namespace PRO131
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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

    
    }   
}

