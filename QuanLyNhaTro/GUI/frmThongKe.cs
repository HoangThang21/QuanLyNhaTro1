using QuanLyNhaTro.DTO;
using System;
using QuanLyNhaTro.ClassModle;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace QuanLyNhaTro.GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        
        }
        Modify modify = new Modify();
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadchart("SELECT NgayThu, SUM(TongTien) AS TongTien, SUM(TienThu) AS TienThu FROM ThongKe GROUP BY NgayThu");
            labelTongHoaDon.Text = modify.GetInt32("select count(IDKhachHang) from ThongKe").ToString();
            labelTongTienKhachHangNo.Text = (modify.GetInt32("select sum(TongTien) from ThongKe")- modify.GetInt32("select sum(TienThu) from ThongKe")).ToString();
            labeltienthu.Text = modify.GetInt32("select sum(TienThu) from ThongKe").ToString();
            labelthang.Text = modify.GetInt32("SELECT sum(TienThu) FROM ThongKe where Month(NgayThu)='" + DateTime.Now.Month + "'").ToString();;
            dgvThongKe.DataSource = modify.GetDataTable("select HoTenKH,NgayThu,TrangThai, sum(TongTien-TienThu) as N'Tiền Còn Nợ' from ThongKe GROUP BY HoTenKH,NgayThu,TrangThai");
            labelTongDoanhThu.Text = modify.GetInt32("select sum(TongTien) from ThongKe").ToString();
            labeltxtthang.Text = "Tổng doanh thu của tháng "+ DateTime.Now.Month;
            dgvThongKe.Columns[0].HeaderText = "Họ tên";
            dgvThongKe.Columns[1].HeaderText = "Ngày thu";
            dgvThongKe.Columns[2].HeaderText = "Trạng thái";
            dgvThongKe.Columns[0].Width = 200;
            dgvThongKe.Columns[1].Width = 200;
            dgvThongKe.Columns[2].Width = 120;
            dgvThongKe.Columns[3].Width = 300;
            dgvThongKe.ReadOnly = true;

        }
        
        public void loadchart(String query)
        {
            List<DTOThongKe> thongKes = modify.ThongKes_report(query);

            chartThongKe.DataSource = thongKes;
            chartThongKe.Series[0].XValueMember = "NgayThu";
            chartThongKe.Series[0].YValueMembers = "TongTien";
            chartThongKe.Series[1].XValueMember = "NgayThu";
            chartThongKe.Series[1].YValueMembers = "TienThu";
            chartThongKe.DataBind();

        }
        public void loadcharttoday(String query)
        {
            List<DTOThongKe> thongKes = modify.ThongKes_report(query);
            chartThongKe.DataSource = thongKes;
            chartThongKe.Series[0].XValueMember = "NgayThu";
            chartThongKe.Series[0].YValueMembers = "TongTien";
            chartThongKe.Series[1].XValueMember = "NgayThu";
            chartThongKe.Series[1].YValueMembers = "TienThu";
            chartThongKe.DataBind();

        }

       

        private void labelStart_Click(object sender, EventArgs e)
        {
            dtpcu.Select();
            SendKeys.Send("%{DOWN}");
           
        }

        private void labelEnd_Click(object sender, EventArgs e)
        {
            dtpmoi.Select();
            SendKeys.Send("%{DOWN}");
           
        }

        private void dtpcu_ValueChanged(object sender, EventArgs e)
        {
            labelStart.Text = dtpcu.Text;
        }

        private void dtpmoi_ValueChanged(object sender, EventArgs e)
        {
            labelEnd.Text = dtpmoi.Text;
        }
      
        private void btnToday_Click(object sender, EventArgs e)
        {
            
            loadcharttoday("SELECT NgayThu, TongTien, TienThu FROM ThongKe where DAY(NgayThu)='"+ DateTime.Now.Day+"'");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadchart("SELECT NgayThu, SUM(TongTien) AS TongTien, SUM(TienThu) AS TienThu FROM ThongKe GROUP BY NgayThu");
        }

        private void btn30day_Click(object sender, EventArgs e)
        {
            loadchart("SELECT NgayThu, TongTien, TienThu FROM ThongKe where Month(NgayThu)='" + DateTime.Now.Month + "'");
        }

        private void btnTìm_Click(object sender, EventArgs e)
        {
            loadchart("SELECT NgayThu, TongTien, TienThu FROM ThongKe where NgayThu between '" + dtpcu.Text+"' and '"+dtpmoi.Text+"'");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            rpThongKe rpThongKe = new rpThongKe();
            rpThongKe.Show();
        }
    }
}
