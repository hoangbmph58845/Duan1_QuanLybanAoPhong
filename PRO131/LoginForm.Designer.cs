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
            pnLogin.Size = new Size(1016, 678);
            pnLogin.TabIndex = 2;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.ForeColor = Color.FromArgb(255, 128, 128);
            btnForgotPassword.Location = new Point(627, 376);
            btnForgotPassword.Margin = new Padding(4);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(188, 36);
            btnForgotPassword.TabIndex = 24;
            btnForgotPassword.Text = "Quên mật khẩu ?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(457, 376);
            chkShowPass.Margin = new Padding(2);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(158, 29);
            chkShowPass.TabIndex = 23;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(493, 433);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(182, 52);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(627, 309);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(174, 31);
            txtMatKhau.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 318);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(627, 232);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(174, 31);
            txtTenDangNhap.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(457, 240);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(630, 45);
            label1.TabIndex = 17;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN ÁO PHÔNG";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 188);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 678);
            Controls.Add(pnLogin);
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