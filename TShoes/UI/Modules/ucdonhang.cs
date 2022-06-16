using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TShoes.UI.Modules
{
    public partial class ucdonhang : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        DBConTExt db = new DBConTExt();
        public ucdonhang()
        {
            InitializeComponent();
            cbTenNV.DataSource = DBConTExt.GetNguoiDungDTOs_TheoTenNV();
            cbTenNV.DisplayMember = "FullName";
            cbTenNV.ValueMember = "TenTK";
            cbTenNV.Text = "";
        }

        List<Bills> bill = new List<Bills>();
        private void ucdonhang_Load(object sender, EventArgs e)
        {
            if(KiemTraAdmin())
            {
                cmdLoadbillsHuy.Visible = true;
            }
            billsBindingSource.DataSource = DBConTExt.GetAllBills_Active();
            bill = DBConTExt.GetAllBills_Active();
            lblTongtienhang.Text = bill.Sum(x => x.TienHang).ToString();
            lblTongdiscount.Text = bill.Sum(x => x.Discount).ToString();
            lblTongcong.Text = bill.Sum(x => x.ToTal).ToString();
            LoadCTSP();
            db.Bill += LoadBills;
        }
        bool KiemTraAdmin()
        {
            if(Tag == null)
            {
                return false;
            }
            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if (item.TenTK == Tag.ToString())
                {
                    if (item.Chucvu_ID == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        void LoadCTSP()
        {
            bill = DBConTExt.GetAllBills_Active();
            chiTietSanPhamBindingSource.DataSource = DBConTExt.getAll_ChitietSP_TheoListBills(bill);
        }
        void LoadBills(List<Bills> bills)
        {
            bill = bills;
            billsBindingSource.DataSource = bills;
            lblTongtienhang.Text = bill.Sum(x => x.TienHang).ToString();
            lblTongdiscount.Text = bill.Sum(x => x.Discount).ToString();
            lblTongcong.Text = bill.Sum(x => x.ToTal).ToString();
            LoadCTSP();
        }

        private void ActiveBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = billsBindingSource.Current as Bills;
            if (bills.BillID == 0 || bills == null)
            {
                return;
            }

            if (bills.Active == 0)
            {
                foreach (BillDetails item in DBConTExt.GetAllBillDetail_TheoIDBIlls(bills.BillID))
                {
                    foreach (ChiTietSanPham chiTietSanPham in DBConTExt.GetAll_ChitietSP())
                    {
                        if (item.ChitietSP_ID == chiTietSanPham.ChitietSPID)
                        {
                            chiTietSanPham.Soluong -= item.Soluong;
                            DBConTExt.SaveChitietSP(chiTietSanPham);
                            SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTietSanPham.SanPham_ID.Value);
                            sanPham.Soluong -= item.Soluong;
                            DBConTExt.SaveSP(sanPham);
                        }
                    }
                }
                bills.Active = 1;
            }
            else if (bills.Active == 1)
            {
                foreach (BillDetails item in DBConTExt.GetAllBillDetail_TheoIDBIlls(bills.BillID))
                {
                    foreach (ChiTietSanPham chiTietSanPham in DBConTExt.GetAll_ChitietSP())
                    {
                        if (item.ChitietSP_ID == chiTietSanPham.ChitietSPID)
                        {
                            chiTietSanPham.Soluong += item.Soluong;
                            DBConTExt.SaveChitietSP(chiTietSanPham);
                            SanPham sanPham = DBConTExt.Tim_SP_TheoID(chiTietSanPham.SanPham_ID.Value);
                            sanPham.Soluong += item.Soluong;
                            DBConTExt.SaveSP(sanPham);
                        }
                    }
                }
                bills.Active = 0;
            }
            DBConTExt.SaveBills(bills);
            LoadBills(DBConTExt.GetAllBills_Active());
        }
        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bills bills = billsBindingSource.Current as Bills;
            if (bills.BillID == 0 || bills == null)
            {
                return;
            }

            DoiTraHang doiTraHang = new DoiTraHang();
            doiTraHang.bills = bills;
            if (doiTraHang.ShowDialog() == DialogResult.OK)
            {
                billsBindingSource.ResetBindings(true);
            }
            bill = DBConTExt.GetAllBills_Active();
            lblTongtienhang.Text = bill.Sum(x => x.TienHang).ToString();
            lblTongdiscount.Text = bill.Sum(x => x.Discount).ToString();
            lblTongcong.Text = bill.Sum(x => x.ToTal).ToString();
        }
        private void cbTenNV_TextChanged(object sender, EventArgs e)
        {
            if (cbTenNV.Text == "")
            {
                ucdonhang_Load(sender, e);
                return;
            }
            billsBindingSource.Clear();
            billsBindingSource.DataSource = DBConTExt.GetBills_TheoTenNV(cbTenNV.Text);
            bill = DBConTExt.GetBills_TheoTenNV(cbTenNV.Text);
            lblTongtienhang.Text = bill.Sum(x => x.TienHang).ToString();
            lblTongdiscount.Text = bill.Sum(x => x.Discount).ToString();
            lblTongcong.Text = bill.Sum(x => x.ToTal).ToString();
            billsBindingSource.ResetBindings(true);
        }

        private void dtpNgaybatdau_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaybatdau.Value.Date > dtpNgayketthuc.Value.Date || dtpNgaybatdau.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Ngày bắt đầu thống kê không thể sau ngày kết thúc thống kê !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgaybatdau.Value = DateTime.Today;
                return;
            }
            dtpNgayketthuc_ValueChanged(sender, e);
        }

        private void dtpNgayketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaybatdau.Value.Date > dtpNgayketthuc.Value.Date || dtpNgayketthuc.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Ngày Kết thúc thống kê không thể trước ngày bắt đầu thống kê !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayketthuc.Value = DateTime.Today;
                return;
            }
            bill.Clear();
            billsBindingSource.Clear();

            if (cbTenNV.Text != "")
            {
                foreach (Bills item in DBConTExt.GetAllBills())
                {
                    if (item.NgaylapBill.Date >= dtpNgaybatdau.Value.Date && item.NgaylapBill.Date <= dtpNgayketthuc.Value.Date && item.TenNhanVien == cbTenNV.Text)
                    {
                        bill.Add(item);
                    }
                }
            }
            else
            {
                foreach (Bills item in DBConTExt.GetAllBills())
                {
                    if (item.NgaylapBill.Date >= dtpNgaybatdau.Value.Date && item.NgaylapBill.Date <= dtpNgayketthuc.Value.Date)
                    {
                        bill.Add(item);
                    }
                }
            }

            billsBindingSource.DataSource = bill;
            lblTongtienhang.Text = bill.Sum(x => x.TienHang).ToString();
            lblTongdiscount.Text = bill.Sum(x => x.Discount).ToString();
            lblTongcong.Text = bill.Sum(x => x.ToTal).ToString();
            billsBindingSource.ResetBindings(true);
        }

        private void contextBills_Opened(object sender, EventArgs e)
        {
            Bills bills = billsBindingSource.Current as Bills;
            if (bills == null || bills.BillID == 0)
            {
                return;
            }
            if (bills.Active == 0)
            {
                ActiveBillsToolStripMenuItem.Text = "Khôi Phục Hoá Đơn";
                deleteBillsToolStripMenuItem.Visible = true;
            }
            else if (bills.Active == 1)
            {
                ActiveBillsToolStripMenuItem.Text = "Xoá Hoá Đơn";
                deleteBillsToolStripMenuItem.Visible = false;
            }
        }

        private void cmdLoadbillsHuy_Click(object sender, EventArgs e)
        {
            LoadBills(DBConTExt.GetAllBills_InActive());
        }

        private void cmdLoadBillsActive_Click(object sender, EventArgs e)
        {
            LoadBills(DBConTExt.GetAllBills_Active());
        }
        int LoadChucVu()
        {
            if (Tag == null)
            {
                return 0;
            }

            foreach (NguoiDung item in DBConTExt.GetAllAccount())
            {
                if (item.TenTK == Tag.ToString() && item.Chucvu_ID == 1)
                {
                    return item.Chucvu_ID;
                }
            }
            return 0;
        }
        private void deleteBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = billsBindingSource.Current as Bills;
            if (bills.BillID == 0 || bills == null)
            {
                return;
            }
            if(LoadChucVu() != 1)
            {
                return;
            }    
            if (bills.Active == 1)
            {
                MessageBox.Show("Không thể xoá bills chưa huỷ kích hoạt");
                return;
            }
            foreach (Bills item in DBConTExt.GetAllBills())
            {
                if (bills.BillID == item.BillID)
                {
                    foreach (BillDetails details in DBConTExt.GetAllBillDetail_TheoIDBIlls(item.BillID))
                    {
                        DBConTExt.Delete(details);
                    }
                    DBConTExt.Delete(item);
                    billsBindingSource.ResetBindings(true);
                    return;
                }
            }
        }

    }
}
