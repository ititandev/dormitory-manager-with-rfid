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
        private DataTable dataTable;
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            SetState(Mode.XEM);
            dataTable = HopDongBUS.ViewAll(dgvHopDong);

            dataTable.Columns[0].ColumnName = "Mã số";
            dataTable.Columns[1].ColumnName = "MSSV";
            dataTable.Columns[2].ColumnName = "Người lập";
            dataTable.Columns[3].ColumnName = "Ngày lập";
            dataTable.Columns[4].ColumnName = "Ngày bắt đầu";
            dataTable.Columns[5].ColumnName = "Ngày kết thúc";
            dataTable.Columns[6].ColumnName = "Thời hạn";
            dataTable.Columns[7].ColumnName = "ID Phòng";
            dataTable.Columns[8].ColumnName = "Đã nộp";
            dataTable.Columns[9].ColumnName = "Tổng cộng";
            dgvHopDong.DataSource = dataTable;
            suaMode.Hide();
            cboTinhTrang.SelectedIndex = 0;
            cboTimKiemTheo.SelectedIndex = 0;
        }

        private void HopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.hopDongForm = null;
        }
        private void dgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                HopDongDTO hopDongDTO = HopDongBUS.GetHopDongDTO(row.Cells[0].Value.ToString());
                if (hopDongDTO == null)
                    return;
                lblMaSo.Text = hopDongDTO.MaSo.ToString();
                txtMSSV.Text = hopDongDTO.MSSV;
                lblNguoiLap.Text = row.Cells[2].Value.ToString();
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
                lblGioiTinh.Text = sinhVienDTO.GioiTinh;
                lblSoDienThoai.Text = sinhVienDTO.SoDienThoai;
                lblKhoa.Text = sinhVienDTO.Khoa;
                lblQueQuan.Text = sinhVienDTO.QueQuan;
                lblDienUuTien.Text = sinhVienDTO.DienUuTien;
                lblEmail.Text = sinhVienDTO.Email;
            }
            else
            {
                lblHoTen.Text = "";
                lblNgaySinh.Text = "";
                lblCMND.Text = "";
                lblGioiTinh.Text = "";
                lblSoDienThoai.Text = "";
                lblKhoa.Text = "";
                lblQueQuan.Text = "";
                lblDienUuTien.Text = "";
                lblEmail.Text = "";
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
            hopDongDTO.NgayLap = Convert.ToDateTime(lblNgayLap.Text);
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
                txtChuThich.Enabled = true;
                txtIDPhong.Enabled = true;
                txtGiaTienDaNop.Enabled = true;
                txtGiaTienTongCong.Enabled = true;
                dtpNgayBatDau.Enabled = true;
                dtpNgayKetThuc.Enabled = true;

                lblMaSo.Text = "";
                txtMSSV.Text = "";
                txtChuThich.Text = "";
                txtIDPhong.Text = "";
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
            if (cboTimKiemTheo.Text == "Ngày lập")
            {
                dtpNgayLap.Show();
                txtTimKiem.Hide();
            }
            else
            {
                dtpNgayLap.Hide();
                txtTimKiem.Show();
            }
            Search();
        }

        private void TimKiem()
        {
            //PhongBUS.TimKiem()
        }
        private void cboThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            chxTheoTinhTrang.Checked = true;
            Search();
        }

        private void txtIDPhong_TextChanged(object sender, EventArgs e)
        {
            PhongDTO phongDTO = PhongBUS.GetPhongDTO(txtIDPhong.Text);
            if (phongDTO == null)
            {
                lblKhuNha.Text = "";
                lblSoPhong.Text = "";
            }
            else
            {
                lblKhuNha.Text = phongDTO.KhuNha;
                lblSoPhong.Text = phongDTO.SoPhong;
            }
            if (CurrentMode == Mode.THEM)
            {
                if (!PhongBUS.KiemTraPhong(txtIDPhong.Text))
                    lblNotSuitableRoom.Show();
                else
                    lblNotSuitableRoom.Hide();
            }
            else
            {
                lblNotSuitableRoom.Hide();
            }
                
        }

        private void chxChuaDuTien_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void chxTheoTinhTrang_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void chxTheoThoiHan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpNgayBatDauTimKiem_ValueChanged(object sender, EventArgs e)
        {
            chxTheoThoiHan.Checked = true;
            Search();
        }

        private void dtpNgayKetThucTimKiem_ValueChanged(object sender, EventArgs e)
        {
            chxTheoThoiHan.Checked = true;
            Search();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            dataTable.DefaultView.RowFilter = HopDongBUS.TimKiem(chxTheoTinhTrang, cboTinhTrang, chxTheoThoiHan,
                dtpNgayBatDauTimKiem, dtpNgayKetThucTimKiem, chxChuaDuTien, cboTimKiemTheo, txtTimKiem, dtpNgayLap);
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
