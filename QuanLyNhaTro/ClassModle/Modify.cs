using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace QuanLyNhaTro.ClassModle
{
    internal class Modify
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public void Command(string squery) // thêm xóa sửa
        {
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                sqlCommand.ExecuteNonQuery(); 
                sqlConnection.Close();
            }
        }
        public DataTable GetDataTable(string squery) 
        {
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                DataTable dt = new DataTable();
                dt.Load(sqlCommand.ExecuteReader());
                return dt;
            }
        }
        public string GetID(string squery)
        {
            string id = "";
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    id = dataReader.GetString(0);
                }
                sqlConnection.Close();
            }
            return id;

        }
        public int GetInt32(string squery)
        {
            int id = 0;
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }
                sqlConnection.Close();
            }
            return id;

        }
    }
}
