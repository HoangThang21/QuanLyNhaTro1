using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    internal class DTOTaiKhoan
    {
        public DTOTaiKhoan()
        {
        }
         private string tenTaiKhoan, matKhau,chucvu;
        public DTOTaiKhoan(string tenTaiKhoan, string matKhau,string chucvu)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.chucvu = chucvu;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChucVu { get => chucvu; set => chucvu = value; }

    }
}
