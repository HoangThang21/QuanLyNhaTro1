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

namespace QuanLyNhaTro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLLQuanLy BLLQuanLy = new BusinessLogicLayer.BLLQuanLy();
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (BLLQuanLy.Kttext(txtUserName.Text, txtPass.Text) == true)
            {
                Main main = new Main(txtUserName.Text);
                MessageBox.Show("Đăng nhập thành công với quyền "+modify.GetID("select chucvu from QuanLy where taikhoan='"+txtUserName.Text+"'"));
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
            anhxa();
        }
        public void anhxa()
        {
            txtUserName.Text = "";
            txtPass.Text = "";
            txtUserName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



       
    }
}
