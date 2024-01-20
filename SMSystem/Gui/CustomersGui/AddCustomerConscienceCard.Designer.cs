
namespace SMSystem.Gui.CustomersGui
{
    partial class AddCustomerConscienceCard
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
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonSave = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBoxMaterialName = new System.Windows.Forms.ComboBox();
            TextBoxInterNo = new System.Windows.Forms.TextBox();
            textBoxCurrentQuanttiy = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            dateTimePickerInterDateTime = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            checkBoxMoveToAnotherDep = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBoxReciverName = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            dateTimePickerRecive = new System.Windows.Forms.DateTimePicker();
            textBoxReciverSign = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBoxMoveToAnotherDep = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            comboBoxDepName = new System.Windows.Forms.ComboBox();
            label18 = new System.Windows.Forms.Label();
            comboBoxTransportReciverName = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            dateTimePickerTransprotReciverDate = new System.Windows.Forms.DateTimePicker();
            textBoxTransportReciverSign = new System.Windows.Forms.TextBox();
            flowLayoutPanelNavBar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxMoveToAnotherDep.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonSave);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 501);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1091, 75);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(957, 11);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(120, 54);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "  حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxMaterialName);
            groupBox1.Controls.Add(TextBoxInterNo);
            groupBox1.Controls.Add(textBoxCurrentQuanttiy);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePickerInterDateTime);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.ForeColor = System.Drawing.Color.Blue;
            groupBox1.Location = new System.Drawing.Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(367, 471);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المادة ";
            // 
            // comboBoxMaterialName
            // 
            comboBoxMaterialName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxMaterialName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxMaterialName.FormattingEnabled = true;
            comboBoxMaterialName.Location = new System.Drawing.Point(18, 81);
            comboBoxMaterialName.Name = "comboBoxMaterialName";
            comboBoxMaterialName.Size = new System.Drawing.Size(321, 28);
            comboBoxMaterialName.TabIndex = 7;
            comboBoxMaterialName.Text = "اختر او اكتب اسم المادة";
            // 
            // TextBoxInterNo
            // 
            TextBoxInterNo.Location = new System.Drawing.Point(18, 276);
            TextBoxInterNo.Name = "TextBoxInterNo";
            TextBoxInterNo.Size = new System.Drawing.Size(321, 26);
            TextBoxInterNo.TabIndex = 4;
            TextBoxInterNo.Text = "0";
            TextBoxInterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxInterNo.TextChanged += TextBoxInterNo_TextChanged_2;
            // 
            // textBoxCurrentQuanttiy
            // 
            textBoxCurrentQuanttiy.Location = new System.Drawing.Point(18, 180);
            textBoxCurrentQuanttiy.Name = "textBoxCurrentQuanttiy";
            textBoxCurrentQuanttiy.Size = new System.Drawing.Size(321, 26);
            textBoxCurrentQuanttiy.TabIndex = 4;
            textBoxCurrentQuanttiy.Text = "0";
            textBoxCurrentQuanttiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxCurrentQuanttiy.TextChanged += textBoxCurrentQuanttiy_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(224, 346);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(115, 20);
            label10.TabIndex = 2;
            label10.Text = "تاريخ مستند الادخال:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerInterDateTime
            // 
            dateTimePickerInterDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerInterDateTime.Location = new System.Drawing.Point(18, 383);
            dateTimePickerInterDateTime.Name = "dateTimePickerInterDateTime";
            dateTimePickerInterDateTime.Size = new System.Drawing.Size(321, 26);
            dateTimePickerInterDateTime.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(236, 236);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(103, 20);
            label9.TabIndex = 2;
            label9.Text = "رقم مستند الادخال:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(299, 41);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 20);
            label5.TabIndex = 2;
            label5.Text = "الاسم:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(297, 140);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 20);
            label7.TabIndex = 2;
            label7.Text = "الكمية:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxMoveToAnotherDep);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxReciverName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePickerRecive);
            groupBox2.Controls.Add(textBoxReciverSign);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = System.Drawing.Color.Blue;
            groupBox2.Location = new System.Drawing.Point(404, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(321, 477);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات المستلم";
            // 
            // checkBoxMoveToAnotherDep
            // 
            checkBoxMoveToAnotherDep.AutoSize = true;
            checkBoxMoveToAnotherDep.Location = new System.Drawing.Point(173, 393);
            checkBoxMoveToAnotherDep.Name = "checkBoxMoveToAnotherDep";
            checkBoxMoveToAnotherDep.Size = new System.Drawing.Size(128, 24);
            checkBoxMoveToAnotherDep.TabIndex = 10;
            checkBoxMoveToAnotherDep.Text = "نقل الى وحدة اخرى";
            checkBoxMoveToAnotherDep.UseVisualStyleBackColor = true;
            checkBoxMoveToAnotherDep.CheckedChanged += checkBoxMoveToAnotherDep_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(218, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "تاريخ الاستلام";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(259, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "التوقيع";
            // 
            // comboBoxReciverName
            // 
            comboBoxReciverName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxReciverName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxReciverName.FormattingEnabled = true;
            comboBoxReciverName.Location = new System.Drawing.Point(16, 81);
            comboBoxReciverName.Name = "comboBoxReciverName";
            comboBoxReciverName.Size = new System.Drawing.Size(285, 28);
            comboBoxReciverName.TabIndex = 7;
            comboBoxReciverName.Text = "اختر او اكتب اسم المستلم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(261, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "الاسم:";
            // 
            // dateTimePickerRecive
            // 
            dateTimePickerRecive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerRecive.Location = new System.Drawing.Point(16, 180);
            dateTimePickerRecive.Name = "dateTimePickerRecive";
            dateTimePickerRecive.Size = new System.Drawing.Size(285, 26);
            dateTimePickerRecive.TabIndex = 9;
            // 
            // textBoxReciverSign
            // 
            textBoxReciverSign.Location = new System.Drawing.Point(16, 276);
            textBoxReciverSign.Name = "textBoxReciverSign";
            textBoxReciverSign.Size = new System.Drawing.Size(285, 26);
            textBoxReciverSign.TabIndex = 4;
            textBoxReciverSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(238, 242);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(15, 20);
            label8.TabIndex = 6;
            label8.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(191, 146);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(15, 20);
            label6.TabIndex = 6;
            label6.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(240, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 20);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // groupBoxMoveToAnotherDep
            // 
            groupBoxMoveToAnotherDep.Controls.Add(label11);
            groupBoxMoveToAnotherDep.Controls.Add(label12);
            groupBoxMoveToAnotherDep.Controls.Add(comboBoxDepName);
            groupBoxMoveToAnotherDep.Controls.Add(label18);
            groupBoxMoveToAnotherDep.Controls.Add(comboBoxTransportReciverName);
            groupBoxMoveToAnotherDep.Controls.Add(label13);
            groupBoxMoveToAnotherDep.Controls.Add(dateTimePickerTransprotReciverDate);
            groupBoxMoveToAnotherDep.Controls.Add(textBoxTransportReciverSign);
            groupBoxMoveToAnotherDep.Enabled = false;
            groupBoxMoveToAnotherDep.ForeColor = System.Drawing.Color.Blue;
            groupBoxMoveToAnotherDep.Location = new System.Drawing.Point(742, 6);
            groupBoxMoveToAnotherDep.Name = "groupBoxMoveToAnotherDep";
            groupBoxMoveToAnotherDep.Size = new System.Drawing.Size(321, 477);
            groupBoxMoveToAnotherDep.TabIndex = 3;
            groupBoxMoveToAnotherDep.TabStop = false;
            groupBoxMoveToAnotherDep.Text = "معلومات المستلم";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(214, 242);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 20);
            label11.TabIndex = 2;
            label11.Text = "تاريخ الاستلام";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(255, 340);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 20);
            label12.TabIndex = 2;
            label12.Text = "التوقيع";
            // 
            // comboBoxDepName
            // 
            comboBoxDepName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxDepName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxDepName.FormattingEnabled = true;
            comboBoxDepName.Location = new System.Drawing.Point(12, 87);
            comboBoxDepName.Name = "comboBoxDepName";
            comboBoxDepName.Size = new System.Drawing.Size(285, 28);
            comboBoxDepName.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = System.Drawing.Color.Black;
            label18.Location = new System.Drawing.Point(230, 47);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(67, 20);
            label18.TabIndex = 2;
            label18.Text = "اسم الوحدة:";
            // 
            // comboBoxTransportReciverName
            // 
            comboBoxTransportReciverName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxTransportReciverName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxTransportReciverName.FormattingEnabled = true;
            comboBoxTransportReciverName.Location = new System.Drawing.Point(12, 186);
            comboBoxTransportReciverName.Name = "comboBoxTransportReciverName";
            comboBoxTransportReciverName.Size = new System.Drawing.Size(285, 28);
            comboBoxTransportReciverName.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(257, 146);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(40, 20);
            label13.TabIndex = 2;
            label13.Text = "الاسم:";
            // 
            // dateTimePickerTransprotReciverDate
            // 
            dateTimePickerTransprotReciverDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerTransprotReciverDate.Location = new System.Drawing.Point(12, 285);
            dateTimePickerTransprotReciverDate.Name = "dateTimePickerTransprotReciverDate";
            dateTimePickerTransprotReciverDate.Size = new System.Drawing.Size(285, 26);
            dateTimePickerTransprotReciverDate.TabIndex = 9;
            // 
            // textBoxTransportReciverSign
            // 
            textBoxTransportReciverSign.Location = new System.Drawing.Point(12, 381);
            textBoxTransportReciverSign.Name = "textBoxTransportReciverSign";
            textBoxTransportReciverSign.Size = new System.Drawing.Size(285, 26);
            textBoxTransportReciverSign.TabIndex = 4;
            textBoxTransportReciverSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCustomerConscienceCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1091, 576);
            Controls.Add(groupBoxMoveToAnotherDep);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCustomerConscienceCard";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ادخال مادة ";
            TopMost = true;
            Load += AddCustomerConscienceCard_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxMoveToAnotherDep.ResumeLayout(false);
            groupBoxMoveToAnotherDep.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBoxMaterialName;
        public System.Windows.Forms.TextBox textBoxCurrentQuanttiy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxReciverName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerRecive;
        private System.Windows.Forms.TextBox textBoxReciverSign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TextBoxInterNo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dateTimePickerInterDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxMoveToAnotherDep;
        private System.Windows.Forms.GroupBox groupBoxMoveToAnotherDep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox comboBoxDepName;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox comboBoxTransportReciverName;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dateTimePickerTransprotReciverDate;
        private System.Windows.Forms.TextBox textBoxTransportReciverSign;
    }
}