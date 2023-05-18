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
        BusinessLogicLayer.BLLDatPhong bll= new BusinessLogicLayer.BLLDatPhong();
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            bll.KTTextPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text,txtDonGia.Text);
            loadagirview();
            anhxa();
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            bll.KTTextUPDATEPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text, txtDonGia.Text);
            loadagirview();
            anhxa();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            
            bll.KTTextDeletePhong(txtMaPhong.Text);
            loadagirview();
            anhxa();
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
