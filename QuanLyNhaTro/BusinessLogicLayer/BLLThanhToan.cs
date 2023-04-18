using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.BusinessLogicLayer
{
    internal class BLLThanhToan
    {
        DataAccess.DAOThongKeThanhToan DAOThongKeThanhToan=new DataAccess.DAOThongKeThanhToan();
       

        DateTime d1 = DateTime.Now;
        DateTime ThangNam = DateTime.Now;

        public void KTtext(String Hoten,String tienPhong, String tienDienNuoc)
        {
            String idThongKe = "TK";
            int Tong=int.Parse(tienPhong)+int.Parse(tienDienNuoc);
            d1.ToString("yyyy / MM / dd");
            
            String NgayThu = d1.ToShortDateString();
            String thangnam=ThangNam.Year+"/"+ThangNam.Month;
            String sqlThangNam =DAOThongKeThanhToan.selectyear()+"/"+DAOThongKeThanhToan.selectmonth();
            try
            {
                if (Hoten != "")
                {
                    if(tienPhong !="" && int.Parse(tienPhong.Trim()) > 0)
                    {
                        if (tienDienNuoc != "" && int.Parse(tienDienNuoc.Trim()) > 0)
                        {
                            //MessageBox.Show(thangnam + ",,,," + sqlThangNam);
                            if(thangnam== sqlThangNam)
                            {
                                MessageBox.Show(thangnam + "=" + sqlThangNam+".Tháng này đã thu");
                            }
                            else
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Random r = new Random();
                                        int ID = r.Next(100, 1000);
                                        idThongKe += ID;
                                        DAOThongKeThanhToan.InsertTKKH(idThongKe, Hoten, Tong, NgayThu, "Đã thu");

                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        idThongKe = "TK";
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu Tiền Điện Nước bị lỗi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu Tiền Phòng bị lỗi!");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu Họ tên bị rỗng!");
                }
            }
            catch (Exception ex){
            
            }
        }
    }
}
