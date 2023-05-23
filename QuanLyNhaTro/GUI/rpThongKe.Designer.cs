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
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1058, 584);
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
            // rpThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 639);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpThongKe";
            this.Text = "rpThongKe";
            this.Load += new System.EventHandler(this.rpThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeBindingSource;
        private QLNhaTroDataSet qLNhaTroDataSet;
    }
}