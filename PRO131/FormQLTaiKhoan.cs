using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO131.DataContext;
using PRO131.Models;
//using DuAn1Context = PRO131.Models.DuAn1Context;

namespace PRO131
{

    public partial class FormQLTaiKhoan : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();
        private List<TaiKhoan> _dsTaiKhoanTam = new List<TaiKhoan>();
        private int maNvDangNhap = 5;

        public FormQLTaiKhoan()
        {
            InitializeComponent();
            this.Load += FormQLTaiKhoan_Load;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;

        }
        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTrangThaiComboBox();
            LoadTaiKhoan();
            txtMaTK.ReadOnly = true;
            LoadNhanVienComboBox();
            clearForm();

        }
        private void clearForm()
        {
            txtMaTK.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            txtSearchTK.Clear();

            // Reset combobox
            cboNhanVien.SelectedIndex = -1;
            cboTrangThaiTK.SelectedIndex = 0;

            // Bỏ chọn trong DataGridView
            dgvTaiKhoan.ClearSelection();

            // Tải lại danh sách tài khoản
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập Tên đăng nhập!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập Mật khẩu!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập Email!");
                return false;
            }

            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn Nhân viên!");
                return false;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("⚠️ Mật khẩu phải có ít nhất 6 ký tự!");
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.com$";
            if (!Regex.IsMatch(txtEmail.Text.Trim(), pattern))
            {
                MessageBox.Show("⚠️ Email không hợp lệ!");
                return false;
            }

            string email = txtEmail.Text.Trim();
            if (!Regex.IsMatch(email, @"[A-Za-z]") || !Regex.IsMatch(email, @"\d"))
            {
                MessageBox.Show("⚠️ Email phải chứa cả chữ và số!");
                return false;
            }
            return true;
        }
        private void LoadNhanVienComboBox()
        {
            try
            {
                var danhSachNhanVien = _context.NhanViens
                    .Select(nv => new
                    {
                        MaNv = nv.MaNv,
                        TenHienThi = nv.MaNv + " - " + nv.TenNhanVien
                    })
                    .ToList();

                cboNhanVien.DataSource = danhSachNhanVien;
                cboNhanVien.DisplayMember = "TenHienThi";
                cboNhanVien.ValueMember = "MaNv";
                cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi load nhân viên: " + ex.Message);
            }
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
                        TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động",
                        Email = tk.Email,
                    }).ToList();

            dgvTaiKhoan.DataSource = dsTaiKhoan;
            dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã TK";
            dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns["MaNV"].HeaderText = "Mã NV";
            dgvTaiKhoan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvTaiKhoan.Columns["Email"].HeaderText = "Email";
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void LoadNhanVien()
        {

        }
        private void LoadTrangThaiComboBox()
        {
            cboTrangThaiTK.Items.Clear();
            cboTrangThaiTK.Items.Add("Hoạt động");
            cboTrangThaiTK.Items.Add("Dừng Hoạt Động");
            cboTrangThaiTK.SelectedIndex = 0;

        }
        private void HienThiDanhSachTam()
        {
            var dsDb = _context.TaiKhoans
                .Select(tk => new
                {
                    MaTK = tk.MaTk,
                    TenDangNhap = tk.TenDangNhap,
                    MatKhau = tk.MatKhau,
                    MaNV = tk.MaNv,
                    TenNhanVien = tk.MaNvNavigation.TenNhanVien,
                    TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động",
                    Email = tk.Email,
                    Nguon = "DB"
                }).ToList();

            var dsTam = _dsTaiKhoanTam
                .Select(tk => new
                {
                    MaTK = tk.MaTk,
                    TenDangNhap = tk.TenDangNhap,
                    MatKhau = tk.MatKhau,
                    MaNV = tk.MaNv,
                    TenNhanVien = _context.NhanViens.FirstOrDefault(nv => nv.MaNv == tk.MaNv)?.TenNhanVien,
                    TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động",
                    Email = tk.Email,
                    Nguon = "Tạm"
                }).ToList();

            var dsTong = dsDb.Concat(dsTam).ToList();
            dgvTaiKhoan.DataSource = dsTong;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                txtMaTK.Text = row.Cells["MaTK"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                int maNv;
                if (int.TryParse(row.Cells["MaNV"].Value.ToString(), out maNv))
                {
                    cboNhanVien.SelectedValue = maNv;
                }

                // Sửa: Gán giá trị chuỗi vào ComboBox
                string trangThaiText = row.Cells["TrangThai"].Value.ToString();
                cboTrangThaiTK.SelectedItem = trangThaiText;

                txtMaTK.ReadOnly = true;
            }
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                int maNv = Convert.ToInt32(cboNhanVien.SelectedValue);

                // ✅ Kiểm tra trong DB
                bool daTonTaiTrongDB = _context.TaiKhoans.Any(t => t.MaNv == maNv);

                // ✅ Kiểm tra trong danh sách tạm
                bool daTonTaiTrongTam = _dsTaiKhoanTam.Any(t => t.MaNv == maNv);

                if (daTonTaiTrongDB || daTonTaiTrongTam)
                {
                    MessageBox.Show("⚠️ Nhân viên này đã có tài khoản, không thể thêm mới!");
                    return;
                }

                var tk = new TaiKhoan()
                {
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    TrangThai = cboTrangThaiTK.SelectedItem.ToString() == "Hoạt động",
                    Email = txtEmail.Text.Trim(),
                    MaNv = maNv
                };

                _dsTaiKhoanTam.Add(tk);
                HienThiDanhSachTam();

                MessageBox.Show("✅ Đã thêm vào danh sách tạm, nhấn Lưu để ghi vào CSDL!");

                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thêm tài khoản tạm: " + ex.Message);
            }
        }


        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                

                // --- Check đã chọn nhân viên chưa ---
                if (string.IsNullOrEmpty(cboNhanVien.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn tài khoản cần sửa!");
                    return;
                }

                // --- Check đã chọn tài khoản chưa ---
                if (string.IsNullOrEmpty(txtMaTK.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn tài khoản cần sửa!");
                    return;
                }

                int maTK = int.Parse(txtMaTK.Text);
                var tk = _context.TaiKhoans.FirstOrDefault(t => t.MaTk == maTK);
                if (!ValidateInput()) return;
                if (tk != null)
                {
                    tk.TenDangNhap = txtTenDangNhap.Text.Trim();
                    tk.MatKhau = txtMatKhau.Text.Trim();
                    tk.Email = txtEmail.Text.Trim();
                    tk.TrangThai = cboTrangThaiTK.SelectedItem.ToString() == "Hoạt động";

                    _context.SaveChanges();
                    MessageBox.Show("✅ Sửa tài khoản thành công!");
                    LoadTaiKhoan();
                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi sửa tài khoản: " + ex.Message);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            
        }



        private void btnTimTK_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchTK.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {

                    LoadTaiKhoan();
                    clearForm();
                    return;
                }

                var dsTaiKhoan = _context.TaiKhoans
                    .Where(tk => tk.TenDangNhap.Contains(keyword)
                                 || tk.MaNvNavigation.TenNhanVien.Contains(keyword)
                                 || tk.MaNv.ToString().Contains(keyword)
                                 || tk.Email.Contains(keyword)
                                 || (tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động").Contains(keyword))
                    .Select(tk => new
                    {
                        MaTK = tk.MaTk,
                        TenDangNhap = tk.TenDangNhap,
                        MatKhau = tk.MatKhau,
                        MaNV = tk.MaNv,
                        TenNhanVien = tk.MaNvNavigation.TenNhanVien,
                        TrangThai = tk.TrangThai ? "Hoạt động" : "Dừng Hoạt Động",
                        Email = tk.Email
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

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dsTaiKhoanTam.Count == 0)
                {
                    MessageBox.Show("⚠️ Không có tài khoản tạm nào để lưu!");
                    return;
                }

                _context.TaiKhoans.AddRange(_dsTaiKhoanTam);
                _context.SaveChanges();

                MessageBox.Show("✅ Đã lưu tất cả tài khoản tạm vào CSDL!");
                _dsTaiKhoanTam.Clear();
                LoadTaiKhoan();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu vào DB: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu trong các textbox
                clearForm();

                // Tải lại danh sách tài khoản
                LoadTaiKhoan();

                MessageBox.Show("✅ Form đã được làm mới!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi làm mới: " + ex.Message);
            }
        }
    }
}
