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
            if (dangNhapBUS.KiemTra(txtTaiKhoan, txtMatKhau))
            {
                if (dangNhapBUS.DangNhap(txtTaiKhoan, txtMatKhau))
                {
                    MessageBox.Show("Bạn đăng nhập thành công!", "Dang nhap");
                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                }
                else
                    MessageBox.Show("Bạn đăng nhập không thành công!", "Dang nhap");
            }
        }
    }
}
