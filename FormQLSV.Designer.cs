namespace CHUONG_5
{
    partial class FormQLSV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTimKIem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoGPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTimKIem);
            this.panel1.Controls.Add(this.buttonTimKiem);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 481);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTimKIem
            // 
            this.textBoxTimKIem.Location = new System.Drawing.Point(686, 31);
            this.textBoxTimKIem.Name = "textBoxTimKIem";
            this.textBoxTimKIem.Size = new System.Drawing.Size(184, 22);
            this.textBoxTimKIem.TabIndex = 3;
            this.textBoxTimKIem.Text = "Nhập tên sinh viên....";
            this.textBoxTimKIem.TextChanged += new System.EventHandler(this.textBoxTimKIem_TextChanged);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(545, 31);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(93, 22);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 388);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.danhSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sắpXếpTheoGPAToolStripMenuItem,
            this.sắpXếpTheoTênToolStripMenuItem,
            this.sắpXếpTheoIDToolStripMenuItem});
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.danhSáchToolStripMenuItem.Text = "Danh Sách";
            // 
            // sắpXếpTheoGPAToolStripMenuItem
            // 
            this.sắpXếpTheoGPAToolStripMenuItem.Name = "sắpXếpTheoGPAToolStripMenuItem";
            this.sắpXếpTheoGPAToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.sắpXếpTheoGPAToolStripMenuItem.Text = "Sắp xếp theo GPA";
            this.sắpXếpTheoGPAToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoGPAToolStripMenuItem_Click);
            // 
            // sắpXếpTheoTênToolStripMenuItem
            // 
            this.sắpXếpTheoTênToolStripMenuItem.Name = "sắpXếpTheoTênToolStripMenuItem";
            this.sắpXếpTheoTênToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.sắpXếpTheoTênToolStripMenuItem.Text = "Sắp xếp theo Tên";
            this.sắpXếpTheoTênToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoTênToolStripMenuItem_Click);
            // 
            // sắpXếpTheoIDToolStripMenuItem
            // 
            this.sắpXếpTheoIDToolStripMenuItem.Name = "sắpXếpTheoIDToolStripMenuItem";
            this.sắpXếpTheoIDToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.sắpXếpTheoIDToolStripMenuItem.Text = "Sắp xếp theo ID";
            this.sắpXếpTheoIDToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoIDToolStripMenuItem_Click);
            // 
            // FormQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLSV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.FormQLSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoGPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoIDToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTimKIem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}