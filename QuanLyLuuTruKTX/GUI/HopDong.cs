using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class HopDong : Form
    {
        private HopDongBUS hopDongBUS = new HopDongBUS();
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            HopDongBUS.ViewAll(dataGridView1);
        }
    }
}
