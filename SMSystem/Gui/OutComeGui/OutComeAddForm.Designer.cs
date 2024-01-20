
namespace SMSystem.Gui.OutComeGui
{
    partial class OutComeAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            groupBox2 = new System.Windows.Forms.GroupBox();
            buttonAddMaterial = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            textBoxTotalPrice = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            comboBoxSupplier = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            checkBoxSelfCard = new System.Windows.Forms.CheckBox();
            label28 = new System.Windows.Forms.Label();
            dateTimePickerReciptDate = new System.Windows.Forms.DateTimePicker();
            linkLabelNewSupplier = new System.Windows.Forms.LinkLabel();
            label26 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            ComboBoxCard = new System.Windows.Forms.ComboBox();
            label24 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            textBoxInterNo = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonDelete = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            flowLayoutPanelNavBar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonSave);
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(-12, 656);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(379, 75);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(245, 11);
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
            groupBox1.Size = new System.Drawing.Size(367, 559);
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
            textBoxCode.Size = new System.Drawing.Size(257, 28);
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
            comboBoxName.Size = new System.Drawing.Size(257, 28);
            comboBoxName.TabIndex = 7;
            comboBoxName.Text = "ابحث عن  اسم المادة";
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new System.Drawing.Point(12, 325);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.ReadOnly = true;
            textBoxUnit.Size = new System.Drawing.Size(257, 26);
            textBoxUnit.TabIndex = 4;
            textBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentQuanttiy
            // 
            textBoxCurrentQuanttiy.Location = new System.Drawing.Point(12, 258);
            textBoxCurrentQuanttiy.Name = "textBoxCurrentQuanttiy";
            textBoxCurrentQuanttiy.ReadOnly = true;
            textBoxCurrentQuanttiy.Size = new System.Drawing.Size(257, 26);
            textBoxCurrentQuanttiy.TabIndex = 4;
            textBoxCurrentQuanttiy.Text = "0";
            textBoxCurrentQuanttiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStore
            // 
            textBoxStore.Location = new System.Drawing.Point(12, 191);
            textBoxStore.Name = "textBoxStore";
            textBoxStore.ReadOnly = true;
            textBoxStore.Size = new System.Drawing.Size(257, 26);
            textBoxStore.TabIndex = 4;
            textBoxStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(12, 473);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new System.Drawing.Size(257, 26);
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
            label15.Location = new System.Drawing.Point(288, 480);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(43, 20);
            label15.TabIndex = 2;
            label15.Text = "السعر:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(281, 328);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "الوحدة:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(282, 258);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 20);
            label7.TabIndex = 2;
            label7.Text = "الكمية :";
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
            textBoxIncome.Size = new System.Drawing.Size(257, 26);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAddMaterial);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxTotalPrice);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBoxQuantity);
            groupBox2.Controls.Add(label13);
            groupBox2.ForeColor = System.Drawing.Color.Blue;
            groupBox2.Location = new System.Drawing.Point(390, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(321, 365);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات المادة المضافة";
            // 
            // buttonAddMaterial
            // 
            buttonAddMaterial.Image = Properties.Resources.save_32px;
            buttonAddMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddMaterial.Location = new System.Drawing.Point(22, 272);
            buttonAddMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAddMaterial.Name = "buttonAddMaterial";
            buttonAddMaterial.Size = new System.Drawing.Size(277, 54);
            buttonAddMaterial.TabIndex = 0;
            buttonAddMaterial.Text = "ادراج ضمن القائمة";
            buttonAddMaterial.UseVisualStyleBackColor = true;
            buttonAddMaterial.Click += buttonAddMaterial_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(137, 41);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(15, 20);
            label9.TabIndex = 6;
            label9.Text = "*";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new System.Drawing.Point(22, 177);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new System.Drawing.Size(277, 26);
            textBoxTotalPrice.TabIndex = 4;
            textBoxTotalPrice.Text = "0";
            textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = System.Drawing.Color.Black;
            label16.Location = new System.Drawing.Point(204, 127);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(80, 20);
            label16.TabIndex = 2;
            label16.Text = "اجمالي السعر:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(22, 84);
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
            label13.Location = new System.Drawing.Point(230, 52);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(69, 20);
            label13.TabIndex = 2;
            label13.Text = "الكمية /العدد";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new System.Drawing.Point(20, 267);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new System.Drawing.Size(277, 28);
            comboBoxSupplier.TabIndex = 7;
            comboBoxSupplier.Text = "اختر العميل";
            comboBoxSupplier.SelectedIndexChanged += comboBoxSupplier_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxSelfCard);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(dateTimePickerReciptDate);
            groupBox3.Controls.Add(linkLabelNewSupplier);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(comboBoxSupplier);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(ComboBoxCard);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(textBoxInterNo);
            groupBox3.ForeColor = System.Drawing.Color.Blue;
            groupBox3.Location = new System.Drawing.Point(723, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(321, 426);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "معلومات قائمة الاخراج";
            // 
            // checkBoxSelfCard
            // 
            checkBoxSelfCard.AutoSize = true;
            checkBoxSelfCard.Checked = true;
            checkBoxSelfCard.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxSelfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxSelfCard.Location = new System.Drawing.Point(22, 317);
            checkBoxSelfCard.Name = "checkBoxSelfCard";
            checkBoxSelfCard.Size = new System.Drawing.Size(48, 21);
            checkBoxSelfCard.TabIndex = 8;
            checkBoxSelfCard.Text = "بدون";
            checkBoxSelfCard.UseVisualStyleBackColor = true;
            checkBoxSelfCard.CheckedChanged += checkBoxSelfCard_CheckedChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = System.Drawing.Color.Black;
            label28.Location = new System.Drawing.Point(195, 41);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(102, 20);
            label28.TabIndex = 2;
            label28.Text = "رقم مستند الاخراج";
            // 
            // dateTimePickerReciptDate
            // 
            dateTimePickerReciptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerReciptDate.Location = new System.Drawing.Point(22, 177);
            dateTimePickerReciptDate.Name = "dateTimePickerReciptDate";
            dateTimePickerReciptDate.Size = new System.Drawing.Size(277, 26);
            dateTimePickerReciptDate.TabIndex = 9;
            // 
            // linkLabelNewSupplier
            // 
            linkLabelNewSupplier.AutoSize = true;
            linkLabelNewSupplier.Location = new System.Drawing.Point(20, 225);
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
            label26.Location = new System.Drawing.Point(223, 225);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(76, 20);
            label26.TabIndex = 2;
            label26.Text = "العميل/المستلم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(232, 318);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 2;
            label4.Text = "بطاقة الذمة";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label27.ForeColor = System.Drawing.Color.Red;
            label27.Location = new System.Drawing.Point(180, 38);
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
            label25.Location = new System.Drawing.Point(202, 225);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(15, 20);
            label25.TabIndex = 6;
            label25.Text = "*";
            // 
            // ComboBoxCard
            // 
            ComboBoxCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            ComboBoxCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            ComboBoxCard.Enabled = false;
            ComboBoxCard.FormattingEnabled = true;
            ComboBoxCard.Location = new System.Drawing.Point(22, 358);
            ComboBoxCard.Name = "ComboBoxCard";
            ComboBoxCard.Size = new System.Drawing.Size(277, 28);
            ComboBoxCard.TabIndex = 7;
            ComboBoxCard.Text = "اكتب اسم المستلم";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = System.Drawing.Color.Black;
            label24.Location = new System.Drawing.Point(185, 140);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(114, 20);
            label24.TabIndex = 2;
            label24.Text = "تاريخ مستند الاخراج";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.ForeColor = System.Drawing.Color.Red;
            label23.Location = new System.Drawing.Point(164, 134);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(15, 20);
            label23.TabIndex = 6;
            label23.Text = "*";
            // 
            // textBoxInterNo
            // 
            textBoxInterNo.Location = new System.Drawing.Point(20, 84);
            textBoxInterNo.Name = "textBoxInterNo";
            textBoxInterNo.Size = new System.Drawing.Size(277, 26);
            textBoxInterNo.TabIndex = 4;
            textBoxInterNo.Text = "0";
            textBoxInterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxInterNo.TextChanged += textBoxInterNo_TextChanged_1;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "لا بيانات";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new System.Drawing.Size(654, 208);
            dataGridView.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new System.Drawing.Point(390, 453);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(654, 278);
            panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonRefresh);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 208);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanel1.Size = new System.Drawing.Size(654, 73);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.Delete_32px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(518, 11);
            buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(120, 54);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "  حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Image = Properties.Resources.refresh_32px;
            buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new System.Drawing.Point(390, 11);
            buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(120, 54);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "  تحديث";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // OutComeAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1056, 732);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OutComeAddForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "قائمة اخراج";
            TopMost = true;
            FormClosing += OutComeAddForm_FormClosing;
            Load += OutComeAddForm_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        public System.Windows.Forms.ComboBox comboBoxName;
        public System.Windows.Forms.ComboBox textBoxCode;
        public System.Windows.Forms.TextBox textBoxIncome;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxUnit;
        public System.Windows.Forms.TextBox textBoxCurrentQuanttiy;
        public System.Windows.Forms.TextBox textBoxStore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxInterNo;
        private System.Windows.Forms.LinkLabel linkLabelNewSupplier;
        private System.Windows.Forms.Button buttonAddMaterial;
        public System.Windows.Forms.DateTimePicker dateTimePickerReciptDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxSelfCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxCard;
    }
}