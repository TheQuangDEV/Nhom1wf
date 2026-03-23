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
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=QLBHMN;Integrated Security=True;";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2026, 3, 1);
            dtpDenNgay.Value = new DateTime(2026, 3, 31);

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblTongHoaDon.Text = "Tổng số hóa đơn: 0";
            lblTongDoanhThu.Text = "Tổng doanh thu: 0";
        }

        private void FrmThongKeDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lblTongHoaDon.Text = "Tổng số hóa đơn: " + rd["TongSoHoaDon"].ToString();
                    lblTongDoanhThu.Text = "Tổng doanh thu: " + Convert.ToDecimal(rd["TongDoanhThu"]).ToString("N0");
                }
                rd.Close();

                SqlCommand cmd2 = new SqlCommand("sp_DanhSachHoaDonTheoNgay", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                cmd2.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHoaDon.DataSource = dt;

                if (dgvHoaDon.Columns.Contains("MaHoaDon"))
                    dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";

                if (dgvHoaDon.Columns.Contains("TenKhachHang"))
                    dgvHoaDon.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";

                if (dgvHoaDon.Columns.Contains("NgayLap"))
                    dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày lập";

                if (dgvHoaDon.Columns.Contains("TongTien"))
                {
                    dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                }
            }
        }

        private void lblTongDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
