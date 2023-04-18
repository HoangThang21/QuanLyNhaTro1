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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            dGVChuaDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVDaDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loaddgvChuaDong();
            loaddgvDaDong();
        }
        DataAccess.DAO dao=new DataAccess.DAO();
        public void loaddgvChuaDong() {
           
            dGVChuaDong.DataSource=dao.loadKH_DN_DV();
        }
        public void loaddgvDaDong() {
            
            dGVDaDong.DataSource = dao.loadThongKe();
        }
        BusinessLogicLayer.BLLThanhToan BLLThanhToan=new BusinessLogicLayer.BLLThanhToan(); 
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int i = dGVChuaDong.CurrentRow.Index;
            dGVChuaDong.Rows[i].Cells[1].Value.ToString();
            BLLThanhToan.KTtext(dGVChuaDong.Rows[i].Cells[0].Value.ToString(), dGVChuaDong.Rows[i].Cells[2].Value.ToString(), dGVChuaDong.Rows[i].Cells[3].Value.ToString());
            loaddgvDaDong();
        }

        private void btnKHChuaDong_Click(object sender, EventArgs e)
        {
            dGVChuaDong.DataSource=dao.loadKHChuaDongTien();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            loaddgvChuaDong();
            loaddgvDaDong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
