namespace QuanLyQuanAn
{
    partial class frmAdminRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvViewRevenue = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBillStatistical = new System.Windows.Forms.Panel();
            this.lblBillStatistical = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnViewByDate = new System.Windows.Forms.RadioButton();
            this.rbtnViewAll = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnToday = new System.Windows.Forms.RadioButton();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.DtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.FoodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvFoodRevenue = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.lblTopFoodChart = new System.Windows.Forms.Label();
            this.pnTotalRevenue = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).BeginInit();
            this.pnBillStatistical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).BeginInit();
            this.pnTotalRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewRevenue
            // 
            this.dgvViewRevenue.AllowUserToAddRows = false;
            this.dgvViewRevenue.AllowUserToDeleteRows = false;
            this.dgvViewRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewRevenue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewRevenue.Location = new System.Drawing.Point(12, 43);
            this.dgvViewRevenue.Name = "dgvViewRevenue";
            this.dgvViewRevenue.ReadOnly = true;
            this.dgvViewRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewRevenue.Size = new System.Drawing.Size(842, 311);
            this.dgvViewRevenue.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giảm giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày vào";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày ra";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NV thanh toán";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pnBillStatistical
            // 
            this.pnBillStatistical.BackColor = System.Drawing.Color.DimGray;
            this.pnBillStatistical.Controls.Add(this.lblBillStatistical);
            this.pnBillStatistical.Controls.Add(this.lblToDate);
            this.pnBillStatistical.Controls.Add(this.lblFromDate);
            this.pnBillStatistical.Controls.Add(this.rbtnYear);
            this.pnBillStatistical.Controls.Add(this.rbtnViewByDate);
            this.pnBillStatistical.Controls.Add(this.rbtnViewAll);
            this.pnBillStatistical.Controls.Add(this.rbtnMonth);
            this.pnBillStatistical.Controls.Add(this.rbtnToday);
            this.pnBillStatistical.Controls.Add(this.dtpkFromDate);
            this.pnBillStatistical.Controls.Add(this.DtpkToDate);
            this.pnBillStatistical.Location = new System.Drawing.Point(860, 12);
            this.pnBillStatistical.Name = "pnBillStatistical";
            this.pnBillStatistical.Size = new System.Drawing.Size(283, 616);
            this.pnBillStatistical.TabIndex = 10;
            // 
            // lblBillStatistical
            // 
            this.lblBillStatistical.AutoSize = true;
            this.lblBillStatistical.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBillStatistical.ForeColor = System.Drawing.Color.White;
            this.lblBillStatistical.Location = new System.Drawing.Point(3, -3);
            this.lblBillStatistical.Name = "lblBillStatistical";
            this.lblBillStatistical.Size = new System.Drawing.Size(234, 32);
            this.lblBillStatistical.TabIndex = 1;
            this.lblBillStatistical.Text = "Thống kê hóa đơn";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(21, 386);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 22);
            this.lblToDate.TabIndex = 15;
            this.lblToDate.Text = "Đến:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(21, 330);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(40, 22);
            this.lblFromDate.TabIndex = 15;
            this.lblFromDate.Text = "Từ:";
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.White;
            this.rbtnYear.Location = new System.Drawing.Point(29, 156);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(68, 26);
            this.rbtnYear.TabIndex = 4;
            this.rbtnYear.Text = "Năm";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // rbtnViewByDate
            // 
            this.rbtnViewByDate.AutoSize = true;
            this.rbtnViewByDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewByDate.ForeColor = System.Drawing.Color.White;
            this.rbtnViewByDate.Location = new System.Drawing.Point(29, 266);
            this.rbtnViewByDate.Name = "rbtnViewByDate";
            this.rbtnViewByDate.Size = new System.Drawing.Size(154, 26);
            this.rbtnViewByDate.TabIndex = 6;
            this.rbtnViewByDate.Text = "Xem theo ngày";
            this.rbtnViewByDate.UseVisualStyleBackColor = true;
            // 
            // rbtnViewAll
            // 
            this.rbtnViewAll.AutoSize = true;
            this.rbtnViewAll.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewAll.ForeColor = System.Drawing.Color.White;
            this.rbtnViewAll.Location = new System.Drawing.Point(29, 211);
            this.rbtnViewAll.Name = "rbtnViewAll";
            this.rbtnViewAll.Size = new System.Drawing.Size(118, 26);
            this.rbtnViewAll.TabIndex = 5;
            this.rbtnViewAll.Text = "Xem tất cả";
            this.rbtnViewAll.UseVisualStyleBackColor = true;
            this.rbtnViewAll.CheckedChanged += new System.EventHandler(this.rbtnAllBill_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Checked = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.White;
            this.rbtnMonth.Location = new System.Drawing.Point(29, 97);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(82, 26);
            this.rbtnMonth.TabIndex = 3;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Tháng";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnToday
            // 
            this.rbtnToday.AutoSize = true;
            this.rbtnToday.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnToday.ForeColor = System.Drawing.Color.White;
            this.rbtnToday.Location = new System.Drawing.Point(29, 47);
            this.rbtnToday.Name = "rbtnToday";
            this.rbtnToday.Size = new System.Drawing.Size(104, 26);
            this.rbtnToday.TabIndex = 2;
            this.rbtnToday.Text = "Hôm nay";
            this.rbtnToday.UseVisualStyleBackColor = true;
            this.rbtnToday.CheckedChanged += new System.EventHandler(this.rbtnToday_CheckedChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(91, 324);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(173, 30);
            this.dtpkFromDate.TabIndex = 7;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            this.dtpkFromDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpkFromDate_MouseUp);
            // 
            // DtpkToDate
            // 
            this.DtpkToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpkToDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpkToDate.Location = new System.Drawing.Point(91, 380);
            this.DtpkToDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtpkToDate.Name = "DtpkToDate";
            this.DtpkToDate.Size = new System.Drawing.Size(173, 30);
            this.DtpkToDate.TabIndex = 8;
            this.DtpkToDate.Value = new System.DateTime(2020, 12, 21, 12, 30, 40, 0);
            this.DtpkToDate.ValueChanged += new System.EventHandler(this.DtpkToDate_ValueChanged);
            this.DtpkToDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DtpkToDate_MouseUp);
            // 
            // FoodChart
            // 
            chartArea1.Name = "ChartArea";
            this.FoodChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FoodChart.Legends.Add(legend1);
            this.FoodChart.Location = new System.Drawing.Point(13, 392);
            this.FoodChart.Name = "FoodChart";
            this.FoodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "FoodName";
            series2.ChartArea = "ChartArea";
            series2.Legend = "Legend1";
            series2.Name = "Số món ăn đã bán";
            this.FoodChart.Series.Add(series1);
            this.FoodChart.Series.Add(series2);
            this.FoodChart.Size = new System.Drawing.Size(435, 236);
            this.FoodChart.TabIndex = 11;
            this.FoodChart.Text = "chart1";
            // 
            // dgvFoodRevenue
            // 
            this.dgvFoodRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvFoodRevenue.Location = new System.Drawing.Point(454, 392);
            this.dgvFoodRevenue.Name = "dgvFoodRevenue";
            this.dgvFoodRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodRevenue.Size = new System.Drawing.Size(400, 236);
            this.dgvFoodRevenue.TabIndex = 10;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên món";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số lượng";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giá";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Doanh thu";
            this.Column10.Name = "Column10";
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.AutoSize = true;
            this.lblFoodRevenue.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblFoodRevenue.Location = new System.Drawing.Point(448, 357);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(239, 32);
            this.lblFoodRevenue.TabIndex = 23;
            this.lblFoodRevenue.Text = "Doanh thu món ăn";
            // 
            // lblTopFoodChart
            // 
            this.lblTopFoodChart.AutoSize = true;
            this.lblTopFoodChart.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTopFoodChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblTopFoodChart.Location = new System.Drawing.Point(6, 357);
            this.lblTopFoodChart.Name = "lblTopFoodChart";
            this.lblTopFoodChart.Size = new System.Drawing.Size(394, 32);
            this.lblTopFoodChart.TabIndex = 23;
            this.lblTopFoodChart.Text = "Biểu đồ món ăn bán nhiều nhất";
            // 
            // pnTotalRevenue
            // 
            this.pnTotalRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnTotalRevenue.Location = new System.Drawing.Point(12, 9);
            this.pnTotalRevenue.Name = "pnTotalRevenue";
            this.pnTotalRevenue.Size = new System.Drawing.Size(842, 28);
            this.pnTotalRevenue.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(3, 5);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(92, 19);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Doanh thu:";
            // 
            // frmAdminRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.pnTotalRevenue);
            this.Controls.Add(this.lblTopFoodChart);
            this.Controls.Add(this.lblFoodRevenue);
            this.Controls.Add(this.dgvFoodRevenue);
            this.Controls.Add(this.FoodChart);
            this.Controls.Add(this.pnBillStatistical);
            this.Controls.Add(this.dgvViewRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminRevenue";
            this.Text = "Quản lý doanh thu ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).EndInit();
            this.pnBillStatistical.ResumeLayout(false);
            this.pnBillStatistical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).EndInit();
            this.pnTotalRevenue.ResumeLayout(false);
            this.pnTotalRevenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewRevenue;
        private System.Windows.Forms.Panel pnBillStatistical;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker DtpkToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RadioButton rbtnViewByDate;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnToday;
        private System.Windows.Forms.Label lblBillStatistical;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart FoodChart;
        private System.Windows.Forms.DataGridView dgvFoodRevenue;
        private System.Windows.Forms.Label lblFoodRevenue;
        private System.Windows.Forms.Label lblTopFoodChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel pnTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}