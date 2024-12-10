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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_OrderFood : UserControl
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        decimal Total = 0;

        public static List<ListViewItem> listItems = new List<ListViewItem>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        public UC_OrderFood()
        {
            InitializeComponent();
        }

        public void AddUserControlToFlowPanel(UserControl uc)
        {
            FlowMenu.Controls.Add(uc);
        }
        private void txtName_Click(object sender, EventArgs e)
        {

        }
       
        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_OrderFood_Load_1(object sender, EventArgs e)
        {

        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
