using Microsoft.EntityFrameworkCore;
using PRO131.DataContext;
using PRO131.Models;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;


namespace PRO131
{
    public partial class QlKhachHang : UserControl
    {
        public QlKhachHang()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            loadDB();
        }

        public void loadDB()
        {
            using (var db = new DataContext.DuAn1Context())
            {
                dataGridView1.DataSource = db.KhachHangs.ToList();
            }
            textBox_M.ReadOnly = true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DataContext.DuAn1Context db = new DataContext.DuAn1Context())
            {
                dataGridView1.DataSource = db.KhachHangs.Where(p => p.MaKh.Equals(textBox_TK.Text));
            }
            textBox_TK.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_DC.Clear();
            textBox_DT.Clear();
            textBox_M.Clear();
            textBox_TK.Clear();
            textBox_GT.Text = null;
            textBox_M.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataContext.DuAn1Context db = new PRO131.DataContext.DuAn1Context())
                {
                    string makh = dataGridView1.SelectedCells[0].OwningRow.Cells["maKhachHang"].Value.ToString();
                    KhachHang delete = db.KhachHangs.Where(p => p.MaKh.Equals(makh)).Single();
                    db.KhachHangs.ExecuteDeleteAsync();
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công!!!!", "Thông báo!", MessageBoxButtons.OK);
            }

            loadDB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (DataContext.DuAn1Context db = new PRO131.DataContext.DuAn1Context())
            {
                try
                {
                    KhachHang sua = db.KhachHangs.Where(p => p.MaKh.Equals(textBox_M.Text)).Single();
                    sua.MaKh = textBox_M.TextLength;
                    sua.TenKhachHang = textBox_T.Text;
                    sua.GioiTinh = textBox_GT.Text;
                    sua.DiaChi = textBox_DC.Text;
                    sua.SoDienThoai = textBox_DT.Text;
                  

                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo!", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi rồi!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            loadDB();
        }

        

        private void cboGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new QlKhachHang().Show();
            this.Hide();
        }

        private void FormQLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox_M.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                textBox_T.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                textBox_GT.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
                textBox_DC.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                textBox_DT.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
               
            }
            textBox_M.ReadOnly = true;
        }

    }
}
