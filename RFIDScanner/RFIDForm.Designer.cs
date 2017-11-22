namespace RFIDScanner
{
    partial class RFIDForm
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblMssv = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxComList = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnImageSource = new System.Windows.Forms.Button();
            this.btnConnectString = new System.Windows.Forms.Button();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblTrongThoiHan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cổng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(224, 627);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Tìm lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Location = new System.Drawing.Point(54, 33);
            this.picAvatar.MaximumSize = new System.Drawing.Size(650, 950);
            this.picAvatar.MinimumSize = new System.Drawing.Size(300, 400);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(449, 538);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 11;
            this.picAvatar.TabStop = false;
            this.picAvatar.SizeChanged += new System.EventHandler(this.picAvatar_SizeChanged);
            // 
            // lblMssv
            // 
            this.lblMssv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMssv.Location = new System.Drawing.Point(590, 274);
            this.lblMssv.Name = "lblMssv";
            this.lblMssv.Size = new System.Drawing.Size(577, 73);
            this.lblMssv.TabIndex = 12;
            this.lblMssv.Text = "MSSV";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(590, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(577, 73);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoConnect.Location = new System.Drawing.Point(305, 630);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(110, 19);
            this.chkAutoConnect.TabIndex = 16;
            this.chkAutoConnect.Text = "Tự động kết nối";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(143, 627);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxComList
            // 
            this.cbxComList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxComList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComList.FormattingEnabled = true;
            this.cbxComList.Location = new System.Drawing.Point(54, 628);
            this.cbxComList.Name = "cbxComList";
            this.cbxComList.Size = new System.Drawing.Size(83, 23);
            this.cbxComList.TabIndex = 17;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblState.Location = new System.Drawing.Point(443, 631);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 15);
            this.lblState.TabIndex = 19;
            // 
            // btnImageSource
            // 
            this.btnImageSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImageSource.Location = new System.Drawing.Point(985, 626);
            this.btnImageSource.Name = "btnImageSource";
            this.btnImageSource.Size = new System.Drawing.Size(75, 23);
            this.btnImageSource.TabIndex = 20;
            this.btnImageSource.Text = "Cài đặt ảnh";
            this.btnImageSource.UseVisualStyleBackColor = true;
            this.btnImageSource.Click += new System.EventHandler(this.btnImageSource_Click);
            // 
            // btnConnectString
            // 
            this.btnConnectString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectString.Location = new System.Drawing.Point(1086, 626);
            this.btnConnectString.Name = "btnConnectString";
            this.btnConnectString.Size = new System.Drawing.Size(101, 23);
            this.btnConnectString.TabIndex = 21;
            this.btnConnectString.Text = "Cài đặt Dữ liệu";
            this.btnConnectString.UseVisualStyleBackColor = true;
            this.btnConnectString.Click += new System.EventHandler(this.btnConnectString_Click);
            // 
            // lblRFID
            // 
            this.lblRFID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(760, 633);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(32, 13);
            this.lblRFID.TabIndex = 23;
            this.lblRFID.Text = "RFID";
            // 
            // lblTrongThoiHan
            // 
            this.lblTrongThoiHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrongThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongThoiHan.ForeColor = System.Drawing.Color.Red;
            this.lblTrongThoiHan.Location = new System.Drawing.Point(590, 433);
            this.lblTrongThoiHan.Name = "lblTrongThoiHan";
            this.lblTrongThoiHan.Size = new System.Drawing.Size(577, 73);
            this.lblTrongThoiHan.TabIndex = 24;
            this.lblTrongThoiHan.Text = "Hợp đồng không hợp lệ";
            // 
            // RFIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 662);
            this.Controls.Add(this.lblTrongThoiHan);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.btnConnectString);
            this.Controls.Add(this.btnImageSource);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbxComList);
            this.Controls.Add(this.chkAutoConnect);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMssv);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Name = "RFIDForm";
            this.Text = "Phần mềm quét thẻ RFID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.RFIDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblMssv;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxComList;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnImageSource;
        private System.Windows.Forms.Button btnConnectString;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblTrongThoiHan;
    }
}

