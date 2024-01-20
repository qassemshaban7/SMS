
namespace SMSystem.Gui.OtherGui
{
    partial class PrintDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDialogForm));
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonExportExel = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonExportExel);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(492, 174);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonExportExel
            // 
            buttonExportExel.BackColor = System.Drawing.Color.White;
            buttonExportExel.Image = Properties.Resources.icons8_csv_80px_1;
            buttonExportExel.Location = new System.Drawing.Point(10, 10);
            buttonExportExel.Margin = new System.Windows.Forms.Padding(10);
            buttonExportExel.Name = "buttonExportExel";
            buttonExportExel.Size = new System.Drawing.Size(231, 154);
            buttonExportExel.TabIndex = 5;
            buttonExportExel.Text = "تصدير كل البيانات ";
            buttonExportExel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonExportExel.UseVisualStyleBackColor = false;
            buttonExportExel.Click += buttonExportExel_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.White;
            buttonCancel.Image = (System.Drawing.Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new System.Drawing.Point(261, 10);
            buttonCancel.Margin = new System.Windows.Forms.Padding(10);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(92, 70);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "الغاء";
            buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PrintDialogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(358, 167);
            Controls.Add(flowLayoutPanel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "PrintDialogForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            Load += PrintDialogForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonExportExel;
        private System.Windows.Forms.Button buttonCancel;
    }
}