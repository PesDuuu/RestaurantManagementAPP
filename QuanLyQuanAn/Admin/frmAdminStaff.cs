using QuanLyQuanAn.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAdminStaff : Form
    {
        public frmAdminStaff()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadComboboxPosition();
            loadStaffList();
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();

        void loadComboboxPosition()
        {
            List<Position> listPosition = (from p in rm.Positions select p).ToList(); // PositionDAO.Instance.GetListPosition();
            cbbPosition.DataSource = listPosition;
            cbbPosition.DisplayMember = "namePosition";
        }
        private void loadStaffList()
        {
            int n = 0;
            dgvStaff.Rows.Clear();
            foreach (var item in (from s in rm.Staffs select s).ToList())
            {
                n = dgvStaff.Rows.Add();
                dgvStaff.Rows[n].Cells[0].Value = item.idStaff;
                dgvStaff.Rows[n].Cells[1].Value = item.nameStaff;
                dgvStaff.Rows[n].Cells[2].Value = item.sex;
                dgvStaff.Rows[n].Cells[3].Value = item.Position.namePosition;
                dgvStaff.Rows[n].Cells[4].Value = item.dateOfBirth.ToString().Split(' ')[0];
                dgvStaff.Rows[n].Cells[5].Value = item.identityCard;
                dgvStaff.Rows[n].Cells[6].Value = item.phoneNumber;
                dgvStaff.Rows[n].Cells[7].Value = item.address;
            }

            lblTotalStaff.Text = "Tổng số nhân viên: " + dgvStaff.Rows.Count.ToString();

            dgvStaff.BorderStyle = BorderStyle.None;
            dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStaff.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvStaff.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvStaff.BackgroundColor = Color.White;

            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void AddStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            string nameStaff = txtStaffName.Text.Trim();
            string sex = txtSex.Text.Trim();
            Position position = (from p in rm.Positions where p.namePosition== cbbPosition.Text select p).FirstOrDefault(); //PositionDAO.Instance.getIdByName(cbbPosition.Text.Trim());
            DateTime dateOfBirth = dtpDateOfBirth.Value;//Text.Trim();
            string identityCard = txtIdentityCard.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = rtbAddress.Text.Trim();
            if (idStaff == "" || nameStaff == "" || identityCard == "" || phoneNumber == "" || address == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
            }
            else
            {
                if ((from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault() != null)
                {
                     msg.Show("Mã nhân viên đã tồn tại. Vui lòng lấy mã khác!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        rm.USP_InsertStaff(idStaff, nameStaff, sex, position.idPosition, dateOfBirth, identityCard, phoneNumber, address);
                        msg.Show("Thêm thành công !","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                    }
                    catch
                    {
                        msg.Show("Đã xảy ra lỗi thi sửa, vui lòng kiểm tra lại !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
        }

        void EditStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            if(idStaff == "" || (from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault() == null)
            {
                msg.Show("Vui lòng chọn nhân viên cần sửa!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
                return;
            }
            string nameStaff = txtStaffName.Text.Trim();
            string sex = txtSex.Text.Trim();
            Position position = (from p in rm.Positions where p.namePosition == cbbPosition.Text select p).FirstOrDefault();
            DateTime dateOfBirth = dtpDateOfBirth.Value;//Text.Trim();
            string identityCard = txtIdentityCard.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = rtbAddress.Text.Trim();
            if ( nameStaff == "" || identityCard == "" || phoneNumber == "" || address == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
            else
            {
                try
                {
                    Staff staff = (from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault();
                    staff.nameStaff = nameStaff;
                    staff.sex = sex;
                    staff.idPosition = position.idPosition;
                    staff.dateOfBirth = dateOfBirth;
                    staff.identityCard = identityCard;
                    staff.phoneNumber = phoneNumber;
                    staff.address = address;
                    if(rm.SaveChanges() > 0)
                    {
                        msg.Show("Sửa thành công !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    }
                    
                }
                catch
                {
                    msg.Show("Đã xảy ra lỗi khi sửa, vui lòng kiểm tra lại !","THÀNH CÔNG",msg.Buttons.No,msg.Icon.Error);
                }
            }
        }

        void DeleteStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            Staff staff = (from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault();
            if (idStaff == "" || staff == null)
            {
                msg.Show("Vui lòng chọn nhân viên cần xóa!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                return;
            }
            if ((from a in rm.Accounts where a.idStaff == idStaff select a).FirstOrDefault() != null)
            {
                msg.Show("Vui lòng xóa tài khoản trước khi xóa nhân viên", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
            }
            else
            {
                try
                {
                    if (msg.Show("Bạn có chắc chắn muốn xóa?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                    {
                        rm.Staffs.Remove(staff);
                        rm.SaveChanges();
                        loadStaffList();
                        msg.Show("Xóa thành công !","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                    }
                }
                catch
                {
                    msg.Show("Bạn không thể xóa nhân viên này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
            }
        }
        private void LoadListStaffByName(string name)
        {
            int n = 0;
            dgvStaff.Rows.Clear();
            foreach (var item in (from s in rm.Staffs where s.nameStaff.Contains(name) select s).ToList())
            {
                n = dgvStaff.Rows.Add();
                dgvStaff.Rows[n].Cells[0].Value = item.idStaff;
                dgvStaff.Rows[n].Cells[1].Value = item.nameStaff;
                dgvStaff.Rows[n].Cells[2].Value = item.sex;
                dgvStaff.Rows[n].Cells[3].Value = item.Position.namePosition;
                dgvStaff.Rows[n].Cells[4].Value = item.dateOfBirth.ToString().Split(' ')[0];
                dgvStaff.Rows[n].Cells[5].Value = item.identityCard;
                dgvStaff.Rows[n].Cells[6].Value = item.phoneNumber;
                dgvStaff.Rows[n].Cells[7].Value = item.address;
            }

            dgvStaff.BorderStyle = BorderStyle.None;
            dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStaff.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvStaff.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvStaff.BackgroundColor = Color.White;

            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        #endregion
        #region Event
        private void dgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvStaff.Rows[rowIndex];
                txtStaffID.Text = row.Cells[0].Value.ToString();
                txtStaffName.Text = row.Cells[1].Value.ToString();
                txtSex.Text = row.Cells[2].Value.ToString();
                cbbPosition.Text = row.Cells[3].Value.ToString();
                txtIdentityCard.Text = row.Cells[5].Value.ToString();
                dtpDateOfBirth.Text = row.Cells[4].Value.ToString();
                txtPhoneNumber.Text = row.Cells[6].Value.ToString();
                rtbAddress.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            loadStaffList();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff();
            loadStaffList();
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
            loadStaffList();
        }
        private void ptbRandomID_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            txtStaffID.Text = randomNumber.ToString();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff();
            
        }
        private void txtFindName_TextChanged(object sender, EventArgs e)
        {
            LoadListStaffByName(txtFindStaffName.Text);
        }
        #endregion
    }
}
