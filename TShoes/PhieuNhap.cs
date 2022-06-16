using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;

namespace TShoes
{
    public partial class PhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public NhapHang nhap { get; set; }

        public PhieuNhap()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        List<ChiTietSanPham> chiTietSanPhams = new List<ChiTietSanPham>();
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            if(nhap.NhapHangID != 0 || nhap == null)
            {
                Text = "Cập Nhật Phiếu Nhập Hàng";
                txtNguonHang.Text = nhap.NguonHang;
                if(nhap.Ghichu != null)
                {
                    txtGhiChu.Text = nhap.Ghichu;
                }
                else
                {
                    txtGhiChu.Text = "";
                }
                chiTietSanPhams = DBConTExt.GetAll_chitietSP_TheoNhapHang(nhap.NhapHangID);
                chiTietSanPhamBindingSource1.DataSource = chiTietSanPhams;
                txtTongTienHang.Text = DBConTExt.TongTienNhapHang(chiTietSanPhams).ToString();
                txtChiPhiKhac.Text = nhap.ChiPhiKhac.ToString();
                txtPhiVanChuyen.Text = nhap.Phivanchuyen.ToString();
                txtThue.Text = nhap.Thue.ToString();
                lblTongSoLuong.Text = chiTietSanPhams.Sum(x => x.Soluong).ToString();
                txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
            }
            else
            {
                Text = "Thêm Phiếu Nhập Hàng";
            }
            chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAll_ChitietSP();
            DBConTExt db = new DBConTExt();
            db.CTSP += LoadSP;
        }

        void LoadSP(List<ChiTietSanPham> chiTietSanPhams)
        {
            chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
        }

        private void dgvchitietsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietSanPham chiTietSanPham = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (chiTietSanPham.ChitietSPID == 0 || chiTietSanPham == null)
            {
                return;
            }
            foreach (ChiTietSanPham item in chiTietSanPhamBindingSource1)
            {
                if (chiTietSanPham.MaSP == item.MaSP && chiTietSanPham.TenSP == item.TenSP && chiTietSanPham.Mau == item.Mau && chiTietSanPham.Sizes == item.Sizes)
                {
                    item.Soluong += Convert.ToInt32(nudSoLuong.Value);
                    chiTietSanPhamBindingSource1.ResetBindings(true);
                    lblTongSoLuong.Text = chiTietSanPhams.Sum(x => x.Soluong).ToString();
                    txtTongTienHang.Text = DBConTExt.TongTienNhapHang(chiTietSanPhams).ToString();
                    txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
                    return;
                }
            }
            chiTietSanPham.Soluong = 0;
            chiTietSanPham.Soluong += Convert.ToInt32(nudSoLuong.Value);
            chiTietSanPhams.Add(chiTietSanPham);
            chiTietSanPhamBindingSource1.DataSource = chiTietSanPhams;
            chiTietSanPhamBindingSource1.ResetBindings(true);
            txtTongTienHang.Text = DBConTExt.TongTienNhapHang(chiTietSanPhams).ToString();
            lblTongSoLuong.Text = chiTietSanPhams.Sum(x => x.Soluong).ToString();
            txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng không được bé hơn bằng 0", "Lỗi");
                nudSoLuong.Value = 1;
            }
        }

        private void txtChiPhiKhac_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtChiPhiKhac.Text, out num))
            {
                txtChiPhiKhac.Text = num.ToString();
            }
            else { txtChiPhiKhac.Text = num.ToString(); MessageBox.Show("Vui lòng nhập số !!"); }

            txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
        }

        private void txtPhiVanChuyen_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtPhiVanChuyen.Text, out num))
            {
                txtPhiVanChuyen.Text = num.ToString();
            }
            else { txtPhiVanChuyen.Text = num.ToString(); MessageBox.Show("Vui lòng nhập số !!"); }

            txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtThue.Text, out num))
            {
                txtThue.Text = num.ToString();
            }
            else { txtThue.Text = num.ToString(); MessageBox.Show("Vui lòng nhập số !!"); }

            txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (txtNguonHang.Text == "")
            {
                MessageBox.Show("Vui Lòng không để trống nguồn Hàng");
                return;
            }
            if (nhap.NhapHangID == 0)
            {
                nhap = new NhapHang()
                {
                    ngaynhap = DateTime.Today,
                    Ghichu = txtGhiChu.Text,
                    NguonHang = txtNguonHang.Text.TrimEnd(),
                    Tienhang = Convert.ToDouble(txtTongTienHang.Text),
                    Phivanchuyen = Convert.ToDouble(txtPhiVanChuyen.Text),
                    Thue = Convert.ToDouble(txtThue.Text),
                    ChiPhiKhac = Convert.ToDouble(txtChiPhiKhac.Text),
                    Thanhtien = Convert.ToDouble(txtTongCong.Text)
                };
            }
            else
            {
                nhap.ngaynhap = DateTime.Today;
                nhap.Ghichu = txtGhiChu.Text;
                nhap.NguonHang = txtNguonHang.Text.TrimEnd();
                nhap.Tienhang = Convert.ToDouble(txtTongTienHang.Text);
                nhap.Phivanchuyen = Convert.ToDouble(txtPhiVanChuyen.Text);
                nhap.Thue = Convert.ToDouble(txtThue.Text);
                nhap.ChiPhiKhac = Convert.ToDouble(txtChiPhiKhac.Text);
                nhap.Thanhtien = Convert.ToDouble(txtTongCong.Text);
            }

            if (DBConTExt.SaveNhapHang(nhap) == 0)
            {
                MessageBox.Show("Không Thể Lưu Phiếu Nhập", "Lỗi");
                return;
            }

            foreach (ChiTietSanPham item in chiTietSanPhamBindingSource1)
            {
                foreach (ChiTietSanPham chiTiet in DBConTExt.GetAllCTSP_TheoMA(item.MaSP))
                {
                    if (item.TenSP == chiTiet.TenSP && item.Mau == chiTiet.Mau && item.Sizes == chiTiet.Sizes)
                    {
                        if (DBConTExt.GetAll_chitietSP_TheoNhapHang(nhap.NhapHangID).Count == 0)
                        {
                            SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTiet.SanPham_ID.Value);
                            ChitietNhapHang chitietNhapHang = new ChitietNhapHang()
                            {
                                NhapHang_ID = nhap.NhapHangID,
                                ChitietsanPham_ID = chiTiet.ChitietSPID,
                                DonGia = sanPham.GiaNhap,
                                SoLuongNhap = item.Soluong
                            };
                            chiTiet.Soluong += item.Soluong;
                            DBConTExt.SaveChitietSP(chiTiet);
                            sanPham.Soluong += item.Soluong;
                            DBConTExt.SaveSP(sanPham);
                            DBConTExt.SaveCTNhapHang(chitietNhapHang);
                        }
                        else
                        {
                            bool i = false;
                            foreach (ChiTietSanPham chiTietSanPham in DBConTExt.GetAll_chitietSP_TheoNhapHang(nhap.NhapHangID))
                            {
                                if (chiTietSanPham.ChitietSPID == chiTiet.ChitietSPID)
                                {
                                    foreach (ChitietNhapHang chitietNhapHang in DBConTExt.GetAll_ChiTietNhapHang_TheoIDNhapHang(nhap.NhapHangID))
                                    {
                                        if (chitietNhapHang.ChitietsanPham_ID == chiTietSanPham.ChitietSPID)
                                        {

                                            SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTiet.SanPham_ID.Value);
                                            chiTiet.Soluong -= chitietNhapHang.SoLuongNhap;
                                            DBConTExt.SaveChitietSP(chiTiet);
                                            sanPham.Soluong -= chitietNhapHang.SoLuongNhap;
                                            chitietNhapHang.SoLuongNhap = item.Soluong;
                                            DBConTExt.SaveCTNhapHang(chitietNhapHang);
                                            chiTiet.Soluong += item.Soluong;
                                            DBConTExt.SaveChitietSP(chiTiet);
                                            sanPham.Soluong += item.Soluong;
                                            DBConTExt.SaveSP(sanPham);
                                            i = true;
                                        }
                                    }
                                    
                                }
                            }
                            if (i == false)
                            {
                                SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTiet.SanPham_ID.Value);
                                ChitietNhapHang chitietNhapHang = new ChitietNhapHang()
                                {
                                    NhapHang_ID = nhap.NhapHangID,
                                    ChitietsanPham_ID = chiTiet.ChitietSPID,
                                    DonGia = sanPham.GiaNhap,
                                    SoLuongNhap = item.Soluong
                                };
                                DBConTExt.SaveCTNhapHang(chitietNhapHang);
                                chiTiet.Soluong += item.Soluong;
                                DBConTExt.SaveChitietSP(chiTiet);
                                sanPham.Soluong += item.Soluong;
                                DBConTExt.SaveSP(sanPham);
                            }
                        }
                        break;
                    }    
                }
            }
            MessageBox.Show("Lưu Thành Công Phiếu Nhập");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvspnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietSanPham chiTietSanPham = chiTietSanPhamBindingSource1.Current as ChiTietSanPham;
            if (chiTietSanPham.ChitietSPID == 0)
            {
                return;
            }

            foreach (ChiTietSanPham item in chiTietSanPhamBindingSource1)
            {
                if (item.MaSP == chiTietSanPham.MaSP && item.TenSP == chiTietSanPham.TenSP && item.Mau == chiTietSanPham.Mau && item.Sizes == chiTietSanPham.Sizes)
                {
                    if(nhap.NhapHangID == 0)
                    {
                        chiTietSanPhams.Remove(item);
                        chiTietSanPhamBindingSource1.DataSource = chiTietSanPhams;
                        chiTietSanPhamBindingSource1.ResetBindings(true);
                        if (chiTietSanPhamBindingSource1.Count == 0)
                        {
                            lblTongSoLuong.Text = "0";
                        }
                        else
                        {
                            lblTongSoLuong.Text = chiTietSanPhams.Sum(x => x.Soluong).ToString();
                        }
                        txtTongTienHang.Text = DBConTExt.TongTienNhapHang(chiTietSanPhams).ToString();
                        txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
                        return;
                    }
                    else
                    {
                        foreach (ChiTietSanPham chiTiet in DBConTExt.GetAll_chitietSP_TheoNhapHang(nhap.NhapHangID))
                        {
                            if(chiTietSanPham.ChitietSPID == chiTiet.ChitietSPID)
                            {
                                foreach (ChitietNhapHang chitietNhapHang in DBConTExt.GetAll_ChiTietNhapHang_TheoIDNhapHang(nhap.NhapHangID))
                                {
                                    if(chitietNhapHang.ChitietsanPham_ID == chiTiet.ChitietSPID)
                                    {
                                        SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTiet.SanPham_ID.Value);
                                        chiTiet.Soluong -= chitietNhapHang.SoLuongNhap;
                                        DBConTExt.SaveChitietSP(chiTiet);
                                        sanPham.Soluong -= chitietNhapHang.SoLuongNhap;
                                        DBConTExt.SaveSP(sanPham);
                                        DBConTExt.Delete(chitietNhapHang);
                                    }
                                }
                            }
                        }
                        chiTietSanPhams.Remove(item);
                        chiTietSanPhamBindingSource1.DataSource = chiTietSanPhams;
                        chiTietSanPhamBindingSource1.ResetBindings(true);
                        if (chiTietSanPhamBindingSource1.Count == 0)
                        {
                            lblTongSoLuong.Text = "0";
                        }
                        else
                        {
                            lblTongSoLuong.Text = chiTietSanPhams.Sum(x => x.Soluong).ToString();
                        }
                        txtTongTienHang.Text = DBConTExt.TongTienNhapHang(chiTietSanPhams).ToString();
                        txtTongCong.Text = (Convert.ToDouble(txtTongTienHang.Text) + Convert.ToDouble(txtPhiVanChuyen.Text) + Convert.ToDouble(txtThue.Text) + Convert.ToDouble(txtChiPhiKhac.Text)).ToString();
                        return;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (!rbmasp.Checked && !rbTenSP.Checked)
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm");
                return;
            }
            else if (rbmasp.Checked)
            {
                chiTietSanPhamBindingSource.Clear();
                chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAllCTSP_TheoMA(txtTimKiem.Text);
                chiTietSanPhamBindingSource.ResetBindings(true);
            }
            else if (rbTenSP.Checked)
            {
                chiTietSanPhamBindingSource.Clear();
                chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAllCTSP_TheoTen(txtTimKiem.Text);
                chiTietSanPhamBindingSource.ResetBindings(true);
            }
        }

        private void cmdThemSP_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            ThongTinSanPham thongTinSanPham = new ThongTinSanPham();
            thongTinSanPham.Text = "Thêm Sản Phẩm Mới";
            thongTinSanPham.sanPham = sp;
            if (thongTinSanPham.ShowDialog() == DialogResult.OK)
            {
                LoadSP(DBConTExt.GetAll_ChitietSP());
            }
        }
    }
}