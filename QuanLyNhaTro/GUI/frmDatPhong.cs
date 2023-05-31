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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLLDatPhong bl = new BusinessLogicLayer.BLLDatPhong();
        DataAccess.DAO dao = new DataAccess.DAO();
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            cbTenPhong.DataSource = dao.GetComboTenPhong();
            cbTenPhong.DisplayMember = "TenPhong";

        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTienDatCoc.Text != "" && int.Parse(txtTienDatCoc.Text.Trim()) > 0)
                {

                    if (txtHoTen.Text != "")
                    {
                        if (txtCMND.Text != "" && txtCMND.Text.All(char.IsDigit) == true)//Kiểm tra CMND all là số
                        {
                            if (txtSoDienThoai.Text != "" && txtSoDienThoai.Text.All(char.IsDigit) == true)
                            {
                                if (bl.KTText(txtTienDatCoc.Text, dTPNgayThue.Text, dTPNgayTra.Text, txtHoTen.Text, txtCMND.Text, txtSoDienThoai.Text, dTPSinh.Text, txtDiaChi.Text, cbBoxGioiTinh.Text, cbTenPhong.Text, cbLoaiPhong.Text) == true)
                                {
                                    MessageBox.Show("Đặt thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Đặt thất bại.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại chỉ chứa số.Vui lòng nhập lại.");
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

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoaiPhong.DataSource = dao.GetComBoLoaiPhong(cbTenPhong.Text);
            cbLoaiPhong.DisplayMember = "LoaiPhong";
        }



        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
