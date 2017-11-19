namespace GUI
{
    partial class SinhVien
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
        private void SetReadOnly(bool enabled, params System.Windows.Forms.TextBox[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].ReadOnly = enabled;
            }
        }
        private void Clear(params System.Windows.Forms.TextBox[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = System.String.Empty;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnHanhDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnChupAnh = new System.Windows.Forms.Button();
            this.lblHopDongHopLe = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDienUutien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.themMode = new System.Windows.Forms.Button();
            this.suaMode = new System.Windows.Forms.Button();
            this.xemMode = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá trị:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(294, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(115, 20);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lọc theo";
            // 
            // cboTimKiemTheo
            // 
            this.cboTimKiemTheo.FormattingEnabled = true;
            this.cboTimKiemTheo.Location = new System.Drawing.Point(90, 9);
            this.cboTimKiemTheo.Name = "cboTimKiemTheo";
            this.cboTimKiemTheo.Size = new System.Drawing.Size(140, 21);
            this.cboTimKiemTheo.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 41);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(639, 717);
            this.dgv.TabIndex = 9;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnHanhDong
            // 
            this.btnHanhDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHanhDong.Location = new System.Drawing.Point(166, 477);
            this.btnHanhDong.Name = "btnHanhDong";
            this.btnHanhDong.Size = new System.Drawing.Size(75, 23);
            this.btnHanhDong.TabIndex = 14;
            this.btnHanhDong.Text = "Thêm mới";
            this.btnHanhDong.UseVisualStyleBackColor = true;
            this.btnHanhDong.Click += new System.EventHandler(this.btnHanhDong_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnChonFile);
            this.panel2.Controls.Add(this.btnChupAnh);
            this.panel2.Controls.Add(this.lblHopDongHopLe);
            this.panel2.Controls.Add(this.btnHanhDong);
            this.panel2.Controls.Add(this.txtRFID);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.pic);
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtDienUutien);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtQueQuan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtKhoa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtLop);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMSSV);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtCMND);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(669, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 519);
            this.panel2.TabIndex = 9;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonFile.Location = new System.Drawing.Point(304, 185);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(75, 23);
            this.btnChonFile.TabIndex = 17;
            this.btnChonFile.Text = "Chọn từ file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnChupAnh
            // 
            this.btnChupAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChupAnh.Location = new System.Drawing.Point(304, 214);
            this.btnChupAnh.Name = "btnChupAnh";
            this.btnChupAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChupAnh.TabIndex = 16;
            this.btnChupAnh.Text = "Chụp ảnh";
            this.btnChupAnh.UseVisualStyleBackColor = true;
            this.btnChupAnh.Click += new System.EventHandler(this.btnChupAnh_Click);
            // 
            // lblHopDongHopLe
            // 
            this.lblHopDongHopLe.AutoSize = true;
            this.lblHopDongHopLe.ForeColor = System.Drawing.Color.Red;
            this.lblHopDongHopLe.Location = new System.Drawing.Point(259, 442);
            this.lblHopDongHopLe.Name = "lblHopDongHopLe";
            this.lblHopDongHopLe.Size = new System.Drawing.Size(120, 13);
            this.lblHopDongHopLe.TabIndex = 15;
            this.lblHopDongHopLe.Text = "Hợp đồng không hợp lệ";
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(81, 439);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(73, 20);
            this.txtRFID.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "RFID";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(312, 285);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(100, 21);
            this.cbGioiTinh.TabIndex = 6;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(109, 19);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(183, 218);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(313, 312);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(99, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 364);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // txtDienUutien
            // 
            this.txtDienUutien.Location = new System.Drawing.Point(82, 287);
            this.txtDienUutien.Name = "txtDienUutien";
            this.txtDienUutien.Size = new System.Drawing.Size(171, 20);
            this.txtDienUutien.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Diện ưu tiên";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(81, 390);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(330, 20);
            this.txtQueQuan.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quê quán";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(81, 338);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(171, 20);
            this.txtKhoa.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khoa";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(313, 338);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(99, 20);
            this.txtLop.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lớp";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(313, 367);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(99, 20);
            this.txtDT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày sinh";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(313, 260);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(99, 20);
            this.txtMSSV.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "MSSV";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(82, 313);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(171, 20);
            this.txtCMND.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "CMND";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(82, 260);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(171, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên";
            // 
            // themMode
            // 
            this.themMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themMode.Location = new System.Drawing.Point(835, 31);
            this.themMode.Name = "themMode";
            this.themMode.Size = new System.Drawing.Size(75, 23);
            this.themMode.TabIndex = 30;
            this.themMode.Text = "Thêm";
            this.themMode.UseVisualStyleBackColor = true;
            this.themMode.Click += new System.EventHandler(this.themMode_Click);
            // 
            // suaMode
            // 
            this.suaMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suaMode.Location = new System.Drawing.Point(907, 31);
            this.suaMode.Name = "suaMode";
            this.suaMode.Size = new System.Drawing.Size(75, 23);
            this.suaMode.TabIndex = 29;
            this.suaMode.Text = "Sửa";
            this.suaMode.UseVisualStyleBackColor = true;
            this.suaMode.Click += new System.EventHandler(this.suaMode_Click);
            // 
            // xemMode
            // 
            this.xemMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xemMode.Location = new System.Drawing.Point(763, 31);
            this.xemMode.Name = "xemMode";
            this.xemMode.Size = new System.Drawing.Size(75, 23);
            this.xemMode.TabIndex = 28;
            this.xemMode.Text = "Xem";
            this.xemMode.UseVisualStyleBackColor = true;
            this.xemMode.Click += new System.EventHandler(this.xemMode_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.png;*.jpeg|Tất cả (*.*)|*.*";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(529, 12);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnXemTatCa.TabIndex = 31;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 770);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.themMode);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.suaMode);
            this.Controls.Add(this.xemMode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTimKiemTheo);
            this.Name = "SinhVien";
            this.Text = "Sinh viên";
            this.Activated += new System.EventHandler(this.SinhVien_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinhVien_FormClosing);
            this.Load += new System.EventHandler(this.SinhVienView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHanhDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTimKiemTheo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDienUutien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button themMode;
        private System.Windows.Forms.Button suaMode;
        private System.Windows.Forms.Button xemMode;
        private System.Windows.Forms.Label lblHopDongHopLe;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnChupAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnXemTatCa;
    }

    
}