
namespace SMSystem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonhome = new System.Windows.Forms.Button();
            buttonStore = new System.Windows.Forms.Button();
            buttonMaterails = new System.Windows.Forms.Button();
            buttonIncome = new System.Windows.Forms.Button();
            buttonOutCome = new System.Windows.Forms.Button();
            buttonDamage = new System.Windows.Forms.Button();
            buttonOutOfConscneine = new System.Windows.Forms.Button();
            buttonSuppliers = new System.Windows.Forms.Button();
            buttonCustomers = new System.Windows.Forms.Button();
            buttonAnalysis = new System.Windows.Forms.Button();
            buttonUsers = new System.Windows.Forms.Button();
            buttonHelp = new System.Windows.Forms.Button();
            buttonAbout = new System.Windows.Forms.Button();
            panelContainer = new System.Windows.Forms.Panel();
            flowLayoutPanelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonhome);
            flowLayoutPanelNavBar.Controls.Add(buttonStore);
            flowLayoutPanelNavBar.Controls.Add(buttonMaterails);
            flowLayoutPanelNavBar.Controls.Add(buttonIncome);
            flowLayoutPanelNavBar.Controls.Add(buttonOutCome);
            flowLayoutPanelNavBar.Controls.Add(buttonDamage);
            flowLayoutPanelNavBar.Controls.Add(buttonOutOfConscneine);
            flowLayoutPanelNavBar.Controls.Add(buttonSuppliers);
            flowLayoutPanelNavBar.Controls.Add(buttonCustomers);
            flowLayoutPanelNavBar.Controls.Add(buttonAnalysis);
            flowLayoutPanelNavBar.Controls.Add(buttonUsers);
            flowLayoutPanelNavBar.Controls.Add(buttonHelp);
            flowLayoutPanelNavBar.Controls.Add(buttonAbout);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 526);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1062, 147);
            flowLayoutPanelNavBar.TabIndex = 0;
            flowLayoutPanelNavBar.Paint += flowLayoutPanelNavBar_Paint;
            // 
            // buttonhome
            // 
            buttonhome.Image = Properties.Resources.home_32px;
            buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonhome.Location = new System.Drawing.Point(918, 6);
            buttonhome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonhome.Name = "buttonhome";
            buttonhome.Size = new System.Drawing.Size(140, 60);
            buttonhome.TabIndex = 0;
            buttonhome.Text = "الرئيسة";
            buttonhome.UseVisualStyleBackColor = true;
            buttonhome.Click += buttonhome_Click;
            // 
            // buttonStore
            // 
            buttonStore.Image = Properties.Resources.department_store_32px;
            buttonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonStore.Location = new System.Drawing.Point(770, 6);
            buttonStore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new System.Drawing.Size(140, 60);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "المخازن";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += buttonStore_Click;
            // 
            // buttonMaterails
            // 
            buttonMaterails.Image = Properties.Resources.open_box_32px;
            buttonMaterails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonMaterails.Location = new System.Drawing.Point(622, 6);
            buttonMaterails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonMaterails.Name = "buttonMaterails";
            buttonMaterails.Size = new System.Drawing.Size(140, 60);
            buttonMaterails.TabIndex = 2;
            buttonMaterails.Text = "  المواد";
            buttonMaterails.UseVisualStyleBackColor = true;
            buttonMaterails.Click += buttonMaterails_Click;
            // 
            // buttonIncome
            // 
            buttonIncome.Image = Properties.Resources.icons8_internal_32px_1;
            buttonIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonIncome.Location = new System.Drawing.Point(474, 6);
            buttonIncome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonIncome.Name = "buttonIncome";
            buttonIncome.Size = new System.Drawing.Size(140, 60);
            buttonIncome.TabIndex = 9;
            buttonIncome.Text = "  المدخلات";
            buttonIncome.UseVisualStyleBackColor = true;
            buttonIncome.Click += buttonIncome_Click;
            // 
            // buttonOutCome
            // 
            buttonOutCome.Image = Properties.Resources.icons8_external_32px;
            buttonOutCome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOutCome.Location = new System.Drawing.Point(326, 6);
            buttonOutCome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonOutCome.Name = "buttonOutCome";
            buttonOutCome.Size = new System.Drawing.Size(140, 60);
            buttonOutCome.TabIndex = 10;
            buttonOutCome.Text = "  المخرجات";
            buttonOutCome.UseVisualStyleBackColor = true;
            buttonOutCome.Click += buttonOutCome_Click;
            // 
            // buttonDamage
            // 
            buttonDamage.Image = Properties.Resources.icons8_damaged_parcel_32px_1;
            buttonDamage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDamage.Location = new System.Drawing.Point(178, 6);
            buttonDamage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonDamage.Name = "buttonDamage";
            buttonDamage.Size = new System.Drawing.Size(140, 60);
            buttonDamage.TabIndex = 11;
            buttonDamage.Text = "  التالف";
            buttonDamage.UseVisualStyleBackColor = true;
            buttonDamage.Click += buttonDamage_Click;
            // 
            // buttonOutOfConscneine
            // 
            buttonOutOfConscneine.Image = Properties.Resources.icons8_export_32px;
            buttonOutOfConscneine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOutOfConscneine.Location = new System.Drawing.Point(30, 6);
            buttonOutOfConscneine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonOutOfConscneine.Name = "buttonOutOfConscneine";
            buttonOutOfConscneine.Size = new System.Drawing.Size(140, 60);
            buttonOutOfConscneine.TabIndex = 13;
            buttonOutOfConscneine.Text = "   خارج الذمة";
            buttonOutOfConscneine.UseVisualStyleBackColor = true;
            buttonOutOfConscneine.Click += buttonOutOfConscneine_Click;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.supplier_32px;
            buttonSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new System.Drawing.Point(918, 78);
            buttonSuppliers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new System.Drawing.Size(140, 60);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "  الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            buttonSuppliers.Click += buttonSuppliers_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.users_32px;
            buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new System.Drawing.Point(770, 78);
            buttonCustomers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new System.Drawing.Size(140, 60);
            buttonCustomers.TabIndex = 7;
            buttonCustomers.Text = "  العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonAnalysis
            // 
            buttonAnalysis.Image = Properties.Resources.chart_32px;
            buttonAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAnalysis.Location = new System.Drawing.Point(622, 78);
            buttonAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAnalysis.Name = "buttonAnalysis";
            buttonAnalysis.Size = new System.Drawing.Size(140, 60);
            buttonAnalysis.TabIndex = 4;
            buttonAnalysis.Text = "التحليل";
            buttonAnalysis.UseVisualStyleBackColor = true;
            buttonAnalysis.Click += buttonAnalysis_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonUsers.Image = Properties.Resources.icons8_select_users_32px;
            buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonUsers.Location = new System.Drawing.Point(474, 78);
            buttonUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new System.Drawing.Size(140, 60);
            buttonUsers.TabIndex = 12;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.settings_32px;
            buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.Location = new System.Drawing.Point(326, 78);
            buttonHelp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new System.Drawing.Size(140, 60);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "  الاعدادات";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.about_32px;
            buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.Location = new System.Drawing.Point(178, 78);
            buttonAbout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new System.Drawing.Size(140, 60);
            buttonAbout.TabIndex = 6;
            buttonAbout.Text = "حول";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 0);
            panelContainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(1062, 526);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1062, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ادارة المخازن";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonMaterails;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonOutCome;
        private System.Windows.Forms.Button buttonDamage;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonOutOfConscneine;
    }
}

