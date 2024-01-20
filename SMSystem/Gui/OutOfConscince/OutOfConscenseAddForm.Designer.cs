
namespace SMSystem.Gui.OutOfConscince
{
    partial class OutOfConscenseAddForm
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
            textBoxCode = new System.Windows.Forms.ComboBox();
            comboBoxName = new System.Windows.Forms.ComboBox();
            textBoxUnit = new System.Windows.Forms.TextBox();
            textBoxCurrentQuanttiy = new System.Windows.Forms.TextBox();
            textBoxStore = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxIncome = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            linkLabelCodeGenerator = new System.Windows.Forms.LinkLabel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            checkBoxIsExpDataEnabled = new System.Windows.Forms.CheckBox();
            dateTimePickerExpData = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBoxTotalPrice = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxNewPrice = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            textBoxNewCode = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            comboBoxSupplier = new System.Windows.Forms.ComboBox();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            textBoxReciptNo = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBoxReciptName = new System.Windows.Forms.ComboBox();
            label28 = new System.Windows.Forms.Label();
            dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            dateTimePickerReciptDate = new System.Windows.Forms.DateTimePicker();
            linkLabelNewSupplier = new System.Windows.Forms.LinkLabel();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            textBoxInterNo = new System.Windows.Forms.TextBox();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            flowLayoutPanelNavBar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonSave);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 620);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1056, 75);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(922, 11);
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
            groupBox1.Controls.Add(textBoxCode);
            groupBox1.Controls.Add(comboBoxName);
            groupBox1.Controls.Add(textBoxUnit);
            groupBox1.Controls.Add(textBoxCurrentQuanttiy);
            groupBox1.Controls.Add(textBoxStore);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIncome);
            groupBox1.Controls.Add(label12);
            groupBox1.ForeColor = System.Drawing.Color.Blue;
            groupBox1.Location = new System.Drawing.Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(367, 514);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المادة الحالية";
            // 
            // textBoxCode
            // 
            textBoxCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            textBoxCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            textBoxCode.FormattingEnabled = true;
            textBoxCode.Location = new System.Drawing.Point(12, 52);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new System.Drawing.Size(233, 28);
            textBoxCode.TabIndex = 7;
            textBoxCode.Text = "ابحث عن طريق الكود";
            textBoxCode.SelectedIndexChanged += textBoxCode_SelectedIndexChanged;
            // 
            // comboBoxName
            // 
            comboBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new System.Drawing.Point(12, 124);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new System.Drawing.Size(233, 28);
            comboBoxName.TabIndex = 7;
            comboBoxName.Text = "ابحث عن  اسم المادة";
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new System.Drawing.Point(12, 325);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.ReadOnly = true;
            textBoxUnit.Size = new System.Drawing.Size(233, 26);
            textBoxUnit.TabIndex = 4;
            textBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentQuanttiy
            // 
            textBoxCurrentQuanttiy.Location = new System.Drawing.Point(12, 258);
            textBoxCurrentQuanttiy.Name = "textBoxCurrentQuanttiy";
            textBoxCurrentQuanttiy.ReadOnly = true;
            textBoxCurrentQuanttiy.Size = new System.Drawing.Size(233, 26);
            textBoxCurrentQuanttiy.TabIndex = 4;
            textBoxCurrentQuanttiy.Text = "0";
            textBoxCurrentQuanttiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStore
            // 
            textBoxStore.Location = new System.Drawing.Point(12, 191);
            textBoxStore.Name = "textBoxStore";
            textBoxStore.ReadOnly = true;
            textBoxStore.Size = new System.Drawing.Size(233, 26);
            textBoxStore.TabIndex = 4;
            textBoxStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(12, 459);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new System.Drawing.Size(233, 26);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.Text = "0";
            textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(290, 121);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 20);
            label5.TabIndex = 2;
            label5.Text = "الاسم:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = System.Drawing.Color.Black;
            label15.Location = new System.Drawing.Point(288, 466);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(43, 20);
            label15.TabIndex = 2;
            label15.Text = "السعر:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(283, 331);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "الوحدة:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(286, 258);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 20);
            label7.TabIndex = 2;
            label7.Text = "الكمية:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(291, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "الكود:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(279, 190);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "المخزن:";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Location = new System.Drawing.Point(12, 392);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.ReadOnly = true;
            textBoxIncome.Size = new System.Drawing.Size(233, 26);
            textBoxIncome.TabIndex = 4;
            textBoxIncome.Text = "0";
            textBoxIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(285, 397);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(45, 20);
            label12.TabIndex = 2;
            label12.Text = "الداخل:";
            // 
            // linkLabelCodeGenerator
            // 
            linkLabelCodeGenerator.AutoSize = true;
            linkLabelCodeGenerator.Location = new System.Drawing.Point(130, 41);
            linkLabelCodeGenerator.Name = "linkLabelCodeGenerator";
            linkLabelCodeGenerator.Size = new System.Drawing.Size(32, 20);
            linkLabelCodeGenerator.TabIndex = 8;
            linkLabelCodeGenerator.TabStop = true;
            linkLabelCodeGenerator.Text = "توليد";
            linkLabelCodeGenerator.LinkClicked += linkLabelCodeGenerator_LinkClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxIsExpDataEnabled);
            groupBox2.Controls.Add(dateTimePickerExpData);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(linkLabelCodeGenerator);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxTotalPrice);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxNewPrice);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxQuantity);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBoxNewCode);
            groupBox2.Controls.Add(label8);
            groupBox2.ForeColor = System.Drawing.Color.Blue;
            groupBox2.Location = new System.Drawing.Point(390, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(321, 514);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ملعومات المادة المتلفة";
            // 
            // checkBoxIsExpDataEnabled
            // 
            checkBoxIsExpDataEnabled.AutoSize = true;
            checkBoxIsExpDataEnabled.Checked = true;
            checkBoxIsExpDataEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxIsExpDataEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxIsExpDataEnabled.Location = new System.Drawing.Point(99, 328);
            checkBoxIsExpDataEnabled.Name = "checkBoxIsExpDataEnabled";
            checkBoxIsExpDataEnabled.Size = new System.Drawing.Size(48, 17);
            checkBoxIsExpDataEnabled.TabIndex = 10;
            checkBoxIsExpDataEnabled.Text = "بدون";
            checkBoxIsExpDataEnabled.UseVisualStyleBackColor = true;
            checkBoxIsExpDataEnabled.CheckedChanged += checkBoxIsExpDataEnabled_CheckedChanged;
            // 
            // dateTimePickerExpData
            // 
            dateTimePickerExpData.Enabled = false;
            dateTimePickerExpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerExpData.Location = new System.Drawing.Point(22, 361);
            dateTimePickerExpData.Name = "dateTimePickerExpData";
            dateTimePickerExpData.Size = new System.Drawing.Size(277, 26);
            dateTimePickerExpData.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Red;
            label10.Location = new System.Drawing.Point(240, 41);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(15, 20);
            label10.TabIndex = 6;
            label10.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(211, 322);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(15, 20);
            label6.TabIndex = 6;
            label6.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.Color.Red;
            label14.Location = new System.Drawing.Point(240, 216);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(15, 20);
            label14.TabIndex = 6;
            label14.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(240, 127);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(15, 20);
            label9.TabIndex = 6;
            label9.Text = "*";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new System.Drawing.Point(22, 452);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new System.Drawing.Size(277, 26);
            textBoxTotalPrice.TabIndex = 4;
            textBoxTotalPrice.Text = "0";
            textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(232, 325);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 17);
            label4.TabIndex = 2;
            label4.Text = "تاريخ الانتهاء";
            // 
            // textBoxNewPrice
            // 
            textBoxNewPrice.Location = new System.Drawing.Point(22, 262);
            textBoxNewPrice.Name = "textBoxNewPrice";
            textBoxNewPrice.Size = new System.Drawing.Size(277, 26);
            textBoxNewPrice.TabIndex = 4;
            textBoxNewPrice.Text = "0";
            textBoxNewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxNewPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = System.Drawing.Color.Black;
            label16.Location = new System.Drawing.Point(219, 409);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(80, 20);
            label16.TabIndex = 2;
            label16.Text = "اجمالي السعر:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(256, 225);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(43, 20);
            label11.TabIndex = 2;
            label11.Text = "السعر:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(22, 170);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(277, 26);
            textBoxQuantity.TabIndex = 4;
            textBoxQuantity.Text = "1";
            textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(261, 132);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(38, 20);
            label13.TabIndex = 2;
            label13.Text = "الكمية";
            // 
            // textBoxNewCode
            // 
            textBoxNewCode.Location = new System.Drawing.Point(22, 81);
            textBoxNewCode.Name = "textBoxNewCode";
            textBoxNewCode.Size = new System.Drawing.Size(277, 26);
            textBoxNewCode.TabIndex = 4;
            textBoxNewCode.Text = "1568467461";
            textBoxNewCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(261, 41);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 20);
            label8.TabIndex = 2;
            label8.Text = "الكود:";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new System.Drawing.Point(18, 352);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new System.Drawing.Size(277, 28);
            comboBoxSupplier.TabIndex = 7;
            comboBoxSupplier.Text = "اختر المستلم";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.Color.Red;
            label18.Location = new System.Drawing.Point(204, 132);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(15, 20);
            label18.TabIndex = 6;
            label18.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = System.Drawing.Color.Black;
            label19.Location = new System.Drawing.Point(227, 132);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(70, 20);
            label19.TabIndex = 2;
            label19.Text = "رقم الوصل:";
            // 
            // textBoxReciptNo
            // 
            textBoxReciptNo.Location = new System.Drawing.Point(20, 170);
            textBoxReciptNo.Name = "textBoxReciptNo";
            textBoxReciptNo.Size = new System.Drawing.Size(277, 26);
            textBoxReciptNo.TabIndex = 4;
            textBoxReciptNo.Text = "0";
            textBoxReciptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxReciptNo.TextChanged += textBoxReciptNo_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxReciptName);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(dateTimePickerIncome);
            groupBox3.Controls.Add(dateTimePickerReciptDate);
            groupBox3.Controls.Add(linkLabelNewSupplier);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(comboBoxSupplier);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(textBoxInterNo);
            groupBox3.Controls.Add(textBoxReciptNo);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label22);
            groupBox3.ForeColor = System.Drawing.Color.Blue;
            groupBox3.Location = new System.Drawing.Point(725, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(321, 611);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "معلومات المجهز";
            // 
            // textBoxReciptName
            // 
            textBoxReciptName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            textBoxReciptName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            textBoxReciptName.FormattingEnabled = true;
            textBoxReciptName.Location = new System.Drawing.Point(18, 81);
            textBoxReciptName.Name = "textBoxReciptName";
            textBoxReciptName.Size = new System.Drawing.Size(277, 28);
            textBoxReciptName.TabIndex = 7;
            textBoxReciptName.Text = "اختر اسم الوصل";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = System.Drawing.Color.Black;
            label28.Location = new System.Drawing.Point(196, 409);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(99, 20);
            label28.TabIndex = 2;
            label28.Text = "رقم مستند الادخال";
            // 
            // dateTimePickerIncome
            // 
            dateTimePickerIncome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerIncome.Location = new System.Drawing.Point(20, 539);
            dateTimePickerIncome.Name = "dateTimePickerIncome";
            dateTimePickerIncome.Size = new System.Drawing.Size(277, 26);
            dateTimePickerIncome.TabIndex = 9;
            // 
            // dateTimePickerReciptDate
            // 
            dateTimePickerReciptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerReciptDate.Location = new System.Drawing.Point(20, 262);
            dateTimePickerReciptDate.Name = "dateTimePickerReciptDate";
            dateTimePickerReciptDate.Size = new System.Drawing.Size(277, 26);
            dateTimePickerReciptDate.TabIndex = 9;
            // 
            // linkLabelNewSupplier
            // 
            linkLabelNewSupplier.AutoSize = true;
            linkLabelNewSupplier.Location = new System.Drawing.Point(97, 312);
            linkLabelNewSupplier.Name = "linkLabelNewSupplier";
            linkLabelNewSupplier.Size = new System.Drawing.Size(42, 20);
            linkLabelNewSupplier.TabIndex = 8;
            linkLabelNewSupplier.TabStop = true;
            linkLabelNewSupplier.Text = "اضافة";
            linkLabelNewSupplier.LinkClicked += linkLabelNewSupplier_LinkClicked;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = System.Drawing.Color.Black;
            label26.Location = new System.Drawing.Point(234, 312);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(64, 20);
            label26.TabIndex = 2;
            label26.Text = "اسم المستلم";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label27.ForeColor = System.Drawing.Color.Red;
            label27.Location = new System.Drawing.Point(175, 409);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(15, 20);
            label27.TabIndex = 6;
            label27.Text = "*";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label25.ForeColor = System.Drawing.Color.Red;
            label25.Location = new System.Drawing.Point(219, 312);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(15, 20);
            label25.TabIndex = 6;
            label25.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = System.Drawing.Color.Black;
            label20.Location = new System.Drawing.Point(182, 502);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(115, 20);
            label20.TabIndex = 2;
            label20.Text = "تاريخ مستند الادخال:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.Red;
            label17.Location = new System.Drawing.Point(161, 502);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(15, 20);
            label17.TabIndex = 6;
            label17.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = System.Drawing.Color.Black;
            label24.Location = new System.Drawing.Point(219, 225);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(78, 20);
            label24.TabIndex = 2;
            label24.Text = "تاريخ الوصل";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.ForeColor = System.Drawing.Color.Red;
            label23.Location = new System.Drawing.Point(204, 225);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(15, 20);
            label23.TabIndex = 6;
            label23.Text = "*";
            // 
            // textBoxInterNo
            // 
            textBoxInterNo.Location = new System.Drawing.Point(18, 452);
            textBoxInterNo.Name = "textBoxInterNo";
            textBoxInterNo.Size = new System.Drawing.Size(277, 26);
            textBoxInterNo.TabIndex = 4;
            textBoxInterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxInterNo.TextChanged += textBoxInterNo_TextChanged_1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = System.Drawing.Color.Black;
            label21.Location = new System.Drawing.Point(230, 41);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(67, 20);
            label21.TabIndex = 2;
            label21.Text = "اسم الوصل";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.ForeColor = System.Drawing.Color.Red;
            label22.Location = new System.Drawing.Point(199, 41);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(15, 20);
            label22.TabIndex = 6;
            label22.Text = "*";
            // 
            // OutOfConscenseAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1056, 695);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OutOfConscenseAddForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "مادة خارج الذمة";
            TopMost = true;
            Load += OutOfConscinesMaterialsAddForm_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabelCodeGenerator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNewCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxReciptNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsExpDataEnabled;
        public System.Windows.Forms.ComboBox comboBoxName;
        public System.Windows.Forms.ComboBox textBoxCode;
        public System.Windows.Forms.TextBox textBoxIncome;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxUnit;
        public System.Windows.Forms.TextBox textBoxCurrentQuanttiy;
        public System.Windows.Forms.TextBox textBoxStore;
        public System.Windows.Forms.TextBox textBoxNewPrice;
        public System.Windows.Forms.DateTimePicker dateTimePickerExpData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxInterNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.DateTimePicker dateTimePickerReciptDate;
        public System.Windows.Forms.ComboBox textBoxReciptName;
        private System.Windows.Forms.LinkLabel linkLabelNewSupplier;
        public System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
    }
}