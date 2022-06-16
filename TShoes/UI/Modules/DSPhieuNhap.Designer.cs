
namespace TShoes.UI.Modules
{
    partial class DSPhieuNhap
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
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.nguonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phivanchuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaphieunhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNguonHang = new System.Windows.Forms.TextBox();
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaybatDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTienShip = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblchiphikhac = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblTienHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoGenerateColumns = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nguonHangDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.tienhangDataGridViewTextBoxColumn,
            this.phivanchuyenDataGridViewTextBoxColumn,
            this.thueDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
            this.dgvPhieuNhap.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPhieuNhap.DataSource = this.nhapHangBindingSource;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 17);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(973, 376);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // nguonHangDataGridViewTextBoxColumn
            // 
            this.nguonHangDataGridViewTextBoxColumn.DataPropertyName = "NguonHang";
            this.nguonHangDataGridViewTextBoxColumn.HeaderText = "Nguồn";
            this.nguonHangDataGridViewTextBoxColumn.Name = "nguonHangDataGridViewTextBoxColumn";
            this.nguonHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tienhangDataGridViewTextBoxColumn
            // 
            this.tienhangDataGridViewTextBoxColumn.DataPropertyName = "Tienhang";
            this.tienhangDataGridViewTextBoxColumn.HeaderText = "Tiền Hàng";
            this.tienhangDataGridViewTextBoxColumn.Name = "tienhangDataGridViewTextBoxColumn";
            this.tienhangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phivanchuyenDataGridViewTextBoxColumn
            // 
            this.phivanchuyenDataGridViewTextBoxColumn.DataPropertyName = "Phivanchuyen";
            this.phivanchuyenDataGridViewTextBoxColumn.HeaderText = "Ship";
            this.phivanchuyenDataGridViewTextBoxColumn.Name = "phivanchuyenDataGridViewTextBoxColumn";
            this.phivanchuyenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thueDataGridViewTextBoxColumn
            // 
            this.thueDataGridViewTextBoxColumn.DataPropertyName = "Thue";
            this.thueDataGridViewTextBoxColumn.HeaderText = "Thuế";
            this.thueDataGridViewTextBoxColumn.Name = "thueDataGridViewTextBoxColumn";
            this.thueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "Thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "Tổng Cộng";
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            this.thanhtienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaphieunhapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 26);
            // 
            // xoaphieunhapToolStripMenuItem
            // 
            this.xoaphieunhapToolStripMenuItem.Name = "xoaphieunhapToolStripMenuItem";
            this.xoaphieunhapToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.xoaphieunhapToolStripMenuItem.Text = "Xoá Phiếu Nhập";
            this.xoaphieunhapToolStripMenuItem.Click += new System.EventHandler(this.xoaphieunhapToolStripMenuItem_Click);
            // 
            // nhapHangBindingSource
            // 
            this.nhapHangBindingSource.DataSource = typeof(DTO.NhapHang);
            // 
            // chiTietSanPhamBindingSource
            // 
            this.chiTietSanPhamBindingSource.DataSource = typeof(DTO.ChiTietSanPham);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNguonHang);
            this.groupBox1.Controls.Add(this.dtpngayketthuc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgaybatDau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Theo Điều Kiện";
            // 
            // txtNguonHang
            // 
            this.txtNguonHang.Location = new System.Drawing.Point(413, 26);
            this.txtNguonHang.Name = "txtNguonHang";
            this.txtNguonHang.Size = new System.Drawing.Size(195, 21);
            this.txtNguonHang.TabIndex = 2;
            this.txtNguonHang.TextChanged += new System.EventHandler(this.txtNguonHang_TextChanged);
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayketthuc.Location = new System.Drawing.Point(207, 23);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(96, 21);
            this.dtpngayketthuc.TabIndex = 1;
            this.dtpngayketthuc.ValueChanged += new System.EventHandler(this.dtpngayketthuc_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nguồn Hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đến :";
            // 
            // dtpNgaybatDau
            // 
            this.dtpNgaybatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybatDau.Location = new System.Drawing.Point(45, 23);
            this.dtpNgaybatDau.Name = "dtpNgaybatDau";
            this.dtpNgaybatDau.Size = new System.Drawing.Size(96, 21);
            this.dtpNgaybatDau.TabIndex = 1;
            this.dtpNgaybatDau.ValueChanged += new System.EventHandler(this.dtpNgaybatDau_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 396);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhập Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.lblTienShip);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblchiphikhac);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblThue);
            this.panel1.Controls.Add(this.lblTienHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 71);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Tiền :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chi phí Khác :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thuế :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(811, 11);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(35, 13);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "label1";
            // 
            // lblTienShip
            // 
            this.lblTienShip.AutoSize = true;
            this.lblTienShip.Location = new System.Drawing.Point(97, 38);
            this.lblTienShip.Name = "lblTienShip";
            this.lblTienShip.Size = new System.Drawing.Size(35, 13);
            this.lblTienShip.TabIndex = 0;
            this.lblTienShip.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "(VNĐ)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(874, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "(VNĐ)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "(VNĐ)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "(VNĐ)";
            // 
            // lblchiphikhac
            // 
            this.lblchiphikhac.AutoSize = true;
            this.lblchiphikhac.Location = new System.Drawing.Point(498, 38);
            this.lblchiphikhac.Name = "lblchiphikhac";
            this.lblchiphikhac.Size = new System.Drawing.Size(35, 13);
            this.lblchiphikhac.TabIndex = 0;
            this.lblchiphikhac.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "(VNĐ)";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(458, 11);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(35, 13);
            this.lblThue.TabIndex = 0;
            this.lblThue.Text = "label1";
            // 
            // lblTienHang
            // 
            this.lblTienHang.AutoSize = true;
            this.lblTienHang.Location = new System.Drawing.Point(91, 11);
            this.lblTienHang.Name = "lblTienHang";
            this.lblTienHang.Size = new System.Drawing.Size(35, 13);
            this.lblTienHang.TabIndex = 0;
            this.lblTienHang.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền Ship :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền Hàng :";
            // 
            // DSPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DSPhieuNhap";
            this.Size = new System.Drawing.Size(985, 543);
            this.Load += new System.EventHandler(this.DSPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTienShip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblTienHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nhapHangBindingSource;
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource;
        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaybatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblchiphikhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguonHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phivanchuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNguonHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoaphieunhapToolStripMenuItem;
    }
}
