namespace Rafat.Gui.PropertysGui
{
    partial class AddPropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPropertyForm));
            tabControl1 = new TabControl();
            tabinfo = new TabPage();
            richTextBox1 = new RichTextBox();
            label20 = new Label();
            groupBox2 = new GroupBox();
            cmbListing = new ComboBox();
            cmbStatus = new ComboBox();
            cmbType = new ComboBox();
            cmpAgent = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            label16 = new Label();
            label17 = new Label();
            label15 = new Label();
            txtprice = new TextBox();
            txtName = new TextBox();
            label14 = new Label();
            tabmap = new TabPage();
            btnpick = new Button();
            txtLat = new TextBox();
            txtLong = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            pnlMap = new Panel();
            gmap3 = new GMap.NET.WindowsForms.GMapControl();
            tabimage = new TabPage();
            btnloadimages = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            tabHistory = new TabPage();
            picrented = new PictureBox();
            picava = new PictureBox();
            picsold = new PictureBox();
            groupBox1 = new GroupBox();
            txtHOdate = new TextBox();
            label26 = new Label();
            txtHOtype = new TextBox();
            label25 = new Label();
            txtHCname = new TextBox();
            label24 = new Label();
            label12 = new Label();
            label10 = new Label();
            textBoxPhone = new TextBox();
            label9 = new Label();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            buttonSave = new Button();
            checkBoxSecondayUser = new CheckBox();
            comboBoxUserId = new ComboBox();
            label1 = new Label();
            label11 = new Label();
            label13 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFullName = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBoxUserName = new TextBox();
            label6 = new Label();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            panel1 = new Panel();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tabinfo.SuspendLayout();
            groupBox2.SuspendLayout();
            tabmap.SuspendLayout();
            pnlMap.SuspendLayout();
            tabimage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picrented).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picsold).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabinfo);
            tabControl1.Controls.Add(tabmap);
            tabControl1.Controls.Add(tabimage);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1046, 719);
            tabControl1.TabIndex = 2;
            // 
            // tabinfo
            // 
            tabinfo.Controls.Add(richTextBox1);
            tabinfo.Controls.Add(label20);
            tabinfo.Controls.Add(groupBox2);
            tabinfo.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabinfo.Location = new Point(4, 38);
            tabinfo.Name = "tabinfo";
            tabinfo.Padding = new Padding(3);
            tabinfo.Size = new Size(1038, 677);
            tabinfo.TabIndex = 1;
            tabinfo.Text = "Basic Info";
            tabinfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(169, 369);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(781, 188);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(29, 52, 122);
            label20.Location = new Point(16, 355);
            label20.Name = "label20";
            label20.Size = new Size(147, 32);
            label20.TabIndex = 16;
            label20.Text = "Description :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbListing);
            groupBox2.Controls.Add(cmbStatus);
            groupBox2.Controls.Add(cmbType);
            groupBox2.Controls.Add(cmpAgent);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtprice);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label14);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(29, 52, 122);
            groupBox2.Location = new Point(8, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1025, 322);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Property Information";
            // 
            // cmbListing
            // 
            cmbListing.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbListing.FormattingEnabled = true;
            cmbListing.Location = new Point(760, 101);
            cmbListing.Name = "cmbListing";
            cmbListing.Size = new Size(259, 38);
            cmbListing.TabIndex = 15;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(760, 204);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(259, 38);
            cmbStatus.TabIndex = 14;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(426, 205);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(259, 38);
            cmbType.TabIndex = 13;
            // 
            // cmpAgent
            // 
            cmpAgent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmpAgent.FormattingEnabled = true;
            cmpAgent.Location = new Point(426, 103);
            cmpAgent.Name = "cmpAgent";
            cmpAgent.Size = new Size(259, 38);
            cmpAgent.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(718, 169);
            label18.Name = "label18";
            label18.Size = new Size(90, 32);
            label18.TabIndex = 11;
            label18.Text = "Status :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(718, 66);
            label19.Name = "label19";
            label19.Size = new Size(95, 32);
            label19.TabIndex = 8;
            label19.Text = "Listing :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(364, 174);
            label16.Name = "label16";
            label16.Size = new Size(77, 32);
            label16.TabIndex = 7;
            label16.Text = "Type :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(355, 68);
            label17.Name = "label17";
            label17.Size = new Size(90, 32);
            label17.TabIndex = 4;
            label17.Text = "Agent :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(21, 170);
            label15.Name = "label15";
            label15.Size = new Size(77, 32);
            label15.TabIndex = 3;
            label15.Text = "Price :";
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtprice.Location = new Point(58, 205);
            txtprice.Name = "txtprice";
            txtprice.PlaceholderText = "Price";
            txtprice.Size = new Size(259, 37);
            txtprice.TabIndex = 2;
            txtprice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(58, 102);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Property Name";
            txtName.Size = new Size(259, 37);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(21, 67);
            label14.Name = "label14";
            label14.Size = new Size(90, 32);
            label14.TabIndex = 0;
            label14.Text = "Name :";
            // 
            // tabmap
            // 
            tabmap.Controls.Add(btnpick);
            tabmap.Controls.Add(txtLat);
            tabmap.Controls.Add(txtLong);
            tabmap.Controls.Add(label23);
            tabmap.Controls.Add(label22);
            tabmap.Controls.Add(label21);
            tabmap.Controls.Add(pnlMap);
            tabmap.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabmap.Location = new Point(4, 38);
            tabmap.Name = "tabmap";
            tabmap.Padding = new Padding(3);
            tabmap.Size = new Size(1038, 677);
            tabmap.TabIndex = 0;
            tabmap.Text = "Location";
            tabmap.UseVisualStyleBackColor = true;
            // 
            // btnpick
            // 
            btnpick.BackColor = Color.FromArgb(149, 149, 149);
            btnpick.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnpick.Image = Properties.Resources.icons8_location;
            btnpick.ImageAlign = ContentAlignment.MiddleLeft;
            btnpick.Location = new Point(694, 326);
            btnpick.Name = "btnpick";
            btnpick.Size = new Size(268, 58);
            btnpick.TabIndex = 6;
            btnpick.Text = "    Pick Location";
            btnpick.UseVisualStyleBackColor = false;
            btnpick.Click += btnpick_Click;
            // 
            // txtLat
            // 
            txtLat.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLat.Location = new Point(753, 213);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(259, 29);
            txtLat.TabIndex = 5;
            txtLat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLong
            // 
            txtLong.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLong.Location = new Point(753, 145);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(259, 29);
            txtLong.TabIndex = 4;
            txtLong.TextAlign = HorizontalAlignment.Center;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Lucida Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(608, 213);
            label23.Name = "label23";
            label23.Size = new Size(119, 25);
            label23.TabIndex = 3;
            label23.Text = "lattitude :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Lucida Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(608, 152);
            label22.Name = "label22";
            label22.Size = new Size(129, 25);
            label22.TabIndex = 2;
            label22.Text = "longitude :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(198, 22);
            label21.Name = "label21";
            label21.Size = new Size(167, 32);
            label21.TabIndex = 1;
            label21.Text = "Google Maps";
            // 
            // pnlMap
            // 
            pnlMap.Controls.Add(gmap3);
            pnlMap.Location = new Point(8, 57);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(570, 490);
            pnlMap.TabIndex = 0;
            // 
            // gmap3
            // 
            gmap3.Bearing = 0F;
            gmap3.CanDragMap = true;
            gmap3.Dock = DockStyle.Fill;
            gmap3.EmptyTileColor = Color.Navy;
            gmap3.GrayScaleMode = false;
            gmap3.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmap3.LevelsKeepInMemory = 5;
            gmap3.Location = new Point(0, 0);
            gmap3.MarkersEnabled = true;
            gmap3.MaxZoom = 2;
            gmap3.MinZoom = 2;
            gmap3.MouseWheelZoomEnabled = true;
            gmap3.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmap3.Name = "gmap3";
            gmap3.NegativeMode = false;
            gmap3.PolygonsEnabled = true;
            gmap3.RetryLoadTile = 0;
            gmap3.RoutesEnabled = true;
            gmap3.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmap3.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmap3.ShowTileGridLines = false;
            gmap3.Size = new Size(570, 490);
            gmap3.TabIndex = 0;
            gmap3.Zoom = 0D;
            gmap3.MouseDoubleClick += gmap3_MouseDoubleClick;
            // 
            // tabimage
            // 
            tabimage.Controls.Add(btnloadimages);
            tabimage.Controls.Add(tableLayoutPanel1);
            tabimage.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabimage.Location = new Point(4, 38);
            tabimage.Name = "tabimage";
            tabimage.Size = new Size(1038, 677);
            tabimage.TabIndex = 2;
            tabimage.Text = "Images";
            tabimage.UseVisualStyleBackColor = true;
            // 
            // btnloadimages
            // 
            btnloadimages.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnloadimages.Image = Properties.Resources.icons8_load_from_file_40;
            btnloadimages.ImageAlign = ContentAlignment.MiddleLeft;
            btnloadimages.Location = new Point(129, 530);
            btnloadimages.Name = "btnloadimages";
            btnloadimages.Size = new Size(215, 48);
            btnloadimages.TabIndex = 1;
            btnloadimages.Text = "    Load Images";
            btnloadimages.UseVisualStyleBackColor = true;
            btnloadimages.Click += btnloadimages_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1038, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(1032, 524);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(384, 384);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(picrented);
            tabHistory.Controls.Add(picava);
            tabHistory.Controls.Add(picsold);
            tabHistory.Controls.Add(groupBox1);
            tabHistory.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabHistory.Location = new Point(4, 38);
            tabHistory.Name = "tabHistory";
            tabHistory.Size = new Size(1038, 677);
            tabHistory.TabIndex = 3;
            tabHistory.Text = "History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // picrented
            // 
            picrented.Image = Properties.Resources.icons8_rent_64;
            picrented.Location = new Point(725, 370);
            picrented.Name = "picrented";
            picrented.Size = new Size(150, 75);
            picrented.SizeMode = PictureBoxSizeMode.Zoom;
            picrented.TabIndex = 3;
            picrented.TabStop = false;
            picrented.Visible = false;
            // 
            // picava
            // 
            picava.Image = Properties.Resources.icons8_open_sign_50;
            picava.Location = new Point(725, 66);
            picava.Name = "picava";
            picava.Size = new Size(150, 90);
            picava.SizeMode = PictureBoxSizeMode.Zoom;
            picava.TabIndex = 2;
            picava.TabStop = false;
            picava.Visible = false;
            // 
            // picsold
            // 
            picsold.Image = Properties.Resources.icons8_sold_96;
            picsold.Location = new Point(725, 205);
            picsold.Name = "picsold";
            picsold.Size = new Size(150, 114);
            picsold.SizeMode = PictureBoxSizeMode.CenterImage;
            picsold.TabIndex = 1;
            picsold.TabStop = false;
            picsold.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHOdate);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(txtHOtype);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtHCname);
            groupBox1.Controls.Add(label24);
            groupBox1.Font = new Font("Lucida Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(42, 130, 218);
            groupBox1.Location = new Point(31, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 494);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order History";
            // 
            // txtHOdate
            // 
            txtHOdate.Location = new Point(64, 329);
            txtHOdate.Name = "txtHOdate";
            txtHOdate.ReadOnly = true;
            txtHOdate.Size = new Size(383, 40);
            txtHOdate.TabIndex = 5;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(24, 290);
            label26.Name = "label26";
            label26.Size = new Size(160, 27);
            label26.TabIndex = 4;
            label26.Text = "Order Date :";
            // 
            // txtHOtype
            // 
            txtHOtype.Location = new Point(64, 207);
            txtHOtype.Name = "txtHOtype";
            txtHOtype.ReadOnly = true;
            txtHOtype.Size = new Size(383, 40);
            txtHOtype.TabIndex = 3;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(6, 167);
            label25.Name = "label25";
            label25.Size = new Size(166, 27);
            label25.TabIndex = 2;
            label25.Text = "Order Type :";
            // 
            // txtHCname
            // 
            txtHCname.Location = new Point(64, 100);
            txtHCname.Name = "txtHCname";
            txtHCname.ReadOnly = true;
            txtHCname.Size = new Size(383, 40);
            txtHCname.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(24, 61);
            label24.Name = "label24";
            label24.Size = new Size(222, 27);
            label24.TabIndex = 0;
            label24.Text = "Customer Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(236, 145);
            label12.Name = "label12";
            label12.Size = new Size(101, 29);
            label12.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(198, 239);
            label10.Name = "label10";
            label10.Size = new Size(147, 29);
            label10.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(0, 0);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 31);
            textBoxPhone.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(271, 331);
            label9.Name = "label9";
            label9.Size = new Size(64, 29);
            label9.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(0, 0);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 31);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(0, 0);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 31);
            textBoxAddress.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(0, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            // 
            // checkBoxSecondayUser
            // 
            checkBoxSecondayUser.Location = new Point(0, 0);
            checkBoxSecondayUser.Name = "checkBoxSecondayUser";
            checkBoxSecondayUser.Size = new Size(104, 24);
            checkBoxSecondayUser.TabIndex = 0;
            // 
            // comboBoxUserId
            // 
            comboBoxUserId.Location = new Point(0, 0);
            comboBoxUserId.Name = "comboBoxUserId";
            comboBoxUserId.Size = new Size(121, 33);
            comboBoxUserId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(217, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(59, 164);
            label11.Name = "label11";
            label11.Size = new Size(119, 22);
            label11.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(59, 286);
            label13.Name = "label13";
            label13.Size = new Size(119, 22);
            label13.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(59, 49);
            label8.Name = "label8";
            label8.Size = new Size(119, 22);
            label8.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(195, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 29);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(203, 158);
            label3.Name = "label3";
            label3.Size = new Size(118, 29);
            label3.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(23, 94);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(324, 31);
            textBoxFullName.TabIndex = 1;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(243, 280);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(197, 388);
            label7.Name = "label7";
            label7.Size = new Size(140, 29);
            label7.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(181, 152);
            label4.Name = "label4";
            label4.Size = new Size(23, 29);
            label4.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(0, 0);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(100, 31);
            textBoxUserName.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(220, 272);
            label6.Name = "label6";
            label6.Size = new Size(23, 29);
            label6.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(0, 0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 31);
            textBoxPassword.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Location = new Point(0, 0);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 33);
            comboBoxRole.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 648);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 71);
            panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.icons8_save_32px;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(396, 5);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(238, 60);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 719);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPropertyForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Property";
            TopMost = true;
            tabControl1.ResumeLayout(false);
            tabinfo.ResumeLayout(false);
            tabinfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabmap.ResumeLayout(false);
            tabmap.PerformLayout();
            pnlMap.ResumeLayout(false);
            tabimage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picrented).EndInit();
            ((System.ComponentModel.ISupportInitialize)picava).EndInit();
            ((System.ComponentModel.ISupportInitialize)picsold).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabinfo;
        private Label label12;
        private Label label10;
        private TextBox textBoxPhone;
        private Label label9;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private Button buttonSave;
        private CheckBox checkBoxSecondayUser;
        private ComboBox comboBoxUserId;
        private Label label1;
        private Label label11;
        private Label label13;
        private Label label8;
        private Label label2;
        private Label label3;
        private TextBox textBoxFullName;
        private Label label5;
        private Label label7;
        private Label label4;
        private TextBox textBoxUserName;
        private Label label6;
        private TextBox textBoxPassword;
        private ComboBox comboBoxRole;
        private TabPage tabimage;
        private TabPage tabHistory;
        private Panel panel1;
        private Button btnSave;
        private GroupBox groupBox2;
        private Label label14;
        private TextBox txtprice;
        private TextBox txtName;
        private Label label18;
        private Label label19;
        private Label label16;
        private Label label17;
        private Label label15;
        private ComboBox cmbListing;
        private ComboBox cmbStatus;
        private ComboBox cmbType;
        private ComboBox cmpAgent;
        private RichTextBox richTextBox1;
        private Label label20;
        private TabPage tabmap;
        private TextBox txtLong;
        private Label label23;
        private Label label22;
        private Label label21;
        private Panel pnlMap;
        private TextBox txtLat;
        private Button btnpick;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private ImageList imageList1;
        private Button btnloadimages;
        private GroupBox groupBox1;
        private Label label26;
        private Label label25;
        private Label label24;
        public TextBox txtHOdate;
        public TextBox txtHOtype;
        public TextBox txtHCname;
        private PictureBox picrented;
        private PictureBox picava;
        private PictureBox picsold;
        private GMap.NET.WindowsForms.GMapControl gmap3;
    }
}