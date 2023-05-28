using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOThongKe
    {
        public String IDThongKe { get; set; }
        public String IDKhachHang { get; set; }
        public String HoTen { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayThu { get; set; }
         public String TrangThai { get; set; }
        public int TienThu { get; set; }
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
