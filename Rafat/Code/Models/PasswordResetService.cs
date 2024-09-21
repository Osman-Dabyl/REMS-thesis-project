using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rafat.Data.EF;
using Rafat.Core;
using DocumentFormat.OpenXml.Office2010.Excel;
using Rafat.Gui.UsersGui;

namespace Rafat.Code.Models
{
    public class PasswordResetService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IDataHelper<Users> dataHelperForUser;
        private const int TokenExpiryMinutes = 15;

        public PasswordResetService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            dataHelperForUser = new UsersEF();
        }

       
       
        public string GenerateResetToken()
        {
            return Guid.NewGuid().ToString().Substring(0, 8); 
        }

        public void SendResetEmailAsync(string recipientEmail, string token)
        {
            // In-memory cache token with expiration
            _memoryCache.Set(recipientEmail, token, TimeSpan.FromMinutes(TokenExpiryMinutes));

            string senderEmail = "adeeg.real.estat@gmail.com";
            string senderPassword = "mhgx nmvb qlie nlwr";


          
            string emailBody = $"Your password reset code is: {token}. " +
                         $"Please enter this code in the application to reset your password.";


            MailMessage mail = new MailMessage();
            mail.To.Add(recipientEmail); 
            mail.From = new MailAddress("adeeg.real.estat@gmail.com"); 
            mail.Subject = "Password Reset"; 

          
            mail.Body = emailBody;
            mail.IsBodyHtml = true; 

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(senderEmail, senderPassword); 
            smtp.EnableSsl = true; 

            try
            {
                smtp.Send(mail); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}"); 
            }
        }

        public bool ValidateResetToken(string email, string token)
        {
            if (_memoryCache.TryGetValue(email, out string storedToken))
            {
                return storedToken == token; 
            }

            return false;
        }

        public async void ResetPasswordAsync(string email, string newPassword)
        {
            
                var Currentuser = await Task.Run(() => dataHelperForUser.GetAllData().Where(x => x.Email == email).FirstOrDefault());

                Currentuser.Password = newPassword;

                dataHelperForUser.Edit(Currentuser);
                
     
                _memoryCache.Remove(email);
        }


    }
}
