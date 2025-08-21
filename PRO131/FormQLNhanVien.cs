using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO131.DataContext; // nơi chứa DuAn1Context
using PRO131.Models;
//using DuAn1Context = PRO131.Models.DuAn1Context;      // nơi chứa class NhanVien

namespace PRO131
{
    public partial class FormQLNhanVien : UserControl
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            _context = new DuAn1Context();
            this.Load += FormQLNhanVien_Load;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ;
        }
        private DuAn1Context _context = new DuAn1Context();



        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            InitTrangThai();   // đảm bảo combobox trạng thái có dữ liệu
            LoadChucVu();      // load combobox Chức vụ
            LoadNhanVien(true); // load từ DB khi mở form
            ClearForm();
        }
        private void LoadChucVu()
        {
            cboChucVu.DataSource = _context.ChucVus.ToList();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaCv";
        }
        private bool checksodienthoai(string soDT, int? idDangSua = null)
        {
            // Bắt đầu bằng 0 và đúng 10 số
            if (string.IsNullOrWhiteSpace(soDT) ||
                !System.Text.RegularExpressions.Regex.IsMatch(soDT, @"^0\d{9}$"))
            {
                MessageBox.Show("❌ Số điện thoại không hợp lệ! Phải bắt đầu bằng số 0 và có đúng 10 chữ số.");
                return false;
            }

            // Kiểm tra trùng trong DB (và bỏ qua chính bản ghi đang sửa nếu có)
            bool trungDb = _context.NhanViens.Any(nv => nv.SoDienThoai == soDT &&
                                                       (idDangSua == null || nv.MaNv != idDangSua.Value));

            // (tuỳ chọn) kiểm tra cả Local (các bản ghi vừa Add/Sửa nhưng chưa SaveChanges)
            bool trungLocal = _context.NhanViens.Local.Any(nv => nv.SoDienThoai == soDT &&
                                                                (idDangSua == null || nv.MaNv != idDangSua.Value));

            if (trungDb || trungLocal)
            {
                MessageBox.Show("❌ Số điện thoại đã tồn tại!");
                return false;
            }

            return true;
        }
        private void ClearForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            cboGioiTinh.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Now;
        }
        private void InitTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang làm");
            cboTrangThai.Items.Add("Nghỉ làm");
        }
        private void LoadNhanVien(bool fromDb = true)
        {
            try
            {
                List<object> dsNhanVien;

                if (fromDb)
                {
                    dsNhanVien = _context.NhanViens
       .Select(nv => new
       {
           MaNV = nv.MaNv,
           HoTen = nv.TenNhanVien,
           GioiTinh = nv.GioiTinh,
           DiaChi = nv.DiaChi,
           SoDienThoai = nv.SoDienThoai,
           NgaySinh = nv.NgaySinh,
           TrangThai = nv.TrangThai ? "Đang làm" : "Nghỉ làm",
           MaCV = nv.MaCv,
           ChucVu = nv.MaCvNavigation.TenChucVu
       }).Cast<object>().ToList();
                }
                else
                {
                    var locals = _context.NhanViens.Local.ToList();
                    dsNhanVien = locals
                        .Select(nv => new
                        {
                            MaNV = nv.MaNv > 0 ? nv.MaNv : (int?)null,  // ❌ không hiển thị 0
                            HoTen = nv.TenNhanVien,
                            GioiTinh = nv.GioiTinh,
                            DiaChi = nv.DiaChi,
                            SoDienThoai = nv.SoDienThoai,
                            NgaySinh = nv.NgaySinh,
                            TrangThai = nv.TrangThai ? "Đang làm" : "Nghỉ làm",
                            MaCV = nv.MaCv,
                            ChucVu = _context.ChucVus.FirstOrDefault(c => c.MaCv == nv.MaCv)?.TenChucVu
                        }).Cast<object>().ToList();
                }

                dgvNhanVien.AutoGenerateColumns = true;
                dgvNhanVien.DataSource = dsNhanVien;

                // Đặt header
                if (dgvNhanVien.Columns["MaNV"] != null) dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                if (dgvNhanVien.Columns["HoTen"] != null) dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                if (dgvNhanVien.Columns["GioiTinh"] != null) dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                if (dgvNhanVien.Columns["DiaChi"] != null) dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                if (dgvNhanVien.Columns["SoDienThoai"] != null) dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
                if (dgvNhanVien.Columns["NgaySinh"] != null) dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                if (dgvNhanVien.Columns["TrangThai"] != null) dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";
                if (dgvNhanVien.Columns["ChucVu"] != null) dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }
        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(cboGioiTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtSoDT.Text) ||
                    string.IsNullOrWhiteSpace(cboChucVu.Text) ||
                    string.IsNullOrWhiteSpace(cboTrangThai.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng nhập đầy đủ thông tin nhân viên!");
                    return;
                }
                // --- Check tuổi ---
                int age = DateTime.Now.Year - dtNgaySinh.Value.Year;
                if (dtNgaySinh.Value > DateTime.Now.AddYears(-age)) age--; // trừ nếu chưa qua sinh nhật

                if (age < 18)
                {
                    MessageBox.Show("❌ Nhân viên chưa đủ 18 tuổi!");
                    return;
                }
                if (age > 50)
                {
                    MessageBox.Show("❌ Nhân viên quá tuổi (trên 50)!");
                    return;
                }

                // --- Check số điện thoại ---
                if (!checksodienthoai(txtSoDT.Text.Trim()))
                    return;

                // --- Check địa chỉ ---
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng nhập địa chỉ!");
                    return;
                }

                var nv = new NhanVien()
                {
                    TenNhanVien = txtHoTen.Text.Trim(),
                    GioiTinh = cboGioiTinh.Text,
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDienThoai = txtSoDT.Text.Trim(),
                    NgaySinh = DateOnly.FromDateTime(dtNgaySinh.Value),
                    TrangThai = cboTrangThai.Text == "Đang làm",
                    MaCv = (int)cboChucVu.SelectedValue
                };

                _context.NhanViens.Add(nv);
                LoadNhanVien(false);
                MessageBox.Show("📝 Đã thêm vào danh sách tạm. Nhấn Lưu để ghi vào database!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thêm nhân viên: " + ex.Message);
                ClearForm();
            }
        }

        private bool CheckSoDienThoaiFormat(string soDT)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(soDT, @"^\d{9,11}$");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn nhân viên để sửa!");
                    return;
                }
                int age = DateTime.Now.Year - dtNgaySinh.Value.Year;
                if (dtNgaySinh.Value > DateTime.Now.AddYears(-age)) age--;

                if (age < 18)
                {
                    MessageBox.Show("❌ Nhân viên chưa đủ 18 tuổi!");
                    return;
                }
                if (age > 50)
                {
                    MessageBox.Show("❌ Nhân viên quá tuổi (trên 50)!");
                    return;
                }


                int maNv = int.Parse(txtMaNV.Text);
                var nv = _context.NhanViens.Local.FirstOrDefault(x => x.MaNv == maNv)
                         ?? _context.NhanViens.FirstOrDefault(x => x.MaNv == maNv);

                if (nv == null)
                {
                    MessageBox.Show("❌ Không tìm thấy nhân viên để sửa!");
                    return;
                }
                if (!CheckSoDienThoaiFormat(txtSoDT.Text.Trim()))
                {
                    MessageBox.Show("⚠️ Số điện thoại không hợp lệ!");
                    return;
                }
                nv.TenNhanVien = txtHoTen.Text.Trim();
                nv.GioiTinh = cboGioiTinh.Text;
                nv.DiaChi = txtDiaChi.Text.Trim();
                nv.SoDienThoai = txtSoDT.Text.Trim();
                nv.NgaySinh = DateOnly.FromDateTime(dtNgaySinh.Value);
                nv.TrangThai = cboTrangThai.Text == "Đang làm";
                nv.MaCv = (int)cboChucVu.SelectedValue;

                LoadNhanVien(false); // refresh local
                MessageBox.Show("📝 Đã sửa trong danh sách tạm. Nhấn Lưu để ghi vào database!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi cập nhật: " + ex.Message);
            }
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["MaNV"]?.Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoTen"]?.Value?.ToString() ?? "";
            cboGioiTinh.Text = row.Cells["GioiTinh"]?.Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"]?.Value?.ToString() ?? "";
            txtSoDT.Text = row.Cells["SoDienThoai"]?.Value?.ToString() ?? "";

            // Ngày sinh: hỗ trợ DateOnly | DateTime | string
            var cellNgaySinh = row.Cells["NgaySinh"]?.Value;
            if (cellNgaySinh is DateOnly dOnly)
            {
                dtNgaySinh.Value = dOnly.ToDateTime(TimeOnly.MinValue);
            }
            else if (cellNgaySinh is DateTime dTime)
            {
                dtNgaySinh.Value = dTime;
            }
            else if (DateTime.TryParse(cellNgaySinh?.ToString(), out var dParsed))
            {
                dtNgaySinh.Value = dParsed;
            }

            // Trạng thái
            var trangThaiText = row.Cells["TrangThai"]?.Value?.ToString() ?? "";
            if (trangThaiText == "Đang làm" || trangThaiText == "Nghỉ làm")
                cboTrangThai.Text = trangThaiText;

            // Chức vụ: set theo MaCV để luôn đúng
            if (row.Cells["MaCV"]?.Value != null && int.TryParse(row.Cells["MaCV"].Value.ToString(), out var maCv))
            {
                cboChucVu.SelectedValue = maCv;
            }

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    ClearForm();
                    LoadNhanVien(true); // xem toàn bộ từ DB
                    return;
                }

                var dsTimKiem = _context.NhanViens
                    .Where(nv => nv.TenNhanVien.Contains(keyword) ||
                                 nv.SoDienThoai.Contains(keyword) ||
                                 nv.DiaChi.Contains(keyword))
                    .Select(nv => new
                    {
                        MaNV = nv.MaNv,
                        HoTen = nv.TenNhanVien,
                        GioiTinh = nv.GioiTinh,
                        DiaChi = nv.DiaChi,
                        SoDienThoai = nv.SoDienThoai,
                        NgaySinh = nv.NgaySinh,
                        TrangThai = nv.TrangThai ? "Đang làm" : "Nghỉ làm",
                        MaCV = nv.MaCv,
                        ChucVu = nv.MaCvNavigation.TenChucVu
                    }).ToList();

                dgvNhanVien.DataSource = dsTimKiem;

                if (dsTimKiem.Count == 0)
                {
                    MessageBox.Show("🔍 Không tìm thấy nhân viên nào phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int changes = _context.SaveChanges(); // lưu tất cả Add/Sửa/Xóa trong Local
                if (changes > 0)
                {
                    MessageBox.Show($"✅ Đã lưu {changes} thay đổi vào database!");
                    LoadNhanVien(true); // load lại từ DB
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("⚠️ Không có thay đổi nào để lưu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu: " + ex.Message);
                ClearForm();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            try
            {
                // Xóa dữ liệu trên form
                ClearForm();

                // Load lại combobox
                InitTrangThai();
                LoadChucVu();

                // Load lại danh sách nhân viên từ DB
                LoadNhanVien(true);

                // Bỏ chọn trên DataGridView
                dgvNhanVien.ClearSelection();

                MessageBox.Show("✅ Đã làm mới dữ liệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi làm mới: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
