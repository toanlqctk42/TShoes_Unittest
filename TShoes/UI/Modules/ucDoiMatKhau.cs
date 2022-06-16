using DTO;
using System;
using System.Windows.Forms;

namespace TShoes.UI.Modules
{
    public partial class ucdoimatkhau : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        public ucdoimatkhau()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if(item.TenTK == Tag.ToString() && txtMatkhaucu.Text == DBConTExt.Decodepass(item.MatKhau) && txtmatkhaumoi.Text == txtxacnhanmatkhau.Text)
                {
                    item.MatKhau = DBConTExt.Encodepass(txtmatkhaumoi.Text);
                    DBConTExt.SaveAccount(item);
                    MessageBox.Show("Lưu Mật Khẩu thành công !!!", "Chúc Mừng");
                    return;
                }

            }
            MessageBox.Show("Lưu mật khẩu không thành công , vui lòng thử lại", "Lỗi");
            cmdHuy.PerformClick();

        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            txtMatkhaucu.Text = "";
            txtmatkhaumoi.Text = "";
            txtxacnhanmatkhau.Text = "";
        }

        private void ucdoimatkhau_Load(object sender, EventArgs e)
        {
            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if (item.TenTK == Tag.ToString())
                {
                    lblTenTK.Text = item.TenTK;
                    lblFullName.Text = item.Fullname;
                    lblNgayKichHoat.Text = item.Ngaykhoitao.ToShortDateString() ;
                    lblChucVu.Text = DBConTExt.GetTenChucVu(item.Chucvu_ID);
                    return;
                }

            }
        }
    }
}
