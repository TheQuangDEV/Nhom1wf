using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Quanlybanhangmini
{

    public partial class frmQuanLyNhanVien : Form
    {
        string strKetNoi = @"Data Source=localhost;Initial Catalog=QLBHMN;Integrated Security=True";
        private void LoadDuLieuTuSQL()
        {
            try
            {
                // 1. Tạo một kết nối mới dựa vào chuỗi kết nối ở Bước 2
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open(); // Mở cửa kết nối vào SQL

                    // 2. Viết câu lệnh SQL để lấy dữ liệu
                    string sql = "SELECT * FROM NhanVien";

                    // 3. Dùng SqlDataAdapter (như một chiếc xe tải) chở dữ liệu từ SQL về C#
                    SqlDataAdapter xeTai = new SqlDataAdapter(sql, conn);

                    // 4. Tạo một cái bảng ảo (DataTable) để chứa dữ liệu chở về
                    DataTable dt = new DataTable();
                    xeTai.Fill(dt); // Đổ dữ liệu từ xe tải vào bảng ảo

                    // 5. Hiển thị bảng ảo đó lên DataGridView trên giao diện
                    dgvNhanVien.AutoGenerateColumns = false; // Chặn đẻ thêm cột lung tung
                    dgvNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu lỡ máy chủ SQL chưa bật hoặc sai tên
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Báo lỗi");
            }
        }
        BindingList<NhanVien> dsNhanVien = new BindingList<NhanVien>();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dsNhanVien;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuTuSQL();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào một dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Dùng dấu ? để tránh lỗi nếu dữ liệu trống (DBNull)
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();

                // XỬ LÝ RIÊNG CHO NGÀY SINH ĐỂ CHỐNG LỖI
                if (row.Cells["NgaySinh"].Value != DBNull.Value && row.Cells["NgaySinh"].Value != null)
                {
                    // Nếu có ngày sinh trong CSDL thì gán vào
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                else
                {
                    // Nếu CSDL đang trống, tự động gán ngày hôm nay
                    dtpNgaySinh.Value = DateTime.Now;
                }

                cboDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

                // Xử lý Giới tính an toàn hơn
                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam")
                    rdoNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    rdoNu.Checked = true;
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                } // Bỏ chọn nếu chưa có giới tính

                txtTaiKhoan.Text = row.Cells["TaiKhoan"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtTaiKhoan.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có nhập thiếu Tài khoản không
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Cảnh báo");
                txtTaiKhoan.Focus();
                return;
            }

            // Lấy giới tính
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            // Câu lệnh SQL để thêm dữ liệu
            string sqlInsert = @"INSERT INTO NhanVien (TaiKhoan, TenNhanVien, NgaySinh, DiaChi, GioiTinh, MatKhau, ChucVu, TrangThai) 
                         VALUES (@TaiKhoan, @TenNhanVien, @NgaySinh, @DiaChi, @GioiTinh, @MatKhau, @ChucVu, @TrangThai)";

            try
            {
                // 1. Mở kết nối
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();

                    // 2. Tạo đối tượng mang câu lệnh SQL đi thực thi
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {
                        // 3. Gắn giá trị thực tế từ giao diện vào các tham số @
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@DiaChi", cboDiaChi.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);

                        // 4. Bóp cò! Yêu cầu SQL Server chạy lệnh INSERT
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                // 5. Quan trọng: Gọi lại hàm Load dữ liệu để cái bảng cập nhật ngay lập tức thành viên mới
                LoadDuLieuTuSQL();

                // 6. Gọi hàm xóa trắng Form (Nếu lúc trước bạn có viết hàm này)
                ResetThongTin();
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu Tài khoản bị trùng lặp (vì SQL cài Primary Key sẽ từ chối)
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Tài khoản này đã tồn tại trong CSDL. Vui lòng chọn tên khác!", "Lỗi trùng lặp");
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi");
                }
            }
        }
        // Hàm hỗ trợ xóa trắng các ô nhập liệu
        private void ResetThongTin()
        {
            txtTenNhanVien.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();

            // Đặt lại ngày sinh về ngày hiện tại
            dtpNgaySinh.Value = DateTime.Now;

            // Đặt lại ComboBox về trạng thái trống (chưa chọn gì)
            cboDiaChi.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            // Đặt mặc định giới tính chọn Nam
            rdoNam.Checked = true;
            // Mở khóa lại để nhập tài khoản nhân viên mới
            txtTaiKhoan.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn ai chưa
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng click chọn một nhân viên trên bảng để sửa!", "Cảnh báo");
                return;
            }

            // 2. Câu lệnh SQL UPDATE (Tìm nhân viên theo Tài khoản và ghi đè thông tin mới)
            string sqlUpdate = @"UPDATE NhanVien 
                         SET TenNhanVien = @TenNhanVien, 
                             NgaySinh = @NgaySinh, 
                             DiaChi = @DiaChi, 
                             GioiTinh = @GioiTinh, 
                             MatKhau = @MatKhau, 
                             ChucVu = @ChucVu, 
                             TrangThai = @TrangThai 
                         WHERE TaiKhoan = @TaiKhoan";

            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        // Truyền dữ liệu
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@DiaChi", cboDiaChi.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);

                        // Chạy lệnh Sửa
                        int soDongBiSua = cmd.ExecuteNonQuery();

                        if (soDongBiSua > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                            LoadDuLieuTuSQL();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản này trong CSDL!", "Lỗi");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng click chọn nhân viên cần xóa!", "Cảnh báo");
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên mang tài khoản: " + txtTaiKhoan.Text + "?",
                                                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (xacNhan == DialogResult.Yes)
            {
                // 3. Câu lệnh SQL DELETE
                string sqlDelete = "DELETE FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                try
                {
                    using (SqlConnection conn = new SqlConnection(strKetNoi))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                        {
                            cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);

                            // Chạy lệnh Xóa
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo");
                    LoadDuLieuTuSQL();

                    ResetThongTin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi");
                }
            }
        }

<<<<<<< HEAD
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetThongTin();
            txtTaiKhoan.Focus();
=======
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> 35f2ac3 (thongkedoanhthu)
        }
    }
    public class NhanVien
    {
        public string tennhanvien{ get; set; }
        public DateTime NgaySinh { get; set; }
        public string Diachi { get; set; }
        public string GioiTinh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Chucvu { get; set; }
        public string TrangThai { get; set; }
    }
}
