using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_5
{
    public partial class FormXoa : Form
    {
        public FormXoa()
        {
            InitializeComponent();
        }

        private void FormXoa_Load(object sender, EventArgs e)
        {
            // Thực hiện các thao tác cần thiết khi form được load (nếu có)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = textBoxXoaMaSV.Text.Trim(); // Lấy mã sinh viên từ textbox

                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên.");
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Kết nối cơ sở dữ liệu và thực hiện xóa
                    using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=student_c#;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "DELETE FROM Students WHERE Id = @Id"; // Thay đổi theo tên trường trong cơ sở dữ liệu

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", maSV);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                            }
                        }
                    }

                    // Đóng form xóa sau khi hoàn tất
                    this.DialogResult = DialogResult.OK; // Trả về kết quả OK cho form chính
                    this.Close(); // Đóng form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
