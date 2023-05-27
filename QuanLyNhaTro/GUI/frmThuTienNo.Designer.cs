namespace QuanLyNhaTro.GUI
{
    partial class frmThuTienNo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttienthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThu = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.exit1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(995, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 46);
            this.panel1.TabIndex = 52;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(259, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(422, 66);
            this.txtHoTen.TabIndex = 53;
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(259, 119);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(422, 66);
            this.txttongtien.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tổng tiền:";
            // 
            // txttienthu
            // 
            this.txttienthu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttienthu.Location = new System.Drawing.Point(259, 205);
            this.txttienthu.Name = "txttienthu";
            this.txttienthu.Size = new System.Drawing.Size(422, 66);
            this.txttienthu.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 45);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tiền thu:";
            // 
            // btnThu
            // 
            this.btnThu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThu.IconColor = System.Drawing.Color.Black;
            this.btnThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThu.Location = new System.Drawing.Point(860, 364);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(172, 73);
            this.btnThu.TabIndex = 58;
            this.btnThu.Text = "Thu";
            this.btnThu.UseVisualStyleBackColor = true;
            this.btnThu.Click += new System.EventHandler(this.btnThu_Click);
            // 
            // frmThuTienNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1044, 438);
            this.Controls.Add(this.btnThu);
            this.Controls.Add(this.txttienthu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmThuTienNo";
            this.Text = "frmThuTienNo";
            this.Load += new System.EventHandler(this.frmThuTienNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttienthu;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnThu;
    }
}