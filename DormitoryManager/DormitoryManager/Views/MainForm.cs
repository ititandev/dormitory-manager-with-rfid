using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DormitoryManager
{
    public partial class MainForm : RibbonForm
    {
        public static SinhVienForm sinhVienForm = new SinhVienForm();
        public static HopDongForm hopDongForm = new HopDongForm();
        public static PhongForm phongForm = new PhongForm();
        public static DienNuocForm dienNuocForm = new DienNuocForm();
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ribbon1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (ribbon.ActiveTab.Equals(sinhVienTab))
            {
                hopDongForm.Hide();
                phongForm.Hide();

                sinhVienForm.MdiParent = this;
                sinhVienForm.Show();
            }
            else if (ribbon.ActiveTab.Equals(hopDongTab))
            {
                sinhVienForm.Hide();
                phongForm.Hide();

                hopDongForm.MdiParent = this;
                hopDongForm.Show();
            }
            else if (ribbon.ActiveTab.Equals(phongTab))
            {
                hopDongForm.Hide();
                sinhVienForm.Hide();

                phongForm.MdiParent = this;
                phongForm.Show();
            }
        }
    }
}