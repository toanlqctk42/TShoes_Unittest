using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;


namespace TShoes
{
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm 
    {
        
        
        public frmlogin()
        {
            InitializeComponent();
        }
        string TenTK = "";
        string MatKhau = "";
        int songuoidung = 0;
        List<NguoiDung> ds = new List<NguoiDung>();
        frmHome home = new frmHome();
        private void frmlogin_Load(object sender, EventArgs e)
        {
            ds = DBConTExt.GetAllAccount();
            songuoidung = DBConTExt.NumberAccount();
            home.phanquyen = "user";
            home.Enabled = false;
            home.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.Count == 0)
                {
                    this.Hide();
                    home.Close();
                    frmHome admin = new frmHome();
                    admin.phanquyen = "admin";
                    admin.Enabled = true;
                    admin.Show();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    MessageBox.Show("Vui lòng điền tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool login = false;
                for (int i = 0; i < songuoidung; i++)
                {
                    TenTK = ds[i].TenTK;
                    MatKhau = ds[i].MatKhau;

                    TenTK = TenTK.TrimEnd();
                    MatKhau = MatKhau.TrimEnd();

                    if (txtUser.Text == TenTK && txtPassword.Text == DBConTExt.Decodepass(MatKhau) && ds[i].Active == 1)
                    {
                        login = true;
                        this.Hide();
                        home.Close();
                        frmHome admin = new frmHome();
                        if (ds[i].Chucvu_ID == 1)
                        {
                            admin.phanquyen = "admin";
                        }
                        else
                        {
                            admin.phanquyen = "user";
                        }

                        admin.accountname = TenTK;
                        admin.Enabled = true;
                        if (admin.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                            home.Enabled = false;
                            home.Show();
                        }
                    }
                }
                if (!login)
                {
                    MessageBox.Show("Tài khoảng đăng nhập không tồn tại , vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
		}

		private void btnoff_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
