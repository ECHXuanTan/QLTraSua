using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.ADO
{
    public class TableADO
    {
        public static int TableWidth = 65;
        public static int TableHeight = 65;


        private static TableADO instance;
        public static TableADO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableADO();
                return TableADO.instance;
            }
            set { TableADO.instance = value; }
        }
        private TableADO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("TableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void SwitchTable(int id1, int id2 )
        {
            DataProvider.Instance.ExecuteQuery("SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 } );
        }


        public List<Table> GetListTable()
        {
            List<Table> list = new List<Table>();

            string query = "select * from TableOrder";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table tbl = new Table(item);
                list.Add(tbl);
            }

            return list;
        }

        public Table GetTableByID(int id)
        {
            Table tableID = null;

            string query = "select * from TableOrder where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                tableID = new Table(item);
                return tableID;
            }

            return tableID;
        }

        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT into dbo.TableOrder ( Names ) VALUES  ( N'Bàn ' + '{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(string name, int id)
        {
            string query = string.Format("UPDATE dbo.TableOrder SET Names = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int id)
        {

            string query = string.Format("alter table Bill nocheck constraint all Delete  TableOrder where id = {0} alter table Bill check constraint all", id );

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
           
        }

    }
}
