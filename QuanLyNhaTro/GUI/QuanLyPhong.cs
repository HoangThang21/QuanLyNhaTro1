using QuanLyNhaTro.DataAccess;
using QuanLyNhaTro.DTO;
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

namespace QuanLyNhaTro
{
    public partial class QuanLyPhong : Form
    {
        public QuanLyPhong()
        {
            InitializeComponent();
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
             dGVPhongDat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVPhongTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadagirview();
            dGVPhongDat.ReadOnly = true;
            dGVPhongTrong.ReadOnly = true;
            // txtMaPhong.Enabled = false;
        }
        public void loadagirview()
        {

            dGVPhongDat.ReadOnly = true;
            dGVPhongDat.DataSource = dao.loadPhongDaDat();
            dGVPhongTrong.DataSource = dao.loadPhongTrong();
        }
        public void anhxa()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGVPhongDat.RowCount > 1)
            {
                int i = dGVPhongDat.CurrentRow.Index;
                txtMaPhong.Text = dGVPhongDat.Rows[i].Cells[0].Value.ToString();
                txtTenPhong.Text = dGVPhongDat.Rows[i].Cells[1].Value.ToString();
                cbLoaiPhong.Text = dGVPhongDat.Rows[i].Cells[2].Value.ToString();
                cbTrangThai.Text = dGVPhongDat.Rows[i].Cells[3].Value.ToString();
                txtDonGia.Text = dGVPhongDat.Rows[i].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
          
        }

        private void dGVPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVPhongTrong.RowCount > 1)
            {
                int i = dGVPhongTrong.CurrentRow.Index;
                txtMaPhong.Text = dGVPhongTrong.Rows[i].Cells[0].Value.ToString();
                txtTenPhong.Text = dGVPhongTrong.Rows[i].Cells[1].Value.ToString();
                cbLoaiPhong.Text = dGVPhongTrong.Rows[i].Cells[2].Value.ToString();
                cbTrangThai.Text = dGVPhongTrong.Rows[i].Cells[3].Value.ToString();
                txtDonGia.Text = dGVPhongTrong.Rows[i].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
        
        }
        BLLDatPhong bll= new BLLDatPhong();
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhong.Text != "" && txtMaPhong.Text.All(char.IsDigit) == true)
                {
                    if (txtTenPhong.Text != "")
                    {
                        if (cbTrangThai.Text == "Trống")
                        {
                            if(bll.KTTextPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text, txtDonGia.Text) == true)
                            {
                                loadagirview();
                                anhxa();
                                MessageBox.Show("Thêm Phòng Thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm Phòng Thất bại");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phòng Trống.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                    }

                }
                else
                {
                    MessageBox.Show("ID Phòng Chứa Số. Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!. Hoặc mã phòng không được trùng");
            }
            
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            int i = dGVPhongTrong.CurrentRow.Index;
            if(dGVPhongTrong.Rows[i].Cells[0].Value.ToString() == txtMaPhong.Text)
            {
                try
                {
                    if (txtMaPhong.Text != "" && txtMaPhong.Text.All(char.IsDigit) == true)
                    {

                        if (txtTenPhong.Text != "")
                        {

                            if (cbTrangThai.Text != "")
                            {
                                if(bll.KTTextUPDATEPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text, txtDonGia.Text) == true)
                                {
                                    loadagirview();
                                    anhxa();
                                    MessageBox.Show("Cập nhật Phòng Thành công");
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật Phòng Thất Bại");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng chọn phòng.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ID Phòng chỉ chứa số. Vui lòng nhập lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!.ID Phòng có thể bị trùng.");
                }
               
            }
            else
            {
                MessageBox.Show("Không được đổi mã phòng khi cập nhật");
            }
            
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            int i = dGVPhongTrong.CurrentRow.Index;
            if (dGVPhongTrong.Rows[i].Cells[3].Value.ToString() == "Trống")
            {
                if (bll.KTTextDeletePhong(txtMaPhong.Text) == true)
                {
                    loadagirview();
                    anhxa();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bảng phòng trống mới được xóa");
            }
            
        }

        private void btnDongDSPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            dGVPhongDat.DataSource=dao.loadPhongDaDatSearch(txtSearch.Text);
            dGVPhongTrong.DataSource= dao.loadPhongSearch(txtSearch.Text);
        }
    }
}
