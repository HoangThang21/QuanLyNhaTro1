﻿using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return modify.GetDataTable("Select * from Phong where TrangThai=N'Đã đặt' and TenPhong like '%"+word+"%'");
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
        public DataTable loadKH_DN_DV()
        {
            return modify.GetDataTable("select DISTINCT kh.HoTen,p.TenPhong,sum (p.DonGia)as N'Đơn Giá Phòng', sum (dn.DonGia)as N'Đơn Giá Điện Nước'  from KhachHang kh, DienNuoc dn, DichVu dv, ThuePhong tp, Phong p where dn.IDKH=kh.IDKH and dv.IDDV=dn.IDDV and tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong group by kh.HoTen,p.TenPhong");
        }
        public DataTable loadThongKe()
        {
            return modify.GetDataTable("select * from ThongKe");
        }
        public DataTable loadKHChuaDongTien()
        {
            return modify.GetDataTable("select DISTINCT kh.HoTen,p.TenPhong,sum (p.DonGia)as N'Đơn Giá Phòng', sum (dn.DonGia)as N'Đơn Giá Điện Nước'  from KhachHang kh, DienNuoc dn, DichVu dv, ThuePhong tp, Phong p where dn.IDKH=kh.IDKH and dv.IDDV=dn.IDDV and tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and kh.HoTen not in (select HoTenKH from ThongKe) group by kh.HoTen,p.TenPhong");
        }

    }
}
