using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Thư viện kết nối SQL Server

namespace Bai4._2
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối tới SQL Server của máy bạn
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDangKy;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Đặt định dạng MaskedTextBox SĐT
            mtxtPhone.Mask = "(000) 000-0000";

            // 2. Đặt định dạng DateTimePicker hiển thị dd/MM/yyyy
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // 3. Nạp danh sách khóa học từ SQL Server vào ComboBox
            LoadCoursesFromDatabase();
        }

        // --- Nạp dữ liệu vào ComboBox bằng Binding Data ---
        private void LoadCoursesFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CourseID, CourseName FROM KhoaHoc";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán nguồn dữ liệu và thiết lập DisplayMember, ValueMember
                    cboCourse.DataSource = dt;
                    cboCourse.DisplayMember = "CourseName"; // Cột hiển thị tên khóa học
                    cboCourse.ValueMember = "CourseID";     // Cột mã khóa học ẩn bên dưới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nạp danh sách khóa học: " + ex.Message,
                                    "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Sự kiện click nút "Đăng ký" ---
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Lấy thông tin Giới tính từ RadioButton
            string gender = rdoMale.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "Chưa chọn");

            // Lấy danh sách Kỹ năng từ các CheckBox
            List<string> selectedSkills = new List<string>();
            if (tienganh.Checked) selectedSkills.Add(tienganh.Text);
            if (laptrinh.Checked) selectedSkills.Add(laptrinh.Text);
            if (thietke.Checked) selectedSkills.Add(thietke.Text);

            string skillsText = selectedSkills.Count > 0
                ? string.Join(", ", selectedSkills)
                : "Không chọn";

            // Lấy các thông tin còn lại
            string courseName = cboCourse.Text;
            string courseId = cboCourse.SelectedValue?.ToString() ?? "";
            string birthDateStr = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string phone = mtxtPhone.Text;

            // 1. Thêm dữ liệu vào SQL Server
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO DangKyHocVien (Phone, BirthDate, Gender, CourseID, Skills)
                                           VALUES (@Phone, @BirthDate, @Gender, @CourseID, @Skills)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@CourseID", courseId);
                        cmd.Parameters.AddWithValue("@Skills", skillsText);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu thông tin vào SQL Server: " + ex.Message,
                                    "Lỗi lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Nếu lưu thất bại thì ngưng, không hiển thị MessageBox đăng ký thành công
                }
            }

            // 2. Tổng hợp và in thông tin lên MessageBox
            string info = $"--- ĐĂNG KÝ THÀNH CÔNG (ĐÃ LƯU DATABASE) ---\n\n" +
                          $"• SĐT: {phone}\n" +
                          $"• Ngày sinh: {birthDateStr}\n" +
                          $"• Giới tính: {gender}\n" +
                          $"• Khóa học: {courseName} (Mã: {courseId})\n" +
                          $"• Kỹ năng: {skillsText}";

            MessageBox.Show(info, "Kết quả đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tienganh_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}