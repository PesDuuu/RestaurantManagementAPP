using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAccount : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.typeAccount); }
        }

        public object AccountDao { get; private set; }

        public frmAccount(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        #region Method
        void changeAccount(int type)
        {
            txtAccountName.Text = loginAccount.userName;
            txtDisplayName.Text = loginAccount.displayName;
        }
        void updateAccount()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newpass = txtNewPassword.Text;
            string username = txtAccountName.Text;
            string retypepass = txtRetypePassword.Text;


            if(password == "")
            {
                msg.Show("Vui lòng nhập mật khẩu để cập nhật","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
            }
            else
            {
                if (!newpass.Equals(retypepass))
                {
                    msg.Show("Mật khẩu nhập lại không trùng với mật khẩu mới", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                else
                {
                    QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
                    Account account = (from acc in rm.Accounts where acc.userName == username select acc).First();
                    account.userName = username;
                    account.passWord = newpass;
                    account.displayName = displayName;
                    if(rm.SaveChanges() > 0)
                    {
                        msg.Show("Cập nhật thành công !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    }
                }
            }
        }
        #endregion
        #region Event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAccount();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
