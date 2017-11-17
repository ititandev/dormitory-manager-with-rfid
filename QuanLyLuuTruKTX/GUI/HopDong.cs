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
    public partial class HopDong : KTXForm
    {
        enum CheDo
        {
            XEM, SUA, THEM
        }
        private static CheDo CheDoHienTai { get; set; }
        private DataTable dataTable;
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            btnXemTatCa_Click(null, null);
            suaMode.Hide();
        }

        private void HopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.hopDongForm = null;
        }
        private void dgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (CheDoHienTai == CheDo.THEM)
                return;
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
                return;
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
            if (CheDoHienTai == CheDo.THEM)
            {
                if (!SinhVienBUS.KiemTraHopDongSV(txtMSSV.Text))
                    lblNotFoundMSSV.Show();
                else
                    lblNotFoundMSSV.Hide();
            }
            else
                lblNotFoundMSSV.Hide();

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            HopDongDTO hopDongDTO = new HopDongDTO();

            hopDongDTO.MSSV = txtMSSV.Text;
            hopDongDTO.MaNhanVien = MainForm.MaNhanVienHienTai;
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

        private void xemMode_Click(object sender, EventArgs e)
        {
            SetState(CheDo.XEM);
        }

        private void suaMode_Click(object sender, EventArgs e)
        {
            SetState(CheDo.SUA);
        }

        private void themMode_Click(object sender, EventArgs e)
        {
            SetState(CheDo.THEM);
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
            if (CheDoHienTai == CheDo.THEM)
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
            try
            {
                dataTable.DefaultView.RowFilter = HopDongBUS.TimKiem(chxTheoTinhTrang, cboTinhTrang, chxTheoThoiHan,
                dtpNgayBatDauTimKiem, dtpNgayKetThucTimKiem, chxChuaDuTien, cboTimKiemTheo, txtTimKiem, dtpNgayLap);
            }
            catch (Exception e)
            {
            }

        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            SetState(CheDo.XEM);
            dataTable = HopDongBUS.XemTatCa();
            dgvHopDong.DataSource = dataTable;
            dgvHopDong.Columns["RFID"].Visible = false;
            chxTheoTinhTrang.Checked = true;
            cboTimKiemTheo.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            txtTimKiem.Text = "";
        }

        public override void SendRFID(string RFID)
        {
            dataTable.DefaultView.RowFilter = "[RFID] = '" + RFID + "'";

        }
    }
}
