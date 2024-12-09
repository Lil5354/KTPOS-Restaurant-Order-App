using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KTPOS_Order.Management_Control
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }
        private void LoadAccountList()
        {
            dtgvAccount.DataSource = null;
            // Clear existing rows (if necessary, e.g., for unbound data).
            dtgvAccount.Rows.Clear();
            string query = "SELECT FullName, Email, ExpY, [Role], [Password] FROM ACCOUNT WHERE Visible = 1 Order by [Role] ASC";
            try
            {
                // Call the ExecuteQuery method to get data from the database.
                DataTable data = GetDatabase.Instance.ExecuteQuery(query);
                // Bind the data to the DataGridView.
                dtgvAccount.DataSource = data;
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here.
                MessageBox.Show("Error loading account list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void account_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAcc_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            /*string query = "INSERT INTO ACCOUNT (FullName, Email, ExpY, [Role]) VALUES (@FullName, @Email, @ExpY, @Role)";

            try
            {
                // Execute the query with parameters.
                GetDatabase.Instance.ExecuteQuery(query, new object[] { fullName, email, expY, role });
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the account list after creation.
                LoadAccountList();
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions.
                MessageBox.Show("Error creating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dtgvAccount.CurrentCell.RowIndex;
            string name = Convert.ToString(dtgvAccount.Rows[CurrentIndex].Cells[0].Value.ToString());
            try
            {
                int n = GetList.Instance.DeleteList(name);
                if (n > 0)
                {
                    MessageBox.Show("Account delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountList();
                }
                else
                {
                    MessageBox.Show("Error delete account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error creating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void txtSearchAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
