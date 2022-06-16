using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TShoes.UI.Modules
{
    public partial class DSPhieuNhap : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        public DSPhieuNhap()
        {
            InitializeComponent();
        }
        List<NhapHang> nhapHangs = new List<NhapHang>();
        private void DSPhieuNhap_Load(object sender, EventArgs e)
        {
            nhapHangBindingSource.DataSource = DBConTExt.GetAll_NhapHang();
            nhapHangs = DBConTExt.GetAll_NhapHang();
            if(nhapHangBindingSource.Count > 0)
            {
                NhapHang nhapHang = nhapHangBindingSource.Current as NhapHang;
                if(nhapHang.NhapHangID == 0)
                {
                    return;
                }/*
                chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAll_chitietSP_TheoNhapHang(nhapHang.NhapHangID);*/
            }    
           
            lblTienHang.Text = nhapHangs.Sum(x => x.Tienhang).ToString();
            lblTienShip.Text = nhapHangs.Sum(x => x.Phivanchuyen).ToString();
            lblchiphikhac.Text = nhapHangs.Sum(x => x.ChiPhiKhac).ToString();
            lblThue.Text = nhapHangs.Sum(x => x.Thue).ToString();
            lblTongTien.Text = nhapHangs.Sum(x => x.Thanhtien).ToString();

            DBConTExt db = new DBConTExt();
            db.NhapHang += LoadPhieuNhap;
        }
        void LoadPhieuNhap(List<NhapHang> nhapHangs)
        {
            nhapHangBindingSource.DataSource = nhapHangs;
            nhapHangBindingSource.ResetBindings(true);
            if (nhapHangBindingSource.Count > 0)
            {
                NhapHang nhapHang = nhapHangBindingSource.Current as NhapHang;
                if (nhapHang.NhapHangID == 0)
                {
                    return;
                }/*
                chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAll_chitietSP_TheoNhapHang(nhapHang.NhapHangID);*/
            }

            lblTienHang.Text = nhapHangs.Sum(x => x.Tienhang).ToString();
            lblTienShip.Text = nhapHangs.Sum(x => x.Phivanchuyen).ToString();
            lblchiphikhac.Text = nhapHangs.Sum(x => x.ChiPhiKhac).ToString();
            lblThue.Text = nhapHangs.Sum(x => x.Thue).ToString();
            lblTongTien.Text = nhapHangs.Sum(x => x.Thanhtien).ToString();
        }
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhapHang nhapHang = nhapHangBindingSource.Current as NhapHang;
            PhieuNhap phieuNhap = new PhieuNhap();
            if (nhapHang.NhapHangID == 0)
            {
                /*return;*/
                phieuNhap.nhap = new NhapHang();
            }
            else
            {
                phieuNhap.nhap = nhapHang;
            }
            phieuNhap.ShowDialog();
            LoadPhieuNhap(DBConTExt.GetAll_NhapHang());
        }

        private void dtpNgaybatDau_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNgaybatDau.Value.Date > dtpngayketthuc.Value.Date)
            {
                MessageBox.Show("Ngày bắt Đầu Không được trước Ngày kết Thúc tìm kiếm");
                dtpNgaybatDau.Value = DateTime.Today;
                dtpngayketthuc.Value = DateTime.Today;
            }
            dtpngayketthuc_ValueChanged(sender, e);
        }

        private void dtpngayketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpngayketthuc.Value.Date < dtpNgaybatDau.Value.Date || dtpngayketthuc.Value > DateTime.Today)
            {
                MessageBox.Show("Vui lòng chọn lại Ngày kết thúc tìm kiếm");
                dtpNgaybatDau.Value = DateTime.Today;
                dtpngayketthuc.Value = DateTime.Today;
            }
            if (txtNguonHang.Text != "")
            {
                txtNguonHang_TextChanged(sender, e);
                return;
            }
            nhapHangs = DBConTExt.GetAll_NhapHang_TheoKhoangThoiGian(dtpNgaybatDau.Value, dtpngayketthuc.Value);
            nhapHangBindingSource.DataSource = nhapHangs;
            if (nhapHangs.Count != 0)
            {
                lblTienHang.Text = nhapHangs.Sum(x => x.Tienhang).ToString();
                lblTienShip.Text = nhapHangs.Sum(x => x.Phivanchuyen).ToString();
                lblchiphikhac.Text = nhapHangs.Sum(x => x.ChiPhiKhac).ToString();
                lblThue.Text = nhapHangs.Sum(x => x.Thue).ToString();
                lblTongTien.Text = nhapHangs.Sum(x => x.Thanhtien).ToString();
            }
            else
            {
                lblTienHang.Text = "0";
                lblTienShip.Text = "0";
                lblchiphikhac.Text = "0";
                lblThue.Text = "0";
                lblTongTien.Text = "0";
            }
        }
        private void txtNguonHang_TextChanged(object sender, EventArgs e)
        {
            if(txtNguonHang.Text == "")
            {
                dtpngayketthuc_ValueChanged(sender, e);
                return;
            }
            nhapHangs = DBConTExt.GetAll_NhapHang_TheoNguon(DBConTExt.GetAll_NhapHang_TheoKhoangThoiGian(dtpNgaybatDau.Value, dtpngayketthuc.Value), txtNguonHang.Text);
            nhapHangBindingSource.DataSource = nhapHangs;
            if (nhapHangBindingSource.Count == 0)
            {
                chiTietSanPhamBindingSource.Clear();
            }
            else
            {
                NhapHang nhapHang = nhapHangBindingSource.Current as NhapHang;
                if (nhapHang.NhapHangID == 0)
                {
                    return;
                }
                chiTietSanPhamBindingSource.DataSource = DBConTExt.GetAll_chitietSP_TheoNhapHang(nhapHang.NhapHangID);
            }

            lblTienHang.Text = nhapHangs.Sum(x => x.Tienhang).ToString();
            lblTienShip.Text = nhapHangs.Sum(x => x.Phivanchuyen).ToString();
            lblchiphikhac.Text = nhapHangs.Sum(x => x.ChiPhiKhac).ToString();
            lblThue.Text = nhapHangs.Sum(x => x.Thue).ToString();
            lblTongTien.Text = nhapHangs.Sum(x => x.Thanhtien).ToString();
        }

        private void xoaphieunhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhapHangBindingSource.Count == 0)
                {
                    return;
                }
                NhapHang nhap = nhapHangBindingSource.Current as NhapHang;
                if (nhap.NhapHangID == 0 || nhap == null)
                {
                    return;
                }
                foreach (ChitietNhapHang item in DBConTExt.GetAll_ChiTietNhapHang_TheoIDNhapHang(nhap.NhapHangID))
                {
                    foreach (ChiTietSanPham chiTietSanPham in DBConTExt.GetAll_ChitietSP())
                    {
                        if (item.ChitietsanPham_ID == chiTietSanPham.ChitietSPID)
                        {
                            chiTietSanPham.Soluong -= item.SoLuongNhap;
                            SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTietSanPham.SanPham_ID.Value);
                            sanPham.Soluong -= item.SoLuongNhap;
                            DBConTExt.SaveSP(sanPham);
                            DBConTExt.SaveChitietSP(chiTietSanPham);
                        }
                    }
                    DBConTExt.Delete(item);
                }
                DBConTExt.Delete(nhap);
                LoadPhieuNhap(DBConTExt.GetAll_NhapHang());
                MessageBox.Show("Xoá Thành Công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xoá Không Thành Công \n Lỗi : " + ex.Message);
            }
        }
    }
}
