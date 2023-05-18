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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (BLLQuanLy.Kttext(txtUserName.Text, txtPass.Text) == true)
            {
                Main main = new Main(txtUserName.Text);

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

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.ShowDialog();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
    }
}
