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
        enum Mode
        {
            XEM, SUA, THEM
        }
        private static Mode CurrentMode { get; set; }
        public SinhVien()
        {
            InitializeComponent();
            cboTimKiemTheo.Items.Add(HoTen);
            cboTimKiemTheo.Items.Add(MaSo);
            cboTimKiemTheo.Items.Add(CMND);
            cboTimKiemTheo.Items.Add(DienThoai);
            cboTimKiemTheo.Items.Add(Email);
            cboTimKiemTheo.SelectedItem = HoTen;
            SetState(Mode.XEM);
        }

        private void SinhVienView_Load(object sender, EventArgs e)
        {
            dgv.DataSource = SinhVienBUS.XemTatCa();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.CMND = txtCMND.Text;
            sv.SoDienThoai = txtDT.Text;
            sv.Email = txtEmail.Text;
            sv.Khoa = txtKhoa.Text;
            sv.Lop = txtLop.Text;
            sv.MSSV = txtMSSV.Text;
            sv.QueQuan = txtQueQuan.Text;
            sv.HoTen = txtTen.Text;
            sv.DienUuTien = txtDienUutien.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = cbGioiTinh.Text;
            SinhVienBUS.CapNhatSinhVien(sv);
            dgv.DataSource = SinhVienBUS.XemTatCa();
            dgv.Refresh();
            dgv.Update();
        }


        private void SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.sinhVienForm = null;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            string filter = cboTimKiemTheo.Text;
            DataTable dt = (dgv.DataSource as DataTable);
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"[{filter}] LIKE %{value}%";
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = (DataGridView)sender;
            if (obj.Rows.Count > 0 && e.RowIndex >= 0)
            {
                txtCMND.Text = obj.Rows[e.RowIndex].Cells[CMND].Value.ToString();
                txtDT.Text = obj.Rows[e.RowIndex].Cells[DienThoai].Value.ToString();
                txtEmail.Text = obj.Rows[e.RowIndex].Cells[Email].Value.ToString();
                txtKhoa.Text = obj.Rows[e.RowIndex].Cells[Khoa].Value.ToString();
                txtLop.Text = obj.Rows[e.RowIndex].Cells[Lop].Value.ToString();
                txtMSSV.Text = obj.Rows[e.RowIndex].Cells[MaSo].Value.ToString();
                txtQueQuan.Text = obj.Rows[e.RowIndex].Cells[Que].Value.ToString();
                txtTen.Text = obj.Rows[e.RowIndex].Cells[HoTen].Value.ToString();
                txtDienUutien.Text = obj.Rows[e.RowIndex].Cells[DienUuTien].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(obj.Rows[e.RowIndex].Cells[NgaySinh].Value.ToString());
                cbGioiTinh.Text = obj.Rows[e.RowIndex].Cells[GioiTinh].Value.ToString();
                txtRFID.Text = obj.Rows[e.RowIndex].Cells[RFID].Value.ToString();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = dgv.SelectedRows;
            if (row.Count > 0)
            {
                string key = row[0].Cells[MaSo].Value.ToString();
                SinhVienBUS.XoaSinhVien(key);
                dgv.DataSource = SinhVienBUS.XemTatCa();
                dgv.Refresh();
                dgv.Update();
            }
        }

        private void xemMode_Click(object sender, EventArgs e)
        {
            SetState(Mode.XEM);
        }

        private void suaMode_Click(object sender, EventArgs e)
        {
            SetState(Mode.SUA);
        }

        private void themMode_Click(object sender, EventArgs e)
        {
            SetState(Mode.THEM);
        }

        private void SetState(Mode state)
        {
            CurrentMode = state;
            if (state == Mode.XEM)
            {
                xemMode.BackColor = Color.LightSlateGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightGray;
                SetReadOnly(true, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                dtpNgaySinh.Enabled = false;
            }
            else if (state == Mode.SUA)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightSlateGray;
                themMode.BackColor = Color.LightGray;
                SetReadOnly(false, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                dtpNgaySinh.Enabled = true;
            }
            else if (state == Mode.THEM)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightSlateGray;
                dtpNgaySinh.Enabled = true;
                SetReadOnly(false, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                Clear(txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
            }
        }

        private void btnHanhDong_Click(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.THEM)
            {
                SinhVienDTO sv = new SinhVienDTO();
                sv.CMND = txtCMND.Text;
                sv.SoDienThoai = txtDT.Text;
                sv.Email = txtEmail.Text;
                sv.Khoa = txtKhoa.Text;
                sv.Lop = txtLop.Text;
                sv.MSSV = txtMSSV.Text;
                sv.QueQuan = txtQueQuan.Text;
                sv.HoTen = txtTen.Text;
                sv.DienUuTien = txtDienUutien.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.GioiTinh = cbGioiTinh.Text;
                sv.Anh = "a.jpg";
                sv.RFID = "2332";

                SinhVienBUS.ThemSinhVien(sv);
                dgv.DataSource = SinhVienBUS.XemTatCa();
                dgv.Refresh();
                dgv.Update();
            }
        }
    }
}
