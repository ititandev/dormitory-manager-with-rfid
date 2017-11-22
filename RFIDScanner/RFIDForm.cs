using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace RFIDScanner
{
    public partial class RFIDForm : Form
    {
        delegate void SetTextCallbackCom(string text);

        String inputDataCom = "";
        String allIDCard = "";
        String currentIDCard = "";
        int currentIndex = 0;
        Regex regexFindLast = new Regex("\\[\\d{8}(\\d?)(\\d?)\\]\\z");
        Match match;

        public RFIDForm()
        {
            InitializeComponent();
        }
        private void RFIDForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(0, null);
            lblMssv.Text = "";
            lblName.Text = "";
            lblTrongThoiHan.Hide();
        }
        private void SetTextCom(string text)
        {
            match = regexFindLast.Match(allIDCard);
            if (match.Success && (match.Value != currentIDCard || allIDCard.LastIndexOf(currentIDCard) != currentIndex))
            {
                currentIDCard = match.Value;
                lblRFID.Text = currentIDCard;
                if (allIDCard.Length > 100)
                    allIDCard.Remove(0, allIDCard.Length - 99);
                UpdateInfo();
                Console.Beep(4000, 200);
                currentIndex = allIDCard.LastIndexOf(currentIDCard);
            }
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            inputDataCom = serialPort.ReadExisting();
            allIDCard += inputDataCom;
            if (inputDataCom != String.Empty)
            {
                this.BeginInvoke(new SetTextCallbackCom(SetTextCom), new object[] { inputDataCom });
            }

        }

        private void UpdateInfo()
        {
            string card = currentIDCard;
            card = card.Remove(0, 1);
            card = card.Remove(card.Length - 1);
            SqlDataReader reader = ExecuteReader($"SELECT MSSV, HoTen, Anh FROM SinhVien WHERE RFID = '{card}'");
            if (reader.Read())
            {
                lblMssv.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;
                lblMssv.Text = Convert.ToString(reader["MSSV"]);
                lblName.Text = Convert.ToString(reader["HoTen"]);
                picAvatar.Image = Image.FromFile(Properties.Settings.Default.ImageSource + "\\"
                                    + Convert.ToString(reader["Anh"]));
                
                string query = $"SELECT COUNT(*) FROM HopDong WHERE MSSV = '{lblMssv.Text}' AND dbo.KiemTraThoiHan(MSSV) = 1";
                reader = ExecuteReader(query);
                if (reader.Read() && Convert.ToInt32(reader[0]) == 1)
                    lblTrongThoiHan.Hide();
                else
                    lblTrongThoiHan.Show();
            }
            else
            {
                lblMssv.ForeColor = Color.Red;
                lblMssv.Text = "Không tìm thấy";
                lblName.Text = "";
                picAvatar.Image = null;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string[] ComList = SerialPort.GetPortNames();

            int[] ComNumberList = new int[ComList.Length];
            for (int i = 0; i < ComList.Length; i++)
            {
                ComNumberList[i] = int.Parse(ComList[i].Substring(3));
            }

            Array.Sort(ComNumberList);
            cbxComList.Items.Clear();
            foreach (int ComNumber in ComNumberList)
            {
                cbxComList.Items.Add("COM" + ComNumber.ToString());
            }

            bool found = false;
            foreach (string str in cbxComList.Items)
            {
                if (str == Properties.Settings.Default.PortName)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                cbxComList.Text = Properties.Settings.Default.PortName;
            }

            chkAutoConnect.Checked = Properties.Settings.Default.AutoConnect;
            if (Properties.Settings.Default.AutoConnect)
            {
                if (e == null)
                    button1_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxComList.Text == "")
            {
                lblState.Text = "Trạng thái: " + "Vui lòng chọn cổng COM";
                lblState.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnConnect.Text = "Kết nối";
                cbxComList.Enabled = true;
                btnRefresh.Enabled = true;
                lblState.Text = "Trạng thái: " + "Ngắt kết nối thành công";
                lblState.ForeColor = System.Drawing.Color.CadetBlue;
            }
            else
            {
                try
                {
                    serialPort.PortName = cbxComList.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.Open();

                    lblState.Text = "Trạng thái: " + "Kết nối thành công " + serialPort.PortName;
                    lblState.ForeColor = System.Drawing.Color.Blue;
                    btnConnect.Text = "Ngắt kết nối";
                    cbxComList.Enabled = false;
                    btnRefresh.Enabled = false;
                }
                catch
                {
                    lblState.Text = "Trạng thái: " + "Không thể mở cổng " + serialPort.PortName;
                    lblState.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.PortName = cbxComList.Text;
            Properties.Settings.Default.AutoConnect = chkAutoConnect.Checked;
            Properties.Settings.Default.Save();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            SaveSetting();
        }

        private void btnImageSource_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.ImageSource
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ImageSource = folderBrowserDialog.SelectedPath;
            }
            // = 
        }

        private void btnConnectString_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Nhập chuỗi kết nối cơ sở dữ liệu\nCơ sở dữ liệu hiện tại:\n" + Properties.Settings.Default.ConnectString, "Tùy chỉnh cơ sở dữ liệu");
            if (result != String.Empty)
                Properties.Settings.Default.ConnectString = result;
        }


        public static SqlDataReader ExecuteReader(String query, object[] param = null)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (param != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listParam = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listParam.Add(item);
                    }
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(listParam[i], param[i]);
                    }
                }
                SqlDataReader reader = sqlCommand.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void picAvatar_SizeChanged(object sender, EventArgs e)
        {
            this.picAvatar.Size = new System.Drawing.Size(picAvatar.Size.Height/4*3, picAvatar.Size.Height);
        }
    }
}
