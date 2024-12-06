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
using KTPOS_Order.Staff_Control;

namespace KTPOS_Order
{
    public partial class fStaff : Form
    {
        private UserControl currentUserControl;
        public fStaff()
        {
            InitializeComponent();
        }
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
        private void btnListBill_Click(object sender, EventArgs e)
        {
            UC_ListBill ucStaff = new UC_ListBill();
            AddUserControl(ucStaff);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
