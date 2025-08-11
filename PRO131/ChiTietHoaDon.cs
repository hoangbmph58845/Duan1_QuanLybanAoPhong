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
    public partial class ChiTietHoaDon : UserControl
    {
        private readonly DuAn1Context _context = new DuAn1Context();
        public ChiTietHoaDon()
        {
            InitializeComponent();
            LoadChiTietHoaDon();
        }
        private void LoadChiTietHoaDon()
        {

            var hoadonCT = _context.HoaDonChiTiets

                .Select(hdct => new
                {
                    MaHDCT = hdct.MaHdct,
                    MaHD = hdct.MaHd,
                    MaSPCT = hdct.MaSpct,
                    Soluong = hdct.SoLuong,
                    Dongia = hdct.DonGia,
                })
                .ToList();


            dataGridView1.DataSource = hoadonCT;
            dataGridView1.Columns["MaHDCT"].HeaderText = "Mã HDCT";
            dataGridView1.Columns["MaHD"].HeaderText = "Mã HD";
            dataGridView1.Columns["MaSPCT"].HeaderText = "Mã SPCT";
            dataGridView1.Columns["Soluong"].HeaderText = "Số Lượng";
            dataGridView1.Columns["Dongia"].HeaderText = "Đơn Giá";
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maHDCT;


            if (int.TryParse(textBox1.Text.Trim(), out maHDCT))
            {
                var ketQua = _context.HoaDonChiTiets
                    .Where(hdct => hdct.MaHdct == maHDCT)
                    .AsEnumerable()
                    .Select(hdct => new
                    {
                        MaHDCT = hdct.MaHdct,
                        MaHD = hdct.MaHd,
                        MaSPCT = hdct.MaSpct,
                        Soluong = hdct.SoLuong,
                        Dongia = hdct.DonGia,

                    })
                    .ToList();

                dataGridView1.DataSource = ketQua;
            }
        }
    }
}