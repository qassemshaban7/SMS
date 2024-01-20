﻿
namespace SMSystem.Gui.UserGui
{
    partial class UserAddForm
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
            comboBoxRole = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBoxUserName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
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
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(579, 554);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المستخدم";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "مدير", "مستخدم" });
            comboBoxRole.Location = new System.Drawing.Point(25, 466);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new System.Drawing.Size(522, 28);
            comboBoxRole.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(467, 431);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(15, 20);
            label7.TabIndex = 6;
            label7.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(473, 324);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(15, 20);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(458, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(15, 20);
            label2.TabIndex = 6;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(485, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(15, 20);
            label3.TabIndex = 6;
            label3.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(488, 431);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(59, 20);
            label8.TabIndex = 2;
            label8.Text = "الصلاحية";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(24, 357);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(522, 26);
            textBoxPassword.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(488, 324);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 20);
            label6.TabIndex = 2;
            label6.Text = "كلمة السر";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(24, 231);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(522, 26);
            textBoxUserName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(473, 193);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 20);
            label4.TabIndex = 2;
            label4.Text = "اسم المستخدم";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(24, 104);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(523, 26);
            textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(506, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "الاسم:";
            // 
            // UserAddForm
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
            Name = "UserAddForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة مستخدم";
            TopMost = true;
            FormClosing += UserAddForm_FormClosing;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}