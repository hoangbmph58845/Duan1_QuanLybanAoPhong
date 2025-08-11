using PRO131.DataContext;
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
    public partial class DanhsachKH : UserControl
    {
        private string? keyword;

        public DanhsachKH()
        {
            InitializeComponent();
            LoadDanhSachKH();
        }

        // Load danh sách khách hàng (không filter)
        private void LoadDanhSachKH()
        {
            using (var db = new DuAn1Context())
            {
                var query = db.KhachHangs.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(kh => kh.TenKhachHang.Contains(keyword)
                                           || kh.MaKh.ToString().Contains(keyword));
                }

                dataGridView2.DataSource = query
                    .Select(kh => new
                    {
                        kh.MaKh,
                        kh.TenKhachHang,
                        kh.GioiTinh,
                        kh.DiaChi,
                        kh.SoDienThoai,
                        TrangThai = kh.TrangThai == true ? "Hoạt động" : "Ngừng"
                    })
                    .ToList();
            }
        }

        // Overload để tìm kiếm theo keyword
        private void LoadDanhSachKH(string tuKhoa)
        {
            keyword = tuKhoa;
            LoadDanhSachKH();
        }

        // Click nút tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachKH(textBox_TK.Text.Trim());
        }

        // Click nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Nếu là UserControl nằm trong Form cha thì đóng Form cha
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        // Khi click vào 1 dòng trong DataGridView
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView2.Rows[e.RowIndex].Cells["MaKh"] != null)
            {
                string maKh = dataGridView2.Rows[e.RowIndex].Cells["MaKh"].Value?.ToString();
                MessageBox.Show("Bạn đã chọn khách hàng: " + maKh, "Thông báo");
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
