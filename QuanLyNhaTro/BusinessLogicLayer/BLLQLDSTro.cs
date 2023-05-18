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
        public void KTtext(String TienDatCoc, String NgayThue, String NgayTra, String Ten, String CMND, String SDT, String NgaySinh, String DiaChi, String GioiTinh,String tenPhong,String IDKH)
        {
            //String idKH = DAOKH.getIDKH(IDTen);
            String idphong = DAOPhong.returnIDPhong(tenPhong);
            String idThuePhong = DAOThuePhong.GetIDThuePhong(IDKH);
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

                               
                                DAOKH.UpdateKH(IDKH, Ten, CMND, SDT, NgaySinh, DiaChi, GioiTinh);
                                DAOThuePhong.UpdateThuePhong(idThuePhong, TienDatCoc, NgayThue, NgayTra, IDKH, idphong);
                                DAOThongKeThanhToan.UpdateTK_KH(IDKH,Ten);
                                MessageBox.Show("Sửa thành công.");
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
        DataAccess.DAODichVu DAODichVu =new DataAccess.DAODichVu();
        public void DeleteThuePhong(String id,String idPhong,String idKH)
        {
            int tmp = DAODienNuoc.getcountIDDN_KH(idKH);
            if (tmp == 0)
            {
                DAOThuePhong.DeleteThuePhong(id);
                DAOPhong.UpdatePhongTrangThai(idPhong, "Trống");
                DAOKH.DeleteKH(idKH);
                MessageBox.Show("Xóa thành công!");
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
                MessageBox.Show("Xóa thành công!");
            }
            

        }
    }
}
