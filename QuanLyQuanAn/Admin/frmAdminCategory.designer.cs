
namespace QuanLyQuanAn
{
    partial class frmCategory
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
            this.btnEditCategory = new FontAwesome.Sharp.IconButton();
            this.btnShowCatetory = new FontAwesome.Sharp.IconButton();
            this.btnDeleteCategory = new FontAwesome.Sharp.IconButton();
            this.btnAddCategory = new FontAwesome.Sharp.IconButton();
            this.pnCategory = new System.Windows.Forms.Panel();
            this.lblCategoryInfo = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.dgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindCategoryName = new FontAwesome.Sharp.IconButton();
            this.txtFindCategoryName = new System.Windows.Forms.TextBox();
            this.pnCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditCategory.IconColor = System.Drawing.Color.Black;
            this.btnEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCategory.IconSize = 32;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.Location = new System.Drawing.Point(442, 566);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(111, 56);
            this.btnEditCategory.TabIndex = 7;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnShowCatetory
            // 
            this.btnShowCatetory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowCatetory.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowCatetory.IconColor = System.Drawing.Color.Black;
            this.btnShowCatetory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowCatetory.IconSize = 32;
            this.btnShowCatetory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCatetory.Location = new System.Drawing.Point(676, 566);
            this.btnShowCatetory.Name = "btnShowCatetory";
            this.btnShowCatetory.Size = new System.Drawing.Size(111, 56);
            this.btnShowCatetory.TabIndex = 9;
            this.btnShowCatetory.Text = "Hiển thị";
            this.btnShowCatetory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCatetory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCatetory.UseVisualStyleBackColor = true;
            this.btnShowCatetory.Click += new System.EventHandler(this.btnShowCatetory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteCategory.IconColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteCategory.IconSize = 32;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(559, 565);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(111, 57);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCategory.IconColor = System.Drawing.Color.Black;
            this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategory.IconSize = 32;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(325, 565);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(111, 56);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.DimGray;
            this.pnCategory.Controls.Add(this.lblCategoryInfo);
            this.pnCategory.Controls.Add(this.txtCategoryName);
            this.pnCategory.Controls.Add(this.txtCategoryID);
            this.pnCategory.Controls.Add(this.lblCategoryName);
            this.pnCategory.Controls.Add(this.lblCategoryID);
            this.pnCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCategory.Location = new System.Drawing.Point(794, 0);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(361, 640);
            this.pnCategory.TabIndex = 22;
            // 
            // lblCategoryInfo
            // 
            this.lblCategoryInfo.AutoSize = true;
            this.lblCategoryInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategoryInfo.ForeColor = System.Drawing.Color.White;
            this.lblCategoryInfo.Location = new System.Drawing.Point(21, 54);
            this.lblCategoryInfo.Name = "lblCategoryInfo";
            this.lblCategoryInfo.Size = new System.Drawing.Size(268, 32);
            this.lblCategoryInfo.TabIndex = 3;
            this.lblCategoryInfo.Text = "Thông Tin Danh Mục";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCategoryName.Location = new System.Drawing.Point(171, 193);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(174, 23);
            this.txtCategoryName.TabIndex = 5;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCategoryID.Location = new System.Drawing.Point(171, 138);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(174, 23);
            this.txtCategoryID.TabIndex = 4;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(3, 191);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(156, 25);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "Tên danh mục:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategoryID.ForeColor = System.Drawing.Color.White;
            this.lblCategoryID.Location = new System.Drawing.Point(3, 136);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(149, 25);
            this.lblCategoryID.TabIndex = 3;
            this.lblCategoryID.Text = "Mã danh mục:";
            // 
            // dgvFoodCategory
            // 
            this.dgvFoodCategory.AllowUserToAddRows = false;
            this.dgvFoodCategory.AllowUserToDeleteRows = false;
            this.dgvFoodCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.categoryName,
            this.column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodCategory.Location = new System.Drawing.Point(2, 90);
            this.dgvFoodCategory.Name = "dgvFoodCategory";
            this.dgvFoodCategory.ReadOnly = true;
            this.dgvFoodCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFoodCategory.RowTemplate.Height = 25;
            this.dgvFoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodCategory.Size = new System.Drawing.Size(785, 469);
            this.dgvFoodCategory.TabIndex = 10;
            this.dgvFoodCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoodCategory_CellMouseClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã danh mục ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Tên danh mục";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // column4
            // 
            this.column4.HeaderText = "Số món ăn";
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.AutoSize = true;
            this.lblTotalCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategory.Location = new System.Drawing.Point(3, 5);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(133, 19);
            this.lblTotalCategory.TabIndex = 2;
            this.lblTotalCategory.Text = "Tổng số món ăn: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalCategory);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 28);
            this.panel1.TabIndex = 29;
            // 
            // btnFindCategoryName
            // 
            this.btnFindCategoryName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindCategoryName.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindCategoryName.IconColor = System.Drawing.Color.Black;
            this.btnFindCategoryName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindCategoryName.IconSize = 1;
            this.btnFindCategoryName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCategoryName.Location = new System.Drawing.Point(3, 24);
            this.btnFindCategoryName.Name = "btnFindCategoryName";
            this.btnFindCategoryName.Size = new System.Drawing.Size(178, 29);
            this.btnFindCategoryName.TabIndex = 0;
            this.btnFindCategoryName.Text = "Tra cứu danh mục";
            this.btnFindCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCategoryName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCategoryName.UseVisualStyleBackColor = true;
            // 
            // txtFindCategoryName
            // 
            this.txtFindCategoryName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCategoryName.Location = new System.Drawing.Point(186, 24);
            this.txtFindCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindCategoryName.Multiline = true;
            this.txtFindCategoryName.Name = "txtFindCategoryName";
            this.txtFindCategoryName.Size = new System.Drawing.Size(601, 28);
            this.txtFindCategoryName.TabIndex = 1;
            this.txtFindCategoryName.TextChanged += new System.EventHandler(this.txtFindCategoryName_TextChanged);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnShowCatetory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.pnCategory);
            this.Controls.Add(this.dgvFoodCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFindCategoryName);
            this.Controls.Add(this.txtFindCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategory";
            this.Text = "Quản lý danh mục";
            this.pnCategory.ResumeLayout(false);
            this.pnCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEditCategory;
        private FontAwesome.Sharp.IconButton btnShowCatetory;
        private FontAwesome.Sharp.IconButton btnDeleteCategory;
        private FontAwesome.Sharp.IconButton btnAddCategory;
        private System.Windows.Forms.Panel pnCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.DataGridView dgvFoodCategory;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFindCategoryName;
        private System.Windows.Forms.TextBox txtFindCategoryName;
        private System.Windows.Forms.Label lblCategoryInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
    }
}

