using QuanLyQuanAn.Admin;
using QuanLyQuanAn.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmTableManager : Form
    {
        public static int TableWidth = 110;
        public static int TableHeight = 110;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; } //;
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();

        public frmTableManager(Account acc) //Account acc
        {
            InitializeComponent();
            LoginAccount = acc;
            LoadTable();
            LoadCategory();
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        #region Method
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<TableFood> tableList = (from t in rm.TableFoods select t).ToList();
            foreach (TableFood item in tableList)
            {
                Button btn = new Button() { Width =TableWidth, Height = TableHeight };
                btn.Text = item.nameTable +Environment.NewLine + item.statusTable;
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.TabStop = false;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                switch (item.statusTable)
                {
                    case "Trống":
                        btn.Image = Image.FromFile(@".\Image\trong.png");
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                        btn.FlatStyle = FlatStyle.Flat;
                        break;
                    default:
                        btn.Image = Image.FromFile(@".\Image\conguoi.png");
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        break;

                }
                flpTable.Controls.Add(btn);
            }

        }

        void LoadCategory()
        {
            
            List<FoodCategory> listCategoryFood = (from c in rm.FoodCategories select c).ToList();
            cbCategory.DataSource = listCategoryFood;
            cbCategory.DisplayMember = "nameFC";
        }

        void LoadFoodListByIdCategory(int id)
        {
            List<Food> listFood = (from c in rm.Foods where c.idFC == id && c.statusFood.Contains("Đang bán") select c).ToList();
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "nameFood";

        }

        void LoadImageFoodByIdFood(int id)
        {
            String image = (from f in rm.Foods where f.idFood == id select f.imageFood).FirstOrDefault().ToString();
            if (image == null)
            {
                image = "default.png";
            }
            Image img = GetCopyImage(@"./Image/food/" + image);
            pbFood.Image = img;
            pbFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void LoadPriceFoodByIdFood(int id)
        {
            float price = (float)((from f in rm.Foods where f.idFood == id select f.price).FirstOrDefault());
            CultureInfo culture = CultureInfo.CurrentCulture;
            lblFoodPrice.Text = double.Parse(price.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            var listBillInfo = (from bi in rm.BillInfoes
                                join b in rm.Bills on bi.idBill equals b.idBill
                                join f in rm.Foods on bi.idFood equals f.idFood
                                where b.statusBill == 0 && b.idTable == id
                                select new
                                {
                                    f.nameFood,
                                    bi.countFood,
                                    f.price,
                                    
                                });
            foreach(var item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.nameFood.ToString());
                lsvItem.SubItems.Add(item.countFood.ToString());
                lsvItem.SubItems.Add(item.price.ToString());
                lsvItem.SubItems.Add((item.price* item.countFood).ToString());
                totalPrice += float.Parse((item.price * item.countFood).ToString());
                lsvBill.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            CultureInfo culture = CultureInfo.CurrentCulture;

            //Thread.CurrentThread.CurrentCulture = culture;
            if (double.Parse(totalPrice.ToString()) != 0)
                txtTotalPrice.Text = double.Parse(totalPrice.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
            else
                txtTotalPrice.Text = "";
            //txbTotalPrice.Text = totalPrice.ToString("c",culture);       
        }
        void printBill()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }
        #endregion

        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).idTable;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount(LoginAccount);
            f.ShowDialog();
            this.Show();
        }

        //private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmAdmin f = new frmAdmin();
        //    f.ShowDialog();
        //}  

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.idFC;

            LoadFoodListByIdCategory(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if(table != null)
            {
                int idBill = -1;
                List<Bill> bills = (from b in rm.Bills where b.idTable == table.idTable && b.statusBill == 0 select b).ToList();
                foreach (Bill item in bills)
                {
                    idBill = item.idBill;
                }
                
                int idFood = (cbFood.SelectedItem as Food).idFood;
                int count = (int)nmCountFood.Value;
                if (idBill == -1)
                {
                    rm.USP_InsertBill(table.idTable);
                    int idBillMax = (from b in rm.Bills select b.idBill).Max();
                    rm.USP_InsertBillInfo(idBillMax, idFood, count);
                }
                else
                {
                    rm.USP_InsertBillInfo(idBill, idFood, count);
                }
                table.statusTable = "Có người";
                ShowBill(table.idTable);
                LoadTable();
            }
            else
            {
                msg.Show("Vui lòng chọn bàn để thêm món! ", "THÔNG BÁO", msg.Buttons.Yes,msg.Icon.Info);
            }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table != null)
            {
                int idBill = -1;
                List<Bill> bills = (from b in rm.Bills where b.idTable == table.idTable && b.statusBill == 0 select b).ToList();
                foreach (Bill item in bills)
                {
                    idBill = item.idBill;
                }
                int discount = (int)nmGiamGia.Value;
                string payerId = LoginAccount.userName;
                if (idBill != -1)
                {
                    float totalPrice = float.Parse((txtTotalPrice.Text).ToString().Split(' ')[0]);
                    float finalTotalPrice = (totalPrice - totalPrice * discount / 100);
                    if (msg.Show(string.Format("Bạn có muốn thành toán cho bàn {0}\nTổng tiền: {1}đ\nSố tiền của bạn sau khi được giảm giá {2}% là: {3}đ", table.nameTable, totalPrice,discount, finalTotalPrice),"THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Success) == DialogResult.Yes)
                    {
                        printBill();
                        rm.USP_CheckOut( discount, finalTotalPrice, payerId,idBill);
                        ShowBill(table.idTable);
                        table.statusTable = "Trống";
                        LoadTable();
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng chọn bàn để thêm món! ", "THÔNG BÁO", msg.Buttons.Yes,msg.Icon.Warning);
            }
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idF = 0;
            ComboBox cb = (sender) as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Food selected = cb.SelectedItem as Food;
            idF = selected.idFood;

            LoadImageFoodByIdFood(idF);
            LoadPriceFoodByIdFood(idF);
        }

        private void btnInfoAccount_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount(LoginAccount);
            f.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }
        private void pbReloadTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tencuahang = "Nhà Hàng A";
            var diachi = "46/1 Tân Hòa 2, Hiệp Phú, Thủ Đức";
            var phone = "0343405727";
            TableFood table = lsvBill.Tag as TableFood;


            var hd = -1;
            var dateCheckIn = DateTime.Now ;
            List<Bill> bills = (from b in rm.Bills where b.idTable == table.idTable && b.statusBill == 0 select b).ToList();
            foreach (Bill item in bills)
            {
                hd = item.idBill;
                dateCheckIn = item.dateCheckIn;
            }

            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawImage(Image.FromFile(@"./Image/Logo2.png"),w / 4 - 20,20,100,100);
            e.Graphics.DrawString(tencuahang.ToUpper(), new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString(String.Format("Số hóa đơn: {0}", hd), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 190, 85));
            e.Graphics.DrawString(table.nameTable, new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 220, 140));
            Pen blackPen = new Pen(Color.Black, 1);
            Point p1 = new Point(w / 2 + 180, 105);
            Point p2 = new Point(w - 40, 105);
            e.Graphics.DrawLine(blackPen, p1, p2);

            p1 = new Point(w / 2 + 190, 108);
            p2 = new Point(w - 50, 108);
            e.Graphics.DrawLine(blackPen, p1, p2);

            e.Graphics.DrawString(string.Format("{0} - {1}", diachi, phone), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(70, 160));
            e.Graphics.DrawString(String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 110));


            var y = 200;
            p1 = new Point(80, y);
            p2 = new Point(w - 80, y);
            e.Graphics.DrawLine(blackPen, p1, p2);


            y += 20;
            e.Graphics.DrawString("HÓA ĐƠN GỌI MÓN", new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(w/4, y - 10));
            DateTime time = DateTime.Now;
            y += 30;
            e.Graphics.DrawString(String.Format("Thời gian vào: {0}", dateCheckIn.ToString("MM/dd/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(String.Format("Thời gian thanh toán: {0}", time.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, y));
            

            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString("Tên món", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 170, y));

            //int i = 1;
            y += 20;
            int flag = y;
            //int sum = 0;
            for(int i =0; i < lsvBill.Items.Count; i++)
            {
                y += 20;
                //sum += Int32.Parse(lsvBill.Items[i].SubItems[3].Text);
                e.Graphics.DrawString(string.Format("{0}", i+1), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(45, y));
                e.Graphics.DrawString(lsvBill.Items[i].SubItems[0].Text, new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[1].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 5, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[2].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[3].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 165, y));
            }
            for(int i =0;i < 20; i++)
            {
                flag += 20;
                e.Graphics.DrawString("............................................................................................................", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(45, flag + 4));

            }
            y += 20*(20 - lsvBill.Items.Count);
            y += 40;
            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            int discount = (int)nmGiamGia.Value;
            float totalPrice = float.Parse((txtTotalPrice.Text).ToString().Split(' ')[0]);
            float finalTotalPrice = (totalPrice - totalPrice * discount / 100);
            y += 20;
            e.Graphics.DrawString(string.Format("Tổng tiền:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0:N0} VNĐ", totalPrice), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - totalPrice.ToString().Length*10, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Giảm giá:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("-{0:N0} VNĐ({1}%)", totalPrice * discount/100,discount), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - totalPrice.ToString().Length * 10, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Thành tiền:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0:N0} VNĐ", finalTotalPrice), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - finalTotalPrice.ToString().Length * 10, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Thành chữ:", new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)), new Font("Courier New",10, FontStyle.Italic), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0}", new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)), new Font("Courier New",10, FontStyle.Italic), Brushes.Black, new Point(w - 40 - (new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)).ToString().Length*10, y));

            y += 40;
            e.Graphics.DrawString("Xin chân thành cảm ơn sự ủng hộ của quý khách!", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
            e.Graphics.DrawImage(Image.FromFile(@"./Image/fivestars.png"), w / 4 + 20 , y + 80,400,85);

        }
        #endregion
    }
}
