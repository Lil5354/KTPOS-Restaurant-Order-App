using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KTPOS_Order.Customer_Control;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order
{
    public partial class fCustomer : Form
    {
        public static List<DataGridViewRow> dataGridRows = new List<DataGridViewRow>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        Decimal Total = 0;
        Decimal SubTotal = 0;
        public fCustomer()
        {
            InitializeComponent();
            InitializeDataGridView();
            txtChange.SendToBack();
            tbNewAmount.SendToBack();
            Filter.SelectedItem = "Default"; 
        }
        private void InitializeDataGridView()
        {
            dtgvBillCus.Columns.Add("Name", "Name");
            dtgvBillCus.Columns.Add("Quantity", "Quantity");
            dtgvBillCus.Columns.Add("Price", "Price");
        }
        public void AddOrUpdate(Dictionary<string, int> dict, string key)
        {
            if (dict.ContainsKey(key))
                dict[key]++;
            else
                dict.Add(key, 1);
        }
        public void AddProduct(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string ID = pictureBox.Tag.ToString();
            string name = "";
            decimal price = 0;

            string query = "SELECT fName, Price FROM ITEM WHERE ID = @ID";
            DataTable result = GetDatabase.Instance.ExecuteQuery(query, new object[] { ID });

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                name = row["fName"].ToString();
                price = Convert.ToDecimal(row["Price"]);
                Total += price;
                SubTotal += price;

                AddOrUpdate(Count, ID);

                if (Count[ID] == 1)
                {
                    dtgvBillCus.Rows.Add(name, 1, price);
                }
                else
                {
                    foreach (DataGridViewRow dgvRow in dtgvBillCus.Rows)
                    {
                        if (dgvRow.Cells[0].Value.ToString() == name)
                        {
                            dgvRow.Cells[1].Value = Count[ID];
                            dgvRow.Cells[2].Value = Count[ID] * price;
                        }
                    }
                }
                txtSubTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
        }

        public void LoadProducts(string query)
        {
            DataTable result = GetDatabase.Instance.ExecuteQuery(query);

            foreach (DataRow row in result.Rows)
            {
                string name = row["fName"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                int id = Convert.ToInt32(row["ID"]);

                UC_Item itemControl = new UC_Item(name, price, id);
                itemControl.guna2CirclePictureBox1.Click += AddProduct;
                FlowMenu.Controls.Add(itemControl);
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private UserControl currentUserControl;
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

        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM");
        }

        private void btnFoodOptions_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 1");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 2");
        }
        private void btnChat_Click(object sender, EventArgs e)
        {

        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void RemoveSpecificUserControl(UserControl userControl)
        {
            if (this.Controls.Contains(userControl))
            {
                this.Controls.Remove(userControl);
                userControl.Dispose(); 
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM");
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void dtgvBillCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBillCus.Rows.Count > 0)
            {
                txtChange.BringToFront();
                tbNewAmount.BringToFront();
                tbNewAmount.Text = dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void tbNewAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNewAmount.Text != "0")
                {
                    decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[2].Value.ToString());
                    int tempamount = int.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                    decimal temp = tempcost / tempamount;
                    temp = temp * int.Parse(tbNewAmount.Text);
                    Total += temp - tempcost;
                    SubTotal += temp - tempcost;

                    dtgvBillCus.SelectedRows[0].Cells[1].Value = tbNewAmount.Text;
                    dtgvBillCus.SelectedRows[0].Cells[2].Value = temp.ToString();
                    txtTotal.Text = "$" + Total.ToString();
                    txtSubTotal.Text = "$" + SubTotal.ToString();
                    txtChange.SendToBack();
                    tbNewAmount.SendToBack();
                }
                else
                {
                    decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[2].Value.ToString());
                    Total -= tempcost;
                    SubTotal -= tempcost;
                    txtTotal.Text = "$" + Total.ToString();
                    txtSubTotal.Text = "$" + SubTotal.ToString();
                    dtgvBillCus.Rows.Remove(dtgvBillCus.SelectedRows[0]);
                    txtChange.SendToBack();
                    tbNewAmount.SendToBack();
                }
            }
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = Filter.SelectedItem.ToString();
            switch (filter)
            {
                case "Default":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM");
                    break;
                case "Best Sellers" :
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 4");
                    break;
                case "New Arrivals":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 1");
                    break;
                case "Featured Dishes":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 2");
                    break;
                case "Combo Deals":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 3");
                    break;
                case "Most Loved":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 4");
                    break;
            }
        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
            {
                foreach (UC_Item item in FlowMenu.Controls)
                {
                    string name = item.GetName();
                    var uc = (UserControl)item;
                    uc.Visible = name.ToLower().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                }
            }
        }
    }
}
