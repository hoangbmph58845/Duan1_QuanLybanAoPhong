using Microsoft.EntityFrameworkCore;
using PRO131.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PRO131.DataContext;
namespace PRO131
{
    public partial class FormQLNhanVien : UserControl
    {
        private readonly DuAn1Context _context;
        public FormQLNhanVien()
        {
            InitializeComponent();
            _context = new DuAn1Context();  // khởi tạo 1 lần
            this.Load += FormQLNhanVien_Load;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadNhanVien();
        }

        private void LoadChucVu()
        {
            try
            {
                var ds = _context.ChucVus.ToList();
                cboChucVu.DataSource = ds;
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaCv";
                cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chức vụ: " + ex.Message);
            }
        }

        private void LoadNhanVien()
        {
            try
            {
                var dsNhanVien = _context.NhanViens
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
                    })
                    .ToList();

                dgvNhanVien.DataSource = dsNhanVien;

                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                // ... các header khác
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
                _context.SaveChanges();
                MessageBox.Show("✅ Thêm nhân viên thành công!");
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thêm nhân viên: " + ex.Message);
            }
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

                int maNV = int.Parse(txtMaNV.Text); // lấy từ txtMaNV (readonly)
                var nv = _context.NhanViens.FirstOrDefault(n => n.MaNv == maNV);
                if (nv != null)
                {
                    nv.TenNhanVien = txtHoTen.Text.Trim();
                    nv.GioiTinh = cboGioiTinh.Text;
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.SoDienThoai = txtSoDT.Text.Trim();
                    nv.NgaySinh = DateOnly.FromDateTime(dtNgaySinh.Value);   // ✅ dùng DateTime luôn, không cần DateOnly
                    nv.TrangThai = cboTrangThai.Text == "Đang làm";

                    // 🔥 Lấy lại MaCV theo tên chức vụ
                    var cv = _context.ChucVus.FirstOrDefault(c => c.TenChucVu == cboChucVu.Text);
                    if (cv != null) nv.MaCv = cv.MaCv;

                    _context.SaveChanges();
                    MessageBox.Show("✅ Cập nhật nhân viên thành công!");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("❌ Không tìm thấy nhân viên cần sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi cập nhật: " + ex.Message);
            }
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Gán dữ liệu vào các textbox & combobox
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDT.Text = row.Cells["SoDienThoai"].Value.ToString();

                // Ngày sinh
                DateOnly dateOnly = (DateOnly)row.Cells["NgaySinh"].Value;
                dtNgaySinh.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                // Trạng thái
                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

                // Chức vụ
                cboChucVu.Text = row.Cells["ChucVu"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("⚠️ Vui lòng chọn nhân viên để xóa!");
                    return;
                }

                int maNV = int.Parse(txtMaNV.Text);

                // Tìm nhân viên theo MaNV
                var nv = _context.NhanViens.FirstOrDefault(n => n.MaNv == maNV);
                if (nv != null)
                {
                    // Hỏi xác nhận trước khi xóa
                    var confirm = MessageBox.Show("❗Bạn có chắc muốn xóa nhân viên này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        _context.NhanViens.Remove(nv);
                        _context.SaveChanges();

                        MessageBox.Show("✅ Xóa nhân viên thành công!");
                        LoadNhanVien();

                        // Xóa thông tin trong các textbox
                        txtMaNV.Clear();
                        txtHoTen.Clear();
                        txtDiaChi.Clear();
                        txtSoDT.Clear();
                        cboGioiTinh.SelectedIndex = -1;
                        cboTrangThai.SelectedIndex = -1;
                        cboChucVu.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("❌ Không tìm thấy nhân viên cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu ô tìm kiếm trống, load lại toàn bộ danh sách
                    LoadNhanVien();
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
    }
}
