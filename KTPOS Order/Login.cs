using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

namespace KTPOS_Order
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint, true);

            // Hoặc nếu muốn chi tiết hơn
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;

            // Đặt StartPosition là CenterScreen để căn giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(800, 450);
            btnMinSize.BringToFront();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*string role = "Manager";
            fStaff f = new fStaff(role);
            this.Hide();
            f.ShowDialog();*/
            string email = txtUser.Text;
            string password = txtPass.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string role = LgAccount.Instance.LgManage(email, password);
                if (role == "Chef")
                {
                    fChef f = new fChef();
                    this.Hide(); f.ShowDialog();
                    
                }
                else if (role!=null)
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
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid email or password."+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.StartPosition = FormStartPosition.Manual;

            // Tùy chỉnh lại vị trí nếu cần (giữ nguyên vị trí hiện tại)
            this.Location = new Point(0, 0);
            btnMinSize.Visible = false;
            btnMaxSize.Visible = true;
            lb2.Visible = false;
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

        private void Login_Load(object sender, EventArgs e)
        {
            pLogin.Visible = false;
        }

        private void TableChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLogin.SelectedItem.ToString() == "Guest")
            {
                fCustomer f = new fCustomer();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                pLogin.Visible = true;
                lb1.Visible = false;
                lb2.Visible = false;
            }
        }
    }
}
