using Microsoft.Reporting.WinForms;
using QuanLyNhaTro.ClassModle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.ClassModle;

namespace QuanLyNhaTro.GUI
{
    public partial class InHoaDon : Form
    {
        private string idkh;
        public InHoaDon(string IDKH)
        {
            InitializeComponent();
            idkh = IDKH;
        }
        Modify modify = new Modify();
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            DataTable table = modify.GetDataTable("select * from ThongKe where IDKhachHang='"+idkh+"' ");
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetHoaDon", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
