
namespace TShoes.UI.Modules
{
    partial class ucsanpham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbTenSP = new System.Windows.Forms.RadioButton();
            this.rbmasp = new System.Windows.Forms.RadioButton();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.sanPhamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThongKe5SPGanhet = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietSanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmsoluongthongke = new System.Windows.Forms.NumericUpDown();
            this.lblKieuThongKe = new System.Windows.Forms.Label();
            this.pnNgay = new System.Windows.Forms.Panel();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe5SPGanhet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluongthongke)).BeginInit();
            this.pnNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.rbTenSP);
            this.panel1.Controls.Add(this.rbmasp);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 40);
            this.panel1.TabIndex = 10;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Enabled = false;
            this.txtTimKiem.Location = new System.Drawing.Point(18, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(228, 21);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rbTenSP
            // 
            this.rbTenSP.AutoSize = true;
            this.rbTenSP.Location = new System.Drawing.Point(400, 9);
            this.rbTenSP.Name = "rbTenSP";
            this.rbTenSP.Size = new System.Drawing.Size(58, 17);
            this.rbTenSP.TabIndex = 6;
            this.rbTenSP.Text = "Tên SP";
            this.rbTenSP.UseVisualStyleBackColor = true;
            this.rbTenSP.CheckedChanged += new System.EventHandler(this.rbTenSP_CheckedChanged);
            // 
            // rbmasp
            // 
            this.rbmasp.AutoSize = true;
            this.rbmasp.Checked = true;
            this.rbmasp.Location = new System.Drawing.Point(277, 9);
            this.rbmasp.Name = "rbmasp";
            this.rbmasp.Size = new System.Drawing.Size(54, 17);
            this.rbmasp.TabIndex = 5;
            this.rbmasp.TabStop = true;
            this.rbmasp.Text = "Mã SP";
            this.rbmasp.UseVisualStyleBackColor = true;
            this.rbmasp.CheckedChanged += new System.EventHandler(this.rbmasp_CheckedChanged);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AllowDrop = true;
            this.dgvSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanpham.AutoGenerateColumns = false;
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSanpham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanPhamIDDataGridViewTextBoxColumn,
            this.maSanPhamDataGridViewTextBoxColumn,
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dgvSanpham.DataSource = this.sanPhamBindingSource;
            this.dgvSanpham.Location = new System.Drawing.Point(6, 49);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.ReadOnly = true;
            this.dgvSanpham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSanpham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanpham.Size = new System.Drawing.Size(559, 612);
            this.dgvSanpham.TabIndex = 11;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // sanPhamIDDataGridViewTextBoxColumn
            // 
            this.sanPhamIDDataGridViewTextBoxColumn.DataPropertyName = "SanPhamID";
            this.sanPhamIDDataGridViewTextBoxColumn.HeaderText = "SanPhamID";
            this.sanPhamIDDataGridViewTextBoxColumn.Name = "sanPhamIDDataGridViewTextBoxColumn";
            this.sanPhamIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "Ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "Giaban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            this.giabanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soluong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(DTO.SanPham);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1191, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // chiTietSanPhamBindingSource
            // 
            this.chiTietSanPhamBindingSource.DataSource = typeof(DTO.ChiTietSanPham);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvSanpham);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 661);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThongKe5SPGanhet);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 658);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách sản phẩm có số lượng";
            // 
            // dgvThongKe5SPGanhet
            // 
            this.dgvThongKe5SPGanhet.AutoGenerateColumns = false;
            this.dgvThongKe5SPGanhet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe5SPGanhet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThongKe5SPGanhet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe5SPGanhet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn1,
            this.tenSPDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.sizesDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvThongKe5SPGanhet.DataSource = this.chiTietSanPhamBindingSource1;
            this.dgvThongKe5SPGanhet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongKe5SPGanhet.Enabled = false;
            this.dgvThongKe5SPGanhet.Location = new System.Drawing.Point(3, 92);
            this.dgvThongKe5SPGanhet.Name = "dgvThongKe5SPGanhet";
            this.dgvThongKe5SPGanhet.ReadOnly = true;
            this.dgvThongKe5SPGanhet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe5SPGanhet.Size = new System.Drawing.Size(612, 563);
            this.dgvThongKe5SPGanhet.TabIndex = 0;
            // 
            // maSPDataGridViewTextBoxColumn1
            // 
            this.maSPDataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn1.Name = "maSPDataGridViewTextBoxColumn1";
            this.maSPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn1
            // 
            this.tenSPDataGridViewTextBoxColumn1.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn1.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn1.Name = "tenSPDataGridViewTextBoxColumn1";
            this.tenSPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Mau";
            this.dataGridViewTextBoxColumn1.HeaderText = "Màu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sizesDataGridViewTextBoxColumn1
            // 
            this.sizesDataGridViewTextBoxColumn1.DataPropertyName = "Sizes";
            this.sizesDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizesDataGridViewTextBoxColumn1.Name = "sizesDataGridViewTextBoxColumn1";
            this.sizesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Soluong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // chiTietSanPhamBindingSource1
            // 
            this.chiTietSanPhamBindingSource1.DataSource = typeof(DTO.ChiTietSanPham);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.pnNgay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 69);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbKieuThongKe);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 25);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểu Thống Kê :";
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Sản Phẩm Tồn Nhiều",
            "Sản Phẩm Tồn Ít",
            "Sản Phẩm Bán Chạy"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(106, 2);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(158, 21);
            this.cbKieuThongKe.TabIndex = 1;
            this.cbKieuThongKe.TextChanged += new System.EventHandler(this.cbKieuThongKe_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmsoluongthongke);
            this.panel2.Controls.Add(this.lblKieuThongKe);
            this.panel2.Location = new System.Drawing.Point(276, 3);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(201, 25);
            this.panel2.TabIndex = 0;
            // 
            // nmsoluongthongke
            // 
            this.nmsoluongthongke.Location = new System.Drawing.Point(112, 3);
            this.nmsoluongthongke.Name = "nmsoluongthongke";
            this.nmsoluongthongke.Size = new System.Drawing.Size(84, 21);
            this.nmsoluongthongke.TabIndex = 1;
            this.nmsoluongthongke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmsoluongthongke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmsoluongthongke.ValueChanged += new System.EventHandler(this.nmsoluongthongke_ValueChanged);
            // 
            // lblKieuThongKe
            // 
            this.lblKieuThongKe.AutoSize = true;
            this.lblKieuThongKe.Location = new System.Drawing.Point(3, 8);
            this.lblKieuThongKe.Name = "lblKieuThongKe";
            this.lblKieuThongKe.Size = new System.Drawing.Size(103, 13);
            this.lblKieuThongKe.TabIndex = 0;
            this.lblKieuThongKe.Text = "Số lượng Thống kê :";
            // 
            // pnNgay
            // 
            this.pnNgay.Controls.Add(this.dtpNgayKetThuc);
            this.pnNgay.Controls.Add(this.dtpNgayBatDau);
            this.pnNgay.Controls.Add(this.label4);
            this.pnNgay.Controls.Add(this.label3);
            this.pnNgay.Location = new System.Drawing.Point(3, 34);
            this.pnNgay.Name = "pnNgay";
            this.pnNgay.Size = new System.Drawing.Size(325, 27);
            this.pnNgay.TabIndex = 5;
            this.pnNgay.Visible = false;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(208, 3);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(106, 21);
            this.dtpNgayKetThuc.TabIndex = 2;
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(48, 3);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(106, 21);
            this.dtpNgayBatDau.TabIndex = 2;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ :";
            // 
            // ucsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucsanpham";
            this.Size = new System.Drawing.Size(1191, 714);
            this.Load += new System.EventHandler(this.ucsanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe5SPGanhet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluongthongke)).EndInit();
            this.pnNgay.ResumeLayout(false);
            this.pnNgay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTenSP;
        private System.Windows.Forms.RadioButton rbmasp;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtTimKiem;/*
        private System.Windows.Forms.DataGridViewTextBoxColumn mauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThongKe5SPGanhet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmsoluongthongke;
        private System.Windows.Forms.Label lblKieuThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource1;
        private System.Windows.Forms.ComboBox cbKieuThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
