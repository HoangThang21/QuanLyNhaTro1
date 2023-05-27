using QuanLyNhaTro.DTO;
using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaTro.GUI
{
    public partial class frmKhachHangView : Form
    {
        private String ID, HoTen, CMND, SDT, DiaChi, GioiTinh;
        private  DateTime NgaySinh;
        public frmKhachHangView(String id, String hoten,String cmnd,String sdt,DateTime ngaysinh,string diachi,string gioitinh)
        {
            InitializeComponent();
            ID=id; HoTen=hoten;
            CMND=cmnd;
            SDT=sdt;
            NgaySinh=ngaysinh;
            DiaChi=diachi;
            GioiTinh = gioitinh;

        }
        public frmKhachHangView()
        {
            InitializeComponent();
           
        }
        Modify modify = new Modify();
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void frmKhachHangView_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            txtCMND.Text = CMND;
            txtDiaChi.Text = DiaChi;
            txtSoDienThoai.Text = SDT;
            dateSinh.Text = NgaySinh.ToString();
            cbBoxGioiTinh.Text = GioiTinh;
            List<DTOThuePhong> dTOThuePhongs = modify.listthuephong("select * from ThuePhong where IDKH='" + ID + "'");
            foreach (DTOThuePhong table in dTOThuePhongs)
            {
                txtTienDatCoc.Text = table.Tendatcoc.ToString();
                dTPNgayThue.Text = table.Ngaythue.ToString();
                dTPNgayTra.Text = table.Ngaytra.ToString();

            }
        }
    }
}
