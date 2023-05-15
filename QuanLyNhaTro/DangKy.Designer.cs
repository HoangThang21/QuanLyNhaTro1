namespace QuanLyNhaTro
{
    partial class DangKy
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBNhanVien = new System.Windows.Forms.RadioButton();
            this.rBQuanLy = new System.Windows.Forms.RadioButton();
            this.txtXNMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuyDK = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(138, 145);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 29);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(126, 306);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 29);
            label4.TabIndex = 4;
            label4.Text = "Chức vụ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.rBNhanVien);
            this.panel2.Controls.Add(this.rBQuanLy);
            this.panel2.Controls.Add(this.txtXNMatKhau);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.txtTenTk);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 397);
            this.panel2.TabIndex = 1;
            // 
            // rBNhanVien
            // 
            this.rBNhanVien.AutoSize = true;
            this.rBNhanVien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNhanVien.Location = new System.Drawing.Point(486, 306);
            this.rBNhanVien.Name = "rBNhanVien";
            this.rBNhanVien.Size = new System.Drawing.Size(126, 29);
            this.rBNhanVien.TabIndex = 3;
            this.rBNhanVien.TabStop = true;
            this.rBNhanVien.Text = "Nhân viên";
            this.rBNhanVien.UseVisualStyleBackColor = true;
            this.rBNhanVien.CheckedChanged += new System.EventHandler(this.rBNhanVien_CheckedChanged);
            // 
            // rBQuanLy
            // 
            this.rBQuanLy.AutoSize = true;
            this.rBQuanLy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBQuanLy.Location = new System.Drawing.Point(268, 306);
            this.rBQuanLy.Name = "rBQuanLy";
            this.rBQuanLy.Size = new System.Drawing.Size(186, 29);
            this.rBQuanLy.TabIndex = 2;
            this.rBQuanLy.TabStop = true;
            this.rBQuanLy.Text = "Quản lý (Admin)";
            this.rBQuanLy.UseVisualStyleBackColor = true;
            this.rBQuanLy.CheckedChanged += new System.EventHandler(this.rBQuanLy_CheckedChanged);
            // 
            // txtXNMatKhau
            // 
            this.txtXNMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXNMatKhau.Location = new System.Drawing.Point(268, 228);
            this.txtXNMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXNMatKhau.Name = "txtXNMatKhau";
            this.txtXNMatKhau.PasswordChar = '*';
            this.txtXNMatKhau.Size = new System.Drawing.Size(344, 35);
            this.txtXNMatKhau.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(268, 129);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(344, 35);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtTenTk
            // 
            this.txtTenTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTk.Location = new System.Drawing.Point(268, 35);
            this.txtTenTk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(344, 35);
            this.txtTenTk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangKy);
            this.panel3.Controls.Add(this.btnHuyDK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 397);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 108);
            this.panel3.TabIndex = 2;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(320, 25);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(255, 63);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDK.Location = new System.Drawing.Point(44, 25);
            this.btnHuyDK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Size = new System.Drawing.Size(164, 63);
            this.btnHuyDK.TabIndex = 0;
            this.btnHuyDK.Text = "Hủy";
            this.btnHuyDK.UseVisualStyleBackColor = true;
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBNhanVien;
        private System.Windows.Forms.RadioButton rBQuanLy;
        private System.Windows.Forms.TextBox txtXNMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuyDK;
    }
}