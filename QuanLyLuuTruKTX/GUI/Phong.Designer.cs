namespace GUI
{
    partial class Phong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.tabCtrlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAdavanceSearch = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTimKiemStatus = new System.Windows.Forms.ComboBox();
            this.numUDTimKiemSoLuongHienTai = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTimKiemLoaiPhong = new System.Windows.Forms.ComboBox();
            this.tbTimKiemSoPhong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTimKiemKhuNha = new System.Windows.Forms.ComboBox();
            this.tbTimKiemMaNhanVien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAddLoaiPhong = new System.Windows.Forms.ComboBox();
            this.tbAddSoPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAddKhuNha = new System.Windows.Forms.ComboBox();
            this.tbAddMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.tabPageChange = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChangeLoaiPhong = new System.Windows.Forms.ComboBox();
            this.tbChangeSoPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbChangeKhuNha = new System.Windows.Forms.ComboBox();
            this.tbChangeMaNhanVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbChangeStatus = new System.Windows.Forms.ComboBox();
            this.numUDChangeSoLuongHienTai = new System.Windows.Forms.NumericUpDown();
            this.btnChangeRoom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabCtrlRoom.SuspendLayout();
            this.tabPageAdavanceSearch.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTimKiemSoLuongHienTai)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageChange.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeSoLuongHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AllowUserToResizeRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(296, 65);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(13);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(628, 418);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabCtrlRoom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 499);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9);
            this.label1.Size = new System.Drawing.Size(272, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỀU KHIỂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Controls.Add(this.tbSearch);
            this.flowLayoutPanel2.Controls.Add(this.btnViewAll);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(286, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(648, 43);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(518, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(313, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(195, 26);
            this.tbSearch.TabIndex = 3;
            // 
            // btnViewAll
            // 
            this.btnViewAll.AutoSize = true;
            this.btnViewAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewAll.Location = new System.Drawing.Point(178, 5);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(125, 29);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "Tải lại";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // tabCtrlRoom
            // 
            this.tabCtrlRoom.Controls.Add(this.tabPageAdavanceSearch);
            this.tabCtrlRoom.Controls.Add(this.tabPageAdd);
            this.tabCtrlRoom.Controls.Add(this.tabPageChange);
            this.tabCtrlRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlRoom.Location = new System.Drawing.Point(6, 55);
            this.tabCtrlRoom.Name = "tabCtrlRoom";
            this.tabCtrlRoom.SelectedIndex = 0;
            this.tabCtrlRoom.Size = new System.Drawing.Size(274, 438);
            this.tabCtrlRoom.TabIndex = 4;
            // 
            // tabPageAdavanceSearch
            // 
            this.tabPageAdavanceSearch.AutoScroll = true;
            this.tabPageAdavanceSearch.Controls.Add(this.flowLayoutPanel4);
            this.tabPageAdavanceSearch.Location = new System.Drawing.Point(4, 27);
            this.tabPageAdavanceSearch.Name = "tabPageAdavanceSearch";
            this.tabPageAdavanceSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdavanceSearch.Size = new System.Drawing.Size(266, 407);
            this.tabPageAdavanceSearch.TabIndex = 2;
            this.tabPageAdavanceSearch.Text = "Tìm kiếm nâng cao";
            this.tabPageAdavanceSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(282, 401);
            this.flowLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbTimKiemStatus, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.numUDTimKiemSoLuongHienTai, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbTimKiemLoaiPhong, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbTimKiemSoPhong, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbTimKiemKhuNha, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbTimKiemMaNhanVien, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(276, 210);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 35);
            this.label16.TabIndex = 18;
            this.label16.Text = "Số lượng hiện tại:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(3, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 35);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mã nhân viên:";
            // 
            // cbTimKiemStatus
            // 
            this.cbTimKiemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTimKiemStatus.FormattingEnabled = true;
            this.cbTimKiemStatus.Items.AddRange(new object[] {
            "Còn trống",
            "Hết chỗ"});
            this.cbTimKiemStatus.Location = new System.Drawing.Point(127, 178);
            this.cbTimKiemStatus.Name = "cbTimKiemStatus";
            this.cbTimKiemStatus.Size = new System.Drawing.Size(146, 26);
            this.cbTimKiemStatus.TabIndex = 19;
            // 
            // numUDTimKiemSoLuongHienTai
            // 
            this.numUDTimKiemSoLuongHienTai.AutoSize = true;
            this.numUDTimKiemSoLuongHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDTimKiemSoLuongHienTai.Location = new System.Drawing.Point(127, 143);
            this.numUDTimKiemSoLuongHienTai.Name = "numUDTimKiemSoLuongHienTai";
            this.numUDTimKiemSoLuongHienTai.Size = new System.Drawing.Size(146, 26);
            this.numUDTimKiemSoLuongHienTai.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(3, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 35);
            this.label13.TabIndex = 2;
            this.label13.Text = "Loại phòng:";
            // 
            // cbTimKiemLoaiPhong
            // 
            this.cbTimKiemLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTimKiemLoaiPhong.FormattingEnabled = true;
            this.cbTimKiemLoaiPhong.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cbTimKiemLoaiPhong.Location = new System.Drawing.Point(127, 73);
            this.cbTimKiemLoaiPhong.Name = "cbTimKiemLoaiPhong";
            this.cbTimKiemLoaiPhong.Size = new System.Drawing.Size(146, 26);
            this.cbTimKiemLoaiPhong.TabIndex = 13;
            // 
            // tbTimKiemSoPhong
            // 
            this.tbTimKiemSoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimKiemSoPhong.Location = new System.Drawing.Point(127, 38);
            this.tbTimKiemSoPhong.MaxLength = 3;
            this.tbTimKiemSoPhong.Name = "tbTimKiemSoPhong";
            this.tbTimKiemSoPhong.Size = new System.Drawing.Size(146, 26);
            this.tbTimKiemSoPhong.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(3, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 35);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số phòng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 35);
            this.label15.TabIndex = 4;
            this.label15.Text = "Khu nhà:";
            // 
            // cbTimKiemKhuNha
            // 
            this.cbTimKiemKhuNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTimKiemKhuNha.FormattingEnabled = true;
            this.cbTimKiemKhuNha.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "C1",
            "C2",
            "C3",
            "H1",
            "H2",
            "H6"});
            this.cbTimKiemKhuNha.Location = new System.Drawing.Point(127, 3);
            this.cbTimKiemKhuNha.Name = "cbTimKiemKhuNha";
            this.cbTimKiemKhuNha.Size = new System.Drawing.Size(146, 26);
            this.cbTimKiemKhuNha.Sorted = true;
            this.cbTimKiemKhuNha.TabIndex = 5;
            // 
            // tbTimKiemMaNhanVien
            // 
            this.tbTimKiemMaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimKiemMaNhanVien.Location = new System.Drawing.Point(127, 108);
            this.tbTimKiemMaNhanVien.MaxLength = 10;
            this.tbTimKiemMaNhanVien.Name = "tbTimKiemMaNhanVien";
            this.tbTimKiemMaNhanVien.Size = new System.Drawing.Size(146, 26);
            this.tbTimKiemMaNhanVien.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 35);
            this.label17.TabIndex = 19;
            this.label17.Text = "Tình trạng:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 219);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(276, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.AutoScroll = true;
            this.tabPageAdd.Controls.Add(this.flowLayoutPanel1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 27);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(266, 407);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Thêm phòng";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnAddRoom);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 401);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbAddLoaiPhong, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbAddSoPhong, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbAddKhuNha, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbAddMaNhanVien, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 140);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng:";
            // 
            // cbAddLoaiPhong
            // 
            this.cbAddLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAddLoaiPhong.FormattingEnabled = true;
            this.cbAddLoaiPhong.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cbAddLoaiPhong.Location = new System.Drawing.Point(118, 73);
            this.cbAddLoaiPhong.Name = "cbAddLoaiPhong";
            this.cbAddLoaiPhong.Size = new System.Drawing.Size(135, 26);
            this.cbAddLoaiPhong.TabIndex = 13;
            // 
            // tbAddSoPhong
            // 
            this.tbAddSoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddSoPhong.Location = new System.Drawing.Point(118, 38);
            this.tbAddSoPhong.MaxLength = 3;
            this.tbAddSoPhong.Name = "tbAddSoPhong";
            this.tbAddSoPhong.Size = new System.Drawing.Size(135, 26);
            this.tbAddSoPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khu nhà:";
            // 
            // cbAddKhuNha
            // 
            this.cbAddKhuNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAddKhuNha.FormattingEnabled = true;
            this.cbAddKhuNha.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "C1",
            "C2",
            "C3",
            "H1",
            "H2",
            "H6"});
            this.cbAddKhuNha.Location = new System.Drawing.Point(118, 3);
            this.cbAddKhuNha.Name = "cbAddKhuNha";
            this.cbAddKhuNha.Size = new System.Drawing.Size(135, 26);
            this.cbAddKhuNha.Sorted = true;
            this.cbAddKhuNha.TabIndex = 5;
            // 
            // tbAddMaNhanVien
            // 
            this.tbAddMaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddMaNhanVien.Location = new System.Drawing.Point(118, 108);
            this.tbAddMaNhanVien.MaxLength = 10;
            this.tbAddMaNhanVien.Name = "tbAddMaNhanVien";
            this.tbAddMaNhanVien.Size = new System.Drawing.Size(135, 26);
            this.tbAddMaNhanVien.TabIndex = 15;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AutoSize = true;
            this.btnAddRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoom.Location = new System.Drawing.Point(3, 149);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnAddRoom.Size = new System.Drawing.Size(256, 38);
            this.btnAddRoom.TabIndex = 13;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // tabPageChange
            // 
            this.tabPageChange.Controls.Add(this.flowLayoutPanel3);
            this.tabPageChange.Location = new System.Drawing.Point(4, 27);
            this.tabPageChange.Name = "tabPageChange";
            this.tabPageChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChange.Size = new System.Drawing.Size(266, 407);
            this.tabPageChange.TabIndex = 1;
            this.tabPageChange.Text = "Thay đổi thông tin";
            this.tabPageChange.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel3.Controls.Add(this.btnChangeRoom);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(260, 401);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbChangeLoaiPhong, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbChangeSoPhong, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbChangeKhuNha, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbChangeMaNhanVien, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbChangeStatus, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.numUDChangeSoLuongHienTai, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 210);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(3, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 35);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "Loại phòng:";
            // 
            // cbChangeLoaiPhong
            // 
            this.cbChangeLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbChangeLoaiPhong.FormattingEnabled = true;
            this.cbChangeLoaiPhong.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cbChangeLoaiPhong.Location = new System.Drawing.Point(117, 73);
            this.cbChangeLoaiPhong.Name = "cbChangeLoaiPhong";
            this.cbChangeLoaiPhong.Size = new System.Drawing.Size(134, 26);
            this.cbChangeLoaiPhong.TabIndex = 13;
            // 
            // tbChangeSoPhong
            // 
            this.tbChangeSoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChangeSoPhong.Location = new System.Drawing.Point(117, 38);
            this.tbChangeSoPhong.MaxLength = 3;
            this.tbChangeSoPhong.Name = "tbChangeSoPhong";
            this.tbChangeSoPhong.Size = new System.Drawing.Size(134, 26);
            this.tbChangeSoPhong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 35);
            this.label9.TabIndex = 4;
            this.label9.Text = "Khu nhà:";
            // 
            // cbChangeKhuNha
            // 
            this.cbChangeKhuNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbChangeKhuNha.FormattingEnabled = true;
            this.cbChangeKhuNha.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "C1",
            "C2",
            "C3",
            "H1",
            "H2",
            "H6"});
            this.cbChangeKhuNha.Location = new System.Drawing.Point(117, 3);
            this.cbChangeKhuNha.Name = "cbChangeKhuNha";
            this.cbChangeKhuNha.Size = new System.Drawing.Size(134, 26);
            this.cbChangeKhuNha.Sorted = true;
            this.cbChangeKhuNha.TabIndex = 5;
            // 
            // tbChangeMaNhanVien
            // 
            this.tbChangeMaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChangeMaNhanVien.Location = new System.Drawing.Point(117, 108);
            this.tbChangeMaNhanVien.MaxLength = 10;
            this.tbChangeMaNhanVien.Name = "tbChangeMaNhanVien";
            this.tbChangeMaNhanVien.Size = new System.Drawing.Size(134, 26);
            this.tbChangeMaNhanVien.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 35);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số lượng hiện tại:";
            // 
            // cbChangeStatus
            // 
            this.cbChangeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbChangeStatus.FormattingEnabled = true;
            this.cbChangeStatus.Items.AddRange(new object[] {
            "Còn trống",
            "Hết chỗ"});
            this.cbChangeStatus.Location = new System.Drawing.Point(117, 178);
            this.cbChangeStatus.Name = "cbChangeStatus";
            this.cbChangeStatus.Size = new System.Drawing.Size(134, 26);
            this.cbChangeStatus.TabIndex = 18;
            // 
            // numUDChangeSoLuongHienTai
            // 
            this.numUDChangeSoLuongHienTai.AutoSize = true;
            this.numUDChangeSoLuongHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDChangeSoLuongHienTai.Location = new System.Drawing.Point(117, 143);
            this.numUDChangeSoLuongHienTai.Name = "numUDChangeSoLuongHienTai";
            this.numUDChangeSoLuongHienTai.Size = new System.Drawing.Size(134, 26);
            this.numUDChangeSoLuongHienTai.TabIndex = 19;
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.AutoSize = true;
            this.btnChangeRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeRoom.Location = new System.Drawing.Point(3, 219);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnChangeRoom.Size = new System.Drawing.Size(254, 38);
            this.btnChangeRoom.TabIndex = 13;
            this.btnChangeRoom.Text = "Thay đổi";
            this.btnChangeRoom.UseVisualStyleBackColor = true;
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(713, 364);
            this.Name = "Phong";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabCtrlRoom.ResumeLayout(false);
            this.tabPageAdavanceSearch.ResumeLayout(false);
            this.tabPageAdavanceSearch.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTimKiemSoLuongHienTai)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageChange.ResumeLayout(false);
            this.tabPageChange.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeSoLuongHienTai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TabControl tabCtrlRoom;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbAddSoPhong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAddLoaiPhong;
        private System.Windows.Forms.ComboBox cbAddKhuNha;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddMaNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChangeLoaiPhong;
        private System.Windows.Forms.TextBox tbChangeSoPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbChangeKhuNha;
        private System.Windows.Forms.TextBox tbChangeMaNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbChangeStatus;
        private System.Windows.Forms.NumericUpDown numUDChangeSoLuongHienTai;
        private System.Windows.Forms.Button btnChangeRoom;
        private System.Windows.Forms.TabPage tabPageAdavanceSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTimKiemLoaiPhong;
        private System.Windows.Forms.TextBox tbTimKiemSoPhong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTimKiemKhuNha;
        private System.Windows.Forms.TextBox tbTimKiemMaNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTimKiemStatus;
        private System.Windows.Forms.NumericUpDown numUDTimKiemSoLuongHienTai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnViewAll;
    }
}