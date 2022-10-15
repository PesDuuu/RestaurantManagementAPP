
namespace QuanLyQuanAn
{
    partial class frmAdminTableFood
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
            this.pnTableFoodInfo = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTableStatus = new System.Windows.Forms.TextBox();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblTableID = new System.Windows.Forms.Label();
            this.lblTableFoodInfo = new System.Windows.Forms.Label();
            this.btnEditTable = new FontAwesome.Sharp.IconButton();
            this.btnShowTable = new FontAwesome.Sharp.IconButton();
            this.btnDeteleTable = new FontAwesome.Sharp.IconButton();
            this.btnAddTable = new FontAwesome.Sharp.IconButton();
            this.pnTotalTableFood = new System.Windows.Forms.Panel();
            this.lblTotalTableFood = new System.Windows.Forms.Label();
            this.txtFindTableName = new System.Windows.Forms.TextBox();
            this.dgvTableFood = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindTable = new FontAwesome.Sharp.IconButton();
            this.pnTableFoodInfo.SuspendLayout();
            this.pnTotalTableFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTableFoodInfo
            // 
            this.pnTableFoodInfo.BackColor = System.Drawing.Color.DimGray;
            this.pnTableFoodInfo.Controls.Add(this.txtTableName);
            this.pnTableFoodInfo.Controls.Add(this.txtTableStatus);
            this.pnTableFoodInfo.Controls.Add(this.txtTableID);
            this.pnTableFoodInfo.Controls.Add(this.lblTableStatus);
            this.pnTableFoodInfo.Controls.Add(this.lblTableName);
            this.pnTableFoodInfo.Controls.Add(this.lblTableID);
            this.pnTableFoodInfo.Controls.Add(this.lblTableFoodInfo);
            this.pnTableFoodInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTableFoodInfo.Location = new System.Drawing.Point(818, 0);
            this.pnTableFoodInfo.Name = "pnTableFoodInfo";
            this.pnTableFoodInfo.Size = new System.Drawing.Size(332, 640);
            this.pnTableFoodInfo.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTableName.Location = new System.Drawing.Point(140, 239);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(180, 25);
            this.txtTableName.TabIndex = 5;
            // 
            // txtTableStatus
            // 
            this.txtTableStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTableStatus.Location = new System.Drawing.Point(140, 324);
            this.txtTableStatus.Name = "txtTableStatus";
            this.txtTableStatus.ReadOnly = true;
            this.txtTableStatus.Size = new System.Drawing.Size(180, 25);
            this.txtTableStatus.TabIndex = 6;
            // 
            // txtTableID
            // 
            this.txtTableID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTableID.Location = new System.Drawing.Point(140, 160);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(180, 25);
            this.txtTableID.TabIndex = 4;
            // 
            // lblTableStatus
            // 
            this.lblTableStatus.AutoSize = true;
            this.lblTableStatus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTableStatus.ForeColor = System.Drawing.Color.White;
            this.lblTableStatus.Location = new System.Drawing.Point(5, 324);
            this.lblTableStatus.Name = "lblTableStatus";
            this.lblTableStatus.Size = new System.Drawing.Size(129, 25);
            this.lblTableStatus.TabIndex = 6;
            this.lblTableStatus.Text = "Trạng Thái :";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTableName.ForeColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(5, 239);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(102, 25);
            this.lblTableName.TabIndex = 4;
            this.lblTableName.Text = "Tên Bàn :";
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTableID.ForeColor = System.Drawing.Color.White;
            this.lblTableID.Location = new System.Drawing.Point(5, 160);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(95, 25);
            this.lblTableID.TabIndex = 3;
            this.lblTableID.Text = "Mã Bàn :";
            // 
            // lblTableFoodInfo
            // 
            this.lblTableFoodInfo.AutoSize = true;
            this.lblTableFoodInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTableFoodInfo.ForeColor = System.Drawing.Color.White;
            this.lblTableFoodInfo.Location = new System.Drawing.Point(16, 66);
            this.lblTableFoodInfo.Name = "lblTableFoodInfo";
            this.lblTableFoodInfo.Size = new System.Drawing.Size(233, 32);
            this.lblTableFoodInfo.TabIndex = 3;
            this.lblTableFoodInfo.Text = "Thông Tin Bàn Ăn";
            // 
            // btnEditTable
            // 
            this.btnEditTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditTable.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditTable.IconColor = System.Drawing.Color.Black;
            this.btnEditTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTable.IconSize = 32;
            this.btnEditTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTable.Location = new System.Drawing.Point(452, 561);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(111, 56);
            this.btnEditTable.TabIndex = 8;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowTable.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowTable.IconColor = System.Drawing.Color.Black;
            this.btnShowTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowTable.IconSize = 32;
            this.btnShowTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTable.Location = new System.Drawing.Point(686, 561);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(111, 56);
            this.btnShowTable.TabIndex = 10;
            this.btnShowTable.Text = "Hiển thị";
            this.btnShowTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnDeteleTable
            // 
            this.btnDeteleTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeteleTable.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeteleTable.IconColor = System.Drawing.Color.Black;
            this.btnDeteleTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeteleTable.IconSize = 32;
            this.btnDeteleTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteleTable.Location = new System.Drawing.Point(569, 560);
            this.btnDeteleTable.Name = "btnDeteleTable";
            this.btnDeteleTable.Size = new System.Drawing.Size(111, 57);
            this.btnDeteleTable.TabIndex = 9;
            this.btnDeteleTable.Text = "Xóa";
            this.btnDeteleTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteleTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeteleTable.UseVisualStyleBackColor = true;
            this.btnDeteleTable.Click += new System.EventHandler(this.btnDeteleTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddTable.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTable.IconColor = System.Drawing.Color.Black;
            this.btnAddTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTable.IconSize = 32;
            this.btnAddTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTable.Location = new System.Drawing.Point(335, 560);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(111, 56);
            this.btnAddTable.TabIndex = 7;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // pnTotalTableFood
            // 
            this.pnTotalTableFood.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalTableFood.Controls.Add(this.lblTotalTableFood);
            this.pnTotalTableFood.Location = new System.Drawing.Point(12, 52);
            this.pnTotalTableFood.Name = "pnTotalTableFood";
            this.pnTotalTableFood.Size = new System.Drawing.Size(785, 28);
            this.pnTotalTableFood.TabIndex = 2;
            // 
            // lblTotalTableFood
            // 
            this.lblTotalTableFood.AutoSize = true;
            this.lblTotalTableFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTableFood.Location = new System.Drawing.Point(3, 5);
            this.lblTotalTableFood.Name = "lblTotalTableFood";
            this.lblTotalTableFood.Size = new System.Drawing.Size(128, 19);
            this.lblTotalTableFood.TabIndex = 2;
            this.lblTotalTableFood.Text = "Tổng số bàn ăn: ";
            // 
            // txtFindTableName
            // 
            this.txtFindTableName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindTableName.Location = new System.Drawing.Point(196, 19);
            this.txtFindTableName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindTableName.Multiline = true;
            this.txtFindTableName.Name = "txtFindTableName";
            this.txtFindTableName.Size = new System.Drawing.Size(601, 28);
            this.txtFindTableName.TabIndex = 1;
            this.txtFindTableName.TextChanged += new System.EventHandler(this.txtFindTableName_TextChanged);
            // 
            // dgvTableFood
            // 
            this.dgvTableFood.AllowUserToAddRows = false;
            this.dgvTableFood.AllowUserToDeleteRows = false;
            this.dgvTableFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.categoryName,
            this.tableStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableFood.Location = new System.Drawing.Point(12, 86);
            this.dgvTableFood.Name = "dgvTableFood";
            this.dgvTableFood.ReadOnly = true;
            this.dgvTableFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTableFood.RowTemplate.Height = 25;
            this.dgvTableFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableFood.Size = new System.Drawing.Size(785, 469);
            this.dgvTableFood.TabIndex = 11;
            this.dgvTableFood.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableFood_CellMouseClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã bàn ăn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Tên bàn ăn";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // tableStatus
            // 
            this.tableStatus.HeaderText = "Trạng thái";
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.ReadOnly = true;
            // 
            // btnFindTable
            // 
            this.btnFindTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindTable.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindTable.IconColor = System.Drawing.Color.Black;
            this.btnFindTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindTable.IconSize = 24;
            this.btnFindTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindTable.Location = new System.Drawing.Point(12, 19);
            this.btnFindTable.Name = "btnFindTable";
            this.btnFindTable.Size = new System.Drawing.Size(178, 29);
            this.btnFindTable.TabIndex = 0;
            this.btnFindTable.Text = "Tra cứu bàn ăn";
            this.btnFindTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindTable.UseVisualStyleBackColor = true;
            // 
            // frmAdminTableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.btnFindTable);
            this.Controls.Add(this.dgvTableFood);
            this.Controls.Add(this.btnEditTable);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.btnDeteleTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.pnTotalTableFood);
            this.Controls.Add(this.txtFindTableName);
            this.Controls.Add(this.pnTableFoodInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminTableFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.pnTableFoodInfo.ResumeLayout(false);
            this.pnTableFoodInfo.PerformLayout();
            this.pnTotalTableFood.ResumeLayout(false);
            this.pnTotalTableFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTableFoodInfo;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTableStatus;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblTableID;
        private FontAwesome.Sharp.IconButton btnEditTable;
        private FontAwesome.Sharp.IconButton btnShowTable;
        private FontAwesome.Sharp.IconButton btnDeteleTable;
        private FontAwesome.Sharp.IconButton btnAddTable;
        private System.Windows.Forms.Panel pnTotalTableFood;
        private System.Windows.Forms.Label lblTotalTableFood;
        private System.Windows.Forms.TextBox txtFindTableName;
        private System.Windows.Forms.Label lblTableFoodInfo;
        private System.Windows.Forms.DataGridView dgvTableFood;
        private FontAwesome.Sharp.IconButton btnFindTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableStatus;
    }
}

