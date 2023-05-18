using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTO_DichVu
    {
        public DTO_DichVu() { }
        private string iddv, idloaidv, cu, moi;
        public DTO_DichVu(string iddv, string idloaidv, string cu, string moi)
        {
            this.iddv = iddv;
            this.idloaidv = idloaidv;
            this.cu = cu;
            this.moi = moi;
        }
        public string Iddv { get; set; }
        public string Idloaidv { get; set; }
        public string Cu { get; set; }
        public string Moi { get; set; }
    }
}
