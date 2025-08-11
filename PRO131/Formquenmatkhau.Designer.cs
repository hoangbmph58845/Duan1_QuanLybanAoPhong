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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblKetQua = new Label();
            btnLayLaiMatKhau = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 32);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 93);
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
            lblEmail.Location = new Point(65, 317);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(153, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 30);
            txtEmail.TabIndex = 24;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = SystemColors.ActiveCaption;
            lblKetQua.Location = new Point(39, 387);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(90, 28);
            lblKetQua.TabIndex = 25;
            lblKetQua.Text = "Kết quả:";
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.BackColor = SystemColors.ButtonShadow;
            btnLayLaiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLayLaiMatKhau.Location = new Point(118, 432);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new Size(201, 40);
            btnLayLaiMatKhau.TabIndex = 26;
            btnLayLaiMatKhau.Text = "Lấy lại Mật khẩu";
            btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(364, 432);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 27;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Formquenmatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(538, 500);
            Controls.Add(button1);
            Controls.Add(btnLayLaiMatKhau);
            Controls.Add(lblKetQua);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Formquenmatkhau";
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
        private TextBox txtEmail;
        private Label lblKetQua;
        private Button btnLayLaiMatKhau;
        private Button button1;
    }
}