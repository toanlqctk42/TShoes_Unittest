using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;

namespace TShoes.UI.Modules
{
    public partial class ucsanpham : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        
        public ucsanpham()
        {
            InitializeComponent();
        }

        private void ucsanpham_Load(object sender, EventArgs e)
        {
            sanPhamBindingSource.DataSource = DBConTExt.GetAllSP();
        }

        void LoadSP(List<SanPham> sp)
        {
            sanPhamBindingSource.Clear();
            sanPhamBindingSource.DataSource = sp;
            sanPhamBindingSource.ResetBindings(true);
        }


        void LoadSPTon(List<ChiTietSanPham> chiTietSanPhams)
        {
            chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
            chiTietSanPhamBindingSource.ResetBindings(true);
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            if (sp.SanPhamID == 0)
            {
                return;
            }
            else
            {
                ThongTinSanPham thongTinSanPham = new ThongTinSanPham();
                thongTinSanPham.Text = "Cập Nhật Sản Phẩm";
                thongTinSanPham.sanPham = sp;
                thongTinSanPham.chiTietSanPhams = DBConTExt.GetAll_ChitietSP_TheoID(sp.SanPhamID);
                if (thongTinSanPham.ShowDialog() == DialogResult.OK)
                {
                    sanPhamBindingSource.Clear();
                    sanPhamBindingSource.DataSource = DBConTExt.GetAllSP();
                    sanPhamBindingSource.ResetBindings(true);
                }
            }
        }

        private void rbTenSP_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
        }

        private void rbmasp_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            sanPhamBindingSource.Clear();
            if (txtTimKiem.Text.Length == 0)
            {
                sanPhamBindingSource.DataSource = DBConTExt.GetAllSP();
                txtTimKiem.Text = "";
                rbmasp.Checked = false;
                rbTenSP.Checked = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (!rbmasp.Checked && !rbTenSP.Checked)
            {
                txtTimKiem.Text = "";
                txtTimKiem.Enabled = false;
                return;
            }
            List<SanPham> sp = new List<SanPham>();
            if (rbmasp.Checked)
            {
                sp = DBConTExt.GetAllSP_TheoMA(txtTimKiem.Text);
            }

            if (rbTenSP.Checked)
            {
                sp = DBConTExt.GetAllSP_TheoTen(txtTimKiem.Text);
            }
            sanPhamBindingSource.DataSource = sp;
        }

        private void nmsoluongthongke_ValueChanged(object sender, EventArgs e)
        {
            if(nmsoluongthongke.Value < 0)
            {
                MessageBox.Show("Số Lượng Thống kê không được bé hơn 0");
                nmsoluongthongke.Value = 1;
                return;
            }
            nmsoluongthongke.Maximum = DBConTExt.GetAll_ChitietSP().Count;
            cbKieuThongKe_TextChanged(sender, e);
        }

        private void cbKieuThongKe_TextChanged(object sender, EventArgs e)
        {
            if(cbKieuThongKe.Text == "")
            {
                chiTietSanPhamBindingSource1.Clear();
            }
            else if(cbKieuThongKe.Text == "Sản Phẩm Tồn Nhiều")
            {
                pnNgay.Visible = false;
                chiTietSanPhamBindingSource1.Clear();
                groupBox2.Text = "Danh sách sản phẩm tồn nhiều nhất";
                chiTietSanPhamBindingSource1.DataSource = DBConTExt.GetAll_SP_TonNhieuNhat((int)nmsoluongthongke.Value);
                chiTietSanPhamBindingSource1.ResetBindings(true);
            }
            else if(cbKieuThongKe.Text == "Sản Phẩm Tồn Ít")
            {
                pnNgay.Visible = false;
                groupBox2.Text = "Danh sách sản phẩm tồn ít nhất";
                chiTietSanPhamBindingSource1.Clear();
                chiTietSanPhamBindingSource1.DataSource = DBConTExt.GetAll_SP_TonItNhat((int)nmsoluongthongke.Value);
                chiTietSanPhamBindingSource1.ResetBindings(true);
            }
            else if (cbKieuThongKe.Text == "Sản Phẩm Bán Chạy")
            {
                pnNgay.Visible = true;
                groupBox2.Text = "Danh Sách sản phẩm bán chạy";
                dtpNgayBatDau_ValueChanged(sender, e);
            }
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Value.Date > dtpNgayKetThuc.Value.Date)
            {
                MessageBox.Show("Ngày bắt Đầu Không được trước Ngày kết Thúc tìm kiếm");
                dtpNgayBatDau.Value = DateTime.Today;
                dtpNgayKetThuc.Value = DateTime.Today;
            }
            dtpNgayKetThuc_ValueChanged(sender, e);
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Value.Date > dtpNgayKetThuc.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không thể sau ngày kết thúc");
                return;
            }
            if (dtpNgayKetThuc.Value.Date > DateTime.Today.Date)
            {
                dtpNgayKetThuc.Value = DateTime.Today;
                MessageBox.Show("Ngày bạn nhập chưa sãy ra");
                return;
            }
            List<ChiTietSanPham> chiTietSanPhams = DBConTExt.Get5SPBanChay_TuDo(dtpNgayBatDau.Value, dtpNgayKetThuc.Value, Convert.ToInt32(nmsoluongthongke.Value));
            chiTietSanPhamBindingSource1.DataSource = chiTietSanPhams;
            chiTietSanPhamBindingSource1.ResetBindings(true);
        }
    }
}
