using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Classes;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Item : UserControl
    {
        public event EventHandler ItemClicked;
        private FoodList foodMenu;
        public UC_Item()
        {
            InitializeComponent();
        }

        public UC_Item(string str)
        {
            InitializeComponent();
            txtCost.Text = str;
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadDishes()
        {
            
        }

        private void Food1_Click(object sender, EventArgs e)
        {
            foodMenu.UpdateFoodItem("Pizza", "Pizza", 3);
        }

        private void Food1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
