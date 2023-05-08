using QuanLyNhaTro.ClassModle;
using QuanLyNhaTro.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaTro
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();

            this.chart1.Titles.Add("Danh sách Thu Tiền Theo Tháng");

            Series series = this.chart1.Series.Add("Tiền Thu");
           
            series.ChartType = SeriesChartType.Spline;

            using (SqlConnection sqlConnection = Connec.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("select * from ThongKe", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    series.Points.AddXY(dataReader.GetDateTime(3), dataReader.GetInt32(2));
                }
                sqlConnection.Close();
            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
