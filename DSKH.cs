using PRO131.DataContext;
using PRO131.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRO131
{
    public partial class DSKH : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();

        public DSKH()
        {
            InitializeComponent();
            LoadData();
            // Gán sự kiện tìm kiếm cho textbox
            textBox1.TextChanged += TxtSearch_TextChanged;
        }

        private void LoadData(string keyword = "")
        {
            var list = _context.KhachHangs
                .Where(kh => string.IsNullOrEmpty(keyword) || kh.TenKhachHang.Contains(keyword))
                .Select(kh => new
                {
                    kh.MaKh,
                    kh.TenKhachHang,
                    kh.GioiTinh,
                    kh.DiaChi,
                    kh.SoDienThoai,
                    TrangThai = kh.TrangThai ? "Hoạt động" : "Ngừng"
                })
                .ToList();

            dataGridView2.DataSource = list;
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            LoadData(keyword);
        }
    }
}
