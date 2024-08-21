
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
using Rafat.Core.Enums;
using static Rafat.Core.Enums.Order_Status;

namespace Rafat.Gui.OrdersGui
{
    public partial class AddOrderForm : Form
    {
        private readonly IDataHelper<Order> dataHelperForOrder;
        private readonly IDataHelper<Customer> dataHelperForCustomer;
        private readonly IDataHelper<Property> dataHelperForProperty;

        private readonly Main main;
        private int id;
        private DateTime orderCreatedDate;
        private OrderStatus currentOrderStatus;

        private List<Customer> customerList;
        private List<Property> propertyList;
        private DBContext db;

        private readonly OrdersUserControl page;

        public AddOrderForm  (Main main, int id)
        {
            InitializeComponent();

            dataHelperForOrder = new OrderEF();
            dataHelperForCustomer = new CustomerEF();
            dataHelperForProperty = new PropertyEF();
            db = new DBContext();

            page = OrdersUserControl.Instance(main);

            this.Owner = main;

            this.main = main;
            this.id = id;


            lblDate.Text = DateTime.Now.Date.ToString();



            LoadCustomer();
            LoadProperty();

            cmbChoice.DataSource = customerList;
            cmbpchoise.DataSource = propertyList;

            if (this.id > 0)
            {
                SetDataForEdit();


              
            }
            else
            {
                int nextorderid = GetNextOrderId();

                lblOrid.Text = nextorderid.ToString();

            }
          

        }






        private bool IsValid()
        {
            if (false
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    

        private async void Add(Order_Status.OrderStatus orderStatus)
        {
            var propid = (int)cmbpchoise.SelectedValue;
            var salePrice = await Task.Run((() => dataHelperForProperty.Find(propid)));

            // Set User
            Order order = new Order
            {
                PropertyId = (int)cmbpchoise.SelectedValue,
                CustomerId = (int)cmbChoice.SelectedValue,
                OrderDate = DateTime.Now,
                SalePrice = salePrice.Price,
                RentStartDate = rentstartdate.Value,
                RentEndDate = rentenddate.Value,
                RentAmount = null,
                Balance = null,
                Status = orderStatus,




                UserId = SetUserId()
            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForOrder.Add(order));
            if (result == "1")
            {
                // Add User Roles

                var propfilled = await Task.Run((() => dataHelperForProperty.Find(order.PropertyId)));

                // Success
                SystemRecordHelper.Add("Order placed",
                    $"order {order.OrderId} filled for {propfilled.DisplayName} ");
                //page.LoadData();
                ToastHelper.ShowAddToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }

        private async void Edit(Order_Status.OrderStatus orderStatus)
        { 
            var propid = (int)cmbpchoise.SelectedValue;

            var orderid = await Task.Run((() => dataHelperForOrder.Find(id)));

         var salePrice = await Task.Run((() => dataHelperForProperty.Find(orderid.PropertyId)));

            // Set User
            Order order = new Order
            {
                OrderId = id,
                PropertyId = (int)cmbpchoise.SelectedValue,
                CustomerId = (int)cmbChoice.SelectedValue,
                OrderDate = DateTime.Now,
                RentStartDate = rentstartdate.Value,
                RentEndDate = rentenddate.Value,
                SalePrice = salePrice.Price,
                RentAmount = null,
                Balance = null,
                Status = orderStatus,
                UserId = SetUserId()

            };



            // Send Data to database
            var result = await Task.Run(() => dataHelperForOrder.Edit(order));
            if (result == "1")
            {

                // Success
                // Success
               
                //page.LoadData();
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
            return LocalUser.UserId;

        }

        private async void SetDataForEdit()
        {
            // Get Edit User Data

            var order = await Task.Run(() => dataHelperForOrder.Find(id));

                lblOrid.Text = order.OrderId.ToString();
                lblDate.Text = order.OrderDate.ToString();
                cmbChoice.SelectedValue = order.CustomerId;
                txtPprice.Text = order.SalePrice.ToString();
                cmbpchoise.SelectedValue = order.PropertyId;

            
        
            // Set Roles

            if (order.Status == OrderStatus.Pending)
            {
                btnReject.Visible = true;
            }
            else
            {
                btnReject.Visible = false;
            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            currentOrderStatus = OrderStatus.Rejected;

            Edit(currentOrderStatus);


            this.Close();
        }

        private void cmbOrdertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdertype.SelectedItem != null && cmbOrdertype.SelectedItem.ToString() == "Rent")
            {

                pnlrent.Visible = true;

            }
            else
            {

                pnlrent.Visible = false;

            }

        }



        private async void btnConfirm_Click(object sender, EventArgs e)
        {

           

            currentOrderStatus = OrderStatus.Accepted;

         



                    // Add
                    if (id == 0)
                    {
                        Add(currentOrderStatus);
                    }
                    else
                    {

                        Edit(currentOrderStatus);
                    }

                    var propid = (int)cmbpchoise.SelectedValue;
                    var salectedProperty = await Task.Run((() => dataHelperForProperty.Find(propid)));

                    salectedProperty.Status = Property_Stutus.PropertyStatus.Sold;

                    SystemRecordHelper.Add("Order placed",
                        $"{salectedProperty.DisplayName} Sold ");

                    await Task.Run((() => dataHelperForProperty.Edit(salectedProperty)));




        }


        private async void LoadProperty()
        {
            cmbpchoise.SelectedIndexChanged -= cmbpchoise_SelectedIndexChanged;
            propertyList = await Task.Run(() => dataHelperForProperty.GetAllData()
                .Where(p => p.Status == Property_Stutus.PropertyStatus.Available).ToList()
                );
            cmbpchoise.DataSource = propertyList;
            cmbpchoise.DisplayMember = "DisplayName"; // assuming FullName is a property of the Agent entity
            cmbpchoise.ValueMember = "PropertyId";
            cmbpchoise.SelectedIndex = -1; //

            txtPprice.Clear();

            cmbpchoise.SelectedIndexChanged += cmbpchoise_SelectedIndexChanged;
        }

      


        private async void LoadCustomer()
        {

            cmbChoice.SelectedIndexChanged -= cmbChoice_SelectedIndexChanged;


            customerList = await Task.Run(() => dataHelperForCustomer.GetAllData());
            cmbChoice.DataSource = customerList;
            cmbChoice.DisplayMember = "FullName"; // assuming FullName is a property of the Agent entity
            cmbChoice.ValueMember = "CustomerId";
            cmbChoice.SelectedIndex = -1; //

            txtCnumber.Clear();

            cmbChoice.SelectedIndexChanged += cmbChoice_SelectedIndexChanged;

        }



        private async void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbChoice.SelectedValue is Customer selectedCustomer)
            {
                int customerId = selectedCustomer.CustomerId;

                // Async call to get the customer data based on the selected value
                var phone = await Task.Run(() => dataHelperForCustomer.Find(customerId));

                // Set the phone number in the text box, or clear it if no phone is found
                txtCnumber.Text = phone?.Phone.ToString() ?? string.Empty;
            }
            else if (cmbChoice.SelectedValue is int customerId)
            {
                // In case SelectedValue is already the CustomerId
                var phone = await Task.Run(() => dataHelperForCustomer.Find(customerId));
                txtCnumber.Text = phone?.Phone.ToString() ?? string.Empty;
            }
        }

        private async void cmbpchoise_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbpchoise.SelectedValue is Property selectedProperty)
            {

                int PropertyId = selectedProperty.PropertyId;

                var property = await Task.Run(() => dataHelperForProperty.Find(PropertyId));

                txtPprice.Text = property.ToString();


            }
            else if (cmbpchoise.SelectedValue is int PropertyId)
            {
                // In case SelectedValue is already the CustomerId
                var property = await Task.Run(() => dataHelperForProperty.Find(PropertyId));
                txtPprice.Text = property?.Price.ToString() ?? string.Empty;
            }


        }


        private int GetNextOrderId()
        {
            

            // Assuming you are using Entity Framework or similar
            int maxOrderId = db.Orders.Max(o => (int?)o.OrderId) ?? 0;
            return maxOrderId + 1;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            currentOrderStatus = OrderStatus.Pending;

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
                if (await Task.Run(() => dataHelperForOrder.IsCanConnect()))
                {

                    // Add
                    if (id == 0)
                    {

                        Add(currentOrderStatus);
                    }
                    else
                    {
                        // Edit

                        Edit(currentOrderStatus);
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
    }
}
