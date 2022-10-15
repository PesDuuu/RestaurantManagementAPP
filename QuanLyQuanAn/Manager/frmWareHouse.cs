using QuanLyQuanAn.Database;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmWareHouse : Form
    {
        public frmWareHouse()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadBillOfWareHouse();
        }
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();

        void loadBillOfWareHouse()
        {
            int n = 0;
            dgvBillOfWareHouseList.Rows.Clear();
            List<BillOfWareHouse> bwh = (from bw in rm.BillOfWareHouses select bw).ToList();
            foreach (var item in bwh) // BillOfWareHouseDAO.Instance.GetListBillOfWareHouse())
            {
                n = dgvBillOfWareHouseList.Rows.Add();
                dgvBillOfWareHouseList.Rows[n].Cells[0].Value = item.idBillOfWareHouse;
                dgvBillOfWareHouseList.Rows[n].Cells[1].Value = item.dateAdded.ToString().Split(' ')[0]; //String.Format("{0}/{1}/{2}", item.DateAdded.Month,item.DateAdded.Day,item.DateAdded.Year); //
                dgvBillOfWareHouseList.Rows[n].Cells[2].Value = item.supplier;
                dgvBillOfWareHouseList.Rows[n].Cells[3].Value = item.note;
            }
            //n = dgvBillOfWareHouseList.Rows.Add();
            //dgvBillOfWareHouseList.Rows[n].Cells[0].Value = "Mã hóa đơn";
            //dgvBillOfWareHouseList.Rows[n].Cells[1].Value = "Ngày Nhập Hàng";
            //dgvBillOfWareHouseList.Rows[n].Cells[2].Value = "Nhà cung cấp";
            //dgvBillOfWareHouseList.Rows[n].Cells[3].Value = "Ghi Chú";
            //dgvBillOfWareHouseList.Rows[n].DefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dgvBillOfWareHouseList.Rows[n].DefaultCellStyle.ForeColor = Color.White;

            lblTotalBill.Text = "Tổng số hóa đơn: " + (dgvBillOfWareHouseList.Rows.Count).ToString();

            dgvBillOfWareHouseList.BorderStyle = BorderStyle.None;
            dgvBillOfWareHouseList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvBillOfWareHouseList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBillOfWareHouseList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvBillOfWareHouseList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvBillOfWareHouseList.BackgroundColor = Color.White;

            dgvBillOfWareHouseList.EnableHeadersVisualStyles = false;
            dgvBillOfWareHouseList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBillOfWareHouseList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvBillOfWareHouseList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void loadBillInfoOfWareHouseById(int idBillOfWareHouseList)
        {
            lsvBillInfoOfWH.Items.Clear();
            int totalPirce = 0;
            foreach (var item in (from biwh in rm.BillInfoOfWareHouses where biwh.idBillOfWareHouse == idBillOfWareHouseList select biwh).ToList())// BillInfoOfWareHouseDAO.Instance.GetListBillInfoOfWareHouseByIdBill(idBillOfWareHouseList))
            {
                ListViewItem lsvItem = new ListViewItem(item.Material.nameMaterial);
                lsvItem.SubItems.Add(item.number.ToString());
                lsvItem.SubItems.Add(item.price.ToString());
                lsvItem.SubItems.Add(item.totalPrice.ToString());
                totalPirce += item.totalPrice;
                lsvBillInfoOfWH.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = totalPirce.ToString();
            
        }
        #endregion

        #region Event
        private void dgvBillOfWareHouseList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            try
            {
                int select = e.RowIndex;
                loadBillInfoOfWareHouseById(select + 1);
                txtBillOfWareHouseID.Text = dgvBillOfWareHouseList.Rows[select].Cells[0].Value.ToString();
                txtDate.Text = dgvBillOfWareHouseList.Rows[select].Cells[1].Value.ToString();
                txtSupplier.Text = dgvBillOfWareHouseList.Rows[select].Cells[2].Value.ToString();
                rtbNote.Text = dgvBillOfWareHouseList.Rows[select].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        #endregion
    }
}
