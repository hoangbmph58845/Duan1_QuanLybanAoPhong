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
    public partial class DanhSachHoaDon : UserControl
    {
        private readonly DuAn1Context _context = new DuAn1Context();
        public DanhSachHoaDon()
        {
            InitializeComponent();
            LoadDanhSachHoaDon();
        }
        private void LoadDanhSachHoaDon()
        {

            var danhSach = _context.HoaDons
                .Include(hd => hd.MaKhNavigation)
                .Include(hd => hd.MaNvNavigation)
                .Select(hd => new
                {
                    MaHD = hd.MaHd,
                    MaKh = hd.MaKh,
                    TenNV = hd.MaNvNavigation.TenNhanVien,
                    NGAYBAN = hd.NgayBan,
                    PHUONGTHUCTHANHTOAN = hd.PhuongThucThanhToan,
                    TONGTIEN = hd.TongTien,
                    TRANGTHAI = hd.TrangThai ? "Đã thanh toán" : "Chưa thanh toán",

                })
                .ToList();


            dataGridView1.DataSource = danhSach;
            dataGridView1.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["MaKh"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["NGAYBAN"].HeaderText = "Ngày bán";
            dataGridView1.Columns["PHUONGTHUCTHANHTOAN"].HeaderText = "Phương thức thanh toán";
            dataGridView1.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
            dataGridView1.Columns["TRANGTHAI"].HeaderText = "trạng thái";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private int _maHoaDonDangChon = -1;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int maHD;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn.");
                return;
            }
            if (!int.TryParse(textBox1.Text.Trim(), out maHD) || maHD <= 0)
            {
                MessageBox.Show("Mã hóa đơn phải là số nguyên dương.");
                return;
            }
            var ketQua = _context.HoaDons
                .Include(hd => hd.MaKhNavigation)
                .Include(hd => hd.MaNvNavigation)
                .Where(hd => hd.MaHd == maHD)
                .AsEnumerable()
                .Select(hd => new
                {
                    MaHD = hd.MaHd,
                    MaKh = hd.MaKh,
                    TenNV = hd.MaNvNavigation.TenNhanVien,
                    NGAYBAN = hd.NgayBan,
                    PHUONGTHUCTHANHTOAN = hd.PhuongThucThanhToan,
                    TONGTIEN = hd.TongTien,
                    TRANGTHAI = hd.TrangThai ? "Đã thanh toán" : "Chưa thanh toán",
                })
                .ToList();
            if (ketQua == null || ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn với Mã HD: " + maHD);
                return;
            }
            dataGridView1.DataSource = ketQua;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_maHoaDonDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn từ bảng để sửa!");
                return;
            }

            var hoaDon = _context.HoaDons.FirstOrDefault(hd => hd.MaHd == _maHoaDonDangChon);

            if (hoaDon != null)
            {
                hoaDon.TrangThai = comboBox1.SelectedItem.ToString().Trim() == "Đã thanh toán";

                _context.SaveChanges();

                MessageBox.Show("Cập nhật trạng thái thành công!");


                button1.PerformClick();
            }
            LoadDanhSachHoaDon();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["MaHD"].Value.ToString();
                _maHoaDonDangChon = Convert.ToInt32(row.Cells["MaHD"].Value);
                string trangThai = row.Cells["TRANGTHAI"].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(trangThai);

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }
    }
}
