namespace Rafat
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            btnHome = new Button();
            btnProperty = new Button();
            btnAgents = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            btnReports = new Button();
            btnAdmin = new Button();
            btnAbout = new Button();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlside = new Panel();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtRecentActivity3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtRecentActivity2 = new TextBox();
            txtRecentActivity1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            MenuProp = new RJControls.RjDropdownMenu(components);
            AddpropertyMenu = new ToolStripMenuItem();
            viewPropertiesToolStripMenuItem = new ToolStripMenuItem();
            viewListToolStripMenuItem = new ToolStripMenuItem();
            MenuCust = new RJControls.RjDropdownMenu(components);
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            viewCustomersToolStripMenuItem = new ToolStripMenuItem();
            MenuOrders = new RJControls.RjDropdownMenu(components);
            makeOrderToolStripMenuItem = new ToolStripMenuItem();
            viewOrdersToolStripMenuItem = new ToolStripMenuItem();
            MenuAgents = new RJControls.RjDropdownMenu(components);
            addAgentToolStripMenuItem = new ToolStripMenuItem();
            viewAgentsToolStripMenuItem = new ToolStripMenuItem();
            MenuUsers = new RJControls.RjDropdownMenu(components);
            addUserToolStripMenuItem = new ToolStripMenuItem();
            viewUsersToolStripMenuItem = new ToolStripMenuItem();
            pofileMenu = new RJControls.RjDropdownMenu(components);
            LogOut = new ToolStripMenuItem();
            flowLayoutPanelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MenuProp.SuspendLayout();
            MenuCust.SuspendLayout();
            MenuOrders.SuspendLayout();
            MenuAgents.SuspendLayout();
            MenuUsers.SuspendLayout();
            pofileMenu.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.Controls.Add(btnHome);
            flowLayoutPanelNavBar.Controls.Add(btnProperty);
            flowLayoutPanelNavBar.Controls.Add(btnAgents);
            flowLayoutPanelNavBar.Controls.Add(btnOrders);
            flowLayoutPanelNavBar.Controls.Add(btnCustomers);
            flowLayoutPanelNavBar.Controls.Add(btnReports);
            flowLayoutPanelNavBar.Controls.Add(btnAdmin);
            flowLayoutPanelNavBar.Controls.Add(btnAbout);
            flowLayoutPanelNavBar.Controls.Add(pictureBox3);
            flowLayoutPanelNavBar.Controls.Add(label5);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(3);
            flowLayoutPanelNavBar.RightToLeft = RightToLeft.No;
            flowLayoutPanelNavBar.Size = new Size(1583, 64);
            flowLayoutPanelNavBar.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = Properties.Resources.icons8_dashboard_32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(8, 8);
            btnHome.Margin = new Padding(5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(177, 50);
            btnHome.TabIndex = 0;
            btnHome.Text = "   Dashboard";
            toolTip1.SetToolTip(btnHome, "Dashboard");
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnProperty
            // 
            btnProperty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProperty.Image = Properties.Resources.icons8_mortgage_32;
            btnProperty.ImageAlign = ContentAlignment.MiddleLeft;
            btnProperty.Location = new Point(195, 8);
            btnProperty.Margin = new Padding(5);
            btnProperty.Name = "btnProperty";
            btnProperty.Size = new Size(165, 50);
            btnProperty.TabIndex = 1;
            btnProperty.Text = "     Property";
            toolTip1.SetToolTip(btnProperty, "Property Manage");
            btnProperty.UseVisualStyleBackColor = true;
            btnProperty.Click += btnProperty_Click;
            // 
            // btnAgents
            // 
            btnAgents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgents.Image = Properties.Resources.icons8_agent_32;
            btnAgents.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgents.Location = new Point(370, 8);
            btnAgents.Margin = new Padding(5);
            btnAgents.Name = "btnAgents";
            btnAgents.Size = new Size(150, 50);
            btnAgents.TabIndex = 2;
            btnAgents.Text = "  Agents";
            toolTip1.SetToolTip(btnAgents, "Agent Manage");
            btnAgents.UseVisualStyleBackColor = true;
            btnAgents.Click += btnAgents_Click;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrders.Image = Properties.Resources.icons8_purchase_order_32;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(530, 8);
            btnOrders.Margin = new Padding(5);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(150, 50);
            btnOrders.TabIndex = 8;
            btnOrders.Text = "    Orders";
            toolTip1.SetToolTip(btnOrders, "Orders Manage");
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.Image = Properties.Resources.icons8_users_32px;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(690, 8);
            btnCustomers.Margin = new Padding(5);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(186, 50);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "   Customers";
            toolTip1.SetToolTip(btnCustomers, "Customer Manage");
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.Image = Properties.Resources.icons8_Business_Report_32px;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(886, 8);
            btnReports.Margin = new Padding(5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(162, 50);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            toolTip1.SetToolTip(btnReports, "Report Maker");
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Image = Properties.Resources.icons8_admin_settings_male_35;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(1058, 8);
            btnAdmin.Margin = new Padding(5);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(235, 50);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "   Administration";
            toolTip1.SetToolTip(btnAdmin, "About Page");
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.Image = Properties.Resources.icons8_about_32px;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(1303, 8);
            btnAbout.Margin = new Padding(5);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(150, 50);
            btnAbout.TabIndex = 7;
            btnAbout.Text = "    About";
            toolTip1.SetToolTip(btnAbout, "About Page");
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.icons8_user_96;
            pictureBox3.Location = new Point(1461, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(1541, 18);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(0, 29);
            label5.TabIndex = 11;
            label5.Click += label5_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(344, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1236, 935);
            panelContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.541378F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.4586258F));
            tableLayoutPanel1.Controls.Add(pnlside, 0, 0);
            tableLayoutPanel1.Controls.Add(panelContainer, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1583, 941);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlside
            // 
            pnlside.BackColor = SystemColors.InactiveBorder;
            pnlside.Controls.Add(splitContainer1);
            pnlside.Dock = DockStyle.Fill;
            pnlside.Location = new Point(5, 5);
            pnlside.Margin = new Padding(5);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(331, 931);
            pnlside.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(331, 931);
            splitContainer1.SplitterDistance = 365;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Work_in_progress1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRecentActivity3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtRecentActivity2);
            groupBox1.Controls.Add(txtRecentActivity1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(331, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtRecentActivity3
            // 
            txtRecentActivity3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecentActivity3.BackColor = Color.White;
            txtRecentActivity3.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtRecentActivity3.ForeColor = Color.DarkBlue;
            txtRecentActivity3.Location = new Point(4, 265);
            txtRecentActivity3.Margin = new Padding(0);
            txtRecentActivity3.Name = "txtRecentActivity3";
            txtRecentActivity3.ReadOnly = true;
            txtRecentActivity3.Size = new Size(323, 28);
            txtRecentActivity3.TabIndex = 8;
            txtRecentActivity3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 29);
            label4.Name = "label4";
            label4.Size = new Size(189, 29);
            label4.TabIndex = 7;
            label4.Text = "Recent Activities";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 507);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 6;
            label3.Text = "Erigavo,Somaliland";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(209, 529);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(118, 29);
            label2.TabIndex = 5;
            label2.Text = "8/12/2024";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(209, 500);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 4;
            label1.Text = "12:43:22";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.icons8_checklist_48;
            pictureBox2.Location = new Point(264, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtRecentActivity2
            // 
            txtRecentActivity2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecentActivity2.BackColor = Color.White;
            txtRecentActivity2.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtRecentActivity2.ForeColor = Color.DarkBlue;
            txtRecentActivity2.Location = new Point(4, 181);
            txtRecentActivity2.Margin = new Padding(0);
            txtRecentActivity2.Name = "txtRecentActivity2";
            txtRecentActivity2.ReadOnly = true;
            txtRecentActivity2.Size = new Size(323, 28);
            txtRecentActivity2.TabIndex = 1;
            txtRecentActivity2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRecentActivity1
            // 
            txtRecentActivity1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecentActivity1.BackColor = Color.White;
            txtRecentActivity1.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtRecentActivity1.ForeColor = Color.DarkBlue;
            txtRecentActivity1.Location = new Point(4, 119);
            txtRecentActivity1.Margin = new Padding(0);
            txtRecentActivity1.Name = "txtRecentActivity1";
            txtRecentActivity1.ReadOnly = true;
            txtRecentActivity1.Size = new Size(323, 28);
            txtRecentActivity1.TabIndex = 0;
            txtRecentActivity1.Text = "(guriga cabdale id 123) record deleted";
            txtRecentActivity1.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MenuProp
            // 
            MenuProp.ImageScalingSize = new Size(24, 24);
            MenuProp.IsMainMenu = false;
            MenuProp.Items.AddRange(new ToolStripItem[] { AddpropertyMenu, viewPropertiesToolStripMenuItem, viewListToolStripMenuItem });
            MenuProp.MenuItemHeight = 25;
            MenuProp.MenuItemTextColor = Color.Empty;
            MenuProp.Name = "MenuProp";
            MenuProp.PrimaryColor = Color.Empty;
            MenuProp.Size = new Size(221, 114);
            // 
            // AddpropertyMenu
            // 
            AddpropertyMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddpropertyMenu.Margin = new Padding(4);
            AddpropertyMenu.Name = "AddpropertyMenu";
            AddpropertyMenu.Size = new Size(220, 32);
            AddpropertyMenu.Text = "Add Property";
            AddpropertyMenu.Click += AddpropertyMenu_Click;
            // 
            // viewPropertiesToolStripMenuItem
            // 
            viewPropertiesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewPropertiesToolStripMenuItem.Margin = new Padding(3);
            viewPropertiesToolStripMenuItem.Name = "viewPropertiesToolStripMenuItem";
            viewPropertiesToolStripMenuItem.Size = new Size(220, 32);
            viewPropertiesToolStripMenuItem.Text = "View Properties";
            viewPropertiesToolStripMenuItem.Click += viewPropertiesToolStripMenuItem_Click;
            // 
            // viewListToolStripMenuItem
            // 
            viewListToolStripMenuItem.Name = "viewListToolStripMenuItem";
            viewListToolStripMenuItem.Size = new Size(220, 32);
            // 
            // MenuCust
            // 
            MenuCust.ImageScalingSize = new Size(24, 24);
            MenuCust.IsMainMenu = false;
            MenuCust.Items.AddRange(new ToolStripItem[] { addCustomerToolStripMenuItem, viewCustomersToolStripMenuItem });
            MenuCust.MenuItemHeight = 25;
            MenuCust.MenuItemTextColor = Color.Empty;
            MenuCust.Name = "MenuCust";
            MenuCust.PrimaryColor = Color.Empty;
            MenuCust.Size = new Size(228, 82);
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerToolStripMenuItem.Margin = new Padding(4);
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(227, 32);
            addCustomerToolStripMenuItem.Text = "Add Customer";
            addCustomerToolStripMenuItem.Click += addCustomerToolStripMenuItem_Click;
            // 
            // viewCustomersToolStripMenuItem
            // 
            viewCustomersToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewCustomersToolStripMenuItem.Margin = new Padding(3);
            viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            viewCustomersToolStripMenuItem.Size = new Size(227, 32);
            viewCustomersToolStripMenuItem.Text = "View Customers";
            viewCustomersToolStripMenuItem.Click += viewCustomersToolStripMenuItem_Click;
            // 
            // MenuOrders
            // 
            MenuOrders.ImageScalingSize = new Size(24, 24);
            MenuOrders.IsMainMenu = false;
            MenuOrders.Items.AddRange(new ToolStripItem[] { makeOrderToolStripMenuItem, viewOrdersToolStripMenuItem });
            MenuOrders.MenuItemHeight = 25;
            MenuOrders.MenuItemTextColor = Color.Empty;
            MenuOrders.Name = "MenuOrders";
            MenuOrders.PrimaryColor = Color.Empty;
            MenuOrders.Size = new Size(193, 82);
            // 
            // makeOrderToolStripMenuItem
            // 
            makeOrderToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            makeOrderToolStripMenuItem.Margin = new Padding(4);
            makeOrderToolStripMenuItem.Name = "makeOrderToolStripMenuItem";
            makeOrderToolStripMenuItem.Size = new Size(192, 32);
            makeOrderToolStripMenuItem.Text = "Make Order";
            makeOrderToolStripMenuItem.Click += makeOrderToolStripMenuItem_Click;
            // 
            // viewOrdersToolStripMenuItem
            // 
            viewOrdersToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewOrdersToolStripMenuItem.Margin = new Padding(3);
            viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            viewOrdersToolStripMenuItem.Size = new Size(192, 32);
            viewOrdersToolStripMenuItem.Text = "View Orders";
            viewOrdersToolStripMenuItem.Click += viewOrdersToolStripMenuItem_Click;
            // 
            // MenuAgents
            // 
            MenuAgents.ImageScalingSize = new Size(24, 24);
            MenuAgents.IsMainMenu = false;
            MenuAgents.Items.AddRange(new ToolStripItem[] { addAgentToolStripMenuItem, viewAgentsToolStripMenuItem });
            MenuAgents.MenuItemHeight = 25;
            MenuAgents.MenuItemTextColor = Color.Empty;
            MenuAgents.Name = "MenuAgents";
            MenuAgents.PrimaryColor = Color.Empty;
            MenuAgents.Size = new Size(195, 82);
            // 
            // addAgentToolStripMenuItem
            // 
            addAgentToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addAgentToolStripMenuItem.Margin = new Padding(4);
            addAgentToolStripMenuItem.Name = "addAgentToolStripMenuItem";
            addAgentToolStripMenuItem.Size = new Size(194, 32);
            addAgentToolStripMenuItem.Text = "Add Agent";
            addAgentToolStripMenuItem.Click += addAgentToolStripMenuItem_Click;
            // 
            // viewAgentsToolStripMenuItem
            // 
            viewAgentsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewAgentsToolStripMenuItem.Margin = new Padding(3);
            viewAgentsToolStripMenuItem.Name = "viewAgentsToolStripMenuItem";
            viewAgentsToolStripMenuItem.Size = new Size(194, 32);
            viewAgentsToolStripMenuItem.Text = "View Agents";
            viewAgentsToolStripMenuItem.Click += viewAgentsToolStripMenuItem_Click;
            // 
            // MenuUsers
            // 
            MenuUsers.ImageScalingSize = new Size(24, 24);
            MenuUsers.IsMainMenu = false;
            MenuUsers.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, viewUsersToolStripMenuItem });
            MenuUsers.MenuItemHeight = 25;
            MenuUsers.MenuItemTextColor = Color.Empty;
            MenuUsers.Name = "MenuUsers";
            MenuUsers.PrimaryColor = Color.Empty;
            MenuUsers.Size = new Size(184, 82);
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addUserToolStripMenuItem.Margin = new Padding(4);
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(183, 32);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // viewUsersToolStripMenuItem
            // 
            viewUsersToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewUsersToolStripMenuItem.Margin = new Padding(3);
            viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            viewUsersToolStripMenuItem.Size = new Size(183, 32);
            viewUsersToolStripMenuItem.Text = "View Users";
            viewUsersToolStripMenuItem.Click += viewUsersToolStripMenuItem_Click;
            // 
            // pofileMenu
            // 
            pofileMenu.ImageScalingSize = new Size(24, 24);
            pofileMenu.IsMainMenu = false;
            pofileMenu.Items.AddRange(new ToolStripItem[] { LogOut });
            pofileMenu.MenuItemHeight = 25;
            pofileMenu.MenuItemTextColor = Color.Empty;
            pofileMenu.Name = "pofileMenu";
            pofileMenu.PrimaryColor = Color.Empty;
            pofileMenu.Size = new Size(172, 36);
            // 
            // LogOut
            // 
            LogOut.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LogOut.Image = Properties.Resources.icons8_logout_30;
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(171, 32);
            LogOut.Text = "Log Out";
            LogOut.Click += LogOut_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 1005);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adeeg Real State MS";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanelNavBar.ResumeLayout(false);
            flowLayoutPanelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlside.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            MenuProp.ResumeLayout(false);
            MenuCust.ResumeLayout(false);
            MenuOrders.ResumeLayout(false);
            MenuAgents.ResumeLayout(false);
            MenuUsers.ResumeLayout(false);
            pofileMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button btnHome;
        private Button btnProperty;
        private Button btnAgents;
        private Button btnCustomers;
        private Button btnReports;
        private Button btnAbout;
        public Panel panelContainer;
        private ToolTip toolTip1;
        private Button btnOrders;
       
      
        public TableLayoutPanel tableLayoutPanel1;
        private Panel pnlside;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TextBox txtRecentActivity1;
        private TextBox txtRecentActivity2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btnAdmin;
        private RJControls.RjDropdownMenu MenuAgents;
        private RJControls.RjDropdownMenu MenuOrders;
        private RJControls.RjDropdownMenu MenuCust;
        private RJControls.RjDropdownMenu MenuUsers;
       
        private Label label1;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private TextBox txtRecentActivity3;
        private RJControls.RjDropdownMenu MenuProp;
        private ToolStripMenuItem AddpropertyMenu;
        private ToolStripMenuItem viewPropertiesToolStripMenuItem;
        private ToolStripMenuItem viewListToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem viewUsersToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem viewCustomersToolStripMenuItem;
        private ToolStripMenuItem makeOrderToolStripMenuItem;
        private ToolStripMenuItem viewOrdersToolStripMenuItem;
        private ToolStripMenuItem addAgentToolStripMenuItem;
        private ToolStripMenuItem viewAgentsToolStripMenuItem;
        private PictureBox pictureBox3;
        private Label label5;
        private RJControls.RjDropdownMenu pofileMenu;
        private ToolStripMenuItem LogOut;
    }
}
