using PRO131.DataContext;
using PRO131.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QLKH : UserControl
    {
        private readonly DuAn1Context _context;

        public QLKH()
        {
            InitializeComponent();
            _context = new DuAn1Context();
            this.Load += QLKH_Load;

            comboBox_GT.Items.Clear();
            comboBox_GT.Items.AddRange(new string[] { "Nam", "Nữ" });
            comboBox_GT.SelectedIndex = 0;

            radioButton_TX.Checked = true;

            textBox_TK.TextChanged += Tb_TimKiem_TextChanged;
            button_TK.Click += Bt_TimKiem_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
            button_Them.Click += Bt_Them_Click;
            button_Sua.Click += Bt_Sua_Click;
            button_Xoa.Click += Bt_Xoa_Click;
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                var khList = _context.KhachHangs.AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    khList = khList.Where(k =>
                        k.MaKh.ToString().Contains(keyword) ||
                        k.TenKhachHang.Contains(keyword) ||
                        k.SoDienThoai.Contains(keyword) ||
                        k.GioiTinh.Contains(keyword) ||
                        k.DiaChi.Contains(keyword));
                }

                var dt = khList
                    .Select(k => new
                    {
                        k.MaKh,
                        k.TenKhachHang,
                        k.GioiTinh,
                        k.SoDienThoai,
                        k.DiaChi,
                        TrangThai = k.TrangThai,
                        TrangThaiText = k.TrangThai ? "Thường xuyên" : "Không thường xuyên"
                    })
                    .ToList();

                dataGridView1.DataSource = dt;

                RenameColumn("MaKh", "Mã khách hàng");
                RenameColumn("TenKhachHang", "Tên khách hàng");
                RenameColumn("GioiTinh", "Giới tính");
                RenameColumn("SoDienThoai", "Số điện thoại");
                RenameColumn("DiaChi", "Địa chỉ");
                RenameColumn("TrangThaiText", "Trạng thái");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void RenameColumn(string columnName, string headerText)
        {
            if (dataGridView1.Columns.Contains(columnName))
                dataGridView1.Columns[columnName].HeaderText = headerText;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            var row = dataGridView1.Rows[e.RowIndex];

            textBox_MK.Text = row.Cells["MaKh"]?.Value?.ToString() ?? "";
            textBox_T.Text = row.Cells["TenKhachHang"]?.Value?.ToString() ?? "";

            string gt = row.Cells["GioiTinh"]?.Value?.ToString() ?? "Nam";
            comboBox_GT.SelectedIndex = (gt == "Nữ") ? 1 : 0;

            textBox_DT.Text = row.Cells["SoDienThoai"]?.Value?.ToString() ?? "";
            textBox_DC.Text = row.Cells["DiaChi"]?.Value?.ToString() ?? "";

            bool trangThai = row.Cells["TrangThai"] != null && Convert.ToBoolean(row.Cells["TrangThai"].Value);
            radioButton_TX.Checked = trangThai;
            radioButton_KTX.Checked = !trangThai;
        }

        private void Bt_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(false)) return;

            try
            {
                var kh = new KhachHang
                {
                    TenKhachHang = textBox_T.Text.Trim(),
                    SoDienThoai = textBox_DT.Text.Trim(),
                    GioiTinh = comboBox_GT.SelectedItem.ToString(),
                    DiaChi = textBox_DC.Text.Trim(),
                    TrangThai = radioButton_TX.Checked
                };

                _context.KhachHangs.Add(kh);
                _context.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void Bt_Sua_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(true)) return;

            if (!int.TryParse(textBox_MK.Text, out int maKh))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ.");
                return;
            }

            var kh = _context.KhachHangs.Find(maKh);
            if (kh == null)
            {
                MessageBox.Show("Khách hàng không tồn tại.");
                return;
            }

            try
            {
                kh.TenKhachHang = textBox_T.Text.Trim();
                kh.SoDienThoai = textBox_DT.Text.Trim();
                kh.GioiTinh = comboBox_GT.SelectedItem.ToString();
                kh.DiaChi = textBox_DC.Text.Trim();
                kh.TrangThai = radioButton_TX.Checked;

                _context.SaveChanges();

                MessageBox.Show("Sửa khách hàng thành công!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message);
            }
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_MK.Text, out int maKh))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            var kh = _context.KhachHangs.Find(maKh);
            if (kh == null)
            {
                MessageBox.Show("Khách hàng không tồn tại.");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    _context.KhachHangs.Remove(kh);
                    _context.SaveChanges();

                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            textBox_MK.Clear();
            textBox_T.Clear();
            textBox_DT.Clear();
            textBox_DC.Clear();
            comboBox_GT.SelectedIndex = 0;
            radioButton_TX.Checked = true;
        }

        private bool ValidateForm(bool isEdit)
        {
            string ten = textBox_T.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên khách hàng không được để trống.");
                textBox_T.Focus();
                return false;
            }
            if (Regex.IsMatch(ten, @"\d"))
            {
                MessageBox.Show("Tên khách hàng không được chứa số.");
                textBox_T.Focus();
                return false;
            }

            string gt = comboBox_GT.SelectedItem?.ToString() ?? "";
            if (gt != "Nam" && gt != "Nữ")
            {
                MessageBox.Show("Giới tính phải là Nam hoặc Nữ.");
                comboBox_GT.Focus();
                return false;
            }

            string sdt = textBox_DT.Text.Trim();
            if (string.IsNullOrEmpty(sdt) || !Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 số.");
                textBox_DT.Focus();
                return false;
            }

            string diaChi = textBox_DC.Text.Trim();
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                textBox_DC.Focus();
                return false;
            }

            if (!isEdit && _context.KhachHangs.Any(k => k.SoDienThoai == sdt))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại.");
                textBox_DT.Focus();
                return false;
            }

            if (isEdit && int.TryParse(textBox_MK.Text, out int maKh) &&
                _context.KhachHangs.Any(k => k.SoDienThoai == sdt && k.MaKh != maKh))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại với khách hàng khác.");
                textBox_DT.Focus();
                return false;
            }

            return true;
        }

        private void Tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox_TK.Text.Trim());
        }

        private void Bt_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData(textBox_TK.Text.Trim());
        }
    }
}
