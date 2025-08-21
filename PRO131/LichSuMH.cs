using PRO131.DataContext;
using System;
using System.Linq;
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

            // Gán sự kiện cho button tìm kiếm
            button_TK3.Click += Bt_TimKiem_Click;
        }

        private void LoadData(int? maKhachHang = null)
        {
            // Lấy hóa đơn
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
                    KhachHang = hd.MaKhNavigation.TenKhachHang,
                    hd.NgayBan,
                    hd.PhuongThucThanhToan,
                    hd.TongTien
                })
                .OrderByDescending(hd => hd.NgayBan)
                .ToList();

            dataGridView_LSMH.DataSource = list;

            // Đặt tiêu đề cột
            dataGridView_LSMH.Columns["MaHd"].HeaderText = "Mã Hóa Đơn";
            dataGridView_LSMH.Columns["MaKh"].HeaderText = "Mã Khách Hàng";
            dataGridView_LSMH.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
            dataGridView_LSMH.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dataGridView_LSMH.Columns["PhuongThucThanhToan"].HeaderText = "Phương Thức Thanh Toán";
            dataGridView_LSMH.Columns["TongTien"].HeaderText = "Tổng Tiền";

            dataGridView_LSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Button tìm kiếm theo mã khách hàng
        private void Bt_TimKiem_Click(object sender, EventArgs e)
        {
            string input = textBox_TK3.Text.Trim();

            // Validate: không được để trống
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập Mã Khách Hàng để tìm kiếm.");
                textBox_TK3.Focus();
                return;
            }

            // Validate: chỉ được nhập số
            if (!int.TryParse(input, out int maKH))
            {
                MessageBox.Show("Mã Khách Hàng phải là số nguyên.");
                textBox_TK3.Focus();
                return;
            }

            // Kiểm tra khách hàng có tồn tại
            var kh = _context.KhachHangs.FirstOrDefault(k => k.MaKh == maKH);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng với Mã Khách Hàng này.");
                textBox_TK3.Focus();
                return;
            }

            // Load dữ liệu hóa đơn của khách hàng
            LoadData(maKH);
        }

        // Nếu muốn load trực tiếp theo khách hàng từ ngoài Form
        public void LoadDataByCustomer(int MaKH)
        {
            LoadData(MaKH);
        }
    }
}
