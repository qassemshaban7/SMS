
namespace SMSystem.Gui.Home
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            buttonAddMaterial = new System.Windows.Forms.Button();
            buttonAddIncome = new System.Windows.Forms.Button();
            buttonAddOutCome = new System.Windows.Forms.Button();
            labelWellcom = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            labelTime = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            labelCompanyName = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            FlowLayoutPanelNotification = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonAddMaterial
            // 
            buttonAddMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddMaterial.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            buttonAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddMaterial.Image = (System.Drawing.Image)resources.GetObject("buttonAddMaterial.Image");
            buttonAddMaterial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddMaterial.Location = new System.Drawing.Point(683, 367);
            buttonAddMaterial.Margin = new System.Windows.Forms.Padding(4);
            buttonAddMaterial.Name = "buttonAddMaterial";
            buttonAddMaterial.Size = new System.Drawing.Size(167, 83);
            buttonAddMaterial.TabIndex = 5;
            buttonAddMaterial.Text = "اضافة مادة";
            buttonAddMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddMaterial.UseVisualStyleBackColor = false;
            buttonAddMaterial.Click += buttonAddMaterial_Click;
            // 
            // buttonAddIncome
            // 
            buttonAddIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddIncome.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            buttonAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddIncome.Image = (System.Drawing.Image)resources.GetObject("buttonAddIncome.Image");
            buttonAddIncome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddIncome.Location = new System.Drawing.Point(494, 367);
            buttonAddIncome.Margin = new System.Windows.Forms.Padding(4);
            buttonAddIncome.Name = "buttonAddIncome";
            buttonAddIncome.Size = new System.Drawing.Size(166, 83);
            buttonAddIncome.TabIndex = 6;
            buttonAddIncome.Text = "ادخال مادة";
            buttonAddIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddIncome.UseVisualStyleBackColor = false;
            buttonAddIncome.Click += buttonAddIncome_Click;
            // 
            // buttonAddOutCome
            // 
            buttonAddOutCome.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddOutCome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddOutCome.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            buttonAddOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddOutCome.Image = (System.Drawing.Image)resources.GetObject("buttonAddOutCome.Image");
            buttonAddOutCome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddOutCome.Location = new System.Drawing.Point(307, 367);
            buttonAddOutCome.Margin = new System.Windows.Forms.Padding(4);
            buttonAddOutCome.Name = "buttonAddOutCome";
            buttonAddOutCome.Size = new System.Drawing.Size(157, 83);
            buttonAddOutCome.TabIndex = 7;
            buttonAddOutCome.Text = "اخراج مادة";
            buttonAddOutCome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddOutCome.UseVisualStyleBackColor = false;
            buttonAddOutCome.Click += buttonAddOutCome_Click;
            // 
            // labelWellcom
            // 
            labelWellcom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelWellcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelWellcom.Location = new System.Drawing.Point(778, 258);
            labelWellcom.Name = "labelWellcom";
            labelWellcom.Size = new System.Drawing.Size(319, 93);
            labelWellcom.TabIndex = 8;
            labelWellcom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            labelWellcom.Click += labelWellcom_Click;
            // 
            // labelDate
            // 
            labelDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDate.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            labelDate.Location = new System.Drawing.Point(3, 436);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(151, 29);
            labelDate.TabIndex = 8;
            labelDate.Text = "000000000";
            labelDate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            labelDate.Click += labelDate_Click;
            // 
            // labelTime
            // 
            labelTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTime.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelTime.Location = new System.Drawing.Point(3, 465);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(151, 33);
            labelTime.TabIndex = 8;
            labelTime.Text = "000000000";
            labelTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            labelTime.Click += labelTime_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(pictureBoxCompanyLogo);
            panel1.Controls.Add(labelCompanyName);
            panel1.Location = new System.Drawing.Point(586, 11);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(511, 94);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxCompanyLogo
            // 
            pictureBoxCompanyLogo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pictureBoxCompanyLogo.Image = (System.Drawing.Image)resources.GetObject("pictureBoxCompanyLogo.Image");
            pictureBoxCompanyLogo.Location = new System.Drawing.Point(379, 2);
            pictureBoxCompanyLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            pictureBoxCompanyLogo.Size = new System.Drawing.Size(129, 89);
            pictureBoxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxCompanyLogo.TabIndex = 0;
            pictureBoxCompanyLogo.TabStop = false;
            pictureBoxCompanyLogo.Click += pictureBoxCompanyLogo_Click;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(13, 13);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(360, 60);
            labelCompanyName.TabIndex = 8;
            labelCompanyName.Text = "مخازن كلية الحاسبات والذكاء الاصطناعي";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelCompanyName.Click += labelCompanyName_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // FlowLayoutPanelNotification
            // 
            FlowLayoutPanelNotification.AutoScroll = true;
            FlowLayoutPanelNotification.BackColor = System.Drawing.Color.White;
            FlowLayoutPanelNotification.ForeColor = System.Drawing.Color.Black;
            FlowLayoutPanelNotification.Location = new System.Drawing.Point(20, 104);
            FlowLayoutPanelNotification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            FlowLayoutPanelNotification.Name = "FlowLayoutPanelNotification";
            FlowLayoutPanelNotification.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            FlowLayoutPanelNotification.Size = new System.Drawing.Size(531, 129);
            FlowLayoutPanelNotification.TabIndex = 10;
            FlowLayoutPanelNotification.Paint += FlowLayoutPanelNotification_Paint;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            Controls.Add(FlowLayoutPanelNotification);
            Controls.Add(labelWellcom);
            Controls.Add(labelDate);
            Controls.Add(panel1);
            Controls.Add(labelTime);
            Controls.Add(buttonAddMaterial);
            Controls.Add(buttonAddIncome);
            Controls.Add(buttonAddOutCome);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "HomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1140, 519);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAddIncome;
        private System.Windows.Forms.Button buttonAddOutCome;
        private System.Windows.Forms.Label labelWellcom;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNotification;
    }
}
