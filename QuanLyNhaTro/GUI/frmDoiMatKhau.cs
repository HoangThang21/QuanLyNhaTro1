using QuanLyNhaTro.BusinessLogicLayer;
using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhaTro.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau(String TenTK)
        {
            InitializeComponent();
            tentk = TenTK;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (DAOQuanLy.selectmatkhau_tk(tentk, modify.GetMd5Hash(txtMKCu.Text)).Trim() != modify.GetMd5Hash(txtMKCu.Text))
            { MessageBox.Show("Mật khẩu không đúng. Vui lòng nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else
            {
                if (txtMKnew.Text != txtmkxnNew.Text) { MessageBox.Show("Mật Khẩu không trùng khớp ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
                else
                {
                    if (BLLQuanLy.DangKyTk(tentk, txtMKCu.Text, txtMKnew.Text, txtmkxnNew.Text) == true)
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
        String tentk;
        BLLQuanLy BLLQuanLy = new BLLQuanLy();
        DAOQuanLy DAOQuanLy = new DAOQuanLy();
        Modify modify = new Modify();
    

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = tentk;
            txtTaiKhoan.Enabled = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
