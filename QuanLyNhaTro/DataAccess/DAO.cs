using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhaTro.DataAccess
{
    internal class DAO
    {
        Modify modify = new Modify();
        public DataTable GetComboTenPhong()
        {
            return modify.GetDataTable("select P.TenPhong From Phong P Where P.TrangThai=N'Trống'");
        }
        public DataTable GetComBoLoaiPhong(String tenPhong)
        {
            return modify.GetDataTable("select P.LoaiPhong From Phong P Where P.TrangThai=N'Trống' and TenPhong =N'"+tenPhong+"'");
        }
        public DataTable loadthuePhong()
        {
            return modify.GetDataTable("select * from ThuePhong tp,Phong p, KhachHang kh where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong");
        }
        public DataTable loadthuephong_SearchTenKH(String tenkh)
        {
            return modify.GetDataTable("select * from ThuePhong tp,Phong p, KhachHang kh where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and kh.HoTen like N'%"+tenkh+"%'");
        }
        public DataTable loadPhongDaDat()
        {
            return modify.GetDataTable("Select * from Phong where TrangThai=N'Đã đặt'");
        }
      
        public DataTable loadPhongTrong()
        {
            return modify.GetDataTable("Select * from Phong where TrangThai=N'Trống'");
        }
        public DataTable loadPhongDaDatSearch(String word)
        {
            return modify.GetDataTable("Select * from Phong where TrangThai=N'Đã đặt' and TenPhong like N'%"+word+"%'");
        }
        public DataTable loadPhongSearch(String word)
        {
            return modify.GetDataTable("Select * from Phong where TrangThai=N'Trống'  and TenPhong like '%"+word+"%'");
        }
        public DataTable loadKH_Phong()
        {
            return modify.GetDataTable("select kh.IDKH,kh.HoTen,p.TenPhong from ThuePhong tp, KhachHang kh, Phong p where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong");
        }
        public DataTable loadDienNuoc()
        {
            return modify.GetDataTable("select dn.IDDienNuoc, kh.HoTen,dv.IDLoaiDV,dv.Cu,dv.Moi,dn.DonGia from DienNuoc dn,DichVu dv,KhachHang kh where kh.IDKH=dn.IDKH and dn.IDDV=dv.IDDV");
        }
        public DataTable loadDienNuocSearch_tenkh(String tenKH)
        {
            return modify.GetDataTable("select dn.IDDienNuoc, kh.HoTen,dv.IDLoaiDV,dv.Cu,dv.Moi,dn.DonGia from DienNuoc dn,DichVu dv,KhachHang kh where kh.IDKH=dn.IDKH and dn.IDDV=dv.IDDV and kh.HoTen like N'%"+tenKH+"%'");
        }
        public DataTable loadKH_DN_DV()
        {
            return modify.GetDataTable("select DISTINCT kh.IDKH ,kh.HoTen,p.TenPhong,sum (p.DonGia)as N'Đơn Giá Phòng', sum (dn.DonGia)as N'Đơn Giá Điện Nước'  from KhachHang kh, DienNuoc dn, DichVu dv, ThuePhong tp, Phong p where dn.IDKH=kh.IDKH and dv.IDDV=dn.IDDV and tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong group by  kh.IDKH ,kh.HoTen,p.TenPhong");
        }
        public DataTable loadThongKe()
        {
            return modify.GetDataTable("select * from ThongKe");
        }
        public DataTable loadKHChuaDongTien()
        {
            return modify.GetDataTable("select DISTINCT  kh.IDKH, kh.HoTen,p.TenPhong,sum (p.DonGia)as N'Đơn Giá Phòng', sum (dn.DonGia)as N'Đơn Giá Điện Nước'  from KhachHang kh, DienNuoc dn, DichVu dv, ThuePhong tp, Phong p where dn.IDKH=kh.IDKH and dv.IDDV=dn.IDDV and tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and kh.HoTen not in (select HoTenKH from ThongKe) group by  kh.IDKH ,kh.HoTen,p.TenPhong");
        }
        public int selectTk(String tenTK,String matKhau)
        {
            string squery = "select * from QuanLy where taikhoan= '" + tenTK + "' and matkhau = '" + matKhau + "'";
            return modify.TaiKhoans(squery).Count;
        }
        public int selectTk_quanly(String tenTK)
        {
            string squery = "select * from QuanLy where taikhoan= '" + tenTK + "'";
            return modify.TaiKhoans(squery).Count;
        }
        public String selectPass(String tenTK)
        {
            return modify.GetID("select matkhau from QuanLy where taikhoan='" + tenTK + "'");
        }
        public String selectChucVu(String tenTK)
        {
            return modify.GetID("select chucvu from QuanLy where taikhoan='" + tenTK + "'");
        }
        public String selectHoTen_Tk(String idkh)
        {

            return modify.GetID("select DISTINCT IDKhachHang from ThongKe where IDKhachHang=N'" + idkh + "'");
        }
        public DataTable select_taikhoan()
        {
            return modify.GetDataTable("select * from QuanLy");
        }
        public  bool SaoLuu(string sDuongDan)
        {
            try
            {
                Modify modify = new Modify();
                string sTen = @"\QLNhaTro(" + DateTime.Now.Day.ToString() + "_" +
                  DateTime.Now.Month.ToString() + "_" +
                  DateTime.Now.Year.ToString() + "_" +
                  DateTime.Now.Hour.ToString() + "_" +
                  DateTime.Now.Minute.ToString() + ").bak";
                string sql = "BACKUP DATABASE QLNhaTro TO DISK = N'" + sDuongDan +
               sTen + "'";
                modify.Command(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool PhucHoiBH(string sDuongDan)
        {
            try
            {
                Modify modify = new Modify();
                
                string sql = "RESTORE DATABASE QLNhaTro From DISK = N'" + sDuongDan +"'";
                modify.Command(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
