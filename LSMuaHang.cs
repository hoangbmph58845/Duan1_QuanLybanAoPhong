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
    public partial class LSMuaHang : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();

        public LSMuaHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(int? maKhachHang = null)
        {
            // Nếu có mã khách hàng, lọc hóa đơn theo khách hàng đó, nếu không thì lấy tất cả
            var query = _context.HoaDons.AsQueryable();

            if (maKhachHang.HasValue)
            {
                query = query.Where(hd => hd.MaKh == maKhachHang.Value);
            }

            var list = query
                .Select(hd => new
                {
                    hd.MaHd,
                    hd.MaKh,
                    KhachHang = hd.MaKhNavigation.TenKhachHang, // liên kết để lấy tên khách hàng
                    hd.NgayBan,
                    hd.PhuongThucThanhToan,
                    hd.TongTien
                })
                .OrderByDescending(hd => hd.NgayBan)
                .ToList();

            dataGridView3.DataSource = list;

            dataGridView3.Columns["MaHd"].HeaderText = "Mã Hóa Đơn";
            dataGridView3.Columns["MaKh"].HeaderText = "Mã Khách Hàng";
            dataGridView3.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
            dataGridView3.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dataGridView3.Columns["PhuongThucThanhToan"].HeaderText = "Phương Thức Thanh Toán";
            dataGridView3.Columns["TongTien"].HeaderText = "Tổng Tiền";

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Nếu bạn muốn gọi load theo khách hàng nào đó
        public void LoadDataByCustomer(int maKhachHang)
        {
            LoadData(maKhachHang);
        }
    }
}
