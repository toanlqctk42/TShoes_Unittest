using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TShoes
{
    public partial class ThongTinSanPham : DevExpress.XtraEditors.XtraForm
    {
        public SanPham sanPham { get; set; }

        public List<ChiTietSanPham> chiTietSanPhams { get; set; }

        public ThongTinSanPham()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            chiTietSanPhams = new List<ChiTietSanPham>();
        }

        private void ThongTinSanPham_Load(object sender, EventArgs e)
        {
            if (sanPham.SanPhamID != 0)
            {
                txtID.Text = sanPham.SanPhamID.ToString();
                txtMaSP.Text = sanPham.MaSanPham;
                txtTenSP.Text = sanPham.TenSanPham;
                cboNhomSP.Text = DBConTExt.GetTenNhomSP(sanPham.NhomSP_ID);
                cboThuongHieu.Text = DBConTExt.GetTenThuongHieu(sanPham.ThuongHieu_ID);
                mskGiaNhap.Text = sanPham.GiaNhap.ToString();
                mskGiaBan.Text = sanPham.Giaban.ToString();
                chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
                if (chiTietSanPhams.Count == 0)
                {
                    chiTietSanPhamBindingSource.AddNew();
                    chiTietSanPhamBindingSource.ResetBindings(true);
                }
            }
            else
            {
                txtID.Text = sanPham.SanPhamID.ToString();
                chiTietSanPhamBindingSource.AddNew();
                chiTietSanPhamBindingSource.ResetBindings(true);
            }

            LoadCBNhomSP();
            LoadCBThuongHieu();

            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (sp != null && sp.ImgURL != "" && sp.ImgURL != null)
                pcbHinh.Image = Image.FromFile(sp.ImgURL);
            else pcbHinh.Image = null;
        }

        void LoadCBNhomSP()
        {
            cboNhomSP.DataSource = DBConTExt.GetAllNhomSP();
            cboNhomSP.DisplayMember = "TenNhomSP";
            cboNhomSP.ValueMember = "NhomSPID";
        }

        void LoadCBThuongHieu()
        {
            cboThuongHieu.DataSource = DBConTExt.GetAllThuongHieu();
            cboThuongHieu.DisplayMember = "TenThuongHieu";
            cboThuongHieu.ValueMember = "ThuongHieuID";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pcbHinh.Image = Image.FromFile(open.FileName);
                    ChiTietSanPham ctsp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
                    if (ctsp != null)
                    {
                        ctsp.ImgURL = open.FileName;
                    }
                    txtfilename.Text = open.FileName;
                }
            }
        }

        private void themNhomSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (NhomSP item in DBConTExt.GetAllNhomSP())
            {
                if (item.TenNhomSP == cboNhomSP.Text.TrimEnd())
                {
                    MessageBox.Show("Đã có tên này , không thể thêm được", "Lỗi");
                    return;
                }
            }
            NhomSP nhomSP = new NhomSP() { TenNhomSP = cboNhomSP.Text.TrimEnd() };
            if (DBConTExt.SaveNhomSP(nhomSP))
            {
                MessageBox.Show("Thêm Thành Công", "Chúc mừng");
                LoadCBNhomSP();
            }
            else MessageBox.Show("Thêm Không Thành Công", "Lỗi");
        }

        private void xoaNhomSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chắc chắn muốn xoá  ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            NhomSP nhomSP = new NhomSP();
            foreach (NhomSP item in DBConTExt.GetAllNhomSP())
            {
                if (item.TenNhomSP == cboNhomSP.Text.TrimEnd())
                {
                    nhomSP = item;
                    break;
                }
            }
            foreach (SanPham item in DBConTExt.GetAllSP())
            {
                if(item.NhomSP_ID == nhomSP.NhomspID)
                {
                    MessageBox.Show("Xoá Không Thành Công", "Lỗi");
                    return;
                }    
            }
            if (DBConTExt.Delete(nhomSP))
            {
                MessageBox.Show("Xoá Thành Công", "Chúc mừng");
                LoadCBNhomSP();
            }
            else MessageBox.Show("Xoá Không Thành Công", "Lỗi");
        }

        private void AddThuongHieu_Click(object sender, EventArgs e)
        {
            foreach (ThuongHieu item in DBConTExt.GetAllThuongHieu())
            {
                if (item.TenThuongHieu == cboThuongHieu.Text.TrimEnd())
                {
                    MessageBox.Show("Đã có tên này , không thể thêm được", "Lỗi");
                    return;
                }
            }
            ThuongHieu thuongHieu = new ThuongHieu() { TenThuongHieu = cboThuongHieu.Text.TrimEnd() };
            if (DBConTExt.SaveThuongHieu(thuongHieu))
            {
                MessageBox.Show("Thêm Thành Công", "Chúc mừng");
                LoadCBThuongHieu();
            }
            else MessageBox.Show("Thêm Không Thành Công", "Lỗi");
        }

        private void DeleteThuongHieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chắc chắn muốn xoá  ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ThuongHieu thuongHieu = new ThuongHieu();
            foreach (ThuongHieu item in DBConTExt.GetAllThuongHieu())
            {
                if (item.TenThuongHieu == cboThuongHieu.Text.TrimEnd())
                {
                    thuongHieu = item;
                    break;
                }
            }
            foreach (SanPham item in DBConTExt.GetAllSP())
            {
                if (item.ThuongHieu_ID == thuongHieu.ThuongHieuID)
                {
                    MessageBox.Show("Xoá Không Thành Công", "Lỗi");
                    return;
                }
            }
            if (DBConTExt.Delete(thuongHieu))
            {
                MessageBox.Show("Xoá Thành Công", "Chúc mừng");
                LoadCBThuongHieu();
            }
            else MessageBox.Show("Xoá Không Thành Công", "Lỗi");
        }

        private void mskGiaNhap_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(mskGiaNhap.Text, out num))
            {
                mskGiaNhap.Text = num.ToString();
            }
            else { mskGiaNhap.Text = num.ToString(); MessageBox.Show("Vui lòng nhập số !!"); }
        }

        private void mskGiaBan_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(mskGiaBan.Text, out num))
            {
                mskGiaBan.Text = num.ToString();
            }
            else { mskGiaBan.Text = num.ToString(); MessageBox.Show("Vui lòng nhập số !!"); }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(mskGiaNhap.Text) > Convert.ToInt32(mskGiaBan.Text))
                {
                    MessageBox.Show("Giá nhập không được lớn hơn giá bán , vui lòng nhập lại");
                    mskGiaNhap.Focus();
                    return;
                }
                sanPham.SanPhamID = Convert.ToInt32(txtID.Text);
                sanPham.MaSanPham = txtMaSP.Text.TrimEnd();
                sanPham.TenSanPham = txtTenSP.Text.TrimEnd();
                sanPham.GiaNhap = Convert.ToInt32(mskGiaNhap.Text);
                sanPham.Giaban = Convert.ToInt32(mskGiaBan.Text);
                sanPham.NhomSP_ID = DBConTExt.FindID_NhomSP(cboNhomSP.Text.TrimEnd());
                sanPham.Ngaynhap = DateTime.Now;
                sanPham.Soluong = chiTietSanPhams.Sum(x => x.Soluong);
                sanPham.ThuongHieu_ID = DBConTExt.FindID_ThuongHieu(cboThuongHieu.Text.TrimEnd());
                if (sanPham.SanPhamID == 0)
                {
                    if (DBConTExt.SaveSP(sanPham)!= 0)
                    {
                        foreach (ChiTietSanPham item in chiTietSanPhamBindingSource)
                        {
                            if(item.Mau == null && item.Sizes == 0)
                            {
                                chiTietSanPhams.Remove(item);
                            }
                            else
                            {
                                item.ChitietSPID = 0;
                                item.SanPham_ID = sanPham.SanPhamID;
                                item.MaSP = sanPham.MaSanPham;
                                item.TenSP = sanPham.TenSanPham;
                                item.Kinhdoanh = 1;
                                DBConTExt.SaveChitietSP(item);
                            }

                        }
                        MessageBox.Show("Lưu thành công", "Chúc mừng");
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công", "Lỗi");
                        btnHuy.PerformClick();
                    }
                }
                else
                {
                    DBConTExt.SaveSP(sanPham);
                    foreach (ChiTietSanPham item in chiTietSanPhamBindingSource)
                    {
                        if(item.Mau != null && item.Sizes != 0) 
                        { 
                            item.SanPham_ID = sanPham.SanPhamID;
                            item.MaSP = sanPham.MaSanPham;
                            item.TenSP = sanPham.TenSanPham;
                            item.Kinhdoanh = 1;
                            DBConTExt.SaveChitietSP(item);
                        }
                    }
                    MessageBox.Show("Lưu thành công", "Chúc mừng");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietSanPham chiTietSanPham = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (chiTietSanPham.ChitietSPID != 0)
            {
                foreach (ChiTietSanPham item in chiTietSanPhams)
                {
                    if (chiTietSanPham.ChitietSPID == item.ChitietSPID)
                    {
                        foreach (ChiTietSanPham chiTiet in DBConTExt.GetAll_ChitietSP())
                        {
                            if (chiTietSanPham.MaSP == chiTiet.MaSP && chiTietSanPham.TenSP == chiTiet.TenSP && chiTietSanPham.Mau == chiTiet.Mau && chiTietSanPham.Sizes == chiTiet.Sizes)
                            {
                                return;
                            }
                        }
                        chiTietSanPhams.Remove(item);
                        break;
                        
                    }
                }
            }
            else
            {
                foreach (ChiTietSanPham item in chiTietSanPhams)
                {
                    if(item.Mau == null && item.Sizes == 0)
                    {
                        chiTietSanPhams.Remove(item);
                        break;
                    }    
                }
                foreach (ChiTietSanPham item in DBConTExt.GetAll_ChitietSP_TheoID(sanPham.SanPhamID))
                {
                    if (chiTietSanPham.Mau == item.Mau && chiTietSanPham.Sizes == item.Sizes && chiTietSanPham.ImgURL == item.ImgURL)
                    {
                        DBConTExt.Delete(item);
                    }
                }
            }
            chiTietSanPhamBindingSource.DataSource = chiTietSanPhams;
            chiTietSanPhamBindingSource.ResetBindings(true);
        }

        private void dgvchitietsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (ChiTietSanPham item in chiTietSanPhamBindingSource)
            {
                int i = 0;
                if(item.ChitietSPID == 0 || item.Mau == null)
                {
                    i++;
                    if (i == 2)
                    {
                        return;
                    }
                }    
            }

            ChiTietSanPham chiTietSanPham = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            chiTietSanPham.ChitietSPID = chiTietSanPhams.Count;
            if (chiTietSanPham != null && chiTietSanPham.ImgURL != "" && chiTietSanPham.ImgURL != null)
                pcbHinh.Image = Image.FromFile(chiTietSanPham.ImgURL);
            else pcbHinh.Image = null;
            
            if(chiTietSanPham.Mau == null)
            {
                chiTietSanPhamBindingSource.RemoveCurrent();
                chiTietSanPhamBindingSource.AddNew();
                chiTietSanPhamBindingSource.ResetBindings(true);
            }    
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (sp.ChitietSPID == 0)
            {
                return;
            }
            if (sp.Kinhdoanh == 0)
            {
                KinhDoanhToolStripMenuItem.Text = "Kích hoạt kinh doanh";
            }
            else if (sp.Kinhdoanh == 1)
            {
                KinhDoanhToolStripMenuItem.Text = "Huỷ kinh doanh";
            }
        }

        private void KinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chắc chắn muốn thay đổi  ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ChiTietSanPham sp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
            if (sp.ChitietSPID == 0)
            {
                chiTietSanPhamBindingSource.ResetBindings(true);
                return;
            }
            if (sp.Kinhdoanh == 0)
            {
                sp.Kinhdoanh = 1;
                DBConTExt.SaveChitietSP(sp);
                MessageBox.Show("Kích hoạt kinh doanh Thành Công", "chúc mừng");
            }
            else if (sp.Kinhdoanh == 1)
            {
                sp.Kinhdoanh = 0;
                MessageBox.Show("Huỷ kích hoạt Thành Công", "chúc mừng");
            }
            else
            {
                MessageBox.Show("Đã có lỗi trong quá trình thay đổi , xin kiểm tra lại", "Lỗi");
                return;
            }
            chiTietSanPhamBindingSource.ResetBindings(true);
        }
    }
}