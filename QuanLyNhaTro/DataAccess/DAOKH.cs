using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOKH
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertKH(String id,String HoTen,String CMND,String SDT,String NgaySinh,String DiaChi,String GioiTinh)
        {
            String query = "insert into KhachHang values('"+id+"',N'"+HoTen+"','"+CMND+"','"+SDT+"','"+NgaySinh+"',N'"+DiaChi+"',N'"+GioiTinh+"')";
            modify.Command(query);
        }
        public void DeleteKH(String id)
        {
            String query = "Delete From KhachHang where IDKH='"+id+"'";
            modify.Command(query);
        }
        public void UpdateKH(String PositionID, String HoTen, String CMND, String SDT, String NgaySinh, String DiaChi, String GioiTinh)
        {
            String query = "Update KhachHang set HoTen=N'"+HoTen+"',CMND='"+CMND+"',SDT='"+SDT+"',NgaySinh='"+NgaySinh+"',DiaChi=N'"+DiaChi+"',GioiTinh=N'"+GioiTinh+"' where IDKH='"+ PositionID + "'";
            modify.Command(query);
        }
        public string getIDKH(String HoTen)
        {
            String query = "select kh.IDKH from KhachHang kh where HoTen=N'" + HoTen + "'";
            return modify.GetID(query);
        }
    }
}
