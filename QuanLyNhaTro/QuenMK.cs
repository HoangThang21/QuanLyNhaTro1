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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLLQuanLy BLLQuanLy=new BusinessLogicLayer.BLLQuanLy();
        private void btnLayMK_Click(object sender, EventArgs e)
        {
            String pass = BLLQuanLy.LayPass(txtUserName.Text);
            if (pass != "")
            {
                MessageBox.Show("Mật khẩu là : " + pass);
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng hoặc không có tài khoản này.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
