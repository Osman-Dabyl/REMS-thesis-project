
using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Core.Enums;
using Rafat.Data.EF;
using Rafat.Gui.LoadingGui;
using System.Data;
using static Rafat.Core.Enums.Listing_Type;
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
        private Oreder_Type.OrderType currentOrderType = Oreder_Type.OrderType.Purchase;

        private List<Customer> customerList;
        private List<Property> propertyList;
        private DBContext db;

        private readonly OrdersUserControl page;

        public AddOrderForm(Main main, int id)
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

            cmbOrdertype.DataSource = Enum.GetValues(typeof(Listing_Type.ListingType));
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

            DateTime? renttimestart = null;
            DateTime? renttimeend = null;

            if (cmbOrdertype.SelectedItem != null && cmbOrdertype.SelectedItem.ToString() == "Rent")
            {
                renttimestart = rentstartdate.Value;
                renttimeend = rentenddate.Value;
                currentOrderType = Oreder_Type.OrderType.Rent;
            }




            var propid = (int)cmbpchoise.SelectedValue;
            var salePrice = await Task.Run((() => dataHelperForProperty.Find(propid)));

            // Set User
            Order order = new Order
            {
                PropertyId = (int)cmbpchoise.SelectedValue,
                CustomerId = (int)cmbChoice.SelectedValue,
                OrderDate = DateTime.Now,
                SalePrice = salePrice.Price,
                RentStartDate = renttimestart,
                RentEndDate = renttimeend,
                RentAmount = null,
                Balance = null,
                Ordertype = currentOrderType,
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

            DateTime? renttimestart = null;
            DateTime? renttimeend = null;



            var orderid = await Task.Run((() => dataHelperForOrder.Find(id)));

            var salePrice = await Task.Run((() => dataHelperForProperty.Find(orderid.PropertyId)));

            if (orderid.Ordertype == Oreder_Type.OrderType.Rent)
            {
                renttimestart = rentstartdate.Value;
                renttimeend = rentenddate.Value;
                currentOrderType = Oreder_Type.OrderType.Rent;
            }

            // Set User
            Order order = new Order
            {
                OrderId = id,
                PropertyId = (int)cmbpchoise.SelectedValue,
                CustomerId = (int)cmbChoice.SelectedValue,
                OrderDate = DateTime.Now,
                SalePrice = salePrice.Price,
                RentStartDate = renttimestart,
                RentEndDate = renttimeend,
                RentAmount = null,
                Balance = null,
                Ordertype = currentOrderType,
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

            cmbOrdertype.Enabled = false;

            var order = await Task.Run(() => dataHelperForOrder.Find(id));
            var customername = await Task.Run(() => dataHelperForCustomer.GetAllData().Where(x => x.CustomerId == order.CustomerId).ToList());

            var salectedprop = await Task.Run(() => dataHelperForProperty.GetAllData().Where(x => x.PropertyId == order.PropertyId).ToList());

            if (order.Ordertype == Oreder_Type.OrderType.Rent)
            {
                currentOrderType = Oreder_Type.OrderType.Rent;
                pnlrent.Visible = true;

                rentstartdate.Value = order.RentStartDate.Value;
                rentenddate.Value = order.RentEndDate.Value;

            }

            cmbChoice.DataSource = null;
            cmbChoice.Items.Clear();
            cmbpchoise.DataSource = null;
            cmbpchoise.Items.Clear();
            cmbpchoise.DataSource = salectedprop;
            cmbpchoise.DisplayMember = "DisplayName"; // assuming FullName is a property of the Agent entity
            cmbpchoise.ValueMember = "PropertyId";
            cmbpchoise.SelectedValue = order.PropertyId;
            lblOrid.Text = order.OrderId.ToString();
            lblDate.Text = order.OrderDate.ToString();
            cmbChoice.DataSource = customername;
            cmbChoice.DisplayMember = "FullName"; // assuming FullName is a property of the Agent entity
            cmbChoice.ValueMember = "CustomerId";
            txtPprice.Text = order.SalePrice.ToString();
            txtCnumber.Text = customername.Select(x => x.Phone).ToString();



            cmbChoice.SelectedIndex = 0;

            // Set Roles

            if (order.Status == OrderStatus.Accepted || order.Status == OrderStatus.Rejected)
            {
                btnReject.Enabled = false;
                btnConfirm.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                btnReject.Enabled = true;
                btnConfirm.Enabled = true;
                btnSave.Enabled = true;
            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            if (id > 0)
            {
                currentOrderStatus = OrderStatus.Rejected;

                Edit(currentOrderStatus);
                this.Close();
            }
            this.Close();
        }

        private void cmbOrdertype_SelectedIndexChanged(object sender, EventArgs e)
        {


            LoadProperty();

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


            var propid = (int)cmbpchoise.SelectedValue;
            var salectedProperty = await Task.Run((() => dataHelperForProperty.Find(propid)));
            if (salectedProperty.Listing == Listing_Type.ListingType.Rent)
            {
                salectedProperty.Status = Property_Stutus.PropertyStatus.Rented;
                currentOrderType = Oreder_Type.OrderType.Rent;
            }
            else
            {
                salectedProperty.Status = Property_Stutus.PropertyStatus.Sold;
                currentOrderType = Oreder_Type.OrderType.Purchase;
            }


            // Add
            if (id == 0)
            {
                Add(currentOrderStatus);
            }
            else
            {

                Edit(currentOrderStatus);
            }



            string orderType = cmbOrdertype.SelectedItem?.ToString();

            var action = "Rented";

            if (currentOrderType == Oreder_Type.OrderType.Purchase)
            {
                action = "Sold";
            }

            SystemRecordHelper.Add("Order placed",
                $"{salectedProperty.DisplayName} {action} ");

            await Task.Run((() => dataHelperForProperty.Edit(salectedProperty)));




        }


        private async void LoadProperty()
        {
            cmbpchoise.SelectedIndexChanged -= cmbpchoise_SelectedIndexChanged;
            cmbOrdertype.SelectedIndexChanged -= cmbOrdertype_SelectedIndexChanged;
            propertyList = await Task.Run(() => dataHelperForProperty.GetAllData()
                .Where(p => p.Status == Property_Stutus.PropertyStatus.Available && p.Listing == (ListingType)cmbOrdertype.SelectedItem).ToList()
                );
            cmbpchoise.DataSource = propertyList;
            cmbpchoise.DisplayMember = "DisplayName"; // assuming FullName is a property of the Agent entity
            cmbpchoise.ValueMember = "PropertyId";
            cmbpchoise.SelectedIndex = -1; //

            txtPprice.Clear();

            cmbpchoise.SelectedIndexChanged += cmbpchoise_SelectedIndexChanged;
            cmbOrdertype.SelectedIndexChanged += cmbOrdertype_SelectedIndexChanged;
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
            if (cmbOrdertype.SelectedItem != null && cmbOrdertype.SelectedItem.ToString() == "Rent")
            {
                currentOrderType = Oreder_Type.OrderType.Rent;
            }
            else
            {
                currentOrderType = Oreder_Type.OrderType.Purchase;
            }

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
