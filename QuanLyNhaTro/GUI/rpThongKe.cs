using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.ClassModle;

namespace QuanLyNhaTro.GUI
{
    public partial class rpThongKe : Form
    {
        public rpThongKe()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void rpThongKe_Load(object sender, EventArgs e)
        {
            DataTable table = modify.GetDataTable("select * from ThongKe ");
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet_ThongKe", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable table = modify.GetDataTable("select * from ThongKe where NgayThu >='"+dtpin.Text+"' and NgayThu <= '"+dtpout.Text+"'");
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet_ThongKe", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
