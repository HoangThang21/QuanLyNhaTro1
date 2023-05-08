using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOThongKeThanhToan
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertTKKH(String id, String HoTen, int TongTien,String NgayThu, String TrangThai)
        {
            String query = "insert into ThongKe values('" + id + "',N'" + HoTen + "','" + TongTien + "','"+ NgayThu + "',N'" + TrangThai + "')";
            modify.Command(query);
        }
        public void DeleteTKKH(String id)
        {
            String query = "Delete From ThongKe where IDThongKeKH='" + id + "'";
            modify.Command(query);
        }
        public void UpdateTKKH(String PositionID, String HoTen, int TongTien,String NgayThu, String TrangThai)
        {
            String query = "Update ThongKe set HoTenKH=N'" + HoTen + "',TongTien='" + TongTien + "',NgayThu='" + NgayThu + "',TrangThai=N'" + TrangThai + "' where IDKH='" + PositionID + "'";

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

    }
}
