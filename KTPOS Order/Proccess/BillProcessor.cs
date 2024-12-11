using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTPOS_Order.Management_Control;

namespace KTPOS_Order.Proccess
{
    public class BillProcessor
    {
       
        public int BillID { get; private set; }
        public DataTable BillDetails { get; private set; }

        public BillProcessor(int billId)
        {
            BillID = billId;
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            string billDetailsQuery = @"
                SELECT i.fname AS ItemName, i.price AS UnitPrice, bi.count AS Quantity,
                       (i.price * bi.count) AS TotalPrice
                FROM BILLINF bi
                JOIN ITEM i ON bi.idFD = i.ID
                WHERE bi.idBill = @billId";

            BillDetails = GetDatabase.Instance.ExecuteQuery(billDetailsQuery, new object[] { BillID });
        }

    }
}

