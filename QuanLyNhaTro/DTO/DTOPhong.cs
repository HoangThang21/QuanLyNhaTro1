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
        private string idphong, tenphong, loaiphong, trangthai;
        private int dongia;

        public  string Idphong { get => idphong; set => idphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Dongia { get => dongia; set => dongia = value; }

        public DTOPhong(string idphong, string tenphong, string loaiphong, string trangthai, int dongia)
        {
            this.Idphong = idphong;
            this.Tenphong = tenphong;
            this.Loaiphong = loaiphong;
            this.Trangthai = trangthai;
            this.Dongia = dongia;
        }


    }
}
