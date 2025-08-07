using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PRO131
{
    public partial class UCDanhSach : UserControl
    {
        private  DataContext.DuAn1Context _context = new DataContext.DuAn1Context();

        public UCDanhSach()
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            var data = _context.SanPhamChiTiets
                .Include(ct => ct.MaSpNavigation)
                    .ThenInclude(sp => sp.MaLoaiNavigation)
                .Include(ct => ct.MaMauNavigation)
                .Include(ct => ct.MaSizeNavigation)
                .Select(ct => new
                {
                    MaSP = ct.MaSp,
                    TenSanPham = ct.MaSpNavigation.TenSanPham,
                    Loai = ct.MaSpNavigation.MaLoaiNavigation.TenLoai,
                    Mau = ct.MaMauNavigation.TenMau,
                    Size = ct.MaSizeNavigation.KichThuoc,
                    GiaNhap = ct.GiaNhap,
                    GiaBan = ct.GiaBan,
                    SoLuong = ct.SoLuong
                })
                .ToList();

            dgvDsChiTietHoaDon.DataSource = data;
        }

        private void dgvDsChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDsChiTietHoaDon.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["MaSP"].Value?.ToString();
                txtNgayTao.Text = row.Cells["TenSanPham"].Value?.ToString();
                cboLoaiSP.Text = row.Cells["Loai"].Value?.ToString();
                cboMau.Text = row.Cells["Mau"].Value?.ToString();
                cboSize.Text = row.Cells["Size"].Value?.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();

                if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong))
                {
                    numericUpDownSoLuong.Value = soLuong;
                }
            }
        }
    }
}
