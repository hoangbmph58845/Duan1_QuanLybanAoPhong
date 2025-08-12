using Microsoft.EntityFrameworkCore;
using PRO131.DataContext;
using PRO131.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1Context = PRO131.Models.DuAn1Context;

namespace PRO131
{
    public partial class TaoHoaDon : UserControl
    {
        private readonly DuAn1Context _context = new DuAn1Context();
        private List<SanPhamTrongGio> _gioHang = new List<SanPhamTrongGio>();
        public TaoHoaDon()
        {
            InitializeComponent();
            LoadDanhSachSanPham();
        }
        private decimal TinhTongTienGioHang()
        {
            return _gioHang.Sum(sp => sp.SoLuong * sp.GiaBan);
        }
        private void LoadDanhSachSanPham()
        {
            var danhSachsanpham = _context.SanPhamChiTiets
                //.Include(sp => sp.MaSpNavigation)
                .Select(dssp => new
                {
                    MaSP = dssp.MaSp,
                    MASize = dssp.MaSize,
                    TenSP = dssp.TenSanPham,
                    MAMau = dssp.MaMau,
                    SOLuong = dssp.SoLuong,
                    GIaBan = dssp.GiaBan,
                })
                .ToList();

            dataGridView1.DataSource = danhSachsanpham;
            dataGridView1.Columns["MaSP"].HeaderText = "Mã Sp";
            dataGridView1.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns["MaSize"].HeaderText = "Mã Size";
            dataGridView1.Columns["MaMau"].HeaderText = "Mã Màu";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá Bán";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số Lượng";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var danhSachNhanVien = _context.NhanViens
                .Select(nv => new
                {
                    MaNv = nv.MaNv,
                    TenNv = nv.TenNhanVien
                })
        .ToList();

            comboBox3.DataSource = danhSachNhanVien;
            comboBox3.DisplayMember = "TenNv";   // Hiển thị tên nhân viên
            comboBox3.ValueMember = "MaNv";      // Giá trị là mã nhân viên

        }
  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var maSP = row.Cells["MaSP"].Value.ToString();
                var tenSP = row.Cells["TenSP"].Value.ToString();
                var maSize = row.Cells["MASize"].Value.ToString();
                var maMau = row.Cells["MAMau"].Value.ToString();
                var giaBan = Convert.ToDecimal(row.Cells["GIaBan"].Value);

                // Kiểm tra sản phẩm có trong giỏ hàng chưa (theo mã sp + size + màu)
                var spDaCo = _gioHang.FirstOrDefault(sp =>
                    sp.MaSP == maSP && sp.MaSize == maSize && sp.MaMau == maMau);

                if (spDaCo != null)
                {
                    spDaCo.SoLuong++;
                }
                else
                {
                    var spMoi = new SanPhamTrongGio
                    {
                        MaSP = maSP,
                        TenSanPham = tenSP,
                        MaSize = maSize,
                        MaMau = maMau,
                        GiaBan = giaBan,
                        SoLuong = 1
                    };
                    _gioHang.Add(spMoi);
                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = _gioHang;
                textBox3.Text = TinhTongTienGioHang().ToString("N0");
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {

                string maSP = dataGridView2.CurrentRow.Cells["MaSP"].Value.ToString();


                var spCanXoa = _gioHang.FirstOrDefault(sp => sp.MaSP == maSP);
                if (spCanXoa != null)
                {
                    _gioHang.Remove(spCanXoa);


                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = _gioHang;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa khỏi giỏ hàng.");
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Ép kiểu mã khách hàng
            if (!int.TryParse(textBox2.Text.Trim(), out int maKhInt))
            {
                MessageBox.Show("Mã khách hàng phải là số.");
                return;
            }
            int maNvInt = Convert.ToInt32(comboBox3.SelectedValue);
            decimal tongTien = decimal.Parse(textBox3.Text.Trim());
            string hinhThucTT = comboBox1.SelectedItem?.ToString();
            string trangThaiText = comboBox2.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(hinhThucTT))
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán.");
                return;
            }

            if (_gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.");
                return;
            }
            bool trangThai = false;
            if (trangThaiText == "Đã thanh toán")
            {
                trangThai = true;
            }


            HoaDon hoaDonMoi = new HoaDon
            {
                MaKh = maKhInt, 
                MaNv = maNvInt,
                //MaKh = 1,
                NgayBan = DateOnly.FromDateTime(DateTime.Now),
                TongTien = tongTien,
                PhuongThucThanhToan = hinhThucTT,
                TrangThai = trangThai
            };

            _context.HoaDons.Add(hoaDonMoi);
            _context.SaveChanges();


            //foreach (var sp in _gioHang)
            //{
            //    HoaDonChiTiet ct = new HoaDonChiTiet
            //    {
            //        MaHd = hoaDonMoi.MaHd,      
            //        //MaSpct = sp.MaSP,            
            //        SoLuong = sp.SoLuong,
            //        DonGia = sp.GiaBan
            //    };

            //    _context.HoaDonChiTiets.Add(ct);


            //    var spct = _context.SanPhamChiTiets.FirstOrDefault(x => x.MaSpct == sp.MaSpct);
            //    if (spct != null)
            //    {
            //        spct.SoLuongTon -= sp.SoLuong;
            //    }
            //}

            _context.SaveChanges();

            MessageBox.Show("Tạo hóa đơn thành công!");


            _gioHang.Clear();
            dataGridView2.DataSource = null;
            //textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
