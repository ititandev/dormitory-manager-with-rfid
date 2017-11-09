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
    public partial class HopDong : Form
    {
        enum Mode
        {
            XEM, SUA, THEM
        }
        private static Mode CurrentMode { get; set; }
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            SetState(Mode.XEM);
            DataTable dataTable = HopDongBUS.ViewAll(dgvHopDong);

            dataTable.Columns[0].ColumnName = "Mã số";
            dataTable.Columns[1].ColumnName = "MSSV";
            dataTable.Columns[2].ColumnName = "Mã nhân viên";
            dataTable.Columns[3].ColumnName = "Ngày lập";
            dataTable.Columns[4].ColumnName = "Ngày bắt đầu";
            dataTable.Columns[5].ColumnName = "Ngày kết thúc";
            dataTable.Columns[6].ColumnName = "Tình trạng";
            dataTable.Columns[7].ColumnName = "Đã nộp";
            dataTable.Columns[8].ColumnName = "Tổng cộng";
            dgvHopDong.DataSource = dataTable;
            suaMode.Hide();
            cboTimKiemTheo.SelectedIndex = 0;
        }

        private void HopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.hopDongForm = null;
        }
        private void dgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            string tenNhanVien;
            
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                HopDongDTO hopDongDTO = HopDongBUS.ViewHopDong(row.Cells[0].Value.ToString(), out tenNhanVien);
                if (hopDongDTO == null)
                    return;
                lblMaSo.Text = hopDongDTO.MaSo.ToString();
                txtMSSV.Text = hopDongDTO.MSSV;
                lblNguoiLap.Text = tenNhanVien;
                lblNgayLap.Text = hopDongDTO.NgayLap.ToString("dd/MM/yyyy");
                dtpNgayBatDau.Value = hopDongDTO.NgayBatDau;
                dtpNgayKetThuc.Value = hopDongDTO.NgayKetThuc;
                lblTinhTrang.Text = hopDongDTO.TinhTrang;
                txtIDPhong.Text = hopDongDTO.IDPhong;
                txtGiaTienTongCong.Text = hopDongDTO.GiaTienTongCong.ToString();
                txtGiaTienDaNop.Text = hopDongDTO.GiaTienDaNop.ToString();
                txtChuThich.Text = hopDongDTO.ChuThich;


            }
        }
        private void HopDong_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width > 1400)
                dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            else
                dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            SinhVienDTO sinhVienDTO = SinhVienBUS.GetSinhVienDTO(txtMSSV.Text);
            if (sinhVienDTO != null)
            {
                lblHoTen.Text = sinhVienDTO.HoTen;
                lblNgaySinh.Text = sinhVienDTO.NgaySinh.ToString("dd/MM/yyyy");
                lblCMND.Text = sinhVienDTO.CMND;
                lblSoDienThoai.Text = sinhVienDTO.SoDienThoai;
                lblKhoa.Text = sinhVienDTO.Khoa;
                lblQueQuan.Text = sinhVienDTO.QueQuan;
                lblDienUuTien.Text = sinhVienDTO.DienUuTien;
                lblEmail.Text = sinhVienDTO.Email;
            }
            if (CurrentMode == Mode.THEM)
            {
                if (!SinhVienBUS.KiemTraSV(txtMSSV.Text))
                    lblNotFoundMSSV.Show();
                else
                    lblNotFoundMSSV.Hide();
            }
            else
                lblNotFoundMSSV.Hide();
            
        }
        private void btnDebug_Click(object sender, EventArgs e)
        {

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            HopDongDTO hopDongDTO = new HopDongDTO();

            hopDongDTO.MSSV = txtMSSV.Text;
            hopDongDTO.MaNhanVien = MainForm.NhanVienHienTai;
            hopDongDTO.NgayLap= Convert.ToDateTime(lblNgayLap.Text);
            hopDongDTO.NgayBatDau = dtpNgayBatDau.Value;
            hopDongDTO.NgayKetThuc = dtpNgayKetThuc.Value;
            hopDongDTO.TinhTrang = HopDongDTO.TinhTrangHopDongString[(int)TinhTrangHopDong.CHUA_TOI_THOI_HAN];
            hopDongDTO.IDPhong = txtIDPhong.Text;
            hopDongDTO.GiaTienTongCong = Convert.ToInt32(txtGiaTienTongCong.Text);
            hopDongDTO.GiaTienDaNop = Convert.ToInt32(txtGiaTienDaNop.Text);
            hopDongDTO.ChuThich = txtChuThich.Text;

            HopDongBUS.AddHopDong(hopDongDTO);
        }

        private void SetState(Mode state)
        {
            CurrentMode = state;
            if (state == Mode.XEM)
            {
                xemMode.BackColor = Color.LightSlateGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightGray;
                txtMSSV.Enabled = false;
                chkGioiTinhNu.Enabled = false;
                txtChuThich.Enabled = false;
                txtIDPhong.Enabled = false;
                txtGiaTienDaNop.Enabled = false;
                txtGiaTienTongCong.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;

                btnHopDong.Hide();
            }
            else if (state == Mode.SUA)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightSlateGray;
                themMode.BackColor = Color.LightGray;

                txtMSSV.Enabled = false;
                chkGioiTinhNu.Enabled = false;
                txtChuThich.Enabled = false;
                txtIDPhong.Enabled = false;
                txtGiaTienDaNop.Enabled = false;
                txtGiaTienTongCong.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;
                btnHopDong.Show();
            }
            else if (state == Mode.THEM)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightSlateGray;

                txtMSSV.Enabled = true;
                chkGioiTinhNu.Enabled = true;
                txtChuThich.Enabled = true;
                txtIDPhong.Enabled = true;
                txtGiaTienDaNop.Enabled = true;
                txtGiaTienTongCong.Enabled = true;
                dtpNgayBatDau.Enabled = true;
                dtpNgayKetThuc.Enabled = true;


                txtChuThich.Text = "";
                txtGiaTienDaNop.Text = "0";
                txtGiaTienTongCong.Text = "0";
                lblTinhTrang.Text = "Chưa tới thời hạn";
                lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblNgayLap.Text = MainForm.NhanVienHienTai;
                btnHopDong.Text = "Thêm hợp đồng";
                btnHopDong.Show();
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

        private void cboTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search()
        {
            //HopDongBUS.Search(cboThoiHan, cboTimKiemTheo, )
        }

        private void cboThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
