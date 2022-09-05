using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.ADO;
using QuanLyQuanTraSua.DTO;
using static QuanLyQuanTraSua.frmAccountProfile;
using Menu = QuanLyQuanTraSua.DTO.Menu;

namespace QuanLyQuanTraSua
{
    public partial class frmMain : Form
    {
        public List<Orders> billCheck = new List<Orders>();

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public frmMain(Account Acc)
        {
            InitializeComponent();

            this.LoginAccount = Acc;

            LoadTables();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        void ChangeAccount(int type)
        {
            quảnLýToolStripMenuItem.Enabled = type == 1;
            thôngTinToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadTables()
        {
            flpTables.Controls.Clear();

            List<Table> tableList = TableADO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableADO.TableWidth,
                    Height = TableADO.TableHeight
                };

                btn.Text = item.Name +/*(xuong hang)*/ Environment.NewLine  + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "In Use":
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.Yellow;
                        break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }

                flpTables.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lvBills.Items.Clear();
            List<Menu> listBillInfo = MenuADO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.OrderName.ToString());

                lvItem.SubItems.Add(item.Count.ToString());

                lvItem.SubItems.Add(item.Price.ToString());

                lvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;

                lvBills.Items.Add(lvItem); 
            }

            CultureInfo culture = new CultureInfo("vi-VN");

            txtTotalPrice.Text = totalPrice.ToString("c",culture);

        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryADO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadOrderListByCategory(int id)
        {
            List<Orders> listFood = OrdersADO.Instance.GetOrdersByCategoryID(id);
            cbListOrder.DataSource = listFood;
            cbListOrder.DisplayMember = "Name";
        }

       

        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableADO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvBills.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile frm = new frmAccountProfile(LoginAccount);
            frm.UpdateAccount += frm_UpdateAccount;
            frm.ShowDialog();
        }
        void frm_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager f = new frmManager();
            f.loginAccount = LoginAccount;

            f.InsertOrder += f_InsertOrder;
            f.DeleteOrder += f_DeleteOrder;
            f.UpdateOrder += f_UpdateOrder;

            f.InsertTable += f_InsertTable;
            f.DeleteTable += f_DeleteTable;
            f.UpdateTable += f_UpdateTable;

            f.ShowDialog();
        }

        void f_UpdateOrder(object sender, EventArgs e)
        {
            LoadOrderListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
        }

        void f_DeleteOrder(object sender, EventArgs e)
        {
            LoadOrderListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
            LoadTables();
        }

        void f_InsertOrder(object sender, EventArgs e)
        {
            LoadOrderListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
        }
        //----------------------------
        void f_UpdateTable(object sender, EventArgs e)
        {
            LoadTables();
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
        }

        void f_DeleteTable(object sender, EventArgs e)
        {
            LoadTables();
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
            LoadTables();
        }

        void f_InsertTable(object sender, EventArgs e)
        {
            LoadTables();
            if (lvBills.Tag != null)
                ShowBill((lvBills.Tag as Table).ID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadOrderListByCategory(id);
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillADO.Instance.GetUncheckedBillByTableID(table.ID);
            int OrdersID = (cbListOrder.SelectedItem as Orders).ID;
            int count = (int)nudCount.Value;

            if (idBill == -1)
            {
                BillADO.Instance.InsertBill(table.ID);
                BillInfoADO.Instance.InsertBillInfo(BillADO.Instance.GetMaxIDBill(), OrdersID, count);
            }
            else
            {
                BillInfoADO.Instance.InsertBillInfo(idBill, OrdersID, count);
            }

            ShowBill(table.ID);

            LoadTables();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillADO.Instance.GetUncheckedBillByTableID(table.ID);

            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);

            if (idBill != -1)
            {
                if (MessageBox.Show("Thanh toán hóa đơn cho " + table.Name,"Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillADO.Instance.CheckOut(idBill , (float) totalPrice);

                    ShowBill(table.ID);

                    LoadTables();
                   

                }
            }

        }

       private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int id1 = (lvBills.Tag as Table).ID;
            
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
           if (MessageBox.Show(string.Format("Bạn có thực sự muốn chuyển {0} đến {1}", (lvBills.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
               TableADO.Instance.SwitchTable(id1, id2);

               LoadTables();
      
            }
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddOrders_Click(this, new EventArgs());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheck_Click(this, new EventArgs());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            
        }


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog();
        }
    }

}
