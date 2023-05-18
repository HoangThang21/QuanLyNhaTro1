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
        private string idkh, hoten, cmnd, sdt, ngaysinh, diachi, gioitinh;
        public DTOKhachHang(string idkh, string hoten, string cmnd, string sdt, string ngaysinh, string diachi, string gioitinh)
        {
            this.idkh = idkh;
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
        }
        public string Idkh { get;set; }
        public string Hoten { get;set; }
        public string Cmd { get; set; }
        public string Sdt { get; set; }
        public string Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
    }
}
