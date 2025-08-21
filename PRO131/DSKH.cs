using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRO131
{
    public partial class DSKH : UserControl
    {
        private string connectionString =
      @"Server=DESKTOP-9MI2RPM;Database=DuAn_1;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";


        public DSKH()
        {
            InitializeComponent();
            LoadData(); // Load toàn bộ KH ban đầu

            // Gán sự kiện tìm kiếm realtime
            textBox_TK2.TextChanged += TxtSearch_TextChanged;

            // Sự kiện click DataGridView
            dataGridView2.CellClick += DataGridView2_CellClick;
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

                // Thêm cột hiển thị trạng thái dạng chữ
                if (!dt.Columns.Contains("TrangThaiText"))
                    dt.Columns.Add("TrangThaiText", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int trangThai = Convert.ToInt32(row["TrangThai"]);
                    row["TrangThaiText"] = trangThai == 1 ? "Thường xuyên" : "Không thường xuyên";
                }

                dataGridView2.DataSource = dt;

                // Ẩn cột gốc
                if (dataGridView2.Columns.Contains("TrangThai"))
                    dataGridView2.Columns["TrangThai"].Visible = false;

                // Đặt tiêu đề cột
                RenameColumn(dataGridView2, "MaKH", "Mã khách hàng");
                RenameColumn(dataGridView2, "TenKhachHang", "Tên khách hàng");
                RenameColumn(dataGridView2, "GioiTinh", "Giới tính");
                RenameColumn(dataGridView2, "DiaChi", "Địa chỉ");
                RenameColumn(dataGridView2, "SoDienThoai", "Số điện thoại");
                RenameColumn(dataGridView2, "TrangThaiText", "Trạng thái");
            }
        }

        private void RenameColumn(DataGridView dgv, string columnName, string headerText)
        {
            if (dgv.Columns.Contains(columnName))
                dgv.Columns[columnName].HeaderText = headerText;
        }

        // Tìm kiếm realtime
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_TK2.Text.Trim();

            // Validate từ khóa tìm kiếm
            if (!IsValidKeyword(keyword))
            {
                MessageBox.Show("Từ khóa tìm kiếm chỉ được chứa chữ, số và khoảng trắng.");
                return;
            }

            LoadData(keyword);
        }

        private bool IsValidKeyword(string keyword)
        {
            // Cho phép chữ, số, khoảng trắng
            return Regex.IsMatch(keyword, @"^[\w\s]*$");
        }

        // Xử lý click DataGridView
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView2.Rows.Count)
                return;

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            // Validate dữ liệu trước khi hiển thị chi tiết
            if (row.Cells["MaKH"].Value == null || row.Cells["TenKhachHang"].Value == null)
            {
                MessageBox.Show("Dữ liệu khách hàng không hợp lệ.");
                return;
            }

            // Ví dụ hiển thị chi tiết vào TextBox (nếu có)
            string maKH = row.Cells["MaKH"].Value.ToString();
            string tenKH = row.Cells["TenKhachHang"].Value.ToString();
            string sdt = row.Cells["SoDienThoai"].Value.ToString();

            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại của khách hàng không hợp lệ.");
                return;
            }

            // Bạn có thể gán giá trị vào các TextBox hiển thị chi tiết
            // textBox_MaKH.Text = maKH;
            // textBox_TenKH.Text = tenKH;
            // textBox_SDT.Text = sdt;
        }
    }
}
