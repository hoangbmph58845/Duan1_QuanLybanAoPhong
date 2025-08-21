using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QLKH : UserControl
    {
        private readonly string str =
            "Data Source=DESKTOP-9MI2RPM;Initial Catalog=DuAn_1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public QLKH()
        {
            InitializeComponent();
            this.Load += QLKH_Load;

            // ComboBox Giới tính
            comboBox_GT.Items.Clear();
            comboBox_GT.Items.AddRange(new string[] { "Nam", "Nữ" });
            comboBox_GT.SelectedIndex = 0;

            // RadioButton mặc định
            radioButton_TX.Checked = true;

            // Tìm kiếm realtime
            textBox_TK.TextChanged += Tb_TimKiem_TextChanged;

            // Button tìm kiếm
            button_TK.Click += Bt_TimKiem_Click;

            // Sự kiện click DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Button CRUD
            button_Them.Click += Bt_Them_Click;
            button_Sua.Click += Bt_Sua_Click;
            button_Xoa.Click += Bt_Xoa_Click;
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load dữ liệu khách hàng, có tìm kiếm
        private void LoadData(string keyword = "")
        {
            try
            {
                using SqlConnection con = new SqlConnection(str);
                con.Open();

                string sql = @"
                    SELECT * FROM KhachHang
                    WHERE (@keyword = '' 
                        OR MaKH LIKE @kw 
                        OR TenKhachHang LIKE @kw
                        OR SoDienThoai LIKE @kw
                        OR GioiTinh LIKE @kw
                        OR DiaChi LIKE @kw)";

                using SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (!dt.Columns.Contains("TrangThaiText"))
                    dt.Columns.Add("TrangThaiText", typeof(string));

                foreach (DataRow row in dt.Rows)
                    row["TrangThaiText"] = Convert.ToBoolean(row["TrangThai"]) ? "Thường xuyên" : "Không thường xuyên";

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("TrangThai"))
                    dataGridView1.Columns["TrangThai"].Visible = false;

                RenameColumn("MaKH", "Mã khách hàng");
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

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox_MK.Text = row.Cells["MaKH"]?.Value?.ToString() ?? "";
            textBox_T.Text = row.Cells["TenKhachHang"]?.Value?.ToString() ?? "";

            // Sửa ComboBox Giới tính để chọn đúng item
            string gt = row.Cells["GioiTinh"]?.Value?.ToString() ?? "Nam";
            if (gt == "Nam")
                comboBox_GT.SelectedIndex = 0;
            else if (gt == "Nữ")
                comboBox_GT.SelectedIndex = 1;
            else
                comboBox_GT.SelectedIndex = 0;

            textBox_DT.Text = row.Cells["SoDienThoai"]?.Value?.ToString() ?? "";
            textBox_DC.Text = row.Cells["DiaChi"]?.Value?.ToString() ?? "";

            bool trangThai = row.Cells["TrangThai"]?.Value != DBNull.Value && Convert.ToBoolean(row.Cells["TrangThai"].Value);
            radioButton_TX.Checked = trangThai;
            radioButton_KTX.Checked = !trangThai;
        }

        private void Bt_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(false)) return;

            try
            {
                bool trangThai = radioButton_TX.Checked;
                using SqlConnection con = new SqlConnection(str);
                con.Open();

                string sql = @"INSERT INTO KhachHang(TenKhachHang, SoDienThoai, GioiTinh, DiaChi, TrangThai) 
                               VALUES (@TenKhachHang, @SoDienThoai, @GioiTinh, @DiaChi, @TrangThai)";

                using SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_T.Text.Trim());
                cmd.Parameters.AddWithValue("@SoDienThoai", textBox_DT.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_GT.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DiaChi", textBox_DC.Text.Trim());
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void Bt_Sua_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(true)) return;

            try
            {
                bool trangThai = radioButton_TX.Checked;
                using SqlConnection con = new SqlConnection(str);
                con.Open();

                string sql = @"UPDATE KhachHang 
                               SET TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, GioiTinh=@GioiTinh, DiaChi=@DiaChi, TrangThai=@TrangThai 
                               WHERE MaKH=@MaKH";

                using SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaKH", textBox_MK.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_T.Text.Trim());
                cmd.Parameters.AddWithValue("@SoDienThoai", textBox_DT.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_GT.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DiaChi", textBox_DC.Text.Trim());
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message);
            }
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MK.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    using SqlConnection con = new SqlConnection(str);
                    con.Open();

                    string sql = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
                    using SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaKH", textBox_MK.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                    }
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

            string gioiTinh = comboBox_GT.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(gioiTinh) || (gioiTinh != "Nam" && gioiTinh != "Nữ"))
            {
                MessageBox.Show("Giới tính phải là Nam hoặc Nữ.");
                comboBox_GT.Focus();
                return false;
            }

            string sdt = textBox_DT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống.");
                textBox_DT.Focus();
                return false;
            }
            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
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

            if (!isEdit && IsPhoneExists(sdt))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại.");
                textBox_DT.Focus();
                return false;
            }

            if (isEdit && IsPhoneExists(sdt, textBox_MK.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại với khách hàng khác.");
                textBox_DT.Focus();
                return false;
            }

            return true;
        }

        private bool IsPhoneExists(string sdt, string maKH = "")
        {
            using SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai=@sdt";
            if (!string.IsNullOrEmpty(maKH))
                sql += " AND MaKH<>@MaKH";

            using SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            if (!string.IsNullOrEmpty(maKH))
                cmd.Parameters.AddWithValue("@MaKH", maKH);

            return (int)cmd.ExecuteScalar() > 0;
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
