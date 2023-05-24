using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using QuanLyNhaTro.DataAccess;
using QuanLyNhaTro.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLQuanLy
    {
        DataAccess.DAO dao =new DataAccess.DAO();
        public bool Kttext(String tenTK, String matKhau)
        {
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            { 
                if ( dao.selectTk ( tenTK,  matKhau) > 0)
                {
                   
                   return true;

                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            return false;
        }
      
        public bool checkAccount(string ac) // check mật khẩu và tài khoản 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        DataAccess.DAOQuanLy DAOQuanLy = new DataAccess.DAOQuanLy();    
        public bool DangKyTk(String TenTk, String passold, String passnew, String xnpass)
        {
            try
            {
                DAOQuanLy.UpdateQuanLy_DoiMatKhau(TenTk, passnew);
                return true;
                

            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool KiemTraThemTk(String tk, String pass,String chucvu) {
            DAOQuanLy.InsertQuanLy(tk, pass, chucvu);
            return true;
        }
        DTOTaiKhoan DTOTaiKhoan =new DTOTaiKhoan();
        public void KiemTraCapNhatTk(String tk, String pass, String chucvu)
        {

            if (tk.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else {
                DTOTaiKhoan.TenTaiKhoan = tk;
                DTOTaiKhoan.MatKhau = pass;
                DTOTaiKhoan.ChucVu= chucvu;
                if(DAOQuanLy.proc_updatequanly(DTOTaiKhoan)== "success")
                    MessageBox.Show("Cập nhật Thành công tài khoản");
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại");
                }
                

            }

        }
    }
}
