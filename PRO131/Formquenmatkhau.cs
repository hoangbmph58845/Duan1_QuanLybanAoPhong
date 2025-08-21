using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class Formquenmatkhau : Form
    {
        private string connectionString = "Data Source=DESKTOP-9MI2RPM;Initial Catalog=DuAn_1;User ID=sa;Password=123456;TrustServerCertificate=True";

        public Formquenmatkhau()
        {
            InitializeComponent();
            
        }
        
        private void Formquenmatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string taiKhoan = txtTdn.Text.Trim();
                string newPassword = txtMkm.Text.Trim();
                string confirmPassword = txtXacNhanMkm.Text.Trim();

                // ===== Validate =====
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(taiKhoan) ||
                    string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Mật khẩu yếu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ✅ Chỉ cho phép tài khoản có chức vụ Quản lý
                    string queryCheck = @"
                    SELECT COUNT(*) 
                    FROM NhanVien nv
                    INNER JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV
                    INNER JOIN ChucVu cv ON nv.MaCV = cv.MaCV
                    WHERE tk.Email = @Email 
                      AND tk.TenDangNhap = @TaiKhoan
                      AND cv.TenChucVu = N'Quản lý'";  // chỉ quản lý mới được đổi

                    using (SqlCommand cmd = new SqlCommand(queryCheck, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                        int count = (int)cmd.ExecuteScalar();
                        if (count != 1)
                        {
                            MessageBox.Show("Chỉ tài khoản quản lý mới có quyền đổi mật khẩu!", "Từ chối",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    var result = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;

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
                }

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmail.Clear();
                txtTdn.Clear();
                txtMkm.Clear();
                txtXacNhanMkm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
