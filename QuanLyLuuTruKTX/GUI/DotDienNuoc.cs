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
using DAO;
using DTO;
using static BUS.DotDienNuocBUS;
namespace GUI
{
    public partial class DotDienNuoc : Form
    {
        public DotDienNuoc()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DotDienNuoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DotDienNuocBUS.viewDotDienNuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Add = true;
        }
        bool Add = true;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                DotDienNuocDTO dn = new DotDienNuocDTO();
                dn.MaDot = int.Parse(txtMaDot.Text);
                dn.NgayBatDau = dateStart.Value;
                dn.NgayKetThuc = dateEnd.Value;
                dn.DonGiaDien = int.Parse(txtDonGiaDien.Text);
                dn.DonGiaNuoc = int.Parse(txtDonGiaNuoc.Text);
                DotDienNuocBUS.ThemDotDienNuoc(dn);
                dataGridView1.DataSource = DotDienNuocBUS.viewDotDienNuoc();
                dataGridView1.Refresh();
                dataGridView1.Update();
                panel1.Visible = false;
            }
            else
            {
                DotDienNuocDTO dn = new DotDienNuocDTO();
                dn.MaDot = int.Parse(txtMaDot.Text);
                dn.NgayBatDau = dateStart.Value;
                dn.NgayKetThuc = dateEnd.Value;
                CapNhatDotDienNuoc(dn);
                dataGridView1.DataSource = DotDienNuocBUS.viewDotDienNuoc();
                dataGridView1.Refresh();
                dataGridView1.Update();
                panel1.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Add = false;
            panel1.Visible = true;
            if(dataGridView1.SelectedRows.Count>0)
            {
                
                DotDienNuocDTO dn = new DotDienNuocDTO();
                txtMaDot.Text = (dataGridView1.Rows[0].Cells[MaDot].Value.ToString());
                dateStart.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[NgayBatDau].Value.ToString());
                dateEnd.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[NgayKetThuc].Value.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int madot = int.Parse(dataGridView1.Rows[0].Cells[MaDot].ToString());
                DotDienNuocBUS.XoaDotDienNuoc(madot);
            }
        }
    }
}
