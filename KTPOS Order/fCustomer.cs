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

namespace KTPOS_Order
{
    public partial class fCustomer : Form
    {
        public static List<DataGridViewRow> dataGridRows = new List<DataGridViewRow>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        Decimal Total = 0;
        public fCustomer()
        {
            InitializeComponent();
            InitializeDataGridView();
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

                // Update Subtotal
                txtSubTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));

                // Automatically calculate VAT (10%)
                decimal vatAmount = Total * 0.10m;
                txtVAT.Text = vatAmount.ToString("C", new System.Globalization.CultureInfo("en-US"));

                // Automatically calculate Total (Subtotal - VAT)
                decimal totalAfterVAT = Total + vatAmount;
                txtTotal.Text = totalAfterVAT.ToString("C", new System.Globalization.CultureInfo("en-US"));
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

        private void txtTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void txtVAT_Click(object sender, EventArgs e)
        {

        }

        //private void btnOrder_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Validate data
        //        if (dtgvBillCus.Rows.Count == 0 || txtTotal.Text.Trim() == "0.00")
        //        {
        //            MessageBox.Show("Please add items to the bill before placing an order.");
        //            return;
        //        }

        //        // Get the selected table ID dynamically
        //        int idTable = GetSelectedTableId(); // Replace with the actual logic to get the table ID

        //        // Insert Bill record
        //        string insertBillQuery = "INSERT INTO Bill (Datepayment, idTable, status) VALUES (GETDATE(), @idTable, 1)";
        //        GetDatabase.Instance.ExecuteNonQuery(insertBillQuery, new object[] { idTable });

        //        // Get the ID of the newly inserted Bill
        //        object result = GetDatabase.Instance.ExecuteScalar("SELECT SCOPE_IDENTITY()");
        //        if (result == null || result == DBNull.Value)
        //        {
        //            MessageBox.Show("Failed to retrieve Bill ID.");
        //            return;
        //        }
        //        int billId = Convert.ToInt32(result);

        //        // Insert BillInf records for each item in the bill
        //        foreach (DataGridViewRow row in dtgvBillCus.Rows)
        //        {
        //            string itemName = row.Cells[0].Value.ToString();
        //            int quantity = Convert.ToInt32(row.Cells[1].Value);

        //            // Get item ID
        //            string getItemIdQuery = "SELECT ID FROM ITEM WHERE fname = @Name";
        //            result = GetDatabase.Instance.ExecuteScalar(getItemIdQuery, new object[] { itemName });
        //            if (result == null || result == DBNull.Value)
        //            {
        //                MessageBox.Show($"Item '{itemName}' not found.");
        //                continue;
        //            }
        //            int itemId = Convert.ToInt32(result);

        //            // Insert BillInf record
        //            string insertBillInfQuery = "INSERT INTO BILLINF (idBill, idFD, count) VALUES (@idBill, @idFD, @count)";
        //            GetDatabase.Instance.ExecuteNonQuery(insertBillInfQuery, new object[] { billId, itemId, quantity });
        //        }

        //        // Reset UI after successful order
        //        dtgvBillCus.Rows.Clear();
        //        txtSubTotal.Text = "0.00";
        //        txtVAT.Text = "0.00";
        //        txtTotal.Text = "0.00";
        //        MessageBox.Show("Order placed successfully!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}
        //private int GetSelectedTableId()
        //{
           
        //}
    }
}
