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
        public static string NhanVienHienTai { get; set; }
        public static string ChucVuHienTai { get; set; }
        public static bool Logined { get; set; }

        public static HopDong hopDongForm;
        public static SinhVien sinhVienForm;
        public static DangNhap dangNhapForm;
        public static NhanVien nhanVienForm;
        public static Phong phongForm;
        public MainForm()
        {
            InitializeComponent();

            if (dangNhapForm == null)
                dangNhapForm = new DangNhap();
            dangNhapForm.MdiParent = this;
            dangNhapForm.Show();
            //btnHopDong_Click(null, null);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            if (hopDongForm == null)
                hopDongForm = new HopDong();
            hopDongForm.MdiParent = this;
            hopDongForm.Show();
            hopDongForm.WindowState = FormWindowState.Maximized;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            if (sinhVienForm == null)
                sinhVienForm = new SinhVien();
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
            sinhVienForm.WindowState = FormWindowState.Maximized;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVienForm == null)
                nhanVienForm = new NhanVien();
            nhanVienForm.MdiParent = this;
            nhanVienForm.Show();
            nhanVienForm.WindowState = FormWindowState.Maximized;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            if (phongForm == null)
                phongForm = new Phong();
            phongForm.MdiParent = this;
            phongForm.Show();
            phongForm.WindowState = FormWindowState.Maximized;
        }
    }
}
