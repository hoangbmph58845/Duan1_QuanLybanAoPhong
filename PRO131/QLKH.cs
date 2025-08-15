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
            radioButton_TT.Checked = true;
            comboBox_GT.Text = "Nam";

            textBox_TIMk.TextChanged += tb_timkiem_TextChanged; // gán tìm kiếm realtime
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string sql = @"
                    SELECT * FROM KhachHang
                    WHERE (@keyword = '' 
                        OR MaKH LIKE @kw 
                        OR TenKhachHang LIKE @kw
                        OR SoDienThoai LIKE @kw
                        OR GioiTinh LIKE @kw
                        OR DiaChi LIKE @kw)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                    }

                    // Thêm cột hiển thị trạng thái dạng chữ
                    if (!dt.Columns.Contains("TrangThaiText"))
                        dt.Columns.Add("TrangThaiText", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        int trangThai = Convert.ToInt32(row["TrangThai"]);
                        row["TrangThaiText"] = trangThai == 1 ? "Thường xuyên" : "Không thường xuyên";
                    }

                    dataGridView1.DataSource = dt;

                    // Ẩn cột trạng thái gốc
                    if (dataGridView1.Columns.Contains("TrangThai"))
                        dataGridView1.Columns["TrangThai"].Visible = false;

                    // Đặt tiêu đề cột
                    RenameColumn("MaKH", "Mã khách hàng");
                    RenameColumn("TenKhachHang", "Tên khách hàng");
                    RenameColumn("GioiTinh", "Giới tính");
                    RenameColumn("SoDienThoai", "Số điện thoại");
                    RenameColumn("DiaChi", "Địa chỉ");
                   
                    RenameColumn("TrangThaiText", "Trạng thái");
                }
            }
        }

        private void RenameColumn(string columnName, string headerText)
        {
            if (dataGridView1.Columns.Contains(columnName))
                dataGridView1.Columns[columnName].HeaderText = headerText;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox_MK.Text = row.Cells["MaKH"]?.Value?.ToString() ?? "";
                textBox_TK.Text = row.Cells["TenKhachHang"]?.Value?.ToString() ?? "";
                comboBox_GT.Text = row.Cells["GioiTinh"]?.Value?.ToString() ?? "";
                textBox_SDT.Text = row.Cells["SoDienThoai"]?.Value?.ToString() ?? "";
                textBox_DC.Text = row.Cells["DiaChi"]?.Value?.ToString() ?? "";

                object value = row.Cells["TrangThai"].Value;
                if (value != DBNull.Value)
                {
                    bool trangThai = Convert.ToBoolean(value);
                    radioButton_TT.Checked = trangThai;
                    radioButton__TT2.Checked = !trangThai;
                }
                else
                {
                    radioButton_TT.Checked = false;
                    radioButton__TT2.Checked = true;
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                bool trangThai = radioButton_TT.Checked;
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string sql = "INSERT INTO KhachHang(TenKhachHang, SoDienThoai, GioiTinh, DiaChi, TrangThai) " +
                                 "VALUES (@TenKhachHang, @SoDienThoai, @GioiTinh, @DiaChi, @TrangThai)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TK.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", textBox_SDT.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBox_GT.Text);
                        
                        cmd.Parameters.AddWithValue("@DiaChi", textBox_DC.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                bool trangThai = radioButton_TT.Checked;
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string sql = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, SoDienThoai = @SoDienThoai, GioiTinh = @GioiTinh, " +
                                 "DiaChi = @DiaChi, TrangThai = @TrangThai WHERE MaKH = @MaKH";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", textBox_MK.Text);
                        cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TK.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", textBox_SDT.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBox_GT.Text);
                      
                        cmd.Parameters.AddWithValue("@DiaChi", textBox_DC.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            textBox_MK.Clear();
            textBox_TK.Clear();
            textBox_SDT.Clear();
            textBox_DC.Clear();
            comboBox_GT.Text = "Nam";
            radioButton_TT.Checked = true;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox_TK.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.");
                textBox_TK.Focus();
                return false;
            }
            if (Regex.IsMatch(textBox_TK.Text, @"\d"))
            {
                MessageBox.Show("Tên khách hàng không được chứa số.");
                textBox_TK.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBox_GT.Text))
            {
                MessageBox.Show("Giới tính không được để trống.");
                comboBox_GT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_SDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.");
                textBox_SDT.Focus();
                return false;
            }
            string sdt = textBox_SDT.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số.");
                textBox_SDT.Focus();
                return false;
            }
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số.");
                textBox_SDT.Focus();
                return false;
            }
            return true;
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox_TIMk.Text.Trim());
        }
    }
}
