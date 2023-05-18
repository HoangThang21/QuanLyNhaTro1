using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOThuePhong
    {
        public DTOThuePhong() { }
        private string idthuephong, tendatcoc, ngaythue, ngaytra, idkh, idphong;
        public DTOThuePhong(string idthuephong, string tendatcoc, string ngaythue, string ngaytra, string idkh, string idphong)
        {
            this.idthuephong = idthuephong;
            this.tendatcoc = tendatcoc;
            this.ngaythue = ngaythue;
            this.ngaytra = ngaytra;
            this.idkh = idkh;
            this.idphong = idphong;
        }
        public string Idthuethong { get; set; }
        public string Tendatcoc { get; set;
        }
        public string Ngaythue { get; set; }
        public string Tendtra { get; set;}
        public string Ngaytra { get; set;
        }
        public string Idkh { get; set; }
        public string Idphong { get; set;}
    }
}
