namespace QuanLyNhaTro.GUI
{
    partial class FrmReportKhachHangOTro
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpout = new System.Windows.Forms.DateTimePicker();
            this.dtpin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1925, 886);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1564, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(238, 67);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpout
            // 
            this.dtpout.CustomFormat = "yyyy/MM/dd";
            this.dtpout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpout.Location = new System.Drawing.Point(1061, 29);
            this.dtpout.Name = "dtpout";
            this.dtpout.Size = new System.Drawing.Size(287, 39);
            this.dtpout.TabIndex = 9;
            // 
            // dtpin
            // 
            this.dtpin.CustomFormat = "yyyy/MM/dd";
            this.dtpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpin.Location = new System.Drawing.Point(440, 29);
            this.dtpin.Name = "dtpin";
            this.dtpin.Size = new System.Drawing.Size(273, 39);
            this.dtpin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(908, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Ngày";
            // 
            // FrmReportKhachHangOTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpout);
            this.Controls.Add(this.dtpin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportKhachHangOTro";
            this.Text = "FrmReportKhachHangOTro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportKhachHangOTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpout;
        private System.Windows.Forms.DateTimePicker dtpin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}