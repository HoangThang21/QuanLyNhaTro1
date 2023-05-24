using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DTO;
using QuanLyNhaTro.GUI;

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
        Modify modify =new Modify();
        
        private void btnDSPhong_Click(object sender, EventArgs e)
        {
            if (dao.selectChucVu(tenTk) == "Admin" || dao.selectChucVu(tenTk) == "Quản lý")
            {
                QuanLyPhong qlphong = new QuanLyPhong();
                qlphong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }
           
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
        List<DTOTaiKhoan> taikhoan;
        private void Main_Load(object sender, EventArgs e)
        {
            if (tenTk == "")
            {
                this.Close();
            }
            labelTen.Text = "Tên tài khoản: "+tenTk;
            labelChucVu.Text ="Chức vụ: "+ dao.selectChucVu(tenTk);
            
            taikhoan= modify.TaiKhoans("select * from QuanLy where TaiKhoan='" + tenTk + "'");
            string a=taikhoan[0].ChucVu;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dao.selectChucVu(tenTk) == "Admin"|| dao.selectChucVu(tenTk) == "Quản lý") {
                QL_NhanVien qL_NhanVien = new QL_NhanVien();
                qL_NhanVien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            tenTk = "";
            this.Close();
            
        }



        private void btnThongKeThanhToan_Click(object sender, EventArgs e)
        {
            rpThongKe rpThongKe = new rpThongKe();
            rpThongKe.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(tenTk);
            doiMatKhau.ShowDialog();
        }

        private void btnThongKeKhachHang_Click(object sender, EventArgs e)
        {
            FrmReportKhachHangOTro frmReportKhachHangOTro = new FrmReportKhachHangOTro();
            frmReportKhachHangOTro.ShowDialog();
        }
    }
}
