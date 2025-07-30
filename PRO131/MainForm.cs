using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            panelSubSanPham.Visible = !panelSubSanPham.Visible;
        }



        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelSubNhanVien.Visible = !panelSubNhanVien.Visible;
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            panelSubKhachHang.Visible = !panelSubKhachHang.Visible;
        }

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
            panelSubBanHang.Visible = !panelSubBanHang.Visible;
        }
        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnDanhSachSP_Click(object sender, EventArgs e)
        {
           
            LoadUserControl(new UCSanPham());
        
        }
    }
}
