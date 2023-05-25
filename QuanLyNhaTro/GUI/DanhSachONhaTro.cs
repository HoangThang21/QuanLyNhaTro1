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
using QuanLyNhaTro.DataAccess;


namespace QuanLyNhaTro
{
    public partial class DanhSachThueNhaTro : Form
    {
        public DanhSachThueNhaTro()
        {
            InitializeComponent();
        }
        DAOPhong DAOPhong = new DAOPhong();
        private void DanhSachThueNhaTro_Load(object sender, EventArgs e)
        {
            LoadDataGirView();
            cbTenPhong.DataSource = DAOPhong.select_TenPhong();
            cbTenPhong.DisplayMember = "TenPhong";
            dGVDSOTro.Columns[0].Visible = false;
            dGVDSOTro.Columns[4].Visible = false;
            dGVDSOTro.Columns[5].Visible = false;
            dGVDSOTro.Columns[6].Visible = false;
            dGVDSOTro.Columns[9].Visible = false;
            dGVDSOTro.Columns[11].Visible = false;
           
           
            txtGia.Enabled = false;
            dGVDSOTro.ReadOnly = true;
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        public void LoadDataGirView()
        {
            dGVDSOTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVDSOTro.ReadOnly = true;
            dGVDSOTro.DataSource = dao.loadthuePhong();
            /* HeaderText*/
            dGVDSOTro.Columns[1].HeaderText = "Tiền đặt cọc";
            dGVDSOTro.Columns[2].HeaderText = "Ngày thuê";
            dGVDSOTro.Columns[3].HeaderText = "Ngày trả";
            dGVDSOTro.Columns[7].HeaderText = "Tên phòng";
            dGVDSOTro.Columns[8].HeaderText = "Loại phòng";
            dGVDSOTro.Columns[10].HeaderText = "Đơn giá";
            dGVDSOTro.Columns[12].HeaderText = "Họ tên";
            dGVDSOTro.Columns[15].HeaderText = "Ngày sinh";
            dGVDSOTro.Columns[16].HeaderText = "Địa chỉ";
            dGVDSOTro.Columns[17].HeaderText = "Giới tính";

        }
        public void anhxa()
        {
            txtTienDatCoc.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTienDatCoc.Focus();
        }
        private void dGVDSOTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            anhxa();
            if (dGVDSOTro.RowCount > 1)
            {
                int i = dGVDSOTro.CurrentRow.Index;
                txtTienDatCoc.Text = dGVDSOTro.Rows[i].Cells[1].Value.ToString();
                dTPNgayThue.Text = dGVDSOTro.Rows[i].Cells[2].Value.ToString();
                dTPNgayTra.Text = dGVDSOTro.Rows[i].Cells[3].Value.ToString();
                cbTenPhong.Text = dGVDSOTro.Rows[i].Cells[7].Value.ToString();
               
                txtGia.Text = dGVDSOTro.Rows[i].Cells[10].Value.ToString();
                txtHoTen.Text = dGVDSOTro.Rows[i].Cells[12].Value.ToString();
                txtCMND.Text = dGVDSOTro.Rows[i].Cells[13].Value.ToString();
                txtSoDienThoai.Text = dGVDSOTro.Rows[i].Cells[14].Value.ToString();
                dateSinh.Text = dGVDSOTro.Rows[i].Cells[15].Value.ToString();
                txtDiaChi.Text = dGVDSOTro.Rows[i].Cells[16].Value.ToString();
                cbBoxGioiTinh.Text = dGVDSOTro.Rows[i].Cells[17].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
        }
        BusinessLogicLayer.BLLQLDSTro BLLQLDSTro = new BusinessLogicLayer.BLLQLDSTro();
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dGVDSOTro.RowCount > 1) {
                int i = dGVDSOTro.CurrentRow.Index;
                try
                {
                    if (txtTienDatCoc.Text != "" && int.Parse(txtTienDatCoc.Text.Trim()) > 0)
                    {

                        if (txtHoTen.Text != "")
                        {
                            if (txtCMND.Text != "" && txtCMND.Text.All(char.IsDigit) == true)//Kiểm tra CMND all là số
                            {
                                if(BLLQLDSTro.KTtext(txtTienDatCoc.Text, dTPNgayThue.Text, dTPNgayTra.Text, txtHoTen.Text, txtCMND.Text, txtSoDienThoai.Text, dateSinh.Text, txtDiaChi.Text, cbBoxGioiTinh.Text, cbTenPhong.Text, dGVDSOTro.Rows[i].Cells[11].Value.ToString(), dGVDSOTro.Rows[i].Cells[7].Value.ToString()) == true)
                                {
                                    LoadDataGirView();
                                    anhxa();
                                    MessageBox.Show("Sửa thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thất bại.");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("CMND/CCCD chỉ chứa số.Vui lòng nhập lại.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Tên không được bỏ trống.Vui lòng nhập lại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiền đặt cọc:" + txtTienDatCoc.Text + " phải > 0.Vui lòng nhập lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!");
                }
               
            }
            else
            {
                MessageBox.Show("Chưa có Khách Hàng");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVDSOTro.RowCount > 1) {
                int i = dGVDSOTro.CurrentRow.Index;
                if (MessageBox.Show("Bạn muốn xóa " + dGVDSOTro.Rows[i].Cells[12].Value.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (BLLQLDSTro.DeleteThuePhong(dGVDSOTro.Rows[i].Cells[0].Value.ToString(), dGVDSOTro.Rows[i].Cells[5].Value.ToString(), dGVDSOTro.Rows[i].Cells[11].Value.ToString()) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                    
            }
            else
            {
               
            }
            anhxa();
            LoadDataGirView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
