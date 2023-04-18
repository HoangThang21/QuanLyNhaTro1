namespace QuanLyNhaTro
{
    partial class Main
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDSOTro = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDSPhong = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangKy.Location = new System.Drawing.Point(52, 28);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(342, 159);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký phòng trọ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDSOTro
            // 
            this.btnDSOTro.BackColor = System.Drawing.SystemColors.Control;
            this.btnDSOTro.Location = new System.Drawing.Point(468, 28);
            this.btnDSOTro.Name = "btnDSOTro";
            this.btnDSOTro.Size = new System.Drawing.Size(342, 159);
            this.btnDSOTro.TabIndex = 2;
            this.btnDSOTro.Text = "Danh Sách Khách Ở Phòng Trọ";
            this.btnDSOTro.UseVisualStyleBackColor = false;
            this.btnDSOTro.Click += new System.EventHandler(this.btnDSOTro_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.btnThanhToan.Location = new System.Drawing.Point(52, 419);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(342, 152);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDSPhong
            // 
            this.btnDSPhong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDSPhong.Location = new System.Drawing.Point(52, 220);
            this.btnDSPhong.Name = "btnDSPhong";
            this.btnDSPhong.Size = new System.Drawing.Size(342, 159);
            this.btnDSPhong.TabIndex = 4;
            this.btnDSPhong.Text = "Quản lý Phòng";
            this.btnDSPhong.UseVisualStyleBackColor = false;
            this.btnDSPhong.Click += new System.EventHandler(this.btnDSPhong_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(468, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(342, 148);
            this.button6.TabIndex = 5;
            this.button6.Text = "Thống kê báo cáo";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 148);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quản Lý Điện Nước";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1317, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnDSPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDSOTro);
            this.Controls.Add(this.btnDangKy);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDSOTro;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDSPhong;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}