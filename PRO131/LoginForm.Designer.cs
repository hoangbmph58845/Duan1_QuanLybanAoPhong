namespace PRO131
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnLogin = new Panel();
            btnForgotPassword = new Button();
            chkShowPass = new CheckBox();
            btnLogin = new Button();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.FromArgb(29, 53, 87);
            pnLogin.Controls.Add(btnForgotPassword);
            pnLogin.Controls.Add(chkShowPass);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(txtMatKhau);
            pnLogin.Controls.Add(label3);
            pnLogin.Controls.Add(txtTenDangNhap);
            pnLogin.Controls.Add(label2);
            pnLogin.Controls.Add(label1);
            pnLogin.Controls.Add(pictureBox1);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.ForeColor = Color.FromArgb(168, 218, 220);
            pnLogin.Location = new Point(0, 0);
            pnLogin.Margin = new Padding(2);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(813, 542);
            pnLogin.TabIndex = 2;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.ForeColor = Color.FromArgb(255, 128, 128);
            btnForgotPassword.Location = new Point(502, 301);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(150, 29);
            btnForgotPassword.TabIndex = 24;
            btnForgotPassword.Text = "Quên mật khẩu ?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(366, 301);
            chkShowPass.Margin = new Padding(2);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(131, 24);
            chkShowPass.TabIndex = 23;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(394, 346);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 42);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(502, 247);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(140, 27);
            txtMatKhau.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 254);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(502, 186);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(140, 27);
            txtTenDangNhap.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 192);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(534, 38);
            label1.TabIndex = 17;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN ÁO PHÔNG";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 150);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 542);
            Controls.Add(pnLogin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogin;
        private Button btnForgotPassword;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}