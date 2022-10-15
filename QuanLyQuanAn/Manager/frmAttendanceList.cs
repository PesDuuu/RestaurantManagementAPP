using QuanLyQuanAn.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAttendanceList : Form
    {
        public frmAttendanceList()
        {
            InitializeComponent();
            loadListAttendance();
        }

        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        #region Method
        void loadListAttendance()
        {
            int n = 0;
            dgvAttendanceList.Rows.Clear();
            List<AttendanceList> attendanceList = (from a in rm.AttendanceLists select a).ToList();
            foreach (var item in attendanceList)
            {
                n = dgvAttendanceList.Rows.Add();
                dgvAttendanceList.Rows[n].Cells[0].Value = item.id;
                dgvAttendanceList.Rows[n].Cells[1].Value = item.idStaff;
                dgvAttendanceList.Rows[n].Cells[2].Value = (from s in rm.Staffs where s.idStaff == item.idStaff select s.nameStaff).FirstOrDefault().ToString();
                dgvAttendanceList.Rows[n].Cells[3].Value = item.dateCheckIn.ToString();
            }

            dgvAttendanceList.BorderStyle = BorderStyle.None;
            dgvAttendanceList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAttendanceList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendanceList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAttendanceList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAttendanceList.BackgroundColor = Color.White;

            dgvAttendanceList.EnableHeadersVisualStyles = false;
            dgvAttendanceList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAttendanceList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAttendanceList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void showInfoStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            Staff staff = (from s in rm.Staffs where s.idStaff == idStaff select s).FirstOrDefault();
            if (staff != null)
            {
                txtStaffName.Text = staff.nameStaff;
                txtPhoneNumber.Text = staff.phoneNumber;
                txtSex.Text = staff.sex;
                txtIdentityCard.Text = staff.identityCard;
                rtbAddress.Text = staff.address;
                txtPosition.Text = staff.Position.namePosition;
                txtDateOfBirth.Text = staff.dateOfBirth.ToString().Split(' ')[0];
            }
            else
            {
                msg.Show("Mã nhân viên không tồn tại", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
            
        }
        void ResetText()
        {
            txtDateOfBirth.Text = "";
            txtIdentityCard.Text = "";
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtPhoneNumber.Text = "";
            txtPosition.Text = "";
            txtSex.Text = "";
            rtbAddress.Text = "";
        }
        #endregion
        #region Event
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string nameStaff = txtStaffName.Text.Trim();
            string idStaff = txtStaffID.Text.Trim();
            if (nameStaff == "")
            {
                msg.Show("Vui lòng kiểm tra thông tin nhân viên trước khi chấm công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
            }
            else
            {
                if (rm.USP_CheckExitsAttendanceList(idStaff).Count() > 0)
                {
                    msg.Show("Nhân viên đã điểm danh", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                    ResetText();
                }
                else
                {
                    try
                    {
                        if (rm.USP_InsertAttendanceList(idStaff)> 0)
                        {
                            msg.Show("Điểm danh thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListAttendance();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi xảy ra khi điểm danh", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                    }
                }
            }
        }
        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            showInfoStaff();
        }
        #endregion
    }
}
