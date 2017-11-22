using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Class form kế thừa System.Windows.Forms có thêm khả năng nhận dạng RFID
    /// </summary>
    public class KTXForm : Form
    {
        virtual public void SendRFID(string RFID) { }
    }
}
