namespace QuanLyNhaTro.GUI
{
    partial class frmDatPhong
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
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.cbTenPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dTPSinh = new System.Windows.Forms.DateTimePicker();
            this.cbBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(1171, 560);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(194, 61);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày Trả:";
            // 
            // dTPNgayTra
            // 
            this.dTPNgayTra.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayTra.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayTra.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayTra.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPNgayTra.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPNgayTra.CustomFormat = "yyyy/MM/dd";
            this.dTPNgayTra.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayTra.Location = new System.Drawing.Point(370, 236);
            this.dTPNgayTra.Name = "dTPNgayTra";
            this.dTPNgayTra.Size = new System.Drawing.Size(304, 66);
            this.dTPNgayTra.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày Thuê:";
            // 
            // dTPNgayThue
            // 
            this.dTPNgayThue.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayThue.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayThue.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPNgayThue.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPNgayThue.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPNgayThue.CustomFormat = "yyyy/MM/dd";
            this.dTPNgayThue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayThue.Location = new System.Drawing.Point(381, 108);
            this.dTPNgayThue.Name = "dTPNgayThue";
            this.dTPNgayThue.Size = new System.Drawing.Size(304, 66);
            this.dTPNgayThue.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tiền đặt cọc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dTPNgayTra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dTPNgayThue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTienDatCoc);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 376);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDatCoc.Location = new System.Drawing.Point(41, 89);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(293, 66);
            this.txtTienDatCoc.TabIndex = 20;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnNhanPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.Location = new System.Drawing.Point(899, 560);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(182, 61);
            this.btnNhanPhong.TabIndex = 26;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(378, 86);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(285, 68);
            this.cbLoaiPhong.TabIndex = 4;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.lable.Location = new System.Drawing.Point(406, 36);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(186, 45);
            this.lable.TabIndex = 3;
            this.lable.Text = "Loại Phòng:";
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenPhong.FormattingEnabled = true;
            this.cbTenPhong.Location = new System.Drawing.Point(50, 86);
            this.cbTenPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(262, 68);
            this.cbTenPhong.TabIndex = 1;
            this.cbTenPhong.SelectedIndexChanged += new System.EventHandler(this.cbTenPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(47, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Phòng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbLoaiPhong);
            this.groupBox5.Controls.Add(this.lable);
            this.groupBox5.Controls.Add(this.cbTenPhong);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(45, 436);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(686, 231);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 45);
            this.label13.TabIndex = 19;
            this.label13.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(461, 211);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(320, 66);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(453, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 45);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ngày sinh:";
            // 
            // dTPSinh
            // 
            this.dTPSinh.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPSinh.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dTPSinh.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dTPSinh.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPSinh.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPSinh.CustomFormat = "yyyy/MM/dd";
            this.dTPSinh.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSinh.Location = new System.Drawing.Point(461, 94);
            this.dTPSinh.Name = "dTPSinh";
            this.dTPSinh.Size = new System.Drawing.Size(320, 66);
            this.dTPSinh.TabIndex = 11;
            // 
            // cbBoxGioiTinh
            // 
            this.cbBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxGioiTinh.FormattingEnabled = true;
            this.cbBoxGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbBoxGioiTinh.Location = new System.Drawing.Point(461, 328);
            this.cbBoxGioiTinh.Name = "cbBoxGioiTinh";
            this.cbBoxGioiTinh.Size = new System.Drawing.Size(320, 68);
            this.cbBoxGioiTinh.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 45);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 45);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(28, 328);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(371, 66);
            this.txtSoDienThoai.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 45);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thẻ căn cước/ CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(28, 211);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(371, 66);
            this.txtCMND.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(28, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(371, 66);
            this.txtHoTen.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.dTPSinh);
            this.groupBox4.Controls.Add(this.cbBoxGioiTinh);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSoDienThoai);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtCMND);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHoTen);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(744, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(804, 473);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // frmDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1569, 902);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.Name = "frmDatPhong";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPNgayTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPNgayThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dTPSinh;
        private System.Windows.Forms.ComboBox cbBoxGioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}