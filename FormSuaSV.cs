using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_5
{
    public partial class FormSuaSV : Form
    {
        public FormSuaSV()
        {
            InitializeComponent();
        }

        private void buttonCapNhatSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy Id từ textbox
                int id = int.Parse(textBoxMaSV.Text);
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
                string academicPerformance;
                if (averageScore >= 8)
                    academicPerformance = "Giỏi";
                else if (averageScore >= 6.5)
                    academicPerformance = "Khá";
                else if (averageScore >= 5)
                    academicPerformance = "Trung Bình";
                else
                    academicPerformance = "Yếu";

                // Kết nối cơ sở dữ liệu và thực hiện cập nhật
                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=student_c#;Integrated Security=True"))
                {
                    connection.Open();
                    string query = @"
                                    UPDATE Students 
                                    SET NameSV = @NameSV, Gender = @Gender, Age = @Age, MathScore = @MathScore, 
                                    PhysicsScore = @PhysicsScore, ChemistryScore = @ChemistryScore, 
                                    AverageScore = @AverageScore, AcademicPerformance = @AcademicPerformance 
                                    WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
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
                            MessageBox.Show("Không thể cập nhật sinh viên.");
                        }
                    }
                }

                // Đóng form sau khi hoàn tất
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK cho form chính
                this.Close(); // Đóng form
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
