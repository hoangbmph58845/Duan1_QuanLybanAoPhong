using Microsoft.EntityFrameworkCore;
using PRO131.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using PRO131.DataContext;
namespace PRO131
{
    public partial class UCDanhSach : UserControl
    {
        private DuAn1Context _context = new DuAn1Context();
        private enum FormMode { View, Edit, Create, DetailEdit, DetailCreate }
        private FormMode _mode = FormMode.View;


        private Control[] _editableInputs;
        private Button[] _otherButtons;

        public UCDanhSach()
        {
            InitializeComponent();
            LoadCombobox();
            LoadSanPham();

            _editableInputs = new Control[]
            {
                txtTenSP, cboLoaiSP, cboMau, cboSize, txtGiaNhap, txtGiaBan, numericUpDownSoLuong
            };
            _otherButtons = new Button[] { btnXoa, btnThemCT, btnSuaCT, btnXoaCT };

            UpdateUiForMode(FormMode.View);
        }
        private void LoadCombobox()
        {
            var dsLoai = _context.LoaiSanPhams.ToList();
            cboLoaiSP.DataSource = dsLoai;
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
            cboLoaiSP.SelectedIndex = -1;
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            var dsMau = _context.MauSacs.ToList();
            cboMau.DataSource = dsMau;
            cboMau.DisplayMember = "TenMau";
            cboMau.ValueMember = "MaMau";
            cboMau.SelectedIndex = -1;
            cboMau.DropDownStyle = ComboBoxStyle.DropDownList;
            var dsSize = _context.KichCos.ToList();
            cboSize.DataSource = dsSize;
            cboSize.DisplayMember = "KichThuoc";
            cboSize.ValueMember = "MaSize";
            cboSize.SelectedIndex = -1;
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            var dsHang = _context.HangSanXuats.ToList();
            cboHangSX.DataSource = dsHang;
            cboHangSX.DisplayMember = "TenHangSanXuat";
            cboHangSX.ValueMember = "MaHangSx";
            cboHangSX.SelectedIndex = -1;
            cboHangSX.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void LoadSanPham()
        {
            var data =
                (from sp in _context.SanPhams
                 join loai in _context.LoaiSanPhams on sp.MaLoai equals loai.MaLoai
                 join hang in _context.HangSanXuats on sp.MaHangSx equals hang.MaHangSx into gjHang
                 from hang in gjHang.DefaultIfEmpty()                                   

                 join ct0 in _context.SanPhamChiTiets on sp.MaSp equals ct0.MaSp into gjCt
                 from ct in gjCt.DefaultIfEmpty()                                       

                 join mau0 in _context.MauSacs on ct.MaMau equals mau0.MaMau into gjMau
                 from mau in gjMau.DefaultIfEmpty()                                     

                 join size0 in _context.KichCos on ct.MaSize equals size0.MaSize into gjSize
                 from size in gjSize.DefaultIfEmpty()                                   

                 select new
                 {
                     MaSP = sp.MaSp,
                     TenSanPham = sp.TenSanPham,

                     MaLoai = loai.MaLoai,
                     Loai = loai.TenLoai,

                     MaHangSx = sp.MaHangSx,
                     HangSX = hang != null ? hang.TenHangSanXuat : string.Empty,

                     MaMau = mau != null ? (int?)mau.MaMau : null,
                     Mau = mau != null ? mau.TenMau : string.Empty,

                     MaSize = size != null ? (int?)size.MaSize : null,
                     Size = size != null ? size.KichThuoc : string.Empty,

                     GiaNhap = ct != null ? ct.GiaNhap : 0m,
                     GiaBan = ct != null ? ct.GiaBan : 0m,
                     SoLuong = ct != null ? ct.SoLuong : 0
                 }).ToList();

            dgvDsChiTietHoaDon.AutoGenerateColumns = true;
            dgvDsChiTietHoaDon.DataSource = data;

            if (dgvDsChiTietHoaDon.Columns["MaLoai"] != null)
                dgvDsChiTietHoaDon.Columns["MaLoai"].Visible = false;
            if (dgvDsChiTietHoaDon.Columns["MaHangSx"] != null)
                dgvDsChiTietHoaDon.Columns["MaHangSx"].Visible = false;
          
            if (dgvDsChiTietHoaDon.Columns["MaMau"] != null) dgvDsChiTietHoaDon.Columns["MaMau"].Visible = false;
            if (dgvDsChiTietHoaDon.Columns["MaSize"] != null) dgvDsChiTietHoaDon.Columns["MaSize"].Visible = false;

            if (dgvDsChiTietHoaDon.Rows.Count > 0)
            {
                dgvDsChiTietHoaDon.ClearSelection();
                dgvDsChiTietHoaDon.Rows[0].Selected = true;
                dgvDsChiTietHoaDon.CurrentCell = dgvDsChiTietHoaDon.Rows[0].Cells[0];
                BindCurrentRowToInputs();   // đã có phiên bản xử lý null theo LEFT JOIN
            }
        }



        private void BindCurrentRowToInputs()
        {
            var row = dgvDsChiTietHoaDon.CurrentRow;
            if (row == null) return;

            txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
            txtTenSP.Text = row.Cells["TenSanPham"].Value?.ToString();

            if (TryGetIntCell(row, "MaHangSx", out var maHang))
                cboHangSX.SelectedValue = maHang;
            else
                cboHangSX.SelectedIndex = -1;

            if (TryGetIntCell(row, "MaLoai", out var maLoai))
                cboLoaiSP.SelectedValue = maLoai;
            else
                cboLoaiSP.SelectedIndex = -1;

            if (TryGetIntCell(row, "MaMau", out var maMau))
                cboMau.SelectedValue = maMau;
            else
            {
                cboMau.SelectedIndex = -1;
                cboMau.Text = row.Cells["Mau"].Value?.ToString() ?? "";
            }

            if (TryGetIntCell(row, "MaSize", out var maSize))
                cboSize.SelectedValue = maSize;
            else
            {
                cboSize.SelectedIndex = -1;
                cboSize.Text = row.Cells["Size"].Value?.ToString() ?? "";
            }

            txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString() ?? "0";
            txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString() ?? "0";

            if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out var sl))
            {
                decimal v = sl;
                if (v < numericUpDownSoLuong.Minimum) v = numericUpDownSoLuong.Minimum;
                if (v > numericUpDownSoLuong.Maximum) v = numericUpDownSoLuong.Maximum;
                numericUpDownSoLuong.Value = v;
            }
            else
            {
                numericUpDownSoLuong.Value = 0;
            }
        }

        private static bool TryGetIntCell(DataGridViewRow row, string colName, out int value)
        {
            value = 0;
            var obj = row.Cells[colName]?.Value;
            if (obj == null || obj == DBNull.Value) return false;
            if (obj is int i) { value = i; return true; }
            return int.TryParse(obj.ToString(), out value);
        }


        private void UpdateUiForMode(FormMode mode)
        {
            _mode = mode;

            bool spEditing = (mode == FormMode.Edit) || (mode == FormMode.Create);
            bool ctEditing = (mode == FormMode.DetailEdit) || (mode == FormMode.DetailCreate);
            bool canEditAny = spEditing || ctEditing;

            txtTenSP.ReadOnly = !spEditing;
            cboLoaiSP.Enabled = spEditing;
            cboHangSX.Enabled = spEditing;

            bool allowDetailInputs = spEditing || ctEditing;
            txtGiaNhap.ReadOnly = !allowDetailInputs;
            txtGiaBan.ReadOnly = !allowDetailInputs;
            numericUpDownSoLuong.ReadOnly = !allowDetailInputs;
            cboMau.Enabled = allowDetailInputs;
            cboSize.Enabled = allowDetailInputs;

            dgvDsChiTietHoaDon.Enabled = !canEditAny;

            btnHuy.Visible = spEditing;

            btnHuyCT.Visible = ctEditing;

            foreach (var b in _otherButtons) b.Enabled = !canEditAny;

            btnSua.Text = spEditing ? "Lưu" : "Sửa";
            btnThem.Text = (mode == FormMode.Create) ? "Lưu mới" : "Thêm";

            btnSuaCT.Text = (mode == FormMode.DetailEdit) ? "Lưu " : "Sửa ";
            btnThemCT.Text = (mode == FormMode.DetailCreate) ? "Lưu mới" : "Thêm ";

            btnThem.Enabled = (mode == FormMode.View) || (mode == FormMode.Create);
            btnSua.Enabled = (mode == FormMode.View) || (mode == FormMode.Edit);
            btnXoa.Enabled = (mode == FormMode.View);

            btnThemCT.Enabled = (mode == FormMode.View) || (mode == FormMode.DetailCreate);
            btnSuaCT.Enabled = (mode == FormMode.View) || (mode == FormMode.DetailEdit);
            btnXoaCT.Enabled = (mode == FormMode.View);
        }


        // ===== XÓA =====
        // B1: Xác định đúng chi tiết theo (MaSP + MaMau + MaSize)
        // B2: Remove chi tiết
        // B3: Nếu không còn chi tiết nào khác → Remove luôn SanPham
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_mode != FormMode.View) return;

            if (!int.TryParse(txtMaSP.Text, out int maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ.");
                return;
            }

            if (MessageBox.Show("Xóa SẢN PHẨM này và TOÀN BỘ chi tiết của nó?",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using (var tx = _context.Database.BeginTransaction())
                {
  
                    var allDetails = _context.SanPhamChiTiets.Where(ct => ct.MaSp == maSP).ToList();
                    if (allDetails.Count > 0)
                        _context.SanPhamChiTiets.RemoveRange(allDetails);

                    var sp = _context.SanPhams.Find(maSP);
                    if (sp != null)
                        _context.SanPhams.Remove(sp);

                    _context.SaveChanges();
                    tx.Commit();
                }

                MessageBox.Show("Đã xóa sản phẩm và toàn bộ chi tiết.");
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (_mode != FormMode.Create)
            {
                ClearInputsForCreate();
                UpdateUiForMode(FormMode.Create);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm.");
                return;
            }
            if (cboLoaiSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm.");
                return;
            }
            if (cboHangSX.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hãng sản xuất.");
                return;
            }

            try
            {
                var ten = txtTenSP.Text.Trim();
                var maLoai = (int)cboLoaiSP.SelectedValue;
                var maHang = (int)cboHangSX.SelectedValue;

      
                bool daTonTai = _context.SanPhams.Any(x => x.TenSanPham == ten && x.MaLoai == maLoai);
                if (daTonTai)
                {
                    var ask = MessageBox.Show(
                        "Sản phẩm cùng Tên và Loại đã tồn tại. Vẫn muốn tạo thêm?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask != DialogResult.Yes) return;
                }

                var sp = new SanPham
                {
                    TenSanPham = ten,
                    MaLoai = maLoai,
                    MaHangSx = maHang       
                };

                _context.SanPhams.Add(sp);
                _context.SaveChanges();       

                txtMaSP.Text = sp.MaSp.ToString();
                MessageBox.Show("Đã thêm SẢN PHẨM. Hãy thêm CHI TIẾT nếu cần.");

                UpdateUiForMode(FormMode.View);
                LoadSanPham();
            }
            catch (DbUpdateException ex)
            {
                var msg = ex.InnerException?.Message ?? ex.GetBaseException().Message ?? ex.Message;
                MessageBox.Show("Lỗi khi thêm SẢN PHẨM:\n" + msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }
        }


        private void ClearInputsForCreate()
        {
  
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            numericUpDownSoLuong.Value = 0;

            cboLoaiSP.SelectedIndex = -1;
            cboHangSX.SelectedIndex = -1;  
            cboMau.SelectedIndex = -1;
            cboSize.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (_mode != FormMode.Edit)
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
                    return;
                }
                UpdateUiForMode(FormMode.Edit);
                return;
            }
            try
            {
                SaveProductToDatabase();
                MessageBox.Show("Đã lưu thay đổi.");
                UpdateUiForMode(FormMode.View);
                LoadSanPham();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá nhập/giá bán không hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            BindCurrentRowToInputs();
            UpdateUiForMode(FormMode.View);
        }
        private void dgvDsChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode == FormMode.View)
                BindCurrentRowToInputs();
        }

        private void SaveProductToDatabase()
        {
      
            if (!int.TryParse(txtMaSP.Text, out int maSP))
                throw new Exception("Mã sản phẩm không hợp lệ.");

            var sp = _context.SanPhams.Find(maSP)
                     ?? throw new Exception("Không tìm thấy sản phẩm.");

            sp.TenSanPham = txtTenSP.Text.Trim();

            if (cboLoaiSP.SelectedValue != null)
                sp.MaLoai = (int)cboLoaiSP.SelectedValue;

            if (cboHangSX.SelectedValue == null ||
                cboMau.SelectedValue == null ||
                cboSize.SelectedValue == null)
                throw new Exception("Thiếu Hãng sản xuất / Màu / Size.");

            sp.MaHangSx = (int)cboHangSX.SelectedValue;

            if (!decimal.TryParse(txtGiaNhap.Text, out var giaNhap))
                throw new FormatException();
            if (!decimal.TryParse(txtGiaBan.Text, out var giaBan))
                throw new FormatException();

            int maMau = (int)cboMau.SelectedValue;
            int maSize = (int)cboSize.SelectedValue;

            var spct = _context.SanPhamChiTiets
                .FirstOrDefault(x => x.MaSp == maSP && x.MaMau == maMau && x.MaSize == maSize)
                ?? throw new Exception("Không tìm thấy chi tiết sản phẩm.");

            spct.GiaNhap = giaNhap;
            spct.GiaBan = giaBan;
            spct.SoLuong = (int)numericUpDownSoLuong.Value;

            _context.SaveChanges();
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (_mode != FormMode.DetailCreate)
            {
                txtGiaNhap.Clear(); 
                txtGiaBan.Clear(); 
                numericUpDownSoLuong.Value = 0;
                UpdateUiForMode(FormMode.DetailCreate);
                return;
            }

            if (!int.TryParse(txtMaSP.Text, out int maSP)) { MessageBox.Show("Chưa có Mã sản phẩm."); return; }
            if (cboMau.SelectedValue == null || cboSize.SelectedValue == null) { MessageBox.Show("Chọn Màu/Size."); return; }
            if (!decimal.TryParse(txtGiaNhap.Text, out var giaNhap) || !decimal.TryParse(txtGiaBan.Text, out var giaBan))
            { MessageBox.Show("Giá nhập/giá bán không hợp lệ."); return; }
            int soLuong = (int)numericUpDownSoLuong.Value; if (soLuong <= 0) { MessageBox.Show("Số lượng phải > 0."); return; }

            int maMau = (int)cboMau.SelectedValue;
            int maSize = (int)cboSize.SelectedValue;

            try
            {
                var sp = _context.SanPhams.Find(maSP);
                if (sp == null) { MessageBox.Show("Không tìm thấy sản phẩm."); return; }

                var spct = _context.SanPhamChiTiets.FirstOrDefault(x => x.MaSp == maSP && x.MaMau == maMau && x.MaSize == maSize);

                if (spct != null)
                {
                    var ask = MessageBox.Show("Biến thể đã tồn tại. Cộng dồn số lượng và cập nhật giá?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask != DialogResult.Yes) return;

                    spct.SoLuong += soLuong;
                    spct.GiaNhap = giaNhap;
                    spct.GiaBan = giaBan;
                }
                else
                {
                    var ct = new SanPhamChiTiet
                    {
                        MaSp = maSP,
                        MaMau = maMau,
                        MaSize = maSize,
                        GiaNhap = giaNhap,
                        GiaBan = giaBan,
                        SoLuong = soLuong
                    };
                    _context.SanPhamChiTiets.Add(ct);
                }

                _context.SaveChanges();
                MessageBox.Show("Đã lưu chi tiết.");

                UpdateUiForMode(FormMode.View);
                LoadSanPham();

                foreach (DataGridViewRow r in dgvDsChiTietHoaDon.Rows)
                {
                    int rMaSp = Convert.ToInt32(r.Cells["MaSP"].Value);
                    int rMaMau = Convert.ToInt32(r.Cells["MaMau"].Value);
                    int rMaSize = Convert.ToInt32(r.Cells["MaSize"].Value);
                    if (rMaSp == maSP && rMaMau == maMau && rMaSize == maSize)
                    { r.Selected = true; dgvDsChiTietHoaDon.CurrentCell = r.Cells[0]; break; }
                }
                BindCurrentRowToInputs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Thêm CT: " + ex.Message); }
        }
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
     
            if (_mode != FormMode.DetailEdit)
            {
                if (dgvDsChiTietHoaDon.CurrentRow == null) { MessageBox.Show("Chọn một chi tiết trên lưới."); return; }
                UpdateUiForMode(FormMode.DetailEdit);
                return;
            }

            if (!int.TryParse(txtMaSP.Text, out int maSP)) { MessageBox.Show("Chưa có Mã SP."); return; }
            if (cboMau.SelectedValue == null || cboSize.SelectedValue == null) { MessageBox.Show("Chọn Màu/Size."); return; }
            if (!decimal.TryParse(txtGiaNhap.Text, out var giaNhap) || !decimal.TryParse(txtGiaBan.Text, out var giaBan))
            { MessageBox.Show("Giá không hợp lệ."); return; }
            int soLuong = (int)numericUpDownSoLuong.Value;

            var row = dgvDsChiTietHoaDon.CurrentRow;
            if (row == null) { MessageBox.Show("Chưa chọn chi tiết."); return; }

            int maMauGoc = Convert.ToInt32(row.Cells["MaMau"].Value);
            int maSizeGoc = Convert.ToInt32(row.Cells["MaSize"].Value);
            int maMauMoi = (int)cboMau.SelectedValue;
            int maSizeMoi = (int)cboSize.SelectedValue;

            try
            {
                var spctGoc = _context.SanPhamChiTiets
                    .FirstOrDefault(x => x.MaSp == maSP && x.MaMau == maMauGoc && x.MaSize == maSizeGoc);
                if (spctGoc == null) { MessageBox.Show("Không tìm thấy CT gốc."); return; }

                if (maMauMoi == maMauGoc && maSizeMoi == maSizeGoc)
                {
                    spctGoc.GiaNhap = giaNhap;
                    spctGoc.GiaBan = giaBan;
                    spctGoc.SoLuong = soLuong;
                }
                else
                {
                    var spctMoi = _context.SanPhamChiTiets
                        .FirstOrDefault(x => x.MaSp == maSP && x.MaMau == maMauMoi && x.MaSize == maSizeMoi);

                    if (spctMoi != null)
                    {
                        var ask = MessageBox.Show("Biến thể mới đã tồn tại. Gộp số lượng và cập nhật giá?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask != DialogResult.Yes) return;

                        spctMoi.SoLuong += soLuong;
                        spctMoi.GiaNhap = giaNhap;
                        spctMoi.GiaBan = giaBan;

                        _context.SanPhamChiTiets.Remove(spctGoc);
                    }
                    else
                    {
                        var ctNew = new SanPhamChiTiet
                        {
                            MaSp = maSP,
                            MaMau = maMauMoi,
                            MaSize = maSizeMoi,
                            GiaNhap = giaNhap,
                            GiaBan = giaBan,
                            SoLuong = soLuong
                        };
                        _context.SanPhamChiTiets.Add(ctNew);
                        _context.SanPhamChiTiets.Remove(spctGoc);
                    }
                }

                _context.SaveChanges();
                MessageBox.Show("Đã lưu chi tiết.");

                UpdateUiForMode(FormMode.View);
                LoadSanPham();
                foreach (DataGridViewRow r in dgvDsChiTietHoaDon.Rows)
                {
                    int rMaSp = Convert.ToInt32(r.Cells["MaSP"].Value);
                    int rMaMau = Convert.ToInt32(r.Cells["MaMau"].Value);
                    int rMaSize = Convert.ToInt32(r.Cells["MaSize"].Value);
                    if (rMaSp == maSP && rMaMau == maMauMoi && rMaSize == maSizeMoi)
                    { r.Selected = true; dgvDsChiTietHoaDon.CurrentCell = r.Cells[0]; break; }
                }
                BindCurrentRowToInputs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Sửa CT: " + ex.Message); }
        }
        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            var row = dgvDsChiTietHoaDon.CurrentRow;
            if (row == null) { MessageBox.Show("Chọn một chi tiết trên lưới."); return; }

            if (MessageBox.Show("Xóa CHI TIẾT này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                int maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
                int maMau = Convert.ToInt32(row.Cells["MaMau"].Value);
                int maSize = Convert.ToInt32(row.Cells["MaSize"].Value);

                var spct = _context.SanPhamChiTiets.FirstOrDefault(x => x.MaSp == maSP && x.MaMau == maMau && x.MaSize == maSize);
                if (spct == null) { MessageBox.Show("Không tìm thấy chi tiết."); return; }

                _context.SanPhamChiTiets.Remove(spct);

                bool conChiTiet = _context.SanPhamChiTiets.Any(x => x.MaSp == maSP && x != spct);
                if (!conChiTiet)
                {
                    var sp = _context.SanPhams.Find(maSP);
                    if (sp != null) _context.SanPhams.Remove(sp);
                }

                _context.SaveChanges();
                MessageBox.Show("Đã xóa chi tiết.");
                LoadSanPham();
                BindCurrentRowToInputs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Xóa CT: " + ex.Message); }
        }
        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            BindCurrentRowToInputs();
            UpdateUiForMode(FormMode.View);
        }

    }
}
