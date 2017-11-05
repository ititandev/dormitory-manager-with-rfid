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
using DAO;
using BUS;
using DTO;

namespace GUI
{
    public partial class SinhVienView : Form
    {
        public SinhVienView()
        {
            InitializeComponent();
            cbFilter.Items.Add(SinhVienBUS.HoTen);
            cbFilter.Items.Add(SinhVienBUS.MaSo);
            cbFilter.Items.Add(SinhVienBUS.CMND);
            cbFilter.Items.Add(SinhVienBUS.DienThoai);
            cbFilter.Items.Add(SinhVienBUS.Email);
            cbFilter.SelectedItem = SinhVienBUS.HoTen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void SinhVienView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
            dataGridView1.Show();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count > 0)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic[SinhVienBUS.HoTen] = row[0].Cells[SinhVienBUS.HoTen].Value.ToString()??"";
                dic[SinhVienBUS.CMND] = row[0].Cells[SinhVienBUS.CMND].Value.ToString();
                dic[SinhVienBUS.DienUuTien] = row[0].Cells[SinhVienBUS.DienUuTien].Value.ToString();
                dic[SinhVienBUS.Email] = row[0].Cells[SinhVienBUS.Email].Value.ToString();
                dic[SinhVienBUS.GioiTinh] = row[0].Cells[SinhVienBUS.GioiTinh].Value.ToString();
                dic[SinhVienBUS.Khoa] = row[0].Cells[SinhVienBUS.Khoa].Value.ToString();
                dic[SinhVienBUS.Lop] = row[0].Cells[SinhVienBUS.Lop].Value.ToString();
                dic[SinhVienBUS.MaSo] = row[0].Cells[SinhVienBUS.MaSo].Value.ToString();
                dic[SinhVienBUS.NgaySinh] = row[0].Cells[SinhVienBUS.NgaySinh].Value.ToString();
                dic[SinhVienBUS.Que] = row[0].Cells[SinhVienBUS.Que].Value.ToString();
                dic[SinhVienBUS.DienThoai] = row[0].Cells[SinhVienBUS.DienThoai].Value.ToString();
                dic[SinhVienBUS.Anh] = row[0].Cells[SinhVienBUS.Anh].Value.ToString();
                dic[SinhVienBUS.TongDiem] = row[0].Cells[SinhVienBUS.TongDiem].Value.ToString();
                UpdateSinhVien form = new UpdateSinhVien(dic);
                form.ShowDialog();
                dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
                dataGridView1.Refresh();
                dataGridView1.Update();


            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            string value = txtValue.Text;
            string filter = cbFilter.Text;
            DataTable dt = (dataGridView1.DataSource as DataTable);
            if (dt != null)
            {
                dt.DefaultView.RowFilter = "[{filter}] LIKE %{value}%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count > 0)
            {
                string key = row[0].Cells[SinhVienBUS.MaSo].Value.ToString();
                SinhVienBUS.deleteSinhVien(key);
                dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
                dataGridView1.Refresh();
                dataGridView1.Update();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new UpdateSinhVien();
            form.ShowDialog();
            dataGridView1.DataSource = SinhVienBUS.viewAllStudent();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}
