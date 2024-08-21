using System.Windows.Forms;

namespace Rafat.Gui.test
{
    partial class testuser
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
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonExportDataGridView = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            toolTip1 = new ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            flowLayoutPanelNavBar.Size = new Size(1002, 65);
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
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 665);
            panel2.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1002, 665);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // testuser
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "testuser";
            RightToLeft = RightToLeft.No;
            Size = new Size(1002, 730);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panel1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ToolTip toolTip1;
        private Button buttonExportDataGridView;
        private Image orignalImage;
        private Image neImage;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
