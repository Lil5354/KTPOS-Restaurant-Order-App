using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KTPOS_Order.Proccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KTPOS_Order.Staff_Control
{
    public partial class UC_Table : UserControl
    {
        private UC_ListBill parentListBill;
        public int SelectedBillId { get; set; }
        public UC_Table()
        {
            InitializeComponent();
            LoadTables();
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            LoadCategories();
        }
        private void LoadTables()
        {
            try
            {
                string query = "SELECT ID, fname, status FROM [TABLE]";
                DataTable data = GetDatabase.Instance.ExecuteQuery(query);

                flTable.Controls.Clear();

                foreach (DataRow row in data.Rows)
                {
                    int tableId = Convert.ToInt32(row["ID"]);
                    string tableName = row["fname"].ToString();
                    int status = Convert.ToInt32(row["status"]);
                    string buttonText = status == 1 ? $"{tableName}\nAvailable" : $"{tableName}\nUnavailable";

                    Guna2Button tableButton = new Guna2Button
                    {
                        Text = buttonText,
                        Width = 100,
                        Height = 100,
                        BorderRadius = 20,
                        FillColor = status == 1 ? Color.White : Color.BurlyWood,
                        ForeColor = Color.Maroon,
                        Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                        Margin = new Padding(10),
                        HoverState = { FillColor = Color.Gray },
                        Tag = tableId
                    };

                    tableButton.Click += TableButton_Click;

                    flTable.Controls.Add(tableButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton == null) return;

            int tableId = Convert.ToInt32(clickedButton.Tag);

            // Kiểm tra điều kiện bàn "Unavailable" và hóa đơn "Chưa thanh toán"
            string billIdQuery = @"
        SELECT b.ID 
        FROM Bill b 
        JOIN [TABLE] t ON b.idTable = t.ID
        WHERE t.ID = @tableId AND t.status = 0 AND b.status = 0";

            object billIdResult = GetDatabase.Instance.ExecuteScalar(billIdQuery, new object[] { tableId });

            if (billIdResult != null)
            {
                int billId = Convert.ToInt32(billIdResult);
                BillProcessor billProcessor = new BillProcessor(billId);

                // Hiển thị thông tin hóa đơn
                DisplayBillDetails(billProcessor.BillDetails);

                // Tính tổng tiền
                decimal totalAmount = billProcessor.BillDetails.AsEnumerable()
                    .Sum(row => row.IsNull("TotalPrice") ? 0 : Convert.ToDecimal(row["TotalPrice"]));

                lblTotalAmount.Text = totalAmount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                MessageBox.Show("No unpaid bill found for this table or table is available.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DisplayBillDetails(DataTable billDetails)
        {
            dgvBillDetails.Rows.Clear();

            foreach (DataRow row in billDetails.Rows)
            {
                string unitPriceFormatted = Convert.ToDecimal(row["UnitPrice"]).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                string totalPriceFormatted = Convert.ToDecimal(row["TotalPrice"]).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                dgvBillDetails.Rows.Add(row["ItemName"], unitPriceFormatted, row["Quantity"], totalPriceFormatted);
            }
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategories.SelectedItem != null && cbCategories.SelectedItem is KeyValuePair<int, string> selectedCategory)
            {
                // Lấy ID từ danh mục đã chọn
                int selectedCategoryId = selectedCategory.Key;

                // Lọc dữ liệu dựa trên ID
                string query = "SELECT ID, fname FROM ITEM WHERE idCategory = @categoryId";
                DataTable items = GetDatabase.Instance.ExecuteQuery(query, new object[] { selectedCategoryId });

                // Cập nhật danh sách cbItem
                cbItem.Items.Clear();
                foreach (DataRow row in items.Rows)
                {
                    cbItem.Items.Add(new KeyValuePair<int, string>((int)row["ID"], row["fname"].ToString()));
                }

                cbItem.DisplayMember = "Value";
                cbItem.ValueMember = "Key";
            }
        }
        private void LoadCategories()
        {
            string query = "SELECT ID, fname FROM [F&BCATEGORY]";
            DataTable categories = GetDatabase.Instance.ExecuteQuery(query);

            cbCategories.Items.Clear();

            foreach (DataRow row in categories.Rows)
            {
                // Thêm dữ liệu dưới dạng KeyValuePair<int, string>
                cbCategories.Items.Add(new KeyValuePair<int, string>((int)row["ID"], row["fname"].ToString()));
            }

            cbCategories.DisplayMember = "Value"; // Hiển thị tên danh mục
            cbCategories.ValueMember = "Key";    // Giá trị là ID
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbItem.SelectedItem != null && cbItem.SelectedItem is KeyValuePair<int, string> selectedItem)
            {
                int itemId = selectedItem.Key;
                string itemName = selectedItem.Value;
                int quantity = (int)numericUpDownQuantity.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Please select a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá của món ăn
                string query = "SELECT price FROM ITEM WHERE ID = @itemId";
                object result = GetDatabase.Instance.ExecuteScalar(query, new object[] { itemId });

                if (result != null && decimal.TryParse(result.ToString(), out decimal unitPrice))
                {
                    decimal totalPrice = unitPrice * quantity;

                    // Format giá
                    string unitPriceFormatted = unitPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    string totalPriceFormatted = totalPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                    // Thêm vào DataGridView
                    dgvBillDetails.Rows.Add(itemName, unitPriceFormatted, quantity, totalPriceFormatted);

                    // Cập nhật tổng tiền hiển thị
                    UpdateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Unable to retrieve the price of the selected item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to add.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = GetCurrentTotalAmount();
            decimal discount = GetDiscountValue();

            // Apply discount and update lblTotalAmount
            decimal discountAmount = totalAmount * (discount / 100);
            decimal newTotal = totalAmount - discountAmount;
            lblTotalAmount.Text = newTotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
        

        private decimal GetDiscountValue()
        {
            // ... Implement your logic here to retrieve and validate discount value (e.g., from a NumericUpDown or TextBox) ...
            // This function should return a valid decimal value between 0 and 100 (inclusive).
            // You can add error handling (e.g., try-catch) to handle invalid input and provide user feedback.

            // Example (assuming discount value is retrieved from numericUpDownDiscount):
            if (Discount.Value < 0 || Discount.Value > 100)
            {
                MessageBox.Show("Invalid discount value. Please enter a value between 0 and 100%.");
                return 0; // Or any default value you prefer
            }
            return Discount.Value;
        }

        private decimal GetCurrentTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvBillDetails.Rows)
            {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(),
                                                                       NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out decimal rowTotal))
                {
                    totalAmount += rowTotal;
                }
            }

            return totalAmount;
        }

        private void Discount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = cbForm.SelectedItem?.ToString();

            // Get the current table's ID from the selected table button
            int currentTableId = GetCurrentTableId();

            if (currentTableId == -1)
            {
                MessageBox.Show("Please select a table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query to get the bill ID for the current table
            string billIdQuery = @"
        SELECT ID 
        FROM Bill 
        WHERE idTable = @tableId AND status = 0";

            try
            {
                object billIdResult = GetDatabase.Instance.ExecuteScalar(billIdQuery, new object[] { currentTableId });

                if (billIdResult != null)
                {
                    SelectedBillId = Convert.ToInt32(billIdResult);

                    if (selectedPaymentMethod == "Cash")
                    {
                        string query = $"UPDATE Bill SET status = 1 WHERE ID = {SelectedBillId}";
                        try
                        {
                            GetDatabase.Instance.ExecuteNonQuery(query);
                            MessageBox.Show("Payment completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (selectedPaymentMethod == "Transfer")
                    {
                        decimal totalAmountUSD = Convert.ToDecimal(lblTotalAmount.Text.Trim('$'));

                        // Convert USD to VND
                        decimal exchangeRate = 240; // Adjust this rate as needed
                        decimal totalAmountVND = totalAmountUSD * exchangeRate;

                        // Prepare QR content
                        string qrcodeText = $"BILL ID: {SelectedBillId}";

                        // Open UC_QRPayment and populate fields
                        UC_QRPayment ucQrPayment = new UC_QRPayment();
                        ucQrPayment.txtContent.Text = qrcodeText;
                        ucQrPayment.txtCost.Text = totalAmountVND.ToString("#"); // Format as VND
                        AddUserControl(ucQrPayment);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No unpaid bill found for the selected table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving bill ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetCurrentTableId()
        {
            // Find the selected table button in the flTable FlowLayoutPanel
            foreach (Control control in flTable.Controls)
            {
                if (control is Guna2Button tableButton && tableButton.FillColor == Color.BurlyWood)
                {
                    return Convert.ToInt32(tableButton.Tag);
                }
            }
            return -1; // Return -1 if no table is selected
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
            userControl.Location = new Point(0, 0);
            userControl.Anchor = AnchorStyles.Right;
            userControl.BringToFront();

            // Cập nhật tham chiếu
            currentUserControl = userControl;
        }

        private void dgvBillDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Table_Load(object sender, EventArgs e)
        {

        }
    }

}


