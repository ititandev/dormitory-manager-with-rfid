using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using static BUS.SinhVienBUS;
namespace GUI
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
            cbFilter.Items.Add(HoTen);
            cbFilter.Items.Add(MaSo);
            cbFilter.Items.Add(CMND);
            cbFilter.Items.Add(DienThoai);
            cbFilter.Items.Add(Email);
            cbFilter.SelectedItem = HoTen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void SinhVienView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
            dataGridView1.Show();
        }


        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            string value = txtValue.Text;
            string filter = cbFilter.Text;
            DataTable dt = (dataGridView1.DataSource as DataTable);
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"[{filter}] LIKE %{value}%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count > 0)
            {
                string key = row[0].Cells[MaSo].Value.ToString();
                SinhVienBUS.deleteSinhVien(key);
                dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
                dataGridView1.Refresh();
                dataGridView1.Update();
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
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
            SinhVienBUS.updateSinhVien(sv);
            dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = (DataGridView)sender;
            if (obj.Rows.Count > 0&&e.RowIndex>=0)
            {
                txtCMND.Text = obj.Rows[e.RowIndex].Cells[CMND].Value.ToString();
                txtDT.Text = obj.Rows[e.RowIndex].Cells[DienThoai].Value.ToString();
                txtEmail.Text = obj.Rows[e.RowIndex].Cells[Email].Value.ToString();
                txtKhoa.Text = obj.Rows[e.RowIndex].Cells[Khoa].Value.ToString();
                txtLop.Text = obj.Rows[e.RowIndex].Cells[Lop].Value.ToString();
                txtMaSo.Text = obj.Rows[e.RowIndex].Cells[MaSo].Value.ToString();
                txtQue.Text = obj.Rows[e.RowIndex].Cells[Que].Value.ToString();
                txtTen.Text = obj.Rows[e.RowIndex].Cells[HoTen].Value.ToString();
                txtUutien.Text = obj.Rows[e.RowIndex].Cells[DienUuTien].Value.ToString();
                dateNgaySinh.Value = DateTime.Parse(obj.Rows[e.RowIndex].Cells[NgaySinh].Value.ToString());
                cbGioiTinh.Text = obj.Rows[e.RowIndex].Cells[GioiTinh].Value.ToString();
                txtDRL.Text= obj.Rows[e.RowIndex].Cells[RFID].Value.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
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
            SinhVienBUS.addSinhVien(sv);
            dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.sinhVienForm = null;
        }
    }
}
