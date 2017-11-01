using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HopDongDAO
    {
        public static DataTable ViewAll()
        {
            return Data.ExecuteQuery("SELECT * FROM HopDong");
        }
    }
}
