using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_5
{
    public partial class FormQLSV : Form
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=student_c#;Integrated Security=True");

        public FormQLSV()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            string sql = "SELECT * FROM Students"; // Lấy tất cả dữ liệu từ bảng Students
            DataTable dt = ExecuteQuery(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt; // Đổ dữ liệu vào DataGridView
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private DataTable ExecuteQuery(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }

        private void FormQLSV_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemSV them = new FormThemSV();
            this.Hide();
            them.ShowDialog();
            this.Show();
            ketnoicsdl(); // Refresh data after closing the form
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuaSV sua = new FormSuaSV();
            this.Hide();
            sua.ShowDialog();
            this.Show();
            ketnoicsdl(); // Refresh data after closing the form
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXoa xoa = new FormXoa();
            this.Hide();
            xoa.ShowDialog();
            this.Show();
            ketnoicsdl(); // Refresh data after closing the form
        }

        private void sắpXếpTheoGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students ORDER BY AverageScore DESC";
            DataTable sortedData = ExecuteQuery(query);
            if (sortedData != null)
            {
                dataGridView1.DataSource = sortedData;
            }
        }

        private void sắpXếpTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students ORDER BY NameSV ASC";
            DataTable sortedData = ExecuteQuery(query);
            if (sortedData != null)
            {
                dataGridView1.DataSource = sortedData;
            }
        }

        private void sắpXếpTheoIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students ORDER BY Id ASC";
            DataTable sortedData = ExecuteQuery(query);
            if (sortedData != null)
            {
                dataGridView1.DataSource = sortedData;
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string ten = textBoxTimKIem.Text; // Lấy giá trị tìm kiếm từ textbox
            string query = $"SELECT * FROM Students WHERE NameSV LIKE N'%{ten}%'";
            DataTable dataTable = ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        private void textBoxTimKIem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
