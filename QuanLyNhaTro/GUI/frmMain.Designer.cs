namespace QuanLyNhaTro.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.flpuser = new System.Windows.Forms.FlowLayoutPanel();
            this.btnten = new FontAwesome.Sharp.IconButton();
            this.btnDoiMatKhau = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.labeltile = new System.Windows.Forms.Label();
            this.bodyContainer = new System.Windows.Forms.Panel();
            this.siderBarControler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.siderbaradmin = new System.Windows.Forms.Panel();
            this.btnPhucHoi = new FontAwesome.Sharp.IconButton();
            this.btnsaoLuu = new FontAwesome.Sharp.IconButton();
            this.btnPhong = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.pnReport = new System.Windows.Forms.Panel();
            this.btnRPKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnRPThongKe = new FontAwesome.Sharp.IconButton();
            this.btnThongKeBaoCao = new FontAwesome.Sharp.IconButton();
            this.siderNV = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDSDatPhong = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeradmin = new System.Windows.Forms.Timer(this.components);
            this.timerUser = new System.Windows.Forms.Timer(this.components);
            this.timereport = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.flpuser.SuspendLayout();
            this.siderBarControler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.siderbaradmin.SuspendLayout();
            this.pnReport.SuspendLayout();
            this.siderNV.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelheader);
            this.panel1.Controls.Add(this.bodyContainer);
            this.panel1.Controls.Add(this.siderBarControler);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1929, 1052);
            this.panel1.TabIndex = 0;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelheader.Controls.Add(this.flpuser);
            this.panelheader.Controls.Add(this.labeltile);
            this.panelheader.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelheader.Location = new System.Drawing.Point(333, 3);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1593, 109);
            this.panelheader.TabIndex = 1;
            // 
            // flpuser
            // 
            this.flpuser.Controls.Add(this.btnten);
            this.flpuser.Controls.Add(this.btnDoiMatKhau);
            this.flpuser.Controls.Add(this.btnThoat);
            this.flpuser.Location = new System.Drawing.Point(553, 24);
            this.flpuser.MaximumSize = new System.Drawing.Size(1030, 101);
            this.flpuser.MinimumSize = new System.Drawing.Size(595, 101);
            this.flpuser.Name = "flpuser";
            this.flpuser.Size = new System.Drawing.Size(595, 101);
            this.flpuser.TabIndex = 10;
            // 
            // btnten
            // 
            this.btnten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnten.FlatAppearance.BorderSize = 0;
            this.btnten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnten.ForeColor = System.Drawing.Color.White;
            this.btnten.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnten.IconColor = System.Drawing.Color.White;
            this.btnten.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnten.Location = new System.Drawing.Point(3, 3);
            this.btnten.Name = "btnten";
            this.btnten.Size = new System.Drawing.Size(534, 67);
            this.btnten.TabIndex = 7;
            this.btnten.Text = "Tên";
            this.btnten.UseVisualStyleBackColor = true;
            this.btnten.Click += new System.EventHandler(this.btnten_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnDoiMatKhau.IconColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(3, 76);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(273, 67);
            this.btnDoiMatKhau.TabIndex = 8;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(282, 76);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(168, 67);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labeltile
            // 
            this.labeltile.AutoSize = true;
            this.labeltile.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltile.Location = new System.Drawing.Point(28, 24);
            this.labeltile.Name = "labeltile";
            this.labeltile.Size = new System.Drawing.Size(361, 60);
            this.labeltile.TabIndex = 0;
            this.labeltile.Text = "                            ";
            // 
            // bodyContainer
            // 
            this.bodyContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bodyContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyContainer.ForeColor = System.Drawing.Color.Black;
            this.bodyContainer.Location = new System.Drawing.Point(335, 113);
            this.bodyContainer.MaximumSize = new System.Drawing.Size(1591, 958);
            this.bodyContainer.MinimumSize = new System.Drawing.Size(1591, 937);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Size = new System.Drawing.Size(1591, 958);
            this.bodyContainer.TabIndex = 2;
            // 
            // siderBarControler
            // 
            this.siderBarControler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.siderBarControler.Controls.Add(this.panel2);
            this.siderBarControler.Controls.Add(this.siderbaradmin);
            this.siderBarControler.Controls.Add(this.pnReport);
            this.siderBarControler.Controls.Add(this.siderNV);
            this.siderBarControler.Location = new System.Drawing.Point(0, 3);
            this.siderBarControler.MaximumSize = new System.Drawing.Size(336, 1049);
            this.siderBarControler.MinimumSize = new System.Drawing.Size(100, 1049);
            this.siderBarControler.Name = "siderBarControler";
            this.siderBarControler.Size = new System.Drawing.Size(336, 1049);
            this.siderBarControler.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 109);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.nhatrologo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(92, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 82);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // siderbaradmin
            // 
            this.siderbaradmin.Controls.Add(this.btnPhucHoi);
            this.siderbaradmin.Controls.Add(this.btnsaoLuu);
            this.siderbaradmin.Controls.Add(this.btnPhong);
            this.siderbaradmin.Controls.Add(this.btnTaiKhoan);
            this.siderbaradmin.Controls.Add(this.btnAdmin);
            this.siderbaradmin.Location = new System.Drawing.Point(3, 118);
            this.siderbaradmin.MaximumSize = new System.Drawing.Size(333, 381);
            this.siderbaradmin.MinimumSize = new System.Drawing.Size(333, 81);
            this.siderbaradmin.Name = "siderbaradmin";
            this.siderbaradmin.Size = new System.Drawing.Size(333, 81);
            this.siderbaradmin.TabIndex = 1;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.FlatAppearance.BorderSize = 0;
            this.btnPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhucHoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.ForeColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnPhucHoi.IconColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhucHoi.Location = new System.Drawing.Point(-3, 309);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(333, 67);
            this.btnPhucHoi.TabIndex = 6;
            this.btnPhucHoi.Text = "Phục Hồi";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnsaoLuu
            // 
            this.btnsaoLuu.FlatAppearance.BorderSize = 0;
            this.btnsaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaoLuu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaoLuu.ForeColor = System.Drawing.Color.White;
            this.btnsaoLuu.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsaoLuu.IconColor = System.Drawing.Color.White;
            this.btnsaoLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsaoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaoLuu.Location = new System.Drawing.Point(0, 236);
            this.btnsaoLuu.Name = "btnsaoLuu";
            this.btnsaoLuu.Size = new System.Drawing.Size(333, 67);
            this.btnsaoLuu.TabIndex = 5;
            this.btnsaoLuu.Text = "Sao Lưu";
            this.btnsaoLuu.UseVisualStyleBackColor = true;
            this.btnsaoLuu.Click += new System.EventHandler(this.btnsaoLuu_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.White;
            this.btnPhong.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnPhong.IconColor = System.Drawing.Color.White;
            this.btnPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(0, 163);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(333, 67);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Danh sách Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click_1);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 90);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(333, 67);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-3, 13);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(333, 67);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // pnReport
            // 
            this.pnReport.Controls.Add(this.btnRPKhachHang);
            this.pnReport.Controls.Add(this.btnRPThongKe);
            this.pnReport.Controls.Add(this.btnThongKeBaoCao);
            this.pnReport.Location = new System.Drawing.Point(3, 205);
            this.pnReport.MaximumSize = new System.Drawing.Size(333, 245);
            this.pnReport.MinimumSize = new System.Drawing.Size(333, 81);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(333, 245);
            this.pnReport.TabIndex = 7;
            // 
            // btnRPKhachHang
            // 
            this.btnRPKhachHang.FlatAppearance.BorderSize = 0;
            this.btnRPKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPKhachHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnRPKhachHang.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.btnRPKhachHang.IconColor = System.Drawing.Color.White;
            this.btnRPKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRPKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRPKhachHang.Location = new System.Drawing.Point(0, 163);
            this.btnRPKhachHang.Name = "btnRPKhachHang";
            this.btnRPKhachHang.Size = new System.Drawing.Size(333, 67);
            this.btnRPKhachHang.TabIndex = 4;
            this.btnRPKhachHang.Text = "Khách Hàng";
            this.btnRPKhachHang.UseVisualStyleBackColor = true;
            this.btnRPKhachHang.Click += new System.EventHandler(this.btnRPKhachHang_Click);
            // 
            // btnRPThongKe
            // 
            this.btnRPThongKe.FlatAppearance.BorderSize = 0;
            this.btnRPThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPThongKe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPThongKe.ForeColor = System.Drawing.Color.White;
            this.btnRPThongKe.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
            this.btnRPThongKe.IconColor = System.Drawing.Color.White;
            this.btnRPThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRPThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRPThongKe.Location = new System.Drawing.Point(0, 90);
            this.btnRPThongKe.Name = "btnRPThongKe";
            this.btnRPThongKe.Size = new System.Drawing.Size(333, 67);
            this.btnRPThongKe.TabIndex = 3;
            this.btnRPThongKe.Text = "Hóa Đơn";
            this.btnRPThongKe.UseVisualStyleBackColor = true;
            this.btnRPThongKe.Click += new System.EventHandler(this.btnRPThongKe_Click);
            // 
            // btnThongKeBaoCao
            // 
            this.btnThongKeBaoCao.FlatAppearance.BorderSize = 0;
            this.btnThongKeBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeBaoCao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnThongKeBaoCao.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.btnThongKeBaoCao.IconColor = System.Drawing.Color.White;
            this.btnThongKeBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKeBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeBaoCao.Location = new System.Drawing.Point(-3, 13);
            this.btnThongKeBaoCao.Name = "btnThongKeBaoCao";
            this.btnThongKeBaoCao.Size = new System.Drawing.Size(333, 67);
            this.btnThongKeBaoCao.TabIndex = 0;
            this.btnThongKeBaoCao.Text = "Thống Kê Báo Cáo";
            this.btnThongKeBaoCao.UseVisualStyleBackColor = true;
            this.btnThongKeBaoCao.Click += new System.EventHandler(this.btnThongKeBaoCao_Click);
            // 
            // siderNV
            // 
            this.siderNV.Controls.Add(this.panel7);
            this.siderNV.Controls.Add(this.panel3);
            this.siderNV.Controls.Add(this.panel5);
            this.siderNV.Controls.Add(this.panel6);
            this.siderNV.Controls.Add(this.panel4);
            this.siderNV.Location = new System.Drawing.Point(3, 456);
            this.siderNV.Name = "siderNV";
            this.siderNV.Size = new System.Drawing.Size(330, 581);
            this.siderNV.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.iconButton2);
            this.panel7.Location = new System.Drawing.Point(3, 373);
            this.panel7.MaximumSize = new System.Drawing.Size(333, 233);
            this.panel7.MinimumSize = new System.Drawing.Size(333, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 103);
            this.panel7.TabIndex = 7;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Torah;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(327, 67);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Hướng Dẫn";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(3, 179);
            this.panel3.MaximumSize = new System.Drawing.Size(333, 233);
            this.panel3.MinimumSize = new System.Drawing.Size(333, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 91);
            this.panel3.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(333, 67);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Đặt phòng";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton3);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.MaximumSize = new System.Drawing.Size(333, 233);
            this.panel5.MinimumSize = new System.Drawing.Size(333, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 91);
            this.panel5.TabIndex = 4;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.HandHoldingDroplet;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(333, 67);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.Text = "Quản lý điện nước";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iconButton4);
            this.panel6.Location = new System.Drawing.Point(3, 264);
            this.panel6.MaximumSize = new System.Drawing.Size(333, 233);
            this.panel6.MinimumSize = new System.Drawing.Size(333, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 103);
            this.panel6.TabIndex = 6;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 12);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(327, 67);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "Thanh Toán";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDSDatPhong);
            this.panel4.Location = new System.Drawing.Point(3, 94);
            this.panel4.MaximumSize = new System.Drawing.Size(333, 233);
            this.panel4.MinimumSize = new System.Drawing.Size(333, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 91);
            this.panel4.TabIndex = 6;
            // 
            // btnDSDatPhong
            // 
            this.btnDSDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDSDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDatPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDSDatPhong.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnDSDatPhong.IconColor = System.Drawing.Color.White;
            this.btnDSDatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDSDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSDatPhong.Location = new System.Drawing.Point(0, 12);
            this.btnDSDatPhong.Name = "btnDSDatPhong";
            this.btnDSDatPhong.Size = new System.Drawing.Size(333, 67);
            this.btnDSDatPhong.TabIndex = 5;
            this.btnDSDatPhong.Text = "DS Đặt phòng";
            this.btnDSDatPhong.UseVisualStyleBackColor = true;
            this.btnDSDatPhong.Click += new System.EventHandler(this.btnDSDatPhong_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeradmin
            // 
            this.timeradmin.Interval = 10;
            this.timeradmin.Tick += new System.EventHandler(this.timeradmin_Tick);
            // 
            // timerUser
            // 
            this.timerUser.Interval = 10;
            this.timerUser.Tick += new System.EventHandler(this.timerUser_Tick);
            // 
            // timereport
            // 
            this.timereport.Interval = 10;
            this.timereport.Tick += new System.EventHandler(this.timereport_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.flpuser.ResumeLayout(false);
            this.siderBarControler.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.siderbaradmin.ResumeLayout(false);
            this.pnReport.ResumeLayout(false);
            this.siderNV.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel siderBarControler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel siderbaradmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timeradmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelheader;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnPhong;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnDSDatPhong;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel siderNV;
        private FontAwesome.Sharp.IconButton btnPhucHoi;
        private FontAwesome.Sharp.IconButton btnsaoLuu;
        private System.Windows.Forms.Label labeltile;
        private System.Windows.Forms.Timer timerUser;
        private System.Windows.Forms.FlowLayoutPanel flpuser;
        private FontAwesome.Sharp.IconButton btnten;
        private FontAwesome.Sharp.IconButton btnDoiMatKhau;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Panel pnReport;
        private FontAwesome.Sharp.IconButton btnRPKhachHang;
        private FontAwesome.Sharp.IconButton btnRPThongKe;
        private FontAwesome.Sharp.IconButton btnThongKeBaoCao;
        private System.Windows.Forms.Timer timereport;
        private System.Windows.Forms.Panel bodyContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}