namespace CHUONG_5
{
    partial class FormThemSV
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.textBoxToan = new System.Windows.Forms.TextBox();
            this.textBoxLy = new System.Windows.Forms.TextBox();
            this.textBoxHoa = new System.Windows.Forms.TextBox();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.buttonThemSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Điểm:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hóa";
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(216, 38);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.Size = new System.Drawing.Size(248, 22);
            this.textBoxTenSV.TabIndex = 7;
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(216, 116);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(86, 22);
            this.textBoxTuoi.TabIndex = 8;
            // 
            // textBoxToan
            // 
            this.textBoxToan.Location = new System.Drawing.Point(36, 238);
            this.textBoxToan.Name = "textBoxToan";
            this.textBoxToan.Size = new System.Drawing.Size(86, 22);
            this.textBoxToan.TabIndex = 9;
            this.textBoxToan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxLy
            // 
            this.textBoxLy.Location = new System.Drawing.Point(226, 238);
            this.textBoxLy.Name = "textBoxLy";
            this.textBoxLy.Size = new System.Drawing.Size(86, 22);
            this.textBoxLy.TabIndex = 10;
            this.textBoxLy.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxHoa
            // 
            this.textBoxHoa.Location = new System.Drawing.Point(407, 238);
            this.textBoxHoa.Name = "textBoxHoa";
            this.textBoxHoa.Size = new System.Drawing.Size(86, 22);
            this.textBoxHoa.TabIndex = 11;
            this.textBoxHoa.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(216, 77);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(86, 24);
            this.comboBoxGioiTinh.TabIndex = 12;
            this.comboBoxGioiTinh.Text = "Nam";
            // 
            // buttonThemSV
            // 
            this.buttonThemSV.Location = new System.Drawing.Point(163, 311);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.Size = new System.Drawing.Size(219, 33);
            this.buttonThemSV.TabIndex = 13;
            this.buttonThemSV.TabStop = false;
            this.buttonThemSV.Text = "Thêm Sinh Viên";
            this.buttonThemSV.UseVisualStyleBackColor = true;
            this.buttonThemSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 374);
            this.Controls.Add(this.buttonThemSV);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.textBoxHoa);
            this.Controls.Add(this.textBoxLy);
            this.Controls.Add(this.textBoxToan);
            this.Controls.Add(this.textBoxTuoi);
            this.Controls.Add(this.textBoxTenSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemSV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTenSV;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.TextBox textBoxToan;
        private System.Windows.Forms.TextBox textBoxLy;
        private System.Windows.Forms.TextBox textBoxHoa;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Button buttonThemSV;
    }
}