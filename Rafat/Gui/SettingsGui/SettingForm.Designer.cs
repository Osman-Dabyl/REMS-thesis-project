namespace Rafat.Gui.SettingsGui
{
    partial class SettingForm
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
            groupBox1 = new GroupBox();
            buttonSaveConnection = new Button();
            radioButtonNetwork = new RadioButton();
            numericUpDownDuration = new NumericUpDown();
            radioButtonLocal = new RadioButton();
            textBoxPassword = new TextBox();
            label8 = new Label();
            textBoxUserName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxDataBase = new TextBox();
            label5 = new Label();
            textBoxServer = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            buttonSaveGenralSettings = new Button();
            numericUpDownNoOfItmes = new NumericUpDown();
            textBoxCurrency = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxCompnayName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoOfItmes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveConnection);
            groupBox1.Controls.Add(radioButtonNetwork);
            groupBox1.Controls.Add(numericUpDownDuration);
            groupBox1.Controls.Add(radioButtonLocal);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxDataBase);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxServer);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(523, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 634);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection Settings";
            // 
            // buttonSaveConnection
            // 
            buttonSaveConnection.Anchor = AnchorStyles.Right;
            buttonSaveConnection.ForeColor = Color.Black;
            buttonSaveConnection.Image = Properties.Resources.icons8_save_32px;
            buttonSaveConnection.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveConnection.Location = new Point(146, 568);
            buttonSaveConnection.Name = "buttonSaveConnection";
            buttonSaveConnection.Size = new Size(178, 60);
            buttonSaveConnection.TabIndex = 5;
            buttonSaveConnection.Text = "Save";
            buttonSaveConnection.UseVisualStyleBackColor = true;
            buttonSaveConnection.Click += buttonSaveConnection_Click;
            // 
            // radioButtonNetwork
            // 
            radioButtonNetwork.AutoSize = true;
            radioButtonNetwork.Location = new Point(39, 44);
            radioButtonNetwork.Name = "radioButtonNetwork";
            radioButtonNetwork.Size = new Size(128, 33);
            radioButtonNetwork.TabIndex = 0;
            radioButtonNetwork.Text = "Network";
            radioButtonNetwork.UseVisualStyleBackColor = true;
            radioButtonNetwork.CheckedChanged += radioButtonNetwork_CheckedChanged;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(23, 499);
            numericUpDownDuration.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(372, 35);
            numericUpDownDuration.TabIndex = 2;
            numericUpDownDuration.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // radioButtonLocal
            // 
            radioButtonLocal.AutoSize = true;
            radioButtonLocal.Checked = true;
            radioButtonLocal.Location = new Point(271, 44);
            radioButtonLocal.Name = "radioButtonLocal";
            radioButtonLocal.Size = new Size(96, 33);
            radioButtonLocal.TabIndex = 0;
            radioButtonLocal.TabStop = true;
            radioButtonLocal.Text = "Local";
            radioButtonLocal.UseVisualStyleBackColor = true;
            radioButtonLocal.CheckedChanged += radioButtonLocal_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(21, 402);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.Size = new Size(374, 35);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "sa";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 454);
            label8.Name = "label8";
            label8.Size = new Size(171, 29);
            label8.TabIndex = 0;
            label8.Text = "TimeOut (Sec)";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(29, 314);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PasswordChar = '*';
            textBoxUserName.RightToLeft = RightToLeft.No;
            textBoxUserName.Size = new Size(374, 35);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.Text = "sa";
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 366);
            label7.Name = "label7";
            label7.Size = new Size(120, 29);
            label7.TabIndex = 0;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 282);
            label6.Name = "label6";
            label6.Size = new Size(135, 29);
            label6.TabIndex = 0;
            label6.Text = "User Name";
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Location = new Point(29, 220);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.RightToLeft = RightToLeft.No;
            textBoxDataBase.Size = new Size(374, 35);
            textBoxDataBase.TabIndex = 1;
            textBoxDataBase.Text = "RafatDB";
            textBoxDataBase.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 188);
            label5.Name = "label5";
            label5.Size = new Size(186, 29);
            label5.TabIndex = 0;
            label5.Text = "Database Name";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(29, 131);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = RightToLeft.No;
            textBoxServer.Size = new Size(374, 35);
            textBoxServer.TabIndex = 1;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 29);
            label4.TabIndex = 0;
            label4.Text = "Server";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSaveGenralSettings);
            groupBox2.Controls.Add(numericUpDownNoOfItmes);
            groupBox2.Controls.Add(textBoxCurrency);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxCompnayName);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(28, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 535);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "General Settings";
            // 
            // buttonSaveGenralSettings
            // 
            buttonSaveGenralSettings.Anchor = AnchorStyles.Right;
            buttonSaveGenralSettings.ForeColor = Color.Black;
            buttonSaveGenralSettings.Image = Properties.Resources.icons8_save_32px;
            buttonSaveGenralSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveGenralSettings.Location = new Point(123, 450);
            buttonSaveGenralSettings.Name = "buttonSaveGenralSettings";
            buttonSaveGenralSettings.Size = new Size(178, 60);
            buttonSaveGenralSettings.TabIndex = 5;
            buttonSaveGenralSettings.Text = "Save";
            buttonSaveGenralSettings.UseVisualStyleBackColor = true;
            buttonSaveGenralSettings.Click += buttonSaveGenralSettings_Click;
            // 
            // numericUpDownNoOfItmes
            // 
            numericUpDownNoOfItmes.Location = new Point(31, 342);
            numericUpDownNoOfItmes.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownNoOfItmes.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownNoOfItmes.Name = "numericUpDownNoOfItmes";
            numericUpDownNoOfItmes.Size = new Size(372, 35);
            numericUpDownNoOfItmes.TabIndex = 2;
            numericUpDownNoOfItmes.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Location = new Point(29, 206);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(374, 35);
            textBoxCurrency.TabIndex = 1;
            textBoxCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 296);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 0;
            label3.Text = "Items Per Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 165);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 0;
            label2.Text = "Currency";
            // 
            // textBoxCompnayName
            // 
            textBoxCompnayName.Location = new Point(29, 95);
            textBoxCompnayName.Name = "textBoxCompnayName";
            textBoxCompnayName.Size = new Size(374, 35);
            textBoxCompnayName.TabIndex = 1;
            textBoxCompnayName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 682);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 9, 6, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingForm";
            Padding = new Padding(16, 26, 16, 26);
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application Settings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoOfItmes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDownNoOfItmes;
        private TextBox textBoxCurrency;
        private Label label3;
        private Label label2;
        private TextBox textBoxCompnayName;
        private Label label1;
        private Button buttonSaveGenralSettings;
        private RadioButton radioButtonNetwork;
        private NumericUpDown numericUpDownDuration;
        private RadioButton radioButtonLocal;
        private TextBox textBoxPassword;
        private Label label8;
        private TextBox textBoxUserName;
        private Label label7;
        private Label label6;
        private TextBox textBoxDataBase;
        private Label label5;
        private TextBox textBoxServer;
        private Label label4;
        private Button buttonSaveConnection;
    }
}
