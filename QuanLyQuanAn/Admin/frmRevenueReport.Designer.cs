namespace QuanLyQuanAn.Admin
{
    partial class frmRevenueReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.quanLyQuanAnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillByDateBingdingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillByDateBingdingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportTopFood";
            reportDataSource1.Value = this.quanLyQuanAnDataSetBindingSource;
            reportDataSource2.Name = "Bill";
            reportDataSource2.Value = this.billBindingSource;
            reportDataSource3.Name = "BillByDate";
            reportDataSource3.Value = this.BillByDateBingdingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanAn.Admin.RevenueReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(QuanLyQuanAn.Database.Bill);
            // 
            // BillByDateBingdingSource
            // 
            this.BillByDateBingdingSource.DataSource = typeof(QuanLyQuanAn.Database.USP_GetListBillByDate_Result);
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRevenueReport";
            this.Text = "Thống kê doanh thu";
            //this.Load += new System.EventHandler(this.frmRevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillByDateBingdingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource quanLyQuanAnDataSetBindingSource;
        private System.Windows.Forms.BindingSource BillByDateBingdingSource;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}