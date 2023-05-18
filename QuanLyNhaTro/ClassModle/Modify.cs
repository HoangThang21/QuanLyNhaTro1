using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections.ObjectModel;
using QuanLyNhaTro.DTO;
using System.Windows.Forms;

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
        public void Command_proc(SqlCommand cmd) 
        {
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                cmd.CommandType = CommandType.StoredProcedure ;
                cmd.Connection = sqlConnection;
                cmd.ExecuteNonQuery();
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
        public List<DTOTaiKhoan> TaiKhoans(string query)
        {
            List<DTOTaiKhoan> taiKhoans = new List<DTOTaiKhoan>();

            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new DTOTaiKhoan(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public List<DTOThongKe> ThongKes(string query)
        {
            List<DTOThongKe> thongkes = new List<DTOThongKe>();
           
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
              
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                
                while (dataReader.Read())
                {
                    
                    thongkes.Add(new DTOThongKe(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetDateTime(4), dataReader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return thongkes;
        }

    }
}
