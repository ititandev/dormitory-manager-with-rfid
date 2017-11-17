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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // themMode
            // 
            this.themMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themMode.Location = new System.Drawing.Point(883, 144);
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
            this.suaMode.Location = new System.Drawing.Point(955, 144);
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
            this.xemMode.Location = new System.Drawing.Point(811, 144);
            this.xemMode.Name = "xemMode";
            this.xemMode.Size = new System.Drawing.Size(75, 23);
            this.xemMode.TabIndex = 31;
            this.xemMode.Text = "Xem";
            this.xemMode.UseVisualStyleBackColor = true;
            this.xemMode.Click += new System.EventHandler(this.xemMode_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 485);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(393, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(359, 485);
            this.dataGridView2.TabIndex = 35;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 721);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.themMode);
            this.Controls.Add(this.suaMode);
            this.Controls.Add(this.xemMode);
            this.Name = "Phong";
            this.Text = "Phong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phong_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button themMode;
        private System.Windows.Forms.Button suaMode;
        private System.Windows.Forms.Button xemMode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}