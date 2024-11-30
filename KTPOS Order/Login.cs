using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPOS_Order
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void fLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            fCustomer cus = new fCustomer();
            cus.Show();
            this.Hide();
        }

        private void btnEyes_Click_2(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
                btnEyes.Visible = false;   
                btnHide.Visible = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnHide.Visible = false;    
                btnEyes.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinSize.Visible = false;
            btnMaxSize.Visible = true;
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxSize.Visible = false;
            btnMinSize.Visible = true;
        }
    }
}
