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
        public static Phong phongForm = new Phong();
        public static HopDong hopDongForm;
        public static SinhVien sinhVienForm = new SinhVien();
        public static DangNhap dangNhapForm = new DangNhap();
        public MainForm()
        {
            InitializeComponent();
            button1_Click(null, null);
            dangNhapForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hopDongForm == null)
                hopDongForm = new HopDong();
            hopDongForm.MdiParent = this;
            hopDongForm.Show();
            hopDongForm.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sinhVienForm == null)
                sinhVienForm = new SinhVien();
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
            sinhVienForm.WindowState = FormWindowState.Maximized;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            if (phongForm.Visible) return;
            phongForm = new Phong();
            phongForm.MdiParent = this;
            phongForm.Show();
            phongForm.WindowState = FormWindowState.Maximized;
        }
    }
}
