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
        string connectionString = "Server=PHONGG\\MSSQLSERVER02;Database=DuAn_1;Trusted_Connection=True;TrustServerCertificate=True;";
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
            try
            {
                // ✅ Validate ngày hợp lệ
                if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

                    // ✅ Ngày kết thúc lấy hết cả ngày (23:59:59)
                    cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // ✅ Kiểm tra dữ liệu rỗng
                    if (dt.Rows.Count == 0)
                    {
                        dgvHoaDon.DataSource = null;
                        lblTongDoanhThu.Text = "Không có dữ liệu trong khoảng thời gian này!";
                        chartDoanhThu.Series.Clear();
                        return;
                    }

                    // Đổ vào DataGridView
                    dgvHoaDon.DataSource = dt;

                    // ✅ Tính tổng an toàn
                    decimal tong = dt.AsEnumerable().Sum(r => r.Field<decimal>("DoanhThu"));
                    lblTongDoanhThu.Text = "💰 Tổng doanh thu: " + tong.ToString("N0") + " VNĐ";

                    // Vẽ biểu đồ
                    chartDoanhThu.Series.Clear();
                    Series series = chartDoanhThu.Series.Add("Doanh thu");
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true; // ✅ Hiện giá trị trên cột
                    series.LabelFormat = "N0";

                    // Trục X là ngày
                    chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày bán";
                    chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
                    chartDoanhThu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
                    chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

                    // Trục Y là doanh thu
                    chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu";

                    // ✅ Parse an toàn
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime ngayBan = row.Field<DateTime>("NgayBan");
                        decimal doanhThu = row.Field<decimal>("DoanhThu");
                        series.Points.AddXY(ngayBan, doanhThu);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message,
                                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
