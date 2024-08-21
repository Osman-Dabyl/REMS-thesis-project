namespace Rafat
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            progressBar1 = new ProgressBar();
            panelSettings = new Panel();
            linkLabelExit = new LinkLabel();
            linkLabelSetServer = new LinkLabel();
            timerStart = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(2, 436);
            progressBar1.Margin = new Padding(4, 6, 4, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1042, 25);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.Transparent;
            panelSettings.Controls.Add(linkLabelExit);
            panelSettings.Controls.Add(linkLabelSetServer);
            panelSettings.Location = new Point(705, 402);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(339, 34);
            panelSettings.TabIndex = 3;
            panelSettings.Visible = false;
            // 
            // linkLabelExit
            // 
            linkLabelExit.AutoSize = true;
            linkLabelExit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelExit.Location = new Point(254, 4);
            linkLabelExit.Name = "linkLabelExit";
            linkLabelExit.Size = new Size(63, 25);
            linkLabelExit.TabIndex = 0;
            linkLabelExit.TabStop = true;
            linkLabelExit.Text = "Close";
            linkLabelExit.LinkClicked += linkLabelExit_LinkClicked;
            // 
            // linkLabelSetServer
            // 
            linkLabelSetServer.AutoSize = true;
            linkLabelSetServer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelSetServer.Location = new Point(22, 5);
            linkLabelSetServer.Name = "linkLabelSetServer";
            linkLabelSetServer.Size = new Size(226, 25);
            linkLabelSetServer.TabIndex = 0;
            linkLabelSetServer.TabStop = true;
            linkLabelSetServer.Text = "Edit Connection Settings";
            linkLabelSetServer.LinkClicked += linkLabelSetServer_LinkClicked;
            // 
            // timerStart
            // 
            timerStart.Enabled = true;
            timerStart.Interval = 5000;
            timerStart.Tick += timerStart_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Designer__1_;
            pictureBox1.Location = new Point(-100, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1384, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(177, 113);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 465);
            Controls.Add(panelSettings);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 9, 6, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartForm";
            Padding = new Padding(16, 26, 16, 26);
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Panel panelSettings;
        private LinkLabel linkLabelExit;
        private LinkLabel linkLabelSetServer;
        private System.Windows.Forms.Timer timerStart;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
