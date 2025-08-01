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
            pnLogin = new Panel();
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
            pnLogin.Controls.Add(chkShowPass);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(txtMatKhau);
            pnLogin.Controls.Add(label3);
            pnLogin.Controls.Add(txtTenDangNhap);
            pnLogin.Controls.Add(label2);
            pnLogin.Controls.Add(label1);
            pnLogin.Controls.Add(pictureBox1);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(914, 733);
            pnLogin.TabIndex = 0;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(538, 450);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(153, 29);
            chkShowPass.TabIndex = 23;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(538, 505);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(319, 34);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(696, 386);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(150, 31);
            txtMatKhau.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 386);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(696, 288);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(150, 31);
            txtTenDangNhap.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 291);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 193);
            label1.Name = "label1";
            label1.Size = new Size(593, 45);
            label1.TabIndex = 17;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN ÁO PHÔNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 288);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 733);
            Controls.Add(pnLogin);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogin;
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
