using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class DangKyPhong : Form
    {
        public DangKyPhong()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLLTaiKhoan bl = new BusinessLogicLayer.BLLTaiKhoan();
        DataAccess.DAO dao= new DataAccess.DAO();
        private void DangKyPhong_Load(object sender, EventArgs e)
        {
            cbTenPhong.DataSource = dao.GetComboTenPhong();
            cbTenPhong.DisplayMember = "TenPhong";

    
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            bl.KTText(txtTienDatCoc.Text,dTPNgayThue.Text,dTPNgayTra.Text,txtHoTen.Text,txtCMND.Text,txtSoDienThoai.Text,dTPSinh.Text,txtDiaChi.Text,cbBoxGioiTinh.Text,cbTenPhong.Text,cbLoaiPhong.Text);


        }

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoaiPhong.DataSource = dao.GetComBoLoaiPhong(cbTenPhong.Text);
            cbLoaiPhong.DisplayMember = "LoaiPhong";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
