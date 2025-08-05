using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO131.DataContext;
using PRO131.Models;

namespace PRO131
{

    public partial class FormQLTaiKhoan : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();

        public FormQLTaiKhoan()
        {
            InitializeComponent();
            this.Load += FormQLTaiKhoan_Load;

            // Gắn sự kiện cho các nút
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;

        }
        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTrangThaiComboBox();
            LoadTaiKhoan();
            txtMaTK.ReadOnly = true;
            txtMaNV.ReadOnly = true;
        }
        private void LoadTaiKhoan()
        {
            var dsTaiKhoan = _context.TaiKhoans
                 .Select(tk => new
                 {
                     MaTK = tk.MaTk,
                     TenDangNhap = tk.TenDangNhap,
                     MatKhau = tk.MatKhau,
                     MaNV = tk.MaNv,
                     TenNhanVien = tk.MaNvNavigation.TenNhanVien,
                     TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động"
                 }).ToList();

            dgvTaiKhoan.DataSource = dsTaiKhoan;
            dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã TK";
            dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns["MaNV"].HeaderText = "Mã NV";
            dgvTaiKhoan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng thái";
        }
        private void LoadNhanVien()
        {

        }
        private void LoadTrangThaiComboBox()
        {
            cboTrangThaiTK.Items.Clear();
            cboTrangThaiTK.Items.Add("Hoạt động");      // tương ứng 1
            cboTrangThaiTK.Items.Add("Dừng Hoạt Động"); // tương ứng 0
            cboTrangThaiTK.SelectedIndex = 0; // mặc định chọn "Hoạt động"
        }
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells["MaTK"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();

                // ✅ set trạng thái
                string trangThai = row.Cells["TrangThai"].Value.ToString();
                cboTrangThaiTK.SelectedItem = trangThai;

                // ✅ Không cho sửa 2 mã tự tăng
                txtMaTK.ReadOnly = true;
                txtMaNV.ReadOnly = true;
            }
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng nhập Tên đăng nhập và Mật khẩu!");
                    return;
                }

                // ✅ Không set MaTk và MaNv vì DB sẽ tự tăng
                var tk = new TaiKhoan()
                {
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    TrangThai = cboTrangThaiTK.SelectedItem.ToString() == "Hoạt động"
                };

                _context.TaiKhoans.Add(tk);
                _context.SaveChanges();
                MessageBox.Show("✅ Thêm tài khoản thành công!");
                LoadTaiKhoan();

                // Reset form
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtMaNV.Clear(); // không cần nhưng vẫn clear để UI sạch
                txtMaTK.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thêm tài khoản: " + ex.Message);
            }
        }
        private int maNvDangNhap = 5;

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTK.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn tài khoản cần sửa!");
                    return;
                }

                int maTK = int.Parse(txtMaTK.Text);
                var tk = _context.TaiKhoans.FirstOrDefault(t => t.MaTk == maTK);
                if (tk != null)
                {
                    tk.TenDangNhap = txtTenDangNhap.Text.Trim();
                    tk.MatKhau = txtMatKhau.Text.Trim();
                    tk.TrangThai = cboTrangThaiTK.SelectedItem.ToString() == "Hoạt động";

                    _context.SaveChanges();
                    MessageBox.Show("✅ Sửa tài khoản thành công!");
                    LoadTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi sửa tài khoản: " + ex.Message);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTK.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn tài khoản cần xóa!");
                    return;
                }

                int maTK = int.Parse(txtMaTK.Text);
                var tk = _context.TaiKhoans.FirstOrDefault(t => t.MaTk == maTK);
                if (tk != null)
                {
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        _context.TaiKhoans.Remove(tk);
                        _context.SaveChanges();
                        MessageBox.Show("🗑️ Xóa tài khoản thành công!");
                        LoadTaiKhoan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi xóa tài khoản: " + ex.Message);
            }
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
             try
            {
                string keyword = txtSearchTK.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadTaiKhoan(); // nếu không nhập → load toàn bộ
                    return;
                }

                var dsTaiKhoan = _context.TaiKhoans
                    .Where(tk => tk.TenDangNhap.Contains(keyword)
                              || tk.MaNvNavigation.TenNhanVien.Contains(keyword)
                              || tk.MaNv.ToString().Contains(keyword)
                              || (tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động").Contains(keyword))
                    .Select(tk => new
                    {
                        MaTK = tk.MaTk,
                        TenDangNhap = tk.TenDangNhap,
                        MatKhau = tk.MatKhau,
                        MaNV = tk.MaNv,
                        TenNhanVien = tk.MaNvNavigation.TenNhanVien,
                        TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động"
                    }).ToList();

                if (dsTaiKhoan.Any())
                {
                    dgvTaiKhoan.DataSource = dsTaiKhoan;
                }
                else
                {
                    MessageBox.Show("⚠️ Không tìm thấy tài khoản nào phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi tìm kiếm: " + ex.Message);
            }
        }
    }
}
