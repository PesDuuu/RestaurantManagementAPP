using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyQuanAn.Database;
namespace QuanLyQuanAn
{
    public partial class frmLogin : Form
    {
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        bool Login(string userName, string passWord)
        {
            
            List<Account> login = (from acc in rm.Accounts
                        where acc.userName == userName && acc.passWord == passWord
                        select acc).ToList();
            return login.Count() > 0;
        }
        #endregion
        #region Event
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            if (Login(userName, passWord))
            {
                
                Account loginAccount = (from acc in rm.Accounts
                            where acc.userName == userName
                            select acc).First();
                frmMain f = new frmMain(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
                
                                  
            }
            else
            {
                msg.Show("Thông tin tài khoản không hợp lệ !", "THÔNG BÁO", msg.Buttons.No,msg.Icon.Error); //tùy m thôi cứ làm nháo nhào đi . ok bạn eei out đây
            }
        }
        #endregion
    }
}
