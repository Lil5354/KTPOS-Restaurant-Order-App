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
using System.Windows.Forms;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order.Management_Control
{
    public partial class UC_Admin : UserControl
    {
        int index = -1;
        public UC_Admin()
        {
            InitializeComponent();
            this.Load += ManagementControl_Load;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
            SetDoubleBuffered(tcManager, true);
        }
        private void SetDoubleBuffered(Control control, bool value)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, value, null);
        }
        private void ManagementControl_Load(object sender, EventArgs e)
        {
            // Đặt trạng thái mặc định khi UserControl được load
            tcManager.SelectedTab = null;
        }
        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];
                // Gán dữ liệu từ các cột vào TextBox
                txtFullName.Text = row.Cells[0].Value?.ToString();
                txtEmail.Text = row.Cells[1].Value?.ToString();
                cbBRole.Text = row.Cells[3].Value?.ToString();
            }
        }
        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                int n = GetLists.Instance.InsertList(name, email, role);
                if (n > 0)
                {
                    MessageBox.Show("Account update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tcManager_SelectedIndexChanged(sender, e);
                    ClearTxtAccount();
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
                    int n = GetLists.Instance.DeleteList(name);
                    if (n > 0)
                    {
                        MessageBox.Show("Account delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtAccount();
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
        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dtgvAccount.CurrentCell.RowIndex;
            string fname = Convert.ToString(dtgvAccount.Rows[CurrentIndex].Cells[0].Value.ToString());

            try
            {
                string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                int n = GetLists.Instance.UpdateList(fname, name, email, role);
                if (n > 0)
                {
                    MessageBox.Show("Account insert successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tcManager_SelectedIndexChanged(sender, e);
                    ClearTxtAccount();
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
        string query = "";
        public void tcManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcManager.SelectedTab != null) {
                // Lấy tab được chọn
                string selectedTab = tcManager.SelectedTab.Text;
                // Tạo câu truy vấn dựa vào tab được chọn
                switch (selectedTab)
                {
                    case "ACCOUNT":
                        query = "SELECT FullName as [FULL NAME], Email AS [EMAIL], ExpY AS [EXP IN YEAR], [Role] AS [ROLE] FROM ACCOUNT WHERE Visible = 1 Order by [Role] ASC";
                        GetLists.Instance.LoadAccountList(query, dtgvAccount);
                        break;
                    case "TABLE":
                        query = "SELECT ID, fname AS [TABLE NAME] FROM [TABLE]";
                        GetLists.Instance.LoadAccountList(query, dtgvTable);
                        break;
                    case "CATEGORIES":
                        query = "SELECT ID, fname AS [NAME CATEGORIES] FROM [F&BCATEGORY]";
                        GetLists.Instance.LoadAccountList(query, dtgvCate);
                        break;
                    case "F&B":
                        query = "SELECT fb.fname [TYPE], ITEM.fname AS [NAME], price[PRICE] FROM ITEM JOIN [F&BCATEGORY] fb ON idCategory = fb.ID Order by [Type] ASC";
                        GetLists.Instance.LoadAccountList(query, dtgvFandB);
                        break;
                    case "REVENUE":
                        query = "SELECT b.ID AS [ID BILL], t.fname AS [TABLE NAME], SUM(i.price * bi.count) AS [TOTAL PRICE], b.Datepayment AS [DATE CHECKOUT] FROM BILLINF bi " +
                            "JOIN Bill b ON bi.idBill = b.ID JOIN [TABLE] t ON b.idTable = t.ID JOIN ITEM i ON bi.idFD = i.ID GROUP BY b.ID, t.fname, b.Datepayment ORDER BY b.ID;";
                        GetLists.Instance.LoadAccountList(query, dtgvRevenue);
                        break;
                    default:
                        query = "";
                        break;
                }
            }
        }
        public void ClearTxtAccount()
        {
            txtSearchAcc.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            cbBRole.SelectedIndex = -1;
        }
        private void ListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }
        private void txtSearchAcc_KeyUp(object sender, KeyEventArgs e)
        {
            query = "SELECT FullName as [FULL NAME], Email AS [EMAIL], ExpY AS [EXP IN YEAR], [Role] AS [ROLE] FROM ACCOUNT \r\nWHERE Visible = 1 AND FullName Like " + "N'%" + txtSearchAcc.Text.ToString() + "%' Order by [Role] ASC";
            GetLists.Instance.LoadAccountList(query, dtgvAccount);
        }

        private void UC_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
