namespace QuanLyNhaTro.GUI
{
    partial class frmQLPhong
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
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDongDSPhong = new FontAwesome.Sharp.IconButton();
            this.btnCapNhatPhong = new FontAwesome.Sharp.IconButton();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnThemPhong = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(27, 165);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(256, 68);
            this.cbLoaiPhong.TabIndex = 65;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(379, 61);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(252, 66);
            this.txtTenPhong.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tên Phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhatPhong);
            this.groupBox3.Controls.Add(this.btnDongDSPhong);
            this.groupBox3.Controls.Add(this.btnXoaPhong);
            this.groupBox3.Controls.Add(this.btnThemPhong);
            this.groupBox3.Controls.Add(this.btnTimKiemPhong);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(7, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(684, 273);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhong.ImageIndex = 6;
            this.btnTimKiemPhong.Location = new System.Drawing.Point(357, 192);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(298, 60);
            this.btnTimKiemPhong.TabIndex = 29;
            this.btnTimKiemPhong.Text = "Tìm Kiếm Tên Phòng";
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemPhong.Click += new System.EventHandler(this.btnTimKiemPhong_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(34, 202);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 46);
            this.txtSearch.TabIndex = 24;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(27, 61);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(256, 66);
            this.txtMaPhong.TabIndex = 64;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(27, 269);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(300, 66);
            this.txtDonGia.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 55;
            this.label3.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 54;
            this.label2.Text = "Loại Phòng:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã đặt",
            "Hư"});
            this.cbTrangThai.Location = new System.Drawing.Point(379, 203);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(252, 68);
            this.cbTrangThai.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 56;
            this.label6.Text = "Đơn Giá:";
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.Location = new System.Drawing.Point(741, 13);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(816, 856);
            this.flpPhong.TabIndex = 66;
            // 
            // btnDongDSPhong
            // 
            this.btnDongDSPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnDongDSPhong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongDSPhong.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnDongDSPhong.IconColor = System.Drawing.Color.Yellow;
            this.btnDongDSPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDongDSPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongDSPhong.Location = new System.Drawing.Point(345, 105);
            this.btnDongDSPhong.Name = "btnDongDSPhong";
            this.btnDongDSPhong.Size = new System.Drawing.Size(298, 52);
            this.btnDongDSPhong.TabIndex = 70;
            this.btnDongDSPhong.Text = "Đóng";
            this.btnDongDSPhong.UseVisualStyleBackColor = false;
            this.btnDongDSPhong.Click += new System.EventHandler(this.btnDongDSPhong_Click);
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnCapNhatPhong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPhong.IconChar = FontAwesome.Sharp.IconChar.TurnUp;
            this.btnCapNhatPhong.IconColor = System.Drawing.Color.Blue;
            this.btnCapNhatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatPhong.Location = new System.Drawing.Point(345, 28);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(310, 52);
            this.btnCapNhatPhong.TabIndex = 69;
            this.btnCapNhatPhong.Text = "Cập Nhật Phòng";
            this.btnCapNhatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnXoaPhong.IconColor = System.Drawing.Color.Red;
            this.btnXoaPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(24, 105);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(313, 52);
            this.btnXoaPhong.TabIndex = 68;
            this.btnXoaPhong.Text = "Xóa Phòng";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnThemPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.Location = new System.Drawing.Point(24, 28);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(313, 52);
            this.btnThemPhong.TabIndex = 67;
            this.btnThemPhong.Text = "   Thêm Phòng";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1569, 881);
            this.Controls.Add(this.flpPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.Name = "frmQLPhong";
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private FontAwesome.Sharp.IconButton btnThemPhong;
        private FontAwesome.Sharp.IconButton btnDongDSPhong;
        private FontAwesome.Sharp.IconButton btnCapNhatPhong;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
    }
}