using QuanLyQuanTraSua.ADO;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyQuanTraSua
{
    public partial class frmManager : Form
    {

        BindingSource OrderList = new BindingSource();

        BindingSource accountList = new BindingSource();

        BindingSource tableList = new BindingSource();

        public frmManager()
        {
            InitializeComponent();

            LoadData();
        }
        public Account loginAccount;

        void LoadData()
        {
            dtgvOrder.DataSource = OrderList;
            dtgvAccount.DataSource = accountList;
            dtgvTables.DataSource = tableList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFrom_Date.Value, dtpTo_Date.Value);
            LoadListOrder();
            AddOrderBinding();
            LoadCategoryIntoCombobox(cbOrderCategory);
            AddAccountBinding();
            LoadAccount();
            LoadListTable();
            AddTableBinding();
        }

        void AddAccountBinding()
        {
            txtAccountName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtAccountDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nudAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            txtTableID.DataBindings.Add(new Binding("Text", dtgvTables.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("Text", dtgvTables.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountADO.Instance.GetListAccount();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountADO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void UpdateAccount(string userName, string displayName, int type)
        {
            if (AccountADO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản đang sử dụng");
                return;
            }
            if (AccountADO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountADO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }


        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFrom_Date.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo_Date.Value = dtpFrom_Date.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvEarnings.DataSource = BillADO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryADO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListOrder()
        {
            OrderList.DataSource = OrdersADO.Instance.GetListOrders();
        }


        void LoadListTable()
        {
            tableList.DataSource = TableADO.Instance.GetListTable();
        }

        void AddOrderBinding()
        {
            txtOrderName.DataBindings.Add(new Binding("Text", dtgvOrder.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtOrderID.DataBindings.Add(new Binding("Text", dtgvOrder.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nudOrderPrice.DataBindings.Add(new Binding("Value", dtgvOrder.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }


        List<Orders> SearchOrderByName(string name)
        {
            List<Orders> listOrder = OrdersADO.Instance.SearchOrdersByName(name);

            return listOrder;
        }


        //*****************************************************************************************************

        private void btnEarningView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFrom_Date.Value, dtpTo_Date.Value);
            txtNumPage.Text = "1";
        }

        private void btnOrderShow_Click(object sender, EventArgs e)
        {
            LoadListOrder();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvOrder.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvOrder.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryADO.Instance.GetCategoryByID(id);

                    cbOrderCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbOrderCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbOrderCategory.SelectedIndex = index;
                }
               
            }
            catch {  }
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            string name = txtOrderName.Text;
            int categoryID = (cbOrderCategory.SelectedItem as Category).ID;
            float price = (float)nudOrderPrice.Value;

            if (OrdersADO.Instance.InsertOrders(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListOrder();
                if (insertOrder != null)
                    insertOrder(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnOrderEdit_Click(object sender, EventArgs e)
        {
            string name = txtOrderName.Text;
            int categoryID = (cbOrderCategory.SelectedItem as Category).ID;
            float price = (float)nudOrderPrice.Value;
            int id = Convert.ToInt32(txtOrderID.Text);

            if (OrdersADO.Instance.UpdateOrders(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListOrder();
                if (updateOrder != null)
                    updateOrder(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOrderID.Text);

            if (OrdersADO.Instance.DeleteOrder(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListOrder();
                if (deleteOrder != null)
                    deleteOrder(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }


        private event EventHandler insertOrder;
        public event EventHandler InsertOrder
        {
            add { insertOrder += value; }
            remove { insertOrder -= value; }
        }

        private event EventHandler deleteOrder;
        public event EventHandler DeleteOrder
        {
            add { deleteOrder += value; }
            remove { deleteOrder -= value; }
        }

        private event EventHandler updateOrder;
        public event EventHandler UpdateOrder
        {
            add { updateOrder += value; }
            remove { updateOrder -= value; }
        }

//--------------------------------------------------
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OrderList.DataSource = SearchOrderByName(txtOrderSearch.Text);
            }
            catch { }
        }

        private void btnAccountShow_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            string userName = txtAccountName.Text;
            string displayName = txtAccountDisplayName.Text;
            int type = (int)nudAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            string userName = txtAccountName.Text;

            DeleteAccount(userName);
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            string userName = txtAccountName.Text;
            string displayName = txtAccountDisplayName.Text;
            int type = (int)nudAccountType.Value;

            UpdateAccount(userName, displayName, type);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string userName = txtAccountName.Text;

            ResetPass(userName);
        }

        private void btnGoToFirstPage_Click(object sender, EventArgs e)
        {
            txtNumPage.Text = "1";
        }

        private void btnGoToLastPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillADO.Instance.GetNumBillListByDate(dtpFrom_Date.Value, dtpTo_Date.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            txtNumPage.Text = lastPage.ToString();
        }

        private void txtNumPage_TextChanged(object sender, EventArgs e)
        {
            dtgvEarnings.DataSource = BillADO.Instance.GetBillListByDateAndPage(dtpFrom_Date.Value, dtpTo_Date.Value, Convert.ToInt32(txtNumPage.Text));
        }

        private void btnGoToNextPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtNumPage.Text);
            int sumRecord = BillADO.Instance.GetNumBillListByDate(dtpFrom_Date.Value, dtpTo_Date.Value);

            if (page < sumRecord)
                page++;

            txtNumPage.Text = page.ToString();
        }

        private void btnGoBackPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtNumPage.Text);

            if (page > 1)
                page--;

            txtNumPage.Text = page.ToString();
        }

        private void btnTableShow_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;

            if (TableADO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
                if (insertTable != null)
                   insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void btnTableEdit_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            int id = Convert.ToInt32(txtTableID.Text);

            if (TableADO.Instance.UpdateTable(name, id))
            {
                MessageBox.Show("Cập nhật bàn thành công");
                LoadListTable();    
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật bàn");
            }
        }

        private void btnTableDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtTableID.Text);

                if (TableADO.Instance.DeleteTable(id))
                {
                    MessageBox.Show("Xóa bàn thành công");
                    LoadListTable();
                    if (deleteTable != null)
                        deleteTable(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa bàn");
                }

            }
            catch { }
        }

    }

}
