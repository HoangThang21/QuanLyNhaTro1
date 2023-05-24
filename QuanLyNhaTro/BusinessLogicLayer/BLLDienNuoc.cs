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
    internal class BLLDienNuoc
    {
        DataAccess.DAODichVu DAODichVu=new DAODichVu();
        DataAccess.DAODienNuoc DAODienNuoc = new DAODienNuoc();
        DataAccess.DAOKH DAOKH = new DAOKH();

        public bool KtText (String LoaiDv,String Cu , String Moi,String idKH)
        {
            String IDDV = "DV";
            String IDDienNuoc = "DN";
            int Gia=0;


            try
            {

                if (LoaiDv == "Điện")
                {
                    Gia = (int.Parse(Moi) - int.Parse(Cu)) * 1500;
                }
                if (LoaiDv == "Nước")
                {
                    Gia = (int.Parse(Moi) - int.Parse(Cu)) * 5000;
                }
                if (int.Parse(Moi) > int.Parse(Cu))
                {
                    while (true)
                    {
                        try
                        {
                            Random r = new Random();
                            int ID = r.Next(100, 1000);
                            IDDV += ID;
                            DAODichVu.InsertDichVu(IDDV, LoaiDv, int.Parse(Cu), (int.Parse(Moi)));

                            break;
                        }
                        catch (Exception ex)
                        {
                            IDDV = "DV";
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Random r = new Random();
                            int ID = r.Next(100, 1000);
                            IDDienNuoc += ID;
                            DAODienNuoc.InsertDienNuoc(IDDienNuoc, IDDV, Gia, idKH);

                            break;
                        }
                        catch (Exception ex)
                        {
                            IDDienNuoc = "DN";
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Điện Nước Mới không được < Điện Nước cũ");
                }
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public void DeleteDN( string id)
        {
            DAODienNuoc.DeleteDienNuoc(id);

        }
       
        public bool updateDN(String id,String loaiDV,String Cu , String Moi)
        {
            int cu = Int32.Parse(Cu);
            int moi= Int32.Parse(Moi);
            String idDV=DAODichVu.GetiDDV_DN(id);
            try
            {

                if (moi > cu)
                {
                    DAODichVu.UpdateDichVu(idDV, loaiDV, cu, moi);
                    return true;
                }
                else
                {
                    MessageBox.Show("Chỉ chứa số và giá trị mới > giá trị cũ. Vui lòng nhập lại!");
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
