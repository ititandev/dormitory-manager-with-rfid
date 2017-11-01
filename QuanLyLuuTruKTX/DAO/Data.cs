using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public static class Data
    {
        /// <summary>
        /// Thực thi query và lấy dữ liệu trả về dạng DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string query, object[] param = null)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectString);
                SqlCommand sqlCommand = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listParam = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listParam.Add(item);
                    }
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(listParam[i], param[i]);
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        /// <summary>
        /// Thực thi query mà không lấy dữ liệu trả về
        /// </summary>
        /// <param name="query"></param>
        public static void ExecuteNonQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        /// <summary>
        /// Thực thi query và lấy dữ liệu trả về dạng SqlDataReader
        /// Sử dụng phương thức Reader() khi sử dụng
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(String query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        /// <summary>
        /// Get, Set ConnectString
        /// </summary>
        public static string ConnectString
        {
            get
            {
                return DAO.Properties.Settings.Default.connectString;
            }
            set
            {
                DAO.Properties.Settings.Default.connectString = value;
                DAO.Properties.Settings.Default.Save();
            }
        }
    }

}
