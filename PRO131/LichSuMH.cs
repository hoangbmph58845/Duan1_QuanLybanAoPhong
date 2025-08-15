using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class LichSuMH : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();

        public LichSuMH()
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

            dataGridView_LSMH.DataSource = list;

            dataGridView_LSMH.Columns["MaHd"].HeaderText = "Mã Hóa Đơn";
            dataGridView_LSMH.Columns["MaKh"].HeaderText = "Mã Khách Hàng";
            dataGridView_LSMH.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
            dataGridView_LSMH.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dataGridView_LSMH.Columns["PhuongThucThanhToan"].HeaderText = "Phương Thức Thanh Toán";
            dataGridView_LSMH.Columns["TongTien"].HeaderText = "Tổng Tiền";

            dataGridView_LSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Nếu bạn muốn gọi load theo khách hàng nào đó
        public void LoadDataByCustomer(int MaKH)
        {
            LoadData(MaKH);
        }
    }
}

