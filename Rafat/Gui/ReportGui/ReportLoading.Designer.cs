namespace Rafat.Gui.ReportGui
{
    partial class ReportLoading
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
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(60, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.Size = new Size(563, 44);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1500;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Generating Report....";
            // 
            // ReportLoading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 159);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportLoading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}