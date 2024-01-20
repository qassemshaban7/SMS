
namespace SMSystem.Gui.MaterailsGui
{
    partial class MaterailsAddForm
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
            linkLabelCodeGenerator = new System.Windows.Forms.LinkLabel();
            linkLabelAddStore = new System.Windows.Forms.LinkLabel();
            comboBoxStore = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            textBoxFullName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBoxCode = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            comboBoxUnit = new System.Windows.Forms.ComboBox();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            textBoxTotalPrice = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            textBoxOutCome = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            textBoxIncome = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            flowLayoutPanelNavBar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonSave);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 553);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1118, 75);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(984, 11);
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
            groupBox1.Controls.Add(linkLabelCodeGenerator);
            groupBox1.Controls.Add(linkLabelAddStore);
            groupBox1.Controls.Add(comboBoxStore);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxCode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = System.Drawing.Color.Blue;
            groupBox1.Location = new System.Drawing.Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(539, 514);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المادة";
            // 
            // linkLabelCodeGenerator
            // 
            linkLabelCodeGenerator.AutoSize = true;
            linkLabelCodeGenerator.Location = new System.Drawing.Point(6, 129);
            linkLabelCodeGenerator.Name = "linkLabelCodeGenerator";
            linkLabelCodeGenerator.Size = new System.Drawing.Size(32, 20);
            linkLabelCodeGenerator.TabIndex = 8;
            linkLabelCodeGenerator.TabStop = true;
            linkLabelCodeGenerator.Text = "توليد";
            linkLabelCodeGenerator.LinkClicked += linkLabelCodeGenerator_LinkClicked;
            // 
            // linkLabelAddStore
            // 
            linkLabelAddStore.AutoSize = true;
            linkLabelAddStore.Location = new System.Drawing.Point(6, 56);
            linkLabelAddStore.Name = "linkLabelAddStore";
            linkLabelAddStore.Size = new System.Drawing.Size(42, 20);
            linkLabelAddStore.TabIndex = 8;
            linkLabelAddStore.TabStop = true;
            linkLabelAddStore.Text = "اضافة";
            linkLabelAddStore.LinkClicked += linkLabelAddStore_LinkClicked;
            // 
            // comboBoxStore
            // 
            comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxStore.FormattingEnabled = true;
            comboBoxStore.Location = new System.Drawing.Point(84, 56);
            comboBoxStore.Name = "comboBoxStore";
            comboBoxStore.Size = new System.Drawing.Size(320, 28);
            comboBoxStore.TabIndex = 7;
            comboBoxStore.SelectedIndexChanged += comboBoxStore_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(428, 188);
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
            label4.Location = new System.Drawing.Point(423, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 20);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(419, 56);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(15, 20);
            label3.TabIndex = 6;
            label3.Text = "*";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(83, 254);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(321, 241);
            textBoxDescription.TabIndex = 4;
            textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new System.Drawing.Point(84, 188);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new System.Drawing.Size(321, 26);
            textBoxFullName.TabIndex = 4;
            textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxFullName.TextChanged += textBoxFullName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(435, 266);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 20);
            label7.TabIndex = 2;
            label7.Text = "الوصف:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(449, 188);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 20);
            label5.TabIndex = 2;
            label5.Text = "الاسم:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new System.Drawing.Point(84, 122);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new System.Drawing.Size(321, 26);
            textBoxCode.TabIndex = 4;
            textBoxCode.Text = "1568467461";
            textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(451, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "الكود:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(439, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "المخزن:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxUnit);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxTotalPrice);
            groupBox2.Controls.Add(textBoxPrice);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBoxOutCome);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBoxIncome);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBoxQuantity);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.ForeColor = System.Drawing.Color.Blue;
            groupBox2.Location = new System.Drawing.Point(567, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(539, 514);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "خصائص المادة الاولية";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new System.Drawing.Point(16, 56);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new System.Drawing.Size(331, 28);
            comboBoxUnit.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.ForeColor = System.Drawing.Color.Red;
            label19.Location = new System.Drawing.Point(383, 406);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(15, 20);
            label19.TabIndex = 6;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.Color.Red;
            label18.Location = new System.Drawing.Point(420, 336);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(15, 20);
            label18.TabIndex = 6;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.Red;
            label17.Location = new System.Drawing.Point(419, 266);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(15, 20);
            label17.TabIndex = 6;
            label17.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(419, 196);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(15, 20);
            label8.TabIndex = 6;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(419, 126);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(15, 20);
            label9.TabIndex = 6;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Red;
            label10.Location = new System.Drawing.Point(419, 56);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(15, 20);
            label10.TabIndex = 6;
            label10.Text = "*";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new System.Drawing.Point(16, 406);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new System.Drawing.Size(332, 26);
            textBoxTotalPrice.TabIndex = 4;
            textBoxTotalPrice.Text = "0";
            textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(16, 336);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(332, 26);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.Text = "0";
            textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = System.Drawing.Color.Black;
            label16.Location = new System.Drawing.Point(404, 412);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(80, 20);
            label16.TabIndex = 2;
            label16.Text = "اجمالي السعر:";
            // 
            // textBoxOutCome
            // 
            textBoxOutCome.Enabled = false;
            textBoxOutCome.Location = new System.Drawing.Point(16, 266);
            textBoxOutCome.Name = "textBoxOutCome";
            textBoxOutCome.Size = new System.Drawing.Size(332, 26);
            textBoxOutCome.TabIndex = 4;
            textBoxOutCome.Text = "0";
            textBoxOutCome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxOutCome.TextChanged += textBoxOutCome_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = System.Drawing.Color.Black;
            label15.Location = new System.Drawing.Point(441, 336);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(43, 20);
            label15.TabIndex = 2;
            label15.Text = "السعر:";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Enabled = false;
            textBoxIncome.Location = new System.Drawing.Point(16, 196);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new System.Drawing.Size(332, 26);
            textBoxIncome.TabIndex = 4;
            textBoxIncome.Text = "0";
            textBoxIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxIncome.TextChanged += textBoxIncome_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(439, 266);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(45, 20);
            label11.TabIndex = 2;
            label11.Text = "إخراج:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(442, 196);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 20);
            label12.TabIndex = 2;
            label12.Text = "إدخال:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(16, 126);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(332, 26);
            textBoxQuantity.TabIndex = 4;
            textBoxQuantity.Text = "0";
            textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(446, 122);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(38, 20);
            label13.TabIndex = 2;
            label13.Text = "الكمية";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.Color.Black;
            label14.Location = new System.Drawing.Point(439, 53);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(45, 20);
            label14.TabIndex = 2;
            label14.Text = "الوحدة:";
            // 
            // MaterailsAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1118, 628);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MaterailsAddForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة مادة";
            TopMost = true;
            Load += MaterailsAddForm_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabelCodeGenerator;
        private System.Windows.Forms.LinkLabel linkLabelAddStore;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOutCome;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}