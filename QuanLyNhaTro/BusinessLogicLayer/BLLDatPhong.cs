using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLDatPhong
    {

        DataAccess.DAOKH daokh = new DataAccess.DAOKH();
        DataAccess.DAOPhong DAOPhong = new DataAccess.DAOPhong();
        DataAccess.DAOThuePhong DAOThuePhong = new DataAccess.DAOThuePhong();
        public bool KTText(String TienDatCoc,String NgayThue,String NgayTra,String Ten,String CMND,String SDT,String NgaySinh,String DiaChi,String GioiTinh,String TenPhong,String LoaiPhong)
        {
            String idKH = "KH";
            String idThuePhong = "TP";
            String idPhong = DAOPhong.returnIDPhong(TenPhong);
            if (TenPhong != "")
            {
                /*MessageBox.Show("" + TienDatCoc + " " + NgayThue + " " + NgayTra + " " + Ten + " " + CMND + " " + SDT + " " + NgaySinh + " " + DiaChi + " " + GioiTinh + " " + TenPhong + " " + LoaiPhong);*/
                while (true)
                {
                    try
                    {
                        Random r = new Random();
                        int ID = r.Next(100, 1000);
                        idKH += ID;
                        daokh.InsertKH(idKH, Ten, CMND, SDT, NgaySinh, DiaChi, GioiTinh);

                        break;
                    }
                    catch (Exception ex)
                    {
                        idKH = "KH";
                    }
                }

                DAOPhong.UpdatePhongTrangThai(idPhong, "Đã đặt");

                while (true)
                {
                    try
                    {
                        Random r = new Random();
                        int ID = r.Next(100, 1000);
                        idThuePhong += ID;
                        DAOThuePhong.InsertThuePhong(idThuePhong, TienDatCoc, NgayThue, NgayTra, idKH, idPhong);
                        break;
                    }
                    catch (Exception ex)
                    {
                        idKH = "TP";
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Hết Phòng.");
            }
            return false;
        }
        public bool KTTextPhong(String id, String TenPhong,String LoaiPhong,String TrangThai,String DonGia)
        {
            if (DonGia != "" && int.Parse(DonGia.Trim()) > 0)
            {
                DAOPhong.InsertPhong(id, TenPhong, LoaiPhong, TrangThai, DonGia);
                return true;
            }
            else
            {
                MessageBox.Show("Đơn Giá phải > 0.Vui lòng nhập lại.");
            }
            return false;
        }
        public bool KTTextUPDATEPhong(String id, String TenPhong, String LoaiPhong, String TrangThai, String DonGia)
        {
            if (DonGia != "")
            {

                DAOPhong.UpdatePhong(id, TenPhong, LoaiPhong, TrangThai, DonGia);
                return true;
               
            }
            else
            {
                MessageBox.Show("Đơn Giá không được bỏ trống.Vui lòng nhập lại.");
            }
            return false;
        }
        public bool KTTextDeletePhong(String id)
        {
            try
            {
             
                DAOPhong.DeletePhong(id);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
            }
            return false;
        }

    }
}
