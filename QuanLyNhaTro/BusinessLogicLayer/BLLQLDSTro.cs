using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLQLDSTro
    {
        DataAccess.DAOKH DAOKH=new DataAccess.DAOKH();
        DataAccess.DAOPhong DAOPhong = new DAOPhong();
        DataAccess.DAOThuePhong DAOThuePhong=new DataAccess.DAOThuePhong();
        public void KTtext(String TienDatCoc, String NgayThue, String NgayTra, String Ten, String CMND, String SDT, String NgaySinh, String DiaChi, String GioiTinh,String tenPhong,String IDTen)
        {
            String idKH = DAOKH.getIDKH(IDTen);
            String idphong = DAOPhong.returnIDPhong(tenPhong);
            String idThuePhong = DAOThuePhong.GetIDThuePhong(idKH);
            try
            {
                if (TienDatCoc != "" && int.Parse(TienDatCoc.Trim()) > 0)
                {

                    if (Ten != "")
                    {
                        if (CMND != "" && CMND.All(char.IsDigit) == true)//Kiểm tra CMND all là số
                        {
                            if (SDT != "" && SDT.All(char.IsDigit) == true)
                            {
                                //MessageBox.Show(""+idKH+"" + TienDatCoc + " " + NgayThue + " " + NgayTra + " " + Ten + " " + CMND + " " + SDT + " " + NgaySinh + " " + DiaChi + " " + GioiTinh + " " );

                                MessageBox.Show("" + idKH);
                                DAOKH.UpdateKH(idKH, Ten, CMND, SDT, NgaySinh, DiaChi, GioiTinh);
                                DAOThuePhong.UpdateThuePhong(idThuePhong, TienDatCoc, NgayThue, NgayTra, idKH, idphong);

                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại chỉ chứa số.Vui lòng nhập lại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("CMND/CCCD chỉ chứa số.Vui lòng nhập lại.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tên không được bỏ trống.Vui lòng nhập lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Tiền đặt cọc:" + TienDatCoc + " phải > 0.Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
            }

        }
        DataAccess.DAODienNuoc DAODienNuoc=new DataAccess.DAODienNuoc();
        public void DeleteThuePhong(String id,String idPhong,String idKH)
        {
            int tmp = DAODienNuoc.getcountIDDN_KH(idKH);
            if (tmp == 0)
            {
                DAOThuePhong.DeleteThuePhong(id);
                DAOPhong.UpdatePhongTrangThai(idPhong, "Trống");
                DAOKH.DeleteKH(idKH);
            }
            if(tmp>0)
            {
                DAOThuePhong.DeleteThuePhong(id);
                for(int i = 0; i < tmp; i++)
                {
                   
                    DAODienNuoc.DeleteDienNuoc(DAODienNuoc.getID_KH(idKH));
                }
                DAOPhong.UpdatePhongTrangThai(idPhong, "Trống");
                DAOKH.DeleteKH(idKH);
            }
            

        }
    }
}
