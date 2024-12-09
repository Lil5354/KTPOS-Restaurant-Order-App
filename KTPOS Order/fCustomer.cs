using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Customer_Control;

namespace KTPOS_Order
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private UserControl currentUserControl;
        public void AddUserControl(UserControl userControl)
        {
            // Xóa UserControl hiện tại (nếu có)
            if (currentUserControl != null)
            {
                this.Controls.Remove(currentUserControl);
                currentUserControl.Dispose();
            }

            // Thêm UserControl mới
            this.Controls.Add(userControl);
            userControl.Location = new Point(110, 103);
            userControl.Anchor = AnchorStyles.Top;
            userControl.BringToFront();

            // Cập nhật tham chiếu
            currentUserControl = userControl;
        }
        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxSize.Visible = false;
            btnMinSize.Visible = true;
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinSize.Visible = false;
            btnMaxSize.Visible = true;
        }

        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            UC_OrderFood ucOrderFood = new UC_OrderFood();
            AddUserControl(ucOrderFood);
        }

        private void btnFoodOptions_Click(object sender, EventArgs e)
        {
            UC_OrderFoodOption ucOrderFood = new UC_OrderFoodOption();
            AddUserControl(ucOrderFood);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            UC_OrderDrink ucOrderFood = new UC_OrderDrink();
            AddUserControl(ucOrderFood);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UC_Payment ucOrderFood = new UC_Payment();
            AddUserControl(ucOrderFood);
        }

        private void btnChat_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void RemoveSpecificUserControl(UserControl userControl)
        {
            if (this.Controls.Contains(userControl))
            {
                this.Controls.Remove(userControl);
                userControl.Dispose(); 
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
