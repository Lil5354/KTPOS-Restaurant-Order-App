using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_OrderFoodOption : UserControl
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        decimal Total = 0;

        public static List<ListViewItem> listItems = new List<ListViewItem>();
        public Dictionary<string, int> Count = new Dictionary<string, int>();
        public UC_OrderFoodOption()
        {
            InitializeComponent();
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
        }

        public void LoadProduct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn trong group Food từ bảng ITEM
                string sql = "SELECT ID, fName, Price FROM ITEM WHERE gr = 'Food'";

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
                            UC_Item1 itemControl = new UC_Item1(fName, Price, id);
                            itemControl.guna2CirclePictureBox1.Click += AddProduct;
                            this.FlowMenu.Controls.Add(itemControl);
                        }
                    }
                }
            }
        }

        private void UC_OrderFoodOptions_Load_1(object sender, EventArgs e)
        {
            LoadProduct();
        }

        public ListView GetList { get { return listView; } }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
