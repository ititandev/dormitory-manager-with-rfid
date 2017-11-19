using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BUS;
namespace GUI
{
    class ReportViewer
    {
        public static RPT.rptDienNuoc DienNuocReport(int MaDot)
        {
            SqlDataReader dr = HoaDonDienNuocBUS.getHoaDonDS();
            DataSet.ReportDataSet reportDS = new DataSet.ReportDataSet();
            reportDS.Tables["DienNuocDS"].Load(dr);
            RPT.rptDienNuoc rptDienNuoc = new RPT.rptDienNuoc();
            rptDienNuoc.SetDataSource(reportDS);
            rptDienNuoc.SetParameterValue("MaSo", MaDot);
            return rptDienNuoc;
        }
        public static RPT.rptHopDong HopDongReport(int MaSo)
        {
            SqlDataReader dr = HopDongBUS.getHopDongDS();
            DataSet.ReportDataSet reportDS = new DataSet.ReportDataSet();
            reportDS.Tables["HopDongDS"].Load(dr);
            RPT.rptHopDong rptHopDong = new RPT.rptHopDong();
            rptHopDong.SetDataSource(reportDS);
            rptHopDong.SetParameterValue("MaSo", MaSo);
            return rptHopDong;
        }
    }
}
