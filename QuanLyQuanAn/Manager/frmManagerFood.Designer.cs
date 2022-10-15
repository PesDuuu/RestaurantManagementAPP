namespace QuanLyQuanAn
{
    partial class frmManagerFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.ptbImageOfFood = new System.Windows.Forms.PictureBox();
            this.lblLinkImage = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtFindFoodName = new System.Windows.Forms.TextBox();
            this.btnFindFood = new FontAwesome.Sharp.IconButton();
            this.lblTotalFood = new System.Windows.Forms.Label();
            this.pnTotalFood = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).BeginInit();
            this.pn1.SuspendLayout();
            this.pnTotalFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đường dẫn hình";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá món ăn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã danh mục ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên món ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã món ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToDeleteRows = false;
            this.dgvFoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoodList.Location = new System.Drawing.Point(2, 90);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(785, 538);
            this.dgvFoodList.TabIndex = 8;
            this.dgvFoodList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoodList_CellMouseClick);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodID.ForeColor = System.Drawing.Color.White;
            this.lblFoodID.Location = new System.Drawing.Point(16, 29);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(96, 25);
            this.lblFoodID.TabIndex = 3;
            this.lblFoodID.Text = "Mã món:";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodName.ForeColor = System.Drawing.Color.White;
            this.lblFoodName.Location = new System.Drawing.Point(16, 83);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(103, 25);
            this.lblFoodName.TabIndex = 4;
            this.lblFoodName.Text = "Tên món:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(16, 134);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(117, 25);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Danh mục:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(16, 192);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Giá:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(16, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // txtFoodID
            // 
            this.txtFoodID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFoodID.Location = new System.Drawing.Point(153, 31);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(174, 23);
            this.txtFoodID.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.Location = new System.Drawing.Point(153, 194);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFoodName.Location = new System.Drawing.Point(153, 85);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(174, 23);
            this.txtFoodName.TabIndex = 4;
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(153, 136);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(174, 27);
            this.cbbCategory.TabIndex = 5;
            // 
            // ptbImageOfFood
            // 
            this.ptbImageOfFood.Location = new System.Drawing.Point(21, 296);
            this.ptbImageOfFood.Name = "ptbImageOfFood";
            this.ptbImageOfFood.Size = new System.Drawing.Size(308, 261);
            this.ptbImageOfFood.TabIndex = 11;
            this.ptbImageOfFood.TabStop = false;
            // 
            // lblLinkImage
            // 
            this.lblLinkImage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLinkImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLinkImage.Location = new System.Drawing.Point(41, 560);
            this.lblLinkImage.Name = "lblLinkImage";
            this.lblLinkImage.Size = new System.Drawing.Size(273, 23);
            this.lblLinkImage.TabIndex = 12;
            this.lblLinkImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbStatus.Location = new System.Drawing.Point(170, 236);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 45);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Text = "Đang bán";
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.Click += new System.EventHandler(this.statusOn_CheckedChanged);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.cbStatus);
            this.pn1.Controls.Add(this.lblLinkImage);
            this.pn1.Controls.Add(this.ptbImageOfFood);
            this.pn1.Controls.Add(this.cbbCategory);
            this.pn1.Controls.Add(this.txtFoodName);
            this.pn1.Controls.Add(this.txtPrice);
            this.pn1.Controls.Add(this.txtFoodID);
            this.pn1.Controls.Add(this.lblStatus);
            this.pn1.Controls.Add(this.lblPrice);
            this.pn1.Controls.Add(this.lblCategory);
            this.pn1.Controls.Add(this.lblFoodName);
            this.pn1.Controls.Add(this.lblFoodID);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn1.Location = new System.Drawing.Point(794, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(361, 640);
            this.pn1.TabIndex = 22;
            // 
            // txtFindFoodName
            // 
            this.txtFindFoodName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindFoodName.Location = new System.Drawing.Point(161, 24);
            this.txtFindFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindFoodName.Multiline = true;
            this.txtFindFoodName.Name = "txtFindFoodName";
            this.txtFindFoodName.Size = new System.Drawing.Size(626, 28);
            this.txtFindFoodName.TabIndex = 1;
            this.txtFindFoodName.TextChanged += new System.EventHandler(this.txtFindFoodName_TextChanged);
            // 
            // btnFindFood
            // 
            this.btnFindFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindFood.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindFood.IconColor = System.Drawing.Color.Black;
            this.btnFindFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindFood.IconSize = 24;
            this.btnFindFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFood.Location = new System.Drawing.Point(3, 24);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(153, 29);
            this.btnFindFood.TabIndex = 0;
            this.btnFindFood.Text = "Tìm món ăn";
            this.btnFindFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindFood.UseVisualStyleBackColor = true;
            // 
            // lblTotalFood
            // 
            this.lblTotalFood.AutoSize = true;
            this.lblTotalFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFood.Location = new System.Drawing.Point(3, 5);
            this.lblTotalFood.Name = "lblTotalFood";
            this.lblTotalFood.Size = new System.Drawing.Size(133, 19);
            this.lblTotalFood.TabIndex = 2;
            this.lblTotalFood.Text = "Tổng số món ăn: ";
            // 
            // pnTotalFood
            // 
            this.pnTotalFood.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalFood.Controls.Add(this.lblTotalFood);
            this.pnTotalFood.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotalFood.Location = new System.Drawing.Point(2, 58);
            this.pnTotalFood.Name = "pnTotalFood";
            this.pnTotalFood.Size = new System.Drawing.Size(785, 28);
            this.pnTotalFood.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmManagerFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.pnTotalFood);
            this.Controls.Add(this.btnFindFood);
            this.Controls.Add(this.txtFindFoodName);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.dgvFoodList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagerFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin thức ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pnTotalFood.ResumeLayout(false);
            this.pnTotalFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.PictureBox ptbImageOfFood;
        private System.Windows.Forms.Label lblLinkImage;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.TextBox txtFindFoodName;
        private FontAwesome.Sharp.IconButton btnFindFood;
        private System.Windows.Forms.Label lblTotalFood;
        private System.Windows.Forms.Panel pnTotalFood;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}