using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

namespace KTPOS_Order.Management_Control
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAccountList()
        {
            string query = "SELECT FullName, Email, ExpY, [Role] FROM ACCOUNT ORDER BY [Role] ASC";

            try
            {
                // Call the ExecuteQuery method to get data from the database.
                DataTable data = GetDatabase.Instance.ExecuteQuery(query);
                dtgvAccount.Rows.Clear();
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
    }
}
