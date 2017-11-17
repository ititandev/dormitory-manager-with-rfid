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
    public partial class Phong : KTXForm
    {
        enum CheDo
        {
            XEM, SUA, THEM
        }
        private static CheDo CheDoHienTai { get; set; }
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.phongForm = null;
        }

        private void xemMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.XEM);
        }

        private void suaMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.SUA);
        }

        private void themMode_Click(object sender, EventArgs e)
        {
            SetCheDo(CheDo.THEM);
        }
        private void SetCheDo(CheDo cheDo)
        {
            CheDoHienTai = cheDo;
            if (CheDoHienTai == CheDo.XEM)
            {

            }
            else if (CheDoHienTai == CheDo.THEM)
            {

            }
            else
            {

            }
        }
    }
}
