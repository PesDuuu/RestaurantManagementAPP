using QuanLyQuanAn.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmAdminFood : Form
    {

        

        public frmAdminFood()
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
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        private void LoadListFood()
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            foreach (var item in (from f in rm.Foods select f).ToList())
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
            List<FoodCategory> listCategoryFood = (from c in rm.FoodCategories select c).ToList();
            cbbFoodCategory.DataSource = listCategoryFood;
            cbbFoodCategory.DisplayMember = "nameFC";
        }


        void LoadImageFoodByIdFood(int id)
        {
            String image = (from f in rm.Foods where f.idFood == id select f.imageFood).FirstOrDefault();
            Image img = GetCopyImage(@"./Image/food/" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        void AddFood()
        {
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;
            if (name != "" && float.TryParse(txtPrice.Text, out price))
            {
                if ((from f in rm.Foods where f.nameFood == name select f).FirstOrDefault() != null )
                {
                    if (msg.Show("Tên món ăn đã tồn tại. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Warning) == DialogResult.Yes)
                    {
                        if (linkImage == "")
                        {
                            if (msg.Show("Bạn vẫn chưa tải hình món ăn lên. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                            {
                                if (rm.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                                {
                                    msg.Show("Thêm thành công","THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                    LoadListFood();
                                }
                                else
                                {
                                    msg.Show("Có lỗi khi thêm món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                                }
                            }
                        }
                        else
                        {
                            if (rm.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                            {
                                msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                LoadListFood();
                            }
                            else
                            {
                                msg.Show("Có lỗi khi thêm món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                            }
                        }
                    }
                }
                else
                {
                    if (rm.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                    {
                        msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        LoadListFood();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi thêm món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                    }
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
            }
        }

        void GetFile()
        {
            System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
            openImage.Title = "Select your image";
            openImage.InitialDirectory = "C:";
            openImage.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openImage.AutoUpgradeEnabled = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                String Chosen_File = openImage.FileName;

                string filename = System.IO.Path.GetFileName(Chosen_File);
                String inputExt = (Path.GetExtension(filename).ToLower());
                try
                {
                    System.IO.File.Copy(Chosen_File, @"./Image/food/" + filename);
                }
                catch
                {
                }
                Invoke((MethodInvoker)delegate
                {
                    lblLinkImage.Text = filename;
                    ptbImageOfFood.Image = new Bitmap(Chosen_File);
                    ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
                });
            }
            //else
            //{
            //    lblLinkImage.Text = "";
            //}
        }

        void DeleteFood()
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                string name = txtFoodID.Text;
                string linkImage = lblLinkImage.Text;
                if (msg.Show("Bạn có chắc chắn muốn xóa món " + name + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    Food food = (from f in rm.Foods where f.idFood == idFood select f).FirstOrDefault();
                    rm.Foods.Remove(food);
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        if (File.Exists(@"./Image/food/" + linkImage))
                        {
                            File.Delete(@"./Image/food/" + linkImage);
                        }
                        LoadListFood();
                    }
                    else
                    {
                        msg.Show("Đã có lỗi xảy ra", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa món ăn này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void EditFood()
        {
            int idFood = Int32.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;
            if (name != "" && float.TryParse(txtPrice.Text, out price))
            {
                Food food = (from f in rm.Foods where f.idFood == idFood select f).FirstOrDefault();
                if (linkImage == "")
                {
                    if (msg.Show("Bạn vẫn chưa tải hình món ăn lên.\n Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        food.nameFood = name;
                        food.idFC = idCategory;
                        food.price = price;
                        food.imageFood = linkImage;
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            LoadListFood();
                        }
                        else
                        {
                            msg.Show("Có lỗi khi sửa món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                        }
                    }
                }
                else
                {
                    food.nameFood = name;
                    food.idFC = idCategory;
                    food.price = price;
                    food.imageFood = linkImage;
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        LoadListFood();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi sửa món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                }
            }
        }

        private void LoadListFoodByName(string name)
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            foreach (var item in (from f in rm.Foods where f.nameFood.Contains(name) select f).ToList())
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
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            EditFood();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DeleteFood();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();

        }

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
                cbbFoodCategory.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch
            {

            }
        }

        [Obsolete]
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            Thread threadGetFile = new Thread(new ThreadStart(GetFile));
            threadGetFile.ApartmentState = ApartmentState.STA;
            threadGetFile.Start();
        }
        private void statusOn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                if(!ChangeStatus(cbStatus.Checked == true, idFood))
                {
                    //msg.Show("Đã có lỗi xảy ra","THÔNG BÁO",msg.Buttons.No,msg.Icon.Error);
                }
                LoadListFood();
            }
            catch
            {
                msg.Show("Vui lòng chọn món trước khi điều chỉnh","THÔNG BÁO",msg.Buttons.Yes,msg.Icon.Warning);
            }
        }

        public bool ChangeStatus(bool status, int idFood)
        {
            Food food = (from f in rm.Foods where f.idFood == idFood select f).FirstOrDefault();
            food.statusFood = "Đang bán";
            //string query = string.Format("update food set statusFood = N'Đang bán' where idFood = " + idFood);
            if (status == false) food.statusFood = "Tạm ngưng";// query = string.Format("update food set statusFood = N'Tạm ngưng' where idFood = " + idFood);
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            return rm.SaveChanges() > 0;
        }

        private void txtFindFoodName_TextChanged(object sender, EventArgs e)
        {
            LoadListFoodByName(txtFindFoodName.Text);
        }
        #endregion
    }
}
