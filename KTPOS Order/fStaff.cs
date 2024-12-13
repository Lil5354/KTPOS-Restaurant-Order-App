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
using KTPOS_Order.Management_Control;
using KTPOS_Order.Staff_Control;

namespace KTPOS_Order
{
    public partial class fStaff : Form
    {
        private string userRole;
        private UserControl currentUserControl;
        public fStaff(string role)
        {
            InitializeComponent();
            this.userRole = role;
            ConfigureUIBasedOnRole();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
        }
        private void ConfigureUIBasedOnRole()
        {
            // Hide the manager button if the user role is Staff
            btnManage.Visible = userRole == "Manager";
        }
        public void AddUserControl(UserControl userControl)
        {
            if (currentUserControl != null)
            {
                this.Controls.Remove(currentUserControl);
                currentUserControl.Dispose(); // Đảm bảo giải phóng tài nguyên đúng cách
            }

            // Các cải tiến:
            userControl.SuspendLayout(); // Tạm dừng layout để giảm thiểu việc vẽ lại
            this.Controls.Add(userControl);
            userControl.Location = new Point(110, 90);
            userControl.Anchor = AnchorStyles.Top;
            userControl.BringToFront();
            userControl.ResumeLayout(true); // Khôi phục layout một cách hiệu quả

            currentUserControl = userControl;
        }
        private void btnListBill_Click(object sender, EventArgs e)
        {
            UC_ListBill ucStaff = new UC_ListBill();
            AddUserControl(ucStaff);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled. Continue your activity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
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
        private void btnManage_Click(object sender, EventArgs e)
        {
            UC_Admin ucAdmin = new UC_Admin(); ;
            AddUserControl(ucAdmin);
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            UC_Table ucStaff = new UC_Table ();
            AddUserControl(ucStaff);
        }
    }
}
