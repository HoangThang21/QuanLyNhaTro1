using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOQuanLy
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertQuanLy( String taikhoan, String matkhau, String chucvu)
        {
            String query = "insert into QuanLy values('" + taikhoan + "','" + matkhau + "','" + chucvu + "')";
            modify.Command(query);
        }
        public void DeleteQuanLy(String taikhoan)
        {
            String query = "Delete From QuanLy where taikhoan='" + taikhoan + "'";
            modify.Command(query);
        }
        public void UpdateQuanLy( String taikhoan, String matkhau, String chucvu)
        {
            String query = "Update QuanLy set matkhau='" + matkhau + "',chucvu='" + chucvu + "' where taikhoan='" + taikhoan + "'";
            modify.Command(query);
        }
        
    }
}
