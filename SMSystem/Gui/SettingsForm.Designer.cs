
namespace SMSystem.Gui
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            groupBox1 = new System.Windows.Forms.GroupBox();
            numericUpDownDamageDuration = new System.Windows.Forms.NumericUpDown();
            linkLabelImportLogo = new System.Windows.Forms.LinkLabel();
            pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            comboBoxCurrency = new System.Windows.Forms.ComboBox();
            buttonSaveGeneralSettings = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxCompanyDescription = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxCompanyName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBoxServer = new System.Windows.Forms.GroupBox();
            buttonRestore = new System.Windows.Forms.Button();
            buttonBackUp = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            radioButtonNetworkConnect = new System.Windows.Forms.RadioButton();
            buttonSaveServerSettings = new System.Windows.Forms.Button();
            radioButtonLocalConnect = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxUser = new System.Windows.Forms.TextBox();
            textBoxPort = new System.Windows.Forms.TextBox();
            textBoxDataBase = new System.Windows.Forms.TextBox();
            textBoxServer = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).BeginInit();
            groupBoxServer.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownDamageDuration);
            groupBox1.Controls.Add(linkLabelImportLogo);
            groupBox1.Controls.Add(pictureBoxCompanyLogo);
            groupBox1.Controls.Add(comboBoxCurrency);
            groupBox1.Controls.Add(buttonSaveGeneralSettings);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxCompanyDescription);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCompanyName);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            groupBox1.Location = new System.Drawing.Point(615, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(391, 705);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اعدادات عامة";
            // 
            // numericUpDownDamageDuration
            // 
            numericUpDownDamageDuration.Location = new System.Drawing.Point(32, 598);
            numericUpDownDamageDuration.Name = "numericUpDownDamageDuration";
            numericUpDownDamageDuration.Size = new System.Drawing.Size(328, 26);
            numericUpDownDamageDuration.TabIndex = 6;
            numericUpDownDamageDuration.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // linkLabelImportLogo
            // 
            linkLabelImportLogo.AutoSize = true;
            linkLabelImportLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelImportLogo.Location = new System.Drawing.Point(126, 453);
            linkLabelImportLogo.Name = "linkLabelImportLogo";
            linkLabelImportLogo.Size = new System.Drawing.Size(34, 17);
            linkLabelImportLogo.TabIndex = 5;
            linkLabelImportLogo.TabStop = true;
            linkLabelImportLogo.Text = "تحميل";
            linkLabelImportLogo.LinkClicked += linkLabelImportLogo_LinkClicked;
            // 
            // pictureBoxCompanyLogo
            // 
            pictureBoxCompanyLogo.Image = (System.Drawing.Image)resources.GetObject("pictureBoxCompanyLogo.Image");
            pictureBoxCompanyLogo.Location = new System.Drawing.Point(20, 248);
            pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            pictureBoxCompanyLogo.Size = new System.Drawing.Size(267, 202);
            pictureBoxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxCompanyLogo.TabIndex = 4;
            pictureBoxCompanyLogo.TabStop = false;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Items.AddRange(new object[] { "(ج.م)", "($)" });
            comboBoxCurrency.Location = new System.Drawing.Point(20, 498);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new System.Drawing.Size(340, 28);
            comboBoxCurrency.TabIndex = 3;
            comboBoxCurrency.SelectedIndexChanged += comboBoxCurrency_SelectedIndexChanged;
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            buttonSaveGeneralSettings.Location = new System.Drawing.Point(20, 649);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new System.Drawing.Size(340, 50);
            buttonSaveGeneralSettings.TabIndex = 2;
            buttonSaveGeneralSettings.Text = "حفظ الاعدادات";
            buttonSaveGeneralSettings.UseVisualStyleBackColor = true;
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(171, 558);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(189, 20);
            label10.TabIndex = 0;
            label10.Text = "التذكير للمواد التي سوف تتلف (يوم)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(323, 465);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 20);
            label3.TabIndex = 0;
            label3.Text = "العملة";
            // 
            // textBoxCompanyDescription
            // 
            textBoxCompanyDescription.Location = new System.Drawing.Point(20, 171);
            textBoxCompanyDescription.Multiline = true;
            textBoxCompanyDescription.Name = "textBoxCompanyDescription";
            textBoxCompanyDescription.Size = new System.Drawing.Size(340, 68);
            textBoxCompanyDescription.TabIndex = 1;
            textBoxCompanyDescription.Text = "وصف  للشركة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(317, 259);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 20);
            label4.TabIndex = 0;
            label4.Text = "الشعار";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(310, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "الوصف";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            textBoxCompanyName.Location = new System.Drawing.Point(20, 79);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new System.Drawing.Size(340, 26);
            textBoxCompanyName.TabIndex = 1;
            textBoxCompanyName.Text = "مخازن كلية الحاسبات والذكاء الاصطناعي";
            textBoxCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxCompanyName.TextChanged += textBoxCompanyName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(236, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "اسم الشركة / المؤسسة";
            // 
            // groupBoxServer
            // 
            groupBoxServer.Controls.Add(buttonRestore);
            groupBoxServer.Controls.Add(buttonBackUp);
            groupBoxServer.Controls.Add(groupBox3);
            groupBoxServer.ForeColor = System.Drawing.Color.Coral;
            groupBoxServer.Location = new System.Drawing.Point(12, 12);
            groupBoxServer.Name = "groupBoxServer";
            groupBoxServer.Size = new System.Drawing.Size(597, 705);
            groupBoxServer.TabIndex = 0;
            groupBoxServer.TabStop = false;
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            buttonRestore.FlatAppearance.BorderSize = 0;
            buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRestore.ForeColor = System.Drawing.Color.White;
            buttonRestore.Image = Properties.Resources.icons8_database_restore_80px_1;
            buttonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRestore.Location = new System.Drawing.Point(21, 549);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new System.Drawing.Size(277, 125);
            buttonRestore.TabIndex = 2;
            buttonRestore.Text = "          استعادة النسخة";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // buttonBackUp
            // 
            buttonBackUp.BackColor = System.Drawing.Color.Teal;
            buttonBackUp.FlatAppearance.BorderSize = 0;
            buttonBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonBackUp.ForeColor = System.Drawing.Color.White;
            buttonBackUp.Image = Properties.Resources.icons8_data_backup_80px;
            buttonBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonBackUp.Location = new System.Drawing.Point(318, 549);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new System.Drawing.Size(273, 125);
            buttonBackUp.TabIndex = 2;
            buttonBackUp.Text = "             اخذ نسخة احتياطية";
            buttonBackUp.UseVisualStyleBackColor = false;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonNetworkConnect);
            groupBox3.Controls.Add(buttonSaveServerSettings);
            groupBox3.Controls.Add(radioButtonLocalConnect);
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new System.Drawing.Point(6, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(585, 450);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "اعدادات السيرفر";
            // 
            // radioButtonNetworkConnect
            // 
            radioButtonNetworkConnect.AutoSize = true;
            radioButtonNetworkConnect.ForeColor = System.Drawing.Color.Black;
            radioButtonNetworkConnect.Location = new System.Drawing.Point(473, 121);
            radioButtonNetworkConnect.Name = "radioButtonNetworkConnect";
            radioButtonNetworkConnect.Size = new System.Drawing.Size(55, 24);
            radioButtonNetworkConnect.TabIndex = 1;
            radioButtonNetworkConnect.Text = "شبكي";
            radioButtonNetworkConnect.UseVisualStyleBackColor = true;
            radioButtonNetworkConnect.CheckedChanged += radioButtonNetworkConnect_CheckedChanged;
            // 
            // buttonSaveServerSettings
            // 
            buttonSaveServerSettings.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonSaveServerSettings.FlatAppearance.BorderSize = 0;
            buttonSaveServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSaveServerSettings.ForeColor = System.Drawing.Color.White;
            buttonSaveServerSettings.Location = new System.Drawing.Point(45, 385);
            buttonSaveServerSettings.Name = "buttonSaveServerSettings";
            buttonSaveServerSettings.Size = new System.Drawing.Size(340, 50);
            buttonSaveServerSettings.TabIndex = 2;
            buttonSaveServerSettings.Text = "حفظ الاعدادات";
            buttonSaveServerSettings.UseVisualStyleBackColor = false;
            buttonSaveServerSettings.Click += buttonSaveServerSettings_Click;
            // 
            // radioButtonLocalConnect
            // 
            radioButtonLocalConnect.AutoSize = true;
            radioButtonLocalConnect.Checked = true;
            radioButtonLocalConnect.ForeColor = System.Drawing.Color.Black;
            radioButtonLocalConnect.Location = new System.Drawing.Point(478, 61);
            radioButtonLocalConnect.Name = "radioButtonLocalConnect";
            radioButtonLocalConnect.Size = new System.Drawing.Size(52, 24);
            radioButtonLocalConnect.TabIndex = 1;
            radioButtonLocalConnect.TabStop = true;
            radioButtonLocalConnect.Text = "محلي";
            radioButtonLocalConnect.UseVisualStyleBackColor = true;
            radioButtonLocalConnect.CheckedChanged += radioButtonLocalConnect_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUser);
            panel1.Controls.Add(textBoxPort);
            panel1.Controls.Add(textBoxDataBase);
            panel1.Controls.Add(textBoxServer);
            panel1.Location = new System.Drawing.Point(7, 36);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(419, 317);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(319, 269);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(58, 20);
            label9.TabIndex = 0;
            label9.Text = "كلمة السر";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(303, 198);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.TabIndex = 0;
            label7.Text = "اسم المستخدم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(342, 143);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 20);
            label6.TabIndex = 0;
            label6.Text = "المنفذ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(300, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "قاعدة البيانات";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(328, 18);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 20);
            label8.TabIndex = 0;
            label8.Text = "السيرفر";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new System.Drawing.Point(14, 259);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxPassword.Size = new System.Drawing.Size(251, 26);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUser
            // 
            textBoxUser.Enabled = false;
            textBoxUser.Location = new System.Drawing.Point(14, 198);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PasswordChar = '*';
            textBoxUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxUser.Size = new System.Drawing.Size(251, 26);
            textBoxUser.TabIndex = 1;
            textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPort
            // 
            textBoxPort.Enabled = false;
            textBoxPort.Location = new System.Drawing.Point(14, 137);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxPort.Size = new System.Drawing.Size(251, 26);
            textBoxPort.TabIndex = 1;
            textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Location = new System.Drawing.Point(14, 76);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxDataBase.Size = new System.Drawing.Size(251, 26);
            textBoxDataBase.TabIndex = 1;
            textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new System.Drawing.Point(14, 15);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxServer.Size = new System.Drawing.Size(251, 26);
            textBoxServer.TabIndex = 1;
            textBoxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1015, 729);
            Controls.Add(groupBoxServer);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "الاعدادات";
            TopMost = true;
            FormClosing += SettingsForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).EndInit();
            groupBoxServer.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Button buttonSaveGeneralSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCompanyDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelImportLogo;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.Button buttonSaveServerSettings;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.RadioButton radioButtonNetworkConnect;
        private System.Windows.Forms.RadioButton radioButtonLocalConnect;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.NumericUpDown numericUpDownDamageDuration;
        private System.Windows.Forms.Label label10;
    }
}