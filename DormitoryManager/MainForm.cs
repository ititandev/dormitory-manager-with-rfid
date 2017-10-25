using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

using System.Windows.Forms;

namespace DormitoryManager
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyForm dangKyForm = new DangKyForm();
            dangKyForm.MdiParent = this;
            dangKyForm.Show();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVienForm = new SinhVienForm();
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
        }
    }
}
