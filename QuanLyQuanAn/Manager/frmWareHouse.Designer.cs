namespace QuanLyQuanAn
{
    partial class frmWareHouse
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtBillOfWareHouseID = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBillOfWHID = new System.Windows.Forms.Label();
            this.dgvBillOfWareHouseList = new System.Windows.Forms.DataGridView();
            this.idBillOfWareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotalBill = new System.Windows.Forms.Panel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblBillDetail = new System.Windows.Forms.Label();
            this.lsvBillInfoOfWH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouseList)).BeginInit();
            this.pnTotalBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.rtbNote);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.txtSupplier);
            this.pn1.Controls.Add(this.txtDate);
            this.pn1.Controls.Add(this.txtBillOfWareHouseID);
            this.pn1.Controls.Add(this.lblTotalPrice);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblBillOfWHID);
            this.pn1.Location = new System.Drawing.Point(8, 444);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(763, 195);
            this.pn1.TabIndex = 3;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(488, 23);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(257, 98);
            this.rtbNote.TabIndex = 5;
            this.rtbNote.Text = "";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Location = new System.Drawing.Point(172, 138);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(174, 23);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplier.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSupplier.Location = new System.Drawing.Point(172, 99);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(174, 23);
            this.txtSupplier.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDate.Location = new System.Drawing.Point(172, 61);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(174, 23);
            this.txtDate.TabIndex = 2;
            // 
            // txtBillOfWareHouseID
            // 
            this.txtBillOfWareHouseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillOfWareHouseID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBillOfWareHouseID.Location = new System.Drawing.Point(172, 23);
            this.txtBillOfWareHouseID.Name = "txtBillOfWareHouseID";
            this.txtBillOfWareHouseID.ReadOnly = true;
            this.txtBillOfWareHouseID.Size = new System.Drawing.Size(174, 23);
            this.txtBillOfWareHouseID.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 138);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 22);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(392, 24);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(79, 22);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(13, 99);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(132, 22);
            this.lblSupplier.TabIndex = 5;
            this.lblSupplier.Text = "Nhà Cung Cấp:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(13, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 22);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblBillOfWHID
            // 
            this.lblBillOfWHID.AutoSize = true;
            this.lblBillOfWHID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBillOfWHID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBillOfWHID.Location = new System.Drawing.Point(13, 23);
            this.lblBillOfWHID.Name = "lblBillOfWHID";
            this.lblBillOfWHID.Size = new System.Drawing.Size(116, 22);
            this.lblBillOfWHID.TabIndex = 3;
            this.lblBillOfWHID.Text = "Mã hóa đơn:";
            // 
            // dgvBillOfWareHouseList
            // 
            this.dgvBillOfWareHouseList.AllowUserToAddRows = false;
            this.dgvBillOfWareHouseList.AllowUserToDeleteRows = false;
            this.dgvBillOfWareHouseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillOfWareHouseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillOfWareHouseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillOfWareHouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillOfWareHouseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBillOfWareHouse,
            this.dateAdded,
            this.supplier,
            this.node});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillOfWareHouseList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillOfWareHouseList.Location = new System.Drawing.Point(8, 35);
            this.dgvBillOfWareHouseList.Name = "dgvBillOfWareHouseList";
            this.dgvBillOfWareHouseList.ReadOnly = true;
            this.dgvBillOfWareHouseList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBillOfWareHouseList.RowTemplate.Height = 25;
            this.dgvBillOfWareHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillOfWareHouseList.Size = new System.Drawing.Size(763, 403);
            this.dgvBillOfWareHouseList.TabIndex = 7;
            this.dgvBillOfWareHouseList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBillOfWareHouseList_CellMouseClick);
            // 
            // idBillOfWareHouse
            // 
            this.idBillOfWareHouse.HeaderText = "Mã Hóa Đơn";
            this.idBillOfWareHouse.Name = "idBillOfWareHouse";
            this.idBillOfWareHouse.ReadOnly = true;
            this.idBillOfWareHouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateAdded
            // 
            this.dateAdded.HeaderText = "Ngày Nhập Hàng";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Nhà cung cấp";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // node
            // 
            this.node.HeaderText = "Ghi Chú";
            this.node.Name = "node";
            this.node.ReadOnly = true;
            // 
            // pnTotalBill
            // 
            this.pnTotalBill.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalBill.Controls.Add(this.lblTotalBill);
            this.pnTotalBill.Location = new System.Drawing.Point(8, 5);
            this.pnTotalBill.Name = "pnTotalBill";
            this.pnTotalBill.Size = new System.Drawing.Size(763, 28);
            this.pnTotalBill.TabIndex = 0;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(3, 5);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(140, 19);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "Tổng số hóa đơn: ";
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDetail.Location = new System.Drawing.Point(3, 5);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(129, 19);
            this.lblBillDetail.TabIndex = 7;
            this.lblBillDetail.Text = "Chi tiết hóa đơn";
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(777, 35);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(375, 604);
            this.lsvBillInfoOfWH.TabIndex = 6;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nguyên Liệu";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(777, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 28);
            this.panel2.TabIndex = 7;
            // 
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.pnTotalBill);
            this.Controls.Add(this.dgvBillOfWareHouseList);
            this.Controls.Add(this.pn1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin đơn hàng";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouseList)).EndInit();
            this.pnTotalBill.ResumeLayout(false);
            this.pnTotalBill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBillOfWareHouseID;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBillOfWHID;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.DataGridView dgvBillOfWareHouseList;
        private System.Windows.Forms.Panel pnTotalBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label lblBillDetail;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ListView lsvBillInfoOfWH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillOfWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn node;
    }
}