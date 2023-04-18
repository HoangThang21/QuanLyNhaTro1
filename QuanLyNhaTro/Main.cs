using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDSPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlphong = new QuanLyPhong();
            qlphong.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyPhong dkphong = new DangKyPhong();
            dkphong.ShowDialog();
        }

        private void btnDSOTro_Click(object sender, EventArgs e)
        {
            DanhSachThueNhaTro dsotro = new DanhSachThueNhaTro();
            dsotro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyDienNuoc quanLyDienNuoc = new QuanLyDienNuoc();
            quanLyDienNuoc.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.ShowDialog();
        }
    }
}
