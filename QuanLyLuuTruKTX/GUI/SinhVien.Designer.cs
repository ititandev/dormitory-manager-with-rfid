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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDRL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUutien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(446, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 393);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(679, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá trị:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(410, 10);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(174, 20);
            this.txtValue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lọc theo";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(90, 10);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(223, 21);
            this.cbFilter.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 327);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-31, -37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách sinh viên lưu trú";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(287, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(29, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txtDRL);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateNgaySinh);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtUutien);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtQue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtKhoa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtLop);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMaSo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtCMND);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 393);
            this.panel2.TabIndex = 9;
            // 
            // txtDRL
            // 
            this.txtDRL.Location = new System.Drawing.Point(289, 70);
            this.txtDRL.Name = "txtDRL";
            this.txtDRL.ReadOnly = true;
            this.txtDRL.Size = new System.Drawing.Size(73, 20);
            this.txtDRL.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Điểm RL:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(289, 43);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(73, 21);
            this.cbGioiTinh.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(55, 40);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(131, 20);
            this.dateNgaySinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(55, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // txtUutien
            // 
            this.txtUutien.Location = new System.Drawing.Point(70, 245);
            this.txtUutien.Name = "txtUutien";
            this.txtUutien.Size = new System.Drawing.Size(116, 20);
            this.txtUutien.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Diện ưu tiên";
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(55, 207);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(131, 20);
            this.txtQue.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quê quán";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(55, 167);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(131, 20);
            this.txtKhoa.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khoa";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(55, 129);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(131, 20);
            this.txtLop.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lớp";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(55, 98);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(131, 20);
            this.txtDT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ĐT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày sinh";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(289, 10);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(73, 20);
            this.txtMaSo.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(232, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mã số";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(55, 70);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(131, 20);
            this.txtCMND.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "CMND";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(55, 10);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(171, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên";
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SinhVien";
            this.Text = "Sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinhVien_FormClosing);
            this.Load += new System.EventHandler(this.SinhVienView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDRL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUutien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}