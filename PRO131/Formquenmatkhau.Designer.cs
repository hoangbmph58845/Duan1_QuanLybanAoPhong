namespace PRO131
{
    partial class btnXacNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnXacNhan));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblEmail = new Label();
            txtEnv = new TextBox();
            lblKetQua = new Label();
            btnLayLaiMatKhau = new Button();
            button1 = new Button();
            txtTknv = new TextBox();
            txtMkm = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 40);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 99);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaption;
            lblEmail.Location = new Point(118, 317);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            // 
            // txtEnv
            // 
            txtEnv.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnv.Location = new Point(213, 315);
            txtEnv.Name = "txtEnv";
            txtEnv.Size = new Size(266, 30);
            txtEnv.TabIndex = 24;
            txtEnv.TextChanged += txtEnv_TextChanged;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = SystemColors.ActiveCaption;
            lblKetQua.Location = new Point(39, 371);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(152, 28);
            lblKetQua.TabIndex = 25;
            lblKetQua.Text = "Tên đăng nhập";
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.BackColor = SystemColors.ButtonShadow;
            btnLayLaiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLayLaiMatKhau.Location = new Point(137, 532);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new Size(138, 40);
            btnLayLaiMatKhau.TabIndex = 26;
            btnLayLaiMatKhau.Text = "Xác Nhận";
            btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(367, 532);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 27;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTknv
            // 
            txtTknv.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTknv.Location = new Point(213, 373);
            txtTknv.Name = "txtTknv";
            txtTknv.Size = new Size(266, 30);
            txtTknv.TabIndex = 28;
            // 
            // txtMkm
            // 
            txtMkm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMkm.Location = new Point(213, 436);
            txtMkm.Name = "txtMkm";
            txtMkm.Size = new Size(266, 30);
            txtMkm.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(37, 438);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 30;
            label2.Text = "Mật khẩu mới";
            // 
            // btnXacNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(583, 619);
            Controls.Add(label2);
            Controls.Add(txtMkm);
            Controls.Add(txtTknv);
            Controls.Add(button1);
            Controls.Add(btnLayLaiMatKhau);
            Controls.Add(lblKetQua);
            Controls.Add(txtEnv);
            Controls.Add(lblEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "btnXacNhan";
            Text = "Formquenmatkhau";
            Load += Formquenmatkhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblEmail;
        private TextBox txtEnv;
        private Label lblKetQua;
        private Button btnLayLaiMatKhau;
        private Button button1;
        private TextBox txtTknv;
        private TextBox txtMkm;
        private Label label2;
    }
}