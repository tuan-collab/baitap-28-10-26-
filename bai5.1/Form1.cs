using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Bai4._1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlytaikhoan;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            SetupFormDefaults();
        }

        private void SetupFormDefaults()
        {
            // 1. Phím Enter kích hoạt btnLogin, phím Esc kích hoạt btnExit
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;

            // 2. Mặc định ẩn mật khẩu (*)
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.Checked = false;
        }

        // --- Xử lý sự kiện CheckBox Ẩn / Hiện mật khẩu ---
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // --- Hàm kiểm tra dữ liệu đầu vào (Validation) ---
        private bool ValidateInputs()
        {
            bool isValid = true;

            // Xóa sạch thông báo lỗi cũ
            errorProvider1.Clear();

            // Kiểm tra trống Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                errorProvider1.SetError(txtLogin, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }

            // Kiểm tra trống Mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }

            return isValid;
        }

        // --- Sự kiện click nút Đăng nhập (Đã kết nối SQL Server) ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Có lỗi trống thông tin thì dừng lại
            }

            string user = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Lấy Họ tên từ bảng Taikhoan theo Username và Passw
                    // Cập nhật câu lệnh query trong hàm btnLogin_Click:
                    string query = "SELECT hoten FROM Taikhoan WHERE RTRIM(Username) = @user AND RTRIM(Passw) = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        object result = cmd.ExecuteScalar(); // Trả về họ tên nếu khớp tài khoản

                        if (result != null)
                        {
                            string hoTen = result.ToString();
                            MessageBox.Show($"Đăng nhập thành công!\nXin chào: {hoTen}", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi kết nối",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // --- Sự kiện click nút Thoát ---
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // --- Các hàm hướng sự kiện bị lặp từ Designer về hàm chính ---
        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            chkShowPassword_CheckedChanged(sender, e);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
    }
}