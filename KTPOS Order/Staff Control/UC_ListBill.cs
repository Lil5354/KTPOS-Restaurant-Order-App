using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

namespace KTPOS_Order.Staff_Control
{
    public partial class UC_ListBill : UserControl
    {
        public void ReloadBillData()
        {
            
        }
        public UC_ListBill()
        {
            InitializeComponent();
            //UpdateTotalAmount();
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = Filter.SelectedItem.ToString();
            ListBill.Rows.Clear(); // Xóa dữ liệu cũ trước khi tải mới

            // Xây dựng câu lệnh SQL dựa trên bộ lọc
            string queryString = @"
            SELECT id, Datepayment, idTable, 
            CASE WHEN status = 1 THEN 'Done' 
                 WHEN status = 0 THEN 'Not Paid' 
                 ELSE 'Unidentified Status' 
            END AS StatusText 
            FROM [dbo].[Bill]";

            // Thêm điều kiện lọc
            switch (selectedFilter)
            {
                case "Newest":
                    queryString += " ORDER BY Datepayment DESC;";
                    break;
                case "Oldest":
                    queryString += " ORDER BY Datepayment ASC;";
                    break;
                case "Unpaid":
                    queryString += " WHERE status = 0 ORDER BY id DESC;";
                    break;
                case "Paid":
                    queryString += " WHERE status = 1 ORDER BY id DESC;";
                    break;
                case "Table number up":
                    queryString += " ORDER BY idTable DESC;";
                    break;
                case "Table number down":
                    queryString += " ORDER BY idTable ASC;";
                    break;
                case "Ascending ID":
                    queryString += " ORDER BY id ASC;";
                    break;
                case "Descending ID":
                    queryString += " ORDER BY id DESC;";
                    break;
                default:
                    queryString += " ORDER BY id DESC;"; // Mặc định
                    break;
            }

            try
            {
                // Sử dụng GetDatabase để lấy dữ liệu
                DataTable data = GetDatabase.Instance.ExecuteQuery(queryString);
                foreach (DataRow row in data.Rows)
                {
                    // Thêm dữ liệu vào DataGridView
                    ListBill.Rows.Add(row["id"], row["Datepayment"], row["idTable"], row["StatusText"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_ListBill_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }
        public void LoadBillData()
        {
            ListBill.Rows.Clear(); // Xóa dữ liệu cũ

            string queryString = @"
            SELECT id, Datepayment, idTable, 
            CASE WHEN status = 1 THEN 'Done' 
                 WHEN status = 0 THEN 'Not Paid' 
                 ELSE 'Unidentified Status'
            END AS StatusText 
            FROM [dbo].[Bill] 
            ORDER BY status, id DESC;";

            try
            {
                DataTable data = GetDatabase.Instance.ExecuteQuery(queryString);
                foreach (DataRow row in data.Rows)
                {
                    ListBill.Rows.Add(row["id"], row["Datepayment"], row["idTable"], row["StatusText"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            userControl.Location = new Point(this.Width - userControl.Width, 103);
            userControl.Anchor = AnchorStyles.Right;
            userControl.BringToFront();

            // Cập nhật tham chiếu
            currentUserControl = userControl;
        }


        private void ListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == ListBill.Columns["Payment"].Index && e.RowIndex >= 0)
            {
                // Lấy ID Bill từ hàng được chọn
                int selectedBillId = Convert.ToInt32(ListBill.Rows[e.RowIndex].Cells["id"].Value);
                SelectedBillId = selectedBillId;
                // Hiển thị chi tiết Bill trực tiếp trong DataGridView
                BillProcessor billProcessor = new BillProcessor(selectedBillId);

                // Xóa dữ liệu cũ
                Bill.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (DataRow row in billProcessor.BillDetails.Rows)
                {
                    Bill.Rows.Add(
                        row["ItemName"],
                        row["Quantity"],
                        row["TotalPrice"]
                    );
                }
                btnPay_Click(sender, e);
            }
        }
        private void cbForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Redirect to QRCode UserControl
            UC_QRPayment ucQrcode = new UC_QRPayment();
            AddUserControl(ucQrcode);  // Switch the UserControl to UC_QRcode

        }
        //private void UpdateTotalAmount()
        //{
        //    decimal totalAmount = GetCurrentTotalAmount();

        //    // Apply discount and update lblTotalAmount
        //    lblTotalAmount.Text = totalAmount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        //}

        //private decimal GetCurrentTotalAmount()
        //{
        //    decimal totalAmount = 0;

        //    foreach (DataGridViewRow row in Bill.Rows)
        //    {
        //        if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(),
        //                                                               NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out decimal rowTotal))
        //        {
        //            totalAmount += rowTotal;
        //        }
        //    }

        //    return totalAmount;
        //}
        
        public int SelectedBillId { get; set; }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = cbForm.SelectedItem?.ToString();

            if (selectedPaymentMethod == "Cash")
            {
                string query = $"UPDATE Bill SET status = 1 WHERE ID = {SelectedBillId}";
                try
                {
                    GetDatabase.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Payment completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the ListBill data to reflect the updated status
                    LoadBillData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedPaymentMethod == "Transfer")
            {
                // Transfer logic: switch to another control for QR Payment, etc.
                UC_QRPayment ucQrPayment = new UC_QRPayment();
                AddUserControl(ucQrPayment);
            }
            else
            {
                MessageBox.Show("Please select a valid payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

        

    