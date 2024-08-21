using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Data.EF;
using Rafat.Gui.AgentsGui;
using Rafat.Gui.CustomersGui;
using Rafat.Gui.HomeGui;
using Rafat.Gui.OrdersGui;
using Rafat.Gui.PropertysGui;
using Rafat.Gui.ReportGui;
using Rafat.Gui.test;
using Rafat.Gui.UsersGui;
using Rafat.Properties;

namespace Rafat;

public partial class Main : Form
{

#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    private static readonly Main? _main;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
    private readonly PageHelper pageHelper;
    private AddAgentForm? addAgentform;
    private AddCustomerForm? addCustomerForm;
    private AddOrderForm? addOrderForm;
    private AddPropertyForm? addPropertyForm;
    private AddUserForm? addUserForm;
    private ReportMaker? reportMaker;
    private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
    private LoginForm? loginForm;
    // ReSharper disable once RedundantDefaultMemberInitializer
    private bool _isLoggingOut = false;
    public Main()
    {
        InitializeComponent();

        pageHelper = new PageHelper(this);

        // Set Home Page
        pageHelper.SetPage(testuser.Instance(_main!));
        // Get And Set The Window State
        SetScreenState(Settings.Default.IsMaxScreen);

        dataHelperForSystemRecords = new SystemRecordsEF();

        UpdateRecentActivities();

        SystemRecordHelper.ActivityLogged += UpdateRecentActivities;



        SetRoles();
        SetTime();

    }

    private async void UpdateRecentActivities()
    {
        var recentActivities = await Task.Run((() => dataHelperForSystemRecords.GetAllData().Select(x => x.Description).ToList()));

        txtRecentActivity1.Text = recentActivities[0];
        txtRecentActivity2.Text = recentActivities[1];
        txtRecentActivity3.Text = recentActivities[2];
    }


    // Test
    private void SetRoles()
    {
        
        label5.Text = LocalUser.UserName;

        if (LocalUser.Role != "Admin")
        {
            btnAdmin.Enabled = false;
        }

    }

    private void SetTime()
    {
        label2.Text = DateTime.Now.ToString("yyyy-M-d dddd");

    }



    private void SetScreenState(bool isMax)
    {
        WindowState = isMax ? FormWindowState.Maximized : FormWindowState.Normal;
    }

    private void SaveWindowStateSettings()
    {
        // Save Window State
        if (WindowState == FormWindowState.Maximized)
        {
            Settings.Default.IsMaxScreen = true;
            Settings.Default.Save();
        }
        else
        {
            Settings.Default.IsMaxScreen = false;
            Settings.Default.Save();
        }
    }

    // Navigation buttons Events
    private void btnHome_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(HomeUserControl.Instance());
    }

    private void btnProperty_Click(object sender, EventArgs e)
    {
        MenuProp.Show(btnProperty, btnProperty.Width, 0);
    }

    private void btnAgents_Click(object sender, EventArgs e)
    {
        MenuAgents.Show(btnAgents, btnAgents.Width, 0);
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
        MenuOrders.Show(btnOrders, btnOrders.Width, 0);
    }

    private void btnCustomers_Click(object sender, EventArgs e)
    {
        MenuCust.Show(btnCustomers, btnCustomers.Width, 0);
    }

    private void btnReports_Click(object sender, EventArgs e)
    {
        if (reportMaker == null || reportMaker.IsDisposed)
        {
            reportMaker = new ReportMaker();
            reportMaker.Show();
        }
        else
        {
            reportMaker.Show();
            reportMaker.Focus();
        }
    }

    private void btnAdmin_Click(object sender, EventArgs e)
    {
        MenuUsers.Show(btnAdmin, btnAdmin.Width, 0);
    }

    // SubMenu Events
    private void AddpropertyMenu_Click(object sender, EventArgs e)
    {
        if (addPropertyForm == null || addPropertyForm.IsDisposed)
        {
            addPropertyForm = new AddPropertyForm(_main!, 0);
            addPropertyForm.Show();
        }
        else
        {
            addPropertyForm.Focus();
        }
    }

    private void viewPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(PropertsUserControl.Instance(_main!));
    }

    private void addAgentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (addAgentform == null || addAgentform.IsDisposed)
        {
            addAgentform = new AddAgentForm(_main!, 0);

            addAgentform.Show();
        }
        else
        {
            addAgentform.Focus();
        }
    }

    private void viewAgentsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(AgentsUserControl.Instance(_main!));
    }

    private void makeOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (addOrderForm == null || addOrderForm.IsDisposed)
        {
            addOrderForm = new AddOrderForm(_main!, 0);
            addOrderForm.Show();
        }
        else
        {
            addOrderForm.Focus();
        }
    }

    private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(OrdersUserControl.Instance(_main!));
    }

    private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (addCustomerForm == null || addCustomerForm.IsDisposed)
        {
            addCustomerForm = new AddCustomerForm(_main!, 0);

            addCustomerForm.Show();
        }
        else
        {
            addCustomerForm.Focus();
        }
    }

    private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(CustomersUserControl.Instance(_main!));
    }

    private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (addUserForm == null || addUserForm.IsDisposed)
        {
            addUserForm = new AddUserForm(_main!, 0);
            addUserForm.Show();
        }
        else
        {
            addUserForm.Focus();
        }
    }

    private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageHelper.SetPage(UsersUserControl.Instance(_main!));
    }

    private void timer1_Tick(object sender, EventArgs e)
    {

        label1.Text = DateTime.Now.ToString("HH:mm:ss");


    }


    public async void UpdateRecentActivities(object sender, EventArgs eventArgs)
    {
        var recentActivities = await Task.Run((() => dataHelperForSystemRecords.GetAllData().Select(x => x.Description).ToList()));

        txtRecentActivity1.Text = recentActivities[0];
        txtRecentActivity2.Text = recentActivities[1];
        txtRecentActivity3.Text = recentActivities[2];
    }


    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        SaveWindowStateSettings();
        SystemRecordHelper.ActivityLogged -= UpdateRecentActivities;

        if (!_isLoggingOut)
        {
     
            Application.Exit();
        }


    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        pofileMenu.Show(pictureBox3, pictureBox3.Width, 0);
    }

    private void label5_Click(object sender, EventArgs e)
    {
        pofileMenu.Show(label5, label5.Width, 0);
    }

    private void LogOut_Click(object sender, EventArgs e)
    {
         _isLoggingOut = true;

        if (loginForm == null || loginForm.IsDisposed)
        {
            loginForm = new LoginForm();

            loginForm.Show();
            this.Close();
        }
        else
        {
            loginForm.Show();
            loginForm.Focus();
            this.Close();
        }
    }
}