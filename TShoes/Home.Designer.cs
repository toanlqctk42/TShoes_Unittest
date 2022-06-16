
namespace TShoes
{
    partial class frmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acehome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acesanpham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDSSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDSNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceaccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acexemtaikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acedoimatkhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acelogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.acehome,
            this.acesanpham,
            this.aceThongKe,
            this.aceaccount});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(56, 503);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = global::TShoes.Properties.Resources.Capture__1_;
            this.accordionControlElement1.Name = "accordionControlElement1";
            // 
            // acehome
            // 
            this.acehome.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.acehome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acehome.ImageOptions.Image")));
            this.acehome.Name = "acehome";
            this.acehome.Text = "Trang Chủ";
            this.acehome.Click += new System.EventHandler(this.acehome_Click);
            // 
            // acesanpham
            // 
            this.acesanpham.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDSSP,
            this.aceDSNhapHang});
            this.acesanpham.Expanded = true;
            this.acesanpham.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.acesanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acesanpham.ImageOptions.Image")));
            this.acesanpham.Name = "acesanpham";
            this.acesanpham.Text = "Sản Phẩm";
            // 
            // aceDSSP
            // 
            this.aceDSSP.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.aceDSSP.ImageOptions.Image = global::TShoes.Properties.Resources.boreport_32x32;
            this.aceDSSP.Name = "aceDSSP";
            this.aceDSSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDSSP.Text = "Danh Sách Sản Phẩm";
            this.aceDSSP.Click += new System.EventHandler(this.aceDSSP_Click);
            // 
            // aceDSNhapHang
            // 
            this.aceDSNhapHang.ImageOptions.Image = global::TShoes.Properties.Resources.botask_32x32;
            this.aceDSNhapHang.Name = "aceDSNhapHang";
            this.aceDSNhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDSNhapHang.Text = "Danh sách Nhập Hàng";
            this.aceDSNhapHang.Click += new System.EventHandler(this.aceDSNhapHang_Click);
            // 
            // aceThongKe
            // 
            this.aceThongKe.Expanded = true;
            this.aceThongKe.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.aceThongKe.ImageOptions.Image = global::TShoes.Properties.Resources._3dcolumn_32x32;
            this.aceThongKe.Name = "aceThongKe";
            this.aceThongKe.Text = "Thống Kê";
            this.aceThongKe.Click += new System.EventHandler(this.aceThongKe_Click);
            // 
            // aceaccount
            // 
            this.aceaccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acexemtaikhoan,
            this.acedoimatkhau,
            this.acelogout});
            this.aceaccount.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.aceaccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceaccount.ImageOptions.Image")));
            this.aceaccount.Name = "aceaccount";
            this.aceaccount.Text = "Tài Khoản";
            // 
            // acexemtaikhoan
            // 
            this.acexemtaikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acexemtaikhoan.ImageOptions.Image")));
            this.acexemtaikhoan.Name = "acexemtaikhoan";
            this.acexemtaikhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acexemtaikhoan.Text = "Xem Danh Sách Tài Khoản";
            this.acexemtaikhoan.Click += new System.EventHandler(this.acexemtaikhoan_Click);
            // 
            // acedoimatkhau
            // 
            this.acedoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acedoimatkhau.ImageOptions.Image")));
            this.acedoimatkhau.Name = "acedoimatkhau";
            this.acedoimatkhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acedoimatkhau.Text = "Đổi mật khẩu";
            this.acedoimatkhau.Click += new System.EventHandler(this.acedoimatkhau_Click);
            // 
            // acelogout
            // 
            this.acelogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acelogout.ImageOptions.Image")));
            this.acelogout.Name = "acelogout";
            this.acelogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acelogout.Text = "Đăng Xuất";
            this.acelogout.Click += new System.EventHandler(this.acelogout_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(810, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(56, 27);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(754, 503);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::TShoes.Properties.Resources.logoTShoes;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(97, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 530);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSHOES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acehome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceaccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acexemtaikhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acelogout;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acesanpham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acedoimatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDSSP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDSNhapHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}