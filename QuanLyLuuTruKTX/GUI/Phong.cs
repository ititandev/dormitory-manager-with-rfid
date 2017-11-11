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
using DTO;

namespace GUI
{
    public partial class Phong : Form
    {
        private PhongBUS phongBUS = new PhongBUS();
        public Phong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phong_Load(object sender, EventArgs e)
        {
            PhongBUS.ViewAll(dgvPhong);
            this.numUDChangeSoLuongHienTai.Maximum = 12;
            this.numUDChangeSoLuongHienTai.Minimum = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = new PhongDTO();
            phongDTO.SoPhong = this.tbAddSoPhong.Text;
            phongDTO.KhuNha = this.cbAddKhuNha.Text;
            phongDTO.MaNhanVien = this.tbAddMaNhanVien.Text;
            try
            {
                phongDTO.SoLuongChoPhep = Convert.ToInt32(this.cbAddLoaiPhong.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + "Vui lòng điền số lượng hợp lệ");
            }
            phongDTO.TinhTrang = "Còn trống";
            phongDTO.SoLuongHienTai = 0;
            phongDTO.IDPhong = phongDTO.KhuNha + "-" + phongDTO.SoPhong;

            try
            {
                phongBUS.Them(phongDTO);
                MessageBox.Show("Add room successfully");
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.ToString());
            }
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = new PhongDTO();
            phongDTO.SoPhong = this.tbAddSoPhong.Text;
            phongDTO.KhuNha = this.cbChangeKhuNha.Text;
            phongDTO.MaNhanVien = this.tbChangeMaNhanVien.Text;
            try
            {
                phongDTO.SoLuongChoPhep = Convert.ToInt32(this.cbChangeLoaiPhong.Text);
                phongDTO.SoLuongChoPhep = Convert.ToInt32(this.cbChangeLoaiPhong.Text);
                phongDTO.SoLuongHienTai = Convert.ToInt32(this.numUDChangeSoLuongHienTai.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + "Vui lòng điền số lượng hợp lệ");
            }
            phongDTO.TinhTrang = this.cbChangeStatus.Text;
            phongDTO.IDPhong = phongDTO.KhuNha + "-" + phongDTO.SoPhong;
            try
            {
                phongBUS.Sua(phongDTO);
                MessageBox.Show("Update room successfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = this.tbSearch.Text;
            phongBUS.TimKiem(this.dgvPhong, searchText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = new PhongDTO();
            phongDTO.SoPhong = this.tbTimKiemSoPhong.Text;
            phongDTO.KhuNha = this.cbTimKiemKhuNha.Text;
            phongDTO.MaNhanVien = this.tbTimKiemMaNhanVien.Text;
            try
            {
                phongDTO.SoLuongChoPhep = Convert.ToInt32(this.cbTimKiemLoaiPhong.Text);
            }
            catch (Exception err)
            {
                phongDTO.SoLuongChoPhep = -1;
            }
            phongDTO.TinhTrang = this.cbChangeStatus.Text;
            try
            {
                phongDTO.SoLuongHienTai = Convert.ToInt32(this.numUDTimKiemSoLuongHienTai.Value);
            }
            catch (Exception err)
            {
                phongDTO.SoLuongHienTai = -1;
            }
            try
            {
                phongBUS.TimKiem(this.dgvPhong, phongDTO);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.ToString());
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.tbSearch.Text = "";
            PhongBUS.ViewAll(dgvPhong);
        }

        private void Phong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.phongForm = null;
        }
    }
}
