using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.BusinessLogicLayer;
using QuanLyNhaTro.DataAccess;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhaTro.GUI
{
    public partial class DoiMatKhau : Form
    {
        String tentk;
        public DoiMatKhau(String TenTK)
        {
            InitializeComponent();
            tentk = TenTK;
        }
        BLLQuanLy BLLQuanLy = new BLLQuanLy();
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = tentk;
            txtTaiKhoan.Enabled=false;
        }
        DAOQuanLy DAOQuanLy = new DAOQuanLy();
        private void button1_Click(object sender, EventArgs e)
        {
            if (DAOQuanLy.selectmatkhau_tk(tentk, txtMKCu.Text).Trim() != txtMKCu.Text)
            { MessageBox.Show("Mật khẩu không đúng. Vui lòng nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else
            {
                if (txtMKnew.Text != txtmkxnNew.Text) { MessageBox.Show("Mật Khẩu không trùng khớp ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
                else
                {
                   if( BLLQuanLy.DangKyTk(tentk, txtMKCu.Text, txtMKnew.Text, txtmkxnNew.Text) == true)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                   
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
