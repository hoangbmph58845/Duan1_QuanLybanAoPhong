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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView_LSMH = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LSMH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(690, 19);
            label1.Name = "label1";
            label1.Size = new Size(371, 47);
            label1.TabIndex = 0;
            label1.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(54, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 511);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_LSMH);
            groupBox2.Font = new Font("Cambria", 11F);
            groupBox2.Location = new Point(374, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1137, 511);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch Sử Mua Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Quy_Trinh_Xuat_Hoa_Don_2;
            pictureBox1.Location = new Point(28, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView_LSMH
            // 
            dataGridView_LSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LSMH.Location = new Point(6, 41);
            dataGridView_LSMH.Name = "dataGridView_LSMH";
            dataGridView_LSMH.RowHeadersWidth = 51;
            dataGridView_LSMH.Size = new Size(1114, 452);
            dataGridView_LSMH.TabIndex = 0;
            // 
            // LichSuMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 621);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "LichSuMH";
            Text = "LichSuMH";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView_LSMH;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}