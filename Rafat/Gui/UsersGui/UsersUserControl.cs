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
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Rafat.Gui.loading;

namespace Rafat.Gui.UsersGui
{
    public partial class UsersUserControl : UserControl
    {
        private static UsersUserControl? _usersUserControl;
        private AddUserForm addUserForm;
        private static Main _main;
        private IDataHelper<Core.Users> dataHelper;
        private List<Core.Users> data;
        private List<int> idDeleteList;



        public UsersUserControl()
        {
            InitializeComponent();
            SetImages();
            dataHelper = new UsersEF();
            data = new List<Core.Users>();
            idDeleteList = new List<int>();
            LoadData();



        }

        public static UsersUserControl Instance(Main main)
        {
            _main = main;
            return _usersUserControl ?? (_usersUserControl = new UsersUserControl());
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
                                    SystemRecordHelper.Add("حذف مستخدم",
                   $"تم حذف مستخدم حالي يحمل الرقم التعريفي {id.ToString()}");
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

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            // Show Loading
            // LoadingUserControl.Instance(panel3).Show();
            //loading("Show");
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
                loading("Hide");

                ExportExcel(data);
            }
            else
            {
                // No Connection
                loading("Hide");
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            // LoadingUserControl.Instance(panel3).Hide();

            //loading("Hide");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        // Methods

        public async void LoadData()
        {

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

            loading("hide");


        }

        public async void Search()
        {
            // Show Loading
            loading("Show");
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {

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
            // Set Title and Description
            labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
            labelStateDescription.Text = Properties.Resources.ServerErrorDescription;
            panelState.Visible = true;
        }

        private void SetColumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Full Name";
            dataGridView1.Columns[2].HeaderCell.Value = "User Name";
            dataGridView1.Columns[3].HeaderCell.Value = "";
            dataGridView1.Columns[4].HeaderCell.Value = "Role";
            dataGridView1.Columns[5].HeaderCell.Value = "";
            dataGridView1.Columns[6].HeaderCell.Value = "";
            dataGridView1.Columns[7].HeaderCell.Value = "Phone Number";
            dataGridView1.Columns[8].HeaderCell.Value = "Email Address";
            dataGridView1.Columns[9].HeaderCell.Value = "Address";
            dataGridView1.Columns[10].HeaderCell.Value = "Creation Date";
            dataGridView1.Columns[11].HeaderCell.Value = "Updated Date";

            // Visible of Columns
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;


        }



        private void Edit()
        {
            // Check Data if not empty
            if (!DgvHelper.IsEmpty(dataGridView1))
            {
                // Get Id
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (addUserForm == null || addUserForm.IsDisposed)
                {
                    addUserForm = new AddUserForm(_main, id);
                    addUserForm.Show();
                }
                else
                {
                    addUserForm.Focus();
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
                    var idlist = data.Select(x => x.Id).ToArray();
                    int index = comboBoxNoOfPages.SelectedIndex;
                    int noOfItemIndex = index * Properties.Settings.Default.NoOfDataGirdViewItems;

                    // Fill DataGridView
                    dataGridView1.DataSource = data.Where(x => x.Id <= idlist[noOfItemIndex])
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

        private void buttonExportDataGridView_Click(object sender, EventArgs e)
        {
            // Get Data
            var data = (List<Core.Users>)dataGridView1.DataSource;
            ExportExcel(data);

        }

        private void ExportExcel(List<Core.Users> data)
        {
            // Define Data Table
            DataTable dataTable = new DataTable();

            // Convert to Data Table
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }

            // Re-Set DataTable
            dataTable = arrangedDataTable(dataTable);

            // Send to export
            ExcelHelper.Export(dataTable, "Users");
        }
        private DataTable arrangedDataTable(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "ت";

            dataTable.Columns["FullName"].SetOrdinal(1);
            dataTable.Columns["FullName"].ColumnName = "الاسم الكامل";


            dataTable.Columns["UserName"].SetOrdinal(2);
            dataTable.Columns["UserName"].ColumnName = "اسم المستخدم";


            dataTable.Columns["Password"].SetOrdinal(3);
            dataTable.Columns["Password"].ColumnName = "كلمة السر";

            dataTable.Columns["Role"].SetOrdinal(4);
            dataTable.Columns["Role"].ColumnName = "الصلاحية";

            dataTable.Columns["IsSecondaryUser"].SetOrdinal(5);
            dataTable.Columns["IsSecondaryUser"].ColumnName = "هل المستخدم ثانوي";

            dataTable.Columns["UserId"].SetOrdinal(6);
            dataTable.Columns["UserId"].ColumnName = "معرف المستخدم";

            dataTable.Columns["Phone"].SetOrdinal(7);
            dataTable.Columns["Phone"].ColumnName = "رقم الهاتف ";


            dataTable.Columns["Email"].SetOrdinal(8);
            dataTable.Columns["Email"].ColumnName = "البريد الالكتروني  ";


            dataTable.Columns["Address"].SetOrdinal(9);
            dataTable.Columns["Address"].ColumnName = "العنوان  ";


            dataTable.Columns["CreatedDate"].SetOrdinal(10);
            dataTable.Columns["CreatedDate"].ColumnName = "تاريخ الانشاء  ";


            dataTable.Columns["EditedDate"].SetOrdinal(11);
            dataTable.Columns["EditedDate"].ColumnName = "تاريخ التعديل  ";


            // Removed columns
            dataTable.Columns.Remove("Roles");
            dataTable.Columns.Remove("SystemRecords");

            return dataTable;
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

        private void SetImages()
        {
            orignalImage = buttonRefresh.Image;
            neImage = Properties.Resources.icons8_recent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonRefresh.Image = orignalImage;
            timer1.Stop();

        }
    }
}
