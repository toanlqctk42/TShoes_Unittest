using System;
using System.Drawing;
using System.Windows.Forms;

namespace TShoes
{
    public partial class infoSP : DevExpress.XtraEditors.XtraForm
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Mau { get; set; }
        public int Sizes { get; set; }
        public int Soluong { get; set; }
        public string UrlImage { get; set; }
        public infoSP()
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
        }

        private void infoSP_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = MaSP;
            lblTenSP.Text = TenSP;
            lblMau.Text = Mau;
            lblSize.Text = Sizes.ToString();
            lblsoLuong.Text = Soluong.ToString();

            if (UrlImage != "" && UrlImage != null)
                pcHinhanh.Image = Image.FromFile(UrlImage);
            else pcHinhanh.Image = null;
           
        }

        private void infoSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}