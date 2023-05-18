﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.DataAccess;
using QuanLyNhaTro.BusinessLogicLayer;
namespace QuanLyNhaTro
{
    public partial class QL_NhanVien : Form
    {
        public QL_NhanVien()
        {
            InitializeComponent();
        }
        DAO dAO = new DAO();
        DAOQuanLy DAOQuanLy = new DAOQuanLy();
        BLLQuanLy BLLQuanLy= new BLLQuanLy();
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            DGVTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadDGV();
            DGVTaiKhoan.ReadOnly = true;
        }
        public void loadDGV()
        {
           
            DGVTaiKhoan.DataSource = dAO.select_taikhoan();
        }

        private void DGVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            BLLQuanLy.KiemTraThemTk(txtTenTK.Text,txtPass.Text,comboBoxChucVu.Text);
            loadDGV();
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            BLLQuanLy.KiemTraCapNhatTk(txtTenTK.Text, txtPass.Text, comboBoxChucVu.Text);
            loadDGV();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            int i = DGVTaiKhoan.CurrentRow.Index;

            if (MessageBox.Show("Bạn có muốn xóa " + DGVTaiKhoan.Rows[i].Cells[0].Value.ToString()+" không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {
                DAOQuanLy.DeleteQuanLy(DGVTaiKhoan.Rows[i].Cells[0].Value.ToString());
                loadDGV();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}