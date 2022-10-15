
namespace QuanLyQuanAn
{
    partial class frmAdminAccount
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
            this.pnAccount = new System.Windows.Forms.Panel();
            this.nudTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTypeAccount = new System.Windows.Forms.Label();
            this.lblDisplayname = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.btnShowAccount = new FontAwesome.Sharp.IconButton();
            this.btnDeleteAccount = new FontAwesome.Sharp.IconButton();
            this.btnAddAccount = new FontAwesome.Sharp.IconButton();
            this.btnFindAccount = new FontAwesome.Sharp.IconButton();
            this.txtFindAccount = new System.Windows.Forms.TextBox();
            this.lblTotalAccount = new System.Windows.Forms.Label();
            this.pnTotalAccount = new System.Windows.Forms.Panel();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnTotalAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.DimGray;
            this.pnAccount.Controls.Add(this.nudTypeAccount);
            this.pnAccount.Controls.Add(this.lblAccountInfo);
            this.pnAccount.Controls.Add(this.btnResetPassword);
            this.pnAccount.Controls.Add(this.txtPassword);
            this.pnAccount.Controls.Add(this.txtDisplayName);
            this.pnAccount.Controls.Add(this.txtRetypePassword);
            this.pnAccount.Controls.Add(this.txtIdStaff);
            this.pnAccount.Controls.Add(this.lblStaffID);
            this.pnAccount.Controls.Add(this.lblRetypePassword);
            this.pnAccount.Controls.Add(this.txtAccountName);
            this.pnAccount.Controls.Add(this.lblPassword);
            this.pnAccount.Controls.Add(this.lblTypeAccount);
            this.pnAccount.Controls.Add(this.lblDisplayname);
            this.pnAccount.Controls.Add(this.lblAccountName);
            this.pnAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnAccount.Location = new System.Drawing.Point(834, 0);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(316, 640);
            this.pnAccount.TabIndex = 4;
            // 
            // nudTypeAccount
            // 
            this.nudTypeAccount.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTypeAccount.Location = new System.Drawing.Point(152, 331);
            this.nudTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTypeAccount.Name = "nudTypeAccount";
            this.nudTypeAccount.Size = new System.Drawing.Size(152, 32);
            this.nudTypeAccount.TabIndex = 7;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccountInfo.ForeColor = System.Drawing.Color.White;
            this.lblAccountInfo.Location = new System.Drawing.Point(12, 27);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(253, 32);
            this.lblAccountInfo.TabIndex = 2;
            this.lblAccountInfo.Text = "Thông tin tài khoản";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnResetPassword.IconColor = System.Drawing.Color.White;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.IconSize = 32;
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.Location = new System.Drawing.Point(115, 465);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(189, 42);
            this.btnResetPassword.TabIndex = 13;
            this.btnResetPassword.Text = "Đặt Lại Mật Khẩu";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(152, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDisplayName.Location = new System.Drawing.Point(152, 273);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(152, 25);
            this.txtDisplayName.TabIndex = 6;
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetypePassword.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRetypePassword.Location = new System.Drawing.Point(152, 219);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(152, 25);
            this.txtRetypePassword.TabIndex = 5;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdStaff.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdStaff.Location = new System.Drawing.Point(152, 385);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.Size = new System.Drawing.Size(152, 25);
            this.txtIdStaff.TabIndex = 8;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(3, 388);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(129, 22);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Mã nhân viên:";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRetypePassword.ForeColor = System.Drawing.Color.White;
            this.lblRetypePassword.Location = new System.Drawing.Point(3, 221);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(119, 22);
            this.lblRetypePassword.TabIndex = 6;
            this.lblRetypePassword.Text = "Nhập lại MK:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAccountName.Location = new System.Drawing.Point(152, 104);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(152, 25);
            this.txtAccountName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(4, 161);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // lblTypeAccount
            // 
            this.lblTypeAccount.AutoSize = true;
            this.lblTypeAccount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTypeAccount.ForeColor = System.Drawing.Color.White;
            this.lblTypeAccount.Location = new System.Drawing.Point(3, 335);
            this.lblTypeAccount.Name = "lblTypeAccount";
            this.lblTypeAccount.Size = new System.Drawing.Size(147, 22);
            this.lblTypeAccount.TabIndex = 6;
            this.lblTypeAccount.Text = "Loại Tài Khoản :";
            // 
            // lblDisplayname
            // 
            this.lblDisplayname.AutoSize = true;
            this.lblDisplayname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDisplayname.ForeColor = System.Drawing.Color.White;
            this.lblDisplayname.Location = new System.Drawing.Point(4, 275);
            this.lblDisplayname.Name = "lblDisplayname";
            this.lblDisplayname.Size = new System.Drawing.Size(129, 22);
            this.lblDisplayname.TabIndex = 4;
            this.lblDisplayname.Text = "Tên Hiển Thị :";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccountName.ForeColor = System.Drawing.Color.White;
            this.lblAccountName.Location = new System.Drawing.Point(4, 106);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(142, 22);
            this.lblAccountName.TabIndex = 3;
            this.lblAccountName.Text = "Tên Tài Khoản :";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.idStaff});
            this.dgvAccount.Location = new System.Drawing.Point(5, 89);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(807, 444);
            this.dgvAccount.TabIndex = 15;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên Tài Khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Hiển Thị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Loại Tài Khoản";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // idStaff
            // 
            this.idStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idStaff.HeaderText = "Mã nhân viên";
            this.idStaff.Name = "idStaff";
            this.idStaff.ReadOnly = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditAccount.IconColor = System.Drawing.Color.Black;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.IconSize = 32;
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.Location = new System.Drawing.Point(491, 550);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(98, 56);
            this.btnEditAccount.TabIndex = 10;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAccount.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowAccount.IconColor = System.Drawing.Color.Black;
            this.btnShowAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAccount.IconSize = 32;
            this.btnShowAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAccount.Location = new System.Drawing.Point(698, 551);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(114, 56);
            this.btnShowAccount.TabIndex = 12;
            this.btnShowAccount.Text = "Hiển Thị";
            this.btnShowAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteAccount.IconColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAccount.IconSize = 32;
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(594, 550);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(98, 57);
            this.btnDeleteAccount.TabIndex = 11;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddAccount.IconColor = System.Drawing.Color.Black;
            this.btnAddAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAccount.IconSize = 32;
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.Location = new System.Drawing.Point(386, 551);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(98, 56);
            this.btnAddAccount.TabIndex = 9;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindAccount.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindAccount.IconColor = System.Drawing.Color.Black;
            this.btnFindAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindAccount.IconSize = 24;
            this.btnFindAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindAccount.Location = new System.Drawing.Point(7, 11);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.Size = new System.Drawing.Size(178, 29);
            this.btnFindAccount.TabIndex = 0;
            this.btnFindAccount.Text = "Tra cứu tài khoản";
            this.btnFindAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindAccount.UseVisualStyleBackColor = true;
            // 
            // txtFindAccount
            // 
            this.txtFindAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAccount.Location = new System.Drawing.Point(191, 11);
            this.txtFindAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindAccount.Multiline = true;
            this.txtFindAccount.Name = "txtFindAccount";
            this.txtFindAccount.Size = new System.Drawing.Size(621, 28);
            this.txtFindAccount.TabIndex = 1;
            this.txtFindAccount.TextChanged += new System.EventHandler(this.txtFindAccountName_TextChanged);
            // 
            // lblTotalAccount
            // 
            this.lblTotalAccount.AutoSize = true;
            this.lblTotalAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAccount.Location = new System.Drawing.Point(3, 5);
            this.lblTotalAccount.Name = "lblTotalAccount";
            this.lblTotalAccount.Size = new System.Drawing.Size(148, 19);
            this.lblTotalAccount.TabIndex = 14;
            this.lblTotalAccount.Text = "Tổng số tài khoản: ";
            // 
            // pnTotalAccount
            // 
            this.pnTotalAccount.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalAccount.Controls.Add(this.lblTotalAccount);
            this.pnTotalAccount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotalAccount.Location = new System.Drawing.Point(6, 50);
            this.pnTotalAccount.Name = "pnTotalAccount";
            this.pnTotalAccount.Size = new System.Drawing.Size(806, 28);
            this.pnTotalAccount.TabIndex = 42;
            // 
            // frmAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.pnTotalAccount);
            this.Controls.Add(this.btnFindAccount);
            this.Controls.Add(this.txtFindAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.pnAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnTotalAccount.ResumeLayout(false);
            this.pnTotalAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblTypeAccount;
        private System.Windows.Forms.Label lblDisplayname;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DataGridView dgvAccount;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnShowAccount;
        private FontAwesome.Sharp.IconButton btnDeleteAccount;
        private FontAwesome.Sharp.IconButton btnAddAccount;
        private FontAwesome.Sharp.IconButton btnFindAccount;
        private System.Windows.Forms.TextBox txtFindAccount;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStaff;
        private System.Windows.Forms.Label lblTotalAccount;
        private System.Windows.Forms.Panel pnTotalAccount;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.NumericUpDown nudTypeAccount;
    }
}

