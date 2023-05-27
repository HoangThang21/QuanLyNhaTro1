using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOKhachHang
    {
        public DTOKhachHang() { }
        private string idkh, hoten, cmnd, sdt, diachi, gioitinh;
        private DateTime ngaysinh;

        public string Idkh { get => idkh; set => idkh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DTOKhachHang(string idkh, string hoten, string cmnd, string sdt, DateTime ngaysinh, string diachi, string gioitinh)
        {
            this.Idkh = idkh;
            this.Hoten = hoten;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            
        }
    }
}
