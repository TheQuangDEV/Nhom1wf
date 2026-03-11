namespace quanlynhanvien_cuahangmini
{
    partial class frmQuanLyNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTenNhanVien = new TextBox();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            cboDiaChi = new ComboBox();
            cboChucVu = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvNhanVien = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label7 = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            label8 = new Label();
            cboTrangThai = new ComboBox();
            tennhanvien = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Diachi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            TaiKhoan = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            Chucvu = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(36, 16);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(36, 48);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(36, 81);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(410, 16);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(411, 48);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(411, 85);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Chức vụ";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(137, 14);
            txtTenNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(143, 23);
            txtTenNhanVien.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(486, 16);
            txtTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(143, 23);
            txtTaiKhoan.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(486, 46);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(143, 23);
            txtMatKhau.TabIndex = 8;
            // 
            // cboDiaChi
            // 
            cboDiaChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiaChi.FormattingEnabled = true;
            cboDiaChi.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "TP. Hồ Chí Minh", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cboDiaChi.Location = new Point(137, 79);
            cboDiaChi.Margin = new Padding(3, 2, 3, 2);
            cboDiaChi.Name = "cboDiaChi";
            cboDiaChi.Size = new Size(143, 23);
            cboDiaChi.TabIndex = 9;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Admin", "Nhân viên" });
            cboChucVu.Location = new Point(486, 79);
            cboChucVu.Margin = new Padding(3, 2, 3, 2);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(143, 23);
            cboChucVu.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.ImeMode = ImeMode.NoControl;
            dtpNgaySinh.Location = new Point(137, 44);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(143, 23);
            dtpNgaySinh.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvNhanVien);
            flowLayoutPanel1.Location = new Point(7, 217);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(679, 167);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { tennhanvien, NgaySinh, Diachi, GioiTinh, TaiKhoan, MatKhau, Chucvu, TrangThai });
            dgvNhanVien.Location = new Point(3, 2);
            dgvNhanVien.Margin = new Padding(3, 2, 3, 2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(676, 165);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnThem);
            flowLayoutPanel2.Controls.Add(btnSua);
            flowLayoutPanel2.Controls.Add(btnXoa);
            flowLayoutPanel2.Location = new Point(424, 173);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(264, 40);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 38);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Location = new Point(91, 2);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 38);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Location = new Point(179, 2);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 38);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(36, 117);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 14;
            label7.Text = "Giới tính";
            label7.Click += label7_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(137, 117);
            rdoNam.Margin = new Padding(3, 2, 3, 2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 15;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(197, 117);
            rdoNu.Margin = new Padding(3, 2, 3, 2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 16;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(411, 119);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 17;
            label8.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Nghỉ việc", "Đang làm" });
            cboTrangThai.Location = new Point(486, 114);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(143, 23);
            cboTrangThai.TabIndex = 18;
            // 
            // tennhanvien
            // 
            tennhanvien.DataPropertyName = "tennhanvien";
            tennhanvien.HeaderText = "Tên nhân viên";
            tennhanvien.MinimumWidth = 6;
            tennhanvien.Name = "tennhanvien";
            tennhanvien.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // Diachi
            // 
            Diachi.DataPropertyName = "Diachi";
            Diachi.HeaderText = "Địa chỉ";
            Diachi.MinimumWidth = 6;
            Diachi.Name = "Diachi";
            Diachi.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            TaiKhoan.DataPropertyName = "TaiKhoan";
            TaiKhoan.HeaderText = "Tài khoản";
            TaiKhoan.MinimumWidth = 6;
            TaiKhoan.Name = "TaiKhoan";
            TaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // Chucvu
            // 
            Chucvu.DataPropertyName = "Chucvu";
            Chucvu.HeaderText = "Chức vụ";
            Chucvu.MinimumWidth = 6;
            Chucvu.Name = "Chucvu";
            Chucvu.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 395);
            Controls.Add(cboTrangThai);
            Controls.Add(label8);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(label7);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cboChucVu);
            Controls.Add(cboDiaChi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtTenNhanVien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTenNhanVien;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private ComboBox cboDiaChi;
        private ComboBox cboChucVu;
        private DateTimePicker dtpNgaySinh;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvNhanVien;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnThem;
        private Label label7;
        private Button btnSua;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Button btnXoa;
        private Label label8;
        private ComboBox cboTrangThai;
        private DataGridViewTextBoxColumn tennhanvien;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Diachi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn TaiKhoan;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn Chucvu;
        private DataGridViewTextBoxColumn TrangThai;
    }
}
