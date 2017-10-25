using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManager
{
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.FillDataToGrid("SELECT * FROM HopDong ", dataGridView1);
        }
    }
}
