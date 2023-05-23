namespace QuanLyNhaTro.GUI
{
    partial class rpThongKe
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaTroDataSet = new QuanLyNhaTro.QLNhaTroDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpin = new System.Windows.Forms.DateTimePicker();
            this.dtpout = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1058, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeBindingSource
            // 
            this.ThongKeBindingSource.DataSource = this.qLNhaTroDataSet;
            this.ThongKeBindingSource.Position = 0;
            // 
            // qLNhaTroDataSet
            // 
            this.qLNhaTroDataSet.DataSetName = "QLNhaTroDataSet";
            this.qLNhaTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // dtpin
            // 
            this.dtpin.CustomFormat = "yyyy/MM/dd";
            this.dtpin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpin.Location = new System.Drawing.Point(107, 22);
            this.dtpin.Name = "dtpin";
            this.dtpin.Size = new System.Drawing.Size(200, 26);
            this.dtpin.TabIndex = 3;
            // 
            // dtpout
            // 
            this.dtpout.CustomFormat = "yyyy/MM/dd";
            this.dtpout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpout.Location = new System.Drawing.Point(427, 21);
            this.dtpout.Name = "dtpout";
            this.dtpout.Size = new System.Drawing.Size(200, 26);
            this.dtpout.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(763, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(199, 30);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rpThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 639);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpout);
            this.Controls.Add(this.dtpin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpThongKe";
            this.Text = "rpThongKe";
            this.Load += new System.EventHandler(this.rpThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeBindingSource;
        private QLNhaTroDataSet qLNhaTroDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpin;
        private System.Windows.Forms.DateTimePicker dtpout;
        private System.Windows.Forms.Button btnTim;
    }
}