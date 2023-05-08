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
    internal class BLLtest
    {

        DataAccess.DAOKH daokh = new DataAccess.DAOKH();
        DataAccess.DAOPhong DAOPhong = new DataAccess.DAOPhong();
        DataAccess.DAOThuePhong DAOThuePhong = new DataAccess.DAOThuePhong();
        public void KTText(String TienDatCoc,String NgayThue,String NgayTra,String Ten,String CMND,String SDT,String NgaySinh,String DiaChi,String GioiTinh,String TenPhong,String LoaiPhong)
        {
            String idKH = "KH";
            String idThuePhong = "TP";
            String idPhong = DAOPhong.returnIDPhong(TenPhong);
            try
            {
                if (TienDatCoc != "" && int.Parse(TienDatCoc.Trim()) > 0)
                {
                 
                    if (Ten != "")
                    {
                        if(CMND!=""&& CMND.All(char.IsDigit) == true)//Kiểm tra CMND all là số
                        {
                            if(SDT!=""&&SDT.All(char.IsDigit) == true)
                            {
                                if (TenPhong != "")
                                {
                                    MessageBox.Show("" + TienDatCoc + " " + NgayThue + " " + NgayTra + " " + Ten + " " + CMND + " " + SDT + " " + NgaySinh + " " + DiaChi + " " + GioiTinh + " " + TenPhong + " " + LoaiPhong);
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
                                    MessageBox.Show("Đã đặt thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Hết Phòng.");
                                }
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
                    MessageBox.Show("Tiền đặt cọc:" + TienDatCoc+" phải > 0.Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
            }

        }
        public void KTTextPhong(String id, String TenPhong,String LoaiPhong,String TrangThai,String DonGia)
        {
            try
            {
                if (id != "" && id.All(char.IsDigit) == true)
                {
                    if (TenPhong != "")
                    {
                        if(TrangThai== "Trống")
                        {
                            if(DonGia!=""&& int.Parse(DonGia.Trim())>0)
                            {
                                DAOPhong.InsertPhong(id, TenPhong, LoaiPhong, TrangThai, DonGia);
                                MessageBox.Show("Thêm Phòng Thành công");
                            }
                            else
                            {
                                MessageBox.Show("Đơn Giá phải > 0.Vui lòng nhập lại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phòng Trống.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                    }

                }
                else
                {
                    MessageBox.Show("ID Phòng Chứa Số. Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
            }
        }
        public void KTTextUPDATEPhong(String id, String TenPhong, String LoaiPhong, String TrangThai, String DonGia)
        {
            try
            {
                if (id != "" && id.All(char.IsDigit) == true)
                {
                   
                    if (TenPhong != "")
                    {
                      
                        if (TrangThai != "")
                        {
                           
                            if (DonGia != "" && int.Parse(DonGia.Trim()) > 0)
                            {
                                
                                DAOPhong.UpdatePhong(id, TenPhong, LoaiPhong, TrangThai, DonGia);
                                MessageBox.Show("Cập nhật Phòng Thành công");
                            }
                            else
                            {
                                MessageBox.Show("Đơn Giá phải > 0.Vui lòng nhập lại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phòng.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                    }

                }
                else
                {
                    MessageBox.Show("ID Phòng chỉ chứa số. Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!.ID Phòng có thể bị trùng.");
            }
        }
        public void KTTextDeletePhong(String id)
        {
            try
            {
             
                DAOPhong.DeletePhong(id);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
            }
        }

    }
}
