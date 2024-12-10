using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPOS_Order.Proccess;

namespace KTPOS_Order.Staff_Control
{
    public partial class UC_ListBill : UserControl
    {
        public UC_ListBill()
        {
            InitializeComponent();
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
        private void LoadBillData()
        {
            ListBill.Rows.Clear(); // Xóa dữ liệu cũ trước khi tải mới

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
            if (e.ColumnIndex == ListBill.Columns["Payment"].Index)

            {

                UC_Payment UCPay = new UC_Payment();
                AddUserControl(UCPay);

            }
        }
    }
}
