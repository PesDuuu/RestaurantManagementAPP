using QuanLyQuanAn.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmManagerFood : Form
    {
        public frmManagerFood()
        {
            InitializeComponent();
            load();

        }

        #region Method

        void load()
        {
            LoadListFood();
            LoadCategory();
        }

        private void LoadListFood()
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            List<Food> listFood = (from f in rm.Foods select f).ToList();
            foreach (var item in listFood)
            {
                n = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[n].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[n].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[n].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[n].Cells[3].Value = item.price;
                dgvFoodList.Rows[n].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[n].Cells[5].Value = item.statusFood;
            }
            lblTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            dgvFoodList.BorderStyle = BorderStyle.None;
            dgvFoodList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodList.BackgroundColor = Color.White;

            dgvFoodList.EnableHeadersVisualStyles = false;
            dgvFoodList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        void LoadCategory()
        {
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            List<FoodCategory> listCategoryFood = (from c in rm.FoodCategories select c).ToList();
            cbbCategory.DataSource = listCategoryFood;
            cbbCategory.DisplayMember = "nameFC";
        }


        void LoadImageFoodByIdFood(int id)
        {
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            String image = (from f in rm.Foods where f.idFood == id select f.imageFood).FirstOrDefault().ToString();
            if(image == null)
            {
                image = "default.png";
            }
            //String image = FoodDAO.Instance.GetLinkImageByFood(id);
            Image img = GetCopyImage(@"./Image/food/" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
            //ptbImageOfFood.Image = new Bitmap(@"./Image/food/" + image);
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        private void LoadListFoodByName(string name)
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            List<Food> listFood = (from f in rm.Foods where f.nameFood.Contains(name) select f).ToList();
            foreach (var item in listFood)
            {
                n = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[n].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[n].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[n].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[n].Cells[3].Value = item.price;
                dgvFoodList.Rows[n].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[n].Cells[5].Value = item.statusFood;
            }
            dgvFoodList.BorderStyle = BorderStyle.None;
            dgvFoodList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodList.BackgroundColor = Color.White;

            dgvFoodList.EnableHeadersVisualStyles = false;
            dgvFoodList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        #endregion
        #region Event
        private void dgvFoodList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodList.Rows[rowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                lblLinkImage.Text = row.Cells[4].Value.ToString();
                cbStatus.Checked = row.Cells[5].Value.ToString() == "Đang bán";
                cbbCategory.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch
            {

            }
        }
        private void statusOn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
                Food food = (from f in rm.Foods where f.idFood == idFood select f).First();
                food.statusFood = (cbStatus.Checked == true) ? "Đang bán" : "Tạm ngưng";
                if (!(rm.SaveChanges()> 0))
                {
                    msg.Show("Đã có lỗi xảy ra", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                LoadListFood();
            }
            catch
            {
                msg.Show("Vui lòng chọn món trước khi điều chỉnh", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
            }
        }
        private void txtFindFoodName_TextChanged(object sender, EventArgs e)
        {
            LoadListFoodByName(txtFindFoodName.Text);
        }
        #endregion
    }
}
