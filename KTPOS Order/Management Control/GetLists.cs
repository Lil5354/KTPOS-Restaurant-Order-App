using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

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
            // Return null if login fails
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
        //public int 
    }
}
