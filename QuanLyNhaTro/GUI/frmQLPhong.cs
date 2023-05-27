using QuanLyNhaTro.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DTO;
using System.Windows.Documents;
using System.Windows.Media;
using Color = System.Drawing.Color;
using QuanLyNhaTro.Properties;
using QuanLyNhaTro.DataAccess;

namespace QuanLyNhaTro.GUI
{
    public partial class frmQLPhong : Form
    {
        private Button imgbotomButton;
        public frmQLPhong()
        {
            InitializeComponent();
            loadagirview();
            
        }
        Modify modify = new Modify();
        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            loadagirview();
        }
        DataAccess.DAO dao = new DataAccess.DAO();
        BLLDatPhong bll = new BLLDatPhong();
       
        public void loadagirview()
        {
            flpPhong.Controls.Clear();
            List < DTOPhong > dtophong= modify.listphong("select * from Phong");
            foreach (DTOPhong table in dtophong)
            {
                Button btn = new Button() { Width = 180, Height = 180 };
                btn.Text=table.Tenphong +Environment.NewLine+table.Trangthai;
                btn.Click += btn_click_flp;
                btn.Tag = table;
                imgbotomButton = new Button();
                imgbotomButton.BackgroundImage = QuanLyNhaTro.Properties.Resources.customer;
                imgbotomButton.BackgroundImageLayout = ImageLayout.Zoom;
                imgbotomButton.Size = new Size(30, 30);
                imgbotomButton.BackColor = Color.Red;
                imgbotomButton.Location = new Point(0, 10);
                imgbotomButton.Visible = true;
                imgbotomButton.Cursor = Cursors.Hand;
                imgbotomButton.BringToFront();
                imgbotomButton.Click += btn_clickKh_view;
                imgbotomButton.Tag = table;
                switch (table.Trangthai)
                {  
                    case "Đã đặt":
                         btn.BackColor = Color.Aqua; break;
                    case "Hư":
                        btn.BackColor = Color.Red; break;
                    default:
                        btn.BackColor = Color.YellowGreen; break;
                }
                flpPhong.Controls.Add(btn);
                flpPhong.Controls.Add(imgbotomButton);
            }
           /* dGVPhongDat.ReadOnly = true;
            dGVPhongDat.DataSource = dao.loadPhongDaDat();
            dGVPhongTrong.DataSource = dao.loadPhongTrong();*/
        }
        DTOPhong phong1;
        private void btn_clickKh_view(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
            {
                MessageBox.Show("Không có khách hàng");
                return;
            }
            phong1 = clickedButton.Tag as DTOPhong;

            // Kiểm tra xem đối tượng DTOPhong có được lưu trữ trong thuộc tính Tag của button không
            if (phong1 == null)
            {
                return;
            }
            List<DTOKhachHang> dTOKhachHangs = loadfrom_label(phong1.Idphong);

            if (dTOKhachHangs.Count == 0)
            {
                MessageBox.Show("Không có khách hàng");
            }
            else
            {
                MessageBox.Show(" có khách hàng");
                foreach (DTOKhachHang table in dTOKhachHangs)
                {
                    frmKhachHangView frmKhachHangView = new frmKhachHangView(table.Idkh,table.Hoten,table.Cmnd,table.Sdt,table.Ngaysinh,table.Diachi,table.Gioitinh);
                    /*frmKhachHangView.TopLevel = false;*/
                    frmKhachHangView.FormBorderStyle = FormBorderStyle.None;
                    frmKhachHangView.Dock = DockStyle.Fill;
                    frmKhachHangView.BringToFront();
                    frmKhachHangView.Show();
                }
                
            }
           

        }

        private List<DTOKhachHang> loadfrom_label(string idphong)
        {

            List<DTOKhachHang> dTOKhachHangs = modify.listkh("select kh.IDKH,kh.HoTen,kh.CMND,kh.SDT,kh.NgaySinh,kh.DiaChi,kh.GioiTinh from ThuePhong tp,Phong p, KhachHang kh where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and tp.IDPhong='"+idphong+"'");
            return dTOKhachHangs;
        }

        DTOPhong phong;
        private void btn_click_flp(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Kiểm tra xem đối tượng click có phải là một Button không
            if (clickedButton == null)
            {
                return;
            }

            // Lấy đối tượng DTOPhong được lưu trữ trong thuộc tính Tag của button
            phong = clickedButton.Tag as DTOPhong;

            // Kiểm tra xem đối tượng DTOPhong có được lưu trữ trong thuộc tính Tag của button không
            if (phong == null)
            {
                return;
            }

            // Lấy thông tin của đối tượng DTOPhong và đưa vào TextBox
            txtMaPhong.Text = phong.Idphong;
            txtTenPhong.Text = phong.Tenphong;
            cbLoaiPhong.Text = phong.Loaiphong;
            cbTrangThai.Text = phong.Trangthai;
            txtDonGia.Text = phong.Dongia.ToString();
        }

        public void anhxa()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Focus();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhong.Text != "" && txtMaPhong.Text.All(char.IsDigit) == true)
                {
                    if (txtTenPhong.Text != "")
                    {
                        if (cbTrangThai.Text == "Trống")
                        {
                            if (bll.KTTextPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text, txtDonGia.Text) == true)
                            {
                                loadagirview();
                                anhxa();
                                MessageBox.Show("Thêm Phòng Thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm Phòng Thất bại");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phòng Trống.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                    }

                }
                else
                {
                    MessageBox.Show("ID Phòng Chứa Số. Vui lòng nhập lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!. Hoặc mã phòng không được trùng");
            }
        }
        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
           
            if (phong.Idphong == txtMaPhong.Text)
            {
                try
                {
                    if (txtMaPhong.Text != "" && txtMaPhong.Text.All(char.IsDigit) == true)
                    {

                        if (txtTenPhong.Text != "")
                        {

                            if (cbTrangThai.Text != "")
                            {
                                if (bll.KTTextUPDATEPhong(txtMaPhong.Text, txtTenPhong.Text, cbLoaiPhong.Text, cbTrangThai.Text, txtDonGia.Text) == true)
                                {
                                    loadagirview();
                                    anhxa();
                                    MessageBox.Show("Cập nhật Phòng Thành công");
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật Phòng Thất Bại");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Vui lòng chọn phòng.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không bỏ trống tên phòng!Vui lòng nhập lại.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ID Phòng chỉ chứa số. Vui lòng nhập lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập lại có dữ liệu nhập lỗi!.ID Phòng có thể bị trùng.");
                }

            }
            else
            {
                MessageBox.Show("Không được đổi mã phòng khi cập nhật");
            }
        }

        private void btnDongDSPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn xóa phòng " + phong.Tenphong+" ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (phong.Trangthai == "Trống")
                {
                    if (bll.KTTextDeletePhong(txtMaPhong.Text) == true)
                    {
                        loadagirview();
                        anhxa();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn  phòng trống mới được xóa");
                }
            }
        }
        public void loadagirviewsearch(String tenphong)
        {
            flpPhong.Controls.Clear();
            List<DTOPhong> dtophong = modify.listphong("select * from Phong where TenPhong like'%"+tenphong+"%'");
            foreach (DTOPhong table in dtophong)
            {
                Button btn = new Button() { Width = 180, Height = 180 };
                btn.Text = table.Tenphong + Environment.NewLine + table.Trangthai;
                btn.Click += btn_click_flp;
                btn.Tag = table;

                switch (table.Trangthai)
                {
                    case "Đã đặt":
                        btn.BackColor = Color.Aqua; break;
                    default:
                        btn.BackColor = Color.YellowGreen; break;
                }
                flpPhong.Controls.Add(btn);
            }
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            loadagirviewsearch(txtSearch.Text);
        
        }
    }
}
