namespace Rafat.Gui.UsersGui
{
    partial class ForgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetForm));
            txtEmail = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(38, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Your Email";
            txtEmail.Size = new Size(451, 45);
            txtEmail.TabIndex = 0;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 34);
            label1.Name = "label1";
            label1.Size = new Size(421, 27);
            label1.TabIndex = 1;
            label1.Text = "Reset Code will be sent to your Email ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_import_32px;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(163, 186);
            button1.Name = "button1";
            button1.Size = new Size(191, 57);
            button1.TabIndex = 2;
            button1.Text = "Send Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 61);
            label2.Name = "label2";
            label2.Size = new Size(179, 27);
            label2.TabIndex = 3;
            label2.Text = "Please Check it";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(63, 276);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the code";
            textBox1.Size = new Size(405, 45);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.icons8_import_32px;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(141, 357);
            button2.Name = "button2";
            button2.Size = new Size(226, 57);
            button2.TabIndex = 5;
            button2.Text = "   Verfiy the Code";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ForgetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 436);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgetForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
    }
}