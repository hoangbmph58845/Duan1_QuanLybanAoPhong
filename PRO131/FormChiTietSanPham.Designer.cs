namespace PRO131
{
    partial class FormChiTietSanPham
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSize = new ComboBox();
            label7 = new Label();
            txtGiaBan = new TextBox();
            txtGiaNhap = new TextBox();
            cboLoai = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenSP = new TextBox();
            cboHang = new ComboBox();
            label6 = new Label();
            numericUpDownSoLuong = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThemSP = new Button();
            btnSuaSp = new Button();
            btnXoaSP = new Button();
            groupBox1 = new GroupBox();
            txtTimKiemSP = new TextBox();
            btnTimKiemSP = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(241, 250, 238);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSize, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtGiaBan, 1, 4);
            tableLayoutPanel1.Controls.Add(txtGiaNhap, 1, 3);
            tableLayoutPanel1.Controls.Add(cboLoai, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtTenSP, 1, 0);
            tableLayoutPanel1.Controls.Add(cboHang, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(numericUpDownSoLuong, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtSize
            // 
            txtSize.BackColor = Color.FromArgb(241, 250, 238);
            txtSize.Dock = DockStyle.Fill;
            txtSize.FormattingEnabled = true;
            txtSize.Location = new Point(403, 228);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(394, 33);
            txtSize.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(241, 250, 238);
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 270);
            label7.Name = "label7";
            label7.Size = new Size(394, 180);
            label7.TabIndex = 13;
            label7.Text = "Số lượng";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = Color.FromArgb(241, 250, 238);
            txtGiaBan.Dock = DockStyle.Fill;
            txtGiaBan.Location = new Point(403, 183);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(394, 31);
            txtGiaBan.TabIndex = 10;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.BackColor = Color.FromArgb(241, 250, 238);
            txtGiaNhap.Dock = DockStyle.Fill;
            txtGiaNhap.Location = new Point(403, 138);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(394, 31);
            txtGiaNhap.TabIndex = 9;
            // 
            // cboLoai
            // 
            cboLoai.BackColor = Color.FromArgb(241, 250, 238);
            cboLoai.Dock = DockStyle.Fill;
            cboLoai.FormattingEnabled = true;
            cboLoai.Location = new Point(403, 93);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(394, 33);
            cboLoai.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 250, 238);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 45);
            label1.TabIndex = 0;
            label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 250, 238);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(394, 45);
            label2.TabIndex = 1;
            label2.Text = "Hãng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 250, 238);
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(394, 45);
            label3.TabIndex = 2;
            label3.Text = "Loại sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 250, 238);
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(394, 45);
            label4.TabIndex = 3;
            label4.Text = "Giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 250, 238);
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 180);
            label5.Name = "label5";
            label5.Size = new Size(394, 45);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // txtTenSP
            // 
            txtTenSP.BackColor = Color.FromArgb(241, 250, 238);
            txtTenSP.Dock = DockStyle.Fill;
            txtTenSP.Location = new Point(403, 3);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(394, 31);
            txtTenSP.TabIndex = 6;
            // 
            // cboHang
            // 
            cboHang.BackColor = Color.FromArgb(241, 250, 238);
            cboHang.Dock = DockStyle.Fill;
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(403, 48);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(394, 33);
            cboHang.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(241, 250, 238);
            label6.Location = new Point(3, 225);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 12;
            label6.Text = "Size";
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.BackColor = Color.FromArgb(241, 250, 238);
            numericUpDownSoLuong.Dock = DockStyle.Fill;
            numericUpDownSoLuong.Location = new Point(403, 273);
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(394, 31);
            numericUpDownSoLuong.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(241, 250, 238);
            flowLayoutPanel1.Controls.Add(btnThemSP);
            flowLayoutPanel1.Controls.Add(btnSuaSp);
            flowLayoutPanel1.Controls.Add(btnXoaSP);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 330);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 120);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = Color.FromArgb(241, 250, 238);
            btnThemSP.DialogResult = DialogResult.Continue;
            btnThemSP.Dock = DockStyle.Top;
            btnThemSP.FlatStyle = FlatStyle.Flat;
            btnThemSP.Location = new Point(3, 3);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.RightToLeft = RightToLeft.No;
            btnThemSP.Size = new Size(112, 34);
            btnThemSP.TabIndex = 2;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = false;
            // 
            // btnSuaSp
            // 
            btnSuaSp.BackColor = Color.FromArgb(241, 250, 238);
            btnSuaSp.DialogResult = DialogResult.Continue;
            btnSuaSp.Dock = DockStyle.Top;
            btnSuaSp.FlatStyle = FlatStyle.Flat;
            btnSuaSp.Location = new Point(121, 3);
            btnSuaSp.Name = "btnSuaSp";
            btnSuaSp.RightToLeft = RightToLeft.No;
            btnSuaSp.Size = new Size(112, 34);
            btnSuaSp.TabIndex = 0;
            btnSuaSp.Text = "Sửa";
            btnSuaSp.UseVisualStyleBackColor = false;
            // 
            // btnXoaSP
            // 
            btnXoaSP.BackColor = Color.FromArgb(241, 250, 238);
            btnXoaSP.DialogResult = DialogResult.Continue;
            btnXoaSP.Dock = DockStyle.Top;
            btnXoaSP.FlatStyle = FlatStyle.Flat;
            btnXoaSP.Location = new Point(239, 3);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.RightToLeft = RightToLeft.No;
            btnXoaSP.Size = new Size(112, 34);
            btnXoaSP.TabIndex = 1;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(241, 250, 238);
            groupBox1.Controls.Add(txtTimKiemSP);
            groupBox1.Controls.Add(btnTimKiemSP);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo tên";
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.BackColor = Color.FromArgb(241, 250, 238);
            txtTimKiemSP.Location = new Point(152, 28);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(389, 31);
            txtTimKiemSP.TabIndex = 1;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.BackColor = Color.FromArgb(241, 250, 238);
            btnTimKiemSP.Location = new Point(577, 28);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(112, 34);
            btnTimKiemSP.TabIndex = 0;
            btnTimKiemSP.Text = "Tìm kiếm";
            btnTimKiemSP.UseVisualStyleBackColor = false;
            // 
            // FormChiTietSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "FormChiTietSanPham";
            Text = "FormChiTietSanPham";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Button button4;
        private TextBox txtGiaBan;
        private TextBox txtGiaNhap;
        private ComboBox cboLoai;
        private TextBox txtTenSP;
        private ComboBox cboHang;
        private ComboBox txtSize;
        private NumericUpDown numericUpDownSoLuong;
        private Button btnThemSP;
        private Button btnSuaSp;
        private Button btnXoaSP;
        private TextBox txtTimKiemSP;
        private Button btnTimKiemSP;
    }
}