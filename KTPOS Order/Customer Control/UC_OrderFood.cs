using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_OrderFood : UserControl
    {
        string connectionString = "Data Source=KHOAZO\\MSSQLSERVER03;Initial Catalog=KTPOS;" + "Integrated Security=true";
        public UC_OrderFood()
        {
            InitializeComponent();
        }
        private void txtName_Click(object sender, EventArgs e)
        {

        }
       
        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_OrderFood_Load_1(object sender, EventArgs e)
        {
            try
            {
                FlowMenu.Controls.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT fName, Price FROM ITEM";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fName = reader["fName"].ToString();
                                decimal Price = Convert.ToDecimal(reader["Price"]);
                                UC_Item itemControl = new UC_Item(fName,Price);
                                FlowMenu.Controls.Add(itemControl);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
