using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanAn.Admin
{
    public partial class frmAdmin : Form
    {
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        public frmAdmin()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadFoodChart();
            loadStaffChart();
            loadTableChart();
            loadTotal();
        }
        void loadFoodChart()
        {
            DateTime now = DateTime.Today;
            FoodChart.ChartAreas["ChartArea"].AxisY.Title = "Số món ăn đã bán";
            FoodChart.ChartAreas["ChartArea"].AxisX.Title = "Tên món ăn";
            FoodChart.ChartAreas["ChartArea"].AxisX.Interval = 1;
            FoodChart.Series["Số món ăn đã bán"].IsValueShownAsLabel = true;
            FoodChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            var dt = rm.USP_GetTopFood(now.Date, now.Date.AddDays(1)).ToList();
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
        void loadStaffChart()
        {
            int totalStaff = (from s in rm.Staffs select s).ToList().Count();
            int totalStaffCheckIn = rm.USP_GetTotalAttendanceList().ToList().Count();
            StaffChart.Palette = ChartColorPalette.None;
            StaffChart.PaletteCustomColors = new Color[] { Color.FromArgb(255, 192, 72), Color.FromArgb(11, 232, 129), Color.Yellow };
            StaffChart.Series["staff"].Points.AddXY("Đi làm", totalStaffCheckIn);
            StaffChart.Series["staff"].Points.AddXY("Vắng", totalStaff - totalStaffCheckIn);
            lblStaff.Text = totalStaffCheckIn.ToString() + "/" + totalStaff.ToString();
        }
        void loadTableChart()
        {
            int totalTable = (from s in rm.TableFoods select s).ToList().Count();
            int totalTableCheckIn = (from s in rm.TableFoods where s.statusTable.Contains("Có người") select s).ToList().Count();
            TableChart.Palette = ChartColorPalette.None;
            TableChart.PaletteCustomColors = new Color[] { Color.FromArgb(239, 87, 119), Color.FromArgb(87, 95, 207), Color.Yellow };
            TableChart.Series["table"].Points.AddXY("Có người", totalTableCheckIn);
            TableChart.Series["table"].Points.AddXY("Trống", totalTable - totalTableCheckIn);
            lblTable.Text = totalTableCheckIn.ToString() + "/" + totalTable.ToString();
        }
        void loadTotal()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            lblTotalFood.Text = (from s in rm.Foods select s).ToList().Count().ToString();
            lblTotalCategory.Text = (from s in rm.FoodCategories select s).ToList().Count().ToString();
            lblTotalBill.Text = rm.USP_GetTotalBillsInDay().ToList().Count().ToString();
            lblRevenue.Text = double.Parse(getRevenue().ToString()).ToString("#,###", culture.NumberFormat) + " đ";
        }

        public Double getRevenue()
        {
            var list = rm.USP_GetTotalBillsInDay().ToList();
            double total = 0;
            foreach (var item in list)
            {
                total += (Double)item.totalPrice;
            }
            return total;
        }
        #endregion
    }
}
