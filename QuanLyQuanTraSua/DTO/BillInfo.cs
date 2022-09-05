using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int BillID, int OrderID , int count)
        {
            this.ID = id;
            this.ID_Bill = BillID;
            this.ID_Order = OrderID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int) row["id"];
            this.ID_Bill = (int) row ["idBill"];
            this.ID_Order = (int) row ["idOrder"];
            this.Count = (int) row ["count"];
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }

        }

        private int iD_Bill;
        public int ID_Bill
        {
            get { return iD_Bill; }
            set { iD_Bill = value; }
        }

        private int iD_Order;
        public int ID_Order
        {
            get { return iD_Order; }
            set { iD_Order = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


    }
}