using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTODienNuoc
    {
        public DTODienNuoc() { }
        private string iddiennuoc, iddv, dongia, idkh;

        public string Iddiennuoc { get => iddiennuoc; set => iddiennuoc = value; }
        public string Iddv { get => iddv; set => iddv = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Idkh { get => idkh; set => idkh = value; }

        public DTODienNuoc(string iddiennuoc, string iddv, string dongia, string idkh)
        {
            this.Iddiennuoc = iddiennuoc;
            this.Iddv = iddv;
            this.Dongia = dongia;
            this.Idkh = idkh;
        }
    
    }
}
