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
        public SinhVienForm sinhVienForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ribbon1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (ribbon1.ActiveTab.Equals(ribbonTab1))
            {
                sinhVienForm = new SinhVienForm();
                sinhVienForm.MdiParent = this;
                sinhVienForm.Show();
            }
            else if (ribbon1.ActiveTab.Equals(ribbonTab2))
            {
                MDIChild2 md = new MDIChild2();
                md.MdiParent = this;
                md.Show();
            }
        }
    }
}