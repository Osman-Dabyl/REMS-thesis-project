using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rafat.Gui.test;
using DocumentFormat.OpenXml.Drawing;
namespace Rafat.Gui.PropertysGui
{
    public partial class PropertsUserControl : UserControl
    {
        private static PropertsUserControl? _propertsUserControl;
        private AddPropertyForm addPropertyForm;
        private static Main _main;
        private IDataHelper<Core.Property> dataHelper;
        private List<Core.Property> data;
        private List<int> idDeleteList;
        private DBContext db;
        private readonly testuser pagelist;
        private SortableBindingList<Property> datalist;


        public PropertsUserControl()
        {
            InitializeComponent();
            SetImages();
            dataHelper = new PropertyEF();
            data = new List<Core.Property>();
            idDeleteList = new List<int>();
            db = new DBContext();
            datalist = new SortableBindingList<Property>();
            pagelist = testuser.Instance(_main);
            LoadData();



        }

        private void SetImages()
        {
            orignalImage = Image.FromFile(@"C:\Users\hp.osampc\Downloads\icons8-recent-48.png");
            neImage = Image.FromFile(@"C:\Users\hp.osampc\Downloads\icons8-recent.gif");
        }

        public static PropertsUserControl Instance(Main main)
        {
            _main = main;
            return _propertsUserControl ?? (_propertsUserControl = new PropertsUserControl());
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

                                    var prop = await Task.Run(() =>
                                        dataHelper.Find(id));
                                    await Task.Run(() => dataHelper.Delete(id));

                                    SystemRecordHelper.Add("Delete Property",
                                            $"({prop.DisplayName}) record deleted");

                                }
                                ToastHelper.ShowDeleteToast();
                                LoadData();
                                pagelist.DisplayPropertyCards();
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
                if (data != null && data.Any())
                {
                    datalist = new SortableBindingList<Property>(data);
                    dataGridView1.DataSource = datalist;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Refresh();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No data available.");
                }
                labelNofOfItmes.Text = datalist.Count.ToString();
                // Fill DataGridView

              
                int itemsPerPage = Properties.Settings.Default.NoOfDataGirdViewItems;
                if (datalist.Count <= itemsPerPage)
                {
                    comboBoxNoOfPages.Items.Clear();
                    comboBoxNoOfPages.Items.Add(0);
                }
                else
                {
                    double value = Convert.ToDouble(datalist.Count) / itemsPerPage;
                    int noOfPage = Convert.ToInt32(Math.Ceiling(value));
                    comboBoxNoOfPages.Items.Clear();
                    for (int i = 0; i < noOfPage; i++)
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

                if (textBoxSearch.Text == null)
                {
                    MessageBox.Show("empty search box."); // Display a message box with the result
                }

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

                if (data == null || !data.Any())
                {
                    MessageBox.Show("Search returned no results."); // Display a message box with the result
                }




                datalist = new SortableBindingList<Property>(data);
                dataGridView1.DataSource = datalist;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Refresh();
                // Set Columns Title


                // Show Empty Data
                ShowEmptyDataState();

                // Clear Data

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
            dataGridView1.Columns[0].HeaderCell.Value = "Property ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Property Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Price";
            dataGridView1.Columns[3].HeaderCell.Value = "Property Type";
            dataGridView1.Columns[4].HeaderCell.Value = "Status";
            dataGridView1.Columns[5].HeaderCell.Value = "Listing";
            dataGridView1.Columns[6].HeaderCell.Value = "Description";
            dataGridView1.Columns[7].HeaderCell.Value = "Added Date";
            dataGridView1.Columns[8].HeaderCell.Value = "Updated Date";
            dataGridView1.Columns[9].HeaderCell.Value = "longitude";
            dataGridView1.Columns[10].HeaderCell.Value = "latitude";
            dataGridView1.Columns[11].HeaderCell.Value = "userId";
            dataGridView1.Columns[12].HeaderCell.Value = "agentId";
            dataGridView1.Columns[13].HeaderCell.Value = "";
            dataGridView1.Columns[8].HeaderCell.Value = "";
            dataGridView1.Columns[9].HeaderCell.Value = "";
            dataGridView1.Columns[10].HeaderCell.Value = "";
            dataGridView1.Columns[11].HeaderCell.Value = "";
            dataGridView1.Columns[12].HeaderCell.Value = "";
            dataGridView1.Columns[13].HeaderCell.Value = "";
            dataGridView1.Columns[14].HeaderCell.Value = "";
            dataGridView1.Columns[15].HeaderCell.Value = "";

            // Visible of Columns
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;

        }



        private void Edit()
        {
            // Check Data if not empty
            if (!DgvHelper.IsEmpty(dataGridView1))
            {
                // Get Id
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (addPropertyForm == null || addPropertyForm.IsDisposed)
                {
                    addPropertyForm = new AddPropertyForm(_main, id);
                    addPropertyForm.Show();
                }
                else
                {
                    addPropertyForm.Focus();
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
                    var idlist = datalist.Select(x => x.PropertyId).ToArray();
                    int index = comboBoxNoOfPages.SelectedIndex;
                    int noOfItemIndex = index * Properties.Settings.Default.NoOfDataGirdViewItems;



                    // Fill DataGridView
                 
                    var pagedata = datalist.Where(x => x.PropertyId <= idlist[noOfItemIndex])
                        .Take(Properties.Settings.Default.NoOfDataGirdViewItems).ToList();
                    datalist = new SortableBindingList<Property>(pagedata);
                    dataGridView1.DataSource = datalist;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Refresh();

                    // Show Empty Data
                    ShowEmptyDataState();

                    // Clear Data
                  
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridView1.Columns[e.ColumnIndex];

            // Determine the sort direction
            ListSortDirection sortDirection;
            if (clickedColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending ||
                clickedColumn.HeaderCell.SortGlyphDirection == SortOrder.None)
            {
                sortDirection = ListSortDirection.Ascending;
            }
            else
            {
                sortDirection = ListSortDirection.Descending;
            }

            // Sort the DataGridView by the selected column and direction
            dataGridView1.Sort(clickedColumn, sortDirection);

            // Update the sort glyph
            clickedColumn.HeaderCell.SortGlyphDirection = sortDirection == ListSortDirection.Ascending
                ? SortOrder.Ascending
                : SortOrder.Descending;
        }
    }
}
