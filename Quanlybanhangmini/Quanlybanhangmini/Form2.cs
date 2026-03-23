using System;
using System.Windows.Forms;

namespace Quanlybanhangmini
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bthoadon_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btsappham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham f = new frmQuanLySanPham();
            f.ShowDialog();
        }

        private void btnhanvien_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo Form Quản lý nhân viên của bạn
            frmQuanLyNhanVien frmNV = new frmQuanLyNhanVien();

            // 2. Hiển thị Form đó lên màn hình
            frmNV.ShowDialog();
        }

        private void btdoanhthu_Click(object sender, EventArgs e)
        {
           Form4 frmdt = new Form4();
            frmdt.ShowDialog();
        }
    }
}