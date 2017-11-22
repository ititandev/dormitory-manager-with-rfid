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
    /// <summary>
    /// Class form đăng nhập khi bắt đầu sử dụng phần mềm
    /// </summary>
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
                    Program.mainForm.MaNhanVienHienTai = DangNhapBUS.GetMaNhanVien(txtTaiKhoan);
                    MainForm.DaDangNhap = true;
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

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
    }
}
