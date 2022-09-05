using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.ADO
{
    public class OrdersADO
    {
        private static OrdersADO instance;

        public static OrdersADO Instance
        {
            get 
            { 
                if (instance == null)
                    instance = new OrdersADO();
                return OrdersADO.instance;
            }
            set { OrdersADO.instance = value; }
        }

        private OrdersADO() { }

        public List<Orders> GetOrdersByCategoryID(int id)
        {
            List<Orders> list = new List<Orders>();

            string query = "select * from Orders where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Orders order = new Orders(item);
                list.Add(order);
            }

            return list;
        }

        public List<Orders> GetListOrders()
        {
            List<Orders> list = new List<Orders>();

            string query = "select * from Orders";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Orders order = new Orders(item);
                list.Add(order);
            }

            return list;
        }

        public List<Orders> SearchOrdersByName(string name)
        {

            List<Orders> list = new List<Orders>();

            string query = string.Format("SELECT * FROM dbo.Orders WHERE dbo.fuConvertToUnsignString(NameOrder) LIKE N'%' + dbo.fuConvertToUnsignString(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Orders order = new Orders(item);
                list.Add(order);
            }

            return list;
        }

        public bool InsertOrders(string name, int id, float price)
        {
            string query = string.Format("INSERT into dbo.Orders ( NameOrder, idCategory, price ) VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateOrders(int idOrders, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Orders SET NameOrder = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idOrders);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOrder(int idOrder)
        {
            BillInfoADO.Instance.DeleteBillInfoByOrderID(idOrder);

            string query = string.Format("Delete Orders where id = {0}", idOrder);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
