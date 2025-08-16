namespace PRO131
{
    partial class Thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvHoaDon = new DataGridView();
            lblTongDoanhThu = new Label();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 250, 238);
            panel1.Controls.Add(chartDoanhThu);
            panel1.Controls.Add(dgvHoaDon);
            panel1.Controls.Add(lblTongDoanhThu);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 718);
            panel1.TabIndex = 0;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            chartDoanhThu.Dock = DockStyle.Bottom;
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(0, 387);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(838, 331);
            chartDoanhThu.TabIndex = 7;
            chartDoanhThu.Text = "chartDoanhThu";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(444, 21);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(374, 347);
            dgvHoaDon.TabIndex = 6;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongDoanhThu.ForeColor = Color.Red;
            lblTongDoanhThu.Location = new Point(30, 285);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(192, 31);
            lblTongDoanhThu.TabIndex = 5;
            lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = SystemColors.Info;
            btnLoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.Location = new Point(152, 191);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(95, 53);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDenNgay.Location = new Point(40, 122);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(346, 34);
            dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTuNgay.Location = new Point(40, 34);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(346, 34);
            dtpTuNgay.TabIndex = 2;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Thongke";
            Size = new Size(838, 718);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTongDoanhThu;
        private Button btnLoc;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private DataGridView dgvHoaDon;
    }
}
