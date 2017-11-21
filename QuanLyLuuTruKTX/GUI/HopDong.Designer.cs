using System.Windows.Forms;
using System.Drawing;
using System;
using BUS;
namespace GUI
{
    partial class HopDong
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chxTheoTinhTrang = new System.Windows.Forms.RadioButton();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.dtpNgayKetThucTimKiem = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDauTimKiem = new System.Windows.Forms.DateTimePicker();
            this.chxTheoThoiHan = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.cboTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.themMode = new System.Windows.Forms.Button();
            this.suaMode = new System.Windows.Forms.Button();
            this.xemMode = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonPhong = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtGiaTienTongCong = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGiaTienDaNop = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtChuThich = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblKhuNha = new System.Windows.Forms.Label();
            this.lblNotSuitableRoom = new System.Windows.Forms.Label();
            this.lblNotFoundMSSV = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDienUuTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNguoiLap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.btnXemSinhVien = new System.Windows.Forms.Button();
            this.btnXemPhong = new System.Windows.Forms.Button();
            this.btnChonMSSV = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemSinhViênToolStripMenuItem,
            this.xemPhòngToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // xemSinhViênToolStripMenuItem
            // 
            this.xemSinhViênToolStripMenuItem.Name = "xemSinhViênToolStripMenuItem";
            this.xemSinhViênToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.xemSinhViênToolStripMenuItem.Text = "Xem sinh viên";
            this.xemSinhViênToolStripMenuItem.Click += new System.EventHandler(this.btnXemSinhVien_Click);
            // 
            // xemPhòngToolStripMenuItem
            // 
            this.xemPhòngToolStripMenuItem.Name = "xemPhòngToolStripMenuItem";
            this.xemPhòngToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.xemPhòngToolStripMenuItem.Text = "Xem phòng";
            this.xemPhòngToolStripMenuItem.Click += new System.EventHandler(this.btnXemPhong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(16, 477);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(229, 23);
            this.btnIn.TabIndex = 45;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(16, 341);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(229, 23);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chxTheoTinhTrang
            // 
            this.chxTheoTinhTrang.AutoSize = true;
            this.chxTheoTinhTrang.Checked = true;
            this.chxTheoTinhTrang.Location = new System.Drawing.Point(21, 169);
            this.chxTheoTinhTrang.Name = "chxTheoTinhTrang";
            this.chxTheoTinhTrang.Size = new System.Drawing.Size(97, 17);
            this.chxTheoTinhTrang.TabIndex = 43;
            this.chxTheoTinhTrang.TabStop = true;
            this.chxTheoTinhTrang.Text = "Theo tình trạng";
            this.chxTheoTinhTrang.UseVisualStyleBackColor = true;
            this.chxTheoTinhTrang.CheckedChanged += new System.EventHandler(this.chxTheoTinhTrang_CheckedChanged);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(16, 290);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(229, 23);
            this.btnXemTatCa.TabIndex = 42;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // dtpNgayKetThucTimKiem
            // 
            this.dtpNgayKetThucTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThucTimKiem.Location = new System.Drawing.Point(138, 230);
            this.dtpNgayKetThucTimKiem.Name = "dtpNgayKetThucTimKiem";
            this.dtpNgayKetThucTimKiem.Size = new System.Drawing.Size(107, 20);
            this.dtpNgayKetThucTimKiem.TabIndex = 40;
            this.dtpNgayKetThucTimKiem.ValueChanged += new System.EventHandler(this.dtpNgayKetThucTimKiem_ValueChanged);
            // 
            // dtpNgayBatDauTimKiem
            // 
            this.dtpNgayBatDauTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDauTimKiem.Location = new System.Drawing.Point(138, 198);
            this.dtpNgayBatDauTimKiem.Name = "dtpNgayBatDauTimKiem";
            this.dtpNgayBatDauTimKiem.Size = new System.Drawing.Size(107, 20);
            this.dtpNgayBatDauTimKiem.TabIndex = 39;
            this.dtpNgayBatDauTimKiem.ValueChanged += new System.EventHandler(this.dtpNgayBatDauTimKiem_ValueChanged);
            // 
            // chxTheoThoiHan
            // 
            this.chxTheoThoiHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chxTheoThoiHan.AutoSize = true;
            this.chxTheoThoiHan.Location = new System.Drawing.Point(21, 199);
            this.chxTheoThoiHan.Name = "chxTheoThoiHan";
            this.chxTheoThoiHan.Size = new System.Drawing.Size(110, 17);
            this.chxTheoThoiHan.TabIndex = 37;
            this.chxTheoThoiHan.Text = "Theo thời hạn: Từ";
            this.chxTheoThoiHan.UseVisualStyleBackColor = true;
            this.chxTheoThoiHan.CheckedChanged += new System.EventHandler(this.chxTheoThoiHan_CheckedChanged);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(106, 234);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 13);
            this.label24.TabIndex = 36;
            this.label24.Text = "đến";
            // 
            // cboTimKiemTheo
            // 
            this.cboTimKiemTheo.FormattingEnabled = true;
            this.cboTimKiemTheo.Items.AddRange(new object[] {
            "Tất cả",
            "Mã số",
            "MSSV",
            "Người lập",
            "Ngày lập",
            "ID Phòng"});
            this.cboTimKiemTheo.Location = new System.Drawing.Point(16, 120);
            this.cboTimKiemTheo.Name = "cboTimKiemTheo";
            this.cboTimKiemTheo.Size = new System.Drawing.Size(97, 21);
            this.cboTimKiemTheo.TabIndex = 32;
            this.cboTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemTheo_SelectedIndexChanged);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa tới thời hạn",
            "Trong thời hạn",
            "Hết thời hạn"});
            this.cboTinhTrang.Location = new System.Drawing.Point(124, 166);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cboTinhTrang.TabIndex = 30;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboThoiHan_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(119, 120);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(126, 20);
            this.txtTimKiem.TabIndex = 28;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // themMode
            // 
            this.themMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themMode.Location = new System.Drawing.Point(1093, 12);
            this.themMode.Name = "themMode";
            this.themMode.Size = new System.Drawing.Size(75, 23);
            this.themMode.TabIndex = 27;
            this.themMode.Text = "Thêm";
            this.themMode.UseVisualStyleBackColor = true;
            this.themMode.Click += new System.EventHandler(this.themMode_Click);
            // 
            // suaMode
            // 
            this.suaMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suaMode.Location = new System.Drawing.Point(1165, 12);
            this.suaMode.Name = "suaMode";
            this.suaMode.Size = new System.Drawing.Size(75, 23);
            this.suaMode.TabIndex = 26;
            this.suaMode.Text = "Sửa";
            this.suaMode.UseVisualStyleBackColor = true;
            this.suaMode.Click += new System.EventHandler(this.suaMode_Click);
            // 
            // xemMode
            // 
            this.xemMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xemMode.Location = new System.Drawing.Point(1021, 12);
            this.xemMode.Name = "xemMode";
            this.xemMode.Size = new System.Drawing.Size(75, 23);
            this.xemMode.TabIndex = 25;
            this.xemMode.Text = "Xem";
            this.xemMode.UseVisualStyleBackColor = true;
            this.xemMode.Click += new System.EventHandler(this.xemMode_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHopDong.Location = new System.Drawing.Point(1087, 633);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(75, 23);
            this.btnHopDong.TabIndex = 24;
            this.btnHopDong.Text = "Thêm hợp đồng mới";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnChonMSSV);
            this.panel1.Controls.Add(this.btnChonPhong);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.lblGioiTinh);
            this.panel1.Controls.Add(this.txtGiaTienTongCong);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtGiaTienDaNop);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtChuThich);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lblKhuNha);
            this.panel1.Controls.Add(this.lblNotSuitableRoom);
            this.panel1.Controls.Add(this.lblNotFoundMSSV);
            this.panel1.Controls.Add(this.txtIDPhong);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblTinhTrang);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblDienUuTien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblQueQuan);
            this.panel1.Controls.Add(this.picAnh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblKhoa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblSoDienThoai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCMND);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblMaSo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNguoiLap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtMSSV);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(941, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 586);
            this.panel1.TabIndex = 22;
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonPhong.Location = new System.Drawing.Point(187, 354);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.Size = new System.Drawing.Size(40, 23);
            this.btnChonPhong.TabIndex = 48;
            this.btnChonPhong.Text = "Chọn";
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(230, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 75;
            this.label23.Text = "Giới tính:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(293, 181);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(46, 13);
            this.lblGioiTinh.TabIndex = 74;
            this.lblGioiTinh.Text = "GioiTinh";
            // 
            // txtGiaTienTongCong
            // 
            this.txtGiaTienTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTienTongCong.Location = new System.Drawing.Point(249, 457);
            this.txtGiaTienTongCong.Name = "txtGiaTienTongCong";
            this.txtGiaTienTongCong.Size = new System.Drawing.Size(90, 20);
            this.txtGiaTienTongCong.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(187, 461);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Tổng cộng";
            // 
            // txtGiaTienDaNop
            // 
            this.txtGiaTienDaNop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTienDaNop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTienDaNop.Location = new System.Drawing.Point(91, 458);
            this.txtGiaTienDaNop.Name = "txtGiaTienDaNop";
            this.txtGiaTienDaNop.Size = new System.Drawing.Size(90, 20);
            this.txtGiaTienDaNop.TabIndex = 71;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 464);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 70;
            this.label18.Text = "Đã nộp:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "Chú thích:";
            // 
            // txtChuThich
            // 
            this.txtChuThich.Location = new System.Drawing.Point(94, 300);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Size = new System.Drawing.Size(249, 43);
            this.txtChuThich.TabIndex = 68;
            this.txtChuThich.Text = "";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Số phòng: ";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(93, 410);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(51, 13);
            this.lblSoPhong.TabIndex = 66;
            this.lblSoPhong.Text = "SoPhong";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 386);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Khu nhà:";
            // 
            // lblKhuNha
            // 
            this.lblKhuNha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhuNha.AutoSize = true;
            this.lblKhuNha.Location = new System.Drawing.Point(93, 386);
            this.lblKhuNha.Name = "lblKhuNha";
            this.lblKhuNha.Size = new System.Drawing.Size(46, 13);
            this.lblKhuNha.TabIndex = 64;
            this.lblKhuNha.Text = "KhuNha";
            // 
            // lblNotSuitableRoom
            // 
            this.lblNotSuitableRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotSuitableRoom.AutoSize = true;
            this.lblNotSuitableRoom.ForeColor = System.Drawing.Color.Red;
            this.lblNotSuitableRoom.Location = new System.Drawing.Point(230, 359);
            this.lblNotSuitableRoom.Name = "lblNotSuitableRoom";
            this.lblNotSuitableRoom.Size = new System.Drawing.Size(113, 13);
            this.lblNotSuitableRoom.TabIndex = 63;
            this.lblNotSuitableRoom.Text = "Phòng không phù hợp";
            // 
            // lblNotFoundMSSV
            // 
            this.lblNotFoundMSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotFoundMSSV.AutoSize = true;
            this.lblNotFoundMSSV.ForeColor = System.Drawing.Color.Red;
            this.lblNotFoundMSSV.Location = new System.Drawing.Point(45, 69);
            this.lblNotFoundMSSV.Name = "lblNotFoundMSSV";
            this.lblNotFoundMSSV.Size = new System.Drawing.Size(110, 13);
            this.lblNotFoundMSSV.TabIndex = 62;
            this.lblNotFoundMSSV.Text = "Không tìm thấy MSSV";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDPhong.Location = new System.Drawing.Point(96, 356);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(85, 20);
            this.txtIDPhong.TabIndex = 61;
            this.txtIDPhong.TextChanged += new System.EventHandler(this.txtIDPhong_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "IDPhong:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Tình trạng:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(140, 523);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(56, 13);
            this.lblTinhTrang.TabIndex = 57;
            this.lblTinhTrang.Text = "TinhTrang";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(91, 277);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Diện ưu tiên:";
            // 
            // lblDienUuTien
            // 
            this.lblDienUuTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDienUuTien.AutoSize = true;
            this.lblDienUuTien.Location = new System.Drawing.Point(91, 254);
            this.lblDienUuTien.Name = "lblDienUuTien";
            this.lblDienUuTien.Size = new System.Drawing.Size(64, 13);
            this.lblDienUuTien.TabIndex = 53;
            this.lblDienUuTien.Text = "DienUuTien";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Quê quán:";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(91, 230);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(53, 13);
            this.lblQueQuan.TabIndex = 51;
            this.lblQueQuan.Text = "QueQuan";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(233, 43);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(111, 132);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 50;
            this.picAnh.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Khoa:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(91, 206);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 48;
            this.lblKhoa.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "SĐT:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(91, 181);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(69, 13);
            this.lblSoDienThoai.TabIndex = 46;
            this.lblSoDienThoai.Text = "SoDienThoai";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "CMND:";
            // 
            // lblCMND
            // 
            this.lblCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(91, 157);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(39, 13);
            this.lblCMND.TabIndex = 44;
            this.lblCMND.Text = "CMND";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày sinh:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(91, 132);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(53, 13);
            this.lblNgaySinh.TabIndex = 40;
            this.lblNgaySinh.Text = "NgaySinh";
            // 
            // lblMaSo
            // 
            this.lblMaSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaSo.Location = new System.Drawing.Point(269, 14);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(80, 13);
            this.lblMaSo.TabIndex = 39;
            this.lblMaSo.Text = "MaSo";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Họ tên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(91, 109);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(40, 13);
            this.lblHoTen.TabIndex = 37;
            this.lblHoTen.Text = "HoTen";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Người lập: ";
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNguoiLap.AutoSize = true;
            this.lblNguoiLap.Location = new System.Drawing.Point(246, 570);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Size = new System.Drawing.Size(33, 13);
            this.lblNguoiLap.TabIndex = 35;
            this.lblNguoiLap.Text = "name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày lập: ";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(246, 550);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(24, 13);
            this.lblNgayLap.TabIndex = 33;
            this.lblNgayLap.Text = "day";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(262, 495);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(85, 20);
            this.dtpNgayKetThuc.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "đến";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(141, 495);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(83, 20);
            this.dtpNgayBatDau.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Thời hạn: Từ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMSSV.Location = new System.Drawing.Point(54, 43);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(90, 20);
            this.txtMSSV.TabIndex = 24;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mã hợp đồng";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.ContextMenuStrip = this.contextMenuStrip;
            this.dgvHopDong.Location = new System.Drawing.Point(259, 12);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(666, 663);
            this.dgvHopDong.TabIndex = 0;
            this.dgvHopDong.SelectionChanged += new System.EventHandler(this.dgvHopDong_SelectionChanged);
            // 
            // btnXemSinhVien
            // 
            this.btnXemSinhVien.Location = new System.Drawing.Point(16, 417);
            this.btnXemSinhVien.Name = "btnXemSinhVien";
            this.btnXemSinhVien.Size = new System.Drawing.Size(229, 23);
            this.btnXemSinhVien.TabIndex = 46;
            this.btnXemSinhVien.Text = "Xem sinh viên";
            this.btnXemSinhVien.UseVisualStyleBackColor = true;
            this.btnXemSinhVien.Click += new System.EventHandler(this.btnXemSinhVien_Click);
            // 
            // btnXemPhong
            // 
            this.btnXemPhong.Location = new System.Drawing.Point(12, 441);
            this.btnXemPhong.Name = "btnXemPhong";
            this.btnXemPhong.Size = new System.Drawing.Size(229, 23);
            this.btnXemPhong.TabIndex = 47;
            this.btnXemPhong.Text = "Xem phòng";
            this.btnXemPhong.UseVisualStyleBackColor = true;
            this.btnXemPhong.Click += new System.EventHandler(this.btnXemPhong_Click);
            // 
            // btnChonMSSV
            // 
            this.btnChonMSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonMSSV.Location = new System.Drawing.Point(152, 42);
            this.btnChonMSSV.Name = "btnChonMSSV";
            this.btnChonMSSV.Size = new System.Drawing.Size(49, 23);
            this.btnChonMSSV.TabIndex = 76;
            this.btnChonMSSV.Text = "Chọn";
            this.btnChonMSSV.UseVisualStyleBackColor = true;
            this.btnChonMSSV.Click += new System.EventHandler(this.btnChonMSSV_Click);
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 687);
            this.Controls.Add(this.btnXemPhong);
            this.Controls.Add(this.btnXemSinhVien);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.chxTheoTinhTrang);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.dtpNgayKetThucTimKiem);
            this.Controls.Add(this.dtpNgayBatDauTimKiem);
            this.Controls.Add(this.chxTheoThoiHan);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cboTimKiemTheo);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.themMode);
            this.Controls.Add(this.suaMode);
            this.Controls.Add(this.xemMode);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHopDong);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "HopDong";
            this.Text = "Hợp đồng";
            this.Activated += new System.EventHandler(this.HopDong_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HopDong_FormClosing);
            this.Load += new System.EventHandler(this.HopDong_Load);
            this.Resize += new System.EventHandler(this.HopDong_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNguoiLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDienUuTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label lblNotFoundMSSV;
        private System.Windows.Forms.Label lblNotSuitableRoom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblKhuNha;
        private System.Windows.Forms.TextBox txtGiaTienTongCong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGiaTienDaNop;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtChuThich;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button xemMode;
        private System.Windows.Forms.Button suaMode;
        private System.Windows.Forms.Button themMode;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ComboBox cboTimKiemTheo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton chxTheoThoiHan;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDauTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThucTimKiem;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.RadioButton chxTheoTinhTrang;


        private void SetCheDo(CheDo state)
        {
            CheDoHienTai = state;
            if (state == CheDo.XEM)
            {
                xemMode.BackColor = Color.LightSlateGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightGray;
                txtMSSV.Enabled = false;
                txtChuThich.Enabled = false;
                txtIDPhong.Enabled = false;
                txtGiaTienDaNop.Enabled = false;
                txtGiaTienTongCong.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;

                btnHopDong.Hide();
                btnChonPhong.Hide();
            }
            else if (state == CheDo.SUA)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightSlateGray;
                themMode.BackColor = Color.LightGray;

                txtMSSV.Enabled = false;
                txtChuThich.Enabled = false;
                txtIDPhong.Enabled = false;
                txtGiaTienDaNop.Enabled = false;
                txtGiaTienTongCong.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;
                btnHopDong.Show();
            }
            else if (state == CheDo.THEM)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightSlateGray;

                txtMSSV.Enabled = true;
                txtChuThich.Enabled = true;
                txtIDPhong.Enabled = true;
                txtGiaTienDaNop.Enabled = true;
                txtGiaTienTongCong.Enabled = true;
                dtpNgayBatDau.Enabled = true;
                dtpNgayKetThuc.Enabled = true;

                lblHoTen.Text = "";
                lblNgaySinh.Text = "";
                lblCMND.Text = "";
                lblSoDienThoai.Text = "";
                lblKhoa.Text = "";
                lblQueQuan.Text = "";
                lblDienUuTien.Text = "";
                lblEmail.Text = "";

                lblMaSo.Text = "";
                txtMSSV.Text = "";
                txtChuThich.Text = "";
                txtIDPhong.Text = "";
                txtGiaTienDaNop.Text = "0";
                txtGiaTienTongCong.Text = "0";
                lblTinhTrang.Text = "Chưa tới thời hạn";
                lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblNguoiLap.Text = NhanVienBUS.GetHoTen(MainForm.MaNhanVienHienTai);
                btnHopDong.Text = "Thêm hợp đồng";
                btnChonPhong.Show();
                btnHopDong.Show();
            }
        }

        private Button btnXoa;
        private Button btnIn;
        private Button btnXemSinhVien;
        private ToolStripMenuItem xemSinhViênToolStripMenuItem;
        private ToolStripMenuItem xemPhòngToolStripMenuItem;
        private Button btnXemPhong;
        private Button btnChonPhong;
        private Button btnChonMSSV;
    }
}