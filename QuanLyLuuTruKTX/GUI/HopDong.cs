using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                lblTinhTrang.Text = row.Cells[6].Value.ToString();
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
                try
                {
                    picAnh.Image = Image.FromFile(MainForm.ThuMucAnh + sinhVienDTO.Anh);
                }
                catch
                {
                    picAnh.Image = null;
                }

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
                picAnh.Image = null;
            }
            if (CheDoHienTai == CheDo.THEM)
            {
                if (!SinhVienBUS.KiemTraSinhVien(txtMSSV.Text))
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
            hopDongDTO.MaNhanVien = Program.mainForm.MaNhanVienHienTai;
            hopDongDTO.NgayLap = Convert.ToDateTime(lblNgayLap.Text);
            hopDongDTO.NgayBatDau = dtpNgayBatDau.Value;
            hopDongDTO.NgayKetThuc = dtpNgayKetThuc.Value;
            hopDongDTO.IDPhong = txtIDPhong.Text;
            hopDongDTO.GiaTienTongCong = Convert.ToInt32(txtGiaTienTongCong.Text);
            hopDongDTO.GiaTienDaNop = Convert.ToInt32(txtGiaTienDaNop.Text);
            hopDongDTO.ChuThich = txtChuThich.Text;

            HopDongBUS.ThemHopDongDTO(hopDongDTO);
        }

        private void xemMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.XEM);
        }

        private void suaMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.SUA);
        }

        private void themMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.THEM);
        }

        private void cboTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cboThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            chxTheoTinhTrang.Checked = true;
            TimKiem();
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
            TimKiem();
        }

        private void chxTheoTinhTrang_CheckedChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void chxTheoThoiHan_CheckedChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dtpNgayBatDauTimKiem_ValueChanged(object sender, EventArgs e)
        {
            chxTheoThoiHan.Checked = true;
            TimKiem();
        }

        private void dtpNgayKetThucTimKiem_ValueChanged(object sender, EventArgs e)
        {
            chxTheoThoiHan.Checked = true;
            TimKiem();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
        private void TimKiem()
        {
            try
            {
                dataTable.DefaultView.RowFilter = HopDongBUS.TimKiem(chxTheoTinhTrang, cboTinhTrang, chxTheoThoiHan,
                dtpNgayBatDauTimKiem, dtpNgayKetThucTimKiem, cboTimKiemTheo, txtTimKiem);
            }
            catch (Exception e)
            {
            }

        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.XEM);
            dataTable = HopDongBUS.LoadTatCa();
            dgvHopDong.DataSource = dataTable;
            dgvHopDong.Columns["RFID"].Visible = false;
            chxTheoTinhTrang.Checked = true;
            cboTimKiemTheo.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            txtTimKiem.Text = "";
            dgvHopDong.Sort(dgvHopDong.Columns["Ngày lập"], ListSortDirection.Descending);
        }

        public override void SendRFID(string RFID)
        {
            dataTable.DefaultView.RowFilter = "[RFID] = '" + RFID + "'";
        }

        private void HopDong_Activated(object sender, EventArgs e)
        {
            MainForm.FormHienTai = MainForm.hopDongForm;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                if (HopDongBUS.Xoa(row.Cells[0].Value.ToString()))
                    MessageBox.Show("Xóa hợp đồng mã số " + row.Cells[0].Value.ToString() + " thành công");
                else
                {
                    MessageBox.Show("Xóa hợp đồng mã số " + row.Cells[0].Value.ToString() + " thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                var report = new Report(row.Cells[0].Value.ToString());
                report.ShowDialog();
                return;
            }
        }
        public void SetIDPhong(string IDPhong)
        {
            if (CheDoHienTai != CheDo.THEM)
                SetCheDo(CheDo.THEM);
            txtIDPhong.Text = IDPhong;
        }
        public void SetMSSV(string MSSV)
        {
            if (CheDoHienTai != CheDo.THEM)
                SetCheDo(CheDo.THEM);
            txtMSSV.Text = MSSV;
        }
        public void XemHopDong(string MSSV)
        {
            SetCheDo(CheDo.XEM);
            cboTimKiemTheo.SelectedIndex = 2;
            chxTheoTinhTrang.Checked = true;
            cboTinhTrang.SelectedIndex = 0;
            txtTimKiem.Text = MSSV;
        }
        private void btnXemSinhVien_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                Program.mainForm.btnSinhVien_Click(null, null);
                MainForm.sinhVienForm.XemSinhVien(row.Cells[1].Value.ToString());
                return;
            }
        }
        private void btnXemPhong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHopDong.SelectedRows)
            {
                Program.mainForm.btnPhong_Click(null, null);
                MainForm.phongForm.XemPhong(row.Cells[7].Value.ToString(), (row.Cells[1].Value.ToString()));
                return;
            }
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            Program.mainForm.btnPhong_Click(null, null);
            MainForm.phongForm.SetCheDo(Phong.CheDo.CHON_PHONG);
        }

        private void btnChonMSSV_Click(object sender, EventArgs e)
        {
            Program.mainForm.btnSinhVien_Click(null, null);
            MainForm.sinhVienForm.SetCheDo(SinhVien.CheDo.CHON_SV);
        }
    }
}
