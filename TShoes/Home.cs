using DevExpress.DXperience.Demos;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShoes
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmHome()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            int widthscreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heighscreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthscreen;
            this.Height = heighscreen;
            float WidthPerscpective = (float)Width / 820;
            float HeightPerscpective = (float)Height / 535;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
        }

        private void ResizeAllControls(Control recussiveControl, float widthPerscpective, float heightPerscpective)
        {
            foreach (Control control in recussiveControl.Controls)
            {
                if (control.Controls.Count != 0)

                    ResizeAllControls(control, widthPerscpective, heightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * widthPerscpective);

                control.Top = (int)(control.Top * heightPerscpective);

                control.Width = (int)(control.Width * widthPerscpective);

                control.Height = (int)(control.Height * heightPerscpective);

            }
        }

        private void acelogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async Task LoadModuleAsync(ModuleInfo module)
        {
            try
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                    {
                        TutorialControlBase control = module.TModule as TutorialControlBase;
                        if (control != null)
                        {
                            control.Dock = DockStyle.Fill;
                            control.CreateWaitDialog();
                            control.Tag = accountname;
                            try
                            {
                                fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                                {
                                    fluentDesignFormContainer1.Controls.Add(control);
                                    control.BringToFront();
                                }));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                this.Refresh();
                            }
                            
                        }
                    }
                    else
                    {
                        var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                        if (control.Length == 1)
                            fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                            {
                                control[0].BringToFront();
                            }));

                    }
                }
            );
                module.ResetModule();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        

        private async void acehome_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucBills") == null)
                ModulesInfo.Add(new ModuleInfo("ucBills", "TShoes.UI.Modules.ucBills"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucBills"));
        }


        private async void acexemtaikhoan_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucaccount") == null)
                ModulesInfo.Add(new ModuleInfo("ucaccount", "TShoes.UI.Modules.ucaccount"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucaccount"));
        }

        public string phanquyen;
        public string accountname;
        private void frmHome_Load(object sender, EventArgs e)
        {

            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            if(phanquyen != "admin")
            {
                acexemtaikhoan.Visible = false;
                aceDSNhapHang.Visible = false;
                acesanpham.Visible = false;
            }
            this.acehome_Click(sender,e);
        }

        private async void acedoimatkhau_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucdoimatkhau") == null)
                ModulesInfo.Add(new ModuleInfo("ucdoimatkhau", "TShoes.UI.Modules.ucdoimatkhau"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucdoimatkhau"));
        }


        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Enabled == true)
            {
                frmlogin login = new frmlogin();
                login.Show();
            }
        }

        private async void aceDSSP_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucsanpham") == null)
                ModulesInfo.Add(new ModuleInfo("ucsanpham", "TShoes.UI.Modules.ucsanpham"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucsanpham"));
        }

        private async void aceDSNhapHang_Click(object sender, EventArgs e)
        {
            if(ModulesInfo.GetItem("DSPhieuNhap") == null)
                ModulesInfo.Add(new ModuleInfo("DSPhieuNhap", "TShoes.UI.Modules.DSPhieuNhap"));
            await LoadModuleAsync(ModulesInfo.GetItem("DSPhieuNhap"));
        }

        private async void aceThongKe_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucdonhang") == null)
                ModulesInfo.Add(new ModuleInfo("ucdonhang", "TShoes.UI.Modules.ucdonhang"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucdonhang"));
        }
    }
}
