namespace QuanLyNhaTro
{
    partial class QuanLyDienNuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbDienNuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dGVKH = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.txtMoi = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVDienNuoc = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaDN = new System.Windows.Forms.Button();
            this.btnDongDSP = new System.Windows.Forms.Button();
            this.btnCapNhatDn = new System.Windows.Forms.Button();
            this.btnThemDn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienNuoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại";
            // 
            // cbDienNuoc
            // 
            this.cbDienNuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDienNuoc.FormattingEnabled = true;
            this.cbDienNuoc.Items.AddRange(new object[] {
            "Điện",
            "Nước"});
            this.cbDienNuoc.Location = new System.Drawing.Point(806, 106);
            this.cbDienNuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDienNuoc.Name = "cbDienNuoc";
            this.cbDienNuoc.Size = new System.Drawing.Size(273, 37);
            this.cbDienNuoc.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 33);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cũ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(816, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 33);
            this.label5.TabIndex = 57;
            this.label5.Text = "Mới";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(460, 358);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(279, 37);
            this.txtGia.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 33);
            this.label7.TabIndex = 60;
            this.label7.Text = "Đơn Giá";
            // 
            // dGVKH
            // 
            this.dGVKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKH.Location = new System.Drawing.Point(49, 560);
            this.dGVKH.Name = "dGVKH";
            this.dGVKH.RowHeadersWidth = 62;
            this.dGVKH.RowTemplate.Height = 28;
            this.dGVKH.Size = new System.Drawing.Size(858, 360);
            this.dGVKH.TabIndex = 62;
            this.dGVKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKH_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 33);
            this.label8.TabIndex = 63;
            this.label8.Text = "Danh Sách Khách Hàng";
            // 
            // txtCu
            // 
            this.txtCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCu.Location = new System.Drawing.Point(455, 213);
            this.txtCu.Multiline = true;
            this.txtCu.Name = "txtCu";
            this.txtCu.Size = new System.Drawing.Size(279, 37);
            this.txtCu.TabIndex = 64;
            // 
            // txtMoi
            // 
            this.txtMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoi.Location = new System.Drawing.Point(813, 213);
            this.txtMoi.Multiline = true;
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.Size = new System.Drawing.Size(279, 37);
            this.txtMoi.TabIndex = 65;
            // 
            // txtKH
            // 
            this.txtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(455, 104);
            this.txtKH.Multiline = true;
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(279, 37);
            this.txtKH.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1019, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 33);
            this.label6.TabIndex = 69;
            this.label6.Text = "Danh Sách Điện Nước Từng Khách Hàng";
            // 
            // dGVDienNuoc
            // 
            this.dGVDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienNuoc.Location = new System.Drawing.Point(1025, 560);
            this.dGVDienNuoc.Name = "dGVDienNuoc";
            this.dGVDienNuoc.RowHeadersWidth = 62;
            this.dGVDienNuoc.RowTemplate.Height = 28;
            this.dGVDienNuoc.Size = new System.Drawing.Size(858, 360);
            this.dGVDienNuoc.TabIndex = 68;
            this.dGVDienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDienNuoc_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaDN);
            this.groupBox3.Controls.Add(this.btnDongDSP);
            this.groupBox3.Controls.Add(this.btnCapNhatDn);
            this.groupBox3.Controls.Add(this.btnThemDn);
            this.groupBox3.Location = new System.Drawing.Point(1157, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(691, 215);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaDN
            // 
            this.btnXoaDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDN.ImageIndex = 2;
            this.btnXoaDN.Location = new System.Drawing.Point(27, 110);
            this.btnXoaDN.Name = "btnXoaDN";
            this.btnXoaDN.Size = new System.Drawing.Size(310, 52);
            this.btnXoaDN.TabIndex = 28;
            this.btnXoaDN.Text = "Xóa Điện Nước";
            this.btnXoaDN.UseVisualStyleBackColor = true;
            this.btnXoaDN.Click += new System.EventHandler(this.btnXoaDN_Click);
            // 
            // btnDongDSP
            // 
            this.btnDongDSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongDSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongDSP.ImageIndex = 0;
            this.btnDongDSP.Location = new System.Drawing.Point(376, 108);
            this.btnDongDSP.Name = "btnDongDSP";
            this.btnDongDSP.Size = new System.Drawing.Size(297, 54);
            this.btnDongDSP.TabIndex = 30;
            this.btnDongDSP.Text = "Đóng Danh Sách ";
            this.btnDongDSP.UseVisualStyleBackColor = true;
            this.btnDongDSP.Click += new System.EventHandler(this.btnDongDSP_Click);
            // 
            // btnCapNhatDn
            // 
            this.btnCapNhatDn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDn.ImageIndex = 7;
            this.btnCapNhatDn.Location = new System.Drawing.Point(376, 28);
            this.btnCapNhatDn.Name = "btnCapNhatDn";
            this.btnCapNhatDn.Size = new System.Drawing.Size(297, 52);
            this.btnCapNhatDn.TabIndex = 26;
            this.btnCapNhatDn.Text = "Cập Nhật Điện Nước";
            this.btnCapNhatDn.UseVisualStyleBackColor = true;
            this.btnCapNhatDn.Click += new System.EventHandler(this.btnCapNhatDn_Click);
            // 
            // btnThemDn
            // 
            this.btnThemDn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDn.ImageIndex = 6;
            this.btnThemDn.Location = new System.Drawing.Point(27, 28);
            this.btnThemDn.Name = "btnThemDn";
            this.btnThemDn.Size = new System.Drawing.Size(310, 52);
            this.btnThemDn.TabIndex = 27;
            this.btnThemDn.Text = "Thêm Điện Nước";
            this.btnThemDn.UseVisualStyleBackColor = true;
            this.btnThemDn.Click += new System.EventHandler(this.btnThemDn_Click);
            // 
            // QuanLyDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGVDienNuoc);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.txtCu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dGVKH);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDienNuoc);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyDienNuoc";
            this.Text = "Quản Lý Điện Nước";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienNuoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDienNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dGVKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.TextBox txtMoi;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGVDienNuoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaDN;
        private System.Windows.Forms.Button btnDongDSP;
        private System.Windows.Forms.Button btnCapNhatDn;
        private System.Windows.Forms.Button btnThemDn;
    }
}