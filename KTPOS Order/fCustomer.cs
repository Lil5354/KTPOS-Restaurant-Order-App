using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //if (dtgvBillCus.Rows.Count == 0)
            //{
            //    MessageBox.Show("No items in the order.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //try
            //{
            //    // Lấy ID của bàn (hoặc ID mặc định)
            //    int tableID = 1; // Giả sử ID bàn là 1, bạn có thể thay đổi theo nhu cầu

            //    // Tạo một hóa đơn mới
            //    string insertBillQuery = "INSERT INTO Bill (idTable, status) OUTPUT INSERTED.ID VALUES (@idTable, @status)";
            //    object billIDObj = GetDatabase.Instance.ExecuteScalar(insertBillQuery, new object[] { tableID, 0 });

            //    if (billIDObj == null)
            //    {
            //        MessageBox.Show("Failed to create a new bill.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    int billID = Convert.ToInt32(billIDObj);

                // Cập nhật các chi tiết hóa đơn
            //    foreach (DataGridViewRow row in dtgvBillCus.Rows)
            //    {
            //        string itemName = row.Cells["Name"].Value.ToString();
            //        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

            //        // Lấy ID của mặt hàng dựa trên tên
            //        string getItemIDQuery = "SELECT ID FROM ITEM WHERE fName = @fName";
            //        DataTable itemResult = GetDatabase.Instance.ExecuteQuery(getItemIDQuery, new object[] { itemName });

            //        if (itemResult.Rows.Count > 0)
            //        {
            //            int itemID = Convert.ToInt32(itemResult.Rows[0]["ID"]);

            //            // Thêm chi tiết vào bảng BILLINF
            //            string insertBillInfQuery = "INSERT INTO BILLINF (idBill, idFD, count) VALUES (@idBill, @idFD, @count)";
            //            GetDatabase.Instance.ExecuteNonQuery(insertBillInfQuery, new object[] { billID, itemID, quantity });
            //        }
            //    }

            //    // Hiển thị thông báo thành công
            //    MessageBox.Show("Order has been placed successfully!", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Xóa giỏ hàng sau khi đặt hàng thành công
            //    dtgvBillCus.Rows.Clear();
            //    Total = 0;
            //    txtSubTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
            //    txtVAT.Text = "0";
            //    txtTotal.Text = "0";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
        
        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = Filter.SelectedItem.ToString();
            switch (filter)
            {
                case "Default":
                    FlowMenu.Controls.Clear();
                    LoadProducts("SELECT ID, fName, Price FROM ITEM");
                    break;
                case "Best Sellers":
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
    }
}
