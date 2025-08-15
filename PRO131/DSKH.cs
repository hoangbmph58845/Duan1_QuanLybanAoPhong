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
    public partial class DSKH : UserControl
    {
        // Chuỗi kết nối tới SQL Server
        private string connectionString =
      @"Server=DESKTOP-9MI2RPM;Database=DuAn_1;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";


        public DSKH()
        {
            InitializeComponent();
            LoadData(); // Load toàn bộ KH ban đầu

            // Gán sự kiện tìm kiếm realtime
            textBox_tk2.TextChanged += TxtSearch_TextChanged;
        }

        private void LoadData(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT MaKH, TenKhachHang, GioiTinh, DiaChi, SoDienThoai, TrangThai

                    FROM KhachHang
                    WHERE TenKhachHang LIKE @keyword OR SoDienThoai LIKE @keyword
                ";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox_tk2.Text.Trim());
        }
    }
}
