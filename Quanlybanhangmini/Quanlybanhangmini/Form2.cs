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

    }
}