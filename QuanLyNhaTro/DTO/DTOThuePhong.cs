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
        private string idthuephong,  idkh, idphong;
        private int tendatcoc;
        private DateTime ngaythue, ngaytra;

        public string Idthuephong { get => idthuephong; set => idthuephong = value; }
        public string Idkh { get => idkh; set => idkh = value; }
        public string Idphong { get => idphong; set => idphong = value; }
        public int Tendatcoc { get => tendatcoc; set => tendatcoc = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }

        public DTOThuePhong(string idthuephong, int tendatcoc, DateTime ngaythue, DateTime ngaytra, string idkh, string idphong)
        {
            this.Idthuephong = idthuephong;
            this.Tendatcoc = tendatcoc;
            this.Ngaythue = ngaythue;
            this.Ngaytra = ngaytra;
            this.Idkh = idkh;
            this.Idphong = idphong;
        }

    }
}
