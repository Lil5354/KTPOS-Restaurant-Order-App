using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using KTPOS_Order.Proccess;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KTPOS_Order.Management_Control
{
    public class GetLists
    {
        private static GetLists instance;
        public static GetLists Instance
        {
            get { if (instance == null) instance = new GetLists(); return instance; }
            private set { instance = value; }
        }
        private static void AutoBindColumns(DataGridView dgv, DataTable dataTable)
        {
            // Lặp qua tất cả các cột trong DataTable
            foreach (DataGridViewColumn dgvColumn in dgv.Columns)
            {
                // Kiểm tra xem HeaderText của cột DataGridView có trùng với tên cột trong DataTable không
                if (dataTable.Columns.Contains(dgvColumn.HeaderText))
                {
                    // Gán DataPropertyName cho cột trong DataGridView
                    dgvColumn.DataPropertyName = dgvColumn.HeaderText;
                }
            }
        }
        public void LoadAccountList(string query, DataGridView dtgv)
        {
            try
            {
                // Call the ExecuteQuery method to get data from the database.
                DataTable data = GetDatabase.Instance.ExecuteQuery(query);
                AutoBindColumns(dtgv, data);
                // Bind the data to the DataGridView.
                dtgv.DataSource = data;
                dtgv.ClearSelection();

            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here.
                MessageBox.Show("Error loading account list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int DeleteList(string name)
        {
            string query = "UPDATE ACCOUNT SET Visible = 0 WHERE FullName = N'" + name + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if function false
            return 0;
        }
        public int UpdateList(string fname, string name, string email, string role)
        {
            string query = "UPDATE ACCOUNT SET FullName = N'" + name + "', Email = '" + email + "',[Role] = '" + role + "'WHERE FullName = N'" + fname + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if function false
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
            // Return null if function false
            return 0;
        }
        public int InsertCate(string name)
        {
            string query = "INSERT INTO [F&BCATEGORY] (fname) VALUES (N'" + name + "' )";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }
        public int DeleteCate(string name) 
        {
            string query = "UPDATE [F&BCATEGORY] SET Visible = 0 WHERE fname = N'" + name + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }
        public int UpdateCate(string fname, string name)
        {
            string query = "UPDATE [F&BCATEGORY] SET fname = N'" + name + "''WHERE fname = N'" + fname + "' ";
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if login fails
            return 0;
        }

        public int InsertItem(string name,float price, string fname)
        {
            string query = "INSERT INTO ITEM (fname, idCategory, price) " +
                "SELECT N'" +name+"' AS fname, c.ID AS idCategory,'" +price+ "' AS price FROM [F&BCATEGORY] c " +
                "WHERE c.fname = '"+fname+"' "; 
            int result = GetDatabase.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return result;
            }
            // Return null if function false
            return 0;
        }
    }
}
