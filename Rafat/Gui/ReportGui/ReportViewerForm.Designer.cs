namespace Rafat.Gui.ReportGui
{
    partial class ReportViewerForm
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
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "panepan";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 724);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ReportViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 724);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportViewerForm";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panel1;
    }
}