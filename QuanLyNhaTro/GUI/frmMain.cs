using FontAwesome.Sharp;
using QuanLyNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Color = System.Drawing.Color;

namespace QuanLyNhaTro.GUI
{
    public partial class frmMain : Form
    {
        private Panel leftBorderBtnadmin;
        private Panel leftBorderBtNV;
        private Panel leftBorderBtReport;
        private String TK, ChucVu;
        public frmMain(String tk)
        {
            InitializeComponent();
            leftBorderBtnadmin = new Panel();
            leftBorderBtnadmin.Size = new Size(7, 60);
            siderbaradmin.Controls.Add(leftBorderBtnadmin);
            /* siderNV.Controls.Add(leftBorderBtn);*/
            leftBorderBtNV = new Panel();
            leftBorderBtNV.Size = new Size(7, 60);
            siderNV.Controls.Add(leftBorderBtNV);
            //report
            leftBorderBtReport = new Panel();
            leftBorderBtReport.Size = new Size(7, 60);
            pnReport.Controls.Add(leftBorderBtReport);
            TK = tk;
            ChucVu =dao.selectChucVu(tk); 
        }
        

        DAO dao = new DAO();
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            btnten.Text ="Tên: "+ TK +" | Chức vụ: "+ ChucVu;
            siderbaradmin.Height = siderbaradmin.MinimumSize.Height;
            if(ChucVu=="Admin"||ChucVu=="Quản lý")
            {

            }
            else
            {
                siderbaradmin.Visible= false;
            }
            
        }
        bool sibarex;
        bool admin;
        bool user;
        bool report;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sibarex)
            {
                siderBarControler.Width -= 10;
                if(siderBarControler.Width == siderBarControler.MinimumSize.Width){
                    sibarex = false;
                    timer1.Stop();
                }
            }
            else
            {
                siderBarControler.Width += 10;
                if (siderBarControler.Width == siderBarControler.MaximumSize.Width)
                {
                    sibarex = true;
                    timer1.Stop();
                }
            }
           
        }
        private Form active_form;
        private void loadfrom_label(Form form_child)
        {
            /*if(active_form == null)
            {
                active_form.Close();
            }*/
            active_form = form_child;
            form_child.TopLevel = false;
            form_child.FormBorderStyle = FormBorderStyle.None;
            form_child.Dock= DockStyle.Fill;
            this.bodyContainer.Controls.Add(form_child);
            this.bodyContainer.Tag= form_child;
            form_child.BringToFront();
            form_child.Show();
            labeltile.Text = form_child.Text;

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private IconButton currentBtn;
        private IconButton currentBtnnv;
        private IconButton currentBtnReport;

        private void ActivateButton(object senderBtn, Color color,int posi)
        {
            DisableButtonv();
            DisableButtonReport();
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtReport.BackColor = Color.Transparent;
                leftBorderBtNV.BackColor=Color.Transparent;
                leftBorderBtnadmin.BackColor = color;
                leftBorderBtnadmin.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtnadmin.Visible = true;
                leftBorderBtnadmin.BringToFront();
                
            }

        }
        private void ActivateButtonnv(object senderBtn, Color color, int posi)
        {
            DisableButton();
            DisableButtonReport();
            if (senderBtn != null)
            {
                DisableButtonv();
                //Button
                currentBtnnv = (IconButton)senderBtn;
                currentBtnnv.BackColor = Color.FromArgb(37, 36, 81);
                currentBtnnv.ForeColor = color;
                currentBtnnv.TextAlign = ContentAlignment.MiddleCenter;
                currentBtnnv.IconColor = color;
                currentBtnnv.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtnnv.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
               
                leftBorderBtnadmin.BackColor = Color.Transparent;
                leftBorderBtReport.BackColor = Color.Transparent;
                leftBorderBtNV.BackColor = color;
                if (currentBtnnv.Text == "Quản lý điện nước")
                {
                    leftBorderBtNV.Location = new Point(0, currentBtnnv.Location.Y);
                }
                else if (currentBtnnv.Text == "DS Đặt phòng")
                {
                    
                    leftBorderBtNV.Location = new Point(0, currentBtnnv.Location.Y+92);
                }
                else if (currentBtnnv.Text == "Đặt phòng")
                {
                   
                    leftBorderBtNV.Location = new Point(0, currentBtnnv.Location.Y + 178);
                }
                else if (currentBtnnv.Text == "Thanh Toán")
                {

                    leftBorderBtNV.Location = new Point(0, currentBtnnv.Location.Y + 262);
                }

                /* MessageBox.Show(currentBtnnv.Location.Y+""+ currentBtnnv.Text);*/
                leftBorderBtNV.Visible = true;
                leftBorderBtNV.BringToFront();
                
            }
        }
        private void ActivateButtonReport(object senderBtn, Color color, int posi)
        {

            DisableButton();
            DisableButtonv();
            if (senderBtn != null)
            {
                DisableButtonReport();
                //Button
                currentBtnReport = (IconButton)senderBtn;
                currentBtnReport.BackColor = Color.FromArgb(37, 36, 81);
                currentBtnReport.ForeColor = color;
                currentBtnReport.TextAlign = ContentAlignment.MiddleCenter;
                currentBtnReport.IconColor = color;
                currentBtnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtnReport.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtNV.BackColor = Color.Transparent;
                leftBorderBtnadmin.BackColor = Color.Transparent;
                leftBorderBtReport.BackColor = color;
                leftBorderBtReport.Location = new Point(0, currentBtnReport.Location.Y);
                
                leftBorderBtReport.Visible = true;
                leftBorderBtReport.BringToFront();

            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 40, 45);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableButtonReport()
        {
            if (currentBtnReport != null)
            {
                currentBtnReport.BackColor = Color.FromArgb(35, 40, 45);
                currentBtnReport.ForeColor = Color.Gainsboro;
                currentBtnReport.TextAlign = ContentAlignment.MiddleLeft;
                currentBtnReport.IconColor = Color.White;
                currentBtnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtnReport.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableButtonv()
        {
            if (currentBtnnv != null)
            {
                currentBtnnv.BackColor = Color.FromArgb(35, 40, 45);
                currentBtnnv.ForeColor = Color.Gainsboro;
                currentBtnnv.TextAlign = ContentAlignment.MiddleLeft;
                currentBtnnv.IconColor = Color.White;
                currentBtnnv.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtnnv.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
           
        }


        private void timeradmin_Tick(object sender, EventArgs e)
        {

            if (admin)
            {
                siderbaradmin.Height -= 10;
                if (siderbaradmin.Height == siderbaradmin.MinimumSize.Height)
                    
                {
                    admin = false;
                    timeradmin.Stop();
                }
            }
            else
            {
                siderbaradmin.Height += 10;
                if (siderbaradmin.Height == siderbaradmin.MaximumSize.Height)
                {
                    admin = true;
                    timeradmin.Stop();
                }
            }
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            timeradmin.Start();
        }

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1,1);
         
            loadfrom_label(new QuanLyNhaTro.GUI.Account());
        }

        private void btnPhong_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1,1);
            loadfrom_label(new QuanLyNhaTro.GUI.frmQLPhong());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.ActivateButtonnv(sender, RGBColors.color2,2);
            loadfrom_label(new QuanLyNhaTro.GUI.frmDatPhong());
        }

        private void btnDSDatPhong_Click(object sender, EventArgs e)
        {
            this.ActivateButtonnv(sender, RGBColors.color3,2);
            loadfrom_label(new QuanLyNhaTro.GUI.frmDSDatPhong());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.ActivateButtonnv(sender, RGBColors.color4,2);
            loadfrom_label(new QuanLyNhaTro.GUI.frmDienNuoc());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.ActivateButtonnv(sender, RGBColors.color5,2);
            loadfrom_label(new QuanLyNhaTro.GUI.frmThanhToan());
        }

        private void btnsaoLuu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1, 1);
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (dao.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }


        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1, 1);
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (dao.PhucHoiDuLieu(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void timerUser_Tick(object sender, EventArgs e)
        {
            if (user)
            {
                flpuser.Width -= 10;
                if (flpuser.Width == flpuser.MinimumSize.Width)
                {
                    user = false;
                    timerUser.Stop();
                }
            }
            else
            {
                flpuser.Width += 10;
                if (flpuser.Width == flpuser.MaximumSize.Width)
                {
                    user = true;
                    timerUser.Stop();
                }
            }
            
        }

        private void btnten_Click(object sender, EventArgs e)
        {
            timerUser.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            timereport.Start();
        }

        private void timereport_Tick(object sender, EventArgs e)
        {
            if (report)
            {
                pnReport.Height -= 10;
                if (pnReport.Height == pnReport.MinimumSize.Height)

                {
                    report = false;
                    timereport.Stop();
                }
            }
            else
            {
                pnReport.Height += 10;
                if (pnReport.Height == pnReport.MaximumSize.Height)
                {
                    report = true;
                    timereport.Stop();
                }
            }
        }

        private void btnRPThongKe_Click(object sender, EventArgs e)
        {
            ActivateButtonReport(sender, RGBColors.color5, 3);
            loadfrom_label(new QuanLyNhaTro.GUI.frmThongKe());
        }

        private void btnRPKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButtonReport(sender, RGBColors.color5, 3);
       
           
            loadfrom_label(new QuanLyNhaTro.GUI.FrmReportKhachHangOTro());
        }

        private void btnRPPhong_Click(object sender, EventArgs e)
        {
            ActivateButtonReport(sender, RGBColors.color5, 3);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://D:\\DoAnQuanLyNhaTro\\DoAn2\\QuanLyNhaTro1\\HuongDan\\HuongDan.chm");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            loadfrom_label(new QuanLyNhaTro.GUI.frmDoiMatKhau(TK));
        }
    }
}
