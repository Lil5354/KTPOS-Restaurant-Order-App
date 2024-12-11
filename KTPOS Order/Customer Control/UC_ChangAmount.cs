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
    public partial class UC_ChangAmount : UserControl
    {
        public UC_ChangAmount()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        public UC_ChangAmount(decimal cost)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            tbNewAmount.Text = cost.ToString();
        }

        private void UC_ChangAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void UC_ChangAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Đóng hoặc ẩn UserControl
                this.Visible = false; // Hoặc: this.Parent.Controls.Remove(this);
                e.Handled = true; // Ngăn không cho xử lý tiếp tục
            }
        }

        private void tbNewAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
