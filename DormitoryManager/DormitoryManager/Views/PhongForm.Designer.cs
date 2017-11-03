namespace DormitoryManager
{
    partial class PhongForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.ribbonTextBox1 = new System.Windows.Forms.RibbonTextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.soPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongChoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AllowUserToOrderColumns = true;
            this.dgvPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhong,
            this.khuNha,
            this.maNhanVien,
            this.soLuongChoPhep,
            this.tinhTrang,
            this.soLuongHienTai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.Location = new System.Drawing.Point(12, 104);
            this.dgvPhong.Name = "dgvPhong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.Size = new System.Drawing.Size(477, 282);
            this.dgvPhong.TabIndex = 0;
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.TextBoxText = "";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(482, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(263, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // soPhong
            // 
            this.soPhong.DataPropertyName = "soPhong";
            this.soPhong.HeaderText = "Số phòng";
            this.soPhong.Name = "soPhong";
            this.soPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // khuNha
            // 
            this.khuNha.DataPropertyName = "khuNha";
            this.khuNha.HeaderText = "Khu nhà";
            this.khuNha.Name = "khuNha";
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Nhân viên quản lý";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // soLuongChoPhep
            // 
            this.soLuongChoPhep.DataPropertyName = "soLuongChoPhep";
            this.soLuongChoPhep.HeaderText = "Loại phòng";
            this.soLuongChoPhep.Name = "soLuongChoPhep";
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.Name = "tinhTrang";
            // 
            // soLuongHienTai
            // 
            this.soLuongHienTai.DataPropertyName = "soLuongHienTai";
            this.soLuongHienTai.HeaderText = "Số lượng hiện tại";
            this.soLuongHienTai.Name = "soLuongHienTai";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = ";alsdkfaldskf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PhongForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(757, 497);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvPhong);
            this.Name = "PhongForm";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.PhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongChoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongHienTai;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}