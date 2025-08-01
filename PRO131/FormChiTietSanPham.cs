using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PRO131.DataContext;

namespace PRO131
{
    public partial class FormChiTietSanPham : Form
    {
        private readonly DuAn1Context _context = new DuAn1Context();
        private string _maSp;

        public FormChiTietSanPham(string maSp)
        {
            InitializeComponent();
            _maSp = maSp;
            LoadThongTinSanPham();
        }

        private void LoadThongTinSanPham()
        {
            var sp = _context.SanPhams
                .Include(s => s.MaLoaiNavigation)
                .Include(s => s.MaHangSxNavigation)
                .FirstOrDefault(s => s.MaSp.ToString() == _maSp);

            var spct = _context.SanPhamChiTiets
                .Include(ct => ct.MaSizeNavigation)
                .FirstOrDefault(ct => ct.MaSp.ToString() == _maSp);

            if (sp != null)
            {
                txtTenSP.Text = sp.TenSanPham;
                cboHang.Text = sp.MaHangSxNavigation?.TenHangSanXuat ?? "";
                cboLoai.Text = sp.MaLoaiNavigation?.TenLoai ?? "";
            }

            if (spct != null)
            {
                txtGiaNhap.Text = spct.GiaNhap.ToString("N0");
                txtGiaBan.Text = spct.GiaBan.ToString("N0");
                txtSize.Text = spct.MaSizeNavigation?.KichThuoc ?? "";
                numericUpDownSoLuong.Value = spct.SoLuong;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
