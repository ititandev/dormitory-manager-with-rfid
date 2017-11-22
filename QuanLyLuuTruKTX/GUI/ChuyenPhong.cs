using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    /// <summary>
    /// Class form chuyển phòng cho sinh viên
    /// </summary>
    public partial class ChuyenPhong : Form
    {
        struct DataMove
        {
            public string MSSV;
            public string maPhong;
        }
        List<DataMove> list = new List<DataMove>();
        DataTable dtSource;
        DataTable dtDes;
        DataTable dtPhong;
        List<string> lstSource = new List<string>();
        List<string> lstDes = new List<string>();
        public ChuyenPhong()
        {
            InitializeComponent();
            dgvDes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void refresh()
        {
            dtPhong = PhongBUS.LoadPhong();
            for (int i = 0; i < dtPhong.Rows.Count; ++i)
            {
                string id = (dtPhong.Rows[i]["IDPhong"].ToString());
                lstSource.Add(id);
                lstDes.Add(id);
            }
            cboDes.DataSource = lstSource;
            cboSource.DataSource = lstDes;
            dgvDes.DataSource = dtDes;
            dgvSource.DataSource = dtSource;
            btnQua.Enabled = true;
            btnLai.Enabled = true;
            if (list.Count > 0)
            {
                list.Clear();
            }
        }
        void LoadDuLieu(string maPhong, out DataTable dt)
        {
            dt = PhongBUS.LoadSinhVien(maPhong);

        }

        private void Chuyen_Load(object sender, EventArgs e)
        {
            refresh();
        }



        //Move from Phong1 to Phong2
        private void btnQua_Click(object sender, EventArgs e)
        {
            if (dgvSource.SelectedRows.Count > 0)
            {
                int index = dgvSource.CurrentCell.RowIndex;
                dtDes.ImportRow(dtSource.Rows[index]);
                DataMove dm;
                dm.MSSV = dtSource.Rows[index]["MSSV"].ToString();
                dm.maPhong = cboDes.Text;
                dtSource.Rows[index].Delete();
                dtSource.AcceptChanges();
                dtDes.AcceptChanges();
                list.Add(dm);
                btnQua.Enabled = false;
            }

        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            if (dgvDes.SelectedRows.Count > 0)
            {
                int index = dgvDes.CurrentCell.RowIndex;
                dtSource.ImportRow(dtDes.Rows[index]);
                DataMove dm;
                dm.MSSV = dtDes.Rows[index]["MSSV"].ToString();
                dm.maPhong = cboSource.Text;
                dtDes.Rows[index].Delete();
                dtDes.AcceptChanges();
                dtSource.AcceptChanges();

                list.Add(dm);
                btnLai.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            if (list.Count == 1)
            {
                success = SinhVienBUS.ChuyenPhong(list[0].MSSV, list[0].maPhong, true);
            }
            else
            {
                SinhVienBUS.ChuyenPhong(list[0].MSSV, list[0].maPhong, false);
                SinhVienBUS.ChuyenPhong(list[1].MSSV, list[1].maPhong, false);
                success = 1;
            }
            if (success == 1)
                MessageBox.Show("Chuyển phòng thành công");
            else MessageBox.Show("Chuyển phòng thất bại, có thể do phòng chuyển qua đã đầy");
        }

        private void cboSource_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDuLieu(cboSource.Text, out dtSource);
            dgvSource.DataSource = dtSource;
        }

        private void cboDes_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDuLieu(cboDes.Text, out dtDes);
            dgvDes.DataSource = dtDes;
        }

        private void cbEmptyRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmptyRoom.Checked)
            {
                DataView dv = new DataView(dtPhong, "[SoLuongHienTai]<[SoLuongToiDa]", "", DataViewRowState.CurrentRows);
                lstDes = new List<string>();
                for (int i = 0; i < dv.Count; ++i)
                {
                    string id = (dv[i]["IDPhong"].ToString());
                    lstDes.Add(id);
                }
                cboDes.DataSource = lstDes;
                cboDes.Refresh();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();

        }
    }
}
