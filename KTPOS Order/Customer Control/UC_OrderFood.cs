using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_OrderFood : UserControl
    {
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
            for (int i = 0; i < 10; i++)
            {
                this.FlowMenu.Controls.Add(new UC_Item(i.ToString()));
            }
        }
    }
}
