
namespace SMSystem.Gui.SuppliersGui
{
    partial class SupplierAddForm
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
            textBoxDescriptions = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            textBoxPhone = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBoxLocation = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            flowLayoutPanelNavBar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonSave);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 575);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(605, 75);
            flowLayoutPanelNavBar.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(471, 11);
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
            groupBox1.Controls.Add(textBoxDescriptions);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxLocation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(579, 554);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات العميل";
            // 
            // textBoxDescriptions
            // 
            textBoxDescriptions.Location = new System.Drawing.Point(16, 324);
            textBoxDescriptions.Multiline = true;
            textBoxDescriptions.Name = "textBoxDescriptions";
            textBoxDescriptions.Size = new System.Drawing.Size(389, 224);
            textBoxDescriptions.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(434, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(15, 20);
            label3.TabIndex = 6;
            label3.Text = "*";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(19, 257);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(389, 26);
            textBoxEmail.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(476, 257);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 20);
            label8.TabIndex = 2;
            label8.Text = "الايميل:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new System.Drawing.Point(19, 186);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(389, 26);
            textBoxPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(455, 186);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 20);
            label6.TabIndex = 2;
            label6.Text = "رقم الهاتف:";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new System.Drawing.Point(19, 117);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new System.Drawing.Size(389, 26);
            textBoxLocation.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(473, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "العنوان:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(19, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(389, 26);
            textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(455, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "اسم المورد:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(469, 324);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "الوصف:";
            // 
            // SupplierAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(605, 650);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplierAddForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة مورد";
            TopMost = true;
            flowLayoutPanelNavBar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescriptions;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label4;
    }
}