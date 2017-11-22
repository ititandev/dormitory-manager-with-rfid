using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    /// <summary>
    /// Class form in hợp đồng
    /// </summary>
    public partial class Report : Form
    {
        /// <summary>
        /// Khởi tạo form in hợp đồng
        /// </summary>
        /// <param name="MaSo"></param>
        public Report(string MaSo)
        {
            InitializeComponent();

            SqlDataReader dr = HopDongBUS.GetHopDong();
            DataSet.ReportDataSet reportDS = new DataSet.ReportDataSet();
            reportDS.Tables["HopDongDS"].Load(dr);
            RPT.rptHopDong rptHopDong = new RPT.rptHopDong();
            rptHopDong.SetDataSource(reportDS);
            rptHopDong.SetParameterValue("MaSo", MaSo);
            crystalReportViewer1.ReportSource = rptHopDong;
        }
    }
}
