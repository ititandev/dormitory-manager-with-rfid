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

namespace GUI
{
    public partial class Phong : Form
    {
        private PhongBUS phongBUS = new PhongBUS();
        public Phong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phong_Load(object sender, EventArgs e)
        {
            PhongBUS.ViewAll(dgvPhong);
        }


    }
}
