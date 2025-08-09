
using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PRO131
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Optional: customize IconButton appearance here if needed
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            panelSubSanPham.Visible = !panelSubSanPham.Visible;
        }

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
            panelSubBanHang.Visible = !panelSubBanHang.Visible;
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            panelSubKhachHang.Visible = !panelSubKhachHang.Visible;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelSubNhanVien.Visible = !panelSubNhanVien.Visible;
        }

        public void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }


        private void btnDanhSachSP_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCSanPham());
        }

        private void btnQuanLyTonKho_Click(object sender, EventArgs e)
        {
            var ucSanPham = new UCSanPham();
            ucSanPham.EnableQuanLyTonKhoMode(); // bật chế độ tồn kho
            LoadUserControl(ucSanPham);
        }


        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FormQLNhanVien());

        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FormQLTaiKhoan());
        }

        private void btnLichSuBan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FormLichSuBanHang());
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TaoHoaDon());
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DanhSachHoaDon());
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ChiTietHoaDon());
        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa nộp bài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

