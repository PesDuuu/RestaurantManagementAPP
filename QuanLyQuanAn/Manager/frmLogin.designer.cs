
namespace QuanLyQuanAn
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lpForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.ptbUser = new FontAwesome.Sharp.IconPictureBox();
            this.ptbPassword = new FontAwesome.Sharp.IconPictureBox();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.White;
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(250, 330);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(373, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 1);
            this.panel2.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(373, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(288, 23);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "lat";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(373, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(288, 19);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "1";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(373, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 1);
            this.panel3.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(356, 53);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(316, 32);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "ĐĂNG NHẬP";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(426, 236);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(194, 40);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lpForgotPassword
            // 
            this.lpForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lpForgotPassword.AutoSize = true;
            this.lpForgotPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lpForgotPassword.LinkColor = System.Drawing.Color.Black;
            this.lpForgotPassword.Location = new System.Drawing.Point(473, 289);
            this.lpForgotPassword.Name = "lpForgotPassword";
            this.lpForgotPassword.Size = new System.Drawing.Size(113, 16);
            this.lpForgotPassword.TabIndex = 4;
            this.lpForgotPassword.TabStop = true;
            this.lpForgotPassword.Text = "Quên Mật Khẩu?";
            this.lpForgotPassword.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(703, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(16, 16);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.White;
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(682, 4);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(16, 16);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimize.TabIndex = 9;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.White;
            this.ptbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ptbUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ptbUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ptbUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbUser.Location = new System.Drawing.Point(335, 109);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(32, 32);
            this.ptbUser.TabIndex = 10;
            this.ptbUser.TabStop = false;
            // 
            // ptbPassword
            // 
            this.ptbPassword.BackColor = System.Drawing.Color.White;
            this.ptbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ptbPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ptbPassword.IconColor = System.Drawing.SystemColors.ControlText;
            this.ptbPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbPassword.Location = new System.Drawing.Point(335, 181);
            this.ptbPassword.Name = "ptbPassword";
            this.ptbPassword.Size = new System.Drawing.Size(32, 32);
            this.ptbPassword.TabIndex = 10;
            this.ptbPassword.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(724, 330);
            this.Controls.Add(this.ptbPassword);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lpForgotPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel lpForgotPassword;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ptbUser;
        private FontAwesome.Sharp.IconPictureBox ptbPassword;
    }
}

