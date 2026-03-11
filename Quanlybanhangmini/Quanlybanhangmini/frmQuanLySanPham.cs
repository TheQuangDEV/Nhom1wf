using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlybanhangmini
{
    public partial class frmQuanLySanPham : Form
    {
        string connStr = @"Data Source=localhost;Initial Catalog=QLBHMN;Integrated Security=True;";

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            cboLoaiHang.Items.Clear();
            cboLoaiHang.Items.Add("Trái cây");
            cboLoaiHang.Items.Add("Nước giải khát");
            cboLoaiHang.Items.Add("Bánh kẹo");
            cboLoaiHang.Items.Add("Khác");

            if (cboLoaiHang.Items.Count > 0)
                cboLoaiHang.SelectedIndex = 0;

            txtMaSP.ReadOnly = true; // Mã SP là IDENTITY, chỉ hiển thị
            LoadSanPham();
            LamMoi();
        }

        private void LoadSanPham(string tuKhoa = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    SELECT MaSanPham, TenSanPham, LoaiHang, DonGia, SoLuongTon
                    FROM SanPham
                    WHERE (@TuKhoa = ''
                           OR CAST(MaSanPham AS NVARCHAR(20)) LIKE N'%' + @TuKhoa + '%'
                           OR TenSanPham LIKE N'%' + @TuKhoa + '%')
                    ORDER BY MaSanPham";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;
                lblTongMatHang.Text = dt.Rows.Count.ToString();
            }

            if (dgvSanPham.Columns.Count > 0)
            {
                dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                dgvSanPham.Columns["LoaiHang"].HeaderText = "Loại hàng";
                dgvSanPham.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            }
        }

        private void LamMoi()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
            txtTimKiem.Clear();

            if (cboLoaiHang.Items.Count > 0)
                cboLoaiHang.SelectedIndex = 0;

            txtTenSP.Focus();
            dgvSanPham.ClearSelection();
        }

        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!");
                txtTenSP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá không được để trống!");
                txtDonGia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuongTon.Text))
            {
                MessageBox.Show("Số lượng tồn không được để trống!");
                txtSoLuongTon.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!");
                txtDonGia.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text.Trim(), out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên không âm!");
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    INSERT INTO SanPham(TenSanPham, LoaiHang, DonGia, SoLuongTon)
                    VALUES(@TenSanPham, @LoaiHang, @DonGia, @SoLuongTon)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text.Trim());
                cmd.Parameters.AddWithValue("@LoaiHang", cboLoaiHang.Text);
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@SoLuongTon", int.Parse(txtSoLuongTon.Text.Trim()));

                conn.Open();
                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadSanPham();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null || dgvSanPham.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Không xác định được mã sản phẩm cần sửa!");
                return;
            }

            if (!KiemTraHopLe())
                return;

            int maSanPham = int.Parse(txtMaSP.Text);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    UPDATE SanPham
                    SET TenSanPham = @TenSanPham,
                        LoaiHang = @LoaiHang,
                        DonGia = @DonGia,
                        SoLuongTon = @SoLuongTon
                    WHERE MaSanPham = @MaSanPham";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text.Trim());
                cmd.Parameters.AddWithValue("@LoaiHang", cboLoaiHang.Text);
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@SoLuongTon", int.Parse(txtSoLuongTon.Text.Trim()));
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    LoadSanPham();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm thất bại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null || dgvSanPham.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Không xác định được mã sản phẩm cần xóa!");
                return;
            }

            int maSanPham = int.Parse(txtMaSP.Text);

            // Kiểm tra sản phẩm đã có trong hóa đơn chưa
            if (SanPhamDaCoTrongHoaDon(maSanPham))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn, không thể xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadSanPham();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadSanPham();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["MaSanPham"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["TenSanPham"].Value?.ToString() ?? "";
            cboLoaiHang.Text = row.Cells["LoaiHang"].Value?.ToString() ?? "";
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString() ?? "";
            txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString() ?? "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadSanPham(txtTimKiem.Text.Trim());
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Trim() == "") return;

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!");
                txtDonGia.Focus();
            }
        }

        private void txtSoLuongTon_Leave(object sender, EventArgs e)
        {
            if (txtSoLuongTon.Text.Trim() == "") return;

            if (!int.TryParse(txtSoLuongTon.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên không âm!");
                txtSoLuongTon.Focus();
            }
        }
        private void CapNhatTongMatHang()
        {
            lblTongMatHang.Text = dgvSanPham.Rows.Count.ToString();
        }

        private void txtTenSP_Leave(object sender, EventArgs e)
        {

        }
        private bool SanPhamDaCoTrongHoaDon(int maSanPham)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}