namespace QuanLyNhaTro.GUI
{
    partial class frmThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnKHChuaDong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dGVDaDong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dGVChuaDong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTienThang = new System.Windows.Forms.TextBox();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuaDong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTroLai);
            this.groupBox1.Controls.Add(this.btnKHChuaDong);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 590);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 186);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng tìm kiếm khách hàng";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(204, 52);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(216, 59);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Reset";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnKHChuaDong
            // 
            this.btnKHChuaDong.Location = new System.Drawing.Point(6, 38);
            this.btnKHChuaDong.Name = "btnKHChuaDong";
            this.btnKHChuaDong.Size = new System.Drawing.Size(192, 148);
            this.btnKHChuaDong.TabIndex = 2;
            this.btnKHChuaDong.Text = "Tìm kiếm Khách Hàng Chưa Đóng Tiền";
            this.btnKHChuaDong.UseVisualStyleBackColor = true;
            this.btnKHChuaDong.Click += new System.EventHandler(this.btnKHChuaDong_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(204, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 60);
            this.button2.TabIndex = 22;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dGVDaDong
            // 
            this.dGVDaDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDaDong.Location = new System.Drawing.Point(924, 67);
            this.dGVDaDong.Name = "dGVDaDong";
            this.dGVDaDong.RowHeadersWidth = 62;
            this.dGVDaDong.RowTemplate.Height = 28;
            this.dGVDaDong.Size = new System.Drawing.Size(633, 506);
            this.dGVDaDong.TabIndex = 20;
            this.dGVDaDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDaDong_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(939, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh Sách Khách Hàng Đã Đóng Tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1060, 703);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(243, 74);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dGVChuaDong
            // 
            this.dGVChuaDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChuaDong.Location = new System.Drawing.Point(12, 67);
            this.dGVChuaDong.Name = "dGVChuaDong";
            this.dGVChuaDong.RowHeadersWidth = 62;
            this.dGVChuaDong.RowTemplate.Height = 28;
            this.dGVChuaDong.Size = new System.Drawing.Size(633, 506);
            this.dGVChuaDong.TabIndex = 17;
            this.dGVChuaDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVChuaDong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh Sách Khách Hàng Chưa Đóng Tiền";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Location = new System.Drawing.Point(1314, 603);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(243, 74);
            this.btnInHoaDon.TabIndex = 23;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 45);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng tiền tháng";
            // 
            // txtTongTienThang
            // 
            this.txtTongTienThang.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienThang.Location = new System.Drawing.Point(735, 630);
            this.txtTongTienThang.Name = "txtTongTienThang";
            this.txtTongTienThang.Size = new System.Drawing.Size(310, 66);
            this.txtTongTienThang.TabIndex = 25;
            // 
            // txtTienThu
            // 
            this.txtTienThu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThu.Location = new System.Drawing.Point(735, 710);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(310, 66);
            this.txtTienThu.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 714);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 45);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tiền thu";
            // 
            // frmThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1569, 902);
            this.Controls.Add(this.txtTienThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTienThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGVDaDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dGVChuaDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInHoaDon);
            this.Name = "frmThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuaDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnKHChuaDong;
        private System.Windows.Forms.DataGridView dGVDaDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dGVChuaDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTienThang;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.Label label4;
    }
}