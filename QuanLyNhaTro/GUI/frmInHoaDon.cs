using Microsoft.Reporting.WinForms;
using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.GUI
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon(string IDKH)
        {
            InitializeComponent();
            idkh = IDKH;
            
        }
        private string idkh;
        Modify modify = new Modify();
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            
            DataTable table = modify.GetDataTable("select * from ThongKe where IDKhachHang='" + idkh + "' ");
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetHoaDon", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
      
    }
}
