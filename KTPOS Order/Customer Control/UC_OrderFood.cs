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
    public partial class UC_OrderFood : UserControl
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        // Sô lượng Items  trong sql
        int Item_Amount = 5;

        public static List<ListViewItem> listItems = new List<ListViewItem>();

       
        public UC_OrderFood()
        {
            InitializeComponent();
            
        }
        private void txtName_Click(object sender, EventArgs e)
        {

        }
       
        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void AddProduct(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            String ID = pictureBox.Tag.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT * FROM ITEM WHERE ID ="+ ID;

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(new string[]
                            {
                                reader["fName"].ToString(),"1", reader["price"].ToString()
                            });
                            listView.Items.Add(item);
                        }
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
                           decimal  Price = Convert.ToDecimal(reader["Price"]);
                            int id = Convert.ToInt32(reader["ID"].ToString());

                            // Tạo một instance mới của UC_Item truyền tên món ăn và giá
                            UC_Item1 itemControl = new UC_Item1(fName, Price,id);
                            itemControl.guna2CirclePictureBox1.Click += AddProduct;
                            this.FlowMenu.Controls.Add(itemControl);
                        }
                    }
                }
            }
        }

        private void UC_OrderFood_Load_1(object sender, EventArgs e)
        {
            LoadProduct();
        }

        public ListView GetList { get { return listView; } }

        public void Loadlist (ListView lv)
        {

        }

        private void FlowMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FlowMenu_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void guna2CustomGradientPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            listView.Items.AddRange(listItems.ToArray());
        }
    }
}
