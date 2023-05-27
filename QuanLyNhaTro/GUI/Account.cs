using QuanLyNhaTro.BusinessLogicLayer;
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

namespace QuanLyNhaTro.GUI
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            DGVTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadDGV();
            DGVTaiKhoan.ReadOnly = true;
            DGVTaiKhoan.Columns[0].Width = 120;
            DGVTaiKhoan.Columns[1].Width = 200;
            DGVTaiKhoan.Columns[2].Width = 200;
        }
        DAO dAO = new DAO();
        DAOQuanLy DAOQuanLy = new DAOQuanLy();
        BLLQuanLy BLLQuanLy = new BLLQuanLy();
        public void loadDGV()
        {

            DGVTaiKhoan.DataSource = dAO.select_taikhoan();
        }

        DAO dao = new DAO();



        private void btnThemTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (dao.selectTk_quanly(txtTenTK.Text) > 0)
                {
                    MessageBox.Show("Tài khoản bị trùng vui lòng nhập tài khoản khác");
                }
                else
                {
                    if (BLLQuanLy.KiemTraThemTk(txtTenTK.Text, txtPass.Text, comboBoxChucVu.Text) == true)
                    {
                        loadDGV();

                        MessageBox.Show("Thêm Thành công tài khoản");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại tài khoản");
                    }

                }

            }
        }

        private void btnCapNhatTaiKhoan_Click_1(object sender, EventArgs e)
        {
            BLLQuanLy.KiemTraCapNhatTk(txtTenTK.Text, txtPass.Text, comboBoxChucVu.Text);
            loadDGV();
        }

        private void btnXoaTaiKhoan_Click_1(object sender, EventArgs e)
        {
            int i = DGVTaiKhoan.CurrentRow.Index;

            if (MessageBox.Show("Bạn có muốn xóa " + DGVTaiKhoan.Rows[i].Cells[0].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {
                DAOQuanLy.DeleteQuanLy(DGVTaiKhoan.Rows[i].Cells[0].Value.ToString());
                loadDGV();
            }
        }

        private void DGVTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVTaiKhoan.RowCount > 1)
            {
                int i = DGVTaiKhoan.CurrentRow.Index;
                txtTenTK.Text = DGVTaiKhoan.Rows[i].Cells[0].Value.ToString();
                txtPass.Text = DGVTaiKhoan.Rows[i].Cells[1].Value.ToString();
                comboBoxChucVu.Text = DGVTaiKhoan.Rows[i].Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
