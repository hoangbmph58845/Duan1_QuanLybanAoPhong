namespace PRO131
{
    partial class UCTonKHo
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
            dgvSanPham = new DataGridView();
            groupBox1 = new GroupBox();
            lblPhieuBanHang = new Label();
            cboMauSP = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            txtGiaBan = new TextBox();
            label1 = new Label();
            txtGIaNhap = new TextBox();
            cboSize = new ComboBox();
            label4 = new Label();
            numericUpDownSL = new NumericUpDown();
            label3 = new Label();
            btnXoaCT = new Button();
            btnSuaCT = new Button();
            btnThemCT = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvSanPham, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1019, 824);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(512, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(504, 818);
            dgvSanPham.TabIndex = 60;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(241, 250, 238);
            groupBox1.Controls.Add(lblPhieuBanHang);
            groupBox1.Controls.Add(cboMauSP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGIaNhap);
            groupBox1.Controls.Add(cboSize);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownSL);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnXoaCT);
            groupBox1.Controls.Add(btnSuaCT);
            groupBox1.Controls.Add(btnThemCT);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(29, 53, 87);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 818);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = Color.SteelBlue;
            lblPhieuBanHang.Location = new Point(90, 84);
            lblPhieuBanHang.Margin = new Padding(4, 0, 4, 0);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(337, 48);
            lblPhieuBanHang.TabIndex = 72;
            lblPhieuBanHang.Text = "CHI TIẾT TỒN KHO";
            // 
            // cboMauSP
            // 
            cboMauSP.FormattingEnabled = true;
            cboMauSP.Location = new Point(246, 334);
            cboMauSP.Name = "cboMauSP";
            cboMauSP.Size = new Size(218, 33);
            cboMauSP.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 342);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 70;
            label5.Text = "Màu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 493);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 69;
            label2.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(246, 490);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(218, 31);
            txtGiaBan.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 415);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 67;
            label1.Text = "Giá nhập";
            // 
            // txtGIaNhap
            // 
            txtGIaNhap.Location = new Point(247, 412);
            txtGIaNhap.Name = "txtGIaNhap";
            txtGIaNhap.Size = new Size(218, 31);
            txtGIaNhap.TabIndex = 66;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(246, 215);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(218, 33);
            cboSize.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 223);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 64;
            label4.Text = "Size";
            // 
            // numericUpDownSL
            // 
            numericUpDownSL.Location = new Point(246, 268);
            numericUpDownSL.Name = "numericUpDownSL";
            numericUpDownSL.Size = new Size(219, 31);
            numericUpDownSL.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 62;
            label3.Text = "Số lượng";
            // 
            // btnXoaCT
            // 
            btnXoaCT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaCT.Location = new Point(309, 567);
            btnXoaCT.Margin = new Padding(4);
            btnXoaCT.Name = "btnXoaCT";
            btnXoaCT.Size = new Size(118, 36);
            btnXoaCT.TabIndex = 59;
            btnXoaCT.Text = "Xóa";
            btnXoaCT.UseVisualStyleBackColor = true;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSuaCT.Location = new Point(185, 567);
            btnSuaCT.Margin = new Padding(4);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(118, 36);
            btnSuaCT.TabIndex = 60;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            // 
            // btnThemCT
            // 
            btnThemCT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemCT.Location = new Point(59, 567);
            btnThemCT.Margin = new Padding(4);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(118, 36);
            btnThemCT.TabIndex = 61;
            btnThemCT.Text = "Thêm";
            btnThemCT.UseVisualStyleBackColor = true;
            // 
            // UCTonKHo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCTonKHo";
            Size = new Size(1019, 824);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ComboBox cboMauSP;
        private Label label5;
        private Label label2;
        private TextBox txtGiaBan;
        private Label label1;
        private TextBox txtGIaNhap;
        private ComboBox cboSize;
        private Label label4;
        private NumericUpDown numericUpDownSL;
        private Label label3;
        private Button btnXoaCT;
        private Button btnSuaCT;
        private Button btnThemCT;
        private DataGridView dgvSanPham;
        private Label lblPhieuBanHang;
    }
}
