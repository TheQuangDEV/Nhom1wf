using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhangmini
{

   
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = QLBHMN; Integrated Security = True;");
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btthemvaogio_Click(object sender, EventArgs e)
        {
            if (tbsoluong.Text == "")
            {
                MessageBox.Show("Nhập số lượng");
                return;
            }
            string maSP = cbsanpham.SelectedValue.ToString();
            string tenSP = cbsanpham.Text;
            int donGia = int.Parse(tbdongia.Text);
            int soLuong = int.Parse(tbsoluong.Text);

            int thanhTien = donGia * soLuong;

            dgvChiTiet.Rows.Add(maSP, tenSP, donGia, soLuong, thanhTien);
        }
        private void TaoMaHoaDon()
        {
            string ma = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            tbmahoadon.Text = ma;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            TaoMaHoaDon();
            conn.Open();

            string sql = "SELECT MaSanPham, TenSanPham , DonGia FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbsanpham.DataSource = dt;
            cbsanpham.DisplayMember = "TenSanPham";   // hiện tên
            cbsanpham.ValueMember = "MaSanPham";                // giá trị là mã

            conn.Close();

            dgvChiTiet.ColumnCount = 5;

            dgvChiTiet.Columns[0].Name = "MaSP";
            dgvChiTiet.Columns[1].Name = "TenSP";
            dgvChiTiet.Columns[2].Name = "DonGia";
            dgvChiTiet.Columns[3].Name = "SoLuong";
            dgvChiTiet.Columns[4].Name = "ThanhTien";


        }

        private void cbsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbsanpham.SelectedItem;

            if (row != null)
            {
                tbdongia.Text = row["DonGia"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?",
                                  "Xác nhận",
                                  MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                // xóa DataGridView
                dgvChiTiet.Rows.Clear();

                // xóa thông tin
                tbtenkhachhang.Clear();
                tbsoluong.Clear();
                tbdongia.Clear();

                // reset combobox
                cbsanpham.SelectedIndex = -1;

                // tạo mã hóa đơn mới
                tbmahoadon.Text = "HD" + DateTime.Now.Ticks.ToString().Substring(10);

                MessageBox.Show("Đã hủy hóa đơn!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn mặt hàng cần xóa");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa mặt hàng này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                dgvChiTiet.Rows.Remove(dgvChiTiet.CurrentRow);
            }
        }
    }
}
