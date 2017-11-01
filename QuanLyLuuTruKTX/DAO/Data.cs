using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class Data
    {
        private static string connectString = DAO.Properties.Settings.Default.connectString;
        /// <summary>
        /// Thực thi query và lấy dữ liệu trả về dạng DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
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
                SqlConnection con = new SqlConnection(connectString);
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
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(String query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectString);
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
