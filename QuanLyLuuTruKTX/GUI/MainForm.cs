using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        static HopDong hopDongForm = new HopDong();
        static SinhVien sinhVienForm = new SinhVien();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hopDongForm.MdiParent = this;
            hopDongForm.Show();
            hopDongForm.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var obj = new SinhVienView();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var obj = new DienNuoc();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }
    }
}
