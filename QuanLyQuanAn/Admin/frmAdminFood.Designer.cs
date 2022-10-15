
namespace QuanLyQuanAn
{
    partial class frmAdminFood
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
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFoodInfo = new System.Windows.Forms.Panel();
            this.lblFoodInfo = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lblLinkImage = new System.Windows.Forms.Label();
            this.ptbImageOfFood = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new FontAwesome.Sharp.IconButton();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.btnEditFood = new FontAwesome.Sharp.IconButton();
            this.btnShowFood = new FontAwesome.Sharp.IconButton();
            this.btnDeleteFood = new FontAwesome.Sharp.IconButton();
            this.btnAddFood = new FontAwesome.Sharp.IconButton();
            this.btnFindFoodName = new FontAwesome.Sharp.IconButton();
            this.txtFindFoodName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalFood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.pnFoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToDeleteRows = false;
            this.dgvFoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodList.Location = new System.Drawing.Point(4, 90);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(785, 470);
            this.dgvFoodList.TabIndex = 14;
            this.dgvFoodList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoodList_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã món ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên món ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã danh mục ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá món ăn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đường dẫn hình";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pnFoodInfo
            // 
            this.pnFoodInfo.BackColor = System.Drawing.Color.DimGray;
            this.pnFoodInfo.Controls.Add(this.lblFoodInfo);
            this.pnFoodInfo.Controls.Add(this.cbStatus);
            this.pnFoodInfo.Controls.Add(this.lblLinkImage);
            this.pnFoodInfo.Controls.Add(this.ptbImageOfFood);
            this.pnFoodInfo.Controls.Add(this.btnOpenImage);
            this.pnFoodInfo.Controls.Add(this.cbbFoodCategory);
            this.pnFoodInfo.Controls.Add(this.txtFoodName);
            this.pnFoodInfo.Controls.Add(this.txtPrice);
            this.pnFoodInfo.Controls.Add(this.txtFoodID);
            this.pnFoodInfo.Controls.Add(this.lblStatus);
            this.pnFoodInfo.Controls.Add(this.lblPrice);
            this.pnFoodInfo.Controls.Add(this.lblFoodCategory);
            this.pnFoodInfo.Controls.Add(this.lblFoodName);
            this.pnFoodInfo.Controls.Add(this.lblFoodID);
            this.pnFoodInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFoodInfo.Location = new System.Drawing.Point(794, 0);
            this.pnFoodInfo.Name = "pnFoodInfo";
            this.pnFoodInfo.Size = new System.Drawing.Size(361, 640);
            this.pnFoodInfo.TabIndex = 2;
            // 
            // lblFoodInfo
            // 
            this.lblFoodInfo.AutoSize = true;
            this.lblFoodInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodInfo.ForeColor = System.Drawing.Color.White;
            this.lblFoodInfo.Location = new System.Drawing.Point(14, 33);
            this.lblFoodInfo.Name = "lblFoodInfo";
            this.lblFoodInfo.Size = new System.Drawing.Size(239, 32);
            this.lblFoodInfo.TabIndex = 3;
            this.lblFoodInfo.Text = "Thông Tin Món Ăn";
            // 
            // cbStatus
            // 
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbStatus.Location = new System.Drawing.Point(170, 233);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 45);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.Text = "Đang bán";
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.CheckedChanged += new System.EventHandler(this.statusOn_CheckedChanged);
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
            // ptbImageOfFood
            // 
            this.ptbImageOfFood.Location = new System.Drawing.Point(63, 360);
            this.ptbImageOfFood.Name = "ptbImageOfFood";
            this.ptbImageOfFood.Size = new System.Drawing.Size(233, 187);
            this.ptbImageOfFood.TabIndex = 11;
            this.ptbImageOfFood.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpenImage.ForeColor = System.Drawing.Color.Black;
            this.btnOpenImage.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnOpenImage.IconColor = System.Drawing.Color.Black;
            this.btnOpenImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenImage.Location = new System.Drawing.Point(91, 297);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(188, 49);
            this.btnOpenImage.TabIndex = 9;
            this.btnOpenImage.Text = "Cập nhật hình";
            this.btnOpenImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(153, 164);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(174, 27);
            this.cbbFoodCategory.TabIndex = 6;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFoodName.Location = new System.Drawing.Point(153, 128);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(174, 23);
            this.txtFoodName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.Location = new System.Drawing.Point(153, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // txtFoodID
            // 
            this.txtFoodID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFoodID.Location = new System.Drawing.Point(153, 91);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(174, 23);
            this.txtFoodID.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(13, 242);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(16, 205);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Giá:";
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodCategory.ForeColor = System.Drawing.Color.White;
            this.lblFoodCategory.Location = new System.Drawing.Point(15, 162);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(117, 25);
            this.lblFoodCategory.TabIndex = 5;
            this.lblFoodCategory.Text = "Danh mục:";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodName.ForeColor = System.Drawing.Color.White;
            this.lblFoodName.Location = new System.Drawing.Point(16, 126);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(103, 25);
            this.lblFoodName.TabIndex = 4;
            this.lblFoodName.Text = "Tên món:";
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodID.ForeColor = System.Drawing.Color.White;
            this.lblFoodID.Location = new System.Drawing.Point(16, 89);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(96, 25);
            this.lblFoodID.TabIndex = 3;
            this.lblFoodID.Text = "Mã món:";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditFood.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditFood.IconColor = System.Drawing.Color.Black;
            this.btnEditFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFood.IconSize = 32;
            this.btnEditFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFood.Location = new System.Drawing.Point(444, 566);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(111, 56);
            this.btnEditFood.TabIndex = 11;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowFood.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowFood.IconColor = System.Drawing.Color.Black;
            this.btnShowFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowFood.IconSize = 32;
            this.btnShowFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFood.Location = new System.Drawing.Point(678, 566);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(111, 56);
            this.btnShowFood.TabIndex = 13;
            this.btnShowFood.Text = "Hiển thị";
            this.btnShowFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFood.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteFood.IconColor = System.Drawing.Color.Black;
            this.btnDeleteFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteFood.IconSize = 32;
            this.btnDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFood.Location = new System.Drawing.Point(561, 565);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(111, 57);
            this.btnDeleteFood.TabIndex = 12;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddFood.IconColor = System.Drawing.Color.Black;
            this.btnAddFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFood.IconSize = 32;
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(327, 565);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(111, 56);
            this.btnAddFood.TabIndex = 10;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnFindFoodName
            // 
            this.btnFindFoodName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindFoodName.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindFoodName.IconColor = System.Drawing.Color.Black;
            this.btnFindFoodName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindFoodName.IconSize = 24;
            this.btnFindFoodName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFoodName.Location = new System.Drawing.Point(5, 24);
            this.btnFindFoodName.Name = "btnFindFoodName";
            this.btnFindFoodName.Size = new System.Drawing.Size(164, 29);
            this.btnFindFoodName.TabIndex = 0;
            this.btnFindFoodName.Text = "Tra cứu món ăn";
            this.btnFindFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFoodName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindFoodName.UseVisualStyleBackColor = true;
            // 
            // txtFindFoodName
            // 
            this.txtFindFoodName.Location = new System.Drawing.Point(174, 24);
            this.txtFindFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindFoodName.Multiline = true;
            this.txtFindFoodName.Name = "txtFindFoodName";
            this.txtFindFoodName.Size = new System.Drawing.Size(615, 28);
            this.txtFindFoodName.TabIndex = 1;
            this.txtFindFoodName.TextChanged += new System.EventHandler(this.txtFindFoodName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalFood);
            this.panel1.Location = new System.Drawing.Point(4, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 28);
            this.panel1.TabIndex = 2;
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
            // frmAdminFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnFindFoodName);
            this.Controls.Add(this.txtFindFoodName);
            this.Controls.Add(this.pnFoodInfo);
            this.Controls.Add(this.dgvFoodList);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.pnFoodInfo.ResumeLayout(false);
            this.pnFoodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Panel pnFoodInfo;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFoodCategory;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblLinkImage;
        private System.Windows.Forms.PictureBox ptbImageOfFood;
        private FontAwesome.Sharp.IconButton btnOpenImage;
        private FontAwesome.Sharp.IconButton btnEditFood;
        private FontAwesome.Sharp.IconButton btnShowFood;
        private FontAwesome.Sharp.IconButton btnDeleteFood;
        private FontAwesome.Sharp.IconButton btnAddFood;
        private FontAwesome.Sharp.IconButton btnFindFoodName;
        private System.Windows.Forms.TextBox txtFindFoodName;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblFoodInfo;
    }
}

