namespace QuanLyNhaTro.GUI
{
    partial class frmDoiMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKnew = new System.Windows.Forms.TextBox();
            this.txtmkxnNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoi = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(183, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(161, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(408, 33);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(341, 66);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(408, 105);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(341, 66);
            this.txtMKCu.TabIndex = 4;
            // 
            // txtMKnew
            // 
            this.txtMKnew.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKnew.Location = new System.Drawing.Point(408, 186);
            this.txtMKnew.Name = "txtMKnew";
            this.txtMKnew.PasswordChar = '*';
            this.txtMKnew.Size = new System.Drawing.Size(341, 66);
            this.txtMKnew.TabIndex = 5;
            // 
            // txtmkxnNew
            // 
            this.txtmkxnNew.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkxnNew.Location = new System.Drawing.Point(408, 275);
            this.txtmkxnNew.Name = "txtmkxnNew";
            this.txtmkxnNew.PasswordChar = '*';
            this.txtmkxnNew.Size = new System.Drawing.Size(341, 66);
            this.txtmkxnNew.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // btnDoi
            // 
            this.btnDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoi.Location = new System.Drawing.Point(62, 425);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(198, 65);
            this.btnDoi.TabIndex = 8;
            this.btnDoi.Text = "Đổi";
            this.btnDoi.UseVisualStyleBackColor = false;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(472, 425);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(207, 65);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Trở về";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.txtmkxnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKnew);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKnew;
        private System.Windows.Forms.TextBox txtmkxnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Button btnback;

    }
}