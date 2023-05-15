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
        private static String tenTk;
        public Main(String TenTk)
        {
            InitializeComponent();
            tenTk = TenTk;
        }
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        private void Main_Load(object sender, EventArgs e)
        {
            labelTen.Text = "Tên tài khoản: "+tenTk;
            labelChucVu.Text ="Chức vụ: "+ dao.selectChucVu(tenTk);
        }


    }
}
