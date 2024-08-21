namespace Rafat.Gui.ReportGui
{
    partial class ReportMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMaker));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            cmbreptype = new ComboBox();
            cmbrepid = new ComboBox();
            lblrepid = new Label();
            btnGenarate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.pngtree_vector_document_in_folder_icon_png_image_3762806;
            pictureBox1.Location = new Point(293, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
  
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(247, 144);
            label1.Name = "label1";
            label1.Size = new Size(217, 60);
            label1.TabIndex = 1;
            label1.Text = "Reports";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(51, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 13);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 3;
            label2.Text = "Adeeg Real Estate";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(133, 304);
            label3.Name = "label3";
            label3.Size = new Size(225, 26);
            label3.TabIndex = 4;
            label3.Text = "Choice Report Type";
            // 
            // cmbreptype
            // 
            cmbreptype.Anchor = AnchorStyles.None;
            cmbreptype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbreptype.FormattingEnabled = true;
            cmbreptype.Location = new Point(66, 351);
            cmbreptype.Name = "cmbreptype";
            cmbreptype.Size = new Size(354, 40);
            cmbreptype.TabIndex = 5;
            // 
            // cmbrepid
            // 
            cmbrepid.Enabled = false;
            cmbrepid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbrepid.FormattingEnabled = true;
            cmbrepid.Location = new Point(66, 481);
            cmbrepid.Name = "cmbrepid";
            cmbrepid.Size = new Size(354, 40);
            cmbrepid.TabIndex = 7;
            // 
            // lblrepid
            // 
            lblrepid.AutoSize = true;
            lblrepid.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblrepid.Location = new Point(133, 434);
            lblrepid.Name = "lblrepid";
            lblrepid.Size = new Size(0, 26);
            lblrepid.TabIndex = 6;
            // 
            // btnGenarate
            // 
            btnGenarate.Anchor = AnchorStyles.None;
            btnGenarate.BackColor = Color.White;
            btnGenarate.FlatAppearance.BorderColor = Color.DarkGray;
            btnGenarate.FlatAppearance.BorderSize = 2;
            btnGenarate.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 248, 250);
            btnGenarate.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 248, 250);
            btnGenarate.FlatStyle = FlatStyle.Flat;
            btnGenarate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenarate.ForeColor = Color.Black;
            btnGenarate.Image = Properties.Resources.icons8_use_of_a_computer_to_generate_an_ecg_result_641;
            btnGenarate.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenarate.Location = new Point(103, 715);
            btnGenarate.Margin = new Padding(5);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(270, 60);
            btnGenarate.TabIndex = 8;
            btnGenarate.Text = "    Generate ";
            btnGenarate.UseVisualStyleBackColor = false;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // ReportMaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(476, 789);
            Controls.Add(btnGenarate);
            Controls.Add(cmbrepid);
            Controls.Add(lblrepid);
            Controls.Add(cmbreptype);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportMaker";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Maker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ComboBox cmbreptype;
        private ComboBox cmbrepid;
        private Label lblrepid;
        private Button btnGenarate;
    }
}