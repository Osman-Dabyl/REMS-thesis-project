using Microsoft.Extensions.Caching.Memory;
using Rafat.Code.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;

namespace Rafat.Gui.UsersGui
{
    public partial class PasswordReset : Form
    {

        public static MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public static PasswordResetService passwordResetService = new PasswordResetService(memoryCache);
        private string useremail;
        private LoginForm loginForm;

        public PasswordReset(string userEmail)
        {
           


            InitializeComponent();

            this.useremail = userEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordResetService.ResetPasswordAsync(useremail, textBox2.Text);

            
            MessageBox.Show("Password Changed Successfully");
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
    }
}
