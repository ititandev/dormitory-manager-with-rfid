using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DormitoryManager
{
    static class Global
    {
        public static string stringConnect = @"Data Source=ITITAN-LAP\SQLEXPRESS01;Initial Catalog=DormitoryDB;Integrated Security=True";

        static public string ToTiengVietKhongDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        static public void FillDataToGrid(String query, DataGridView grid)
        {
            SqlConnection sqlConnection = new SqlConnection(stringConnect);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCommand);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            grid.DataSource = dtRecord;

        }

        static public SqlDataReader GetQueryData(String query)
        {
            SqlConnection sqlConnection = new SqlConnection(stringConnect);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return reader;
        }
    }
}
