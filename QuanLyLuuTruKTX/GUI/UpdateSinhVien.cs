using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BUS.SinhVienBUS;
using DTO;
using BUS;
namespace GUI
{
    public partial class UpdateSinhVien : Form
    {
        SinhVienDTO sv = new SinhVienDTO();
        bool AddNew = false;
        public UpdateSinhVien(Dictionary<string,string> dic)
        {
            
            InitializeComponent();
            txtCMND.Text = dic[CMND];
            txtDT.Text = dic[DienThoai];
            txtEmail.Text = dic[Email];
            txtKhoa.Text = dic[Khoa];
            txtLop.Text = dic[Lop];
            txtMaSo.Text = dic[MaSo];
            txtQue.Text = dic[Que];
            txtTen.Text = dic[HoTen];
            txtDRL.Text = dic[TongDiem];
            txtUutien.Text = dic[DienUuTien];
            dateNgaySinh.Value = DateTime.Parse(dic[NgaySinh]);
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            Updated = false;
            cbGioiTinh.SelectedItem = dic[GioiTinh];
            
        }
        public UpdateSinhVien()
        {
            InitializeComponent();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedItem = "Nam";
            btnUpdate.Text = "Thêm mới";
            AddNew = true;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtUutien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtQue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool Updated { get; set; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sv.CMND = txtCMND.Text;
            sv.SoDienThoai = txtDT.Text;
            sv.Email = txtEmail.Text;
            sv.Khoa = txtKhoa.Text;
            sv.Lop = txtLop.Text;
            sv.MSSV = txtMaSo.Text;
            sv.QueQuan = txtQue.Text;
            sv.HoTen = txtTen.Text;
            sv.DienUuTien = txtUutien.Text;
            sv.NgaySinh = dateNgaySinh.Value;
            sv.GioiTinh = cbGioiTinh.Text;
            if (!AddNew)
            {
                SinhVienBUS.updateSinhVien(sv);
                Updated = true;
            }
            else
            {
                SinhVienBUS.addSinhVien(sv);
                Updated = true;
            }
            this.Close();
        }
    }
}
