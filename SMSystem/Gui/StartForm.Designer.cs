
namespace SMSystem.Gui
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            progressBar1 = new System.Windows.Forms.ProgressBar();
            labelstate = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar1.Location = new System.Drawing.Point(75, 395);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(561, 43);
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // labelstate
            // 
            labelstate.BackColor = System.Drawing.Color.Transparent;
            labelstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelstate.ForeColor = System.Drawing.Color.Black;
            labelstate.Location = new System.Drawing.Point(170, 355);
            labelstate.Name = "labelstate";
            labelstate.Size = new System.Drawing.Size(466, 37);
            labelstate.TabIndex = 1;
            labelstate.Text = "البداية ..";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(693, 453);
            Controls.Add(labelstate);
            Controls.Add(progressBar1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartForm";
            Padding = new System.Windows.Forms.Padding(16, 26, 16, 26);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StartForm";
            Load += StartForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelstate;
    }
}
