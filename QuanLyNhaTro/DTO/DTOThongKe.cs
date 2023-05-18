using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOThongKe
    {
        String IDThongKe { get; set; }
        String IDKhachHang { get; set; }
        String HoTen { get; set; }
        int TongTien { get; set; }
        DateTime NgayThu { get; set; }
        String TrangThai { get; set; }
        public DTOThongKe(String idThongKe,String idkhachhang, String hoten, int tongtien, DateTime ngaythu, String trangthai)
        {
            IDThongKe = idThongKe;
            HoTen = hoten;
            IDKhachHang = idkhachhang;
            TongTien = tongtien;
            NgayThu = ngaythu;
            TrangThai = trangthai;
        }
        public DTOThongKe()
        {
        
        }
    }
}
