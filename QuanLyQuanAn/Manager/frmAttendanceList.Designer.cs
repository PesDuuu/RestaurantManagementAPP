namespace QuanLyQuanAn
{
    partial class frmAttendanceList
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
            this.dgvAttendanceList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnInfoStaff = new System.Windows.Forms.Panel();
            this.btnCheckIn = new FontAwesome.Sharp.IconButton();
            this.btnFindStaff = new FontAwesome.Sharp.IconButton();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lblTimeSheets = new System.Windows.Forms.Label();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnTimeSheetsList = new System.Windows.Forms.Panel();
            this.lblTimeSheetsList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).BeginInit();
            this.pnInfoStaff.SuspendLayout();
            this.pnTimeSheetsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendanceList
            // 
            this.dgvAttendanceList.AllowUserToAddRows = false;
            this.dgvAttendanceList.AllowUserToDeleteRows = false;
            this.dgvAttendanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendanceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendanceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendanceList.Location = new System.Drawing.Point(2, 46);
            this.dgvAttendanceList.Name = "dgvAttendanceList";
            this.dgvAttendanceList.ReadOnly = true;
            this.dgvAttendanceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAttendanceList.RowHeadersWidth = 51;
            this.dgvAttendanceList.RowTemplate.Height = 25;
            this.dgvAttendanceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceList.Size = new System.Drawing.Size(818, 594);
            this.dgvAttendanceList.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Nhân Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Điểm Danh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pnInfoStaff
            // 
            this.pnInfoStaff.BackColor = System.Drawing.Color.DimGray;
            this.pnInfoStaff.Controls.Add(this.btnCheckIn);
            this.pnInfoStaff.Controls.Add(this.btnFindStaff);
            this.pnInfoStaff.Controls.Add(this.rtbAddress);
            this.pnInfoStaff.Controls.Add(this.lblTimeSheets);
            this.pnInfoStaff.Controls.Add(this.lblStaffInfo);
            this.pnInfoStaff.Controls.Add(this.lblStaffID);
            this.pnInfoStaff.Controls.Add(this.lblDateOfBirth);
            this.pnInfoStaff.Controls.Add(this.lblIdentityCard);
            this.pnInfoStaff.Controls.Add(this.txtIdentityCard);
            this.pnInfoStaff.Controls.Add(this.txtSex);
            this.pnInfoStaff.Controls.Add(this.txtDateOfBirth);
            this.pnInfoStaff.Controls.Add(this.txtPosition);
            this.pnInfoStaff.Controls.Add(this.txtStaffName);
            this.pnInfoStaff.Controls.Add(this.lblSex);
            this.pnInfoStaff.Controls.Add(this.lblPhoneNumber);
            this.pnInfoStaff.Controls.Add(this.txtStaffID);
            this.pnInfoStaff.Controls.Add(this.lblAddress);
            this.pnInfoStaff.Controls.Add(this.lblStaffName);
            this.pnInfoStaff.Controls.Add(this.lblPosition);
            this.pnInfoStaff.Controls.Add(this.txtPhoneNumber);
            this.pnInfoStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnInfoStaff.Location = new System.Drawing.Point(823, 0);
            this.pnInfoStaff.Name = "pnInfoStaff";
            this.pnInfoStaff.Size = new System.Drawing.Size(332, 643);
            this.pnInfoStaff.TabIndex = 24;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckIn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCheckIn.IconColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckIn.IconSize = 32;
            this.btnCheckIn.Location = new System.Drawing.Point(174, 583);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(148, 46);
            this.btnCheckIn.TabIndex = 12;
            this.btnCheckIn.Text = "Điểm danh";
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnFindStaff
            // 
            this.btnFindStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindStaff.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnFindStaff.IconColor = System.Drawing.Color.Black;
            this.btnFindStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindStaff.IconSize = 32;
            this.btnFindStaff.Location = new System.Drawing.Point(289, 75);
            this.btnFindStaff.Name = "btnFindStaff";
            this.btnFindStaff.Size = new System.Drawing.Size(34, 33);
            this.btnFindStaff.TabIndex = 3;
            this.btnFindStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindStaff.UseVisualStyleBackColor = true;
            this.btnFindStaff.Click += new System.EventHandler(this.btnFindStaff_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.Location = new System.Drawing.Point(136, 449);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.ReadOnly = true;
            this.rtbAddress.Size = new System.Drawing.Size(187, 118);
            this.rtbAddress.TabIndex = 11;
            this.rtbAddress.Text = "";
            // 
            // lblTimeSheets
            // 
            this.lblTimeSheets.AutoSize = true;
            this.lblTimeSheets.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeSheets.ForeColor = System.Drawing.Color.White;
            this.lblTimeSheets.Location = new System.Drawing.Point(28, 25);
            this.lblTimeSheets.Name = "lblTimeSheets";
            this.lblTimeSheets.Size = new System.Drawing.Size(147, 32);
            this.lblTimeSheets.TabIndex = 1;
            this.lblTimeSheets.Text = "Chấm công";
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffInfo.ForeColor = System.Drawing.Color.White;
            this.lblStaffInfo.Location = new System.Drawing.Point(28, 123);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(270, 32);
            this.lblStaffInfo.TabIndex = 4;
            this.lblStaffInfo.Text = "Thông Tin Nhân Viên";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStaffID.Location = new System.Drawing.Point(9, 79);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(74, 22);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "Mã NV :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDateOfBirth.Location = new System.Drawing.Point(9, 314);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(103, 22);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Ngày Sinh :";
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdentityCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdentityCard.Location = new System.Drawing.Point(9, 358);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(72, 22);
            this.lblIdentityCard.TabIndex = 12;
            this.lblIdentityCard.Text = "CMND :";
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentityCard.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdentityCard.Location = new System.Drawing.Point(136, 358);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.ReadOnly = true;
            this.txtIdentityCard.Size = new System.Drawing.Size(187, 23);
            this.txtIdentityCard.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSex.Location = new System.Drawing.Point(136, 223);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(187, 23);
            this.txtSex.TabIndex = 6;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateOfBirth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDateOfBirth.Location = new System.Drawing.Point(136, 314);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(187, 23);
            this.txtDateOfBirth.TabIndex = 8;
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPosition.Location = new System.Drawing.Point(136, 271);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(187, 23);
            this.txtPosition.TabIndex = 7;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStaffName.Location = new System.Drawing.Point(135, 180);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(187, 23);
            this.txtStaffName.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSex.Location = new System.Drawing.Point(9, 223);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(91, 22);
            this.lblSex.TabIndex = 18;
            this.lblSex.Text = "Giới Tính";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneNumber.Location = new System.Drawing.Point(9, 402);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(54, 22);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "SĐT :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStaffID.Location = new System.Drawing.Point(129, 80);
            this.txtStaffID.MaxLength = 5;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(154, 23);
            this.txtStaffID.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Location = new System.Drawing.Point(9, 449);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 22);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Địa Chỉ :";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStaffName.Location = new System.Drawing.Point(9, 180);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(80, 22);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ Tên :";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPosition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosition.Location = new System.Drawing.Point(9, 271);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 22);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Chức Vụ :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(136, 402);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(187, 23);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // pnTimeSheetsList
            // 
            this.pnTimeSheetsList.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTimeSheetsList.Controls.Add(this.lblTimeSheetsList);
            this.pnTimeSheetsList.Location = new System.Drawing.Point(2, 0);
            this.pnTimeSheetsList.Name = "pnTimeSheetsList";
            this.pnTimeSheetsList.Size = new System.Drawing.Size(815, 40);
            this.pnTimeSheetsList.TabIndex = 0;
            // 
            // lblTimeSheetsList
            // 
            this.lblTimeSheetsList.AutoSize = true;
            this.lblTimeSheetsList.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeSheetsList.ForeColor = System.Drawing.Color.Black;
            this.lblTimeSheetsList.Location = new System.Drawing.Point(3, 0);
            this.lblTimeSheetsList.Name = "lblTimeSheetsList";
            this.lblTimeSheetsList.Size = new System.Drawing.Size(277, 32);
            this.lblTimeSheetsList.TabIndex = 0;
            this.lblTimeSheetsList.Text = "Danh sách chấm công";
            // 
            // frmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 643);
            this.Controls.Add(this.pnTimeSheetsList);
            this.Controls.Add(this.pnInfoStaff);
            this.Controls.Add(this.dgvAttendanceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAttendanceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).EndInit();
            this.pnInfoStaff.ResumeLayout(false);
            this.pnInfoStaff.PerformLayout();
            this.pnTimeSheetsList.ResumeLayout(false);
            this.pnTimeSheetsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAttendanceList;
        private System.Windows.Forms.Panel pnInfoStaff;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblTimeSheets;
        private System.Windows.Forms.TextBox txtStaffID;
        private FontAwesome.Sharp.IconButton btnCheckIn;
        private FontAwesome.Sharp.IconButton btnFindStaff;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pnTimeSheetsList;
        private System.Windows.Forms.Label lblTimeSheetsList;
    }
}