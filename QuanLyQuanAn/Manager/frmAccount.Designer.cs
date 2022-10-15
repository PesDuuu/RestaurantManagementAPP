namespace QuanLyQuanAn
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ptbUser = new FontAwesome.Sharp.IconPictureBox();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtAccountName);
            this.panel2.Controls.Add(this.lblAccountName);
            this.panel2.Location = new System.Drawing.Point(17, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 46);
            this.panel2.TabIndex = 1;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(148, 11);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(179, 26);
            this.txtAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountName.Location = new System.Drawing.Point(15, 14);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(130, 19);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtRetypePassword);
            this.panel1.Controls.Add(this.lblRetypePassword);
            this.panel1.Location = new System.Drawing.Point(17, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 46);
            this.panel1.TabIndex = 2;
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtRetypePassword.Location = new System.Drawing.Point(148, 12);
            this.txtRetypePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(179, 26);
            this.txtRetypePassword.TabIndex = 5;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRetypePassword.Location = new System.Drawing.Point(15, 14);
            this.lblRetypePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(83, 19);
            this.lblRetypePassword.TabIndex = 0;
            this.lblRetypePassword.Text = "Nhập Lại:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtNewPassword);
            this.panel3.Controls.Add(this.lblNewPassword);
            this.panel3.Location = new System.Drawing.Point(17, 343);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 46);
            this.panel3.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.Location = new System.Drawing.Point(148, 12);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(179, 26);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewPassword.Location = new System.Drawing.Point(15, 14);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(119, 19);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Mật Khẩu Mới:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.lblPassword);
            this.panel4.Location = new System.Drawing.Point(17, 292);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 46);
            this.panel4.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(148, 12);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(15, 14);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật Khẩu :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.txtDisplayName);
            this.panel5.Controls.Add(this.lblDisplayName);
            this.panel5.Location = new System.Drawing.Point(17, 242);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 46);
            this.panel5.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(148, 11);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(179, 26);
            this.txtDisplayName.TabIndex = 2;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplayName.Location = new System.Drawing.Point(15, 14);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(111, 19);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Tên Hiển Thị:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(269, 442);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.Transparent;
            this.ptbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ptbUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ptbUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ptbUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbUser.IconSize = 133;
            this.ptbUser.Location = new System.Drawing.Point(118, 54);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(144, 133);
            this.ptbUser.TabIndex = 6;
            this.ptbUser.TabStop = false;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.Location = new System.Drawing.Point(53, 20);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(259, 31);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Cập nhật tài khoản";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(165, 443);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(368, 486);
            this.Controls.Add(this.lblUpdateAccount);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccountProfile";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Button btnExit;
        private FontAwesome.Sharp.IconPictureBox ptbUser;
        private System.Windows.Forms.Label lblUpdateAccount;
        private System.Windows.Forms.Button btnUpdate;
    }
}