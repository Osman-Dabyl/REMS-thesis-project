using Rafat.Code.Helper;
using Rafat.Data.EF;
using Rafat.Gui.UsersGui;

namespace Rafat
{
    // ReSharper disable once ArrangeTypeModifiers
    partial class StartForm : Form
    {
        private LoginForm loginForm = null;
        private readonly bool _isLoggingin=false;

        private DBContext db;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StartForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            Code.Helper.ConStringHelper.SetConString();
        }

        private void linkLabelSetServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show Settings From
            Gui.SettingsGui.SettingForm settingForm = new Gui.SettingsGui.SettingForm();
            settingForm.Show();
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
           
            if (!_isLoggingin)
            {
                Application.Exit();
            }


        }


        private async void timerStart_Tick(object sender, EventArgs e)
        {
            db = new DBContext();

            // Check the con

            if (await db.Database.CanConnectAsync())
            {
                // Show Login From
                timerStart.Enabled = false;
                this.Hide();
                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                    loginForm.Show();
                    loginForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    loginForm.Show();
                }
                
            }
            else
            {
                panelSettings.Visible = true;

            }
        }
    }
}
