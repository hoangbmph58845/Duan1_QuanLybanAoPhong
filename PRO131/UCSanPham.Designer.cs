namespace PRO131
{
    partial class UCSanPham
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
            panelForm = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox6 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDanhSachSanPham = new DataGridView();
            panelForm.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.Controls.Add(textBox6);
            panelForm.Controls.Add(groupBox1);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(textBox5);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(textBox4);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(textBox3);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(textBox2);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(label1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(3, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(461, 865);
            panelForm.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 77);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 311);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 224);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 4;
            label3.Text = "Hãng sản xuất";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 151);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 6;
            label4.Text = "Loại sản phẩm";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 391);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 8;
            label5.Text = "Size";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(211, 391);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 482);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 10;
            label6.Text = "Số lượng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(31, 604);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình ảnh";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 175);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(211, 482);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panelForm, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDanhSachSanPham, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1169, 871);
            tableLayoutPanel1.TabIndex = 0;
           
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Dock = DockStyle.Fill;
            dgvDanhSachSanPham.Location = new Point(470, 3);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 62;
            dgvDanhSachSanPham.Size = new Size(696, 865);
            dgvDanhSachSanPham.TabIndex = 2;
      
            // 
            // UCSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tableLayoutPanel1);
            Name = "UCSanPham";
            Size = new Size(1169, 871);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDanhSachSanPham;
    }
}
