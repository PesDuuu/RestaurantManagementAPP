using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAdminTableFood : Form
    {
        public frmAdminTableFood()
        {
            InitializeComponent();
            Load();
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        #region Method
        void AddTable()
        {
            string nameTable = txtTableName.Text;
            if (nameTable != "")
            {
                if ((from t in rm.TableFoods where t.nameTable == nameTable select t).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên bàn đã tồn tại. Bạn có muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Info) == DialogResult.Yes)
                    {
                        rm.TableFoods.Add(new TableFood() { nameTable = nameTable });
                        if (rm.SaveChanges() > 0 )
                        {
                            msg.Show("Thêm bàn thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {

                    rm.TableFoods.Add(new TableFood() { nameTable = nameTable, statusTable = "Trống" });
                    rm.SaveChanges();
                    msg.Show("Thêm bàn thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    Load();
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void DeleteTable()
        {
            int idTable = Int32.Parse(txtTableID.Text);
            string name = txtTableName.Text;
            try
            {
                if (msg.Show("Bạn có chắc chắn muốn xóa " + name + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    rm.TableFoods.Remove((from t in rm.TableFoods where t.idTable == idTable select t).FirstOrDefault());
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã có lỗi xảy ra", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa bàn này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
            }
        }

        void EditTable()
        {
            int idTable = Int32.Parse(txtTableID.Text);
            string nameTable = txtTableName.Text;
            TableFood table = (from t in rm.TableFoods where t.nameTable == nameTable select t).FirstOrDefault();
            if (nameTable != "")
            {
                if (table != null)
                {
                    if (msg.Show("Tên bàn đã tồn tại.\n Bạn có muốn sửa tên bàn?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Warning) == DialogResult.Yes)
                    {
                        table.nameTable = nameTable;
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    table = (from t in rm.TableFoods where t.idTable == idTable select t).FirstOrDefault();
                    table.nameTable = nameTable;
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void Load()
        {
            LoadTableFood();
        }

        private void LoadTableFood()
        {
            int n = 0;
            dgvTableFood.Rows.Clear();
            foreach (var item in (from t in rm.TableFoods select t).ToList())
            {
                n = dgvTableFood.Rows.Add();
                dgvTableFood.Rows[n].Cells[0].Value = item.idTable;
                dgvTableFood.Rows[n].Cells[1].Value = item.nameTable;
                dgvTableFood.Rows[n].Cells[2].Value = item.statusTable;
            }
            lblTotalTableFood.Text = "Tổng số bàn ăn: " + dgvTableFood.Rows.Count.ToString();

            dgvTableFood.BorderStyle = BorderStyle.None;
            dgvTableFood.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvTableFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTableFood.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvTableFood.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTableFood.BackgroundColor = Color.White;

            dgvTableFood.EnableHeadersVisualStyles = false;
            dgvTableFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTableFood.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvTableFood.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void LoadListTableFoodByName(string tableName)
        {
            int n = 0;
            dgvTableFood.Rows.Clear();
            foreach (var item in (from t in rm.TableFoods where t.nameTable.Contains(tableName) select t).ToList())
            {
                n = dgvTableFood.Rows.Add();
                dgvTableFood.Rows[n].Cells[0].Value = item.idTable;
                dgvTableFood.Rows[n].Cells[1].Value = item.nameTable;
                dgvTableFood.Rows[n].Cells[2].Value = item.statusTable;
            }
            lblTotalTableFood.Text = "Tổng số bàn ăn: " + dgvTableFood.Rows.Count.ToString();

            dgvTableFood.BorderStyle = BorderStyle.None;
            dgvTableFood.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvTableFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTableFood.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvTableFood.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTableFood.BackgroundColor = Color.White;

            dgvTableFood.EnableHeadersVisualStyles = false;
            dgvTableFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTableFood.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvTableFood.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion
        #region Event
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddTable();
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            EditTable();
        }

        private void btnDeteleTable_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTableFood();
        }

        private void dgvTableFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvTableFood.Rows[rowIndex];
                txtTableID.Text = row.Cells[0].Value.ToString();
                txtTableName.Text = row.Cells[1].Value.ToString();
                txtTableStatus.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtFindTableName_TextChanged(object sender, EventArgs e)
        {
            LoadListTableFoodByName(txtFindTableName.Text);
        }
        #endregion
    }
}
