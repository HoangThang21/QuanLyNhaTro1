using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLThanhToan
    {
        DataAccess.DAOThongKeThanhToan DAOThongKeThanhToan=new DataAccess.DAOThongKeThanhToan();
        DataAccess.DAO dao = new DataAccess.DAO();

        DateTime d1 = DateTime.Now;
        DateTime ThangNam = DateTime.Now;

        public bool KTtext(String maKH,String Hoten,String tienPhong, String tienDienNuoc)
        {
            

            String idThongKe = "TK";
            int Tong = int.Parse(tienPhong) + int.Parse(tienDienNuoc);
            d1.ToString("yyyy / MM / dd");
            String sqlIDKH_ThongKe = dao.selectHoTen_Tk(maKH);
            String NgayThu = d1.ToShortDateString();
            String thangnam = ThangNam.Year + "/" + ThangNam.Month;//Lấy tháng năm hiện tại của máy tính
            String sqlThangNam = DAOThongKeThanhToan.selectyear() + "/" + DAOThongKeThanhToan.selectmonth();
            try
            {
                if (thangnam == sqlThangNam && maKH == sqlIDKH_ThongKe)
                {
                    MessageBox.Show(Hoten + " .Tháng này đã thu");
                }
                else
                {
                    while (true)
                    {
                        try
                        {
                            Random r = new Random();
                            int ID = r.Next(100, 1000);
                            idThongKe += ID;
                            DAOThongKeThanhToan.InsertTKKH(idThongKe, maKH, Hoten, Tong, NgayThu, "Đã thu");
                            break;
                        }
                        catch (Exception ex)
                        {
                            idThongKe = "TK";
                        }
                    }
                    return true;
                    

                }
               
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
