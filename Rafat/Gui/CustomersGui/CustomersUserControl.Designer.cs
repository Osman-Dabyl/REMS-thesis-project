using System.Windows.Forms;

namespace Rafat.Gui.CustomersGui
{
    partial class CustomersUserControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonExportDataGridView = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            labelStateTitle = new Label();
            panelState = new Panel();
            labelStateDescription = new Label();
            buttonRefresh = new Button();
            toolTip1 = new ToolTip(components);
            buttonPrev = new Button();
            buttonNext = new Button();
            comboBoxNoOfPages = new ComboBox();
            panel3 = new Button();
            panel2 = new Panel();
            labelNofOfItmes = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelState.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonEdit);
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonExportDataGridView);
            flowLayoutPanelNavBar.Controls.Add(panel1);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(5);
            flowLayoutPanelNavBar.Size = new Size(988, 65);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(8, 8);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.RightToLeft = RightToLeft.No;
            buttonEdit.Size = new Size(145, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "     Edit";
            toolTip1.SetToolTip(buttonEdit, "For Edit");
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Image = Properties.Resources.icons8_Delete_32px;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(159, 8);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(154, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "     Delete";
            toolTip1.SetToolTip(buttonDelete, "Delete One row");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExportDataGridView
            // 
            buttonExportDataGridView.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExportDataGridView.Image = Properties.Resources.icons8_Microsoft_Excel_32px;
            buttonExportDataGridView.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExportDataGridView.Location = new Point(319, 8);
            buttonExportDataGridView.Name = "buttonExportDataGridView";
            buttonExportDataGridView.Size = new Size(147, 50);
            buttonExportDataGridView.TabIndex = 5;
            buttonExportDataGridView.Text = "     Print";
            toolTip1.SetToolTip(buttonExportDataGridView, "show in Exel");
            buttonExportDataGridView.UseVisualStyleBackColor = true;
            buttonExportDataGridView.Click += buttonExportDataGridView_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(472, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 50);
            panel1.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(50, 0);
            textBoxSearch.Margin = new Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(385, 37);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxSearch, "Search In database");
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.Image = Properties.Resources.icons8_search_32px;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 50);
            buttonSearch.TabIndex = 4;
            toolTip1.SetToolTip(buttonSearch, "Search In database");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(42, 130, 218);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 43, 81);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(42, 130, 218);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.Size = new Size(988, 542);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // labelStateTitle
            // 
            labelStateTitle.BackColor = Color.White;
            labelStateTitle.Dock = DockStyle.Top;
            labelStateTitle.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelStateTitle.ForeColor = Color.Gray;
            labelStateTitle.Location = new Point(0, 0);
            labelStateTitle.Name = "labelStateTitle";
            labelStateTitle.Size = new Size(493, 37);
            labelStateTitle.TabIndex = 5;
            labelStateTitle.Text = "Massege Title";
            labelStateTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelState
            // 
            panelState.Anchor = AnchorStyles.None;
            panelState.BackColor = Color.White;
            panelState.Controls.Add(labelStateDescription);
            panelState.Controls.Add(labelStateTitle);
            panelState.Location = new Point(248, 279);
            panelState.Name = "panelState";
            panelState.Size = new Size(493, 125);
            panelState.TabIndex = 5;
            panelState.Visible = false;
            // 
            // labelStateDescription
            // 
            labelStateDescription.BackColor = Color.White;
            labelStateDescription.Dock = DockStyle.Top;
            labelStateDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelStateDescription.ForeColor = Color.LightGray;
            labelStateDescription.Location = new Point(0, 37);
            labelStateDescription.Name = "labelStateDescription";
            labelStateDescription.Size = new Size(493, 37);
            labelStateDescription.TabIndex = 6;
            labelStateDescription.Text = "Descriptoin";
            labelStateDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRefresh.Image = Properties.Resources.icons8_recent_48;
            buttonRefresh.Location = new Point(8, 544);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(50, 50);
            buttonRefresh.TabIndex = 5;
            toolTip1.SetToolTip(buttonRefresh, "Refresh");
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Image = Properties.Resources.icons8_chevron_left_32px;
            buttonPrev.Location = new Point(3, -3);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(50, 50);
            buttonPrev.TabIndex = 6;
            toolTip1.SetToolTip(buttonPrev, "Previous Page");
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Image = Properties.Resources.icons8_chevron_right_32px;
            buttonNext.Location = new Point(161, 0);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(50, 50);
            buttonNext.TabIndex = 7;
            toolTip1.SetToolTip(buttonNext, "Next page");
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // comboBoxNoOfPages
            // 
            comboBoxNoOfPages.BackColor = Color.White;
            comboBoxNoOfPages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNoOfPages.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNoOfPages.FormattingEnabled = true;
            comboBoxNoOfPages.Location = new Point(50, 0);
            comboBoxNoOfPages.Name = "comboBoxNoOfPages";
            comboBoxNoOfPages.Size = new Size(105, 38);
            comboBoxNoOfPages.TabIndex = 8;
            toolTip1.SetToolTip(comboBoxNoOfPages, "عدد الصفحات");
            comboBoxNoOfPages.SelectedIndexChanged += comboBoxNoOfPages_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Transparent;
            panel3.FlatAppearance.BorderSize = 0;
            panel3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            panel3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            panel3.FlatStyle = FlatStyle.Flat;
            panel3.Image = Properties.Resources.loadingif;
            panel3.Location = new Point(383, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 182);
            panel3.TabIndex = 11;
            toolTip1.SetToolTip(panel3, "Refresh");
            panel3.UseVisualStyleBackColor = false;
            panel3.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelNofOfItmes);
            panel2.Controls.Add(comboBoxNoOfPages);
            panel2.Controls.Add(buttonNext);
            panel2.Controls.Add(buttonPrev);
            panel2.Location = new Point(657, 544);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 50);
            panel2.TabIndex = 6;
            // 
            // labelNofOfItmes
            // 
            labelNofOfItmes.BackColor = Color.White;
            labelNofOfItmes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNofOfItmes.ForeColor = Color.IndianRed;
            labelNofOfItmes.Location = new Point(205, 8);
            labelNofOfItmes.Name = "labelNofOfItmes";
            labelNofOfItmes.Size = new Size(107, 37);
            labelNofOfItmes.TabIndex = 9;
            labelNofOfItmes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(106, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CustomersUserControl
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonRefresh);
            Controls.Add(panelState);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "CustomersUserControl";
            RightToLeft = RightToLeft.No;
            Size = new Size(988, 607);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelState.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panel1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private Label labelStateTitle;
        private Panel panelState;
        private Button buttonRefresh;
        private ToolTip toolTip1;
        private Button buttonExportDataGridView;
        private Panel panel2;
        private Button buttonNext;
        private Button buttonPrev;
        private ComboBox comboBoxNoOfPages;
        private Label labelNofOfItmes;
        private PictureBox pictureBox1;
        private Label labelStateDescription;
        private loading.LoadingUserControl loadingUserControl1;
        private System.Windows.Forms.Timer timer1;
        private Image orignalImage;
        private Image neImage;
        private Button panel3;
    }
}
