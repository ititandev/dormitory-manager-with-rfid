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
    public partial class NhanVien : Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private bool Add = false;
        private bool Updated = false;
        private bool Remove = false;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load_1(object sender, EventArgs e)
        {
            NhanVienBUS.LayDS(dgvNhanVien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtHoTen.Enabled = true;
            txtMa.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtQueQuan.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtChucVu.Enabled = true;

            txtHoTen.Text = "";
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";

            btnCapNhat.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvNhanVien.Enabled = false;

            Add = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtMa.Enabled = false;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtQueQuan.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtChucVu.Enabled = true;

            btnCapNhat.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvNhanVien.Enabled = true;

            Updated = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvNhanVien.Enabled = true;

            Remove = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVienDTO nvDTO = new NhanVienDTO();
            nvDTO.HoTen = txtHoTen.Text;
            nvDTO.MaNhanVien = txtMa.Text;
            nvDTO.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            nvDTO.GioiTinh = cboGioiTinh.Text;
            nvDTO.DiaChi = txtDiaChi.Text;
            nvDTO.QueQuan = txtQueQuan.Text;
            nvDTO.SoDienThoai = txtSDT.Text;
            nvDTO.Email = txtEmail.Text;
            nvDTO.ChucVu = txtChucVu.Text;

            if (Add)
            {
                nhanVienBUS.Them(nvDTO);
            }
            else if (Updated)
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    nhanVienBUS.Sua(nvDTO);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên cần sửa", "Nhân viên", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else if (Remove)
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    nhanVienBUS.Xoa(nvDTO);
                }
            }

            Add = Updated = Remove = false;

            txtHoTen.Enabled = false;
            txtMa.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtChucVu.Enabled = false;

            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;

            dgvNhanVien.Enabled = false;

            txtHoTen.Text = "";
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";

            NhanVienBUS.LayDS(dgvNhanVien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Add = Updated = Remove = false;

            txtHoTen.Enabled = false;
            txtMa.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtChucVu.Enabled = false;

            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;

            dgvNhanVien.Enabled = false;

            txtHoTen.Text = "";
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                txtHoTen.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                txtMa.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                txtQueQuan.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                txtSDT.Text = dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
                txtEmail.Text = dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
                txtChucVu.Text = dgvNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            }  
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtSearchTen.Text == "" && txtSearchMa.Text == "" && txtSearchNgay.Text == "" && cboSearchGT.Text != "Nam" && cboSearchGT.Text != "Nữ" &&
                txtSearchDC.Text == "" && txtSearchQQ.Text == "" && txtSearchSDT.Text == "" && txtSearchEmail.Text == "" && txtSearchCV.Text == "")
            {
                MessageBox.Show("Nhập từ khóa để tìm kiếm", "Nhân viên");
            }
            else
            {
                NhanVienDTO nvDTO = new NhanVienDTO(); 
                nvDTO.HoTen = txtSearchTen.Text;
                nvDTO.MaNhanVien = txtSearchMa.Text;
                nvDTO.NgaySinh = txtSearchNgay.Text;

                if(cboSearchGT.Text == "Tất cả")
                {
                    nvDTO.GioiTinh = "";
                }
                else
                {
                    nvDTO.GioiTinh = cboSearchGT.Text;
                }
                
                nvDTO.DiaChi = txtSearchDC.Text;
                nvDTO.QueQuan = txtSearchQQ.Text;
                nvDTO.SoDienThoai = txtSearchSDT.Text;
                nvDTO.Email = txtSearchEmail.Text;
                nvDTO.ChucVu = txtSearchCV.Text;
                nhanVienBUS.TimKiem(dgvNhanVien, nvDTO);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            NhanVienBUS.LayDS(dgvNhanVien);
            txtSearchTen.Text = "";
            txtSearchMa.Text = "";
            cboSearchGT.Text = "Tất cả";
            txtSearchNgay.Text = "";
            txtSearchDC.Text = "";
            txtSearchQQ.Text = "";
            txtSearchSDT.Text = "";
            txtSearchEmail.Text = "";
            txtSearchCV.Text = "";
        }
    }
}
