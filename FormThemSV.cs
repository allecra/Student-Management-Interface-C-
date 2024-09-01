using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_5
{
    public partial class FormThemSV : Form
    {
        public FormThemSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = textBoxTenSV.Text.Trim();
                string gioiTinh = comboBoxGioiTinh.SelectedItem?.ToString(); // Kiểm tra nếu có giá trị
                if (string.IsNullOrEmpty(gioiTinh))
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                    return;
                }

                int tuoi;
                if (!int.TryParse(textBoxTuoi.Text, out tuoi))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho tuổi.");
                    return;
                }

                float diemToan, diemLy, diemHoa;
                if (!float.TryParse(textBoxToan.Text, out diemToan) ||
                    !float.TryParse(textBoxLy.Text, out diemLy) ||
                    !float.TryParse(textBoxHoa.Text, out diemHoa))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho điểm số.");
                    return;
                }

                // Tính điểm trung bình
                float averageScore = (diemToan + diemLy + diemHoa) / 3;

                // Xếp loại
                string academicPerformance = GetAcademicPerformance(averageScore);

                // Kết nối cơ sở dữ liệu và thực hiện thêm
                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=student_c#;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (NameSV, Gender, Age, MathScore, PhysicsScore, ChemistryScore, AverageScore, AcademicPerformance) " +
                                   "VALUES (@NameSV, @Gender, @Age, @MathScore, @PhysicsScore, @ChemistryScore, @AverageScore, @AcademicPerformance)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NameSV", ten);
                        command.Parameters.AddWithValue("@Gender", gioiTinh);
                        command.Parameters.AddWithValue("@Age", tuoi);
                        command.Parameters.AddWithValue("@MathScore", diemToan);
                        command.Parameters.AddWithValue("@PhysicsScore", diemLy);
                        command.Parameters.AddWithValue("@ChemistryScore", diemHoa);
                        command.Parameters.AddWithValue("@AverageScore", averageScore);
                        command.Parameters.AddWithValue("@AcademicPerformance", academicPerformance);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Lưu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sinh viên.");
                        }
                    }
                }

                // Đóng form thêm sau khi hoàn tất
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK cho form chính
                this.Close(); // Đóng form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string GetAcademicPerformance(float averageScore)
        {
            if (averageScore >= 8)
                return "Giỏi";
            else if (averageScore >= 6.5)
                return "Khá";
            else if (averageScore >= 5)
                return "Trung Bình";
            else
                return "Yếu";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
