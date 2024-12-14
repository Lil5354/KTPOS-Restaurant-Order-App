using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Decimal SubTotal = 0;
        Decimal VATamount = 0;
        int BillId = 0;
        int BTN = 0;
        public fCustomer()
        {
            InitializeComponent();
            InitializeDataGridView();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
            SetDoubleBuffered(FlowMenu, true);
            SetDoubleBuffered(dtgvBillCus, true);
            SetDoubleBuffered(btnMaxSize, true);
            SetDoubleBuffered(btnMinSize, true);
            this.WindowState = FormWindowState.Maximized;

            // Đặt StartPosition là CenterScreen để căn giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            btnMinSize.BringToFront();
        }
        private void SetDoubleBuffered(Control control, bool value)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, value, null);
        }
        private void InitializeDataGridView()
        {
            dtgvBillCus.Columns.Add("Name", "Name");
            dtgvBillCus.Columns.Add("Quantity", "Quantity");
            dtgvBillCus.Columns.Add("Price", "Price");
            DataGridViewTextBoxColumn idFDColumn = new DataGridViewTextBoxColumn();
            idFDColumn.Name = "idFD";
            idFDColumn.HeaderText = "ID Food";
            idFDColumn.Visible = false;
            dtgvBillCus.Columns.Add(idFDColumn);
            dtgvBillCus.Columns["Price"].DefaultCellStyle.Format = "C2";
            dtgvBillCus.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");

            // Set the alignment of each column to Center
            dtgvBillCus.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvBillCus.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvBillCus.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            nUDItem.Visible = false;
            PictureBox pictureBox = (PictureBox)sender;
            string ID = pictureBox.Tag.ToString();
            string name = "";
            decimal price = 0;

            string query = "SELECT *  FROM ITEM WHERE ID = @ID";
            DataTable result = GetDatabase.Instance.ExecuteQuery(query, new object[] { ID });

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                name = row["fName"].ToString();
                string queryid = "SELECT fname, MIN(id) AS id FROM ITEM where fname = '" + name + "' GROUP BY fname ORDER BY id";
                DataTable id = GetDatabase.Instance.ExecuteQuery(queryid);
                DataRow row1 = id.Rows[0];
                ID = row1["ID"].ToString();
                price = Convert.ToDecimal(row["Price"]);
                SubTotal += price;

                AddOrUpdate(Count, name);

                if (Count[name] == 1)
                {
                    dtgvBillCus.Rows.Add(name, 1, price.ToString("C", new System.Globalization.CultureInfo("en-US")), ID);
                }
                else
                {
                    foreach (DataGridViewRow dgvRow in dtgvBillCus.Rows)
                    {
                        if (dgvRow.Cells[0].Value.ToString() == name)
                        {
                            dgvRow.Cells[1].Value = Count[name];
                            dgvRow.Cells[2].Value = (Count[name] * price).ToString("C", new System.Globalization.CultureInfo("en-US"));
                        }
                    }
                }

                // Update Subtotal
                txtSubTotal.Text = SubTotal.ToString("C", new System.Globalization.CultureInfo("en-US"));
                Total = SubTotal;

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
                int id = int.Parse(row["ID"].ToString());

                UC_Item itemControl = new UC_Item(name, price, id);
                itemControl.guna2CirclePictureBox1.Click += AddProduct;
                FlowMenu.Controls.Add(itemControl);
            }
        }
        private UserControl currentUserControl;
        public void AddUserControl(UserControl userControl)
        {
            // Xóa UserControl hiện tại (nếu có)
            if (currentUserControl != null)
            {
                this.Controls.Remove(currentUserControl);
                currentUserControl.Dispose(); // Đảm bảo giải phóng tài nguyên đúng cách
            }
            userControl.SuspendLayout(); // Tạm dừng layout để giảm thiểu việc vẽ lại
            this.Controls.Add(userControl);
            userControl.Location = new Point(110, 90);
            userControl.Anchor = AnchorStyles.Top;
            userControl.BringToFront();
            userControl.ResumeLayout(true); // Khôi phục layout một cách hiệu quả

            currentUserControl = userControl;
        }
        public void RemoveSpecificUserControl(UserControl userControl)
        {
            if (this.Controls.Contains(userControl))
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
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
            this.StartPosition = FormStartPosition.Manual;

            // Tùy chỉnh lại vị trí nếu cần (giữ nguyên vị trí hiện tại)
            this.Location = new Point(0, 0);
            btnMinSize.Visible = false;
            btnMaxSize.Visible = true;
        }
        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory IN (1,2)");
            BTN = 0;
        }
        private void btnFoodOptions_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 1");
            BTN = 1;
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 2");
            BTN = 2;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled. Continue your activity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
        }
        private void fCustomer_Load(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (UC_Item item in FlowMenu.Controls)
            {
                string name = item.GetName();
                var uc = (UserControl)item;
                uc.Visible = name.ToLower().ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }
        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = Filter.SelectedItem.ToString();
            string filter2;
            FlowMenu.Controls.Clear();
            int x = 0, y = 0;
            switch (BTN)
            {
                case 1:
                    x = 1;
                    switch (filter)
                    {
                        case "Default":
                            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 1");
                            return;
                        case "Best Sellers":
                            y = 3;
                            break;
                        case "New Arrivals":
                            y = 4;
                            break;
                            break;
                        case "Featured Dishes":
                            y = 5;
                            break;
                            break;
                        case "Combo Deals":
                            y = 6;
                            break;
                            break;
                        case "Most Loved":
                            y = 7;
                            break;
                            break;
                    }
                    filter2 = $"SELECT TOP 1 * FROM ITEM WHERE idCategory IN ({x}, {y}) AND fname IN (SELECT fname FROM ITEM WHERE idCategory IN ({x}, {y}) GROUP BY fname HAVING COUNT(*) > 1)ORDER BY id DESC";
                    LoadProducts(filter2);
                    break;
                case 2:
                    x = 2;
                    switch (filter)
                    {
                        case "Default":
                            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory = 2");
                            break;
                        case "Best Sellers":
                            y = 3;
                            break;
                        case "New Arrivals":
                            y = 4;
                            break;
                            break;
                        case "Featured Dishes":
                            y = 5;
                            break;
                            break;
                        case "Combo Deals":
                            y = 6;
                            break;
                            break;
                        case "Most Loved":
                            y = 7;
                            break;
                    }
                    filter2 = $"SELECT TOP 1 * FROM ITEM WHERE idCategory IN ({x}, {y}) AND fname IN (SELECT fname FROM ITEM WHERE idCategory IN ({x}, {y}) GROUP BY fname HAVING COUNT(*) > 1)ORDER BY id DESC";
                    LoadProducts(filter2);
                    break;
                case 0:
                    switch (filter)
                    {
                        case "Default":
                            LoadProducts("SELECT ID, fName, Price FROM ITEM WHERE idCategory IN (1,2)");
                            return;
                        case "Best Sellers":
                            y = 3;
                            break;
                        case "New Arrivals":
                            y = 4;
                            break;
                            break;
                        case "Featured Dishes":
                            y = 5;
                            break;
                            break;
                        case "Combo Deals":
                            y = 6;
                            break;
                            break;
                        case "Most Loved":
                            y = 7;
                            break;
                    }
                    filter2 = $"SELECT ID, fName, Price FROM ITEM WHERE idCategory = {y}";
                    LoadProducts(filter2);
                    break;
            }
        }

        private void dtgvBillCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBillCus.Rows.Count > 0)
            {
                nUDItem.Value = int.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                nUDItem.Visible = true;
            }
        }

        private void nUDItem_ValueChanged(object sender, EventArgs e)
        {
            string key = dtgvBillCus.SelectedRows[0].Cells[0].Value.ToString();
            int d = (int)nUDItem.Value;
            Count[key] = d;
            if (nUDItem.Value != 0)
            {
                decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                int tempamount = int.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                decimal temp = tempcost / tempamount;
                temp = temp * nUDItem.Value;
                SubTotal += temp - tempcost;
                decimal vatAmount = SubTotal * 0.10m;
                Total = SubTotal + vatAmount;

                dtgvBillCus.SelectedRows[0].Cells[1].Value = nUDItem.Value;
                dtgvBillCus.SelectedRows[0].Cells[2].Value = temp.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtSubTotal.Text = SubTotal.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtVAT.Text = vatAmount.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
            else
            {
                decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                SubTotal -= tempcost;
                decimal vatAmount = SubTotal * 0.10m;
                Total = SubTotal + vatAmount;

                txtTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtSubTotal.Text = SubTotal.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtVAT.Text = vatAmount.ToString("C", new System.Globalization.CultureInfo("en-US"));
                dtgvBillCus.Rows.Remove(dtgvBillCus.SelectedRows[0]);
                nUDItem.Visible = false;
            }
        }

        private void fCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            nUDItem.Visible = false;
        }

        private void PanelBillCus_MouseDown(object sender, MouseEventArgs e)
        {
            nUDItem.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {if (dtgvBillCus.RowCount == 0)
            {
                MessageBox.Show("You haven't order any yet.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("Do you really want to Order?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string filePath = "D:\\FILE CỦA THẢO\\KTPOS\\Functions\\Thư mục mới\\KTPOS-Restaurant-Order-App\\KTPOS Order\\Note\\BillNote";
                string queryid = "INSERT INTO BILL (IDTABLE, STATUS) VALUES (1, 0); SELECT SCOPE_IDENTITY();";
                DataTable result = GetDatabase.Instance.ExecuteQuery(queryid);
                if (result.Rows.Count > 0)
                {
                    int billId = Convert.ToInt32(result.Rows[0][0]);

                    // Then insert BILLINF records
                    foreach (DataGridViewRow row in dtgvBillCus.Rows)
                    {
                        if (row.IsNewRow) continue;
                        int count = Convert.ToInt32(row.Cells["Quantity"].Value);
                        int idFD = Convert.ToInt32(row.Cells["idFD"].Value);

                        string billInfQuery = $"INSERT INTO BILLINF (idBill, idFD, count) VALUES ({billId}, {idFD}, {count})";
                        GetDatabase.Instance.ExecuteQuery(billInfQuery);
                    }
                }
                else
                {
                    BillId = 0;
                }
                BillId++;
                filePath = filePath + BillId.ToString() + ".txt";
                if (guna2TextBox1 != null) using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(guna2TextBox1.Text);
                    }
                guna2TextBox1.Clear();


                
                while (dtgvBillCus.Rows.Count > 0)
                {
                    dtgvBillCus.Rows.RemoveAt(0);
                }
                Reset();
            }
            else
            {
                MessageBox.Show("Order cancelled. Continue your activity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
        }
        void Reset()
        {
            Total = 0;
            SubTotal = 0;
            VATamount = 0;
            txtTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
            txtSubTotal.Text = SubTotal.ToString("C", new System.Globalization.CultureInfo("en-US"));
            txtVAT.Text = VATamount.ToString("C", new System.Globalization.CultureInfo("en-US"));
            int BillId = 0;
            dataGridRows = new List<DataGridViewRow>();
            Count = new Dictionary<string, int>();
        }
    }
}
