namespace PRO131
{
    partial class FormQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnTim = new Button();
            btnThem = new Button();
            dtNgaySinh = new DateTimePicker();
            cboTrangThai = new ComboBox();
            cboChucVu = new ComboBox();
            cboGioiTinh = new ComboBox();
            txtSearch = new TextBox();
            txtSoDT = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // txtTenNV
            // 
            txtTenNV.BorderStyle = BorderStyle.FixedSingle;
            txtTenNV.Location = new Point(349, -51);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(205, 27);
            txtTenNV.TabIndex = 15;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Location = new Point(349, -93);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(205, 27);
            txtMaNV.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, -44);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, -86);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã nhân viên : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(143, 157, 178);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dtNgaySinh);
            panel1.Controls.Add(cboTrangThai);
            panel1.Controls.Add(cboChucVu);
            panel1.Controls.Add(cboGioiTinh);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(txtSoDT);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 662);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 47;
            label7.Text = "Trạng thái : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 253);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 46;
            label6.Text = "Chức vụ : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 200);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 45;
            label5.Text = "Số điện thoại : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 466);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.Location = new Point(239, 341);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 44;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveBorder;
            btnSua.Location = new Point(119, 341);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 43;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = SystemColors.ActiveBorder;
            btnTim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(8, 394);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(105, 41);
            btnTim.TabIndex = 42;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveBorder;
            btnThem.Location = new Point(8, 341);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 41;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(119, 102);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(205, 27);
            dtNgaySinh.TabIndex = 40;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm", "Nghỉ làm" });
            cboTrangThai.Location = new Point(119, 289);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(130, 28);
            cboTrangThai.TabIndex = 39;
            cboTrangThai.SelectedIndexChanged += cboTrangThai_SelectedIndexChanged;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "", "Quản lí", "Nhân viên" });
            cboChucVu.Location = new Point(119, 245);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(130, 28);
            cboChucVu.TabIndex = 38;
            cboChucVu.SelectedIndexChanged += cboChucVu_SelectedIndexChanged;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(119, 60);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(130, 28);
            cboGioiTinh.TabIndex = 37;
            cboGioiTinh.SelectedIndexChanged += cboGioiTinh_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(119, 403);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 36;
            // 
            // txtSoDT
            // 
            txtSoDT.BorderStyle = BorderStyle.FixedSingle;
            txtSoDT.Location = new Point(119, 193);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(205, 27);
            txtSoDT.TabIndex = 35;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(119, 19);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(205, 27);
            txtHoTen.TabIndex = 34;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(119, 146);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(205, 27);
            txtDiaChi.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 153);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 28;
            label4.Text = "Địa chỉ : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 109);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 28;
            label9.Text = "Ngày sinh : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 26);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 28;
            label8.Text = "Họ Tên : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 68);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 28;
            label3.Text = "Giới tính : ";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(339, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(778, 659);
            dgvNhanVien.TabIndex = 17;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // FormQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dgvNhanVien);
            Controls.Add(panel1);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQLNhanVien";
            Size = new Size(1120, 662);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTim;
        private Button btnThem;
        private DateTimePicker dtNgaySinh;
        private ComboBox cboTrangThai;
        private ComboBox cboChucVu;
        private ComboBox cboGioiTinh;
        private TextBox txtSearch;
        private TextBox txtSoDT;
        private TextBox txtDiaChi;
        private Label label3;
        private DataGridView dgvNhanVien;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtHoTen;
        private Label label8;
    }
}