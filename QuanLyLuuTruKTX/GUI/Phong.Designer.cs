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
            this.themMode = new System.Windows.Forms.Button();
            this.suaMode = new System.Windows.Forms.Button();
            this.xemMode = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // themMode
            // 
            this.themMode.Location = new System.Drawing.Point(94, 116);
            this.themMode.Name = "themMode";
            this.themMode.Size = new System.Drawing.Size(75, 23);
            this.themMode.TabIndex = 33;
            this.themMode.Text = "Thêm";
            this.themMode.UseVisualStyleBackColor = true;
            this.themMode.Click += new System.EventHandler(this.themMode_Click);
            // 
            // suaMode
            // 
            this.suaMode.Location = new System.Drawing.Point(166, 116);
            this.suaMode.Name = "suaMode";
            this.suaMode.Size = new System.Drawing.Size(75, 23);
            this.suaMode.TabIndex = 32;
            this.suaMode.Text = "Sửa";
            this.suaMode.UseVisualStyleBackColor = true;
            this.suaMode.Click += new System.EventHandler(this.suaMode_Click);
            // 
            // xemMode
            // 
            this.xemMode.Location = new System.Drawing.Point(22, 116);
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
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(283, 116);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(501, 615);
            this.dgvPhong.TabIndex = 34;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(810, 116);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(506, 615);
            this.dgvSinhVien.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1272, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "IDPhong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Khu nhà";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số lượng hiện tại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Số lượng tối đa";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(103, 376);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(162, 69);
            this.txtTinhTrang.TabIndex = 42;
            this.txtTinhTrang.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Chú thích phòng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(103, 193);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(100, 20);
            this.txtIDPhong.TabIndex = 44;
            // 
            // txtKhuNha
            // 
            this.txtKhuNha.Location = new System.Drawing.Point(103, 232);
            this.txtKhuNha.Name = "txtKhuNha";
            this.txtKhuNha.Size = new System.Drawing.Size(100, 20);
            this.txtKhuNha.TabIndex = 45;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(103, 268);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhong.TabIndex = 46;
            // 
            // numToiDa
            // 
            this.numToiDa.Location = new System.Drawing.Point(103, 343);
            this.numToiDa.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToiDa.Name = "numToiDa";
            this.numToiDa.Size = new System.Drawing.Size(100, 20);
            this.numToiDa.TabIndex = 49;
            this.numToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHienTai
            // 
            this.numHienTai.Location = new System.Drawing.Point(103, 309);
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
            this.btnHanhDong.Location = new System.Drawing.Point(103, 475);
            this.btnHanhDong.Name = "btnHanhDong";
            this.btnHanhDong.Size = new System.Drawing.Size(75, 23);
            this.btnHanhDong.TabIndex = 51;
            this.btnHanhDong.Text = "Thêm mới";
            this.btnHanhDong.UseVisualStyleBackColor = true;
            this.btnHanhDong.Click += new System.EventHandler(this.btnHanhDong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Xem tất cả";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 813);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
    }
}