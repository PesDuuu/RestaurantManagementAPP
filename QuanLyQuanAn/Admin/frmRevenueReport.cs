using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyQuanAn.Database;

namespace QuanLyQuanAn.Admin
{
    public partial class frmRevenueReport : Form
    {
       /*public string x = "";
        public frmRevenueReport(DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            load(checkIn, checkOut);
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            //  Load data vào Bill

            this.reportViewer1.RefreshReport();
        }

        void load(DateTime checkIn, DateTime checkOut)
        {
            using (QuanLyQuanAnEntities db = new QuanLyQuanAnEntities())
            {
                quanLyQuanAnDataSetBindingSource.DataSource = db.USP_GetTopFood(checkIn, checkOut).ToList();
                billBindingSource.DataSource = db.Bills.ToList();
                BillByDateBingdingSource.DataSource = db.USP_GetListBillByDate(checkIn, checkOut);
                ReportParameter[] parameter = new ReportParameter[2]; 
                parameter[0] = new ReportParameter("fromDate");
                parameter[0].Values.Add(checkIn.ToString().Split(' ')[0]); 
                parameter[1] = new ReportParameter("toDate");
                parameter[1].Values.Add(checkOut.ToString().Split(' ')[0]); 
                reportViewer1.LocalReport.SetParameters(parameter);
                reportViewer1.Refresh();
            }
        }*/

    }
}
