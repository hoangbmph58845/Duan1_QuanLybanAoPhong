using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class Formquenmatkhau : Form
    {
        public Formquenmatkhau()
        {
            InitializeComponent();
        }

        private void Formquenmatkhau_Load(object sender, EventArgs e)
        {
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // 1. Kiểm tra email rỗng
            if (string.IsNullOrEmpty(email))
            {
                lblKetQua.Text = "⚠ Bạn chưa nhập email.";
                lblKetQua.ForeColor = Color.Yellow;
                return;
            }

            // 2. Chuỗi kết nối mới
            string connectionString = @"Data Source=DESKTOP-9MI2RPM;Initial Catalog=DuAn_1;;TrustServerCertificate=True";

            // 3. Tạo và mở kết nối
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 4. Truy vấn kiểm tra email
                string query = "SELECT MatKhau FROM TaiKhoan WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                object result = cmd.ExecuteScalar();

                // 5. Xử lý kết quả
                if (result != null)
                {
                    lblKetQua.Text = $"✅ Mật khẩu của bạn là: {result}";
                    lblKetQua.ForeColor = Color.LightGreen;
                }
                else
                {
                    lblKetQua.Text = "❌ Email không tồn tại";
                    lblKetQua.ForeColor = Color.Red;
                }
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
    }
}
