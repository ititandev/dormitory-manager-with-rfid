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
    public partial class DangNhap : Form
    {
        private DangNhapBUS dangNhapBUS = new DangNhapBUS();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (DangNhapBUS.KiemTra(txtTaiKhoan, txtMatKhau))
            {
                if (DangNhapBUS.DangNhap(txtTaiKhoan, txtMatKhau))
                {
                    MessageBox.Show("Bạn đăng nhập thành công!", "Dang nhap");
                    MainForm.MaNhanVienHienTai = DangNhapBUS.GetMaNhanVien(txtTaiKhoan);
                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                    Hide();
                }
                else
                    MessageBox.Show("Bạn đăng nhập không thành công!", "Dang nhap");
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.dangNhapForm = null;
        }
    }
}
