using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using BUS;
using DTO;
using static BUS.SinhVienBUS;
namespace GUI
{
    /// <summary>
    /// Class form quản lý thông tin sinh viên
    /// </summary>
    public partial class SinhVien : KTXForm
    {
        public enum CheDo
        {
            XEM, SUA, THEM, CHON_SV
        }
        private string duongDanAnh;
        private static CheDo CheDoHienTai { get; set; }
        public static bool DaChonAnh { get; set; }
        public string DuongDanAnh
        {
            get
            {
                return duongDanAnh;
            }
            set
            {
                duongDanAnh = value;
                try
                {
                    pic.Image = Image.FromFile(duongDanAnh);
                }
                catch (Exception ex)
                {
                    pic.Image = null;
                }

            }
        }
        public SinhVien()
        {
            InitializeComponent();
            cboTimKiemTheo.Items.Add(HoTen);
            cboTimKiemTheo.Items.Add(MaSo);
            cboTimKiemTheo.Items.Add(CMND);
            cboTimKiemTheo.Items.Add(DienThoai);
            cboTimKiemTheo.Items.Add(Email);
            cboTimKiemTheo.SelectedItem = HoTen;
            SetCheDo(CheDo.XEM);
        }

        private void SinhVienView_Load(object sender, EventArgs e)
        {
            dgv.DataSource = SinhVienBUS.LoadSinhVien();
            dgv.Columns[Anh].Visible = false;
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
            try
            {
                dt.DefaultView.RowFilter = $"[{filter}] LIKE '%{value}%'";
            }
            catch (Exception)
            {
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = dgv.SelectedRows;
            if (row.Count > 0)
            {
                string MSSV = row[0].Cells[MaSo].Value.ToString();
                if (SinhVienBUS.XoaSinhVien(MSSV))
                    MessageBox.Show("Xóa thành công sinh viên " + MSSV);
                else
                    MessageBox.Show("Xóa thất bại sinh viên " + MSSV, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnXemTatCa_Click(null, null);
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

        public void SetCheDo(CheDo cheDo)
        {
            CheDoHienTai = cheDo;
            if (cheDo == CheDo.XEM)
            {
                dgv_SelectionChanged(dgv, null);
                xemMode.BackColor = Color.LightSlateGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightGray;
                SetReadOnly(true, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                dtpNgaySinh.Enabled = false;
                btnChonFile.Hide();
                btnChupAnh.Hide();
                btnHanhDong.Hide();
                btnChonSV.Show();
            }
            else if (cheDo == CheDo.SUA)
            {
                dgv_SelectionChanged(dgv, null);
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightSlateGray;
                themMode.BackColor = Color.LightGray;
                SetReadOnly(false, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                dtpNgaySinh.Enabled = true;
                btnChonFile.Show();
                btnChupAnh.Show();
                DaChonAnh = false;
                btnHanhDong.Show();
                btnHanhDong.Text = "Cập nhật";
                btnChonSV.Hide();
            }
            else if (cheDo == CheDo.THEM)
            {
                xemMode.BackColor = Color.LightGray;
                suaMode.BackColor = Color.LightGray;
                themMode.BackColor = Color.LightSlateGray;
                dtpNgaySinh.Enabled = true;
                SetReadOnly(false, txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                Clear(txtTen, txtLop, txtCMND, txtDT, txtKhoa, txtQueQuan, txtDienUutien, txtEmail, txtMSSV, txtRFID);
                btnChonFile.Show();
                btnChupAnh.Show();
                DaChonAnh = false;
                DuongDanAnh = null;
                btnHanhDong.Show();
                btnHanhDong.Text = "Thêm";
                btnChonSV.Hide();
            }
            else if (cheDo == CheDo.CHON_SV)
            {
                btnChonSV.Show();
            }
        }

        private void btnHanhDong_Click(object sender, EventArgs e)
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
            sv.RFID = txtRFID.Text;

            if (CheDoHienTai == CheDo.THEM)
            {
                if (!DaChonAnh)
                {
                    MessageBox.Show("Vui lòng chọn ảnh/RFID cho sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int index = DuongDanAnh.LastIndexOf('.');
                sv.Anh = sv.MSSV + DuongDanAnh.Remove(0, index);
                string destPath = MainForm.ThuMucAnh + sv.MSSV + DuongDanAnh.Remove(0, index);
                try
                {
                    File.Copy(DuongDanAnh, destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm ảnh vào cơ sở dữ liệu\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!SinhVienBUS.ThemSinhVien(sv))
                {
                    File.Delete(destPath);
                    return;
                }
                btnXemTatCa_Click(null, null);
                SetCheDo(CheDo.XEM);
            }
            else if (CheDoHienTai == CheDo.SUA)
            {
                if (DaChonAnh == true)
                {
                    int index = DuongDanAnh.LastIndexOf('.');
                    Random ran = new Random();
                    string randomCode = "(" + ran.Next() + ")";
                    string destPath = MainForm.ThuMucAnh + sv.MSSV + randomCode + DuongDanAnh.Remove(0, index);
                    sv.Anh = sv.MSSV + randomCode + DuongDanAnh.Remove(0, index);
                    try
                    {
                        File.Copy(DuongDanAnh, destPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm ảnh vào cơ sở dữ liệu\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    int index = DuongDanAnh.LastIndexOf('\\');
                    sv.Anh = DuongDanAnh.Remove(0, index + 1);
                }
                if (SinhVienBUS.CapNhatSinhVien(sv))
                {
                    btnXemTatCa_Click(null, null);
                    SetCheDo(CheDo.XEM);
                }


            }

        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DaChonAnh = true;
                DuongDanAnh = openFileDialog.FileName;
            }

        }

        private void btnChupAnh_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string fileName = "temp" + rand.Next() + ".jpg";
            new List<string>(Directory.GetFiles(Directory.GetCurrentDirectory())).ForEach(file =>
            {
                if (file.IndexOf("temp", StringComparison.OrdinalIgnoreCase) >= 0)
                    File.Delete(file);
            });
            MessageBox.Show("Nhấn F8 để chụp");
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "WebCamImageSave.exe";
            startInfo.Arguments = "/Filename " + fileName;
            process.StartInfo = startInfo;
            process.Start();
            do
            {
                System.Threading.Thread.Sleep(200);
                Process[] pname = Process.GetProcessesByName("WebCamImageSave");
                if (pname.Length == 0)
                {
                    break;
                }
            } while (true);
            if (File.Exists(fileName))
            {
                DuongDanAnh = Directory.GetCurrentDirectory() + @"\" + fileName;
                DaChonAnh = true;
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (CheDoHienTai == CheDo.THEM)
            {
                lblHopDongHopLe.Hide();
                return;
            }
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                txtCMND.Text = row.Cells[CMND].Value.ToString();
                txtDT.Text = row.Cells[DienThoai].Value.ToString();
                txtEmail.Text = row.Cells[Email].Value.ToString();
                txtKhoa.Text = row.Cells[Khoa].Value.ToString();
                txtLop.Text = row.Cells[Lop].Value.ToString();
                txtMSSV.Text = row.Cells[MaSo].Value.ToString();
                txtQueQuan.Text = row.Cells[Que].Value.ToString();
                txtTen.Text = row.Cells[HoTen].Value.ToString();
                txtDienUutien.Text = row.Cells[DienUuTien].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells[NgaySinh].Value.ToString());
                cbGioiTinh.Text = row.Cells[GioiTinh].Value.ToString();
                txtRFID.Text = row.Cells[RFID].Value.ToString();
                DuongDanAnh = MainForm.ThuMucAnh + row.Cells[Anh].Value.ToString();

                if (HopDongBUS.KiemTraThoiHan(txtMSSV.Text))
                    lblHopDongHopLe.Hide();
                else
                    lblHopDongHopLe.Show();
            }
        }
        public override void SendRFID(string RFID)
        {
            if (CheDoHienTai == CheDo.XEM)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells["RFID"].Value.ToString() == RFID)
                        dgv.CurrentCell = this.dgv["RFID", i];
                }
            }
            else
            {
                txtRFID.Text = RFID;
            }

        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            dgv.DataSource = SinhVienBUS.LoadSinhVien();
            dgv.Columns[Anh].Visible = false;
            dgv.Refresh();
            dgv.Update();
        }

        private void SinhVien_Activated(object sender, EventArgs e)
        {
            MainForm.FormHienTai = MainForm.sinhVienForm;
        }
        public void XemSinhVien(string MSSV)
        {
            SetCheDo(CheDo.XEM);
            cboTimKiemTheo.SelectedIndex = 1;
            txtTimKiem.Text = MSSV;
        }

        private void btnChonSV_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.mainForm.btnHopDong_Click(null, null);
            MainForm.hopDongForm.SetMSSV(dgv.SelectedRows[0].Cells[MaSo].Value.ToString());
            SetCheDo(CheDo.XEM);
        }

        private void xemHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.mainForm.btnHopDong_Click(null, null);
            MainForm.hopDongForm.XemHopDong(dgv.SelectedRows[0].Cells["MSSV"].Value.ToString());
        }
        
    }
}
