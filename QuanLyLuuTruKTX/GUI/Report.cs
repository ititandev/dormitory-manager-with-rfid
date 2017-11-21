using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class Report : Form
    {
        public Report(string MaSo)
        {
            InitializeComponent();

            SqlDataReader dr = HopDongBUS.getHopDongDS();
            DataSet.ReportDataSet reportDS = new DataSet.ReportDataSet();
            reportDS.Tables["HopDongDS"].Load(dr);
            RPT.rptHopDong rptHopDong = new RPT.rptHopDong();
            rptHopDong.SetDataSource(reportDS);
            rptHopDong.SetParameterValue("MaSo", MaSo);
            crystalReportViewer1.ReportSource = rptHopDong;
        }

        private void Report_Load(object sender, EventArgs e)
        {
           /* 
            int MaSo = 2;
            SqlDataReader dr = HoaDonDienNuocBUS.getHoaDonDS();
            reportDataSet1.Tables["DienNuocDS"].Load(dr);
            RPT.rptDienNuoc rptDienNuoc = new RPT.rptDienNuoc();
            rptDienNuoc.SetDataSource(reportDataSet1);
            rptDienNuoc.SetParameterValue("MaSo", MaSo);

            int MaSo = 9;
            SqlDataReader dr = HopDongBUS.getHopDongDS();
            reportDataSet1.Tables["HopDongDS"].Load(dr);
            RPT.rptHopDong rptHopDong = new RPT.rptHopDong();
            rptHopDong.SetDataSource(reportDataSet1);
            rptHopDong.SetParameterValue("MaSo", MaSo);
            crystalReportViewer1.ReportSource = rptHopDong;
            */
        }
    }
}
