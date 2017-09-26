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
            btnRefresh_Click(0, EventArgs.Empty);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboComports.Text))
            {
                MessageBox.Show("Chọn một cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            try
            {
                serialPort.PortName = cboComports.Text;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnRefresh.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Connection fail!!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefresh_Click(0,EventArgs.Empty);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnRefresh.Enabled = true;
                return;
            }
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnRefresh.Enabled = true;
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
            cboComports.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                cboComports.Items.Add(port);
            if (ports.Length > 0)
                cboComports.SelectedIndex = 0;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnRefresh.Enabled = true;
        }
    }
}
