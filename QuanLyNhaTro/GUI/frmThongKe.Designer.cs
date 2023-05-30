namespace QuanLyNhaTro.GUI
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpmoi = new System.Windows.Forms.DateTimePicker();
            this.dtpcu = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTongHoaDon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelTongTienKhachHangNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labeltienthu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeltxtthang = new System.Windows.Forms.Label();
            this.labelthang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnTìm = new FontAwesome.Sharp.IconButton();
            this.btn30day = new FontAwesome.Sharp.IconButton();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpmoi
            // 
            this.dtpmoi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(151)))));
            this.dtpmoi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dtpmoi.CustomFormat = "yyyy/MM/dd";
            this.dtpmoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmoi.Location = new System.Drawing.Point(388, 13);
            this.dtpmoi.Name = "dtpmoi";
            this.dtpmoi.Size = new System.Drawing.Size(200, 39);
            this.dtpmoi.TabIndex = 6;
            this.dtpmoi.ValueChanged += new System.EventHandler(this.dtpmoi_ValueChanged);
            // 
            // dtpcu
            // 
            this.dtpcu.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(151)))));
            this.dtpcu.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dtpcu.CustomFormat = "yyyy/MM/dd";
            this.dtpcu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcu.Location = new System.Drawing.Point(164, 13);
            this.dtpcu.Name = "dtpcu";
            this.dtpcu.Size = new System.Drawing.Size(200, 39);
            this.dtpcu.TabIndex = 5;
            this.dtpcu.ValueChanged += new System.EventHandler(this.dtpcu_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.labelTongHoaDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 96);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.rating;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(25, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 45);
            this.panel5.TabIndex = 2;
            // 
            // labelTongHoaDon
            // 
            this.labelTongHoaDon.AutoSize = true;
            this.labelTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongHoaDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTongHoaDon.Location = new System.Drawing.Point(108, 41);
            this.labelTongHoaDon.Name = "labelTongHoaDon";
            this.labelTongHoaDon.Size = new System.Drawing.Size(54, 45);
            this.labelTongHoaDon.TabIndex = 1;
            this.labelTongHoaDon.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.labelTongTienKhachHangNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(409, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 96);
            this.panel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.salary;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(25, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(48, 45);
            this.panel6.TabIndex = 3;
            // 
            // labelTongTienKhachHangNo
            // 
            this.labelTongTienKhachHangNo.AutoSize = true;
            this.labelTongTienKhachHangNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTienKhachHangNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTongTienKhachHangNo.Location = new System.Drawing.Point(108, 41);
            this.labelTongTienKhachHangNo.Name = "labelTongTienKhachHangNo";
            this.labelTongTienKhachHangNo.Size = new System.Drawing.Size(54, 45);
            this.labelTongTienKhachHangNo.TabIndex = 1;
            this.labelTongTienKhachHangNo.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền khách hàng còn nợ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.labeltienthu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(988, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 96);
            this.panel3.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.coins;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(25, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(48, 45);
            this.panel7.TabIndex = 4;
            // 
            // labeltienthu
            // 
            this.labeltienthu.AutoSize = true;
            this.labeltienthu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltienthu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labeltienthu.Location = new System.Drawing.Point(108, 41);
            this.labeltienthu.Name = "labeltienthu";
            this.labeltienthu.Size = new System.Drawing.Size(54, 45);
            this.labeltienthu.TabIndex = 1;
            this.labeltienthu.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền đã thu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel4.Controls.Add(this.labeltxtthang);
            this.panel4.Controls.Add(this.labelthang);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.labelTongDoanhThu);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(32, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 354);
            this.panel4.TabIndex = 13;
            // 
            // labeltxtthang
            // 
            this.labeltxtthang.AutoSize = true;
            this.labeltxtthang.Location = new System.Drawing.Point(19, 145);
            this.labeltxtthang.Name = "labeltxtthang";
            this.labeltxtthang.Size = new System.Drawing.Size(190, 32);
            this.labeltxtthang.TabIndex = 4;
            this.labeltxtthang.Text = "Tổng Doanh thu";
            // 
            // labelthang
            // 
            this.labelthang.AutoSize = true;
            this.labelthang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthang.ForeColor = System.Drawing.Color.White;
            this.labelthang.Location = new System.Drawing.Point(102, 187);
            this.labelthang.Name = "labelthang";
            this.labelthang.Size = new System.Drawing.Size(54, 45);
            this.labelthang.TabIndex = 3;
            this.labelthang.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tổng Doanh thu";
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.ForeColor = System.Drawing.Color.White;
            this.labelTongDoanhThu.Location = new System.Drawing.Point(102, 85);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(54, 45);
            this.labelTongDoanhThu.TabIndex = 1;
            this.labelTongDoanhThu.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doanh thu";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(480, 514);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 62;
            this.dgvThongKe.RowTemplate.Height = 28;
            this.dgvThongKe.Size = new System.Drawing.Size(825, 354);
            this.dgvThongKe.TabIndex = 16;
            // 
            // labelEnd
            // 
            this.labelEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnd.Location = new System.Drawing.Point(382, 13);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(209, 39);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "2023/05/28";
            this.labelEnd.Click += new System.EventHandler(this.labelEnd_Click);
            // 
            // labelStart
            // 
            this.labelStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStart.Location = new System.Drawing.Point(158, 13);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(209, 42);
            this.labelStart.TabIndex = 18;
            this.labelStart.Text = "2023/05/28";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(921, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(208, 53);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTìm
            // 
            this.btnTìm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnTìm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.btnTìm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTìm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTìm.IconColor = System.Drawing.Color.Black;
            this.btnTìm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTìm.Location = new System.Drawing.Point(707, 13);
            this.btnTìm.Name = "btnTìm";
            this.btnTìm.Size = new System.Drawing.Size(208, 53);
            this.btnTìm.TabIndex = 17;
            this.btnTìm.Text = "Tìm";
            this.btnTìm.UseVisualStyleBackColor = false;
            this.btnTìm.Click += new System.EventHandler(this.btnTìm_Click);
            // 
            // btn30day
            // 
            this.btn30day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btn30day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.btn30day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30day.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn30day.IconColor = System.Drawing.Color.Black;
            this.btn30day.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn30day.Location = new System.Drawing.Point(1349, 13);
            this.btn30day.Name = "btn30day";
            this.btn30day.Size = new System.Drawing.Size(208, 53);
            this.btn30day.TabIndex = 11;
            this.btn30day.Text = "Month";
            this.btn30day.UseVisualStyleBackColor = false;
            this.btn30day.Click += new System.EventHandler(this.btn30day_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToday.IconColor = System.Drawing.Color.Black;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.Location = new System.Drawing.Point(1135, 14);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(208, 53);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.seo_report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.Location = new System.Drawing.Point(1373, 525);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(106, 99);
            this.btnReport.TabIndex = 20;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // chartThongKe
            // 
            this.chartThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.chartThongKe.BackSecondaryColor = System.Drawing.Color.White;
            this.chartThongKe.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineWidth = 5;
            chartArea1.AxisX.MajorTickMark.Size = 3F;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LabelStyle.Format = "${0:0,}K";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = "Tổng tiền";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(32, 188);
            this.chartThongKe.Name = "chartThongKe";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.Legend = "Tổng tiền";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Tổng tiền";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.Legend = "Tổng tiền";
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Tiền nợ";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Series.Add(series2);
            this.chartThongKe.Size = new System.Drawing.Size(1511, 300);
            this.chartThongKe.TabIndex = 21;
            this.chartThongKe.Text = "chartThongKe";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            title1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Title1";
            title1.Text = "Statistic";
            this.chartThongKe.Titles.Add(title1);
            // 
            // frmThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1569, 902);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.btnTìm);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn30day);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.dtpmoi);
            this.Controls.Add(this.dtpcu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.MinimumSize = new System.Drawing.Size(1591, 958);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpmoi;
        private System.Windows.Forms.DateTimePicker dtpcu;
        private FontAwesome.Sharp.IconButton btnToday;
        private FontAwesome.Sharp.IconButton btn30day;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTongHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTongTienKhachHangNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labeltienthu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTongDoanhThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private FontAwesome.Sharp.IconButton btnTìm;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labeltxtthang;
        private System.Windows.Forms.Label labelthang;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}