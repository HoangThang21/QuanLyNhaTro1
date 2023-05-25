namespace QuanLyNhaTro
{
    partial class ThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGVChuaDong = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dGVDaDong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnKHChuaDong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuaDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Khách Hàng Chưa Đóng Tiền";
            // 
            // dGVChuaDong
            // 
            this.dGVChuaDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChuaDong.Location = new System.Drawing.Point(38, 103);
            this.dGVChuaDong.Name = "dGVChuaDong";
            this.dGVChuaDong.RowHeadersWidth = 62;
            this.dGVChuaDong.RowTemplate.Height = 28;
            this.dGVChuaDong.Size = new System.Drawing.Size(934, 361);
            this.dGVChuaDong.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1206, 229);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(304, 74);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dGVDaDong
            // 
            this.dGVDaDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDaDong.Location = new System.Drawing.Point(38, 538);
            this.dGVDaDong.Name = "dGVDaDong";
            this.dGVDaDong.RowHeadersWidth = 62;
            this.dGVDaDong.RowTemplate.Height = 28;
            this.dGVDaDong.Size = new System.Drawing.Size(934, 389);
            this.dGVDaDong.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh Sách Khách Hàng Đã Đóng Tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTroLai);
            this.groupBox1.Controls.Add(this.btnKHChuaDong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1131, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 186);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng tìm kiếm khách hàng";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(33, 121);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(278, 59);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Reset";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnKHChuaDong
            // 
            this.btnKHChuaDong.Location = new System.Drawing.Point(33, 40);
            this.btnKHChuaDong.Name = "btnKHChuaDong";
            this.btnKHChuaDong.Size = new System.Drawing.Size(514, 65);
            this.btnKHChuaDong.TabIndex = 2;
            this.btnKHChuaDong.Text = "Tìm kiếm Khách Hàng Chưa Đóng Tiền";
            this.btnKHChuaDong.UseVisualStyleBackColor = true;
            this.btnKHChuaDong.Click += new System.EventHandler(this.btnKHChuaDong_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1206, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 74);
            this.button2.TabIndex = 14;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Location = new System.Drawing.Point(1164, 853);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(304, 74);
            this.btnInHoaDon.TabIndex = 15;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 1038);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGVDaDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dGVChuaDong);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuaDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVChuaDong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dGVDaDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKHChuaDong;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}