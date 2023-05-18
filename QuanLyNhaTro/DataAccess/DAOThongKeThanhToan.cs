using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOThongKeThanhToan
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertTKKH(String id, String IDKH, String HoTen, int TongTien,String NgayThu, String TrangThai)
        {
            String query = "insert into ThongKe values('" + id + "','"+ IDKH + "',N'" + HoTen + "','" + TongTien + "','"+ NgayThu + "',N'" + TrangThai + "')";
            modify.Command(query);
        }
        public void DeleteTKKH(String id)
        {
            String query = "Delete From ThongKe where IDThongKeKH='" + id + "'";
            modify.Command(query);
        }
        public void UpdateTKKH(String PositionID, String IDKH, String HoTen, int TongTien,String NgayThu, String TrangThai)
        {
            String query = "Update ThongKe set IDKhachHang='"+ IDKH + "',  HoTenKH=N'" + HoTen + "',TongTien='" + TongTien + "',NgayThu='" + NgayThu + "',TrangThai=N'" + TrangThai + "' where IDKH='" + PositionID + "'";

            modify.Command(query);
        }
        public int selectyear()
        {
            return modify.GetInt32("select YEar(NgayThu) from ThongKe");
        }
        public int selectmonth()
        {
            return modify.GetInt32("select month(NgayThu) from ThongKe");
        }
        public void UpdateTK_KH(String IDKH, String HoTen)
        {
            if(modify.ThongKes("select * from ThongKe where IDKhachHang='"+IDKH+"'").Count>0)
            {
     
                String query = "Update ThongKe set   HoTenKH=N'" + HoTen + "' where IDKhachHang='" + IDKH + "'";
                modify.Command(query);
            }
           
        }
    }
}
