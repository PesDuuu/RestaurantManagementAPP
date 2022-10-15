
namespace QuanLyQuanAn
{
    partial class frmAdminStaff
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
            this.pnStaffInfo = new System.Windows.Forms.Panel();
            this.ptbRandomID = new FontAwesome.Sharp.IconPictureBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindStaffName = new FontAwesome.Sharp.IconButton();
            this.txtFindStaffName = new System.Windows.Forms.TextBox();
            this.btnEditStaff = new FontAwesome.Sharp.IconButton();
            this.btnShowStaff = new FontAwesome.Sharp.IconButton();
            this.btnDeleteStaff = new FontAwesome.Sharp.IconButton();
            this.btnAddStaff = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalStaff = new System.Windows.Forms.Label();
            this.pnStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRandomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStaffInfo
            // 
            this.pnStaffInfo.BackColor = System.Drawing.Color.DimGray;
            this.pnStaffInfo.Controls.Add(this.ptbRandomID);
            this.pnStaffInfo.Controls.Add(this.dtpDateOfBirth);
            this.pnStaffInfo.Controls.Add(this.rtbAddress);
            this.pnStaffInfo.Controls.Add(this.lblStaffInfo);
            this.pnStaffInfo.Controls.Add(this.lblStaffID);
            this.pnStaffInfo.Controls.Add(this.lblDateOfBirth);
            this.pnStaffInfo.Controls.Add(this.lblIdentityCard);
            this.pnStaffInfo.Controls.Add(this.cbbPosition);
            this.pnStaffInfo.Controls.Add(this.txtIdentityCard);
            this.pnStaffInfo.Controls.Add(this.txtSex);
            this.pnStaffInfo.Controls.Add(this.txtStaffName);
            this.pnStaffInfo.Controls.Add(this.lblSex);
            this.pnStaffInfo.Controls.Add(this.lblPhoneNumber);
            this.pnStaffInfo.Controls.Add(this.txtStaffID);
            this.pnStaffInfo.Controls.Add(this.lblAddress);
            this.pnStaffInfo.Controls.Add(this.lblStaffName);
            this.pnStaffInfo.Controls.Add(this.lblPosition);
            this.pnStaffInfo.Controls.Add(this.txtPhoneNumber);
            this.pnStaffInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnStaffInfo.Location = new System.Drawing.Point(823, 0);
            this.pnStaffInfo.Name = "pnStaffInfo";
            this.pnStaffInfo.Size = new System.Drawing.Size(332, 640);
            this.pnStaffInfo.TabIndex = 4;
            // 
            // ptbRandomID
            // 
            this.ptbRandomID.BackColor = System.Drawing.Color.Gray;
            this.ptbRandomID.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ptbRandomID.IconColor = System.Drawing.Color.White;
            this.ptbRandomID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbRandomID.IconSize = 31;
            this.ptbRandomID.Location = new System.Drawing.Point(301, 111);
            this.ptbRandomID.Name = "ptbRandomID";
            this.ptbRandomID.Size = new System.Drawing.Size(31, 37);
            this.ptbRandomID.TabIndex = 23;
            this.ptbRandomID.TabStop = false;
            this.ptbRandomID.Click += new System.EventHandler(this.ptbRandomID_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(133, 288);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(187, 30);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.Location = new System.Drawing.Point(133, 426);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(187, 118);
            this.rtbAddress.TabIndex = 11;
            this.rtbAddress.Text = "";
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffInfo.ForeColor = System.Drawing.Color.White;
            this.lblStaffInfo.Location = new System.Drawing.Point(3, 45);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(270, 32);
            this.lblStaffInfo.TabIndex = 3;
            this.lblStaffInfo.Text = "Thông Tin Nhân Viên";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(5, 114);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(74, 22);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "Mã NV :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(5, 291);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(103, 22);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Ngày Sinh :";
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdentityCard.ForeColor = System.Drawing.Color.White;
            this.lblIdentityCard.Location = new System.Drawing.Point(5, 334);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(72, 22);
            this.lblIdentityCard.TabIndex = 12;
            this.lblIdentityCard.Text = "CMND :";
            // 
            // cbbPosition
            // 
            this.cbbPosition.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Items.AddRange(new object[] {
            "Quản Lý",
            "Phục Vụ",
            "Đầu Bếp",
            "Thu Ngân"});
            this.cbbPosition.Location = new System.Drawing.Point(133, 244);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(187, 30);
            this.cbbPosition.TabIndex = 7;
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentityCard.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdentityCard.Location = new System.Drawing.Point(133, 334);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(187, 23);
            this.txtIdentityCard.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSex.Location = new System.Drawing.Point(133, 197);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(187, 23);
            this.txtSex.TabIndex = 6;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStaffName.Location = new System.Drawing.Point(133, 154);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(187, 23);
            this.txtStaffName.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(5, 200);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(91, 22);
            this.lblSex.TabIndex = 18;
            this.lblSex.Text = "Giới Tính";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 379);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(54, 22);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "SĐT :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStaffID.Location = new System.Drawing.Point(133, 112);
            this.txtStaffID.MaxLength = 5;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(162, 23);
            this.txtStaffID.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(5, 426);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 22);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Địa Chỉ :";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(5, 157);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(80, 22);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ Tên :";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(5, 247);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 22);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Chức Vụ :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(133, 379);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(187, 23);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.Location = new System.Drawing.Point(5, 92);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(807, 431);
            this.dgvStaff.TabIndex = 16;
            this.dgvStaff.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Chức Vụ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "CMND";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "SĐT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Địa Chỉ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnFindStaffName
            // 
            this.btnFindStaffName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFindStaffName.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindStaffName.IconColor = System.Drawing.Color.Black;
            this.btnFindStaffName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindStaffName.IconSize = 24;
            this.btnFindStaffName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindStaffName.Location = new System.Drawing.Point(5, 8);
            this.btnFindStaffName.Name = "btnFindStaffName";
            this.btnFindStaffName.Size = new System.Drawing.Size(201, 29);
            this.btnFindStaffName.TabIndex = 0;
            this.btnFindStaffName.Text = "Tra cứu nhân viên";
            this.btnFindStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindStaffName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindStaffName.UseVisualStyleBackColor = true;
            // 
            // txtFindStaffName
            // 
            this.txtFindStaffName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFindStaffName.Location = new System.Drawing.Point(211, 8);
            this.txtFindStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindStaffName.Multiline = true;
            this.txtFindStaffName.Name = "txtFindStaffName";
            this.txtFindStaffName.Size = new System.Drawing.Size(601, 28);
            this.txtFindStaffName.TabIndex = 1;
            this.txtFindStaffName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditStaff.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditStaff.IconColor = System.Drawing.Color.Black;
            this.btnEditStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditStaff.IconSize = 32;
            this.btnEditStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStaff.Location = new System.Drawing.Point(490, 529);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(98, 56);
            this.btnEditStaff.TabIndex = 13;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowStaff.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowStaff.IconColor = System.Drawing.Color.Black;
            this.btnShowStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowStaff.IconSize = 32;
            this.btnShowStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStaff.Location = new System.Drawing.Point(698, 529);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(114, 56);
            this.btnShowStaff.TabIndex = 15;
            this.btnShowStaff.Text = "Hiển Thị";
            this.btnShowStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowStaff.UseVisualStyleBackColor = true;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStaff.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteStaff.IconColor = System.Drawing.Color.Black;
            this.btnDeleteStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteStaff.IconSize = 32;
            this.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStaff.Location = new System.Drawing.Point(594, 529);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(98, 57);
            this.btnDeleteStaff.TabIndex = 14;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddStaff.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddStaff.IconColor = System.Drawing.Color.Black;
            this.btnAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStaff.IconSize = 32;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(386, 529);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(98, 56);
            this.btnAddStaff.TabIndex = 12;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotalStaff);
            this.panel1.Location = new System.Drawing.Point(5, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 28);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalStaff
            // 
            this.lblTotalStaff.AutoSize = true;
            this.lblTotalStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStaff.Location = new System.Drawing.Point(3, 5);
            this.lblTotalStaff.Name = "lblTotalStaff";
            this.lblTotalStaff.Size = new System.Drawing.Size(151, 19);
            this.lblTotalStaff.TabIndex = 2;
            this.lblTotalStaff.Text = "Tổng số nhân viên: ";
            // 
            // frmAdminStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnFindStaffName);
            this.Controls.Add(this.txtFindStaffName);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.pnStaffInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.pnStaffInfo.ResumeLayout(false);
            this.pnStaffInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRandomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnStaffInfo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.DataGridView dgvStaff;
        private FontAwesome.Sharp.IconButton btnFindStaffName;
        private System.Windows.Forms.TextBox txtFindStaffName;
        private FontAwesome.Sharp.IconButton btnEditStaff;
        private FontAwesome.Sharp.IconButton btnShowStaff;
        private FontAwesome.Sharp.IconButton btnDeleteStaff;
        private FontAwesome.Sharp.IconButton btnAddStaff;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private FontAwesome.Sharp.IconPictureBox ptbRandomID;
    }
}

