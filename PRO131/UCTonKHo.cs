using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PRO131.DataContext;

namespace PRO131
{
    public partial class UCTonKHo : UserControl
    {
        private readonly DuAn1Context _context = new DuAn1Context();
        private string _maSp;

        public UCTonKHo(string maSp)
        {
            _maSp = maSp;
            InitializeComponent();
            LoadComboBoxData();
            LoadComboBoxMau();
            LoadChiTietSanPham();
        }

        private void LoadComboBoxData()
        {
            cboSize.DataSource = _context.KichCos.ToList();
            cboSize.DisplayMember = "KichThuoc";
            cboSize.ValueMember = "MaSize";
        }

        private void LoadComboBoxMau()
        {
            cboMauSP.DataSource = _context.MauSacs.ToList();
            cboMauSP.DisplayMember = "TenMau";
            cboMauSP.ValueMember = "MaMau";
        }

        private void LoadChiTietSanPham()
        {
            int maSP = int.Parse(_maSp);
            var chiTietList = _context.SanPhamChiTiets
                .Include(ct => ct.MaSizeNavigation)
                .Include(ct => ct.MaMauNavigation)
                .Where(ct => ct.MaSp == maSP)
                .Select(ct => new
                {
                    Size = ct.MaSizeNavigation.KichThuoc,
                    Mau = ct.MaMauNavigation.TenMau,
                    SoLuong = ct.SoLuong,
                    GiaNhap = ct.GiaNhap,
                    GiaBan = ct.GiaBan
                })
                .ToList();

            dgvSanPham.DataSource = chiTietList;

            if (dgvSanPham.Rows.Count > 0)
            {
                dgvSanPham.ClearSelection();
                dgvSanPham.Rows[0].Selected = true;
                dgvSanPham.CurrentCell = dgvSanPham.Rows[0].Cells[0];

                dgvSanPham_CellClick(dgvSanPham, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                var row = dgvSanPham.Rows[e.RowIndex];

                cboSize.Text = row.Cells["Size"].Value?.ToString();
                cboMauSP.Text = row.Cells["Mau"].Value?.ToString();

                txtGIaNhap.Text = row.Cells["GiaNhap"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();

                if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong))
                {
                    numericUpDownSL.Value = soLuong;
                }
            }
        }
    }
}
