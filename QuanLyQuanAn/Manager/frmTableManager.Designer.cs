using System.Drawing;

namespace QuanLyQuanAn
{
    partial class frmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.lblBill = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.nmCountFood = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.pnlTableManager = new System.Windows.Forms.Panel();
            this.pnlAddFood = new System.Windows.Forms.Panel();
            this.pnlNameFood = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.pnlBillName = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlListTable = new System.Windows.Forms.Panel();
            this.pnlShowListTable = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTableListName = new System.Windows.Forms.Panel();
            this.pbReloadTable = new FontAwesome.Sharp.IconPictureBox();
            this.lbTableFoodList = new System.Windows.Forms.Label();
            this.pddHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pdHoaDon = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.pnlTableManager.SuspendLayout();
            this.pnlAddFood.SuspendLayout();
            this.pnlNameFood.SuspendLayout();
            this.pnlHoaDon.SuspendLayout();
            this.pnlBillName.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.pnlListTable.SuspendLayout();
            this.pnlShowListTable.SuspendLayout();
            this.pnlTableListName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.DimGray;
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBill.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBill.Location = new System.Drawing.Point(0, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(359, 57);
            this.lblBill.TabIndex = 3;
            this.lblBill.Text = "HÓA ĐƠN";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(14, 367);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(283, 23);
            this.lblFoodPrice.TabIndex = 8;
            this.lblFoodPrice.Text = "0 đ";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(32, 123);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(248, 227);
            this.pbFood.TabIndex = 6;
            this.pbFood.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(58, 395);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(93, 22);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Số lượng:";
            // 
            // nmCountFood
            // 
            this.nmCountFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFood.Location = new System.Drawing.Point(175, 393);
            this.nmCountFood.Margin = new System.Windows.Forms.Padding(2);
            this.nmCountFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCountFood.Name = "nmCountFood";
            this.nmCountFood.Size = new System.Drawing.Size(39, 30);
            this.nmCountFood.TabIndex = 2;
            this.nmCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(48, 76);
            this.cbFood.Margin = new System.Windows.Forms.Padding(2);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(215, 27);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(80, 440);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(164, 50);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(48, 20);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(215, 27);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.LabelEdit = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 57);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(359, 421);
            this.lsvBill.TabIndex = 1;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 110;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.nmGiamGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 74);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giảm giá";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(6, 15);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(156, 39);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(227, 14);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 41);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGiamGia.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmGiamGia.Location = new System.Drawing.Point(170, 24);
            this.nmGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(53, 30);
            this.nmGiamGia.TabIndex = 4;
            // 
            // pnlTableManager
            // 
            this.pnlTableManager.Controls.Add(this.pnlAddFood);
            this.pnlTableManager.Controls.Add(this.pnlNameFood);
            this.pnlTableManager.Controls.Add(this.pnlHoaDon);
            this.pnlTableManager.Controls.Add(this.pnlTable);
            this.pnlTableManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableManager.Location = new System.Drawing.Point(0, 0);
            this.pnlTableManager.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTableManager.Name = "pnlTableManager";
            this.pnlTableManager.Size = new System.Drawing.Size(1151, 552);
            this.pnlTableManager.TabIndex = 0;
            // 
            // pnlAddFood
            // 
            this.pnlAddFood.Controls.Add(this.lblFoodPrice);
            this.pnlAddFood.Controls.Add(this.btnAddFood);
            this.pnlAddFood.Controls.Add(this.nmCountFood);
            this.pnlAddFood.Controls.Add(this.lblNumber);
            this.pnlAddFood.Controls.Add(this.pbFood);
            this.pnlAddFood.Controls.Add(this.cbCategory);
            this.pnlAddFood.Controls.Add(this.cbFood);
            this.pnlAddFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddFood.Location = new System.Drawing.Point(840, 57);
            this.pnlAddFood.Name = "pnlAddFood";
            this.pnlAddFood.Size = new System.Drawing.Size(311, 495);
            this.pnlAddFood.TabIndex = 5;
            // 
            // pnlNameFood
            // 
            this.pnlNameFood.BackColor = System.Drawing.Color.DimGray;
            this.pnlNameFood.Controls.Add(this.lblOrder);
            this.pnlNameFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNameFood.Location = new System.Drawing.Point(840, 0);
            this.pnlNameFood.Name = "pnlNameFood";
            this.pnlNameFood.Size = new System.Drawing.Size(311, 57);
            this.pnlNameFood.TabIndex = 4;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(92, 13);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(135, 34);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "GỌI MÓN";
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.lsvBill);
            this.pnlHoaDon.Controls.Add(this.panel2);
            this.pnlHoaDon.Controls.Add(this.pnlBillName);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHoaDon.Location = new System.Drawing.Point(481, 0);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(359, 552);
            this.pnlHoaDon.TabIndex = 3;
            // 
            // pnlBillName
            // 
            this.pnlBillName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBillName.Controls.Add(this.lblBill);
            this.pnlBillName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillName.Location = new System.Drawing.Point(0, 0);
            this.pnlBillName.Name = "pnlBillName";
            this.pnlBillName.Size = new System.Drawing.Size(359, 57);
            this.pnlBillName.TabIndex = 0;
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.pnlListTable);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTable.Location = new System.Drawing.Point(0, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(481, 552);
            this.pnlTable.TabIndex = 2;
            // 
            // pnlListTable
            // 
            this.pnlListTable.Controls.Add(this.pnlShowListTable);
            this.pnlListTable.Controls.Add(this.pnlTableListName);
            this.pnlListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListTable.Location = new System.Drawing.Point(0, 0);
            this.pnlListTable.Name = "pnlListTable";
            this.pnlListTable.Size = new System.Drawing.Size(481, 552);
            this.pnlListTable.TabIndex = 5;
            // 
            // pnlShowListTable
            // 
            this.pnlShowListTable.Controls.Add(this.flpTable);
            this.pnlShowListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowListTable.Location = new System.Drawing.Point(0, 57);
            this.pnlShowListTable.Name = "pnlShowListTable";
            this.pnlShowListTable.Size = new System.Drawing.Size(481, 495);
            this.pnlShowListTable.TabIndex = 5;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(481, 495);
            this.flpTable.TabIndex = 0;
            // 
            // pnlTableListName
            // 
            this.pnlTableListName.BackColor = System.Drawing.Color.DimGray;
            this.pnlTableListName.Controls.Add(this.lbTableFoodList);
            this.pnlTableListName.Controls.Add(this.pbReloadTable);
            this.pnlTableListName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableListName.Location = new System.Drawing.Point(0, 0);
            this.pnlTableListName.Name = "pnlTableListName";
            this.pnlTableListName.Size = new System.Drawing.Size(481, 57);
            this.pnlTableListName.TabIndex = 4;
            // 
            // pbReloadTable
            // 
            this.pbReloadTable.BackColor = System.Drawing.Color.DimGray;
            this.pbReloadTable.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.pbReloadTable.IconColor = System.Drawing.Color.White;
            this.pbReloadTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbReloadTable.Location = new System.Drawing.Point(377, 13);
            this.pbReloadTable.Name = "pbReloadTable";
            this.pbReloadTable.Size = new System.Drawing.Size(32, 33);
            this.pbReloadTable.TabIndex = 5;
            this.pbReloadTable.TabStop = false;
            this.pbReloadTable.Click += new System.EventHandler(this.pbReloadTable_Click);
            // 
            // lbTableFoodList
            // 
            this.lbTableFoodList.BackColor = System.Drawing.Color.DimGray;
            this.lbTableFoodList.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableFoodList.ForeColor = System.Drawing.Color.White;
            this.lbTableFoodList.Location = new System.Drawing.Point(3, 3);
            this.lbTableFoodList.Name = "lbTableFoodList";
            this.lbTableFoodList.Size = new System.Drawing.Size(478, 54);
            this.lbTableFoodList.TabIndex = 3;
            this.lbTableFoodList.Text = "DANH SÁCH BÀN ĂN";
            this.lbTableFoodList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pddHoaDon
            // 
            this.pddHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pddHoaDon.Enabled = true;
            this.pddHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pddHoaDon.Icon")));
            this.pddHoaDon.Name = "pddHoaDon";
            this.pddHoaDon.Visible = false;
            // 
            // pdHoaDon
            // 
            this.pdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdHoaDon_PrintPage);
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 552);
            this.Controls.Add(this.pnlTableManager);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt món";
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.pnlTableManager.ResumeLayout(false);
            this.pnlAddFood.ResumeLayout(false);
            this.pnlAddFood.PerformLayout();
            this.pnlNameFood.ResumeLayout(false);
            this.pnlNameFood.PerformLayout();
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlBillName.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            this.pnlListTable.ResumeLayout(false);
            this.pnlShowListTable.ResumeLayout(false);
            this.pnlTableListName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTableManager;
        private System.Windows.Forms.NumericUpDown nmCountFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel pnlAddFood;
        private System.Windows.Forms.Panel pnlNameFood;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Panel pnlBillName;
        private System.Windows.Forms.Panel pnlTableListName;
        private System.Windows.Forms.Label lbTableFoodList;
        private System.Windows.Forms.Panel pnlListTable;
        private System.Windows.Forms.Panel pnlShowListTable;
        private FontAwesome.Sharp.IconPictureBox pbReloadTable;
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
        private System.Drawing.Printing.PrintDocument pdHoaDon;
    }
}