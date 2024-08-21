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
using Rafat.Gui.PropertysGui;

namespace Rafat.Gui.test;

public partial class testuser : UserControl
{
    private static testuser? testusercontrol;
    private AddPropertyForm addPropertyForm;
    private static Main _main;
    private IDataHelper<Core.Property> dataHelper;
    private List<Core.Property> data;
    private List<int> idDeleteList;
    private DBContext db;
    private DataGridView dataGridView1;

    public testuser()
    {
        InitializeComponent();
        // SetImages();
        dataHelper = new PropertyEF();
        data = new List<Core.Property>();
        idDeleteList = new List<int>();
        db = new DBContext();

        DisplayPropertyCards();


        //LoadData();

        DataGridView dataGridView1 = new DataGridView();
    }
    private void DisplayPropertyCards()
    {
        flowLayoutPanel1.Controls.Clear();
        var propertyCards = LoadPropertyCards();

        foreach (var card in propertyCards)
        {
            var propertyCardControl = new PropertyCard();
            propertyCardControl.SetData(card.PropertyId, card.PropertyImage, card.PropertyName, $"${card.Price:F2}");

            var panel = new Panel
            {
                Width = propertyCardControl.Width + 15, // Add padding to the panel width
                Height = propertyCardControl.Height + 15, // Add padding to the panel height
                Padding = new Padding(10) // Add some padding inside the panel
            };

            propertyCardControl.Dock = DockStyle.Fill; // Ensure UserControl fills the panel
            panel.Controls.Add(propertyCardControl);

            flowLayoutPanel1.Controls.Add(panel);


            flowLayoutPanel1.Controls.Add(panel);
        }
    }



    private List<PropertyCardcore> LoadPropertyCards()
    {
        using (var context = new DBContext())
        {
            var properties = context.Properties.ToList();
            var propertyCards = new List<PropertyCardcore>();

            foreach (var property in properties)
            {
                var firstImageFile = context.PropertyFiles
                    .Where(pf => pf.PropertyId == property.PropertyId)
                    .OrderBy(pf => pf.FileName)
                    .FirstOrDefault();

                Image propertyImage = ByteArrayToImage(firstImageFile.FileData);

                propertyCards.Add(new PropertyCardcore
                {
                    PropertyId = property.PropertyId,
                    PropertyImage = propertyImage,
                    PropertyName = property.PropertyName,
                    Price = property.Price
                });
            }

            return propertyCards;
        }
    }

    private Image ByteArrayToImage(byte[] byteArray)
    {
        using (var ms = new MemoryStream(byteArray))
        {
            return Image.FromStream(ms);
        }
    }



    private void SetImages()
    {
        orignalImage = Image.FromFile(@"C:\Users\hp.osampc\Downloads\icons8-recent-48.png");
        neImage = Image.FromFile(@"C:\Users\hp.osampc\Downloads\icons8-recent.gif");
    }

    public static testuser Instance(Main main)
    {
        _main = main;
        var instance = testusercontrol;
        if (instance != null && !instance.IsDisposed)
        {
            return instance;
        }

        return (testusercontrol = new testuser());
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
                                SystemRecordHelper.Add("Delete Property",
                                    $"the property ID ({id.ToString()})");
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





            dataGridView1.DataSource = data.ToList();
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
    }

    private void ShowServerErrorState()
    {
            
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
                var idlist = data.Select(x => x.PropertyId).ToArray();
                // int index = comboBoxNoOfPages.SelectedIndex;
                // int noOfItemIndex = index * Properties.Settings.Default.NoOfDataGirdViewItems;

                // Fill DataGridView
                // dataGridView1.DataSource = data.Where(x => x.PropertyId <= idlist[noOfItemIndex])
                //    .Take(Properties.Settings.Default.NoOfDataGirdViewItems).ToList();

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



    //private void buttonExportDataGridView_Click(object sender, EventArgs e)
    //{
    //    // Get Data
    //    var data = (List<Core.Property>)dataGridView1.DataSource;
    //    ExportExcel(data);

    //}

    //private void ExportExcel(List<Core.Property> data)
    //{
    //    // Define Data Table
    //    DataTable dataTable = new DataTable();

    //    // Convert to Data Table
    //    using (var reader = FastMember.ObjectReader.Create(data))
    //    {
    //        dataTable.Load(reader);
    //    }

    //    // Re-Set DataTable
    //    dataTable = arrangedDataTable(dataTable);

    //    // Send to export
    //    ExcelHelper.Export(dataTable, "Users");
    //}
    //private DataTable arrangedDataTable(DataTable dataTable)
    //{
    //    dataTable.Columns["Id"].SetOrdinal(0);
    //    dataTable.Columns["Id"].ColumnName = "ت";

    //    dataTable.Columns["FullName"].SetOrdinal(1);
    //    dataTable.Columns["FullName"].ColumnName = "الاسم الكامل";


    //    dataTable.Columns["UserName"].SetOrdinal(2);
    //    dataTable.Columns["UserName"].ColumnName = "اسم المستخدم";


    //    dataTable.Columns["Password"].SetOrdinal(3);
    //    dataTable.Columns["Password"].ColumnName = "كلمة السر";

    //    dataTable.Columns["Role"].SetOrdinal(4);
    //    dataTable.Columns["Role"].ColumnName = "الصلاحية";

    //    dataTable.Columns["IsSecondaryUser"].SetOrdinal(5);
    //    dataTable.Columns["IsSecondaryUser"].ColumnName = "هل المستخدم ثانوي";

    //    dataTable.Columns["UserId"].SetOrdinal(6);
    //    dataTable.Columns["UserId"].ColumnName = "معرف المستخدم";

    //    dataTable.Columns["Phone"].SetOrdinal(7);
    //    dataTable.Columns["Phone"].ColumnName = "رقم الهاتف ";


    //    dataTable.Columns["Email"].SetOrdinal(8);
    //    dataTable.Columns["Email"].ColumnName = "البريد الالكتروني  ";


    //    dataTable.Columns["Address"].SetOrdinal(9);
    //    dataTable.Columns["Address"].ColumnName = "العنوان  ";


    //    dataTable.Columns["CreatedDate"].SetOrdinal(10);
    //    dataTable.Columns["CreatedDate"].ColumnName = "تاريخ الانشاء  ";


    //    dataTable.Columns["EditedDate"].SetOrdinal(11);
    //    dataTable.Columns["EditedDate"].ColumnName = "تاريخ التعديل  ";


    //    // Removed columns
    //    dataTable.Columns.Remove("Roles");
    //    dataTable.Columns.Remove("SystemRecords");

    //    return dataTable;
    //} 

    public void loading(string state)
    {

           


    }

    private void timer1_Tick(object sender, EventArgs e)
    {
           
    }

    private void propertyCard2_Load(object sender, EventArgs e)
    {

    }
}