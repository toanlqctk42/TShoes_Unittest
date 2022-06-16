
namespace TShoes.UI.Modules
{
    partial class ucaccount
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
            this.dgvAccout = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.contextChucvu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Addchucvu = new System.Windows.Forms.ToolStripMenuItem();
            this.Deletechucvu = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneltimkiem = new System.Windows.Forms.Panel();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pncreate = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhoitaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccout)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.contextChucvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneltimkiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pncreate.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Tài Khoản";
            // 
            // dgvAccout
            // 
            this.dgvAccout.AutoGenerateColumns = false;
            this.dgvAccout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccout.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAccout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTKDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.ngaykhoitaoDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dgvAccout.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccout.DataSource = this.nguoiDungBindingSource;
            this.dgvAccout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccout.Location = new System.Drawing.Point(0, 0);
            this.dgvAccout.Name = "dgvAccout";
            this.dgvAccout.ReadOnly = true;
            this.dgvAccout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAccout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccout.Size = new System.Drawing.Size(717, 572);
            this.dgvAccout.TabIndex = 1;
            this.dgvAccout.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccout_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActiveToolStripMenuItem,
            this.resetPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ActiveToolStripMenuItem
            // 
            this.ActiveToolStripMenuItem.Name = "ActiveToolStripMenuItem";
            this.ActiveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ActiveToolStripMenuItem.Text = "Kích hoạt";
            this.ActiveToolStripMenuItem.Click += new System.EventHandler(this.ActiveToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.resetPasswordToolStripMenuItem.Text = "Đặt Lại Mật Khẩu";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTendangnhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 51);
            this.panel2.TabIndex = 1;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "TenTK", true));
            this.txtTendangnhap.Location = new System.Drawing.Point(151, 10);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(212, 27);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbochucvu);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 49);
            this.panel6.TabIndex = 4;
            // 
            // cbochucvu
            // 
            this.cbochucvu.ContextMenuStrip = this.contextChucvu;
            this.cbochucvu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.chucVuBindingSource, "TenChucVu", true));
            this.cbochucvu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nguoiDungBindingSource, "Chucvu_ID", true));
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(160, 9);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(200, 27);
            this.cbochucvu.TabIndex = 4;
            // 
            // contextChucvu
            // 
            this.contextChucvu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addchucvu,
            this.Deletechucvu});
            this.contextChucvu.Name = "contextChucvu";
            this.contextChucvu.Size = new System.Drawing.Size(105, 48);
            // 
            // Addchucvu
            // 
            this.Addchucvu.Name = "Addchucvu";
            this.Addchucvu.Size = new System.Drawing.Size(104, 22);
            this.Addchucvu.Text = "Thêm";
            this.Addchucvu.Click += new System.EventHandler(this.Addchucvu_Click);
            // 
            // Deletechucvu
            // 
            this.Deletechucvu.Name = "Deletechucvu";
            this.Deletechucvu.Size = new System.Drawing.Size(104, 22);
            this.Deletechucvu.Text = "Xoá";
            this.Deletechucvu.Click += new System.EventHandler(this.Deletechucvu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ :";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.BackgroundImage = global::TShoes.Properties.Resources.diskette;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(101, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 50);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackgroundImage = global::TShoes.Properties.Resources.cancel;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(198, 7);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(53, 50);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 61);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1110, 61);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // paneltimkiem
            // 
            this.paneltimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltimkiem.Controls.Add(this.cbTenNV);
            this.paneltimkiem.Controls.Add(this.label3);
            this.paneltimkiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneltimkiem.Location = new System.Drawing.Point(4, 3);
            this.paneltimkiem.Name = "paneltimkiem";
            this.paneltimkiem.Size = new System.Drawing.Size(383, 51);
            this.paneltimkiem.TabIndex = 10;
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(153, 13);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(209, 27);
            this.cbTenNV.TabIndex = 1;
            this.cbTenNV.TextChanged += new System.EventHandler(this.cbTenNV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTennhanvien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 51);
            this.panel1.TabIndex = 2;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "Fullname", true));
            this.txtTennhanvien.Location = new System.Drawing.Point(166, 10);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(197, 27);
            this.txtTennhanvien.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Nhân Viên :";
            // 
            // pncreate
            // 
            this.pncreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pncreate.Controls.Add(this.panel6);
            this.pncreate.Controls.Add(this.panel1);
            this.pncreate.Controls.Add(this.panel2);
            this.pncreate.Enabled = false;
            this.pncreate.Location = new System.Drawing.Point(3, 60);
            this.pncreate.Name = "pncreate";
            this.pncreate.Size = new System.Drawing.Size(382, 190);
            this.pncreate.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Location = new System.Drawing.Point(6, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 60);
            this.panel4.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pncreate);
            this.splitContainer1.Panel1.Controls.Add(this.paneltimkiem);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAccout);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 572);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 11;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataSource = typeof(DTO.ChucVu);
            // 
            // tenTKDataGridViewTextBoxColumn
            // 
            this.tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
            this.tenTKDataGridViewTextBoxColumn.HeaderText = "Tên Đăng Nhập";
            this.tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
            this.tenTKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaykhoitaoDataGridViewTextBoxColumn
            // 
            this.ngaykhoitaoDataGridViewTextBoxColumn.DataPropertyName = "Ngaykhoitao";
            this.ngaykhoitaoDataGridViewTextBoxColumn.HeaderText = "Ngày khởi tạo";
            this.ngaykhoitaoDataGridViewTextBoxColumn.Name = "ngaykhoitaoDataGridViewTextBoxColumn";
            this.ngaykhoitaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataSource = typeof(DTO.NguoiDung);
            // 
            // ucaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucaccount";
            this.Size = new System.Drawing.Size(1110, 639);
            this.Load += new System.EventHandler(this.ucaccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccout)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.contextChucvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneltimkiem.ResumeLayout(false);
            this.paneltimkiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pncreate.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel paneltimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pncreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ActiveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextChucvu;
        private System.Windows.Forms.ToolStripMenuItem Addchucvu;
        private System.Windows.Forms.ToolStripMenuItem Deletechucvu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhoitaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
    }
}
