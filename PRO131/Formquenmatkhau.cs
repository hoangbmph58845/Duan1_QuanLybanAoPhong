using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class btnXacNhan : Form
    {
        SqlConnection conn;
        string generatedOtp = "";
        public btnXacNhan()
        {
            InitializeComponent();
            connect();
        }
        public void connect()
        {
            string connectionString = "Data Source=TUAN;Initial Catalog=DuAn_1;User ID=sa;Password=123456;TrustServerCertificate=True";
            conn = new SqlConnection(connectionString);
            conn.Open();

        }
        private void Formquenmatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEnv.Text.Trim();
                string taiKhoan = txtTknv.Text.Trim();
                string newPassword = txtMkm.Text.Trim();

                // Validate đầu vào
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tài khoản + email có tồn tại không
                string queryCheck = @"
                            SELECT COUNT(*) 
                            FROM NhanVien nv
                            INNER JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV
                            WHERE tk.Email = @Email AND tk.TenDangNhap = @TaiKhoan";

                using (SqlCommand cmd = new SqlCommand(queryCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    int count = (int)cmd.ExecuteScalar();

                    if (count != 1)
                    {
                        MessageBox.Show("Email hoặc tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Xác nhận đổi mật khẩu
                var result = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return; // Người dùng chọn No
                }

                // Thực hiện cập nhật mật khẩu
                string queryUpdate = @"
                                UPDATE TaiKhoan
                                SET MatKhau = @MatKhau
                                WHERE Email = @Email AND TenDangNhap = @TaiKhoan";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@MatKhau", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giao diện
                txtEnv.Clear();
                txtTknv.Clear();
                txtMkm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            using (Login logins = new Login())
            {
                logins.ShowDialog(); // Mở form quên mật khẩu dạng modal             
            }
        }

        private void txtEnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void guiMaOTP_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
