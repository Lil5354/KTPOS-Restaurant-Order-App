using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPOS_Order.Proccess
{
    public class LgAccount
    {
        private static LgAccount instance;
        public static LgAccount Instance
        {
            get { if (instance == null) instance = new LgAccount(); return instance; }
            private set { instance = value; }
        }
        public bool Login(string email, string password)
        {
            string query = "SELECT * FROM ACCOUNT WHERE Email = N'" + email + "' AND [Password] =N'" + password + "' ";
            DataTable result = GetDatabase.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
