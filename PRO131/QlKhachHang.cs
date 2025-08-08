using PRO131.DataContext;
using PRO131.Models;
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

namespace PRO131
{
    public partial class QlKhachHang : Form
    {
        public QlKhachHang()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {

        }

        public void loadDB()
        {
            using (DuAn1Context db = new DuAn1Context())
            {
               dataGridView1.DataSource = from kh in db.KhachHangs
                                          select new
                                          {
                                              maKhachHang = kh.MaKh,
                                              tenKhachHang = kh.TenKhachHang,
                                              gioiTinh = kh.GioiTinh,
                                              diaChi = kh.DiaChi,
                                              dienThoai = kh.SoDienThoai,
                                            
                                          };
            }
            textBox_M.ReadOnly = true;
        }
        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            loadDB();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DuAn1Context db = new DuAn1Context())
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
            textBox_T.Clear();
            textBox_GT.Text = null;
           textBox_M.ReadOnly = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DuAn1Context db = new DuAn1Context())
                {
                    string makh = dataGridView1.SelectedCells[0].OwningRow.Cells["maKhachHang"].Value.ToString();
                 KhachHang delete = db.KhachHangs.Where(p => p.MaKh.Equals(makh)).Single();
                    db.KhachHangs.Remove(delete);
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
            using (DuAn1Context db = new DuAn1Context())
            {
                try
                {
                    KhachHang sua = db.KhachHangs.Where(p => p.MaKh.Equals(textBox_M.Text)).Single();
                  
                    sua.TenKhachHang = textBox_T.Text;
                    sua.GioiTinh = textBox_GT.Text;
                    sua.DiaChi = textBox_DC.Text;
                    sua.SoDienThoai = textBox_DT.Text;
                    

                    db.SaveChangesAsync();
                    MessageBox.Show("Sửa thành công", "Thông báo!", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi rồi!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            loadDB();
        }
    }
}
