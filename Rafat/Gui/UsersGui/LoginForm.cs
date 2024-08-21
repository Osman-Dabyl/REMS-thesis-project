using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Data.EF;
using static Rafat.Code.Helper.SystemRecordHelper;

namespace Rafat.Gui.UsersGui
{
    public partial class LoginForm : Form
    {
        private readonly IDataHelper<Users> dataHelperForUser;

        public LoginForm()
        {
            InitializeComponent();
          
            dataHelperForUser = new UsersEF();
          
      

        }


        private bool IsValid()
        {
            if (

                textBoxPassword.Text.Length < 3 ||
                textBoxUserName.Text.Length < 3
                )
            {
                return false;
            }

            return true;

        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading
                pictureBoxLoding.Visible = true;
                // Check Connection
                if (await Task.Run(() => dataHelperForUser.IsCanConnect()))
                {

                    Login();

                }

                else
                {
                    pictureBoxLoding.Visible = false;

                    MsgHelper.ShowServerError();
                }

                pictureBoxLoding.Visible = false;

            }

        }

        private async void Login()
        {
            // Check UserName and Password
            string userName = textBoxUserName.Text,
                    password = textBoxPassword.Text;
            var user = await Task.Run(() =>
                dataHelperForUser
                    .GetAllData().FirstOrDefault(x => x.UserName == userName && x.Password == password) ?? new Users());
            if (user.Id > 0)
            {
                // Set User Info
                LocalUser.Id = user.Id;
                LocalUser.UserName = user.UserName;
                LocalUser.Password = user.Password;
                LocalUser.Address = user.Address;
                LocalUser.UserId = user.UserId;
                LocalUser.FullName = user.FullName;
                LocalUser.Email = user.Email;
                LocalUser.Role = user.Role;

                // Success Add 
                Add(" Login Success ",
                    $" {user.FullName} has Login ");

                Main main = new Main();
                main.Show();
                Hide();
            }
            else
            { // Valid Login
                MsgHelper.ShowValidLogin();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          
            if (checkBox1.Checked)
            {
               textBoxPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true; // Hide password
            }

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            

           
        }
    }
}
