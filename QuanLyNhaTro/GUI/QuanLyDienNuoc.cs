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

namespace QuanLyNhaTro
{
    public partial class QuanLyDienNuoc : Form
    {
        public QuanLyDienNuoc()
        {
            InitializeComponent();
        }
        private void QuanLyDienNuoc_Load(object sender, EventArgs e)
        {
            load();
            txtGia.Enabled=false;
            txtKH.Enabled = false;
            dGVKH.ReadOnly = true;
            dGVDienNuoc.ReadOnly = true;
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        public void load()
        {
            dGVKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVKH.ReadOnly = true;
            dGVKH.DataSource = dao.loadKH_Phong();

            dGVDienNuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVDienNuoc.ReadOnly = true;
            dGVDienNuoc.DataSource = dao.loadDienNuoc();
            dGVDienNuoc.Columns[0].Visible = false;
            dGVKH.Columns[0].Visible = false;
        }

        private void dGVKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVKH.RowCount > 1)
            {
                int i = dGVKH.CurrentRow.Index;
                txtKH.Text = dGVKH.Rows[i].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
           

            
        }
        BusinessLogicLayer.BLLDienNuoc BLLDienNuoc = new BusinessLogicLayer.BLLDienNuoc();
        private void btnThemDn_Click(object sender, EventArgs e)
        {
            if (dGVKH.RowCount > 1)
            {
                int i = dGVKH.CurrentRow.Index;
                if (txtCu.Text != "" && txtCu.Text.All(char.IsDigit) == true)
                {
                    if (txtMoi.Text != "" && txtMoi.Text.All(char.IsDigit) == true)
                    {
                        if(BLLDienNuoc.KtText(cbDienNuoc.Text, txtCu.Text, txtMoi.Text, dGVKH.Rows[i].Cells[0].Value.ToString()) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                        


                    }
                    else
                    {
                        MessageBox.Show("Chỉ chứa số và số lớn hơn 0. Vui lòng nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ chứa số và số lớn hơn 0. Vui lòng nhập lại!");
                }
               
            }
            else
            {
                MessageBox.Show("Không có khách hàng để thêm");
            }
           
            load();
        }

        private void btnXoaDN_Click(object sender, EventArgs e)
        {
            if (dGVDienNuoc.RowCount > 1)
            {
                int i = dGVDienNuoc.CurrentRow.Index;
                if (MessageBox.Show("Bạn xóa Chỉ số điện nước của " + dGVDienNuoc.Rows[i].Cells[1].Value.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                 
                    BLLDienNuoc.DeleteDN(dGVDienNuoc.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công");
                }
                    
            }
            else
            {
                MessageBox.Show("Không có điện nước để xóa");
            }
          
            load();
        }

        private void dGVDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDienNuoc.RowCount > 1)
            {
                int i = dGVDienNuoc.CurrentRow.Index;
                txtKH.Text = dGVDienNuoc.Rows[i].Cells[1].Value.ToString();
                cbDienNuoc.Text = dGVDienNuoc.Rows[i].Cells[2].Value.ToString();
                txtCu.Text = dGVDienNuoc.Rows[i].Cells[3].Value.ToString();
                txtMoi.Text = dGVDienNuoc.Rows[i].Cells[4].Value.ToString();
                txtGia.Text = dGVDienNuoc.Rows[i].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
          
        }

        private void btnDongDSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatDn_Click(object sender, EventArgs e)
        {
            if (dGVKH.RowCount > 1)
            {
                int i = dGVDienNuoc.CurrentRow.Index;
                if (txtCu.Text != "" && txtCu.Text.All(char.IsDigit) == true)
                {
                    if (txtMoi.Text != "" && txtMoi.Text.All(char.IsDigit) == true)
                    {
                        if(BLLDienNuoc.updateDN(dGVDienNuoc.Rows[i].Cells[0].Value.ToString(), cbDienNuoc.Text, txtCu.Text, txtMoi.Text))
                        {
                            MessageBox.Show("Cập nhật thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                       


                    }
                    else
                    {
                        MessageBox.Show("Điện Nước Mới không được < Điện Nước cũ. Vui lòng nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ chứa số. Vui lòng nhập lại!");
                }
               
            }
            else
            {
                MessageBox.Show("Không có điện nước để cập nhật");
            }

            load();
        }

        private void btnSearchDn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng muốn tìm");
            }
            else
            {
                dGVDienNuoc.DataSource = dao.loadDienNuocSearch_tenkh(txtSearch.Text.Trim());
            }
           
        }

        private void btnDongDSPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
