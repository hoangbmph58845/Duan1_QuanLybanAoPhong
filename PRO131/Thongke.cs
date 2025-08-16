using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRO131
{
    public partial class Thongke : UserControl
    {
        string connectionString = "Server=TUAN;Database=DuAn_1;User Id=sa;Password=123456;TrustServerCertificate=true;";
        public Thongke()
        {
            InitializeComponent();
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";

            dtpTuNgay.Value = DateTime.Now.AddDays(-7);
            dtpDenNgay.Value = DateTime.Now;

            LoadThongKe();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }
        private void LoadThongKe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    HoaDon.NgayBan, 
                    SUM(HoaDon.TongTien) AS DoanhThu
                FROM HoaDon
                WHERE HoaDon.NgayBan BETWEEN @TuNgay AND @DenNgay
                GROUP BY HoaDon.NgayBan
                ORDER BY HoaDon.NgayBan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Đổ vào DataGridView
                dgvHoaDon.DataSource = dt;

                // Tính tổng
                decimal tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tong += Convert.ToDecimal(row["DoanhThu"]);
                }
                lblTongDoanhThu.Text = "💰 Tổng doanh thu: " + tong.ToString("N0") + " VNĐ";

                // Vẽ biểu đồ
                chartDoanhThu.Series.Clear();
                Series series = chartDoanhThu.Series.Add("Doanh thu");
                series.ChartType = SeriesChartType.Column;

                // Trục X là ngày
                chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày bán";
                chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
                chartDoanhThu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
                chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

                // Trục Y là doanh thu
                chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu";

                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngayBan = DateTime.Parse(row["NgayBan"].ToString());
                    decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                    series.Points.AddXY(ngayBan.ToOADate(), doanhThu);
                }
            }
        }
    }
}
