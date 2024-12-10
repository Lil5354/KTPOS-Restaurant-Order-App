using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KTPOS_Order.Management_Control
{
    public partial class UC_Admin : UserControl
    {
        int index = -1;
        public UC_Admin()
        {
            InitializeComponent();
        }
        
        private void btnViewAcc_Click(object sender, EventArgs e)
        {
            //GetList.Instance.LoadAccountList(dtgvAccount);
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                int n = GetList.Instance.InsertList(name, email, role);
                if (n > 0)
                {
                    MessageBox.Show("Account update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //GetList.Instance.LoadAccountList(dtgvAccount);
                }
                else
                {
                    MessageBox.Show("Error update account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be delete!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int CurrentIndex = dtgvAccount.CurrentCell.RowIndex;
                string name = Convert.ToString(dtgvAccount.Rows[CurrentIndex].Cells[0].Value.ToString());
                try
                {
                    int n = GetList.Instance.DeleteList(name);
                    if (n > 0)
                    {
                        MessageBox.Show("Account delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //GetList.Instance.LoadAccountList(dtgvAccount);
                    }
                    else
                    {
                        MessageBox.Show("Error delete account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];

                // Gán dữ liệu từ các cột vào TextBox
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                cbBRole.Text = row.Cells["Role"].Value?.ToString();
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dtgvAccount.CurrentCell.RowIndex;
            string fname = Convert.ToString(dtgvAccount.Rows[CurrentIndex].Cells[0].Value.ToString());
           
            try
            {
                string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                int n = GetList.Instance.UpdateList(fname, name, email, role);
                if (n > 0)
                {
                    MessageBox.Show("Account insert successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // GetList.Instance.LoadAccountList(dtgvAccount);
                }
                else
                {
                    MessageBox.Show("Error insert account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insert account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }
        string query = "";
        private void tcManager_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            // Lấy tab được chọn
            string selectedTab = tcManager.SelectedTab.Text;
            // Tạo câu truy vấn dựa vào tab được chọn
            switch (selectedTab)
            {
                case "ACCOUNT":
                    query = "SELECT FullName, Email, ExpY, [Role] FROM ACCOUNT WHERE Visible = 1 Order by [Role] ASC";
                    GetList.Instance.LoadAccountList(query, dtgvAccount);
                    break;
                case "TABLE":
                    query = "SELECT * FROM [TABLE] Order by [ID] ASC";
                    break;
                case "CATEGORIES":
                    query = "SELECT ID, fname AS [NAME CATEGORIES] FROM [F&BCATEGORY]";
                    GetList.Instance.LoadAccountList(query, dtgvCate);
                    break;
                case "F&B":
                    query = "SELECT fb.fname [Type], ITEM.fname AS [Name], price[Price] FROM ITEM JOIN [F&BCATEGORY] fb ON idCategory = fb.ID Order by [Type] ASC";
                    GetList.Instance.LoadAccountList(query, dtgvFandB);
                    break;
                case "REVENUE":
                    query = "SELECT * FROM REVENUE WHERE Visible = 1 Order by [Role] ASC";
                    break;
                default:
                    query = "";
                    break;
            }
        }
    
    }
}
