using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QuanLyNhaTro.DTO;

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
        public string proc_updatequanly(DTOTaiKhoan dTOTaiKhoan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "update_quanly";
              
                cmd.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = dTOTaiKhoan.TenTaiKhoan;
                
                cmd.Parameters.Add("@makhau", SqlDbType.NVarChar).Value = dTOTaiKhoan.MatKhau;
               
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = dTOTaiKhoan.ChucVu;
           
                modify.Command_proc(cmd);
              
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String selectmatkhau_tk(string taikhoan, string matkhau)
        {
            return modify.GetID("select matkhau from QuanLy where taikhoan='" + taikhoan + "' and matkhau='" + matkhau + "' ");
        }
        public void UpdateQuanLy_DoiMatKhau(String taikhoan, String matkhau)
        {
            String query = "Update QuanLy set matkhau='" + matkhau + "' where taikhoan='" + taikhoan + "'";
            modify.Command(query);
        }
    }
}
