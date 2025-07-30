namespace PRO131
{
    partial class MainForm
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
            panelMenu = new Panel();
            panelSubNhanVien = new Panel();
            btnLichSuBan = new Button();
            btnTaiKhoan = new Button();
            btnThemNV = new Button();
            btnDSNhanVien = new Button();
            btnNhanVien = new Button();
            panelSubBanHang = new Panel();
            btnChiTietHoaDon = new Button();
            btnDSHoaDon = new Button();
            btnTaoHoaDon = new Button();
            btnBanHang = new Button();
            panelSubKhachHang = new Panel();
            btnLichSuMua = new Button();
            btnDanhSachKH = new Button();
            btnThemKH = new Button();
            btnKhachHang = new Button();
            panelSubSanPham = new Panel();
            btnDanhSachSP = new Button();
            btnThemSanPham = new Button();
            btnQLSanPham = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            panelSubNhanVien.SuspendLayout();
            panelSubBanHang.SuspendLayout();
            panelSubKhachHang.SuspendLayout();
            panelSubSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(panelSubNhanVien);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(panelSubBanHang);
            panelMenu.Controls.Add(btnBanHang);
            panelMenu.Controls.Add(panelSubKhachHang);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(panelSubSanPham);
            panelMenu.Controls.Add(btnQLSanPham);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 956);
            panelMenu.TabIndex = 0;
            // 
            // panelSubNhanVien
            // 
            panelSubNhanVien.Controls.Add(btnLichSuBan);
            panelSubNhanVien.Controls.Add(btnTaiKhoan);
            panelSubNhanVien.Controls.Add(btnThemNV);
            panelSubNhanVien.Controls.Add(btnDSNhanVien);
            panelSubNhanVien.Dock = DockStyle.Top;
            panelSubNhanVien.Location = new Point(0, 772);
            panelSubNhanVien.Name = "panelSubNhanVien";
            panelSubNhanVien.Size = new Size(300, 180);
            panelSubNhanVien.TabIndex = 15;
            panelSubNhanVien.Visible = false;
            // 
            // btnLichSuBan
            // 
            btnLichSuBan.BackColor = SystemColors.ActiveBorder;
            btnLichSuBan.Dock = DockStyle.Top;
            btnLichSuBan.FlatAppearance.BorderSize = 0;
            btnLichSuBan.FlatStyle = FlatStyle.Flat;
            btnLichSuBan.Location = new Point(0, 135);
            btnLichSuBan.Name = "btnLichSuBan";
            btnLichSuBan.Size = new Size(300, 45);
            btnLichSuBan.TabIndex = 9;
            btnLichSuBan.Text = "Lịch sử bán hàng";
            btnLichSuBan.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = SystemColors.ActiveBorder;
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Location = new Point(0, 90);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(300, 45);
            btnTaiKhoan.TabIndex = 8;
            btnTaiKhoan.Text = "\tQuản lý tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = SystemColors.ActiveBorder;
            btnThemNV.Dock = DockStyle.Top;
            btnThemNV.FlatAppearance.BorderSize = 0;
            btnThemNV.FlatStyle = FlatStyle.Flat;
            btnThemNV.Location = new Point(0, 45);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(300, 45);
            btnThemNV.TabIndex = 7;
            btnThemNV.Text = "Thêm nhân viên";
            btnThemNV.UseVisualStyleBackColor = false;
            // 
            // btnDSNhanVien
            // 
            btnDSNhanVien.BackColor = SystemColors.ActiveBorder;
            btnDSNhanVien.Dock = DockStyle.Top;
            btnDSNhanVien.FlatAppearance.BorderSize = 0;
            btnDSNhanVien.FlatStyle = FlatStyle.Flat;
            btnDSNhanVien.Location = new Point(0, 0);
            btnDSNhanVien.Name = "btnDSNhanVien";
            btnDSNhanVien.Size = new Size(300, 45);
            btnDSNhanVien.TabIndex = 6;
            btnDSNhanVien.Text = "Danh sách nhân viên";
            btnDSNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = SystemColors.ButtonHighlight;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 712);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(300, 60);
            btnNhanVien.TabIndex = 14;
            btnNhanVien.Text = "Quản Lý Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panelSubBanHang
            // 
            panelSubBanHang.Controls.Add(btnChiTietHoaDon);
            panelSubBanHang.Controls.Add(btnDSHoaDon);
            panelSubBanHang.Controls.Add(btnTaoHoaDon);
            panelSubBanHang.Dock = DockStyle.Top;
            panelSubBanHang.Location = new Point(0, 577);
            panelSubBanHang.Name = "panelSubBanHang";
            panelSubBanHang.Size = new Size(300, 135);
            panelSubBanHang.TabIndex = 13;
            panelSubBanHang.Visible = false;
            // 
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.BackColor = SystemColors.ActiveBorder;
            btnChiTietHoaDon.Dock = DockStyle.Top;
            btnChiTietHoaDon.FlatAppearance.BorderSize = 0;
            btnChiTietHoaDon.FlatStyle = FlatStyle.Flat;
            btnChiTietHoaDon.Location = new Point(0, 90);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(300, 45);
            btnChiTietHoaDon.TabIndex = 5;
            btnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            btnChiTietHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnDSHoaDon
            // 
            btnDSHoaDon.BackColor = SystemColors.ActiveBorder;
            btnDSHoaDon.Dock = DockStyle.Top;
            btnDSHoaDon.FlatAppearance.BorderSize = 0;
            btnDSHoaDon.FlatStyle = FlatStyle.Flat;
            btnDSHoaDon.Location = new Point(0, 45);
            btnDSHoaDon.Name = "btnDSHoaDon";
            btnDSHoaDon.Size = new Size(300, 45);
            btnDSHoaDon.TabIndex = 4;
            btnDSHoaDon.Text = "Danh sách hóa đơn";
            btnDSHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = SystemColors.ActiveBorder;
            btnTaoHoaDon.Dock = DockStyle.Top;
            btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            btnTaoHoaDon.FlatStyle = FlatStyle.Flat;
            btnTaoHoaDon.Location = new Point(0, 0);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(300, 45);
            btnTaoHoaDon.TabIndex = 3;
            btnTaoHoaDon.Text = "Tạo hóa đơn mới";
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(0, 517);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(300, 60);
            btnBanHang.TabIndex = 12;
            btnBanHang.Text = "Quản Lý Bán hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click_1;
            // 
            // panelSubKhachHang
            // 
            panelSubKhachHang.Controls.Add(btnLichSuMua);
            panelSubKhachHang.Controls.Add(btnDanhSachKH);
            panelSubKhachHang.Controls.Add(btnThemKH);
            panelSubKhachHang.Dock = DockStyle.Top;
            panelSubKhachHang.Location = new Point(0, 382);
            panelSubKhachHang.Name = "panelSubKhachHang";
            panelSubKhachHang.Size = new Size(300, 135);
            panelSubKhachHang.TabIndex = 11;
            panelSubKhachHang.Visible = false;
            // 
            // btnLichSuMua
            // 
            btnLichSuMua.BackColor = SystemColors.AppWorkspace;
            btnLichSuMua.Dock = DockStyle.Top;
            btnLichSuMua.FlatAppearance.BorderSize = 0;
            btnLichSuMua.FlatStyle = FlatStyle.Flat;
            btnLichSuMua.Location = new Point(0, 90);
            btnLichSuMua.Name = "btnLichSuMua";
            btnLichSuMua.Size = new Size(300, 45);
            btnLichSuMua.TabIndex = 4;
            btnLichSuMua.Text = "\tLịch sử mua hàng";
            btnLichSuMua.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachKH
            // 
            btnDanhSachKH.BackColor = SystemColors.AppWorkspace;
            btnDanhSachKH.Dock = DockStyle.Top;
            btnDanhSachKH.FlatAppearance.BorderSize = 0;
            btnDanhSachKH.FlatStyle = FlatStyle.Flat;
            btnDanhSachKH.Location = new Point(0, 45);
            btnDanhSachKH.Name = "btnDanhSachKH";
            btnDanhSachKH.Size = new Size(300, 45);
            btnDanhSachKH.TabIndex = 3;
            btnDanhSachKH.Text = "Danh sách KH";
            btnDanhSachKH.UseVisualStyleBackColor = false;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = SystemColors.AppWorkspace;
            btnThemKH.Dock = DockStyle.Top;
            btnThemKH.FlatAppearance.BorderSize = 0;
            btnThemKH.FlatStyle = FlatStyle.Flat;
            btnThemKH.Location = new Point(0, 0);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(300, 45);
            btnThemKH.TabIndex = 2;
            btnThemKH.Text = "Thêm khách hàng";
            btnThemKH.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = SystemColors.ButtonHighlight;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 322);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(300, 60);
            btnKhachHang.TabIndex = 10;
            btnKhachHang.Text = "Quản Lý Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click_1;
            // 
            // panelSubSanPham
            // 
            panelSubSanPham.BackColor = SystemColors.ButtonFace;
            panelSubSanPham.Controls.Add(btnDanhSachSP);
            panelSubSanPham.Controls.Add(btnThemSanPham);
            panelSubSanPham.Dock = DockStyle.Top;
            panelSubSanPham.Location = new Point(0, 232);
            panelSubSanPham.Name = "panelSubSanPham";
            panelSubSanPham.Size = new Size(300, 90);
            panelSubSanPham.TabIndex = 3;
            panelSubSanPham.Visible = false;
            // 
            // btnDanhSachSP
            // 
            btnDanhSachSP.BackColor = SystemColors.ButtonFace;
            btnDanhSachSP.FlatAppearance.BorderSize = 0;
            btnDanhSachSP.FlatStyle = FlatStyle.Flat;
            btnDanhSachSP.Location = new Point(0, 0);
            btnDanhSachSP.Name = "btnDanhSachSP";
            btnDanhSachSP.Size = new Size(300, 45);
            btnDanhSachSP.TabIndex = 2;
            btnDanhSachSP.Text = "Danh sách sản phẩm";
            btnDanhSachSP.UseVisualStyleBackColor = false;
            btnDanhSachSP.Click += btnDanhSachSP_Click;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = SystemColors.ButtonFace;
            btnThemSanPham.FlatAppearance.BorderSize = 0;
            btnThemSanPham.FlatStyle = FlatStyle.Flat;
            btnThemSanPham.Location = new Point(-3, 39);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(303, 51);
            btnThemSanPham.TabIndex = 3;
            btnThemSanPham.Text = "Thêm sản phẩm mới";
            btnThemSanPham.UseVisualStyleBackColor = false;
            // 
            // btnQLSanPham
            // 
            btnQLSanPham.BackColor = SystemColors.ButtonHighlight;
            btnQLSanPham.Dock = DockStyle.Top;
            btnQLSanPham.FlatAppearance.BorderSize = 0;
            btnQLSanPham.FlatStyle = FlatStyle.Flat;
            btnQLSanPham.Location = new Point(0, 172);
            btnQLSanPham.Name = "btnQLSanPham";
            btnQLSanPham.Size = new Size(300, 60);
            btnQLSanPham.TabIndex = 0;
            btnQLSanPham.Text = "Quản Lý Sản Phẩm";
            btnQLSanPham.UseVisualStyleBackColor = false;
            btnQLSanPham.Click += btnQLSanPham_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 172);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(300, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1022, 956);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 956);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelSubNhanVien.ResumeLayout(false);
            panelSubBanHang.ResumeLayout(false);
            panelSubKhachHang.ResumeLayout(false);
            panelSubSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnQLSanPham;
        private Button btnBanHang;
        private Panel panelSubKhachHang;
        private Button btnLichSuMua;
        private Button btnDanhSachKH;
        private Button btnThemKH;
        private Button btnKhachHang;
        private Panel panelSubSanPham;
        private Button btnDanhSachSP;
        private Button btnThemSanPham;
        private Panel panelSubBanHang;
        private Button btnChiTietHoaDon;
        private Button btnDSHoaDon;
        private Button btnTaoHoaDon;
        private Button btnNhanVien;
        private Panel panelSubNhanVien;
        private Button btnLichSuBan;
        private Button btnTaiKhoan;
        private Button btnThemNV;
        private Button btnDSNhanVien;
        private PictureBox pictureBox1;
        private Panel panelMain;
        
    }
}