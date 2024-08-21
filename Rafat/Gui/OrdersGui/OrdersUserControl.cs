using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Data.EF;
using System.Data;
using Rafat.Core;

namespace Rafat.Gui.OrdersGui
{
    public partial class OrdersUserControl : UserControl
    {
        private static OrdersUserControl? _ordersUserControl;
        private AddOrderForm addOrderForm;
        private static Main _main;
        private IDataHelper<Order> dataHelper;
        private List<Order> data;
        private List<int> idDeleteList;


        public OrdersUserControl()
        {
            InitializeComponent();
            SetImages();
            dataHelper = new OrderEF();
            data = new List<Order>();
            idDeleteList = new List<int>();
            LoadData();

        }

        public static OrdersUserControl Instance(Main main)
        {
            _main = main;
            return _ordersUserControl ?? (_ordersUserControl = new OrdersUserControl());
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Data if not empty
                if (!DgvHelper.IsEmpty(dataGridView1))
                {

                    // Get Id
                    SetIdDeleteList();
                    if (idDeleteList.Count > 0)
                    {
                        if (MsgHelper.ShowDeleteDialog())
                        {
                            loading("Show");
                            if (await Task.Run(() => dataHelper.IsCanConnect()))
                            {
                                // Loop into Id List
                                foreach (int id in idDeleteList)
                                {
                                    await Task.Run(() => dataHelper.Delete(id));
                                    SystemRecordHelper.Add("Order Deleted",
                   $"the Order With the Id {id.ToString()} Has been deleted ");
                                }
                                ToastHelper.ShowDeleteToast();
                                LoadData();
                            }
                            else
                            {
                                loading("Hide");
                                MsgHelper.ShowServerError();
                            }

                            loading("Hide");
                        }
                    }
                    else
                    {
                        MsgHelper.ShowDeleteSelectRow();
                    }
                }

                else
                {
                    loading("Hide");
                    MsgHelper.ShowEmptyDataGridView();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void SetIdDeleteList()
        {
            idDeleteList.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    idDeleteList.Add(Convert.ToInt32(row.Cells[0].Value));
                }

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            buttonRefresh.Image = neImage;
            timer1.Start();
            LoadData();
           
        }

    

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        // Methods
        public async void LoadData()
        {
            //LoadingForm.Instance(_main).StartPosition= FormStartPosition.CenterParent;
            loading("Show");
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                // Start Load Data


                // Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    // Get All Data
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    // Get Data By User
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));
                }
                labelNofOfItmes.Text = data.Count.ToString();
                // Fill DataGridView
                dataGridView1.DataSource = data.Take(Properties.Settings.Default.NoOfDataGirdViewItems).ToList();
                if (data.Count <= Properties.Settings.Default.NoOfDataGirdViewItems)
                {
                    comboBoxNoOfPages.Items.Clear();
                    comboBoxNoOfPages.Items.Add(0);

                }
                else
                {
                    // Get and Add No of pages
                    double value = Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.NoOfDataGirdViewItems);
                    int noOfPage = Convert.ToInt32(Math.Round(value, MidpointRounding.AwayFromZero));
                    comboBoxNoOfPages.Items.Clear();
                    for (int i = 0; i <= noOfPage; i++)
                    {
                        comboBoxNoOfPages.Items.Add(i);
                    }
                }


                //
                // Set Columns Title
                SetColumns();

                // Show Empty Data
                ShowEmptyDataState();

                // Clear Data
                data.Clear();

            }
            else
            {
                // No Connection
                loading("Hide");
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            loading("Hide");


        }

        public async void Search()
        {
            // Show Loading
            loading("Show");
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                // Start Load Data
                string searchItem = textBoxSearch.Text;
                // Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    // Get All Data
                    data = await Task.Run(() => dataHelper.SearchAll(searchItem));
                }
                else
                {
                    // Get Data By User
                    data = await Task.Run(() => dataHelper.SearchByUser(LocalUser.UserId, searchItem));
                }

                // Fill DataGridView
                dataGridView1.DataSource = data.ToList();


                // Set Columns Title
                //SetColumns();

                // Show Empty Data
                ShowEmptyDataState();

                // Clear Data
                data.Clear();
                loading("Hide");
            }
            else
            {
                // No Connection
                loading("Hide");
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            loading("Hide");


        }

        private void ShowEmptyDataState()
        {
            // Set Title and Descripton
            labelStateTitle.Text = Properties.Resources.EmptyDataStateTitle;
            labelStateDescription.Text = Properties.Resources.EmptyDataStateDescription;
            panelState.Visible = DgvHelper.IsEmpty(dataGridView1);
        }

        private void ShowServerErrorState()
        {
            // Set Title and Descripton
            labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
            labelStateDescription.Text = Properties.Resources.ServerErrorDescription;
            panelState.Visible = true;
        }

        private void SetColumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value  ="Order Id";
            dataGridView1.Columns[1].HeaderCell.Value  ="Property ID";
            dataGridView1.Columns[2].HeaderCell.Value  ="Customer Id";
            dataGridView1.Columns[3].HeaderCell.Value  ="Order Date";
            dataGridView1.Columns[4].HeaderCell.Value  ="Type";
           
            dataGridView1.Columns[10].HeaderCell.Value ="Status";
          


            // Visible of Columns
        
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
       


        }



        private void Edit()
        {
            // Check Data if not empty
            if (!DgvHelper.IsEmpty(dataGridView1))
            {
                // Get Id
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (addOrderForm == null || addOrderForm.IsDisposed)
                {
                    addOrderForm = new AddOrderForm(_main, id);
                    addOrderForm.Show();
                }
                else
                {
                    addOrderForm.Focus();
                }
            }
            else
            {
                MsgHelper.ShowEmptyDataGridView();
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private async void comboBoxNoOfPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Show Loading
                loading("Show");
                if (await Task.Run(() => dataHelper.IsCanConnect()))
                {
                    // Start Load Data
                    // Check if Admin or not
                    if (LocalUser.Role == "Admin")
                    {
                        // Get All Data
                        data = await Task.Run(() => dataHelper.GetAllData());
                    }
                    else
                    {
                        // Get Data By User
                        data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));
                    }

                    // Get and Set Param
                    var idlist = data.Select(x => x.OrderId).ToArray();
                    int index = comboBoxNoOfPages.SelectedIndex;
                    int noOfItemIndex = index * Properties.Settings.Default.NoOfDataGirdViewItems;

                    // Fill DataGridView
                    dataGridView1.DataSource = data.Where(x => x.OrderId <= idlist[noOfItemIndex])
                        .Take(Properties.Settings.Default.NoOfDataGirdViewItems).ToList();

                    // Show Empty Data
                    ShowEmptyDataState();

                    // Clear Data
                    data.Clear();
                    loading("Hide");
                }
                else
                {
                    // No Connection
                    loading("Hide");
                    ShowServerErrorState();
                    MsgHelper.ShowServerError();
                }

                // Hide Loading
                loading("Hide");

            }
            catch { }

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNoOfPages.SelectedIndex != 0)
                {
                    comboBoxNoOfPages.SelectedIndex = comboBoxNoOfPages.SelectedIndex - 1;
                }
            }
            catch { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {

                comboBoxNoOfPages.SelectedIndex = comboBoxNoOfPages.SelectedIndex + 1;

            }
            catch { }
        }

      

        public void loading(string state)
        {

            if (state == "Show")
            {

                panel3.Visible = true;

            }
            else
            {

                panel3.Visible = false;
            }



        }

        
        
            private void timer1_Tick(object sender, EventArgs e)
            {
                buttonRefresh.Image = orignalImage;
                timer1.Stop();

            }

            private void SetImages()
            {
                orignalImage = buttonRefresh.Image;
                neImage = Properties.Resources.icons8_recent;
            }

    }
}
