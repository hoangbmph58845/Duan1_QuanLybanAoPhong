namespace PRO131
{
    partial class UCDanhSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDsChiTietHoaDon = new DataGridView();
            gbChiTietSP = new GroupBox();
            label3 = new Label();
            cboMau = new ComboBox();
            txtGiaNhap = new TextBox();
            cboSize = new ComboBox();
            numericUpDownSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            btnXoaCT = new Button();
            txtGiaBan = new TextBox();
            btnSuaCT = new Button();
            btnThemCT = new Button();
            lblGiaBan = new Label();
            lblGiaNhap = new Label();
            lblMaHangHoa = new Label();
            lblTenHangHoa = new Label();
            gbThongTinSP = new GroupBox();
            lblPhieuBanHang = new Label();
            cboLoaiSP = new ComboBox();
            label1 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtNgayTao = new TextBox();
            lblNgayTao = new Label();
            txtMaHoaDon = new TextBox();
            lblMaHoaDon = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).BeginInit();
            gbChiTietSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            gbThongTinSP.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDsChiTietHoaDon, 0, 1);
            tableLayoutPanel1.Controls.Add(gbChiTietSP, 1, 0);
            tableLayoutPanel1.Controls.Add(gbThongTinSP, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1108, 769);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDsChiTietHoaDon
            // 
            dgvDsChiTietHoaDon.AllowUserToAddRows = false;
            dgvDsChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvDsChiTietHoaDon.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvDsChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvDsChiTietHoaDon, 2);
            dgvDsChiTietHoaDon.Dock = DockStyle.Fill;
            dgvDsChiTietHoaDon.Location = new Point(4, 388);
            dgvDsChiTietHoaDon.Margin = new Padding(4);
            dgvDsChiTietHoaDon.Name = "dgvDsChiTietHoaDon";
            dgvDsChiTietHoaDon.ReadOnly = true;
            dgvDsChiTietHoaDon.RowHeadersWidth = 51;
            dgvDsChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsChiTietHoaDon.Size = new Size(1100, 377);
            dgvDsChiTietHoaDon.TabIndex = 15;
            dgvDsChiTietHoaDon.CellClick += dgvDsChiTietHoaDon_CellClick;
            // 
            // gbChiTietSP
            // 
            gbChiTietSP.BackColor = Color.FromArgb(241, 250, 238);
            gbChiTietSP.Controls.Add(label3);
            gbChiTietSP.Controls.Add(cboMau);
            gbChiTietSP.Controls.Add(txtGiaNhap);
            gbChiTietSP.Controls.Add(cboSize);
            gbChiTietSP.Controls.Add(numericUpDownSoLuong);
            gbChiTietSP.Controls.Add(lblSoLuong);
            gbChiTietSP.Controls.Add(btnXoaCT);
            gbChiTietSP.Controls.Add(txtGiaBan);
            gbChiTietSP.Controls.Add(btnSuaCT);
            gbChiTietSP.Controls.Add(btnThemCT);
            gbChiTietSP.Controls.Add(lblGiaBan);
            gbChiTietSP.Controls.Add(lblGiaNhap);
            gbChiTietSP.Controls.Add(lblMaHangHoa);
            gbChiTietSP.Controls.Add(lblTenHangHoa);
            gbChiTietSP.Dock = DockStyle.Fill;
            gbChiTietSP.ForeColor = Color.FromArgb(29, 53, 87);
            gbChiTietSP.Location = new Point(558, 4);
            gbChiTietSP.Margin = new Padding(4);
            gbChiTietSP.Name = "gbChiTietSP";
            gbChiTietSP.Padding = new Padding(4);
            gbChiTietSP.Size = new Size(546, 376);
            gbChiTietSP.TabIndex = 14;
            gbChiTietSP.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(163, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 32);
            label3.TabIndex = 49;
            label3.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // cboMau
            // 
            cboMau.FormattingEnabled = true;
            cboMau.Location = new Point(191, 92);
            cboMau.Name = "cboMau";
            cboMau.Size = new Size(309, 33);
            cboMau.TabIndex = 8;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(192, 182);
            txtGiaNhap.Margin = new Padding(4);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(308, 31);
            txtGiaNhap.TabIndex = 7;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(192, 138);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(309, 33);
            cboSize.TabIndex = 6;
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Location = new Point(189, 275);
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(308, 31);
            numericUpDownSoLuong.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(67, 275);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(89, 25);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng";
            // 
            // btnXoaCT
            // 
            btnXoaCT.Location = new Point(364, 332);
            btnXoaCT.Margin = new Padding(4);
            btnXoaCT.Name = "btnXoaCT";
            btnXoaCT.Size = new Size(118, 36);
            btnXoaCT.TabIndex = 3;
            btnXoaCT.Text = "Xóa";
            btnXoaCT.UseVisualStyleBackColor = true;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(192, 221);
            txtGiaBan.Margin = new Padding(4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(308, 31);
            txtGiaBan.TabIndex = 1;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(228, 332);
            btnSuaCT.Margin = new Padding(4);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(118, 36);
            btnSuaCT.TabIndex = 3;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            // 
            // btnThemCT
            // 
            btnThemCT.Location = new Point(87, 332);
            btnThemCT.Margin = new Padding(4);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(118, 36);
            btnThemCT.TabIndex = 3;
            btnThemCT.Text = "Thêm";
            btnThemCT.UseVisualStyleBackColor = true;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(67, 227);
            lblGiaBan.Margin = new Padding(4, 0, 4, 0);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(72, 25);
            lblGiaBan.TabIndex = 0;
            lblGiaBan.Text = "Giá bán";
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.AutoSize = true;
            lblGiaNhap.Location = new Point(67, 188);
            lblGiaNhap.Margin = new Padding(4, 0, 4, 0);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(82, 25);
            lblGiaNhap.TabIndex = 0;
            lblGiaNhap.Text = "Giá nhập";
            // 
            // lblMaHangHoa
            // 
            lblMaHangHoa.AutoSize = true;
            lblMaHangHoa.Location = new Point(70, 106);
            lblMaHangHoa.Margin = new Padding(4, 0, 4, 0);
            lblMaHangHoa.Name = "lblMaHangHoa";
            lblMaHangHoa.Size = new Size(47, 25);
            lblMaHangHoa.TabIndex = 0;
            lblMaHangHoa.Text = "Màu";
            // 
            // lblTenHangHoa
            // 
            lblTenHangHoa.AutoSize = true;
            lblTenHangHoa.Location = new Point(67, 147);
            lblTenHangHoa.Margin = new Padding(4, 0, 4, 0);
            lblTenHangHoa.Name = "lblTenHangHoa";
            lblTenHangHoa.Size = new Size(43, 25);
            lblTenHangHoa.TabIndex = 0;
            lblTenHangHoa.Text = "Size";
            // 
            // gbThongTinSP
            // 
            gbThongTinSP.BackColor = Color.FromArgb(241, 250, 238);
            gbThongTinSP.Controls.Add(lblPhieuBanHang);
            gbThongTinSP.Controls.Add(cboLoaiSP);
            gbThongTinSP.Controls.Add(label1);
            gbThongTinSP.Controls.Add(btnLamMoi);
            gbThongTinSP.Controls.Add(btnXoa);
            gbThongTinSP.Controls.Add(btnSua);
            gbThongTinSP.Controls.Add(btnThem);
            gbThongTinSP.Controls.Add(txtNgayTao);
            gbThongTinSP.Controls.Add(lblNgayTao);
            gbThongTinSP.Controls.Add(txtMaHoaDon);
            gbThongTinSP.Controls.Add(lblMaHoaDon);
            gbThongTinSP.Dock = DockStyle.Fill;
            gbThongTinSP.ForeColor = Color.FromArgb(29, 53, 87);
            gbThongTinSP.Location = new Point(4, 4);
            gbThongTinSP.Margin = new Padding(4);
            gbThongTinSP.Name = "gbThongTinSP";
            gbThongTinSP.Padding = new Padding(4);
            gbThongTinSP.Size = new Size(546, 376);
            gbThongTinSP.TabIndex = 12;
            gbThongTinSP.TabStop = false;
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = Color.SteelBlue;
            lblPhieuBanHang.Location = new Point(138, 28);
            lblPhieuBanHang.Margin = new Padding(4, 0, 4, 0);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(284, 32);
            lblPhieuBanHang.TabIndex = 48;
            lblPhieuBanHang.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(240, 237);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(244, 33);
            cboLoaiSP.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 237);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 4;
            label1.Text = "Loại sản phẩm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(394, 332);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(99, 36);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(286, 332);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 36);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(175, 332);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 36);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(59, 332);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtNgayTao
            // 
            txtNgayTao.Location = new Point(241, 170);
            txtNgayTao.Margin = new Padding(4);
            txtNgayTao.Name = "txtNgayTao";
            txtNgayTao.Size = new Size(243, 31);
            txtNgayTao.TabIndex = 1;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(59, 177);
            lblNgayTao.Margin = new Padding(4, 0, 4, 0);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(121, 25);
            lblNgayTao.TabIndex = 0;
            lblNgayTao.Text = "Tên sản phẩm";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(241, 112);
            txtMaHoaDon.Margin = new Padding(4);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(243, 31);
            txtMaHoaDon.TabIndex = 1;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(59, 119);
            lblMaHoaDon.Margin = new Padding(4, 0, 4, 0);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(120, 25);
            lblMaHoaDon.TabIndex = 0;
            lblMaHoaDon.Text = "Mã sản phẩm";
            // 
            // UCDanhSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCDanhSach";
            Size = new Size(1108, 769);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).EndInit();
            gbChiTietSP.ResumeLayout(false);
            gbChiTietSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            gbThongTinSP.ResumeLayout(false);
            gbThongTinSP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbThongTinSP;
        private ComboBox cboLoaiSP;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtNgayTao;
        private Label lblNgayTao;
        private TextBox txtMaHoaDon;
        private Label lblMaHoaDon;
        private GroupBox gbChiTietSP;
        private ComboBox cboMau;
        private TextBox txtGiaNhap;
        private ComboBox cboSize;
        private NumericUpDown numericUpDownSoLuong;
        private Label label2;
        private Button btnXoaCT;
        private TextBox txtGiaBan;
        private Button btnSuaCT;
        private Button btnThemCT;
        private Label lblSoLuong;
        private Label lblDonGia;
        private Label lblMaHangHoa;
        private Label lblTenHangHoa;
        private DataGridView dgvDsChiTietHoaDon;
        private Label label3;
        private Label lblPhieuBanHang;
        private Label lblGiaBan;
        private Label lblGiaNhap;
    }
}
