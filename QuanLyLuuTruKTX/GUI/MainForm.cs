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
    public partial class MainForm : Form
    {
        string maNhanVienHienTai;
        public string MaNhanVienHienTai
        {
            get
            {
                return maNhanVienHienTai;
            }
            set
            {
                maNhanVienHienTai = value;
                lblNhanVienHienTai.Text = DangNhapBUS.GetHoTen(maNhanVienHienTai);
            }
        }
        public static bool DaDangNhap { get; set; }

        public static HopDong hopDongForm;
        public static SinhVien sinhVienForm;
        public static DangNhap dangNhapForm;
        public static Phong phongForm;
        public static CaiDat caiDatForm = new CaiDat();

        public static KTXForm FormHienTai;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DaDangNhap = false;
        }
        public void btnHopDong_Click(object sender, EventArgs e)
        {
            if (!DaDangNhap)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hopDongForm == null)
                hopDongForm = new HopDong();
            hopDongForm.MdiParent = this;
            hopDongForm.Show();
            hopDongForm.WindowState = FormWindowState.Maximized;
            FormHienTai = hopDongForm;
        }

        public void btnSinhVien_Click(object sender, EventArgs e)
        {
            if (!DaDangNhap)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sinhVienForm == null)
                sinhVienForm = new SinhVien();
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
            sinhVienForm.WindowState = FormWindowState.Maximized;
            FormHienTai = sinhVienForm;
        }

        public void btnPhong_Click(object sender, EventArgs e)
        {
            if (!DaDangNhap)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
