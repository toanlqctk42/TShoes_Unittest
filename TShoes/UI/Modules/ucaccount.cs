using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DTO;

namespace TShoes.UI.Modules
{
    public partial class ucaccount : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        public ucaccount()
        {
            InitializeComponent();
        }

        
        private void ucaccount_Load(object sender, EventArgs e)
        {
            LoadChucvu(DBConTExt.GetAllChucvu());
            nguoiDungBindingSource.DataSource = DBConTExt.GetAllAccount();
            cbTenNV.DataSource = DBConTExt.GetNguoiDungDTOs_TheoTenNV();
            cbTenNV.DisplayMember = "FullName";
            cbTenNV.ValueMember = "TenTK";
            cbTenNV.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDung account = nguoiDungBindingSource.Current as NguoiDung;
                if( account.MatKhau == null )
                {
                    account.MatKhau = DBConTExt.Encodepass("123");
                    account.Ngaykhoitao = DateTime.Now;
                    account.Active = 1;
                }    
                if(DBConTExt.SaveAccount(account))
                {
                    MessageBox.Show("Lưu Thành Công", "Chúc Mừng");
                    ucaccount_Load(sender,e);
                }
                else MessageBox.Show("Lưu Không Thành Công", "Lỗi");
            }
            catch (Exception ex)
            {
                ucaccount_Load(sender, e);
                MessageBox.Show(ex.Message);
            }
            pncreate.Enabled = false;
            dgvAccout.Enabled = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            pncreate.Enabled = false;
            nguoiDungBindingSource.ResetBindings(false);
            ucaccount_Load(sender, e);
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            dgvAccout.Enabled = true;
            cbTenNV.Enabled = true;
        }

        void LoadChucvu(List<ChucVu> chucVus)
        {
            cbochucvu.DataSource = chucVus;
            cbochucvu.DisplayMember = "Tenchucvu";
            cbochucvu.ValueMember = "ChucVuID";
        }
       
        private void Addchucvu_Click(object sender, EventArgs e)
        {
            foreach (ChucVu item in DBConTExt.GetAllChucvu())
            {
                if (item.TenChucVu == cbochucvu.Text)
                {
                    MessageBox.Show("Đã có tên này , không thể thêm được", "Lỗi");
                    return;
                }
            }
            ChucVu chucvu = new ChucVu() { TenChucVu = cbochucvu.Text };
            if (DBConTExt.SaveChucVU(chucvu))
            {
                MessageBox.Show("Thêm Thành Công", "Chúc mừng");
                LoadChucvu(DBConTExt.GetAllChucvu());
            }
            else MessageBox.Show("Thêm Không Thành Công", "Lỗi");
        }

        private void Deletechucvu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chắc chắn muốn xoá  ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ChucVu chucvu = new ChucVu() { TenChucVu = cbochucvu.Text };
            foreach (ChucVu item in DBConTExt.GetAllChucvu())
            {
                if (item.TenChucVu == cbochucvu.Text)
                {
                    chucvu = item;
                    break;
                }
            }

            if (DBConTExt.Delete(chucvu))
            {
                MessageBox.Show("Xoá Thành Công", "Chúc mừng");
                LoadChucvu(DBConTExt.GetAllChucvu());
            }
            else MessageBox.Show("Xoá Không Thành Công", "Lỗi");
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung account = nguoiDungBindingSource.Current as NguoiDung;
            if (DBConTExt.ResetPassword(account))
            {
                MessageBox.Show("Reset Mật Khẩu Thành công","Chúc mừng");
                ucaccount_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Reset Mật Khẩu Không Thành công", "Lỗi");
            }
        }

        private void cbTenNV_TextChanged(object sender, EventArgs e)
        {
            nguoiDungBindingSource.Clear();
            if (cbTenNV.Text == "")
            {
                nguoiDungBindingSource.DataSource = DBConTExt.GetAllAccount();
                return;
            }
            List<NguoiDung> nguoiDungDTOs = new List<NguoiDung>();
            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if (item.Fullname == cbTenNV.Text)
                {
                    nguoiDungDTOs.Add(item);
                }
            }
            nguoiDungBindingSource.DataSource = nguoiDungDTOs;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            NguoiDung nguoiDungs = nguoiDungBindingSource.Current as NguoiDung;
            if (nguoiDungs.Active == 0)
            {
                ActiveToolStripMenuItem.Text = "Kích Hoạt";
            }
            else { ActiveToolStripMenuItem.Text = "Huỷ Kích Hoạt"; }
        }

        private void ActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDung nguoiDung = nguoiDungBindingSource.Current as NguoiDung;
                if (nguoiDung.Active == 0)
                {
                    if (MessageBox.Show("Bạn có chắc muốn kích hoạt tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nguoiDung.Active = 1;
                        DBConTExt.SaveAccount(nguoiDung);
                        MessageBox.Show("Bạn đã lưu thành công");
                        return;
                    }
                    else
                    {
                        contextMenuStrip1.Close();
                    }
                }
                else if (nguoiDung.Active == 1)
                {
                    if (MessageBox.Show("Bạn có chắc muốn huỷ kích hoạt tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nguoiDung.Active = 0;
                        DBConTExt.SaveAccount(nguoiDung);
                        MessageBox.Show("Bạn đã lưu thành công");
                        return;
                    }
                    else
                    {
                        contextMenuStrip1.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NguoiDung nguoiDung = nguoiDungBindingSource.Current as NguoiDung;
            if(nguoiDung.TenTK == "" || nguoiDung.TenTK == null)
            {
                pncreate.Enabled = true;
                nguoiDungBindingSource.AddNew();
                nguoiDungBindingSource.MoveLast();
                txtTendangnhap.Focus();
                btnLuu.Visible = true;
                btnHuy.Visible = true;
                dgvAccout.Enabled = false;
                cbTenNV.Enabled = false;
            }
            else
            {
                pncreate.Enabled = true;
                btnLuu.Visible = true;
                btnHuy.Visible = true;
            }
        }
    }
}
