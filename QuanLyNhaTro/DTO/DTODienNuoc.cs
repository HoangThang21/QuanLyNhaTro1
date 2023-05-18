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
        public DTODienNuoc(string iddiennuoc, string iddv, string dongia, string idkh)
        {
            this.iddiennuoc = iddiennuoc;
            this.iddv = iddv;
            this.dongia = dongia;
            this.idkh = idkh;
        }
        public string Iddiennuoc { get ; set ; }
        public string Iddv { get ; set ; }
        public string Dongia { get ; set ;}
        public string Idkh { get ; set ; }
    }
}
