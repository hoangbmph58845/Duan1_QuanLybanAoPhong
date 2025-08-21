using PRO131.DataContext;
using PRO131.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRO131
{
    public partial class DSKH : UserControl
    {
        private readonly DuAn1Context _context;

        public DSKH()
        {
            InitializeComponent();
            _context = new DuAn1Context();

            // Cấu hình DataGridView
            dataGridView2.ScrollBars = ScrollBars.Vertical; // Hiển thị thanh trượt dọc
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự giãn vừa khít
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả hàng
            dataGridView2.MultiSelect = false; // Chỉ chọn 1 hàng
            dataGridView2.AllowUserToAddRows = false; // Không thêm dòng thủ công
            dataGridView2.RowHeadersVisible = false; // Ẩn header dòng nếu muốn

            LoadData(); // Load toàn bộ KH ban đầu

            // Gán sự kiện tìm kiếm realtime
            textBox_TK2.TextChanged += TxtSearch_TextChanged;

            // Sự kiện click DataGridView
            dataGridView2.CellClick += DataGridView2_CellClick;
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                var khList = _context.KhachHangs.AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    khList = khList.Where(k =>
                        k.TenKhachHang.Contains(keyword) ||
                        k.SoDienThoai.Contains(keyword));
                }

                var dt = khList
                    .Select(k => new
                    {
                        k.MaKh,
                        k.TenKhachHang,
                        k.GioiTinh,
                        k.DiaChi,
                        k.SoDienThoai,
                        k.TrangThai,
                        TrangThaiText = k.TrangThai ? "Thường xuyên" : "Không thường xuyên"
                    })
                    .ToList();

                dataGridView2.DataSource = dt;

                // Đặt tiêu đề cột
                RenameColumn(dataGridView2, "MaKh", "Mã khách hàng");
                RenameColumn(dataGridView2, "TenKhachHang", "Tên khách hàng");
                RenameColumn(dataGridView2, "GioiTinh", "Giới tính");
                RenameColumn(dataGridView2, "DiaChi", "Địa chỉ");
                RenameColumn(dataGridView2, "SoDienThoai", "Số điện thoại");
                RenameColumn(dataGridView2, "TrangThaiText", "Trạng thái");

                // Ẩn cột gốc
                if (dataGridView2.Columns.Contains("TrangThai"))
                    dataGridView2.Columns["TrangThai"].Visible = false;

                // Tự cuộn về đầu khi load
                if (dataGridView2.Rows.Count > 0)
                    dataGridView2.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void RenameColumn(DataGridView dgv, string columnName, string headerText)
        {
            if (dgv.Columns.Contains(columnName))
                dgv.Columns[columnName].HeaderText = headerText;
        }

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

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView2.Rows.Count)
                return;

            var row = dataGridView2.Rows[e.RowIndex];

            if (row.Cells["MaKh"].Value == null || row.Cells["TenKhachHang"].Value == null)
            {
                MessageBox.Show("Dữ liệu khách hàng không hợp lệ.");
                return;
            }

            // Ví dụ hiển thị chi tiết vào TextBox (nếu có)
            string maKH = row.Cells["MaKh"].Value.ToString();
            string tenKH = row.Cells["TenKhachHang"].Value.ToString();
            string sdt = row.Cells["SoDienThoai"].Value.ToString();

            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại của khách hàng không hợp lệ.");
                return;
            }

            // Gán giá trị vào TextBox nếu cần
            // textBox_MaKH.Text = maKH;
            // textBox_TenKH.Text = tenKH;
            // textBox_SDT.Text = sdt;
        }
    }
}
