using QuanLyQuanAn.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            Load();
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        #region Method
        void Load()
        {
            LoadCategory();
        }

        
        private void LoadCategory()
        {
            int n = 0;
            dgvFoodCategory.Rows.Clear();
            foreach (var item in (from c in rm.FoodCategories select c).ToList())
            {
                n = dgvFoodCategory.Rows.Add();
                dgvFoodCategory.Rows[n].Cells[0].Value = item.idFC;
                dgvFoodCategory.Rows[n].Cells[1].Value = item.nameFC;
                dgvFoodCategory.Rows[n].Cells[2].Value = item.Foods.Count().ToString();
            }
            lblTotalCategory.Text = "Tổng số danh mục: " + dgvFoodCategory.Rows.Count.ToString();


            dgvFoodCategory.BorderStyle = BorderStyle.None;
            dgvFoodCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodCategory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodCategory.BackgroundColor = Color.White;

            dgvFoodCategory.EnableHeadersVisualStyles = false;
            dgvFoodCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void AddCategory()
        {
            string nameCategory = txtCategoryName.Text;
            if (nameCategory != "")
            {
                if ((from c in rm.FoodCategories where c.nameFC == nameCategory select c).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên danh mục đã tồn tại. Bạn có muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Question) == DialogResult.Yes)
                    {
                        rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Thêm danh mục thành công!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi thêm!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Thêm danh mục thành công!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi thêm!","THÔNG BÁO",msg.Buttons.No,msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
            }
        }

        void DeleteCategory()
        {
            int idCategory = Int32.Parse(txtCategoryID.Text);
            string nameCategory = txtCategoryName.Text;
            //DialogResult result = msg.Show("Bạn có chắc chắn muốn xóa danh mục " + nameCategory + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question);
            try
            {
                if (msg.Show("Bạn có chắc chắn muốn xóa danh mục " + nameCategory + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    FoodCategory category = (from c in rm.FoodCategories where c.nameFC == nameCategory select c).FirstOrDefault();
                    rm.FoodCategories.Remove(category);
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
                msg.Show("Bạn không thể xóa danh mục này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
            }
        }

        void EditFoodCategory()
        {
            int idCategory = Int32.Parse(txtCategoryID.Text);
            string nameCategory = txtCategoryName.Text;
            if (nameCategory != "")
            {
                FoodCategory category = (from c in rm.FoodCategories where c.nameFC == nameCategory select c).FirstOrDefault();
                if (category != null)
                {
                    if (msg.Show("Tên danh mục đã tồn tại.\n Bạn có muốn sửa tên danh mục?", "Sửa danh mục món ăn", msg.Buttons.YesNo,msg.Icon.Question) == DialogResult.Yes)
                    {
                        category.nameFC = nameCategory;
                        if (rm.SaveChanges() >  0)
                        {
                            msg.Show("Sửa danh mục thành công!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi sửa!","THÔNG BÁO",msg.Buttons.No,msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    FoodCategory cat = (from c in rm.FoodCategories where c.idFC == idCategory select c).FirstOrDefault();
                    cat.nameFC = nameCategory;
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
                msg.Show("Vui lòng nhập đầy đủ!","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Info);
            }
        }

        void LoadListCategoryByName(string CategoryName)
        {
            int n = 0;
            dgvFoodCategory.Rows.Clear();
            foreach (var item in (from c in rm.FoodCategories where c.nameFC.Contains(CategoryName) select c).ToList())
            {
                n = dgvFoodCategory.Rows.Add();
                dgvFoodCategory.Rows[n].Cells[0].Value = item.idFC;
                dgvFoodCategory.Rows[n].Cells[1].Value = item.nameFC;
            }
            lblTotalCategory.Text = "Tổng số danh mục: " + dgvFoodCategory.Rows.Count.ToString();


            dgvFoodCategory.BorderStyle = BorderStyle.None;
            dgvFoodCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodCategory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodCategory.BackgroundColor = Color.White;

            dgvFoodCategory.EnableHeadersVisualStyles = false;
            dgvFoodCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion
        #region Event
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            EditFoodCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void btnShowCatetory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void dgvFoodCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodCategory.Rows[rowIndex];
                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtFindCategoryName_TextChanged(object sender, EventArgs e)
        {
            LoadListCategoryByName(txtFindCategoryName.Text);
        }
        #endregion
    }
}
