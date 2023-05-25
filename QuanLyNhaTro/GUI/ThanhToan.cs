using QuanLyNhaTro.DataAccess;
using QuanLyNhaTro.GUI;
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
            dGVChuaDong.ReadOnly = true;
            dGVDaDong.ReadOnly = true;
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        public void loaddgvChuaDong()
        {

            dGVChuaDong.DataSource = dao.loadKH_DN_DV();
        }
        public void loaddgvDaDong()
        {

            dGVDaDong.DataSource = dao.loadThongKe();
        }
        BusinessLogicLayer.BLLThanhToan BLLThanhToan = new BusinessLogicLayer.BLLThanhToan();
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dGVChuaDong.RowCount > 1)
            {
                int i = dGVChuaDong.CurrentRow.Index;
                if (dGVChuaDong.Rows[i].Cells[0].Value.ToString() != "")
                {
                    if (dGVChuaDong.Rows[i].Cells[3].Value.ToString() != "" && int.Parse(dGVChuaDong.Rows[i].Cells[3].Value.ToString().Trim()) > 0)
                    {
                        if (dGVChuaDong.Rows[i].Cells[4].Value.ToString() != "" && int.Parse(dGVChuaDong.Rows[i].Cells[4].Value.ToString().Trim()) > 0)
                        {
                            if (BLLThanhToan.KTtext(dGVChuaDong.Rows[i].Cells[0].Value.ToString(), dGVChuaDong.Rows[i].Cells[1].Value.ToString(), dGVChuaDong.Rows[i].Cells[3].Value.ToString(), dGVChuaDong.Rows[i].Cells[4].Value.ToString()) == true)
                            {
                                MessageBox.Show("Thu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán thất bại");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu Tiền Điện Nước bị lỗi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu Tiền Phòng bị lỗi!");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu Họ tên bị rỗng!");
                }


            }
            else
            {
                MessageBox.Show("Không có Khách Hàng hoặc chưa ghi điện nước cho khách hàng.");


            }

            loaddgvDaDong();
        }

        private void btnKHChuaDong_Click(object sender, EventArgs e)
        {
            dGVChuaDong.DataSource = dao.loadKHChuaDongTien();
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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dGVDaDong.RowCount > 1)
            {
                int i = dGVDaDong.CurrentRow.Index;
                if(MessageBox.Show("Bạn muốn in hóa đơn của "+ dGVDaDong.Rows[i].Cells[2].Value.ToString(),"Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    InHoaDon inHoaDon = new InHoaDon(dGVDaDong.Rows[i].Cells[1].Value.ToString());
                    inHoaDon.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
        }
    }
}
