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
        public static string MaNhanVienHienTai { get; set; }
        public static string ChucVuHienTai { get; set; }
        public static bool Logined { get; set; }

        public static HopDong hopDongForm;
        public static SinhVien sinhVienForm;
        public static DangNhap dangNhapForm;
        public static NhanVien nhanVienForm;
        public static Phong phongForm;
        public static CaiDat caiDatForm = new CaiDat();

        public static KTXForm FormHienTai;
        public MainForm()
        {
            InitializeComponent();
            //btnHopDong_Click(null, null);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDangNhap_Click(dangNhapForm, null);
        }
        public void btnHopDong_Click(object sender, EventArgs e)
        {
            if (hopDongForm == null)
                hopDongForm = new HopDong();
            hopDongForm.MdiParent = this;
            hopDongForm.Show();
            hopDongForm.WindowState = FormWindowState.Maximized;
            FormHienTai = hopDongForm;
        }

        public void btnSinhVien_Click(object sender, EventArgs e)
        {
            if (sinhVienForm == null)
                sinhVienForm = new SinhVien();
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
            sinhVienForm.WindowState = FormWindowState.Maximized;
            FormHienTai = sinhVienForm;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVienForm == null)
                nhanVienForm = new NhanVien();
            nhanVienForm.MdiParent = this;
            nhanVienForm.Show();
            nhanVienForm.WindowState = FormWindowState.Maximized;
        }

        public void btnPhong_Click(object sender, EventArgs e)
        {
            if (phongForm == null)
                phongForm = new Phong();
            phongForm.MdiParent = this;
            phongForm.Show();
            phongForm.WindowState = FormWindowState.Maximized;
            FormHienTai = phongForm;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dangNhapForm == null)
                dangNhapForm = new DangNhap();
            dangNhapForm.Show();
            dangNhapForm.Activate();
        }

        public static string ThuMucAnh
        {
            get
            {
                return GUI.Properties.Settings.Default.ThuMucAnh;
            }
            set
            {
                GUI.Properties.Settings.Default.ThuMucAnh = value;
                GUI.Properties.Settings.Default.Save();
            }
        }

        private void btnCaiDat_Click_1(object sender, EventArgs e)
        {

            caiDatForm.CapNhatDuLieu();
            caiDatForm.Show();
            caiDatForm.Activate();
            caiDatForm.WindowState = FormWindowState.Normal;
        }
    }
}
