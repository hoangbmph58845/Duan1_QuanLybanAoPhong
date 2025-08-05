namespace PRO131
{
    partial class FormLichSuBanHang
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnXemChiTiet = new Button();
            btnLocHoaDon = new Button();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            txtMaHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox3 = new GroupBox();
            dgvHoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dgvHoaDonCT = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(143, 157, 178);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnXemChiTiet);
            panel1.Controls.Add(btnLocHoaDon);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(cboKhachHang);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 579);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(19, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 222);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 178);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.BackColor = SystemColors.ActiveBorder;
            btnXemChiTiet.Location = new Point(181, 252);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(133, 32);
            btnXemChiTiet.TabIndex = 16;
            btnXemChiTiet.Text = "Hóa đơn chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnLocHoaDon
            // 
            btnLocHoaDon.BackColor = SystemColors.ActiveBorder;
            btnLocHoaDon.Location = new Point(19, 252);
            btnLocHoaDon.Name = "btnLocHoaDon";
            btnLocHoaDon.Size = new Size(129, 32);
            btnLocHoaDon.TabIndex = 17;
            btnLocHoaDon.Text = "Lọc hóa đơn";
            btnLocHoaDon.UseVisualStyleBackColor = false;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(139, 187);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(200, 27);
            dtTo.TabIndex = 14;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(139, 144);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(200, 27);
            dtFrom.TabIndex = 15;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(141, 97);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(159, 28);
            cboNhanVien.TabIndex = 12;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(141, 54);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(159, 28);
            cboKhachHang.TabIndex = 13;
            // 
            // txtMaHD
            // 
            txtMaHD.BorderStyle = BorderStyle.FixedSingle;
            txtMaHD.Location = new Point(139, 9);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(200, 27);
            txtMaHD.TabIndex = 11;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 194);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 6;
            label5.Text = "Đến ngày :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 151);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Từ ngày :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 105);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 8;
            label3.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 62);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 9;
            label2.Text = "Mã khách hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã hóa đơn :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHoaDon);
            groupBox3.Location = new Point(360, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(766, 267);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(6, 26);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(754, 241);
            dgvHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHoaDonCT);
            groupBox2.Location = new Point(358, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(768, 316);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dgvHoaDonCT
            // 
            dgvHoaDonCT.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvHoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonCT.Location = new Point(8, 26);
            dgvHoaDonCT.Name = "dgvHoaDonCT";
            dgvHoaDonCT.RowHeadersWidth = 51;
            dgvHoaDonCT.Size = new Size(754, 279);
            dgvHoaDonCT.TabIndex = 0;
            // 
            // FormLichSuBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "FormLichSuBanHang";
            Size = new Size(1166, 589);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnXemChiTiet;
        private Button btnLocHoaDon;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private TextBox txtMaHD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox3;
        private DataGridView dgvHoaDon;
        private GroupBox groupBox2;
        private DataGridView dgvHoaDonCT;
    }
}