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
            label10 = new Label();
            panel2 = new Panel();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnTim = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtSearch = new TextBox();
            dgvNhanVien = new DataGridView();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtNgaySinh = new DateTimePicker();
            cboTrangThai = new ComboBox();
            cboChucVu = new ComboBox();
            cboGioiTinh = new ComboBox();
            txtSoDT = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 659);
            panel1.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 255, 209);
            label10.Location = new Point(27, 562);
            label10.Name = "label10";
            label10.Size = new Size(289, 38);
            label10.TabIndex = 50;
            label10.Text = "Danh sách nhân viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 180, 219);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnTim);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(12, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 162);
            panel2.TabIndex = 49;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(168, 230, 207);
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(244, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(55, 66);
            btnLamMoi.TabIndex = 49;
            btnLamMoi.Text = "Load";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(168, 230, 207);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(165, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(55, 66);
            btnSua.TabIndex = 50;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(160, 231, 229);
            btnTim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(5, 110);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(96, 36);
            btnTim.TabIndex = 48;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 230, 207);
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(82, 16);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(56, 66);
            btnLuu.TabIndex = 46;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 230, 207);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(5, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(55, 66);
            btnThem.TabIndex = 47;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(112, 117);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 27);
            txtSearch.TabIndex = 45;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(339, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(778, 659);
            dgvNhanVien.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(205, 180, 219);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtNgaySinh);
            panel3.Controls.Add(cboTrangThai);
            panel3.Controls.Add(cboChucVu);
            panel3.Controls.Add(cboGioiTinh);
            panel3.Controls.Add(txtSoDT);
            panel3.Controls.Add(txtHoTen);
            panel3.Controls.Add(txtDiaChi);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 348);
            panel3.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 293);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 61;
            label7.Text = "Trạng thái : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 249);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 60;
            label6.Text = "Chức vụ : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 196);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 59;
            label5.Text = "Số ĐT : ";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new Point(108, 103);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(196, 27);
            dtNgaySinh.TabIndex = 58;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm", "Nghỉ làm" });
            cboTrangThai.Location = new Point(108, 290);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(130, 28);
            cboTrangThai.TabIndex = 57;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lí", "Nhân viên" });
            cboChucVu.Location = new Point(108, 246);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(130, 28);
            cboChucVu.TabIndex = 56;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(108, 61);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(130, 28);
            cboGioiTinh.TabIndex = 55;
            // 
            // txtSoDT
            // 
            txtSoDT.BorderStyle = BorderStyle.FixedSingle;
            txtSoDT.Location = new Point(108, 194);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(196, 27);
            txtSoDT.TabIndex = 54;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(108, 20);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(196, 27);
            txtHoTen.TabIndex = 52;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(108, 147);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(196, 27);
            txtDiaChi.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 48;
            label4.Text = "Địa chỉ : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 105);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 49;
            label9.Text = "Ngày sinh : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 22);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 50;
            label8.Text = "Họ Tên : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 51;
            label3.Text = "Giới tính : ";
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
            Size = new Size(1117, 659);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvNhanVien;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtNgaySinh;
        private ComboBox cboTrangThai;
        private ComboBox cboChucVu;
        private ComboBox cboGioiTinh;
        private TextBox txtSoDT;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label3;
        private Panel panel2;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnTim;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtSearch;
        private Label label10;
    }
}