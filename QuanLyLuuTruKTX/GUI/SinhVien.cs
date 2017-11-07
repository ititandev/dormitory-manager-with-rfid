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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count > 0)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic[HoTen] = row[0].Cells[HoTen].Value.ToString() ?? "";
                dic[CMND] = row[0].Cells[CMND].Value.ToString();
                dic[DienUuTien] = row[0].Cells[DienUuTien].Value.ToString();
                dic[Email] = row[0].Cells[Email].Value.ToString();
                dic[GioiTinh] = row[0].Cells[GioiTinh].Value.ToString();
                dic[Khoa] = row[0].Cells[Khoa].Value.ToString();
                dic[Lop] = row[0].Cells[Lop].Value.ToString();
                dic[MaSo] = row[0].Cells[MaSo].Value.ToString();
                dic[NgaySinh] = row[0].Cells[NgaySinh].Value.ToString();
                dic[Que] = row[0].Cells[Que].Value.ToString();
                dic[DienThoai] = row[0].Cells[DienThoai].Value.ToString();
                dic[Anh] = row[0].Cells[Anh].Value.ToString();
                dic[TongDiem] = row[0].Cells[TongDiem].Value.ToString();
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
