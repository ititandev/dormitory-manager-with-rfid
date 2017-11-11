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
using static BUS.HoaDonDienNuocBUS;
namespace GUI
{
    public partial class DienNuoc : Form
    {
        public DienNuoc()
        {
            InitializeComponent();
            cbFilter.Items.Add(MaDot);
            cbFilter.SelectedItem = (MaDot);
        }

        private void DienNuoc_Load(object sender, EventArgs e)
        {
            var source = HoaDonDienNuocBUS.viewAllHoaDon();
            source = HoaDonDienNuocBUS.tinhTongTien(source);
            dataGridView1.DataSource = source;
            dataGridView1.Show();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            // try
            {
                string value = txtValue.Text;
                string filter = cbFilter.Text;
                if (value != "")
                {
                    DataTable dt = (dataGridView1.DataSource as DataTable);
                    if (dt.Rows.Count>0)
                    {
                        if (filter == MaDot)
                        {
                            dt.DefaultView.RowFilter = $"[{filter}]={value}";
                        }
                        else
                            dt.DefaultView.RowFilter = $"[{filter}] LIKE '%{value}%'";
                    }

                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                }
            }
            //catch
            {

            }
        }

        private void DienNuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.dienNuocForm = null;
        }
    }
}
