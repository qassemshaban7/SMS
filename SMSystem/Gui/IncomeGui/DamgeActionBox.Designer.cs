
namespace SMSystem.Gui.IncomeGui
{
    partial class DamgeActionBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamgeActionBox));
            buttonOk = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Image = Properties.Resources.icons8_damaged_parcel_32px_1;
            buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOk.Location = new System.Drawing.Point(261, 164);
            buttonOk.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(192, 59);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "تأكيد";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonDelete_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(73, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(348, 29);
            textBox1.TabIndex = 4;
            textBox1.Text = "1";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(18, 164);
            button1.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(192, 59);
            button1.TabIndex = 3;
            button1.Text = "الغاء الامر";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(19, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(459, 82);
            label1.TabIndex = 5;
            label1.Text = "كمية المادة التي تود نقلها\r\n ( في حال اختيارك كامل الكمية يتم حذفها من المواد الداخلة)";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DamgeActionBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(497, 251);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(buttonOk);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DamgeActionBox";
            Padding = new System.Windows.Forms.Padding(16, 26, 16, 26);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DamgeActionBox";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
