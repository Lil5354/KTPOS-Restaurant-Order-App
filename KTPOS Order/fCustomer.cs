using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order
{
    public partial class fCustomer : Form
    {
        public static List<DataGridViewRow> dataGridRows = new List<DataGridViewRow>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        Decimal Total = 0;
        decimal SubTotal = 0;
        int BillId = 0;
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
            nUDItem.Visible = false;
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
        }
        public void AddOrUpdate(Dictionary<string, int> dict, string key)
        {
            if (dict.ContainsKey(key) && dict[key] != 0)
                dict[key]++;
            else if (!dict.ContainsKey(key))
                dict.Add(key, 1);
            else if (dict.ContainsKey(key) && dict[key] == 0)
                dict[key] = 1;
        }
        public void AddProduct(object sender, EventArgs e)
        {
            nUDItem.Visible = false;
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
                SubTotal += price;

                AddOrUpdate(Count, name);

                if (Count[name] == 1)
                {
                    dtgvBillCus.Rows.Add(name, 1, price, ID);
                }
                else
                {
                    foreach (DataGridViewRow dgvRow in dtgvBillCus.Rows)
                    {
                        if (dgvRow.Cells[0].Value.ToString() == name)
                        {
                            dgvRow.Cells[1].Value = Count[name];
                            dgvRow.Cells[2].Value = Count[name] * price;
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
                int id = Convert.ToInt32(row["ID"]);

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
            LoadProducts("SELECT ID, fName, Price FROM ITEM");
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
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

        private void dtgvBillCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBillCus.Rows.Count > 0)
            {
                nUDItem.Value = int.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                nUDItem.Visible = true;
            }
        }

        private void nUDItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void nUDItem_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nUDItem_ValueChanged(object sender, EventArgs e)
        {
            string key = dtgvBillCus.SelectedRows[0].Cells[0].Value.ToString();
            int d = (int) nUDItem.Value;
            Count[key] = d;
            if (nUDItem.Value != 0)
            {
                decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[2].Value.ToString());
                int tempamount = int.Parse(dtgvBillCus.SelectedRows[0].Cells[1].Value.ToString());
                decimal temp = tempcost / tempamount;
                temp = temp * nUDItem.Value;
                SubTotal += temp - tempcost;
                decimal vatAmount = SubTotal * 0.10m;
                Total = SubTotal + vatAmount;

                dtgvBillCus.SelectedRows[0].Cells[1].Value = nUDItem.Value;
                dtgvBillCus.SelectedRows[0].Cells[2].Value = temp.ToString();
                txtTotal.Text = Total.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtSubTotal.Text = SubTotal.ToString("C", new System.Globalization.CultureInfo("en-US"));
                txtVAT.Text = vatAmount.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
            else
            {
                decimal tempcost = decimal.Parse(dtgvBillCus.SelectedRows[0].Cells[2].Value.ToString());
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
            nUDItem.Visible=false;
        }

        private void dtgvBillCus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2CustomGradientPanel16_MouseDown(object sender, MouseEventArgs e)
        {
            nUDItem.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Order?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string filePath = "E:\\Project\\KTPOS-Restaurant-Order-App\\KTPOS Order\\Note\\Bill Note.txt";
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(txtNoteBill.Text);
                }
                txtNoteBill.Clear();
                    // Kết nối cơ sở dữ liệu SQL Server
                    string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
                string queryid = "SELECT TOP 1 * FROM BILLINF ORDER BY idBill DESC";
                // Duyệt qua từng dòng trong DataGridView và thêm vào cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(queryid, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        BillId = int.Parse(row["idBill"].ToString());
                    }
                    else
                    {
                        BillId = 0;
                    }
                    BillId++;
                    foreach (DataGridViewRow row in dtgvBillCus.Rows)
                    {
                        // Kiểm tra nếu dòng không phải là dòng trống
                        if (row.IsNewRow) continue;

                        int idFD = Convert.ToInt32(row.Cells["idFD"].Value);
                        int count = Convert.ToInt32(row.Cells["Quantity"].Value);

                        // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                        string query = "INSERT INTO BILLINF (idBill, idFD, count) VALUES (@idBill, @idFD, @count)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Thêm tham số vào câu lệnh SQL
                            cmd.Parameters.AddWithValue("@idBill", BillId);
                            cmd.Parameters.AddWithValue("@idFD", idFD);
                            cmd.Parameters.AddWithValue("@count", count);

                            // Thực thi câu lệnh SQL
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                while (dtgvBillCus.Rows.Count > 0)
                {
                    dtgvBillCus.Rows.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Order cancelled. Continue your activity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
        }
    }
}
