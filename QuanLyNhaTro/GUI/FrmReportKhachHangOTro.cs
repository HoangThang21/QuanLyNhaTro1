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
    public partial class FrmReportKhachHangOTro : Form
    {
        public FrmReportKhachHangOTro()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void FrmReportKhachHangOTro_Load(object sender, EventArgs e)
        {
            DataTable table = modify.GetDataTable("select * from Phong p , ThuePhong tp, KhachHang kh, DienNuoc dn, DichVu dv where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and  dn.IDDV=dv.IDDV and dn.IDKH=kh.IDKH");
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSetPhong", table);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSetThuePhong", table);
            ReportDataSource reportDataSource3 = new ReportDataSource("DataSetKhachHang", table);
            ReportDataSource reportDataSource4 = new ReportDataSource("DataSetDienNuoc", table);
            ReportDataSource reportDataSource5 = new ReportDataSource("DataSetDichVu", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource5);

            this.reportViewer1.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable table = modify.GetDataTable("select * from Phong p , ThuePhong tp, KhachHang kh, DienNuoc dn, DichVu dv where tp.IDKH=kh.IDKH and tp.IDPhong=p.IDPhong and  dn.IDDV=dv.IDDV and dn.IDKH=kh.IDKH and tp.NgayTraPhong >='"+dtpin.Text+"' and tp.NgayTraPhong <= '"+dtpout.Text+"'");
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSetPhong", table);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSetThuePhong", table);
            ReportDataSource reportDataSource3 = new ReportDataSource("DataSetKhachHang", table);
            ReportDataSource reportDataSource4 = new ReportDataSource("DataSetDienNuoc", table);
            ReportDataSource reportDataSource5 = new ReportDataSource("DataSetDichVu", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource5);

            this.reportViewer1.RefreshReport();
        }
    }
}
