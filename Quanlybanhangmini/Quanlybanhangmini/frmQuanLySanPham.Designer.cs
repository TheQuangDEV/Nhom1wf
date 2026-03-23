namespace Quanlybanhangmini
{
    partial class frmQuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.tableInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTongMatHang = new System.Windows.Forms.Label();
            this.lblTextTongMatHang = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tableButton.SuspendLayout();
            this.flowButton.SuspendLayout();
            this.tableInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.dgvSanPham, 0, 2);
            this.tableMain.Controls.Add(this.tableButton, 0, 1);
            this.tableMain.Controls.Add(this.tableInput, 0, 0);
            this.tableMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableMain.Size = new System.Drawing.Size(1473, 942);
            this.tableMain.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(4, 395);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1465, 464);
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // tableButton
            // 
            this.tableButton.ColumnCount = 1;
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.Controls.Add(this.flowButton, 0, 0);
            this.tableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButton.Location = new System.Drawing.Point(4, 286);
            this.tableButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.Size = new System.Drawing.Size(1465, 99);
            this.tableButton.TabIndex = 4;
            // 
            // flowButton
            // 
            this.flowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowButton.AutoSize = true;
            this.flowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButton.Controls.Add(this.btnThem);
            this.flowButton.Controls.Add(this.btnSua);
            this.flowButton.Controls.Add(this.btnXoa);
            this.flowButton.Controls.Add(this.btnLamMoi);
            this.flowButton.Location = new System.Drawing.Point(4, 5);
            this.flowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowButton.Name = "flowButton";
            this.flowButton.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.flowButton.Size = new System.Drawing.Size(1457, 89);
            this.flowButton.TabIndex = 5;
            this.flowButton.WrapContents = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(27, 21);
            this.btnThem.Margin = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 55);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(201, 21);
            this.btnSua.Margin = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 55);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(375, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 55);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.AutoSize = true;
            this.btnLamMoi.Location = new System.Drawing.Point(549, 21);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(154, 55);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // tableInput
            // 
            this.tableInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInput.ColumnCount = 4;
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableInput.Controls.Add(this.txtTimKiem, 3, 2);
            this.tableInput.Controls.Add(this.lblTimKiem, 2, 2);
            this.tableInput.Controls.Add(this.txtSoLuongTon, 1, 2);
            this.tableInput.Controls.Add(this.lblSoLuongTon, 0, 2);
            this.tableInput.Controls.Add(this.txtDonGia, 3, 1);
            this.tableInput.Controls.Add(this.lblDonGia, 2, 1);
            this.tableInput.Controls.Add(this.lblLoaiHang, 0, 1);
            this.tableInput.Controls.Add(this.lblMaSP, 0, 0);
            this.tableInput.Controls.Add(this.txtMaSP, 1, 0);
            this.tableInput.Controls.Add(this.txtTenSP, 3, 0);
            this.tableInput.Controls.Add(this.lblTenSP, 2, 0);
            this.tableInput.Controls.Add(this.cboLoaiHang, 1, 1);
            this.tableInput.Location = new System.Drawing.Point(15, 16);
            this.tableInput.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.tableInput.Name = "tableInput";
            this.tableInput.RowCount = 3;
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableInput.Size = new System.Drawing.Size(1443, 249);
            this.tableInput.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.txtTimKiem.Location = new System.Drawing.Point(1012, 191);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(427, 32);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(906, 195);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(98, 25);
            this.lblTimKiem.TabIndex = 12;
            this.lblTimKiem.Text = "Tìm kiếm";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuongTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.txtSoLuongTon.Location = new System.Drawing.Point(292, 191);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(424, 32);
            this.txtSoLuongTon.TabIndex = 11;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            this.txtSoLuongTon.Leave += new System.EventHandler(this.txtSoLuongTon_Leave);
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(151, 195);
            this.lblSoLuongTon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(133, 25);
            this.lblSoLuongTon.TabIndex = 10;
            this.lblSoLuongTon.Text = "Số lượng tồn";
            this.lblSoLuongTon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.txtDonGia.Location = new System.Drawing.Point(1012, 108);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(427, 32);
            this.txtDonGia.TabIndex = 9;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(918, 112);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(86, 25);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Location = new System.Drawing.Point(177, 112);
            this.lblLoaiHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(107, 25);
            this.lblLoaiHang.TabIndex = 6;
            this.lblLoaiHang.Text = "Loại hàng";
            this.lblLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(142, 29);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(142, 25);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.txtMaSP.Location = new System.Drawing.Point(292, 25);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(424, 32);
            this.txtMaSP.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.txtTenSP.Location = new System.Drawing.Point(1012, 25);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(427, 32);
            this.txtTenSP.TabIndex = 5;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(855, 29);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(149, 25);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên sản phẩm";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(292, 107);
            this.cboLoaiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(424, 34);
            this.cboLoaiHang.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTongMatHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextTongMatHang, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 869);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1465, 68);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblTongMatHang
            // 
            this.lblTongMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongMatHang.AutoSize = true;
            this.lblTongMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongMatHang.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTongMatHang.Location = new System.Drawing.Point(304, 0);
            this.lblTongMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongMatHang.Name = "lblTongMatHang";
            this.lblTongMatHang.Size = new System.Drawing.Size(36, 68);
            this.lblTongMatHang.TabIndex = 7;
            this.lblTongMatHang.Text = "0";
            this.lblTongMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextTongMatHang
            // 
            this.lblTextTongMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextTongMatHang.AutoSize = true;
            this.lblTextTongMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTongMatHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTextTongMatHang.Location = new System.Drawing.Point(38, 0);
            this.lblTextTongMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextTongMatHang.Name = "lblTextTongMatHang";
            this.lblTextTongMatHang.Size = new System.Drawing.Size(258, 68);
            this.lblTextTongMatHang.TabIndex = 6;
            this.lblTextTongMatHang.Text = "Tổng mặt hàng:";
            this.lblTextTongMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 942);
            this.Controls.Add(this.tableMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            this.tableMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tableButton.ResumeLayout(false);
            this.tableButton.PerformLayout();
            this.flowButton.ResumeLayout(false);
            this.flowButton.PerformLayout();
            this.tableInput.ResumeLayout(false);
            this.tableInput.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableInput;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.FlowLayoutPanel flowButton;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextTongMatHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTongMatHang;
    }
}