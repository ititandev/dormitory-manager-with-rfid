using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        public static DataTable ViewAll()
        {
            return Data.ExecuteQuery("SELECT * FROM Phong");
        }
    }
}
