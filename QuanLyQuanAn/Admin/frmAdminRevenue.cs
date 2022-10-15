using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAdminRevenue : Form
    {
        public frmAdminRevenue()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            LoadDatTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, DtpkToDate.Value);
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            int n = 0;
            dgvViewRevenue.Rows.Clear();
            double total = 0;
            foreach (var item in (rm.USP_GetListBillByDate(checkIn, checkOut).ToList()))
            {
                n = dgvViewRevenue.Rows.Add();
                dgvViewRevenue.Rows[n].Cells[0].Value = item.idBill;
                dgvViewRevenue.Rows[n].Cells[1].Value = double.Parse(item.totalPrice.ToString().ToString()).ToString("#,###", culture.NumberFormat) + " đ";
                total += double.Parse(item.totalPrice.ToString());
                dgvViewRevenue.Rows[n].Cells[2].Value = item.discount;
                dgvViewRevenue.Rows[n].Cells[3].Value = item.dateCheckIn.ToString("MM/dd/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[n].Cells[4].Value = item.dateCheckOut == null ? item.dateCheckOut.ToString() : DateTime.Parse(item.dateCheckOut.ToString()).ToString("MM/dd/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[n].Cells[5].Value = item.payerId;

            }
            //CultureInfo culture = CultureInfo.CurrentCulture;
            string totalPrice = double.Parse(total.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
            lblTotalRevenue.Text = "Doanh thu: " + totalPrice;

            dgvViewRevenue.BorderStyle = BorderStyle.None;
            dgvViewRevenue.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvViewRevenue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvViewRevenue.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvViewRevenue.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvViewRevenue.BackgroundColor = Color.White;

            dgvViewRevenue.EnableHeadersVisualStyles = false;
            dgvViewRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvViewRevenue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvViewRevenue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadListAllBill()
        {
            int n = 0;
            dgvViewRevenue.Rows.Clear();
            foreach (var item in (from b in rm.Bills select b).ToList())
            {
                n = dgvViewRevenue.Rows.Add();
                dgvViewRevenue.Rows[n].Cells[0].Value = item.idBill;
                dgvViewRevenue.Rows[n].Cells[1].Value = item.totalPrice;
                dgvViewRevenue.Rows[n].Cells[2].Value = item.discount;
                dgvViewRevenue.Rows[n].Cells[3].Value = item.dateCheckIn.ToString("MM/dd/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[n].Cells[4].Value = item.dateCheckOut == null? item.dateCheckOut.ToString():  DateTime.Parse(item.dateCheckOut.ToString()).ToString("MM/dd/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[n].Cells[5].Value = item.payerId;
            }


            dgvViewRevenue.BorderStyle = BorderStyle.None;
            dgvViewRevenue.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvViewRevenue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvViewRevenue.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvViewRevenue.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvViewRevenue.BackgroundColor = Color.White;

            dgvViewRevenue.EnableHeadersVisualStyles = false;
            dgvViewRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvViewRevenue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvViewRevenue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadDatTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            DtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        
        void loadChart()
        {
            FoodChart.ChartAreas["ChartArea"].AxisY.Title = "Số món ăn đã bán";
            FoodChart.ChartAreas["ChartArea"].AxisX.Title = "Tên món ăn";
            FoodChart.ChartAreas["ChartArea"].AxisX.Interval = 1;
            FoodChart.Series["Số món ăn đã bán"].IsValueShownAsLabel = true;
            FoodChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            var dt = rm.USP_GetTopFood(dtpkFromDate.Value, DtpkToDate.Value).ToList();
            int n = 0;
            dgvFoodRevenue.Rows.Clear();
            foreach (var item in dt)
            {
                n = dgvFoodRevenue.Rows.Add();
                dgvFoodRevenue.Rows[n].Cells[0].Value = item.nameFood;
                dgvFoodRevenue.Rows[n].Cells[1].Value = item.countFood; 
                dgvFoodRevenue.Rows[n].Cells[2].Value = item.price; 
                dgvFoodRevenue.Rows[n].Cells[3].Value = item.totalPrice;
            }
            dgvFoodRevenue.BorderStyle = BorderStyle.None;
            dgvFoodRevenue.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodRevenue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodRevenue.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodRevenue.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodRevenue.BackgroundColor = Color.White;
            dgvFoodRevenue.EnableHeadersVisualStyles = false;
            dgvFoodRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodRevenue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodRevenue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            FoodChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            foreach (var series in FoodChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var item in dt)
            {
                FoodChart.Series["Số món ăn đã bán"].Points.AddXY(item.nameFood, item.countFood);
            }
        }
        #endregion
        #region Event
        private void rbtnToday_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = today.Date;
            DtpkToDate.Value = today.Date.AddDays(1);
        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, DtpkToDate.Value);
            loadChart();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form f = new Admin.frmRevenueReport(dtpkFromDate.Value, DtpkToDate.Value);
            f.ShowDialog();
        }

        private void DtpkToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, DtpkToDate.Value);
            loadChart();
        }


        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            DtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        private void dtpkFromDate_MouseUp(object sender, MouseEventArgs e)
        {
            rbtnViewByDate.Checked = true;
        }

        private void DtpkToDate_MouseUp(object sender, MouseEventArgs e)
        {
            rbtnViewByDate.Checked = true;
        }

        private void rbtnAllBill_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = DateTime.Parse("01/01/2020");
            LoadListAllBill();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, 1, 1);
            DtpkToDate.Value = dtpkFromDate.Value.AddYears(1).AddDays(-1);
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, DtpkToDate.Value);
        }
        #endregion

        
    }
}
