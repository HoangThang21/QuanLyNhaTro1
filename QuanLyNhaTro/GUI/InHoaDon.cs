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
            MessageBox.Show(idkh);

            this.reportViewer1.RefreshReport();
        }
    }
}
