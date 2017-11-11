namespace GUI
{
    partial class NhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchNgay = new System.Windows.Forms.TextBox();
            this.txtSearchCV = new System.Windows.Forms.TextBox();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchSDT = new System.Windows.Forms.TextBox();
            this.txtSearchQQ = new System.Windows.Forms.TextBox();
            this.txtSearchDC = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.cboSearchGT = new System.Windows.Forms.ComboBox();
            this.txtSearchMa = new System.Windows.Forms.TextBox();
            this.txtSearchTen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12_5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHoTen,
            this.colMaNV,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.QueQuan,
            this.SDT,
            this.Email,
            this.ChucVu});
            this.dgvNhanVien.Enabled = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 10);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(846, 382);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNhanVien";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            this.QueQuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SoDienThoai";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(870, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(116, 249);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 25);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Location = new System.Drawing.Point(33, 249);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 25);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Đồng ý";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(55, 193);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(168, 20);
            this.txtChucVu.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(41, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(77, 148);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(144, 20);
            this.txtSDT.TabIndex = 15;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Location = new System.Drawing.Point(62, 125);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(159, 20);
            this.txtQueQuan.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(48, 102);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(174, 20);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(80, 32);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(143, 20);
            this.txtMa.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(48, 10);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 20);
            this.txtHoTen.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quê quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(55, 78);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(167, 21);
            this.cboGioiTinh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(63, 55);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(159, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(872, 316);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(225, 22);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhSua.Location = new System.Drawing.Point(872, 343);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(225, 22);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Sửa thông tin nhân viên";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(871, 370);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(225, 22);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa nhân viên";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSearchNgay);
            this.groupBox2.Controls.Add(this.txtSearchCV);
            this.groupBox2.Controls.Add(this.txtSearchEmail);
            this.groupBox2.Controls.Add(this.txtSearchSDT);
            this.groupBox2.Controls.Add(this.txtSearchQQ);
            this.groupBox2.Controls.Add(this.txtSearchDC);
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.cboSearchGT);
            this.groupBox2.Controls.Add(this.txtSearchMa);
            this.groupBox2.Controls.Add(this.txtSearchTen);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12_5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(9, 396);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1088, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtSearchNgay
            // 
            this.txtSearchNgay.Location = new System.Drawing.Point(84, 70);
            this.txtSearchNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchNgay.Name = "txtSearchNgay";
            this.txtSearchNgay.Size = new System.Drawing.Size(180, 20);
            this.txtSearchNgay.TabIndex = 20;
            // 
            // txtSearchCV
            // 
            this.txtSearchCV.Location = new System.Drawing.Point(662, 70);
            this.txtSearchCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchCV.Name = "txtSearchCV";
            this.txtSearchCV.Size = new System.Drawing.Size(185, 20);
            this.txtSearchCV.TabIndex = 19;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(662, 47);
            this.txtSearchEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(185, 20);
            this.txtSearchEmail.TabIndex = 18;
            // 
            // txtSearchSDT
            // 
            this.txtSearchSDT.Location = new System.Drawing.Point(662, 22);
            this.txtSearchSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchSDT.Name = "txtSearchSDT";
            this.txtSearchSDT.Size = new System.Drawing.Size(185, 20);
            this.txtSearchSDT.TabIndex = 17;
            // 
            // txtSearchQQ
            // 
            this.txtSearchQQ.Location = new System.Drawing.Point(375, 70);
            this.txtSearchQQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchQQ.Name = "txtSearchQQ";
            this.txtSearchQQ.Size = new System.Drawing.Size(181, 20);
            this.txtSearchQQ.TabIndex = 16;
            // 
            // txtSearchDC
            // 
            this.txtSearchDC.Location = new System.Drawing.Point(375, 47);
            this.txtSearchDC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchDC.Name = "txtSearchDC";
            this.txtSearchDC.Size = new System.Drawing.Size(181, 20);
            this.txtSearchDC.TabIndex = 15;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(910, 59);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 24);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cboSearchGT
            // 
            this.cboSearchGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchGT.FormattingEnabled = true;
            this.cboSearchGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Tất cả"});
            this.cboSearchGT.Location = new System.Drawing.Point(375, 22);
            this.cboSearchGT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSearchGT.Name = "cboSearchGT";
            this.cboSearchGT.Size = new System.Drawing.Size(181, 21);
            this.cboSearchGT.TabIndex = 13;
            // 
            // txtSearchMa
            // 
            this.txtSearchMa.Location = new System.Drawing.Point(84, 47);
            this.txtSearchMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchMa.Name = "txtSearchMa";
            this.txtSearchMa.Size = new System.Drawing.Size(180, 20);
            this.txtSearchMa.TabIndex = 11;
            // 
            // txtSearchTen
            // 
            this.txtSearchTen.Location = new System.Drawing.Point(84, 22);
            this.txtSearchTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchTen.Name = "txtSearchTen";
            this.txtSearchTen.Size = new System.Drawing.Size(180, 20);
            this.txtSearchTen.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(910, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 24);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(590, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Chức vụ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(590, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(590, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Số điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quê quán";
            // 
            // label12_5
            // 
            this.label12_5.AutoSize = true;
            this.label12_5.Location = new System.Drawing.Point(317, 50);
            this.label12_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12_5.Name = "label12_5";
            this.label12_5.Size = new System.Drawing.Size(40, 13);
            this.label12_5.TabIndex = 4;
            this.label12_5.Text = "Địa chỉ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 24);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ngày sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Họ tên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhanVien";
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVien_FormClosing);
            this.Load += new System.EventHandler(this.NhanVien_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchMa;
        private System.Windows.Forms.TextBox txtSearchTen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12_5;
        private System.Windows.Forms.TextBox txtSearchCV;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchSDT;
        private System.Windows.Forms.TextBox txtSearchQQ;
        private System.Windows.Forms.TextBox txtSearchDC;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cboSearchGT;
        private System.Windows.Forms.TextBox txtSearchNgay;
    }
}