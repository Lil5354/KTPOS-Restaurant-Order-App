using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

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
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*string role = "Manager";
            fStaff f = new fStaff(role);
            this.Hide();
            f.ShowDialog();*/
            
            string email = txtUser.Text;
            string password = txtPass.Text;
            try
            {
                string role = LgAccount.Instance.LgManage(email, password);
                if (role != null)
                {
                    fStaff f = new fStaff(role);
                    this.Hide();
                    f.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Please enter a valid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled. Continue your activity ❤️.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
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

        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
