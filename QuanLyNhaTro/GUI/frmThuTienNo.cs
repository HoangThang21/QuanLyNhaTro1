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

namespace QuanLyNhaTro.GUI
{
    public partial class frmThuTienNo : Form
    {
        private String ID, HoTen ;
        private int TongTien, THU;
        public frmThuTienNo(String id,String hoten,int tongtien, int thu)
        {
            InitializeComponent();
            ID = id;
            HoTen = hoten;
            TongTien = tongtien;
            THU = thu;
        }

        private void frmThuTienNo_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            txttongtien.Text = TongTien.ToString();
            txtHoTen.Enabled = false;
            txttongtien.Enabled=false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLLThanhToan BLLThanhToan = new BLLThanhToan();
        private void btnThu_Click(object sender, EventArgs e)
        {
            if (TongTien == THU)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");

            }
            else
            {
                if (txttienthu.Text != "" && int.Parse(txttienthu.Text) > 0)
                {
                    MessageBox.Show(TongTien+""+ THU);
                    if (BLLThanhToan.kiemtrathutien(ID, TongTien, THU, txttienthu.Text) == true)
                    {
                        MessageBox.Show("Thu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Tiền thu không được bỏ trống và >0.Vui lòng nhập lại");
                }
            }
                
           
            
        }
    }
}
