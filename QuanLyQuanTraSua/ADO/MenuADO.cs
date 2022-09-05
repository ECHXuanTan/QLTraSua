using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.ADO
{
    public class MenuADO
    {
        private static MenuADO instance;

        public static MenuADO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new MenuADO(); 
                return MenuADO.instance; }
            set { MenuADO.instance = value; }
        }

        private MenuADO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.NameOrder, bi.count, f.price, f.price*bi.count AS totalPrice " +
                           "FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Orders AS f " +
                           "WHERE bi.idBill = b.id " +
                                "AND bi.idOrder = f.id " +
                                "AND b.status = 0" +
                                " AND b.idTable = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
