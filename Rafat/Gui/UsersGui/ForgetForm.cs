using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Caching.Memory;
using Rafat.Code.Models;
using Irony.Parsing;

namespace Rafat.Gui.UsersGui
{
    public partial class ForgetForm : Form
    {
         public static MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public static PasswordResetService passwordResetService = new PasswordResetService(memoryCache);
        private  PasswordReset passwordReset = null;

        public ForgetForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private string GenerateResetToken()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            string resetToken = GenerateResetToken();

            passwordResetService.SendResetEmailAsync(userEmail, resetToken);
            MessageBox.Show("Password reset email has been sent.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            string resetToken = textBox1.Text;
            if (passwordResetService.ValidateResetToken(userEmail, resetToken))
            {
                this.Hide();
                if (passwordReset == null)
                {
                    passwordReset = new PasswordReset(userEmail);
                    passwordReset.Show();
                    passwordReset.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    passwordReset.Show();
                }

            }
            else {

                MessageBox.Show("Invalid or expired token.");
            }

            
        }
    }
}
