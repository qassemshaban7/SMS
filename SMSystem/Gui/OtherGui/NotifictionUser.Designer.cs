
namespace SMSystem.Gui.OtherGui
{
    partial class NotifictionUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifictionUser));
            timerhide = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelNotifictionCatption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerhide
            // 
            timerhide.Enabled = true;
            timerhide.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Lime;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(310, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(76, 45);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelNotifictionCatption
            // 
            labelNotifictionCatption.BackColor = System.Drawing.Color.Lime;
            labelNotifictionCatption.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNotifictionCatption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNotifictionCatption.ForeColor = System.Drawing.Color.Black;
            labelNotifictionCatption.Location = new System.Drawing.Point(0, 0);
            labelNotifictionCatption.Name = "labelNotifictionCatption";
            labelNotifictionCatption.Size = new System.Drawing.Size(310, 45);
            labelNotifictionCatption.TabIndex = 1;
            labelNotifictionCatption.Text = "تمت عملية الاضافة بنجاح";
            labelNotifictionCatption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelNotifictionCatption.Click += labelNotifictionCatption_Click;
            // 
            // NotifictionUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(386, 45);
            Controls.Add(labelNotifictionCatption);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "NotifictionUser";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerhide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNotifictionCatption;
    }
}
