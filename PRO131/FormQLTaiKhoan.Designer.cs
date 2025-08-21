namespace PRO131
{
    partial class FormQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLTaiKhoan));
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            btnLuuTK = new Button();
            btnLamMoi = new Button();
            btnSuaTK = new Button();
            btnTimTK = new Button();
            btnThemTK = new Button();
            txtSearchTK = new TextBox();
            panel3 = new Panel();
            cboNhanVien = new ComboBox();
            txtEmail = new TextBox();
            label = new Label();
            cboTrangThaiTK = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMaTK = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvTaiKhoan = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(143, 157, 178);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 626);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 255, 209);
            label10.Location = new Point(42, 522);
            label10.Name = "label10";
            label10.Size = new Size(250, 38);
            label10.TabIndex = 51;
            label10.Text = "Quản lý tài khoản";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 180, 219);
            panel2.Controls.Add(btnLuuTK);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSuaTK);
            panel2.Controls.Add(btnTimTK);
            panel2.Controls.Add(btnThemTK);
            panel2.Controls.Add(txtSearchTK);
            panel2.Location = new Point(17, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 153);
            panel2.TabIndex = 24;
            // 
            // btnLuuTK
            // 
            btnLuuTK.BackColor = Color.FromArgb(168, 230, 207);
            btnLuuTK.Image = (Image)resources.GetObject("btnLuuTK.Image");
            btnLuuTK.Location = new Point(88, 16);
            btnLuuTK.Name = "btnLuuTK";
            btnLuuTK.Size = new Size(63, 66);
            btnLuuTK.TabIndex = 21;
            btnLuuTK.Text = "Lưu";
            btnLuuTK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLuuTK.UseVisualStyleBackColor = false;
            btnLuuTK.Click += btnLuuTK_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(168, 230, 207);
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(233, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(58, 66);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Load";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSuaTK
            // 
            btnSuaTK.BackColor = Color.FromArgb(168, 230, 207);
            btnSuaTK.Image = (Image)resources.GetObject("btnSuaTK.Image");
            btnSuaTK.Location = new Point(157, 16);
            btnSuaTK.Name = "btnSuaTK";
            btnSuaTK.Size = new Size(60, 66);
            btnSuaTK.TabIndex = 23;
            btnSuaTK.Text = "Sửa";
            btnSuaTK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSuaTK.UseVisualStyleBackColor = false;
            btnSuaTK.Click += btnSuaTK_Click;
            // 
            // btnTimTK
            // 
            btnTimTK.BackColor = Color.FromArgb(168, 230, 207);
            btnTimTK.Image = (Image)resources.GetObject("btnTimTK.Image");
            btnTimTK.Location = new Point(25, 93);
            btnTimTK.Name = "btnTimTK";
            btnTimTK.Size = new Size(67, 50);
            btnTimTK.TabIndex = 24;
            btnTimTK.Text = "Tìm";
            btnTimTK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTimTK.UseVisualStyleBackColor = false;
            btnTimTK.Click += btnTimTK_Click;
            // 
            // btnThemTK
            // 
            btnThemTK.BackColor = Color.FromArgb(168, 230, 207);
            btnThemTK.Image = (Image)resources.GetObject("btnThemTK.Image");
            btnThemTK.Location = new Point(14, 16);
            btnThemTK.Name = "btnThemTK";
            btnThemTK.Size = new Size(68, 66);
            btnThemTK.TabIndex = 25;
            btnThemTK.Text = "Thêm";
            btnThemTK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThemTK.UseVisualStyleBackColor = false;
            btnThemTK.Click += btnThemTK_Click;
            // 
            // txtSearchTK
            // 
            txtSearchTK.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTK.Location = new Point(98, 106);
            txtSearchTK.Name = "txtSearchTK";
            txtSearchTK.Size = new Size(193, 27);
            txtSearchTK.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(205, 180, 219);
            panel3.Controls.Add(cboNhanVien);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label);
            panel3.Controls.Add(cboTrangThaiTK);
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(txtTenDangNhap);
            panel3.Controls.Add(txtMaTK);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 306);
            panel3.TabIndex = 25;
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(138, 66);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(153, 28);
            cboNhanVien.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(138, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 27);
            txtEmail.TabIndex = 33;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(14, 259);
            label.Name = "label";
            label.Size = new Size(53, 20);
            label.TabIndex = 32;
            label.Text = "Email :";
            // 
            // cboTrangThaiTK
            // 
            cboTrangThaiTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThaiTK.FormattingEnabled = true;
            cboTrangThaiTK.Items.AddRange(new object[] { "Hoạt Động", "Dừng Hoạt Động" });
            cboTrangThaiTK.Location = new Point(138, 205);
            cboTrangThaiTK.Name = "cboTrangThaiTK";
            cboTrangThaiTK.Size = new Size(153, 28);
            cboTrangThaiTK.TabIndex = 31;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(138, 156);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(153, 27);
            txtMatKhau.TabIndex = 28;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(138, 110);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(153, 27);
            txtTenDangNhap.TabIndex = 29;
            // 
            // txtMaTK
            // 
            txtMaTK.BorderStyle = BorderStyle.FixedSingle;
            txtMaTK.Location = new Point(138, 24);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(153, 27);
            txtMaTK.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 208);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 23;
            label5.Text = "Trang thái :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 163);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 24;
            label4.Text = "Mật khẩu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 117);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 25;
            label3.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 26;
            label2.Text = "Mã nhân viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 27;
            label1.Text = "Mã tài khoản :";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(348, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(716, 626);
            dgvTaiKhoan.TabIndex = 2;
            // 
            // FormQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTaiKhoan);
            Controls.Add(panel1);
            Name = "FormQLTaiKhoan";
            Size = new Size(1064, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvTaiKhoan;
        private Panel panel2;
        private Button btnLuuTK;
        private Button btnLamMoi;
        private Button btnSuaTK;
        private Button btnTimTK;
        private Button btnThemTK;
        private TextBox txtSearchTK;
        private Panel panel3;
        private ComboBox cboNhanVien;
        private TextBox txtEmail;
        private Label label;
        private ComboBox cboTrangThaiTK;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMaTK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}