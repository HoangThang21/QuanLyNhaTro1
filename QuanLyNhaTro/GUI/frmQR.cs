using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhaTro.GUI
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }
        private string Tienthu;
        public frmQR(String tenkh,String tienthu)
        {
            InitializeComponent();
            string tongtien=  String.Format("{0:0,00}", tienthu);
            Tienthu = "Tên khách hàng: "+tenkh+"\n Tổng tiền tháng này: "+ tongtien;
        }

        private void frmQR_Load(object sender, EventArgs e)
        {

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qRCodeGenerator.CreateQrCode(Tienthu, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(data);
            pictureBox1.Image = qRCode.GetGraphic(10);
        }
    }
}
