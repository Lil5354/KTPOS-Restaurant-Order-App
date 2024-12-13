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

namespace KTPOS_Order.Chef_Control
{
    public partial class UC_OrderList : UserControl
    {
        public UC_OrderList()
        {
            InitializeComponent();
        }

        private void UC_OrderList_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }
        private void LoadBillData() {
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
        public int SelectedBillId { get; set; }
        private void ListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListBill.Columns["Details"].Index && e.RowIndex >= 0)
            {
                // Lấy ID Bill từ hàng được chọn
                int selectedBillId = Convert.ToInt32(ListBill.Rows[e.RowIndex].Cells["BillId"].Value);
                SelectedBillId = selectedBillId;

                // Hiển thị chi tiết Bill trực tiếp trong DataGridView
                BillProcessor billProcessor = new BillProcessor(selectedBillId);

                // Xóa dữ liệu cũ
                Bill.Rows.Clear();

                // Thêm dữ liệu vào DataGridView và tính tổng
                
                foreach (DataRow row in billProcessor.BillDetails.Rows)
                {
                    int quantity = Convert.ToInt32(row["Quantity"]);

                    Bill.Rows.Add(
                        row["ItemName"],
                        row["Quantity"]
                    );
                }

                // Cập nhật tổng tiền
               
            }
        }
    }
}
