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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        

        private void rBNhanVien_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        BusinessLogicLayer.BLLQuanLy BLLQuanLy=new BusinessLogicLayer.BLLQuanLy();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            if (rBNhanVien.Checked == true)
            {
                BLLQuanLy.DangKyTk(txtTenTk.Text, txtMatKhau.Text, txtXNMatKhau.Text, "Quản lý");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
