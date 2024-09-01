namespace CHUONG_5
{
    partial class FormSuaSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxToan = new System.Windows.Forms.TextBox();
            this.textBoxLy = new System.Windows.Forms.TextBox();
            this.textBoxHoa = new System.Windows.Forms.TextBox();
            this.buttonCapNhatSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(231, 21);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(248, 22);
            this.textBoxMaSV.TabIndex = 8;
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(231, 61);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.Size = new System.Drawing.Size(248, 22);
            this.textBoxTenSV.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giới Tính:";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(231, 106);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(86, 24);
            this.comboBoxGioiTinh.TabIndex = 13;
            this.comboBoxGioiTinh.Text = "Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tuổi:";
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(231, 150);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(86, 22);
            this.textBoxTuoi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nhập Điểm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hóa";
            // 
            // textBoxToan
            // 
            this.textBoxToan.Location = new System.Drawing.Point(62, 277);
            this.textBoxToan.Name = "textBoxToan";
            this.textBoxToan.Size = new System.Drawing.Size(86, 22);
            this.textBoxToan.TabIndex = 20;
            // 
            // textBoxLy
            // 
            this.textBoxLy.Location = new System.Drawing.Point(231, 277);
            this.textBoxLy.Name = "textBoxLy";
            this.textBoxLy.Size = new System.Drawing.Size(86, 22);
            this.textBoxLy.TabIndex = 21;
            // 
            // textBoxHoa
            // 
            this.textBoxHoa.Location = new System.Drawing.Point(396, 277);
            this.textBoxHoa.Name = "textBoxHoa";
            this.textBoxHoa.Size = new System.Drawing.Size(86, 22);
            this.textBoxHoa.TabIndex = 22;
            // 
            // buttonCapNhatSV
            // 
            this.buttonCapNhatSV.Location = new System.Drawing.Point(145, 349);
            this.buttonCapNhatSV.Name = "buttonCapNhatSV";
            this.buttonCapNhatSV.Size = new System.Drawing.Size(258, 32);
            this.buttonCapNhatSV.TabIndex = 23;
            this.buttonCapNhatSV.Text = "Cập Nhật Sinh Viên";
            this.buttonCapNhatSV.UseVisualStyleBackColor = true;
            this.buttonCapNhatSV.Click += new System.EventHandler(this.buttonCapNhatSV_Click);
            // 
            // FormSuaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 413);
            this.Controls.Add(this.buttonCapNhatSV);
            this.Controls.Add(this.textBoxHoa);
            this.Controls.Add(this.textBoxLy);
            this.Controls.Add(this.textBoxToan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTenSV);
            this.Controls.Add(this.textBoxMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuaSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.TextBox textBoxTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxToan;
        private System.Windows.Forms.TextBox textBoxLy;
        private System.Windows.Forms.TextBox textBoxHoa;
        private System.Windows.Forms.Button buttonCapNhatSV;
    }
}