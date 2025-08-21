namespace PRO131
{
    partial class LichSuMH
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox_TK3 = new TextBox();
            button_TK3 = new Button();
            dataGridView_LSMH = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LSMH).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 590);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Quy_Trinh_Xuat_Hoa_Don_2;
            pictureBox1.Location = new Point(6, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 542);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_TK3);
            groupBox2.Controls.Add(button_TK3);
            groupBox2.Controls.Add(dataGridView_LSMH);
            groupBox2.Font = new Font("Cambria", 11F);
            groupBox2.Location = new Point(460, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1193, 590);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch Sử Mua Hàng";
            // 
            // textBox_TK3
            // 
            textBox_TK3.Location = new Point(445, 108);
            textBox_TK3.Name = "textBox_TK3";
            textBox_TK3.Size = new Size(456, 29);
            textBox_TK3.TabIndex = 2;
            // 
            // button_TK3
            // 
            button_TK3.Location = new Point(243, 108);
            button_TK3.Name = "button_TK3";
            button_TK3.Size = new Size(132, 29);
            button_TK3.TabIndex = 1;
            button_TK3.Text = "Tìm Kiếm";
            button_TK3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LSMH
            // 
            dataGridView_LSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LSMH.Location = new Point(40, 196);
            dataGridView_LSMH.Name = "dataGridView_LSMH";
            dataGridView_LSMH.RowHeadersWidth = 51;
            dataGridView_LSMH.Size = new Size(1107, 368);
            dataGridView_LSMH.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(611, 28);
            label1.Name = "label1";
            label1.Size = new Size(371, 47);
            label1.TabIndex = 2;
            label1.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // LichSuMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 865);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LichSuMH";
            Text = "LichSuMH";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView_LSMH;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox_TK3;
        private Button button_TK3;
    }
}