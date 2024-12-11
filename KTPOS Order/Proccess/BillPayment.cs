using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPOS_Order.Proccess
{
    public class BillPayment
    {
        private static BillPayment instance;
        public static BillPayment Instance
        {
            get { if (instance == null) instance = new BillPayment(); return instance; }
            private set { instance = value; }
        }

        public void LoadDataPayment(string query, DataGridView dtgv)
        {
            DataTable data = new DataTable();
            data.Clear();
            try
            {
                // Call the ExecuteQuery method to get data from the database.
                data = GetDatabase.Instance.ExecuteQuery(query);

            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here.
                MessageBox.Show("Error loading account list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
