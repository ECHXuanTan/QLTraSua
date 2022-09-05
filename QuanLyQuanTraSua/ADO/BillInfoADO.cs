using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.ADO
{
    public class BillInfoADO
    {
        private static BillInfoADO instance;

        public static BillInfoADO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoADO();
                return BillInfoADO.instance;
            }
            set { BillInfoADO.instance = value; }
        }

        private BillInfoADO() { }

        public List<BillInfo> GetListBillInfo (int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo where idBill = " + id);

            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInfoByOrderID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idOrder = " + id);
        }

    }
}
