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
        public String LayPass(String tenTK)
        {
            String pass = "";
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                return dao.selectPass(tenTK);
            }
            return pass;
        }
        public bool checkAccount(string ac) // check mật khẩu và tài khoản 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        DataAccess.DAOQuanLy DAOQuanLy = new DataAccess.DAOQuanLy();    
        public void DangKyTk(String TenTk, String pass, String xnpass, String chucvu)
        {
            if (!checkAccount(TenTk))
            { MessageBox.Show("Tên Tài Khoản Không Hợp Lệ! Nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else
            {
                if (pass != xnpass) { MessageBox.Show("Vui Lòng Xác Nhận Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
                else
                {
                    try
                    {
                        DAOQuanLy.InsertQuanLy(TenTk, pass,chucvu);
                        MessageBox.Show("Đăng ký thành công.");

                    }
                    catch
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tại, Vui Lòng Nhập Tên Tài Khoản Khác", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
