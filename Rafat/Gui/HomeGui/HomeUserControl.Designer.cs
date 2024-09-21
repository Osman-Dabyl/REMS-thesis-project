using System.Windows.Forms;

namespace Rafat.Gui.HomeGui
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblgreeting = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            roundedPanel1 = new RJControls.RoundedPanel();
            label5 = new Label();
            label4 = new Label();
            txtOcount = new Label();
            roundedPanel2 = new RJControls.RoundedPanel();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            txtsales = new Label();
            roundedPanel3 = new RJControls.RoundedPanel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            txtrevenue = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            roundedPanel5 = new RJControls.RoundedPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            roundedPanel6 = new RJControls.RoundedPanel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            txtACount = new Label();
            txtPcount = new Label();
            txtCCount = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            roundedPanel4 = new RJControls.RoundedPanel();
            roundedPanel7 = new RJControls.RoundedPanel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            DateAdded = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            roundedPanel4.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblgreeting
            // 
            lblgreeting.AutoSize = true;
            lblgreeting.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblgreeting.Location = new Point(13, 17);
            lblgreeting.Name = "lblgreeting";
            lblgreeting.Size = new Size(295, 24);
            lblgreeting.TabIndex = 0;
            lblgreeting.Text = "Good Morning Osman!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(88, 41);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 1;
            label2.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_bill_96;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(txtOcount);
            roundedPanel1.Location = new Point(43, 6);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(347, 76);
            roundedPanel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(271, 20);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 6;
            label5.Text = "54%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(97, 43);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(73, 30);
            label4.TabIndex = 5;
            label4.Text = "Orders";
            // 
            // txtOcount
            // 
            txtOcount.AutoSize = true;
            txtOcount.BackColor = Color.Transparent;
            txtOcount.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtOcount.Location = new Point(97, 10);
            txtOcount.Margin = new Padding(7);
            txtOcount.Name = "txtOcount";
            txtOcount.Size = new Size(40, 32);
            txtOcount.TabIndex = 4;
            txtOcount.Text = "54";
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(label9);
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Controls.Add(label10);
            roundedPanel2.Controls.Add(txtsales);
            roundedPanel2.Location = new Point(851, 6);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(347, 76);
            roundedPanel2.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LimeGreen;
            label9.Location = new Point(285, 19);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(62, 32);
            label9.TabIndex = 10;
            label9.Text = "54%";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.icons8_investment_96;
            pictureBox3.Location = new Point(8, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonShadow;
            label10.Location = new Point(102, 42);
            label10.Name = "label10";
            label10.Padding = new Padding(4);
            label10.Size = new Size(109, 30);
            label10.TabIndex = 9;
            label10.Text = "Total Sales";
            // 
            // txtsales
            // 
            txtsales.AutoSize = true;
            txtsales.BackColor = Color.Transparent;
            txtsales.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtsales.Location = new Point(106, 10);
            txtsales.Margin = new Padding(0);
            txtsales.Name = "txtsales";
            txtsales.Size = new Size(105, 32);
            txtsales.TabIndex = 8;
            txtsales.Text = "545645$";
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top;
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Controls.Add(pictureBox2);
            roundedPanel3.Controls.Add(label7);
            roundedPanel3.Controls.Add(txtrevenue);
            roundedPanel3.Location = new Point(446, 6);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(347, 76);
            roundedPanel3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(276, 19);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 10;
            label6.Text = "54%";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_total_sales_color_96;
            pictureBox2.Location = new Point(8, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(102, 42);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new Size(90, 30);
            label7.TabIndex = 9;
            label7.Text = "Revenue";
            // 
            // txtrevenue
            // 
            txtrevenue.AutoSize = true;
            txtrevenue.BackColor = Color.Transparent;
            txtrevenue.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtrevenue.Location = new Point(102, 10);
            txtrevenue.Margin = new Padding(0);
            txtrevenue.Name = "txtrevenue";
            txtrevenue.Size = new Size(92, 32);
            txtrevenue.TabIndex = 8;
            txtrevenue.Text = "54787$";
            txtrevenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblgreeting);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 71);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel3);
            panel2.Controls.Add(roundedPanel1);
            panel2.Controls.Add(roundedPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 89);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel5);
            panel3.Controls.Add(roundedPanel6);
            panel3.Controls.Add(roundedPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(1257, 768);
            panel3.TabIndex = 12;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.Controls.Add(chart1);
            roundedPanel5.Location = new Point(46, 20);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(540, 487);
            roundedPanel5.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(540, 487);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // roundedPanel6
            // 
            roundedPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel6.BackColor = Color.White;
            roundedPanel6.Controls.Add(pictureBox6);
            roundedPanel6.Controls.Add(pictureBox5);
            roundedPanel6.Controls.Add(pictureBox7);
            roundedPanel6.Controls.Add(txtACount);
            roundedPanel6.Controls.Add(txtPcount);
            roundedPanel6.Controls.Add(txtCCount);
            roundedPanel6.Controls.Add(label15);
            roundedPanel6.Controls.Add(label14);
            roundedPanel6.Controls.Add(label13);
            roundedPanel6.Controls.Add(label12);
            roundedPanel6.Controls.Add(pictureBox4);
            roundedPanel6.Location = new Point(640, 20);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(558, 487);
            roundedPanel6.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(71, 216);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(97, 72);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(71, 326);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(97, 84);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_customers_96;
            pictureBox7.Location = new Point(71, 95);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(97, 81);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // txtACount
            // 
            txtACount.AutoSize = true;
            txtACount.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtACount.Location = new Point(313, 252);
            txtACount.Name = "txtACount";
            txtACount.Size = new Size(65, 63);
            txtACount.TabIndex = 7;
            txtACount.Text = "50";
            // 
            // txtPcount
            // 
            txtPcount.AutoSize = true;
            txtPcount.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPcount.Location = new Point(313, 374);
            txtPcount.Name = "txtPcount";
            txtPcount.Size = new Size(65, 63);
            txtPcount.TabIndex = 6;
            txtPcount.Text = "50";
            // 
            // txtCCount
            // 
            txtCCount.AutoSize = true;
            txtCCount.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCount.Location = new Point(313, 140);
            txtCCount.Name = "txtCCount";
            txtCCount.Size = new Size(65, 63);
            txtCCount.TabIndex = 5;
            txtCCount.Text = "50";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(174, 343);
            label15.Name = "label15";
            label15.Size = new Size(140, 32);
            label15.TabIndex = 4;
            label15.Text = "Properties";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(174, 237);
            label14.Name = "label14";
            label14.Size = new Size(102, 32);
            label14.TabIndex = 3;
            label14.Text = "Agents";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(174, 118);
            label13.Name = "label13";
            label13.Size = new Size(149, 32);
            label13.TabIndex = 2;
            label13.Text = "Customers";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(32, 27);
            label12.Name = "label12";
            label12.Size = new Size(284, 45);
            label12.TabIndex = 0;
            label12.Text = "Total Counters";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_counter_96;
            pictureBox4.Location = new Point(375, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Controls.Add(roundedPanel7);
            roundedPanel4.Dock = DockStyle.Bottom;
            roundedPanel4.Location = new Point(0, 523);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(1257, 245);
            roundedPanel4.TabIndex = 0;
            // 
            // roundedPanel7
            // 
            roundedPanel7.Anchor = AnchorStyles.Bottom;
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.Controls.Add(dataGridView1);
            roundedPanel7.Controls.Add(panel4);
            roundedPanel7.Location = new Point(60, 20);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(1126, 213);
            roundedPanel7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(42, 130, 218);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(43, 43, 81);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(42, 130, 218);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.Size = new Size(988, 542);
            dataGridView1.TabIndex = 2;
            
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // DateAdded
            // 
            DateAdded.HeaderText = "DateAdded";
            DateAdded.MinimumWidth = 8;
            DateAdded.Name = "DateAdded";
            DateAdded.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label19);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1126, 35);
            panel4.TabIndex = 4;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(422, 3);
            label19.Name = "label19";
            label19.Size = new Size(280, 27);
            label19.TabIndex = 0;
            label19.Text = "Recent Added Properties";
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 245);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            Size = new Size(1257, 928);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblgreeting;
        private Label label2;
        private PictureBox pictureBox1;
        private RJControls.RoundedPanel roundedPanel1;
        private Label label5;
        private Label label4;
        private Label txtOcount;
        private RJControls.RoundedPanel roundedPanel2;
        private RJControls.RoundedPanel roundedPanel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private RJControls.RoundedPanel roundedPanel4;
        private RJControls.RoundedPanel roundedPanel6;
        private RJControls.RoundedPanel roundedPanel7;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label7;
        private Label txtrevenue;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label10;
        private Label txtsales;
        private PictureBox pictureBox4;
        private Label label12;
        private PictureBox pictureBox7;
        private Label txtACount;
        private Label txtPcount;
        private Label txtCCount;
        private Label label15;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RJControls.RoundedPanel roundedPanel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn DateAdded;
        private Panel panel4;
        private Label label19;
    }
}
