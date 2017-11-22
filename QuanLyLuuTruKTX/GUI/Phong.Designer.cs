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
            this.components = new System.ComponentModel.Container();
            this.themMode = new System.Windows.Forms.Button();
            this.suaMode = new System.Windows.Forms.Button();
            this.xemMode = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.txtKhuNha = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.numToiDa = new System.Windows.Forms.NumericUpDown();
            this.numHienTai = new System.Windows.Forms.NumericUpDown();
            this.btnHanhDong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.btnChonPhong = new System.Windows.Forms.Button();
            this.btnXemHopDong = new System.Windows.Forms.Button();
            this.btnXemSinhVien = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.contextMenuStripSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // themMode
            // 
            this.themMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themMode.Location = new System.Drawing.Point(1463, 105);
            this.themMode.Name = "themMode";
            this.themMode.Size = new System.Drawing.Size(75, 23);
            this.themMode.TabIndex = 33;
            this.themMode.Text = "Thêm";
            this.themMode.UseVisualStyleBackColor = true;
            this.themMode.Click += new System.EventHandler(this.themMode_Click);
            // 
            // suaMode
            // 
            this.suaMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suaMode.Location = new System.Drawing.Point(1535, 105);
            this.suaMode.Name = "suaMode";
            this.suaMode.Size = new System.Drawing.Size(75, 23);
            this.suaMode.TabIndex = 32;
            this.suaMode.Text = "Sửa";
            this.suaMode.UseVisualStyleBackColor = true;
            this.suaMode.Click += new System.EventHandler(this.suaMode_Click);
            // 
            // xemMode
            // 
            this.xemMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xemMode.Location = new System.Drawing.Point(1391, 105);
            this.xemMode.Name = "xemMode";
            this.xemMode.Size = new System.Drawing.Size(75, 23);
            this.xemMode.TabIndex = 31;
            this.xemMode.Text = "Xem";
            this.xemMode.UseVisualStyleBackColor = true;
            this.xemMode.Click += new System.EventHandler(this.xemMode_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(220, 27);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(462, 796);
            this.dgvPhong.TabIndex = 34;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.ContextMenuStrip = this.contextMenuStripSV;
            this.dgvSinhVien.Location = new System.Drawing.Point(839, 27);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(506, 796);
            this.dgvSinhVien.TabIndex = 35;
            // 
            // contextMenuStripSV
            // 
            this.contextMenuStripSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHợpĐồngToolStripMenuItem,
            this.xemSinhViênToolStripMenuItem});
            this.contextMenuStripSV.Name = "contextMenuStripSV";
            this.contextMenuStripSV.Size = new System.Drawing.Size(154, 48);
            // 
            // xemHợpĐồngToolStripMenuItem
            // 
            this.xemHợpĐồngToolStripMenuItem.Name = "xemHợpĐồngToolStripMenuItem";
            this.xemHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.xemHợpĐồngToolStripMenuItem.Text = "Xem hợp đồng";
            this.xemHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.btnXemHopDong_Click);
            // 
            // xemSinhViênToolStripMenuItem
            // 
            this.xemSinhViênToolStripMenuItem.Name = "xemSinhViênToolStripMenuItem";
            this.xemSinhViênToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.xemSinhViênToolStripMenuItem.Text = "Xem sinh viên";
            this.xemSinhViênToolStripMenuItem.Click += new System.EventHandler(this.btnXemSinhVien_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1399, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "IDPhong";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1399, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Khu nhà";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1399, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số phòng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1370, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số lượng hiện tại";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1377, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Số lượng tối đa";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTinhTrang.Location = new System.Drawing.Point(1472, 365);
            this.txtTinhTrang.MaxLength = 50;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(162, 69);
            this.txtTinhTrang.TabIndex = 42;
            this.txtTinhTrang.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1370, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Chú thích phòng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDPhong.Location = new System.Drawing.Point(1472, 182);
            this.txtIDPhong.MaxLength = 10;
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(100, 20);
            this.txtIDPhong.TabIndex = 44;
            // 
            // txtKhuNha
            // 
            this.txtKhuNha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhuNha.Location = new System.Drawing.Point(1472, 221);
            this.txtKhuNha.MaxLength = 10;
            this.txtKhuNha.Name = "txtKhuNha";
            this.txtKhuNha.Size = new System.Drawing.Size(100, 20);
            this.txtKhuNha.TabIndex = 45;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhong.Location = new System.Drawing.Point(1472, 257);
            this.txtSoPhong.MaxLength = 9;
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhong.TabIndex = 46;
            // 
            // numToiDa
            // 
            this.numToiDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numToiDa.Location = new System.Drawing.Point(1472, 332);
            this.numToiDa.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numToiDa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numToiDa.Name = "numToiDa";
            this.numToiDa.Size = new System.Drawing.Size(100, 20);
            this.numToiDa.TabIndex = 49;
            this.numToiDa.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numHienTai
            // 
            this.numHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numHienTai.Enabled = false;
            this.numHienTai.Location = new System.Drawing.Point(1472, 298);
            this.numHienTai.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHienTai.Name = "numHienTai";
            this.numHienTai.ReadOnly = true;
            this.numHienTai.Size = new System.Drawing.Size(100, 20);
            this.numHienTai.TabIndex = 50;
            // 
            // btnHanhDong
            // 
            this.btnHanhDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHanhDong.Location = new System.Drawing.Point(1472, 464);
            this.btnHanhDong.Name = "btnHanhDong";
            this.btnHanhDong.Size = new System.Drawing.Size(75, 23);
            this.btnHanhDong.TabIndex = 51;
            this.btnHanhDong.Text = "Thêm mới";
            this.btnHanhDong.UseVisualStyleBackColor = true;
            this.btnHanhDong.Click += new System.EventHandler(this.btnHanhDong_Click);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng trống"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(19, 55);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(166, 21);
            this.cboLoaiPhong.TabIndex = 52;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Loại phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Số lượng";
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng 4",
            "Phòng 6",
            "Phòng 8"});
            this.cboSoLuong.Location = new System.Drawing.Point(19, 113);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(166, 21);
            this.cboSoLuong.TabIndex = 54;
            this.cboSoLuong.SelectedIndexChanged += new System.EventHandler(this.cboSoLuong_SelectedIndexChanged);
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChonPhong.Image = global::GUI.Properties.Resources.tick;
            this.btnChonPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonPhong.Location = new System.Drawing.Point(315, 841);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.Size = new System.Drawing.Size(229, 34);
            this.btnChonPhong.TabIndex = 57;
            this.btnChonPhong.Text = "Chọn làm hợp đồng";
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // btnXemHopDong
            // 
            this.btnXemHopDong.Location = new System.Drawing.Point(19, 257);
            this.btnXemHopDong.Name = "btnXemHopDong";
            this.btnXemHopDong.Size = new System.Drawing.Size(166, 23);
            this.btnXemHopDong.TabIndex = 58;
            this.btnXemHopDong.Text = "Xem hợp đồng";
            this.btnXemHopDong.UseVisualStyleBackColor = true;
            this.btnXemHopDong.Click += new System.EventHandler(this.btnXemHopDong_Click);
            // 
            // btnXemSinhVien
            // 
            this.btnXemSinhVien.Location = new System.Drawing.Point(19, 295);
            this.btnXemSinhVien.Name = "btnXemSinhVien";
            this.btnXemSinhVien.Size = new System.Drawing.Size(166, 23);
            this.btnXemSinhVien.TabIndex = 59;
            this.btnXemSinhVien.Text = "Xem sinh viên";
            this.btnXemSinhVien.UseVisualStyleBackColor = true;
            this.btnXemSinhVien.Click += new System.EventHandler(this.btnXemSinhVien_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(19, 154);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(166, 23);
            this.btnXemTatCa.TabIndex = 60;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(19, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 57);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa phòng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Image = global::GUI.Properties.Resources.swap;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 55);
            this.button1.TabIndex = 62;
            this.button1.Text = "Chuyển phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 887);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnXemSinhVien);
            this.Controls.Add(this.btnXemHopDong);
            this.Controls.Add(this.btnChonPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.btnHanhDong);
            this.Controls.Add(this.numHienTai);
            this.Controls.Add(this.numToiDa);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.txtKhuNha);
            this.Controls.Add(this.txtIDPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.themMode);
            this.Controls.Add(this.suaMode);
            this.Controls.Add(this.xemMode);
            this.Name = "Phong";
            this.Text = "Phong";
            this.Activated += new System.EventHandler(this.Phong_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phong_FormClosing);
            this.Load += new System.EventHandler(this.Phong_Load);
            this.Resize += new System.EventHandler(this.Phong_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.contextMenuStripSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHienTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button themMode;
        private System.Windows.Forms.Button suaMode;
        private System.Windows.Forms.Button xemMode;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.TextBox txtKhuNha;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.NumericUpDown numToiDa;
        private System.Windows.Forms.NumericUpDown numHienTai;
        private System.Windows.Forms.Button btnHanhDong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSoLuong;
        private System.Windows.Forms.Button btnChonPhong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSV;
        private System.Windows.Forms.ToolStripMenuItem xemHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.Button btnXemHopDong;
        private System.Windows.Forms.ToolStripMenuItem xemSinhViênToolStripMenuItem;
        private System.Windows.Forms.Button btnXemSinhVien;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
    }
}