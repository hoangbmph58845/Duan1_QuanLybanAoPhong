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
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnLoc = new Button();
            lblTongDoanhThu = new Label();
            dgvHoaDon = new DataGridView();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Dock = DockStyle.Fill;
            dtpTuNgay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTuNgay.Location = new Point(3, 33);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(324, 34);
            dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Dock = DockStyle.Fill;
            dtpDenNgay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDenNgay.Location = new Point(3, 91);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(324, 34);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = SystemColors.Info;
            btnLoc.Dock = DockStyle.Fill;
            btnLoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.Location = new Point(3, 152);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(324, 88);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Dock = DockStyle.Fill;
            lblTongDoanhThu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongDoanhThu.ForeColor = Color.Red;
            lblTongDoanhThu.Location = new Point(3, 243);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(324, 73);
            lblTongDoanhThu.TabIndex = 5;
            lblTongDoanhThu.Text = "Tổng doanh thu:";
            lblTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(344, 3);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dgvHoaDon, 5);
            dgvHoaDon.Size = new Size(613, 310);
            dgvHoaDon.TabIndex = 6;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            tableLayoutPanel1.SetColumnSpan(chartDoanhThu, 3);
            chartDoanhThu.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(3, 354);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(954, 426);
            chartDoanhThu.TabIndex = 7;
            chartDoanhThu.Text = "chartDoanhThu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.76617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.233831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 618F));
            tableLayoutPanel1.Controls.Add(lblTongDoanhThu, 0, 4);
            tableLayoutPanel1.Controls.Add(chartDoanhThu, 1, 5);
            tableLayoutPanel1.Controls.Add(btnLoc, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpDenNgay, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpTuNgay, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvHoaDon, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2465744F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.7534256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 431F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(960, 783);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 250, 238);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 783);
            panel1.TabIndex = 0;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Thongke";
            Size = new Size(960, 783);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnLoc;
        private Label lblTongDoanhThu;
        private DataGridView dgvHoaDon;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Panel panel1;
    }
}
