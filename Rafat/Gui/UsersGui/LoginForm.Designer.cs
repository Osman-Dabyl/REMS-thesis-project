namespace Rafat.Gui.UsersGui
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            pictureBoxLoding = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonlogin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(88, 474);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(385, 35);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(202, 420);
            label6.Name = "label6";
            label6.Size = new Size(23, 29);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(88, 344);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(385, 35);
            textBoxUserName.TabIndex = 0;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(217, 284);
            label4.Name = "label4";
            label4.Size = new Size(23, 29);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(88, 432);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 0;
            label5.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(88, 300);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 0;
            label3.Text = "User Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBoxLoding);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonlogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(556, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 779);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.MenuHighlight;
            checkBox1.Location = new Point(358, 527);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 26);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 203);
            label2.Name = "label2";
            label2.Size = new Size(252, 40);
            label2.TabIndex = 4;
            label2.Text = "PLEASE LOGIN ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 20);
            label1.Name = "label1";
            label1.Size = new Size(392, 58);
            label1.TabIndex = 3;
            label1.Text = "WELCOME BACK";
            // 
            // pictureBoxLoding
            // 
            pictureBoxLoding.Image = Properties.Resources.Loading;
            pictureBoxLoding.Location = new Point(202, 677);
            pictureBoxLoding.Name = "pictureBoxLoding";
            pictureBoxLoding.Size = new Size(148, 90);
            pictureBoxLoding.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoding.TabIndex = 2;
            pictureBoxLoding.TabStop = false;
            pictureBoxLoding.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.two_step_verification;
            pictureBox2.Location = new Point(384, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonlogin
            // 
            buttonlogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonlogin.ForeColor = Color.Black;
            buttonlogin.Image = Properties.Resources.icons8_import_32px;
            buttonlogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonlogin.Location = new Point(183, 586);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(199, 60);
            buttonlogin.TabIndex = 2;
            buttonlogin.Text = "Login";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-5, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 779);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.vecteezy_ai_generated_real_estate_advertisment_background_with_copy_36725213;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 779);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 779);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login form";
            FormClosed += LoginForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoding).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxUserName;
        private Label label4;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button buttonlogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLoding;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
    }
}