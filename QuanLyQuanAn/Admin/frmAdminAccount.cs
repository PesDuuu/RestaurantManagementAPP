using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAdminAccount : Form
    {
        public frmAdminAccount()
        {
            InitializeComponent();
            Load();
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        #region Method
        void AddAccount()
        {
            string userName = txtAccountName.Text;
            string password = txtPassword.Text;
            string retypepass = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;
            if (userName == "" || password == "" || retypepass == "" || displayName == "" || idStaff == "" )
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin !!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
            }
            else
            {
                if ((from a in rm.Accounts where a.userName == userName select a).FirstOrDefault() != null)
                {
                    msg.Show("Tài khoản đã tồn tại !!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Error);
                }
                else
                {
                    if (!password.Equals(retypepass))
                    {
                        msg.Show("Mật khẩu nhập lại không trùng với mật khẩu mới","THÔNG BÁO",msg.Buttons.No,msg.Icon.Error);
                    }
                    else
                    {
                        if ((from a in rm.Staffs where a.idStaff == idStaff select a).FirstOrDefault() == null)
                        {
                            msg.Show("Mã nhân viên không tồn tại !","THÔNG BÁO",msg.Buttons.No,msg.Icon.Error);
                        }
                        else
                        {
                            try
                            {
                                if (rm.USP_InsertAccount(userName, password, displayName, typeAccount, idStaff) > 0)
                                {
                                    msg.Show("Tạo tài khoản thành công","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                                }
                            }
                            catch
                            {
                                msg.Show("Có lỗi khi tạo tài khoản","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Warning);
                            }
                        }
                    }
                    
                }
            }
        }

        void Load()
        {
            LoadAccount();
        }
        private void LoadAccount()
        {
            int n = 0;
            dgvAccount.Rows.Clear();
            foreach (var item in (from a in rm.Accounts select a).ToList())
            {
                n = dgvAccount.Rows.Add();
                dgvAccount.Rows[n].Cells[0].Value = item.userName;
                dgvAccount.Rows[n].Cells[1].Value = item.displayName;
                dgvAccount.Rows[n].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[n].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + dgvAccount.Rows.Count.ToString();

            dgvAccount.BorderStyle = BorderStyle.None;
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAccount.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAccount.BackgroundColor = Color.White;

            dgvAccount.EnableHeadersVisualStyles = false;
            dgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadListAccountByName(string username)
        {
            int n = 0;
            dgvAccount.Rows.Clear();
            foreach (var item in (from a in rm.Accounts where a.displayName.Contains(username) select a).ToList())
            {
                n = dgvAccount.Rows.Add();
                dgvAccount.Rows[n].Cells[0].Value = item.userName;
                dgvAccount.Rows[n].Cells[1].Value = item.displayName;
                dgvAccount.Rows[n].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[n].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + dgvAccount.Rows.Count.ToString();

            dgvAccount.BorderStyle = BorderStyle.None;
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAccount.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAccount.BackgroundColor = Color.White;

            dgvAccount.EnableHeadersVisualStyles = false;
            dgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void DeleteAccount()
        {
            string username = txtAccountName.Text.Trim();
            try
            {
                if (username == "" || (from a in rm.Accounts where a.userName == username select a).FirstOrDefault() == null)
                {
                    msg.Show("Tài khoản không hợp lệ. \n Vui lòng chọn đúng tài khoản cần xóa", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
                }
                else
                {
                    if (msg.Show("Bạn có chắc chắn muốn xóa tài khoản ? ", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Account account = (from a in rm.Accounts where a.userName == username select a).FirstOrDefault();
                            rm.Accounts.Remove(account);
                            if (rm.SaveChanges() > 0)
                            {
                                msg.Show("Xóa tài khoản thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            }
                        }
                        catch
                        {
                            msg.Show("Đã xảy ra lỗi khi xóa tài khoản", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                        }
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa tài khoản này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
            }
        }

        private void EditAccount()
        {
            string username = txtAccountName.Text.Trim();
            string password = txtPassword.Text;
            string retypepass = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;
            if (username == "" || displayName == "" || idStaff == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin !!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
            else
            {
                if ((from a in rm.Accounts where a.userName == username select a).FirstOrDefault() == null)
                {
                    msg.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                }
                else
                {
                    if (password != "")
                    {
                        msg.Show("Bạn không thể thay đổi mật khẩu tại đây !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
                    }
                    else
                    {
                        if ((from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault() == null)
                        {
                            msg.Show("Mã nhân viên không tồn tại !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                        }
                        else
                        {
                            try
                            {
                                Account account = (from s in rm.Accounts where s.userName == username select s).FirstOrDefault();
                                account.displayName = displayName;
                                account.typeAccount = typeAccount;
                                account.idStaff = idStaff;
                                account.userName = username;
                                if (rm.SaveChanges()> 0)
                                {
                                    msg.Show("Sửa thông tin khoản thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                }
                            }
                            catch
                            {
                                msg.Show("Có lỗi khi sửa thông tin tài khoản", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void ResetPassword()
        {
            string username = txtAccountName.Text.Trim();
            if (username == "" || (from s in rm.Accounts where s.userName == username select s).FirstOrDefault() == null)
            {
                msg.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần reset mật khẩu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
            else
            {
                if (msg.Show("Bạn có chắc chắn muốn đặt mật khẩu về mặc định?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Account account = (from s in rm.Accounts where s.userName == username select s).FirstOrDefault();
                        account.passWord = "@abc123";
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Đặt lại mật khẩu thành công.\nMật khẩu mặc định của bạn là: @abc123", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        }
                    }
                    catch
                    {
                        msg.Show("Đã xảy ra lỗi khi đặt lại mật khẩu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
        }
        #endregion 

        #region Event
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void txtFindAccountName_TextChanged(object sender, EventArgs e)
        {
            LoadListAccountByName(txtFindAccount.Text);
        }
        private void dgvAccount_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvAccount.Rows[rowIndex];
                txtAccountName.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                nudTypeAccount.Text = row.Cells[2].Value.ToString();
                txtIdStaff.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
            LoadAccount();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            LoadAccount();
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            EditAccount();
            LoadAccount(); 
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }
        #endregion
    }
}
