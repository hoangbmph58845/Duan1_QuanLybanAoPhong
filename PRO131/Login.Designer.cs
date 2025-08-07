namespace PRO131
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tlpLogin = new TableLayoutPanel();
            chkShowPass = new CheckBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnForgotPassword = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tlpLogin, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1338, 733);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 729);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // tlpLogin
            // 
            tlpLogin.BackColor = Color.FromArgb(29, 53, 87);
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpLogin.Controls.Add(chkShowPass, 0, 3);
            tlpLogin.Controls.Add(txtMatKhau, 1, 2);
            tlpLogin.Controls.Add(label3, 0, 2);
            tlpLogin.Controls.Add(txtTenDangNhap, 1, 1);
            tlpLogin.Controls.Add(label2, 0, 1);
            tlpLogin.Controls.Add(label1, 0, 0);
            tlpLogin.Controls.Add(btnLogin, 0, 5);
            tlpLogin.Controls.Add(btnForgotPassword, 1, 3);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.ForeColor = Color.FromArgb(168, 218, 220);
            tlpLogin.Location = new Point(672, 3);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 6;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.Size = new Size(663, 727);
            tlpLogin.TabIndex = 18;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Dock = DockStyle.Fill;
            chkShowPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(2, 306);
            chkShowPass.Margin = new Padding(2);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(194, 126);
            chkShowPass.TabIndex = 24;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.TextChanged += chkShowPass_CheckedChanged_1;
            // 
            // txtMatKhau
            // 
            tlpLogin.SetColumnSpan(txtMatKhau, 2);
            txtMatKhau.Dock = DockStyle.Fill;
            txtMatKhau.Location = new Point(200, 219);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(461, 31);
            txtMatKhau.TabIndex = 22;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 217);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 21;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            tlpLogin.SetColumnSpan(txtTenDangNhap, 2);
            txtTenDangNhap.Dock = DockStyle.Fill;
            txtTenDangNhap.Location = new Point(200, 89);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(461, 31);
            txtTenDangNhap.TabIndex = 20;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 19;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            tlpLogin.SetColumnSpan(label1, 3);
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(630, 45);
            label1.TabIndex = 18;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN ÁO PHÔNG";
            // 
            // btnLogin
            // 
            tlpLogin.SetColumnSpan(btnLogin, 3);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(2, 581);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(659, 144);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_2;
            // 
            // btnForgotPassword
            // 
            tlpLogin.SetColumnSpan(btnForgotPassword, 2);
            btnForgotPassword.Dock = DockStyle.Fill;
            btnForgotPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = Color.FromArgb(255, 128, 128);
            btnForgotPassword.Location = new Point(202, 308);
            btnForgotPassword.Margin = new Padding(4);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(457, 122);
            btnForgotPassword.TabIndex = 25;
            btnForgotPassword.Text = "Quên mật khẩu ?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 733);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlpLogin;
        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private Label label3;
        private TextBox txtMatKhau;
        private CheckBox chkShowPass;
        private Button btnForgotPassword;
        private Button btnLogin;
    }
}
