using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAODienNuoc
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertDienNuoc(String IDDN,String IDDV,int DonGia,String IDKH)
        {
            String query = "insert into DienNuoc values('" + IDDN + "','" + IDDV + "','" + DonGia + "','" + IDKH + "')";
            modify.Command(query);
        }
        public void DeleteDienNuoc(String id)
        {
            String query = "Delete From DienNuoc where IDDienNuoc='" + id + "'";
            modify.Command(query);
        }
        public void UpdateDienNuoc(String PositionID,String IDDV, int DonGia, String IDKH)
        {
            String query = "Update DienNuoc set IDDienNuoc='" + IDDV + "',IDDV='" + IDDV + "',DonGia='" + IDKH + "' where IDDienNuoc='" + PositionID + "'";
            modify.Command(query);
        }
        public string getID_KH(String IDKH) 
        {
            return modify.GetID("select IDDienNuoc from DienNuoc where IDKH='" + IDKH + "'");
        }
        public int getcountIDDN_KH(String IDKH)
        {
            return modify.GetInt32("select count(IDDienNuoc) from DienNuoc where IDKH='" + IDKH + "'");
        }

    }
}
