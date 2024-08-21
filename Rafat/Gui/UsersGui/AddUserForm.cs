using Microsoft.VisualBasic.ApplicationServices;
using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Data.EF;
using Rafat.Gui.LoadingGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafat.Gui.UsersGui
{
    public partial class AddUserForm : Form
    {
        private readonly IDataHelper<Users> dataHelperForUser;

        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int id;
        private DateTime userCreatedDate;
        private readonly UsersUserControl page;

        public AddUserForm(Main main, int id)
        {
            InitializeComponent();

            dataHelperForUser = new UsersEF();

            dataHelperForSystemRecords = new SystemRecordsEF();

            this.Owner = main;




            SetRoles();
            this.main = main;
            this.id = id;
            page = UsersUserControl.Instance(main);

            if (this.id > 0)
            {
                SetDataForEdit();
            }
        }

      

        private void SetRoles()
        {
            if (Code.Models.LocalUser.Role == "Admin")
            {
                // Admin
                // Add Roles
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Admin");
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");

               
            }
            else
            {
                // User
                // Add Roles
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");

            }


        }

      

     

      
        private bool IsValid()
        {
            if (
                textBoxFullName.Text.Length < 3 ||
                textBoxPassword.Text.Length < 3 ||
                textBoxUserName.Text.Length < 3
                )
            {
                return false;
            }
            else
            {
                return true;
            }

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
                LoadingForm.Instance(main).Show();
                // Check Connection
                if (await Task.Run(() => dataHelperForUser.IsCanConnect()))
                {
                    // Check Duplicated Item

                    string fullName = textBoxFullName.Text;
                    string userName = textBoxUserName.Text;

                    var result = await Task.Run(() => dataHelperForUser
                    .GetAllData()
                    .Where(x => x.Id != id)
                    .Where(x => x.FullName == fullName || x.UserId == userName)
                    .FirstOrDefault() ?? new Users());

                    if (result.Id > 0)
                    {
                        // Msg
                        LoadingForm.Instance(main).Hide();
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        // Add
                        if (id == 0)
                        {
                            Add();
                        }
                        else
                        {
                            // Edit
                            Edit();
                        }
                    }


                }
                else
                {
                    LoadingForm.Instance(main).Hide();
                    MsgHelper.ShowServerError();
                }

                LoadingForm.Instance(main).Hide();
            }

        }

        private async void Add()
        {
            // Set User
            Users users = new Users
            {
                FullName = textBoxFullName.Text,
                Password = textBoxPassword.Text,
                UserName = textBoxUserName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = DateTime.Now.Date,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString() ?? "User",
                Phone = textBoxPhone.Text,
                UserId = SetUserId()
            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForUser.Add(users));
            if (result == "1")
            {


                // Success
                SystemRecordHelper.Add("اضافة مستخدم",
                    $"تم اضافة مستخدم جديد يحمل الرقم التعريفي {users.Id}");
                page.LoadData();
                ToastHelper.ShowAddToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }

        private async void Edit()
        {

            // Set User
            Users users = new Users
            {
                Id = id,
                FullName = textBoxFullName.Text,
                Password = textBoxPassword.Text,
                UserName = textBoxUserName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = userCreatedDate,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString() ?? "User",
                Phone = textBoxPhone.Text,
                UserId = SetUserId()

            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForUser.Edit(users));
            if (result == "1")
            {


                // Success
                // Success
                SystemRecordHelper.Add("تعديل مستخدم",
                    $"تم تعديل مستخدم حالي يحمل الرقم التعريفي {users.Id}");
                page.LoadData();
                ToastHelper.ShowEditToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }


        private string SetUserId()
        {
           
            return Guid.NewGuid().ToString();
            
        }

        private async void SetDataForEdit()
        {
            // Get Edit User Data
            var user = await Task.Run(() => dataHelperForUser.Find(id));
            if (user != null)
            {
                textBoxFullName.Text = user.FullName;
                textBoxPassword.Text = user.Password;
                textBoxUserName.Text = user.UserName;
                textBoxEmail.Text = user.Email;
                textBoxPhone.Text = user.Phone;
                textBoxAddress.Text = user.Address;
                comboBoxRole.SelectedItem = user.Role;
                userCreatedDate = user.CreatedDate;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
