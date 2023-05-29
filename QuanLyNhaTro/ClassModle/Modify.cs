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
using System.Security.Cryptography;
using System.Collections;

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
        public List<DTOThongKe> ThongKes_report(string query)
        {
            List<DTOThongKe> thongKes = new List<DTOThongKe>();

            using (SqlConnection connection = Connec.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTOThongKe thongKe = new DTOThongKe();
                    thongKe.NgayThu = reader.GetDateTime(0);
                    thongKe.TongTien = reader.GetInt32(1);
                    thongKe.TienThu = reader.GetInt32(1)-reader.GetInt32(2);

                    thongKes.Add(thongKe);
                }

                reader.Close();
            }

            return thongKes;
        }
        public List<DTOThongKe> ThongKes_report_thangthu(string query)
        {
            List<DTOThongKe> thongKes = new List<DTOThongKe>();

            using (SqlConnection connection = Connec.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTOThongKe thongKe = new DTOThongKe();
                    thongKe.thangthu = reader.GetInt32(0);
                    thongKe.TongTien = reader.GetInt32(1);
                    thongKe.TienThu = reader.GetInt32(1) - reader.GetInt32(2);

                    thongKes.Add(thongKe);
                }

                reader.Close();
            }

            return thongKes;
        }
        public string GetMd5Hash( string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public List<DTOPhong> listphong(String query)
        {
            List<DTOPhong> dTOPhongs = new List<DTOPhong>();
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    dTOPhongs.Add(new DTOPhong(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4)));
                }
                sqlConnection.Close();
            }
            return dTOPhongs;
        }
        public List<DTOKhachHang> listkh(String query)
        {
            List<DTOKhachHang> dTOkhs = new List<DTOKhachHang>();
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    dTOkhs.Add(new DTOKhachHang(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetDateTime(4), dataReader.GetString(5), dataReader.GetString(6)));
                }
                sqlConnection.Close();
            }
            return dTOkhs;
        }
        public List<DTOThuePhong> listthuephong(String query)
        {
            List<DTOThuePhong> dTOtps = new List<DTOThuePhong>();
            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    dTOtps.Add(new DTOThuePhong(dataReader.GetString(0), dataReader.GetInt32(1), dataReader.GetDateTime(2), dataReader.GetDateTime(3), dataReader.GetString(4), dataReader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return dTOtps;
        }

    }
}
