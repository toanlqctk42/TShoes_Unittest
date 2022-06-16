using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TShoes
{
    public partial class DoiTraHang : DevExpress.XtraEditors.XtraForm
    {

        public Bills bills { get; set; }
        public DoiTraHang()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        private List<BillDetails> ListchitietTamThoi = new List<BillDetails>();
        private void DoiTraHang_Load(object sender, EventArgs e)
        {
            ListchitietTamThoi = DBConTExt.GetAllBillDetail_TheoIDBIlls(bills.BillID);
            billDetailsBindingSource.DataSource = ListchitietTamThoi;
            txtTenNhanVien.Text = bills.TenNhanVien;
            txtTenKhachHang.Text = bills.TenKhachHang;
            mktsdtKh.Text = bills.SDTKhachHang;
            txtTienHang.Text = bills.TienHang.ToString();
            nudDiscount.Value = Convert.ToInt32((bills.Discount * 100) / bills.TienHang);
            lblDiscount.Text = bills.Discount.ToString();
            txtToTal.Text = bills.ToTal.ToString();
            DBConTExt db = new DBConTExt();
            LoadSP(DBConTExt.GetAll_ChitietSP());
            db.CTSP += LoadSP;
        }
        void LoadSP(List<ChiTietSanPham> chiTietSanPhams)
        {
            chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
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

        private void rbmasp_CheckedChanged(object sender, EventArgs e)
        {
            lblTimkiem.Text = "Mã Sản Phẩm : ";
        }

        private void rbTenSP_CheckedChanged(object sender, EventArgs e)
        {
            lblTimkiem.Text = "Tên Sản Phẩm";
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                nudSoLuong.Value = 1;
            }
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            nudSoLuong.Maximum = sp.Soluong;
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
            print.NguoiNhan = "";
            print.DiaChi = "";
            print.lblThoiGiandukien.Text = "";
            if (print.ShowDialog() == DialogResult.Yes)
            {
                bills.TenNhanVien = txtTenNhanVien.Text;
                bills.TenKhachHang = txtTenKhachHang.Text;
                bills.NgaylapBill = DateTime.Now;
                bills.SDTKhachHang = mktsdtKh.Text;
                bills.TienHang = Convert.ToDouble(txtTienHang.Text);
                bills.Active = 1;
                bills.ToTal = Convert.ToDouble(txtToTal.Text);
                bills.Discount = Convert.ToDouble(lblDiscount.Text);
                DBConTExt.SaveBills(bills);
                foreach (BillDetails item in billDetailsBindingSource)
                {
                    bool i = false;
                    foreach (BillDetails billDetails in DBConTExt.GetAllBillDetail_TheoIDBIlls(bills.BillID))
                    {
                        if(billDetails.ChitietSP_ID == item.ChitietSP_ID)
                        {
                            billDetails.Soluong = item.Soluong;
                            DBConTExt.SaveBillDetails(billDetails);
                            i = true;
                        }
                    }
                    if(i == false)
                    {
                        item.BillDetailID = 0;
                        item.Bills_ID = bills.BillID;
                        DBConTExt.SaveBillDetails(item);
                    }
                }
                MessageBox.Show("Thêm Bills Thành Công");
            }
            else
            {
                btnhuy.PerformClick();
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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
                    txtToTal.Text = (Convert.ToDouble(txtTienHang.Text) - Convert.ToDouble(lblDiscount.Text)).ToString();
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
            txtToTal.Text = (Convert.ToDouble(txtTienHang.Text) - Convert.ToDouble(lblDiscount.Text)).ToString();
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

            foreach (BillDetails details in DBConTExt.GetAllBillDetail_TheoIDBIlls(bills.BillID))
            {
                if(billDetails.ChitietSP_ID ==  details.ChitietSP_ID)
                {
                    DBConTExt.Delete(details);
                }
            }
            nudDiscount.Enabled = false;
            billDetailsBindingSource.RemoveCurrent();
            billDetailsBindingSource.ResetBindings(true);
            txtTienHang.Text = ListchitietTamThoi.Sum(x => x.Total).ToString();
            txtToTal.Text = (Convert.ToDouble(txtTienHang.Text) - Convert.ToDouble(lblDiscount.Text)).ToString();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (billDetailsBindingSource.Count <= 0)
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

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            SanPham sanpham = DBConTExt.Tim_SP_TheoID(sp.SanPham_ID.Value);
            if (sp.ChitietSPID == 0 || sp.Kinhdoanh == 0)
            {
                return;
            }
            nudSoLuong.Enabled = true;
            if (nudSoLuong.Value >= sp.Soluong)
            {
                MessageBox.Show("Số lượng bạn chọn vượt quá số lượng tồn trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ChiTietSanPham item in DBConTExt.GetAllCTSP_TheoMA(sp.MaSP))
            {
                if(sp.TenSP == item.TenSP && sp.Mau == item.Mau && sp.Sizes == item.Sizes)
                {
                    foreach (BillDetails chitiet in ListchitietTamThoi)
                    {
                        if (chitiet.ChitietSP_ID == item.ChitietSPID)
                        {
                            chitiet.Soluong += Convert.ToInt32(nudSoLuong.Value);
                            billDetailsBindingSource.ResetBindings(true);
                            item.Soluong -= Convert.ToInt32(nudSoLuong.Value);
                            DBConTExt.SaveChitietSP(item);
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
                        ChitietSP_ID = item.ChitietSPID,
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
            }
            
        }
    }
}