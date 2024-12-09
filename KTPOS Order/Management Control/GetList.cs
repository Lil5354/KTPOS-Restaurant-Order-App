using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTPOS_Order.Proccess;

namespace KTPOS_Order.Management_Control
{
    public class GetList
    {
        private static GetList instance;
        public static GetList Instance
        {
            get { if (instance == null) instance = new GetList(); return instance; }
            private set { instance = value; }
        }

        public int DeleteList(string name)
        {
            string query = "UPDATE ACCOUNT SET Visible = 0 WHERE FullName = N'" + name + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }
        
        public int UpdateList(string fname,string name, string email, string role)
        {
            string query = "UPDATE ACCOUNT SET FullName = N'" +name+ "', Email = '" +email+ "',[Role] = '" +role+ "'WHERE FullName = N'" + fname + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }
        public int InsertList(string name, string email, string role)
        {
            string query = "INSERT INTO ACCOUNT (FullName, Email, [Role]) VALUES (N'" + name + "','" + email + "','" + role + "' )";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }
    }
}
