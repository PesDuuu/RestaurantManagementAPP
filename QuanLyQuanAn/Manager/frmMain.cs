using QuanLyQuanAn.Database;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyQuanAn
{
    public partial class frmMain : Form
    {
        
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.typeAccount); }
        }
        private FontAwesome.Sharp.IconButton currentbtn;
        private Panel leftBoardbtn;
        private Form currentchildform;
        public frmMain(Account acc)
        {
            InitializeComponent();
            Customer();
            leftBoardbtn = new Panel();
            leftBoardbtn.Size = new Size(7, 47);
            pnlMenu.Controls.Add(leftBoardbtn);
            LoginAccount = acc;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 179);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.DarkTurquoise;// FromArgb(20, 25, 72);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(255, 0, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Method
        void changeAccount(int type)
        {
            btnAdmin.Enabled = type == 1;
            btnWareHouse.Enabled = type == 1;
            btnOpenFormAttendance.Enabled = type == 1;
            //lblXinChao.Text = "Xin chào " + loginAccount.DisplayName + " !";
            btnDisplayName.Text = "Xin chào " + loginAccount.displayName + " !";
            //btnInfoAccount.Text += " (" + loginAccount.DisplayName + ")";
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisabaleButton();
                //Button
                currentbtn = (FontAwesome.Sharp.IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border
                leftBoardbtn.BackColor = color;
                leftBoardbtn.Visible = true;
                leftBoardbtn.BringToFront();
                //childform
                ptbChildForm.IconChar = currentbtn.IconChar;
                ptbChildForm.IconColor = color;
            }
        }
        private void DisabaleButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        private void Openchildform(Form chilform)
        {
            if (currentchildform != null)
                currentchildform.Close();
            currentchildform = chilform;
            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(chilform);
            pnDesktop.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
            lblHome.Text = chilform.Text;
        }


        private void Reset()
        {
            hidensub();
            DisabaleButton();
            leftBoardbtn.Visible = false;
            ptbChildForm.IconChar = IconChar.Home;
            ptbChildForm.IconColor = Color.Gainsboro;
            lblHome.Text = "Home";
        }
        

        private void Customer()
        {
            pnlAdmin.Visible = false;
            pnlWareHouse.Visible = false;
        }
        private void hidensub()
        {
            if (pnlAdmin.Visible == true)
                pnlAdmin.Visible = false;
            if (pnlWareHouse.Visible == true)
                pnlWareHouse.Visible = false;
        }
        private void showsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidensub();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region Event
        //Ẩn button
        private void ptblogo_Click(object sender, EventArgs e)
        {
            try
            {
                currentchildform.Close();
                Reset();
            }
            catch
            {

            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(msg.Show("Bạn có muốn đăng xuất?","THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hidensub();
            ActivateButton(sender, RGBcolors.color1);
            leftBoardbtn.Location = new Point(0, currentbtn.Location.Y);
            Openchildform(new frmTableManager(LoginAccount));
        }
        private void btnOpenFormAttendance_Click(object sender, EventArgs e)
        {
            hidensub();
            ActivateButton(sender, RGBcolors.color5);
            leftBoardbtn.Location = new Point(0, btnOpenFormAttendance.Location.Y);
            Openchildform(new frmAttendanceList());
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            leftBoardbtn.Location = new Point(0, btnAdmin.Location.Y);
            showsubmenu(pnlAdmin);
            Openchildform(new Admin.frmAdmin());
        }
        private void btnOpenFormAccount_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAdminAccount());
        }
        private void btnOpenFormFood_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAdminFood());
        }
        private void btnOpenFormRevenue_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAdminRevenue());
        }
        private void btnOpenFormTable_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAdminTableFood());
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAdminStaff());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Openchildform(new frmCategory());
        }
        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            leftBoardbtn.Location = new Point(0, btnAdmin.Location.Y + btnWareHouse.Size.Height);
            showsubmenu(pnlWareHouse);
            //Openchildform(new frmAdmin());
        }
        private void btnInfoWareHouse_Click(object sender, EventArgs e)
        {
            Openchildform(new frmWareHouse());
        }
        private void btnAddBillOfWareHouse_Click(object sender, EventArgs e)
        {
            Openchildform(new frmAddWareHouse(LoginAccount));
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            hidensub();
            ActivateButton(sender, RGBcolors.color6);
            leftBoardbtn.Location = new Point(0, btnInfo.Location.Y);
            Openchildform(new frmInfomation());
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            hidensub();
            ActivateButton(sender, RGBcolors.color4);
            leftBoardbtn.Location = new Point(0, btnFind.Location.Y);
            Openchildform(new frmManagerFood());
        }
        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            Form f = new frmAccount(LoginAccount);
            f.ShowDialog();
        }
        private void pnChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #endregion
    }
}
