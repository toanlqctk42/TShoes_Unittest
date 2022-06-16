using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TShoes.UI.Modules
{
    public partial class ucBills : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        DBConTExt db = new DBConTExt();
        
        public ucBills()
        {
            InitializeComponent();

        }
        private List<BillDetails> ListchitietTamThoi = new List<BillDetails>();
        private void ucBills_Load(object sender, EventArgs e)
        {
            LoadSP(DBConTExt.GetAll_ChitietSP());
            db.CTSP += LoadSP;
            txtTenNhanVien.Text = LoadTenNhanVien();
            txtTimKiem.Text = "";
        }

        string LoadTenNhanVien()
        {
            if (Tag == null)
            {
                return null;
            }

            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if(item.TenTK == Tag.ToString())
                {
                    return item.Fullname;
                }
            }
            return null;
        }

        void LoadSP(List<ChiTietSanPham> chiTietSanPhams)
        {
            chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if(nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                nudSoLuong.Value = 1;
            }
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            nudSoLuong.Maximum = sp.Soluong;
        }

        private void btnTangSL1_Click(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa Có sản phẩm");
                return;
            }
            BillDetails billDetails = billDetailsBindingSource.Current as BillDetails;

            foreach (ChiTietSanPham item in DBConTExt.GetAll_ChitietSP())
            {
                if (item.ChitietSPID == billDetails.ChitietSP_ID && item.Soluong > 0)
                {
                    billDetails.Soluong += 1;
                    billDetailsBindingSource.ResetBindings(true);
                    item.Soluong -= 1;
                    DBConTExt.SaveChitietSP(item);
                    txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
                    txtToTal.Text = txtTienHang.Text;
                    LoadSP(DBConTExt.GetAll_ChitietSP());
                    return;
                }
            }


        }

        private void btnGiamSL1_Click(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa Có sản phẩm");
                return;
            }
            BillDetails billDetails = billDetailsBindingSource.Current as BillDetails;
            billDetails.Soluong -= 1;
            foreach (ChiTietSanPham item in DBConTExt.GetAll_ChitietSP())
            {
                if (item.ChitietSPID == billDetails.ChitietSP_ID)
                {
                    item.Soluong += 1;
                    DBConTExt.SaveChitietSP(item);
                    break;
                }

            }
            if (billDetails.Soluong == 0)
            {
                btnXoa.PerformClick();
                return;
            }
            billDetailsBindingSource.ResetBindings(true);
            txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
            txtToTal.Text = txtTienHang.Text;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa Có sản phẩm");
                return;
            }
            BillDetails billDetails = billDetailsBindingSource.Current as BillDetails;
            foreach (ChiTietSanPham item in DBConTExt.GetAll_ChitietSP())
            {
                if (item.ChitietSPID == billDetails.ChitietSP_ID)
                {
                    item.Soluong += billDetails.Soluong;
                    DBConTExt.SaveChitietSP(item);
                    break;
                }
            }
            nudDiscount.Enabled = false;
            billDetailsBindingSource.RemoveCurrent();
            billDetailsBindingSource.ResetBindings(true);
            txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
            txtToTal.Text = txtTienHang.Text;
        }


        private void btninbills_Click(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa Có sản phẩm");
                return;
            }

            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập Tên Khách Hàng ");
                txtTenKhachHang.Focus();
                return;
            }
            mktsdtKh.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mktsdtKh.Text == "" || mktsdtKh.Text.Length < 10)
            {
                MessageBox.Show("Số Diện Thoại Không hợp lệ");
                mktsdtKh.Focus();
                return;
            }


            XuatBills print = new XuatBills();
            print.TenNV = txtTenNhanVien.Text;
            print.ListchitietTamThoi = ListchitietTamThoi;
            print.lblTienHang.Text = txtTienHang.Text;
            print.lblDiscount.Text = lblDiscount.Text;
            print.lblTotal.Text = txtToTal.Text;
            print.NguoiNhan = txtNguoiNhan.Text;
            print.DiaChi = txtDiaChi.Text;
            print.lblThoiGiandukien.Text = dtpNgaygiaohangdukien.Text;
            if (print.ShowDialog() == DialogResult.Yes)
            {
                Bills bills = new Bills()
                {
                    TenNhanVien = txtTenNhanVien.Text,
                    TenKhachHang = txtTenKhachHang.Text,
                    NgaylapBill = DateTime.Now,
                    SDTKhachHang = mktsdtKh.Text,
                    TienHang = Convert.ToDouble(txtTienHang.Text),
                    Active = 1,
                    ToTal = Convert.ToDouble(txtToTal.Text),
                    Discount = Convert.ToDouble(lblDiscount.Text)
                };
                int billID = DBConTExt.SaveBills(bills);
                if (billID == 0)
                {
                    MessageBox.Show("Không Thể Thêm Bills Này");
                    return;
                }
                foreach (BillDetails item in billDetailsBindingSource)
                {
                    item.BillDetailID = 0;
                    item.Bills_ID = billID;
                    DBConTExt.SaveBillDetails(item);
                }
                MessageBox.Show("Thêm Bills Thành Công");
            }
            else
            {
                btnhuy.PerformClick();
                return;
            }


            int i = billDetailsBindingSource.Count;
            while (i > 0)
            {
                i--;
                billDetailsBindingSource.RemoveAt(i);
            }
            txtTenKhachHang.Text = "";
            txtTienHang.Text = "";
            txtToTal.Text = "";
            mktsdtKh.Text = "";
            nudDiscount.Value = 0;
        }


        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            if(billDetailsBindingSource.Count <= 0)
            {
                return;
            }
            nudDiscount.Enabled = true;
            if (nudDiscount.Value == 0)
            {
                txtToTal.Text = txtTienHang.Text;
            }
            else
            {
                lblDiscount.Text = ((Convert.ToDouble(txtTienHang.Text) * (double)nudDiscount.Value) / 100).ToString();
                txtToTal.Text = (((Convert.ToDouble(txtTienHang.Text)) - ((Convert.ToDouble(txtTienHang.Text)) * (double)nudDiscount.Value) / 100)).ToString();
            }
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa Có sản phẩm");
                return;
            }
            foreach (ChiTietSanPham item in DBConTExt.GetAll_ChitietSP())
            {
                foreach (BillDetails billDetails in billDetailsBindingSource)
                {
                    if (item.ChitietSPID == billDetails.ChitietSP_ID)
                    {
                        item.Soluong += billDetails.Soluong;
                        DBConTExt.SaveChitietSP(item);
                        SanPham sanPham = DBConTExt.Tim_SP_TheoID(item.SanPham_ID.Value);
                        sanPham.Soluong += billDetails.Soluong;
                        DBConTExt.SaveSP(sanPham);
                        billDetailsBindingSource.Remove(billDetails);
                        break;
                    }
                }
            }
            nudSoLuong.Value = 1;
            txtNguoiNhan.Text = "";
            txtDiaChi.Text = "";
            dtpNgaygiaohangdukien.Value = DateTime.Today;
            txtTenKhachHang.Text = "";
            txtTienHang.Text = "";
            txtToTal.Text = "";
            mktsdtKh.Text = "";
            nudDiscount.Value = 0;
        }

        private void rbmasp_CheckedChanged(object sender, EventArgs e)
        {
            lblTimkiem.Text = "Mã Sản Phẩm : ";
        }

        private void rbTenSP_CheckedChanged(object sender, EventArgs e)
        {
            lblTimkiem.Text = "Tên Sản Phẩm";
        }

        private void dgvsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            SanPham sanpham = DBConTExt.Tim_SP_TheoID(sp.SanPham_ID.Value);
            if (sp.ChitietSPID == 0 || sp.Kinhdoanh == 0)
            {
                return;
            }

            if (nudSoLuong.Value >= sp.Soluong)
            {
                MessageBox.Show("Số lượng bạn chọn vượt quá số lượng tồn trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nudDiscount.Enabled = true;
            foreach (BillDetails chitiet in ListchitietTamThoi)
            {
                if (chitiet.ChitietSP_ID == sp.ChitietSPID)
                {
                    chitiet.Soluong += Convert.ToInt32(nudSoLuong.Value);
                    billDetailsBindingSource.ResetBindings(true);
                    sp.Soluong -= Convert.ToInt32(nudSoLuong.Value);
                    DBConTExt.SaveChitietSP(sp);
                    sanpham.Soluong -= Convert.ToInt32(nudSoLuong.Value);
                    DBConTExt.SaveSP(sanpham);
                    LoadSP(DBConTExt.GetAll_ChitietSP());
                    txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
                    txtToTal.Text = txtTienHang.Text;
                    return;
                }
            }

            BillDetails billDetails = new BillDetails()
            {
                BillDetailID = dgvBilldetails.Rows.Count + 1,
                ChitietSP_ID = sp.ChitietSPID,
                TenSP = sp.TenSP,
                Mau = sp.Mau,
                Sizes = sp.Sizes,
                Giaban = sanpham.Giaban,
                Soluong = Convert.ToInt32(nudSoLuong.Text)
            };

            ListchitietTamThoi.Add(billDetails);
            billDetailsBindingSource.DataSource = ListchitietTamThoi;
            billDetailsBindingSource.ResetBindings(true);
            sp.Soluong -= Convert.ToInt32(nudSoLuong.Value);
            DBConTExt.SaveChitietSP(sp);
            sanpham.Soluong -= Convert.ToInt32(nudSoLuong.Value);
            DBConTExt.SaveSP(sanpham);
            txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
            txtToTal.Text = txtTienHang.Text;
            LoadSP(DBConTExt.GetAll_ChitietSP());
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            chiTietSanPhamBindingSource.Clear();
            if (txtTimKiem.Text == "")
            {
                LoadSP(DBConTExt.GetAll_ChitietSP());
                lblTimkiem.Text = "";
                txtTimKiem.Text = "";
                rbmasp.Checked = false;
                rbTenSP.Checked = false;
                return;
            }

            if (!rbmasp.Checked && !rbTenSP.Checked)
            {
                lblTimkiem.Text = "";
                txtTimKiem.Text = "";
                return;
            }
            List<ChiTietSanPham> sp = new List<ChiTietSanPham>();
            if (rbmasp.Checked)
            {
                sp = DBConTExt.GetAllCTSP_TheoMA(txtTimKiem.Text);
            }

            if (rbTenSP.Checked)
            {
                sp = DBConTExt.GetAllCTSP_TheoTen(txtTimKiem.Text);
            }
            chiTietSanPhamBindingSource.DataSource = sp;
            chiTietSanPhamBindingSource.ResetBindings(true);
        }

        infoSP InfoSP = new infoSP();
        
        private void dgvsanpham_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(chiTietSanPhamBindingSource.Count == 0)
            {
                return;
            }
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (sp.ChitietSPID == 0)
            {
                return;
            }
            if (InfoSP != null && InfoSP.DialogResult == DialogResult.OK)
                InfoSP.Hide();
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (sp.ChitietSPID == 0)
            {
                return;
            }
            if (InfoSP.MaSP != sp.MaSP||InfoSP.TenSP !=sp.TenSP ||InfoSP.Mau !=sp.Mau ||InfoSP.Sizes == sp.Sizes)
            {
                InfoSP = new infoSP();
                InfoSP.MaSP = sp.MaSP;
                InfoSP.TenSP = sp.TenSP;
                InfoSP.Mau = sp.Mau;
                InfoSP.Sizes = sp.Sizes;
                InfoSP.Soluong = sp.Soluong;
                InfoSP.UrlImage = sp.ImgURL;
                InfoSP.Show();
            }
            else
            {
                InfoSP.MaSP = sp.MaSP;
                InfoSP.TenSP = sp.TenSP;
                InfoSP.Mau = sp.Mau;
                InfoSP.Sizes = sp.Sizes;
                InfoSP.Soluong = sp.Soluong;
                InfoSP.UrlImage = sp.ImgURL;
                InfoSP.Show();
            }
        }

        private void dgvBilldetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
