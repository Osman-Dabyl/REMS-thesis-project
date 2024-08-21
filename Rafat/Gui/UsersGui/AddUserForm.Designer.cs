namespace Rafat.Gui.UsersGui
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            groupBox1 = new GroupBox();
            comboBoxRole = new ComboBox();
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            textBoxFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            label9 = new Label();
            textBoxPhone = new TextBox();
            label10 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN INFO";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(27, 432);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(320, 37);
            comboBoxRole.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(23, 320);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 35);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(165, 273);
            label6.Name = "label6";
            label6.Size = new Size(23, 29);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(23, 205);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(324, 35);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(181, 152);
            label4.Name = "label4";
            label4.Size = new Size(23, 29);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(27, 388);
            label7.Name = "label7";
            label7.Size = new Size(156, 29);
            label7.TabIndex = 0;
            label7.Text = "General Role";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 285);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 0;
            label5.Text = "Password :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(23, 94);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(324, 35);
            textBoxFullName.TabIndex = 1;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 152);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 0;
            label3.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(158, 49);
            label2.Name = "label2";
            label2.Size = new Size(23, 29);
            label2.TabIndex = 0;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(textBoxAddress);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(396, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 498);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Detiles";
            // 
            // buttonSave
            // 
            buttonSave.ForeColor = Color.Black;
            buttonSave.Image = Properties.Resources.icons8_save_32px;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(23, 424);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(319, 50);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(18, 320);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(324, 35);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(18, 205);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(324, 35);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(23, 273);
            label9.Name = "label9";
            label9.Size = new Size(114, 29);
            label9.TabIndex = 0;
            label9.Text = "Address :";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(18, 94);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(324, 35);
            textBoxPhone.TabIndex = 7;
            textBoxPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(23, 163);
            label10.Name = "label10";
            label10.Size = new Size(86, 29);
            label10.TabIndex = 0;
            label10.Text = "Email :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(18, 49);
            label12.Name = "label12";
            label12.Size = new Size(188, 29);
            label12.TabIndex = 0;
            label12.Text = "Phone Number :";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 609);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit User";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxUserName;
        private Label label4;
        private Label label5;
        private TextBox textBoxFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private Label label9;
        private TextBox textBoxPhone;
        private Label label10;
        private Label label12;
        private Button buttonSave;
        private ComboBox comboBoxRole;
        private Label label7;
    }
}