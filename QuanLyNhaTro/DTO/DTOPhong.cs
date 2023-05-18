using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOPhong
    {
        public DTOPhong() { }
        private string idphong, tenphong, loaiphong, trangthai, dongia;
        public DTOPhong(string idphong, string tenphong, string loaiphong, string trangthai, string dongia)
        {
            this.idphong = idphong;
            this.tenphong = tenphong;
            this.loaiphong = loaiphong;
            this.trangthai = trangthai;
            this.dongia = dongia;
        }
        public string Idphong { get; set; }
        public string Tenphong { get; set;
        }
        public string Loaiphong { get; set;
        }
        public string Trangthai { get; set; }
        public string Dongia { get; set;}

    }
}
