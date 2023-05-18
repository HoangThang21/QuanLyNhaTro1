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

namespace QuanLyNhaTro
{
    public partial class DanhSachThueNhaTro : Form
    {
        public DanhSachThueNhaTro()
        {
            InitializeComponent();
        }

        private void DanhSachThueNhaTro_Load(object sender, EventArgs e)
        {
            LoadDataGirView();
            dGVDSOTro.Columns[0].Visible = false;
            dGVDSOTro.Columns[4].Visible = false;
            dGVDSOTro.Columns[5].Visible = false;
            dGVDSOTro.Columns[6].Visible = false;
            dGVDSOTro.Columns[9].Visible = false;
            dGVDSOTro.Columns[11].Visible = false;
            txtTenPhong.Enabled = false;
            txtLoaiPhong.Enabled=false;
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
                txtTenPhong.Text = dGVDSOTro.Rows[i].Cells[7].Value.ToString();
                txtLoaiPhong.Text = dGVDSOTro.Rows[i].Cells[8].Value.ToString();
                txtGia.Text = dGVDSOTro.Rows[i].Cells[9].Value.ToString();
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
                BLLQLDSTro.KTtext(txtTienDatCoc.Text, dTPNgayThue.Text, dTPNgayTra.Text, txtHoTen.Text, txtCMND.Text, txtSoDienThoai.Text, dateSinh.Text, txtDiaChi.Text, cbBoxGioiTinh.Text,txtTenPhong.Text, dGVDSOTro.Rows[i].Cells[11].Value.ToString());
            }
            else
            {
                MessageBox.Show("Chưa có Khách Hàng");
            }
            LoadDataGirView();
            anhxa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVDSOTro.RowCount > 1) {
                int i = dGVDSOTro.CurrentRow.Index;
                BLLQLDSTro.DeleteThuePhong(dGVDSOTro.Rows[i].Cells[0].Value.ToString(), dGVDSOTro.Rows[i].Cells[5].Value.ToString(), dGVDSOTro.Rows[i].Cells[11].Value.ToString());
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
