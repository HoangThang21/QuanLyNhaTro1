using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.ClassModle
{
   
    internal class Connec
    {
        private static string stringConnection = @"Data Source=THANG;Initial Catalog=QLNhaTro;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        private static string stringConnectionmaster = @"Data Source=THANG;Initial Catalog=master;Integrated Security=True";
        public static SqlConnection GetSqlConnectionmaster()
        {
            SqlConnection.ClearAllPools();
            return new SqlConnection(stringConnectionmaster);
        }

    }
}
