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
        String HoTen { get; set; }
        String TongTien { get; set; }
        String NgayThu { get; set; }
        String TrangThai { get; set; }
        public DTOThongKe(String idThongKe, String hoten, String tongtien, String ngaythu, String trangthai)
        {
            IDThongKe = idThongKe;
            HoTen = hoten;
            TongTien = tongtien;
            NgayThu = ngaythu;
            TrangThai = trangthai;
        }
        public DTOThongKe()
        {
        
        }
    }
}
