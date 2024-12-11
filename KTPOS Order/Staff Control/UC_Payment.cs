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
using KTPOS_Order.Proccess;

namespace KTPOS_Order.Staff_Control
{
    public partial class UC_Payment : UserControl
    {
        private UC_ListBill parentListBill;
        public int SelectedBillId { get; set; }
        private decimal totalAmount;
        public UC_Payment(UC_ListBill listBill = null)
        {
            InitializeComponent();
            InitializeBillDataGridView();
            parentListBill = listBill;
        }

        private UserControl currentUserControl;
        public void InitializeBillDataGridView()
        {
            Bill.Columns.Clear();
            Bill.Columns.Add("ItemName", "Item Name");
            Bill.Columns.Add("Quantity", "Quantity");
            Bill.Columns.Add("TotalPrice", "Total Price");
        }
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

        
            
            private void btnPay_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = cbForm.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedPaymentMethod == "Transfer")
            {
                // Chuyển đến UC_QRPayment
                UC_QRPayment ucQrPayment = new UC_QRPayment();
                AddUserControl(ucQrPayment);
            }
            else if (selectedPaymentMethod == "Cash")
            {
                string query = $"UPDATE Bill SET status = 1 WHERE ID = {SelectedBillId}";
                try
                {
                    GetDatabase.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Payment completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload bill data in the parent ListBill if available
                    if (parentListBill != null)
                    {
                        parentListBill.ReloadBillData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBillData()
        {
            // Hàm này sẽ gọi lại UC_ListBill để làm mới danh sách hóa đơn
            UC_ListBill listBillControl = new UC_ListBill();
            listBillControl.LoadBillData();
        }

        private void cbForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý logic khi chọn phương thức thanh toán, nếu cần
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = GetCurrentTotalAmount();

            // Apply discount and update lblTotalAmount
            lblTotalAmount.Text = totalAmount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }

        private decimal GetCurrentTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in Bill.Rows)
            {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(),
                                                                       NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out decimal rowTotal))
                {
                    totalAmount += rowTotal;
                }
            }

            return totalAmount;
        }

        private void guna2CustomGradientPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
