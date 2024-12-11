using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using KTPOS_Order.Customer_Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTPOS_Order
{
    public partial class fCustomer : Form
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        public static List<ListViewItem> listItems = new List<ListViewItem>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        string filePath = "E:\\Project\\KTPOS-Restaurant-Order-App\\KTPOS Order\\Temp\\Bill.txt";
        Decimal Total = 0;
        public fCustomer()
        {
            InitializeComponent();
            File.WriteAllText(filePath, string.Empty);
        }
        UC_OrderFood UcOrderFood;

        public fCustomer(UC_OrderFood ucOrderFood)
        {
            InitializeComponent();
            UcOrderFood = ucOrderFood;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private UserControl currentUserControl;
        bool kt = true;

        public void ClearUC()
        {
            if (currentUserControl != null)
            {
                this.Controls.Remove(currentUserControl);
                currentUserControl.Dispose();
            }
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
            int x = 1400 - userControl.Width; // Xác định tọa độ X
            int y = 740 - userControl.Height; // Xác định tọa độ Y
            userControl.Location = new Point(x, y);
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
            ClearUC();
            this.FlowMenu.Controls.Clear();
            LoadProductAll();
        }

        private void btnFoodOptions_Click(object sender, EventArgs e)
        {
            ClearUC();
            this.FlowMenu.Controls.Clear();
            LoadProductFood();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            ClearUC();
            this.FlowMenu.Controls.Clear();
            LoadProductDrink();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UC_Payment uC_Payment = new UC_Payment();
            AddUserControl(uC_Payment);
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
        public void AddOrUpdate(Dictionary<string, int> a, string key)
        {
            int val;
            if (a.TryGetValue(key, out val))
            {
                // Tồn tại giá trị!
                a[key]++;
            }
            else
            {
                // Thêm giá trị
                a.Add(key, 1);
            }
        }

        public void AddProduct(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            String ID = pictureBox.Tag.ToString();
            ListViewItem item = new ListViewItem();
            AddOrUpdate(Count, ID);
            string name = "";
            decimal price = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT * FROM ITEM WHERE ID =" + ID;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader["fName"].ToString();
                            price = decimal.Parse(reader["price"].ToString());
                            Total += price;
                            item = new ListViewItem(new string[]
                            {
                                name,Count[ID].ToString(), price.ToString()
                            });
                            //listView.Items.Add(item);
                        }
                    }
                }
            }
            if (Count[ID] == 1) listView.Items.Add(item);
            else
            {
                foreach (ListViewItem i in listView.Items)
                {
                    if (i.SubItems[0].Text == name)
                    {
                        i.SubItems[1].Text = Count[ID].ToString();
                        decimal x = Count[ID] * price;
                        i.SubItems[2].Text = x.ToString();
                    }
                }
            }
            txtTotal.Text = Total.ToString() + "$";
        }
        public void LoadProductAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT ID, fName, Price FROM ITEM";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy tên món ăn từ cột "fName"
                            string fName = reader["fName"].ToString();

                            // Lấy giá từ cột "Price" và chuyển đổi sang kiểu decimal
                            decimal Price = Convert.ToDecimal(reader["Price"]);
                            int id = Convert.ToInt32(reader["ID"].ToString());

                            // Tạo một instance mới của UC_Item truyền tên món ăn và giá
                            UC_Item itemControl = new UC_Item(fName, Price, id);
                            itemControl.guna2CirclePictureBox1.Click += AddProduct;
                            this.FlowMenu.Controls.Add(itemControl);
                        }
                    }
                }
            }
        }

        public void LoadProductFood()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT ID, fName, Price FROM ITEM where idCategory = 1";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy tên món ăn từ cột "fName"
                            string fName = reader["fName"].ToString();

                            // Lấy giá từ cột "Price" và chuyển đổi sang kiểu decimal
                            decimal Price = Convert.ToDecimal(reader["Price"]);
                            int id = Convert.ToInt32(reader["ID"].ToString());

                            // Tạo một instance mới của UC_Item truyền tên món ăn và giá
                            UC_Item itemControl = new UC_Item(fName, Price, id);
                            itemControl.guna2CirclePictureBox1.Click += AddProduct;
                            this.FlowMenu.Controls.Add(itemControl);
                        }
                    }
                }
            }
        }
        public void LoadProductDrink()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT ID, fName, Price FROM ITEM where idCategory = 2";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy tên món ăn từ cột "fName"
                            string fName = reader["fName"].ToString();

                            // Lấy giá từ cột "Price" và chuyển đổi sang kiểu decimal
                            decimal Price = Convert.ToDecimal(reader["Price"]);
                            int id = Convert.ToInt32(reader["ID"].ToString());

                            // Tạo một instance mới của UC_Item truyền tên món ăn và giá
                            UC_Item itemControl = new UC_Item(fName, Price, id);
                            itemControl.guna2CirclePictureBox1.Click += AddProduct;
                            this.FlowMenu.Controls.Add(itemControl);
                        }
                    }
                }
            }
        }
        private void fCustomer_Load(object sender, EventArgs e)
        {
            this.FlowMenu.Controls.Clear();
            LoadProductAll();
        }
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            string filePath = "E:\\Project\\KTPOS-Restaurant-Order-App\\KTPOS Order\\Temp\\Bill.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Ghi dữ liệu từng dòng
                foreach (ListViewItem item in listView.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        writer.Write(subItem.Text + "\t");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
