using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAODichVu
    {
        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertDichVu(String IDDV, String LoaiDV, int Cu, int Moi)
        {
            String query = "insert into DichVu values('" + IDDV + "',N'" + LoaiDV + "','" + Cu + "','" + Moi + "')";
            modify.Command(query);
        }
        public void DeleteDichVu(String id)
        {
            String query = "Delete From DichVu where IDDichVu='" + id + "'";
            modify.Command(query);
        }
        public void UpdateDichVu(String PositionID, String LoaiDV, int Cu, int Moi)
        {
            String query = "Update DichVu set IDLoaiDV=N'" + LoaiDV + "',Cu='" + Cu + "',Moi='" + Moi + "' where IDDichVu='" + PositionID + "'";
            modify.Command(query);
        }
    }
}
