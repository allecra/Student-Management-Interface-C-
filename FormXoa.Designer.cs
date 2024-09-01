namespace CHUONG_5
{
    partial class FormXoa
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
            this.textBoxXoaMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxXoaMaSV
            // 
            this.textBoxXoaMaSV.Location = new System.Drawing.Point(266, 57);
            this.textBoxXoaMaSV.Name = "textBoxXoaMaSV";
            this.textBoxXoaMaSV.Size = new System.Drawing.Size(190, 22);
            this.textBoxXoaMaSV.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập Mã Sinh Viên Để Xóa:";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(166, 117);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(186, 32);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa Sinh Viên";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHUONG_5.Properties.Resources._0306d9708592d1b0c4f05c4af14962cf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 177);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxXoaMaSV);
            this.Name = "FormXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Sinh Viên";
            this.Load += new System.EventHandler(this.FormXoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXoaMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXoa;
    }
}