namespace PRO131
{
    partial class Formquenmatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formquenmatkhau));
            button1 = new Button();
            btnLayLaiMatKhau = new Button();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblKetQua = new Label();
            txtTdn = new TextBox();
            label2 = new Label();
            txtMkm = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(316, 505);
            button1.Name = "button1";
            button1.Size = new Size(307, 57);
            button1.TabIndex = 27;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.BackColor = SystemColors.ButtonShadow;
            btnLayLaiMatKhau.Dock = DockStyle.Fill;
            btnLayLaiMatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLayLaiMatKhau.Location = new Point(3, 505);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new Size(307, 57);
            btnLayLaiMatKhau.TabIndex = 26;
            btnLayLaiMatKhau.Text = "Xác Nhận";
            btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 69);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(316, 376);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 30);
            txtEmail.TabIndex = 24;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaption;
            lblEmail.Location = new Point(3, 373);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(307, 60);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            lblEmail.Click += lblEmail_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Dock = DockStyle.Fill;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = SystemColors.ActiveCaption;
            lblKetQua.Location = new Point(3, 315);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(307, 58);
            lblKetQua.TabIndex = 25;
            lblKetQua.Text = "Tên đăng nhập";
            lblKetQua.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTdn
            // 
            txtTdn.Dock = DockStyle.Fill;
            txtTdn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTdn.Location = new Point(316, 318);
            txtTdn.Name = "txtTdn";
            txtTdn.Size = new Size(307, 30);
            txtTdn.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(3, 433);
            label2.Name = "label2";
            label2.Size = new Size(307, 69);
            label2.TabIndex = 30;
            label2.Text = "Mật khẩu mới";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMkm
            // 
            txtMkm.Dock = DockStyle.Fill;
            txtMkm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMkm.Location = new Point(316, 436);
            txtMkm.Name = "txtMkm";
            txtMkm.Size = new Size(307, 30);
            txtMkm.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(620, 67);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMkm, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(lblKetQua, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnLayLaiMatKhau, 0, 5);
            tableLayoutPanel1.Controls.Add(button1, 1, 5);
            tableLayoutPanel1.Controls.Add(txtTdn, 1, 2);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.47239F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.52761F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.Size = new Size(626, 590);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // Formquenmatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(626, 590);
            Controls.Add(tableLayoutPanel1);
            Name = "Formquenmatkhau";
            Text = "Formquenmatkhau";
            Load += Formquenmatkhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnLayLaiMatKhau;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblKetQua;
        private TextBox txtTdn;
        private Label label2;
        private TextBox txtMkm;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}