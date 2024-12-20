﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order.Management_Control
{
    public partial class UC_Admin : UserControl
    {
        int index = -1;
        string query = "", q = "";
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
        public void tcManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcManager.SelectedTab != null)
            {
                // Lấy tab được chọn
                string selectedTab = tcManager.SelectedTab.Text;
                // Tạo câu truy vấn dựa vào tab được chọn
                switch (selectedTab)
                {
                    case "ACCOUNT":
                        query = "SELECT FullName as [FULL NAME], Email AS [EMAIL], ExpY AS [EXP IN YEAR], [Role] AS [ROLE] FROM ACCOUNT WHERE Visible = 1 Order by [Role] ASC";
                        GetLists.Instance.LoadAccountList(query, dtgvAccount);
                        index = -1;
                        break;
                    case "TABLE":
                        query = "SELECT fname AS [TABLE NAME] FROM [TABLE] WHERE Visible = 1";
                        GetLists.Instance.LoadAccountList(query, dtgvTable);
                        index = -1;
                        break;
                    case "CATEGORIES":
                        query = "SELECT fname AS [NAME CATEGORIES] FROM [F&BCATEGORY] WHERE Visible = 1";
                        GetLists.Instance.LoadAccountList(query, dtgvCate);
                        index = -1;
                        break;
                    case "F&B":
                        query = "SELECT fb.fname [TYPE], i.fname AS [NAME], price[PRICE] FROM ITEM i JOIN [F&BCATEGORY] fb ON idCategory = fb.ID  " +
                            "WHERE i.Visible = 1 Order by [Type] ASC";
                        GetLists.Instance.LoadAccountList(query, dtgvFandB);
                        q = "SELECT fname AS [NAME CATEGORIES] FROM [F&BCATEGORY] WHERE Visible = 1";
                        GetDatabase.Instance.LoadDataToComboBox(q, cbCategoriesFB);
                        index = -1;
                        break;
                    case "REVENUE":
                        query = "SELECT b.ID AS [ID BILL], t.fname AS [TABLE NAME], SUM(i.price * bi.count) AS [TOTAL PRICE], b.Datepayment AS [DATE CHECKOUT] FROM BILLINF bi " +
                            "JOIN Bill b ON bi.idBill = b.ID JOIN [TABLE] t ON b.idTable = t.ID JOIN ITEM i ON bi.idFD = i.ID GROUP BY b.ID, t.fname, b.Datepayment ORDER BY b.ID;";
                        GetLists.Instance.LoadAccountList(query, dtgvRevenue);
                        index = -1;
                        break;
                    default:
                        query = "";
                        break;
                }
            }
        }
        private void ClearTxtAccount()
        {
            txtSearchAcc.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            cbBRole.SelectedIndex = -1;
        }
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];
                // Gán dữ liệu từ các cột vào TextBox
                txtFullName.Text = row.Cells[0].Value?.ToString();
                txtEmail.Text = row.Cells[1].Value?.ToString();
                cbBRole.Text = row.Cells[3].Value?.ToString();
            }
        }
        private void btnAddAcc_Click(object sender, EventArgs e)
        {  if (txtFullName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || cbBRole.Text =="")
            {
              MessageBox.Show("Error add account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                try
                {
                    string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                    int n = GetLists.Instance.InsertList(name, email, role);
                    if (n > 0)
                    {
                        MessageBox.Show("Account add successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtAccount();
                    }
                    else
                    {
                        MessageBox.Show("Error add account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error add account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be update!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtFullName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || cbBRole.Text == "")
                {
                    MessageBox.Show("Error update account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int CurrentIndex = dtgvAccount.CurrentCell.RowIndex;
                        string fname = Convert.ToString(dtgvAccount.Rows[CurrentIndex].Cells[0].Value.ToString());
                        string name = txtFullName.Text, email = txtEmail.Text, role = cbBRole.Text;
                        int n = GetLists.Instance.UpdateList(fname, name, email, role);
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
            }
        }
        private void txtSearchAcc_KeyUp(object sender, KeyEventArgs e)
        {
            query = "SELECT FullName as [FULL NAME], Email AS [EMAIL], ExpY AS [EXP IN YEAR], [Role] AS [ROLE] FROM ACCOUNT \r\nWHERE Visible = 1 AND FullName Like " + "N'%" + txtSearchAcc.Text.ToString() + "%'";
            GetLists.Instance.LoadAccountList(query, dtgvAccount);
        }
        //CATEGORY
        private void dtgvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvCate.Rows[e.RowIndex];
                // Gán dữ liệu từ các cột vào TextBox
                txtNameCate.Text = row.Cells[0].Value?.ToString();
            }
        }
        public void ClearTxtCate()
        {
            txtSearchCategories.Text = "";
            txtNameCate.Text = "";
        }
        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            if (txtNameCate.Text.Trim() == "")
            {
                MessageBox.Show("Error add category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string name = txtNameCate.Text;
                    int n = GetLists.Instance.InsertCate(name);
                    if (n > 0)
                    {
                        MessageBox.Show("Category add successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtCate();
                    }
                    else
                    {
                        MessageBox.Show("Error add account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error add account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be delete!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int CurrentIndex = dtgvCate.CurrentCell.RowIndex;
                string name = Convert.ToString(dtgvCate.Rows[CurrentIndex].Cells[0].Value.ToString());
                try
                {
                    int n = GetLists.Instance.DeleteCate(name);
                    if (n > 0)
                    {
                        MessageBox.Show("Category delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtCate();
                    }
                    else
                    {
                        MessageBox.Show("Error delete category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be edit!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtNameCate.Text.Trim() == "")
                {
                    MessageBox.Show("Error to edit category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int CurrentIndex = dtgvCate.CurrentCell.RowIndex;
                        string fname = Convert.ToString(dtgvCate.Rows[CurrentIndex].Cells[0].Value.ToString());
                        string name = txtNameCate.Text;
                        int n = GetLists.Instance.UpdateCate(fname, name);
                        if (n > 0)
                        {
                            MessageBox.Show("Category update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tcManager_SelectedIndexChanged(sender, e);
                            ClearTxtCate();
                        }
                        else
                        {
                            MessageBox.Show("Error update category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error update category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtSearchCategories_KeyUp(object sender, KeyEventArgs e)
        {
            query = "SELECT fname AS [NAME CATEGORIES] FROM [F&BCATEGORY] \r\nWHERE Visible = 1 AND fName Like " + "N'%" + txtSearchCategories.Text.ToString() + "%'";
            GetLists.Instance.LoadAccountList(query, dtgvCate);
        }
        //F&B (ITEM)
        private void ClearTxtFaB()
        {
            txtNameFB.Text = "";
            txtPriceFB.Text = "";
            cbCategoriesFB.SelectedIndex = -1;
        }
        private void dtgvFandB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvFandB.Rows[e.RowIndex];
                // Gán dữ liệu từ các cột vào TextBox
                txtNameFB.Text = row.Cells[1].Value?.ToString();
                txtPriceFB.Text = row.Cells[2].Value?.ToString();
                cbCategoriesFB.Text = row.Cells[0].Value?.ToString();
            }
        }
        private void txtPriceFB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnAddFB_Click(object sender, EventArgs e)
        {
            if (txtNameFB.Text.Trim() == "" || txtPriceFB.Text.Trim() == "" || cbCategoriesFB.Text == "")
            {
                MessageBox.Show("Error add F&B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string name = txtNameFB.Text, price = txtPriceFB.Text, fname = cbCategoriesFB.Text;
                    int n = GetLists.Instance.InsertItem(name, price, fname);
                    if (n > 0)
                    {
                        MessageBox.Show("F&B add successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtFaB();
                    }
                    else
                    {
                        MessageBox.Show("F&B add error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("F&B add error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteFB_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be delete!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int CurrentIndex = dtgvFandB.CurrentCell.RowIndex;
                string name = Convert.ToString(dtgvFandB.Rows[CurrentIndex].Cells[1].Value.ToString());
                string namefcate = Convert.ToString(dtgvFandB.Rows[CurrentIndex].Cells[0].Value.ToString());
                try
                {
                    int n = GetLists.Instance.DeleteItem(name, namefcate);
                    if (n > 0)
                    {
                        MessageBox.Show("F&B delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtFaB();
                    }
                    else
                    {
                        MessageBox.Show("Error delete F&B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete F&B: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditFB_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be edit!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtNameFB.Text.Trim() == "" || txtPriceFB.Text.Trim() == "" || cbCategoriesFB.Text == "")
                {
                    MessageBox.Show("Error edit F&B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int CurrentIndex = dtgvFandB.CurrentCell.RowIndex;
                        string fname = Convert.ToString(dtgvFandB.Rows[CurrentIndex].Cells[1].Value.ToString());
                        string namefcate = Convert.ToString(dtgvFandB.Rows[CurrentIndex].Cells[0].Value.ToString());
                        string name = txtNameFB.Text, price = txtPriceFB.Text, namecate = cbCategoriesFB.Text;
                        int n = GetLists.Instance.UpdateItem(name, price, namecate, fname, namefcate);
                        if (n > 0)
                        {
                            MessageBox.Show("F&B update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tcManager_SelectedIndexChanged(sender, e);
                            ClearTxtFaB();
                        }
                        else
                        {
                            MessageBox.Show("Error update F&B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error update F&B: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtSearchFB_KeyUp(object sender, KeyEventArgs e)
        {
            query = "SELECT fb.fname [TYPE], i.fname AS [NAME], price[PRICE] FROM ITEM i JOIN [F&BCATEGORY] fb ON idCategory = fb.ID WHERE i.Visible = 1  AND i.fname Like " + "N'%" + txtSearchFB.Text.ToString() + "%' Order by [Type] ASC";
            GetLists.Instance.LoadAccountList(query, dtgvFandB);
        }
        //TABLE
        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvTable.Rows[e.RowIndex];
                // Gán dữ liệu từ các cột vào TextBox
                txtTableName.Text = row.Cells[0].Value?.ToString();
            }
        }
        public void ClearTxtTable()
        {
            txtSearchTable.Clear();
            txtTableName.Clear();
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                int n = GetLists.Instance.InsertTable();
                if (n > 0)
                {
                    MessageBox.Show("Category add successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tcManager_SelectedIndexChanged(sender, e);
                    ClearTxtTable();
                }
                else
                {
                    MessageBox.Show("Error add account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be delete!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int CurrentIndex = dtgvTable.CurrentCell.RowIndex;
                string name = Convert.ToString(dtgvTable.Rows[CurrentIndex].Cells[0].Value.ToString());
                try
                {
                    int n = GetLists.Instance.DeleteTable(name);
                    if (n > 0)
                    {
                        MessageBox.Show("Table delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tcManager_SelectedIndexChanged(sender, e);
                        ClearTxtTable();
                    }
                    else
                    {
                        MessageBox.Show("Error delete table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please chose the row need to be edit!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtTableName.Text.Trim() == "")
                {
                    MessageBox.Show("Error edit Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int CurrentIndex = dtgvTable.CurrentCell.RowIndex;
                        string fname = Convert.ToString(dtgvTable.Rows[CurrentIndex].Cells[0].Value.ToString());
                        string name = txtTableName.Text;
                        int n = GetLists.Instance.UpdateTable(name, fname);
                        if (n > 0)
                        {
                            MessageBox.Show("Table update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tcManager_SelectedIndexChanged(sender, e);
                            ClearTxtTable();
                        }
                        else
                        {
                            MessageBox.Show("Error update Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error update Table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtSearchTable_KeyUp(object sender, KeyEventArgs e)
        {
            query = "SELECT fname AS [TABLE NAME] FROM [TABLE] \r\nWHERE Visible = 1 AND fName Like " + "N'%" + txtSearchTable.Text.ToString() + "%'";
            GetLists.Instance.LoadAccountList(query, dtgvTable);
        }
        //REVENUE
        private void btnCompile_Click(object sender, EventArgs e)
        {
            DateTime dstart = dtpStart.Value;
            DateTime dend = dtpEnd.Value;
            string startDate = dstart.ToString("yyyy-MM-dd");
            string endDate = dend.ToString("yyyy-MM-dd");
            string check = "SELECT b.ID AS [ID BILL], t.fname AS [TABLE NAME], SUM(i.price * bi.count) AS [TOTAL PRICE], b.Datepayment AS [DATE CHECKOUT] FROM BILLINF bi " +
            "JOIN Bill b ON bi.idBill = b.ID JOIN [TABLE] t ON b.idTable = t.ID JOIN ITEM i ON bi.idFD = i.ID WHERE b.Datepayment BETWEEN '"+ startDate + "' AND '"+ endDate + "' GROUP BY b.ID, t.fname, b.Datepayment ORDER BY b.ID;";
            GetLists.Instance.LoadAccountList(check, dtgvRevenue);
        }
    }
}
