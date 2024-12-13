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
            Application.Exit();
        }
        private void fCustomer_Load(object sender, EventArgs e)
        {
            FlowMenu.Controls.Clear();
            LoadProducts("SELECT ID, fName, Price FROM ITEM");
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
