using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOThuePhong
    {

        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertThuePhong(String idThuePhong,String TienDatCoc,String NgayThue,String NgayTra,String IDKH,String IDPhong)
        {
            String query = "insert into ThuePhong values('" + idThuePhong + "','" + TienDatCoc + "','" + NgayThue + "','" + NgayTra + "','" + IDKH + "','" + IDPhong + "')";
            modify.Command(query);
        }
        public void DeleteThuePhong(String id)
        {
            String query = "Delete From ThuePhong where IDThuePhong='" + id + "'";
            modify.Command(query);
        }
        public void UpdateThuePhong(String PositionID, String TienDatCoc, String NgayThue, String NgayTra, String IDKH, String IDPhong)
        {
            String query = "Update ThuePhong set TienDatCoc='" + TienDatCoc + "',NgayThue='" + NgayThue + "',NgayTraPhong='" + NgayTra + "',IDKH='" + IDKH + "',IDPhong=N'" + IDPhong + "' where IDThuePhong='" + PositionID + "'";
            modify.Command(query);
        }
        public String GetIDThuePhong(String idkh)
        {
            String query = "select tp.IDThuePhong from ThuePhong tp,KhachHang kh where tp.IDKH=kh.IDKH and kh.IDKH='" + idkh + "'";
            return modify.GetID(query);
        }
    }
}
