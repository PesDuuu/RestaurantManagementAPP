﻿using QuanLyQuanAn.Database;
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
    public partial class frmAddWareHouse : Form
    {
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        private Account loginAccount;
        public frmAddWareHouse(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Load();
        }

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; } //;
        }

        #region Method
        void Load()
        {
            loadListUnit();
            loadMaterialList();
            loadComboboxUnit();
            loadDetailOfBill();
            loadComboboxMaterial();
        }

        void loadListUnit()
        {
            int n = 0;
            dgvUnitList.Rows.Clear();
            List<Unit> unitList = (from u in rm.Units select u).ToList();
            foreach (var item in unitList)
            {
                n = dgvUnitList.Rows.Add();
                dgvUnitList.Rows[n].Cells[0].Value = item.idUnit;
                dgvUnitList.Rows[n].Cells[1].Value = item.nameUnit;
            }

            dgvUnitList.BorderStyle = BorderStyle.None;
            dgvUnitList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUnitList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnitList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvUnitList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUnitList.BackgroundColor = Color.White;

            dgvUnitList.EnableHeadersVisualStyles = false;
            dgvUnitList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUnitList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvUnitList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void addUnit()
        {
            string nameUnit = txtUnitName.Text.Trim();
            if (nameUnit != "")
            {
                Unit un = (from u in rm.Units where u.nameUnit == nameUnit select u).FirstOrDefault();
                if (un != null)
                {
                    if (msg.Show("Tên đơn vị đã tồn tại.\n Bạn có chắc chắn muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            rm.Units.Add(new Unit() { nameUnit = nameUnit });
                            rm.SaveChanges();
                            msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListUnit();
                        }
                        catch
                        {
                            msg.Show("Có lỗi khi thêm đơn vị tính", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    try
                    {
                        rm.Units.Add(new Unit() { nameUnit = nameUnit });
                        rm.SaveChanges();
                        msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadListUnit();
                    }
                    catch
                    {
                        msg.Show("Có lỗi khi thêm đơn vị tính", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập tên đơn vị tính!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void editUnit()
        {
            try
            {
                int idUnit = Int32.Parse(txtUnitID.Text);
                string name = txtUnitName.Text.Trim();
                if (name != "")
                {
                    try
                    {
                        int id = Int32.Parse(txtUnitID.Text);
                        Unit un = rm.Units.Find(id);
                        un.nameUnit = name;
                        rm.SaveChanges();
                        msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadListUnit();
                    }
                    catch
                    {
                        msg.Show("Có lỗi khi sửa đơn vị tính", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
                else
                {
                    msg.Show("Vui lòng nhập tên đơn vị tính!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
            }
            catch
            {
                msg.Show("Vui lòng chọn đơn vị tính cần sửa!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void deleteUnit()
        {
            try
            {
                int idUnit = Int32.Parse(txtUnitID.Text);
                if (idUnit.ToString() == "")
                {
                    msg.Show("Vui lòng chọn loại đơn vị cần xóa !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
                else
                {
                    if (msg.Show("Bạn có chắc chắn muốn xóa?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int id = Int32.Parse(txtUnitID.Text);
                            Unit un = rm.Units.Find(id);
                            rm.Units.Remove(un);
                            rm.SaveChanges();
                            msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListUnit();
                        }
                        catch
                        {
                            msg.Show("Bạn không thể xóa đơn vị tính", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                        }
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa đơn vị tính này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void loadComboboxUnit()
        {
            List<Unit> listUnit = (from u in rm.Units select u).ToList();
            cbbUnit.DataSource = listUnit;
            cbbUnit.DisplayMember = "nameUnit";
        }

        void loadComboboxMaterial()
        {
            List<Material> listMaterial = (from m in rm.Materials select m).ToList();
            cbbMaterialName.DataSource = listMaterial;
            cbbMaterialName.DisplayMember = "nameMaterial";
        }

        void loadMaterialList()
        {
            int n = 0;
            dgvMaterialList.Rows.Clear();
            List<Material> materials = (from m in rm.Materials select m).ToList();
            foreach (var item in materials)
            {
                n = dgvMaterialList.Rows.Add();
                dgvMaterialList.Rows[n].Cells[0].Value = item.idMaterial;
                dgvMaterialList.Rows[n].Cells[1].Value = item.nameMaterial;
                dgvMaterialList.Rows[n].Cells[2].Value = item.Unit.nameUnit;
            }
            dgvMaterialList.BorderStyle = BorderStyle.None;
            dgvMaterialList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMaterialList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaterialList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMaterialList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMaterialList.BackgroundColor = Color.White;

            dgvMaterialList.EnableHeadersVisualStyles = false;
            dgvMaterialList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaterialList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMaterialList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void loadDetailOfBill()
        {
            var billMax = rm.BillOfWareHouses.OrderByDescending(x => x.idBillOfWareHouse).FirstOrDefault();
            int idBillOfWareHouse = 1;
            if (billMax != null)
            {
                idBillOfWareHouse = billMax.idBillOfWareHouse + 1;
            }
            
            txtIdBillOfWareHouse.Text = idBillOfWareHouse.ToString();
            txtDate.Text = DateTime.Today.ToString().Split(' ')[0];
        }

        void addBillOfWareHouse()
        {
            string supplier = txtSupplier.Text.Trim();
            string note = rtbNote.Text;
            if(supplier == "")
            {
                msg.Show("Vui lòng nhập nhà cung cấp nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
            }
            else
            {
                if(lsvBillInfoOfWH.Items.Count > 0)
                {
                    //try
                    //{
                        if (rm.USP_InsertBillOfWareHouse(supplier, note, loginAccount.userName) > 0)
                        {
                            for (int i = 0; i < lsvBillInfoOfWH.Items.Count; i++)
                            {
                                int idBillOfWareHouse = Int32.Parse(txtIdBillOfWareHouse.Text);
                                string nameMaterial = lsvBillInfoOfWH.Items[i].SubItems[0].Text;
                                int idMaterial = (from m in rm.Materials where m.nameMaterial == nameMaterial select m.idMaterial).FirstOrDefault();
                                int number=  Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[1].Text);
                                int price = Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[2].Text);
                                int totalPrice = Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[3].Text);
                                try
                                {
                                    rm.USP_InsertBillInfoOfWareHouse(idBillOfWareHouse, idMaterial, number, price, totalPrice);
                                }
                                catch
                                {
                                    msg.Show("Đã xảy ra lỗi khi thêm", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                                }
                            }
                            msg.Show("Thêm hóa đơn nhập kho thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            printBill();
                            LoadSuccessInsert();
                        }
                    //}
                    //catch
                    //{
                    //    msg.Show("Đã xảy ra lỗi khi thêm !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    //}
                }
                else
                {
                    msg.Show("Vui lòng nhập nguyên liệu trước khi thêm hóa đơn", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
            }
        }
        
        void LoadSuccessInsert()
        {
            loadDetailOfBill();
            txtSupplier.Text = "";
            rtbNote.Text = "";
            lsvBillInfoOfWH.Items.Clear();
        }
        void DeleteMaterial()
        {
            try
            {
                int idMaterial = Int32.Parse(txtMaterialID.Text);
                if (idMaterial.ToString() == "")
                {
                    msg.Show("Vui lòng chọn loại nguyên liệu cần xóa !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
                else
                {
                    if (msg.Show("Bạn có chắc chắn muốn xóa?", "THÔNG BÁO", msg.Buttons.YesNo,msg.Icon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (rm.USP_DeleteMaterial(idMaterial) > 0)
                            {
                                msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                loadMaterialList();
                            }
                            else
                            {
                                msg.Show("Bạn không thể xóa nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                            }
                        }
                        catch
                        {
                            msg.Show("Bạn không thể xóa nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa nguyên liệu này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void EditMaterial()
        {
            try
            {
                int idMaterial = Int32.Parse(txtMaterialID.Text);
                string name = txtMaterialName.Text.Trim();
                Unit unit = (from u in rm.Units where u.nameUnit == cbbUnit.Text select u).FirstOrDefault();

                if (name != "")
                {
                    Material material = (from m in rm.Materials where m.idMaterial == idMaterial select m).FirstOrDefault();
                    material.nameMaterial = name;
                    material.idUnit = unit.idUnit;
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadMaterialList();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi sửa nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
                else
                {
                    msg.Show("Vui lòng nhập tên nguyên liệu!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
            }
            catch
            {
                msg.Show("Vui lòng chọn dòng nguyên liệu cần sửa", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void AddMaterial()
        {
            string name = txtMaterialName.Text.Trim();
            Unit unit = (from u in rm.Units where u.nameUnit == cbbUnit.Text select u).FirstOrDefault();
            if (name != "")
            {
                if ((from m in rm.Materials where m.nameMaterial == name select m).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên nguyên liệu đã tồn tại.\n Bạn có chắc chắn muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                    {
                        if (rm.USP_InsertMaterial(name,unit.idUnit) > 0)
                        {
                            msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadMaterialList();
                        }
                        else
                        {
                            msg.Show("Có lỗi khi thêm nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    if (rm.USP_InsertMaterial(name, unit.idUnit) > 0)
                    {
                        msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadMaterialList();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi thêm nguyên liệu", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập tên nguyên liệu!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void addBillInfoOfWareHouse()
        {
            int number, price;
            bool isNumber = Int32.TryParse(txtNumer.Text, out number);
            bool isPrice = Int32.TryParse(txtPrice.Text, out price);
            string material = cbbMaterialName.Text;
            if(isNumber && isPrice)
            {
                if(material == "")
                {
                    msg.Show("Vui lòng chọn loại nguyên liệu cần nhập", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
                }
                else
                {
                    ListViewItem lsvItem = new ListViewItem(material);
                    lsvItem.SubItems.Add(number.ToString());
                    lsvItem.SubItems.Add(price.ToString());
                    lsvItem.SubItems.Add((number*price).ToString());
                    lsvBillInfoOfWH.Items.Add(lsvItem);
                    txtPrice.Text = "";
                    txtNumer.Text = "";
                }
            }
            else
            {
                msg.Show("Vui lòng nhập số !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }
        void printBill()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }
        #endregion
        #region Event
        private void dgvUnitList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;
            try
            {
                txtUnitID.Text = dgvUnitList.Rows[selected].Cells[0].Value.ToString();
                txtUnitName.Text = dgvUnitList.Rows[selected].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string tencuahang = "Nhà Hàng A";
            string diachi = "46/1 Tân Hòa 2 ,Hiệp Phú, Thủ Đức";
            string phone = "0343405727";
            string idBill= txtIdBillOfWareHouse.Text;

            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawImage(Image.FromFile(@"./Image/Logo2.png"), w / 4 - 20, 20, 100, 100);
            e.Graphics.DrawString(tencuahang.ToUpper(), new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString(String.Format("Số hóa đơn: {0}", idBill), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 190, 85));
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
            e.Graphics.DrawString("HÓA ĐƠN NHẬP KHO", new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(w / 4, y - 10));
            //DateTime time = DateTime.Now;
            //e.Graphics.DrawString(String.Format("Giờ bắt đầu: {0}", time.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            //e.Graphics.DrawString(String.Format("Giờ kết thúc: {0}", time.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, y));
            y += 20;

            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;
            e.Graphics.DrawString(String.Format("Nhà cung cấp: {0}", txtSupplier.Text), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(40, y));
            y += 25;
            e.Graphics.DrawString(String.Format("Ghi chú: {0}", rtbNote.Text), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(40, y));
            y += 25;
            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString("Tên Nguyên liệu", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Số lượng", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 170, y));

            //int i = 1;
            y += 20;
            int flag = y;
            int sum = 0;
            for (int i = 0; i < lsvBillInfoOfWH.Items.Count; i++)
            {
                y += 20;
                sum += Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[3].Text);
                e.Graphics.DrawString(string.Format("{0}", i + 1), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(45, y));
                e.Graphics.DrawString(lsvBillInfoOfWH.Items[i].SubItems[0].Text, new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[1].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 5, y));
                e.Graphics.DrawString(Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[2].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBillInfoOfWH.Items[i].SubItems[3].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 165, y));
            }
            for (int i = 0; i < 20; i++)
            {
                flag += 20;
                e.Graphics.DrawString("............................................................................................................", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(45, flag + 4));

            }
            y += 20 * (20 - lsvBillInfoOfWH.Items.Count);
            y += 40;
            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 20;
            e.Graphics.DrawString(string.Format("Tổng tiền:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0:N0} VNĐ", sum), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - sum.ToString().Length * 10, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Thành chữ:", new NumberToText().ChuyenSoSangChuoi(sum)), new Font("Courier New", 10, FontStyle.Italic), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0}", new NumberToText().ChuyenSoSangChuoi(sum)), new Font("Courier New", 10, FontStyle.Italic), Brushes.Black, new Point(w - 40 - (new NumberToText().ChuyenSoSangChuoi(sum)).ToString().Length * 10, y));

            //y += 40;
            //e.Graphics.DrawString("Xin chân thành cảm ơn sự ủng hộ của quý khách!", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
            //e.Graphics.DrawImage(Image.FromFile(@"./Image/fivestars.png"), w / 4 + 20, y + 80, 400, 85);

        }
        private void btnShowUnit_Click(object sender, EventArgs e)
        {
            loadListUnit();
        }
        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            deleteUnit();
            loadComboboxUnit();
        }
        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            editUnit();
            loadComboboxUnit();
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            addUnit();
            loadComboboxUnit();
        }
        private void btnShowMaterial_Click(object sender, EventArgs e)
        {
            loadMaterialList();
        }
        private void dgvMaterialList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;
            try
            {
                txtMaterialID.Text = dgvMaterialList.Rows[selected].Cells[0].Value.ToString();
                txtMaterialName.Text = dgvMaterialList.Rows[selected].Cells[1].Value.ToString();
                cbbUnit.Text = dgvMaterialList.Rows[selected].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial();
            loadComboboxMaterial();
        }
        private void btnEditMaterial_Click(object sender, EventArgs e)
        {
            EditMaterial();
            loadComboboxMaterial();
        }
        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            DeleteMaterial();
            loadComboboxMaterial();
        }
        private void btnSaveBillOfWH_Click(object sender, EventArgs e)
        {
            addBillOfWareHouse();
        }
        private void btnAddBillInfo_Click(object sender, EventArgs e)
        {
            addBillInfoOfWareHouse();
        }
        #endregion
    }
}
