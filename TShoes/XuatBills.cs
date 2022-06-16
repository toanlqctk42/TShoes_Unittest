using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace TShoes
{
    public partial class XuatBills : DevExpress.XtraEditors.XtraForm
    {
        public string TenNV { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public XuatBills()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
        }
        public List<BillDetails> ListchitietTamThoi = new List<BillDetails>();
        private void XuatBills_Load(object sender, EventArgs e)
		{
            lblTenNV.Text = TenNV;
            lblNgayinBill.Text = DateTime.Now.ToString();
            if (NguoiNhan == "" && DiaChi == "")
            {
                pnNhanHang.Visible = false;
            }
            else
            {
                lblNguoiNhan.Text = NguoiNhan;
                lblDiachi.Text = DiaChi;
                pnNhanHang.Visible = true;
            }
            billDetailsBindingSource.DataSource = ListchitietTamThoi;
        }

		
        private void cmdInBills_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn Huỷ");
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}