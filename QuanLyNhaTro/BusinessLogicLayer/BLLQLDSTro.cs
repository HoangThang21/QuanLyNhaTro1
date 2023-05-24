using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.DataAccess;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLQLDSTro
    {
        DAOKH DAOKH=new DAOKH();
        DAOPhong DAOPhong = new DAOPhong();
        DAOThuePhong DAOThuePhong=new DAOThuePhong();
        DAOThongKeThanhToan DAOThongKeThanhToan =new DAOThongKeThanhToan();
        public bool KTtext(String TienDatCoc, String NgayThue, String NgayTra, String Ten, String CMND, String SDT, String NgaySinh, String DiaChi, String GioiTinh,String tenPhong,String IDKH,string tenPhongcu)
        {
            //String idKH = DAOKH.getIDKH(IDTen);
            String idphong = DAOPhong.returnIDPhong(tenPhong);
            String idThuePhong = DAOThuePhong.GetIDThuePhong(IDKH);
            if (SDT != "" && SDT.All(char.IsDigit) == true)
            {

                if (DAOPhong.select_tinhtrangphong(tenPhong).Trim() == "Trống")
                {
                    DAOPhong.UpdateTrangThai(tenPhong, "Đã Đặt");
                    DAOPhong.UpdateTrangThai(tenPhongcu, "Trống");
                }

                DAOKH.UpdateKH(IDKH, Ten, CMND, SDT, NgaySinh, DiaChi, GioiTinh);
                DAOThuePhong.UpdateThuePhong(idThuePhong, TienDatCoc, NgayThue, NgayTra, IDKH, idphong);
                DAOThongKeThanhToan.UpdateTK_KH(IDKH, Ten);
                return true;
               
            }
            else
            {
                MessageBox.Show("Số điện thoại chỉ chứa số.Vui lòng nhập lại.");
            }

            return false;
        }
        DataAccess.DAODienNuoc DAODienNuoc=new DataAccess.DAODienNuoc();
        DataAccess.DAODichVu DAODichVu =new DataAccess.DAODichVu();
        public bool DeleteThuePhong(String id,String idPhong,String idKH)
        {
            int tmp = DAODienNuoc.getcountIDDN_KH(idKH);
            if (tmp == 0)
            {
                DAOThuePhong.DeleteThuePhong(id);
                DAOPhong.UpdatePhongTrangThai(idPhong, "Trống");
                DAOKH.DeleteKH(idKH);
                return true;
               
            }
            if(tmp>0)
            {
                DAOThuePhong.DeleteThuePhong(id);
                for(int i = 0; i < tmp; i++)
                {
                    DAODienNuoc.DeleteDienNuoc(DAODienNuoc.getID_KH(idKH));
                    //MessageBox.Show("a");
                  
                    
                }
                for(int y=0; y < tmp; y++)
                {
                    
                    DAODichVu.DeleteDichVu(DAODienNuoc.GetID_DV(idKH));
                }
                DAOPhong.UpdatePhongTrangThai(idPhong, "Trống");
                DAOKH.DeleteKH(idKH);
                return true;
               
            }
            return false;
            

        }
    }
}
