namespace PRO131
{
    public partial class Login : Form
    {
        ToolTip toolTip = new ToolTip();
        public Login()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            // Xoá khoảng trắng
            string clean = txtMatKhau.Text.Replace(" ", "");
            if (txtMatKhau.Text != clean)
            {
                int cursor = txtMatKhau.SelectionStart;
                txtMatKhau.Text = clean;
                txtMatKhau.SelectionStart = cursor;
            }

            // Cảnh báo độ dài
            txtMatKhau.BackColor = clean.Length < 6 ? Color.MistyRose : Color.White;

            // Gợi ý độ mạnh
            string strength = "Yếu";
            if (clean.Length >= 8 && clean.Any(char.IsUpper) && clean.Any(char.IsDigit))
                strength = "Mạnh";
            else if (clean.Length >= 6)
                strength = "Trung bình";

            toolTip.SetToolTip(txtMatKhau, $"Độ mạnh mật khẩu: {strength}");
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            string text = txtTenDangNhap.Text.Trim().ToLower();

            // Cập nhật text nếu khác
            if (txtTenDangNhap.Text != text)
            {
                int cursor = txtTenDangNhap.SelectionStart;
                txtTenDangNhap.Text = text;
                txtTenDangNhap.SelectionStart = cursor;
            }

            // Đổi màu nếu độ dài chưa đạt
            txtTenDangNhap.BackColor = text.Length < 3 ? Color.MistyRose : Color.White;
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            try
            {
                string username = txtTenDangNhap.Text.Trim();
                string password = txtMatKhau.Text;

                using (var context = new PRO131.DataContext.DuAn1Context())
                {
                    var account = context.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == username && tk.MatKhau == password);

                    if (account == null)
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNv == account.MaNv);
                    string tenNhanVien = nhanVien?.TenNhanVien ?? "(Không có tên)";

                    var chucVu = nhanVien != null
                        ? context.ChucVus.FirstOrDefault(cv => cv.MaCv == nhanVien.MaCv)
                        : null;

                    string tenChucVu = chucVu?.TenChucVu ?? "(Không có chức vụ)";

                    MessageBox.Show($"Chào mừng: {tenNhanVien} ({tenChucVu})", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập:\n{ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkShowPass.Checked;
        }
    }

}

