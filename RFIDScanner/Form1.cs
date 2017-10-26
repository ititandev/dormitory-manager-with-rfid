using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace RFIDScanner
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallbackCom(string text);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(0, null);
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.PortName = cbxComList.Text;
            Properties.Settings.Default.AutoConnect = chxAutoConnect.Checked;

            Properties.Settings.Default.Save();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //if (serialPort.IsOpen)
            //{
            //    serialPort.Close();
            //    btnConnect.Enabled = true;
            //    btnDisconnect.Enabled = false;
            //    btnRefresh.Enabled = true;
            //    return;
            //}
            //btnConnect.Enabled = true;
            //btnDisconnect.Enabled = false;
            //btnRefresh.Enabled = true;
        }
        String InputDataCom = "";
        String allIDCard = "";
        String currentIDCard = "";
        int currentIndex = 0;
        Regex RegexFindLast = new Regex("\\[\\d{8}(\\d?)(\\d?)\\]\\z");
        Match m;



        private void SetTextCom(string text)
        {
            richTextBox1.Text += text;
            m = RegexFindLast.Match(allIDCard);
            if (m.Success && (m.Value != currentIDCard || allIDCard.LastIndexOf(currentIDCard) != currentIndex))
            {
                currentIDCard = m.Value;
                updateInfo();
                Console.Beep(4000, 200);
                currentIndex = allIDCard.LastIndexOf(currentIDCard);
            }
        }

        
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputDataCom = serialPort.ReadExisting();
            allIDCard += InputDataCom;
            if (InputDataCom != String.Empty)
            {
                this.BeginInvoke(new SetTextCallbackCom(SetTextCom), new object[] { InputDataCom });
            }
            
        }
        
        private void updateInfo()
        {
            switch (currentIDCard)
            {
                default:
                    labelName.Text = currentIDCard;
                    break;
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
            
            chxAutoConnect.Checked = Properties.Settings.Default.AutoConnect;
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
                //MessageBox.Show("Vui lòng chọn cổng com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.Text = "Trạng thái: " + "Vui lòng chọn cổng COM";
                label2.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                button1.Text = "Kết nối";
                cbxComList.Enabled = true;
            }
            else
            {
                try
                {
                    serialPort.PortName = cbxComList.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.Open();
                    //MessageBox.Show("Kết nối thành công " + serialPort.PortName);
                    label2.Text = "Trạng thái: " + "Kết nối thành công " + serialPort.PortName;
                    label2.ForeColor = System.Drawing.Color.Blue;

                    button1.Text = "Ngắt kết nối";
                    cbxComList.Enabled = false;
                }
                catch
                {
                    //MessageBox.Show("Không thể mở cổng " + serialPort.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Text = "Trạng thái: " + "Không thể mở cổng " + serialPort.PortName;
                    label2.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            SaveSetting();
        }
    }
}
