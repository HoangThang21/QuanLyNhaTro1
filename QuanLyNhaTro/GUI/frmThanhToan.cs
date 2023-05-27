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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dGVChuaDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVDaDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loaddgvChuaDong();
            loaddgvDaDong();
            dGVChuaDong.ReadOnly = true;
            dGVChuaDong.Columns[0].Visible = false;
            dGVChuaDong.Columns[1].Width = 150;
            dGVChuaDong.Columns[3].Width = 160;
            dGVChuaDong.Columns[4].Width = 160;
            dGVChuaDong.Columns[1].HeaderText ="Họ tên";
            dGVChuaDong.Columns[2].HeaderText = "Phòng";
            dGVDaDong.Columns[0].Visible = false;
            dGVDaDong.Columns[1].Visible = false;
            dGVDaDong.Columns[2].HeaderText = "Họ tên";
            dGVDaDong.Columns[3].HeaderText = "Tổng tiền";
            dGVDaDong.Columns[4].HeaderText = "Ngày thu";
            dGVDaDong.Columns[5].HeaderText = "Trạng thái";
            dGVDaDong.Columns[6].HeaderText = "Đã thu";
            dGVDaDong.Columns[2].Width = 150;
            dGVDaDong.Columns[3].Width = 160;
            dGVDaDong.Columns[4].Width = 160;
            dGVDaDong.ReadOnly = true;
            txtTongTienThang.Enabled = false;
        }
        DAO dao = new DAO();
        public void loaddgvChuaDong()
        {
            dGVChuaDong.DataSource = dao.loadKH_DN_DV();
        }
        public void loaddgvDaDong()
        {

            dGVDaDong.DataSource = dao.loadThongKe();
        }
        BLLThanhToan BLLThanhToan = new BLLThanhToan();
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
                            if (txtTienThu.Text != "")
                            {
                                if (BLLThanhToan.KTtext(dGVChuaDong.Rows[i].Cells[0].Value.ToString(), dGVChuaDong.Rows[i].Cells[1].Value.ToString(), dGVChuaDong.Rows[i].Cells[3].Value.ToString(), dGVChuaDong.Rows[i].Cells[4].Value.ToString(), txtTienThu.Text) == true)
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
                                MessageBox.Show("Tiền thu không được bỏ trống");
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
                if (MessageBox.Show("Bạn muốn in hóa đơn của " + dGVDaDong.Rows[i].Cells[2].Value.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

        private void dGVChuaDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVChuaDong.RowCount > 1)
            {
                int i = dGVChuaDong.CurrentRow.Index;
                txtTongTienThang.Text = (int.Parse(dGVChuaDong.Rows[i].Cells[3].Value.ToString()) + int.Parse( dGVChuaDong.Rows[i].Cells[4].Value.ToString())).ToString();


            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chọn");
            }
           
        }

        private void dGVDaDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Thu tiền còn nợ","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {
                int i = dGVDaDong.CurrentRow.Index;
                int tong= int.Parse( dGVDaDong.Rows[i].Cells[3].Value.ToString());
                int thu = int.Parse(dGVDaDong.Rows[i].Cells[6].Value.ToString());
                frmThuTienNo frmThuTienNo = new frmThuTienNo(dGVDaDong.Rows[i].Cells[0].Value.ToString(), dGVDaDong.Rows[i].Cells[2].Value.ToString(),tong ,thu );
                frmThuTienNo.FormBorderStyle = FormBorderStyle.None;
                frmThuTienNo.Dock = DockStyle.Fill;
                frmThuTienNo.BringToFront();
                frmThuTienNo.ShowDialog();
                loaddgvDaDong();
            }
        }
    }
}
