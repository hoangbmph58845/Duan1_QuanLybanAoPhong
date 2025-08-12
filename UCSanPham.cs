using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO131.DataContext;
using Microsoft.EntityFrameworkCore;

namespace PRO131
{
    public partial class UCSanPham : UserControl
    {
        private readonly DuAn1Context _context = new DuAn1Context();

        public UCSanPham()
        {
            InitializeComponent();
            LoadDanhSachSanPham();
        }

        private void LoadDanhSachSanPham()
        {
            var danhSach = _context.SanPhams
                .Include(sp => sp.MaLoaiNavigation)
                .Include(sp => sp.MaHangSxNavigation)
                .Select(sp => new
                {
                    MaSP = sp.MaSp,
                    TenSanPham = sp.TenSanPham,
                    Loai = sp.MaLoaiNavigation.TenLoai,
                    HangSX = sp.MaHangSxNavigation.TenHangSanXuat
                })
                .ToList();

            dgvDanhSachSanPham.DataSource = danhSach;
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var maSP = dgvDanhSachSanPham.Rows[e.RowIndex].Cells["MaSP"].Value?.ToString();

                if (!string.IsNullOrEmpty(maSP) && IsQuanLyTonKho)
                {
                   
                    var ucTonKho = new UCTonKHo(maSP);
                    Form parentForm = this.FindForm();
                    if (parentForm is MainForm mainForm)
                    {
                        mainForm.LoadUserControl(ucTonKho);
                    }
                }
                else
                {
                    var ucDanhSach = new UCDanhSach();
                    Form parentForm = this.FindForm();
                    if (parentForm is MainForm mainForm)
                    {
                        mainForm.LoadUserControl(ucDanhSach);
                    }
                }
            }
        }



        private bool IsQuanLyTonKho = false;

        public void EnableQuanLyTonKhoMode()
        {
            IsQuanLyTonKho = true;
        }

    }
}
