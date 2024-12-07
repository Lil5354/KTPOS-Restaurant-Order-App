using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Item : UserControl
    {

        public UC_Item()
        {
            InitializeComponent();
            txtName.Width = btnItem.Width;
            txtName.Dock = DockStyle.Fill;
        }

        public UC_Item(string fName, decimal Price)
        {
            InitializeComponent();
            txtName.Text = fName;
            txtCost.Text = $"${Price:0.00}";
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
        }
    }
}
