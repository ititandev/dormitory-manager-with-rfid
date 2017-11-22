namespace GUI
{
    partial class ChuyenPhong
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
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.dgvDes = new System.Windows.Forms.DataGridView();
            this.btnQua = new System.Windows.Forms.Button();
            this.btnLai = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboSource = new System.Windows.Forms.ComboBox();
            this.cboDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmptyRoom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Location = new System.Drawing.Point(12, 67);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.Size = new System.Drawing.Size(391, 350);
            this.dgvSource.TabIndex = 0;
            // 
            // dgvDes
            // 
            this.dgvDes.AllowUserToAddRows = false;
            this.dgvDes.AllowUserToDeleteRows = false;
            this.dgvDes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDes.Location = new System.Drawing.Point(627, 67);
            this.dgvDes.Name = "dgvDes";
            this.dgvDes.ReadOnly = true;
            this.dgvDes.Size = new System.Drawing.Size(375, 350);
            this.dgvDes.TabIndex = 1;
            // 
            // btnQua
            // 
            this.btnQua.Location = new System.Drawing.Point(488, 123);
            this.btnQua.Name = "btnQua";
            this.btnQua.Size = new System.Drawing.Size(75, 23);
            this.btnQua.TabIndex = 3;
            this.btnQua.Text = ">>";
            this.btnQua.UseVisualStyleBackColor = true;
            this.btnQua.Click += new System.EventHandler(this.btnQua_Click);
            // 
            // btnLai
            // 
            this.btnLai.Location = new System.Drawing.Point(488, 196);
            this.btnLai.Name = "btnLai";
            this.btnLai.Size = new System.Drawing.Size(75, 23);
            this.btnLai.TabIndex = 3;
            this.btnLai.Text = "<<";
            this.btnLai.UseVisualStyleBackColor = true;
            this.btnLai.Click += new System.EventHandler(this.btnLai_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(356, 437);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(151, 43);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "Áp dụng chuyển phòng";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(544, 437);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 43);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboSource
            // 
            this.cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Location = new System.Drawing.Point(146, 23);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(121, 21);
            this.cboSource.TabIndex = 8;
            this.cboSource.SelectedValueChanged += new System.EventHandler(this.cboSource_SelectedValueChanged);
            // 
            // cboDes
            // 
            this.cboDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDes.FormattingEnabled = true;
            this.cboDes.Location = new System.Drawing.Point(713, 25);
            this.cboDes.Name = "cboDes";
            this.cboDes.Size = new System.Drawing.Size(121, 21);
            this.cboDes.TabIndex = 9;
            this.cboDes.SelectedValueChanged += new System.EventHandler(this.cboDes_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn phòng:";
            // 
            // cbEmptyRoom
            // 
            this.cbEmptyRoom.AutoSize = true;
            this.cbEmptyRoom.Location = new System.Drawing.Point(858, 27);
            this.cbEmptyRoom.Name = "cbEmptyRoom";
            this.cbEmptyRoom.Size = new System.Drawing.Size(124, 17);
            this.cbEmptyRoom.TabIndex = 12;
            this.cbEmptyRoom.Text = "Chỉ hiện phòng trống";
            this.cbEmptyRoom.UseVisualStyleBackColor = true;
            this.cbEmptyRoom.CheckedChanged += new System.EventHandler(this.cbEmptyRoom_CheckedChanged);
            // 
            // ChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 490);
            this.Controls.Add(this.cbEmptyRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDes);
            this.Controls.Add(this.cboSource);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnLai);
            this.Controls.Add(this.btnQua);
            this.Controls.Add(this.dgvDes);
            this.Controls.Add(this.dgvSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChuyenPhong";
            this.Text = "Chuyen";
            this.Load += new System.EventHandler(this.Chuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.DataGridView dgvDes;
        private System.Windows.Forms.Button btnQua;
        private System.Windows.Forms.Button btnLai;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboSource;
        private System.Windows.Forms.ComboBox cboDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEmptyRoom;
    }
}