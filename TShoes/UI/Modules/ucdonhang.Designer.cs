
namespace TShoes.UI.Modules
{
    partial class ucdonhang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextBills = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActiveBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTenNV = new System.Windows.Forms.Panel();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnNgay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdLoadBillsActive = new System.Windows.Forms.Button();
            this.cmdLoadbillsHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongtienhang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongdiscount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTongcong = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.contextBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTenNV.SuspendLayout();
            this.pnNgay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê Bán Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBills
            // 
            this.dgvBills.AutoGenerateColumns = false;
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.ngaylapBillDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.sDTKhachHangDataGridViewTextBoxColumn,
            this.TienHang,
            this.discountDataGridViewTextBoxColumn,
            this.toTalDataGridViewTextBoxColumn});
            this.dgvBills.ContextMenuStrip = this.contextBills;
            this.dgvBills.DataSource = this.billsBindingSource;
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.Location = new System.Drawing.Point(3, 17);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(684, 497);
            this.dgvBills.TabIndex = 2;
            this.dgvBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            this.dgvBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellDoubleClick);
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "BillID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "BillID";
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaylapBillDataGridViewTextBoxColumn
            // 
            this.ngaylapBillDataGridViewTextBoxColumn.DataPropertyName = "NgaylapBill";
            this.ngaylapBillDataGridViewTextBoxColumn.HeaderText = "Ngày Lập Bill";
            this.ngaylapBillDataGridViewTextBoxColumn.Name = "ngaylapBillDataGridViewTextBoxColumn";
            this.ngaylapBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTKhachHangDataGridViewTextBoxColumn
            // 
            this.sDTKhachHangDataGridViewTextBoxColumn.DataPropertyName = "SDTKhachHang";
            this.sDTKhachHangDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTKhachHangDataGridViewTextBoxColumn.Name = "sDTKhachHangDataGridViewTextBoxColumn";
            this.sDTKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TienHang
            // 
            this.TienHang.DataPropertyName = "TienHang";
            this.TienHang.HeaderText = "Tiền Hàng";
            this.TienHang.Name = "TienHang";
            this.TienHang.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toTalDataGridViewTextBoxColumn
            // 
            this.toTalDataGridViewTextBoxColumn.DataPropertyName = "ToTal";
            this.toTalDataGridViewTextBoxColumn.HeaderText = "Tổng";
            this.toTalDataGridViewTextBoxColumn.Name = "toTalDataGridViewTextBoxColumn";
            this.toTalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextBills
            // 
            this.contextBills.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActiveBillsToolStripMenuItem,
            this.deleteBillsToolStripMenuItem});
            this.contextBills.Name = "contextBills";
            this.contextBills.Size = new System.Drawing.Size(198, 48);
            this.contextBills.Opened += new System.EventHandler(this.contextBills_Opened);
            // 
            // ActiveBillsToolStripMenuItem
            // 
            this.ActiveBillsToolStripMenuItem.Name = "ActiveBillsToolStripMenuItem";
            this.ActiveBillsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ActiveBillsToolStripMenuItem.Text = "Delete";
            this.ActiveBillsToolStripMenuItem.Click += new System.EventHandler(this.ActiveBillsToolStripMenuItem_Click);
            // 
            // deleteBillsToolStripMenuItem
            // 
            this.deleteBillsToolStripMenuItem.Name = "deleteBillsToolStripMenuItem";
            this.deleteBillsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deleteBillsToolStripMenuItem.Text = "Xoá Vĩnh Viễn Hoá Đơn";
            this.deleteBillsToolStripMenuItem.Click += new System.EventHandler(this.deleteBillsToolStripMenuItem_Click);
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataSource = typeof(DTO.Bills);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo điều kiện :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnTenNV);
            this.flowLayoutPanel1.Controls.Add(this.pnNgay);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1215, 51);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pnTenNV
            // 
            this.pnTenNV.Controls.Add(this.cbTenNV);
            this.pnTenNV.Controls.Add(this.label4);
            this.pnTenNV.Location = new System.Drawing.Point(3, 3);
            this.pnTenNV.Name = "pnTenNV";
            this.pnTenNV.Size = new System.Drawing.Size(295, 37);
            this.pnTenNV.TabIndex = 2;
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(119, 9);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(153, 21);
            this.cbTenNV.TabIndex = 1;
            this.cbTenNV.TextChanged += new System.EventHandler(this.cbTenNV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhân Viên bán hàng :";
            // 
            // pnNgay
            // 
            this.pnNgay.Controls.Add(this.label3);
            this.pnNgay.Controls.Add(this.dtpNgayketthuc);
            this.pnNgay.Controls.Add(this.label7);
            this.pnNgay.Controls.Add(this.dtpNgaybatdau);
            this.pnNgay.Location = new System.Drawing.Point(304, 3);
            this.pnNgay.Name = "pnNgay";
            this.pnNgay.Size = new System.Drawing.Size(464, 37);
            this.pnNgay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn Ngày Kết thúc :";
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayketthuc.Location = new System.Drawing.Point(352, 8);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.Size = new System.Drawing.Size(94, 21);
            this.dtpNgayketthuc.TabIndex = 2;
            this.dtpNgayketthuc.ValueChanged += new System.EventHandler(this.dtpNgayketthuc_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chọn Ngày bắt đầu :";
            // 
            // dtpNgaybatdau
            // 
            this.dtpNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybatdau.Location = new System.Drawing.Point(124, 9);
            this.dtpNgaybatdau.Name = "dtpNgaybatdau";
            this.dtpNgaybatdau.Size = new System.Drawing.Size(94, 21);
            this.dtpNgaybatdau.TabIndex = 2;
            this.dtpNgaybatdau.ValueChanged += new System.EventHandler(this.dtpNgaybatdau_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdLoadBillsActive);
            this.panel2.Controls.Add(this.cmdLoadbillsHuy);
            this.panel2.Location = new System.Drawing.Point(774, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 37);
            this.panel2.TabIndex = 4;
            // 
            // cmdLoadBillsActive
            // 
            this.cmdLoadBillsActive.Location = new System.Drawing.Point(245, 9);
            this.cmdLoadBillsActive.Name = "cmdLoadBillsActive";
            this.cmdLoadBillsActive.Size = new System.Drawing.Size(157, 23);
            this.cmdLoadBillsActive.TabIndex = 1;
            this.cmdLoadBillsActive.Text = "Xem lại Danh sách Bills";
            this.cmdLoadBillsActive.UseVisualStyleBackColor = true;
            this.cmdLoadBillsActive.Click += new System.EventHandler(this.cmdLoadBillsActive_Click);
            // 
            // cmdLoadbillsHuy
            // 
            this.cmdLoadbillsHuy.Location = new System.Drawing.Point(14, 9);
            this.cmdLoadbillsHuy.Name = "cmdLoadbillsHuy";
            this.cmdLoadbillsHuy.Size = new System.Drawing.Size(175, 23);
            this.cmdLoadbillsHuy.TabIndex = 0;
            this.cmdLoadbillsHuy.Text = "Xem lại Bills đã huỷ";
            this.cmdLoadbillsHuy.UseVisualStyleBackColor = true;
            this.cmdLoadbillsHuy.Visible = false;
            this.cmdLoadbillsHuy.Click += new System.EventHandler(this.cmdLoadbillsHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBills);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 517);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Hoá đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1224, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvsanpham);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 517);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Đã bán ";
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.mauDataGridViewTextBoxColumn,
            this.sizesDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn});
            this.dgvsanpham.DataSource = this.chiTietSanPhamBindingSource;
            this.dgvsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsanpham.Enabled = false;
            this.dgvsanpham.Location = new System.Drawing.Point(3, 17);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsanpham.Size = new System.Drawing.Size(518, 497);
            this.dgvsanpham.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 663);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1224, 49);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTongtienhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 42);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "(VNĐ)";
            // 
            // lblTongtienhang
            // 
            this.lblTongtienhang.AutoSize = true;
            this.lblTongtienhang.Location = new System.Drawing.Point(201, 17);
            this.lblTongtienhang.Name = "lblTongtienhang";
            this.lblTongtienhang.Size = new System.Drawing.Size(13, 13);
            this.lblTongtienhang.TabIndex = 1;
            this.lblTongtienhang.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Tiền Hàng :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblTongdiscount);
            this.panel3.Location = new System.Drawing.Point(382, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 42);
            this.panel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "(VNĐ)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng Tiền Discount :";
            // 
            // lblTongdiscount
            // 
            this.lblTongdiscount.AutoSize = true;
            this.lblTongdiscount.Location = new System.Drawing.Point(214, 17);
            this.lblTongdiscount.Name = "lblTongdiscount";
            this.lblTongdiscount.Size = new System.Drawing.Size(35, 13);
            this.lblTongdiscount.TabIndex = 1;
            this.lblTongdiscount.Text = "label5";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblTongcong);
            this.panel4.Location = new System.Drawing.Point(795, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 42);
            this.panel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "(VNĐ)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tổng Tiền Thực Thu :";
            // 
            // lblTongcong
            // 
            this.lblTongcong.AutoSize = true;
            this.lblTongcong.Location = new System.Drawing.Point(206, 17);
            this.lblTongcong.Name = "lblTongcong";
            this.lblTongcong.Size = new System.Drawing.Size(35, 13);
            this.lblTongcong.TabIndex = 1;
            this.lblTongcong.Text = "label5";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 143);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1218, 517);
            this.splitContainer1.SplitterDistance = 690;
            this.splitContainer1.TabIndex = 9;
            // 
            // chiTietSanPhamBindingSource
            // 
            this.chiTietSanPhamBindingSource.DataSource = typeof(DTO.ChiTietSanPham);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // mauDataGridViewTextBoxColumn
            // 
            this.mauDataGridViewTextBoxColumn.DataPropertyName = "Mau";
            this.mauDataGridViewTextBoxColumn.HeaderText = "Màu";
            this.mauDataGridViewTextBoxColumn.Name = "mauDataGridViewTextBoxColumn";
            // 
            // sizesDataGridViewTextBoxColumn
            // 
            this.sizesDataGridViewTextBoxColumn.DataPropertyName = "Sizes";
            this.sizesDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizesDataGridViewTextBoxColumn.Name = "sizesDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // ucdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucdonhang";
            this.Size = new System.Drawing.Size(1224, 712);
            this.Load += new System.EventHandler(this.ucdonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.contextBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnTenNV.ResumeLayout(false);
            this.pnTenNV.PerformLayout();
            this.pnNgay.ResumeLayout(false);
            this.pnNgay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextBills;
        private System.Windows.Forms.ToolStripMenuItem ActiveBillsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Panel pnNgay;
        private System.Windows.Forms.Panel pnTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdLoadBillsActive;
        private System.Windows.Forms.Button cmdLoadbillsHuy;
        private System.Windows.Forms.ToolStripMenuItem deleteBillsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongtienhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongdiscount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTongcong;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource;
    }
}
