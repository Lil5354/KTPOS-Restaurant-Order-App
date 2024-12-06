using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public UC_OrderFood()
        {
            InitializeComponent();
            EnableLeftScrollBar(FlowMenu);
        }
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private const int GWL_STYLE = -16;
        private const int WS_VSCROLL = 0x00200000;
        private const int SBS_LEFTALIGN = 0x0020;

        private void EnableLeftScrollBar(Panel panel)
        {
            // Lấy handle của Panel
            IntPtr handle = panel.Handle;

            // Lấy style hiện tại của Panel
            int style = GetWindowLong(handle, GWL_STYLE);

            // Thêm style để di chuyển scrollbar sang bên trái
            SetWindowLong(handle, GWL_STYLE, style | WS_VSCROLL | SBS_LEFTALIGN);
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
