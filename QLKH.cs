using PRO131.DataContext;
using PRO131.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QLKH : UserControl
    {
        public QLKH()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            using (var db = new DuAn1Context())
            {
                var data = db.KhachHangs
                    .Select(kh => new
                    {
                        maKhachHang = kh.MaKh,
                        tenKhachHang = kh.TenKhachHang,
                        gioiTinh = kh.GioiTinh,
                        diaChi = kh.DiaChi,
                        dienThoai = kh.SoDienThoai,
                        TrangThai = kh.TrangThai ? "Hoạt động" : "Ngừng"
                    })
                    .ToList();

                dataGridView1.DataSource = data;
            }

            textBox_MK.ReadOnly = true;
        }

        // Thêm khách hàng mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DuAn1Context())
                {
                    // Kiểm tra mã khách hàng đã tồn tại chưa
                    int maKh;
                    if (!int.TryParse(textBox_MK.Text.Trim(), out maKh))
                    {
                        MessageBox.Show("Mã khách hàng phải là số.", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    if (db.KhachHangs.Any(kh => kh.MaKh == maKh))
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại.", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    var kh = new KhachHang()
                    {
                        MaKh = maKh,
                        TenKhachHang = textBox_TK.Text.Trim(),
                        GioiTinh = comboBox_GT.Text,
                        DiaChi = textBox_DC.Text.Trim(),
                        SoDienThoai = textBox_DT.Text.Trim(),
                        TrangThai = true // Mặc định là hoạt động
                    };

                    db.KhachHangs.Add(kh);
                    db.SaveChanges();

                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            LoadDB();
            ResetForm();
        }

        // Sửa khách hàng
        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DuAn1Context())
                {
                    int maKh;
                    if (!int.TryParse(textBox_MK.Text.Trim(), out maKh))
                    {
                        MessageBox.Show("Mã khách hàng phải là số.", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    var sua = db.KhachHangs.SingleOrDefault(kh => kh.MaKh == maKh);

                    if (sua == null)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    sua.TenKhachHang = textBox_TK.Text.Trim();
                    sua.GioiTinh = comboBox_GT.Text;
                    sua.DiaChi = textBox_DC.Text.Trim();
                    sua.SoDienThoai = textBox_DT.Text.Trim();

                    await db.SaveChangesAsync();

                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            LoadDB();
            ResetForm();
        }

        // Xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DuAn1Context())
                {
                    if (dataGridView1.SelectedCells.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    var makh = dataGridView1.SelectedCells[0].OwningRow.Cells["maKhachHang"].Value.ToString();

                    int maKh;
                    if (!int.TryParse(makh, out maKh))
                    {
                        MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    var delete = db.KhachHangs.SingleOrDefault(kh => kh.MaKh == maKh);

                    if (delete == null)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    db.KhachHangs.Remove(delete);
                    db.SaveChanges();

                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            LoadDB();
            ResetForm();
        }

        // Tìm kiếm khách hàng theo mã
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var db = new DuAn1Context())
            {
                var keyword = textBox_TK.Text.Trim();

                int maKh;
                if (!int.TryParse(keyword, out maKh))
                {
                    MessageBox.Show("Mã khách hàng phải là số.", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                var data = db.KhachHangs
                    .Where(p => p.MaKh == maKh)
                    .Select(kh => new
                    {
                        maKhachHang = kh.MaKh,
                        tenKhachHang = kh.TenKhachHang,
                        gioiTinh = kh.GioiTinh,
                        diaChi = kh.DiaChi,
                        dienThoai = kh.SoDienThoai,
                        TrangThai = kh.TrangThai ? "Hoạt động" : "Ngừng"
                    })
                    .ToList();

                dataGridView1.DataSource = data;
            }

            textBox_TK.Clear();
        }

        // Reset form về trạng thái ban đầu
        private void ResetForm()
        {
            textBox_MK.Clear();
            textBox_TK.Clear();
            comboBox_GT.SelectedIndex = -1;
            textBox_DC.Clear();
            textBox_DT.Clear();
            textBox_MK.ReadOnly = false;
        }

        private void textBox_M_TextChanged(object sender, EventArgs e)
        {
            // Xử lý nếu cần
        }
    }
}
