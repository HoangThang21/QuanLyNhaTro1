using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAOPhong
    {

        ClassModle.Modify modify = new ClassModle.Modify();
        public void InsertPhong(String id,String TenPhong,String LoaiPhong,String TrangThai,String DonGia)
        {
            String query = "insert into Phong values('" + id + "',N'" + TenPhong + "',N'" + LoaiPhong + "',N'" + TrangThai + "','" + DonGia + "')";
            modify.Command(query);
        }
        public void DeletePhong(String idPhong)
        {
            String query = "Delete From Phong where IDPhong='" + idPhong + "'";
            modify.Command(query);
        }
        public void UpdatePhong(String PositionID, String TenPhong, String LoaiPhong, String TrangThai, String DonGia)
        {
            String query = "Update Phong set TenPhong=N'" + TenPhong + "',LoaiPhong=N'" +LoaiPhong + "',TrangThai=N'" + TrangThai + "',DonGia='" + DonGia + "' where IDPhong='" + PositionID + "'";
            modify.Command(query);
        }
        public void UpdatePhongTrangThai(String PositionID,String TrangThai)
        {
            String query = "Update Phong set TrangThai=N'"+ TrangThai + "' where IDPhong='" + PositionID + "'";
            modify.Command(query);
        }
        public string returnIDPhong(String TenPhong)
        {
            string query = "select DISTINCT P.IDPhong from Phong P where P.TenPhong=N'" + TenPhong + "'";
            return modify.GetID(query);
        }
        public DataTable select_TenPhong()
        {
            return modify.GetDataTable("select TenPhong from Phong where TrangThai=N'Trống'");
        }
        public string select_tinhtrangphong(String tenphong)
        {
            return modify.GetID("select TrangThai from Phong where TenPhong =N'" + tenphong + "'");
        }
        public void UpdateTrangThai(String tenPhong, String TrangThai)
        {
            String query = "Update Phong set TrangThai=N'" + TrangThai + "' where TenPhong=N'" + tenPhong + "'";
            modify.Command(query);
        }
       
    }
}
