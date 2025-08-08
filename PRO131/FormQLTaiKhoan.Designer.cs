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
            cboNhanVien = new ComboBox();
            pictureBox1 = new PictureBox();
            btnXoaTK = new Button();
            btnSuaTK = new Button();
            btnTimTK = new Button();
            btnThemTK = new Button();
            cboTrangThaiTK = new ComboBox();
            txtSearchTK = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(143, 157, 178);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnXoaTK);
            panel1.Controls.Add(btnSuaTK);
            panel1.Controls.Add(btnTimTK);
            panel1.Controls.Add(btnThemTK);
            panel1.Controls.Add(cboTrangThaiTK);
            panel1.Controls.Add(txtSearchTK);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(txtMaTK);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 626);
            panel1.TabIndex = 0;
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(142, 52);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(171, 28);
            cboNhanVien.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 411);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnXoaTK
            // 
            btnXoaTK.BackColor = SystemColors.ActiveBorder;
            btnXoaTK.Location = new Point(230, 253);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new Size(83, 27);
            btnXoaTK.TabIndex = 16;
            btnXoaTK.Text = "Xóa";
            btnXoaTK.UseVisualStyleBackColor = false;
            btnXoaTK.Click += btnXoaTK_Click;
            // 
            // btnSuaTK
            // 
            btnSuaTK.BackColor = SystemColors.ActiveBorder;
            btnSuaTK.Location = new Point(120, 253);
            btnSuaTK.Name = "btnSuaTK";
            btnSuaTK.Size = new Size(83, 27);
            btnSuaTK.TabIndex = 17;
            btnSuaTK.Text = "Sửa";
            btnSuaTK.UseVisualStyleBackColor = false;
            btnSuaTK.Click += btnSuaTK_Click;
            // 
            // btnTimTK
            // 
            btnTimTK.BackColor = SystemColors.ActiveBorder;
            btnTimTK.Location = new Point(18, 315);
            btnTimTK.Name = "btnTimTK";
            btnTimTK.Size = new Size(83, 27);
            btnTimTK.TabIndex = 18;
            btnTimTK.Text = "Tìm kiếm";
            btnTimTK.UseVisualStyleBackColor = false;
            btnTimTK.Click += btnTimTK_Click;
            // 
            // btnThemTK
            // 
            btnThemTK.BackColor = SystemColors.ActiveBorder;
            btnThemTK.Location = new Point(18, 253);
            btnThemTK.Name = "btnThemTK";
            btnThemTK.Size = new Size(83, 27);
            btnThemTK.TabIndex = 19;
            btnThemTK.Text = "Thêm";
            btnThemTK.UseVisualStyleBackColor = false;
            btnThemTK.Click += btnThemTK_Click;
            // 
            // cboTrangThaiTK
            // 
            cboTrangThaiTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThaiTK.FormattingEnabled = true;
            cboTrangThaiTK.Items.AddRange(new object[] { "", "Hoạt Động", "Dừng Hoạt Động" });
            cboTrangThaiTK.Location = new Point(142, 186);
            cboTrangThaiTK.Name = "cboTrangThaiTK";
            cboTrangThaiTK.Size = new Size(171, 28);
            cboTrangThaiTK.TabIndex = 15;
            // 
            // txtSearchTK
            // 
            txtSearchTK.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTK.Location = new Point(120, 315);
            txtSearchTK.Name = "txtSearchTK";
            txtSearchTK.Size = new Size(193, 27);
            txtSearchTK.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(142, 142);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(171, 27);
            txtMatKhau.TabIndex = 11;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(142, 96);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(171, 27);
            txtTenDangNhap.TabIndex = 12;
            // 
            // txtMaTK
            // 
            txtMaTK.BorderStyle = BorderStyle.FixedSingle;
            txtMaTK.Location = new Point(142, 10);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(171, 27);
            txtMaTK.TabIndex = 14;
            txtMaTK.TextChanged += txtMaTK_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 194);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 5;
            label5.Text = "Trang thái :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 149);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 103);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "Mã nhân viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã tài khoản :";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTaiKhoan.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(348, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.Size = new Size(716, 626);
            dgvTaiKhoan.TabIndex = 2;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnXoaTK;
        private Button btnSuaTK;
        private Button btnTimTK;
        private Button btnThemTK;
        private ComboBox cboTrangThaiTK;
        private TextBox txtSearchTK;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMaTK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvTaiKhoan;
        private ComboBox cboNhanVien;
    }
}