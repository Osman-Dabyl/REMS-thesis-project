
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
using GMap.NET;
using GMap.NET.MapProviders;
using FontAwesome6;

namespace Rafat.Gui.CustomersGui
{
    public partial class AddCustomerForm : Form
    {
        private readonly IDataHelper<Customer> dataHelperForCustomer;

        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int id;
        private DateTime userCreatedDate;
        private const double ZoomStep = 0.5; // Step size for zooming

        private CustomersUserControl page;

        public AddCustomerForm(Main main, int id)
        {
            InitializeComponent();

            dataHelperForCustomer = new CustomerEF();

            dataHelperForSystemRecords = new SystemRecordsEF();

            page = CustomersUserControl.Instance(main);

            this.Owner = main;


            this.main = main;
            this.id = id;


            if (this.id > 0)
            {
                SetDataForEdit();
            }
        }

        private bool IsValid()
        {
            if (
                txtCoFullname.Text.Length < 3 ||
                txtCoPhone.Text.Length < 3

                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        private async void Add()
        {
            // Set User
            var customer = new Customer
            {
                FullName = txtCoFullname.Text,
                Phone = txtCoPhone.Text,
                AddedDate = DateTime.Now.Date,
                ModifiedDate = DateTime.Now.Date,

                UserId = LocalUser.UserId
            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForCustomer.Add(customer));
            if (result == "1")
            {


                // Success
                SystemRecordHelper.Add("Customer added", $"Customer({customer.FullName}) added Successfully");
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
            Customer customer = new Customer
            {
                CustomerId = id,
                FullName = txtCoFullname.Text,
                Phone = txtCoPhone.Text,
                AddedDate = userCreatedDate,
                ModifiedDate = DateTime.Now.Date,

                UserId = LocalUser.UserId

            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForCustomer.Edit(customer));
            if (result == "1")
            {
                SystemRecordHelper.Add("Customer Edited", $"Customer({customer.FullName}) Updated Successfully");
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



        private async void SetDataForEdit()
        {
            // Get Edit User Data
            var customer = await Task.Run(() => dataHelperForCustomer.Find(id));
            if (customer != null)
            {
                txtCoFullname.Text = customer.FullName;
                txtCoPhone.Text = customer.Phone;
                userCreatedDate = customer.AddedDate;
            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading

                // Check Connection
                if (await Task.Run(() => dataHelperForCustomer.IsCanConnect()))
                {
                    // Check Duplicated Item

                    string PhoneNumber = txtCoPhone.Text;

                    var result = await Task.Run(() => dataHelperForCustomer
                        .GetAllData()
                        .Where(x => x.CustomerId != id)
                        .FirstOrDefault(x => x.Phone == PhoneNumber) ?? new Customer());

                    if (result.CustomerId > 0)
                    {
                        // Msg

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

                    MsgHelper.ShowServerError();
                }


            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {

            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading

                // Check Connection
                if (await Task.Run(() => dataHelperForCustomer.IsCanConnect()))
                {
                    // Check Duplicated Item

                    string PhoneNumber = txtCoPhone.Text;

                    var result = await Task.Run(() => dataHelperForCustomer
                        .GetAllData()
                        .Where(x => x.CustomerId != id)
                        .FirstOrDefault(x => x.Phone == PhoneNumber) ?? new Customer());

                    if (result.CustomerId > 0)
                    {
                        // Msg

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

                    MsgHelper.ShowServerError();
                }


            }
        }
    }
}
