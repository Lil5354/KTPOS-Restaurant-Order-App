using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Item2 : UserControl
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        string fName;
        decimal Price;

        public UC_Item2()
        {
            InitializeComponent();
            txtName.Width = btnItem.Width;
            txtName.Dock = DockStyle.Fill;
        }

        public UC_Item2(string fName, decimal Price)
        {
            InitializeComponent();
            txtName.Text = fName;
            txtCost.Text = $"${Price:0.00}";
        }

        public UC_Item2 Item()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT fName, Price FROM ITEM WHERE ID = 2";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lấy tên món ăn từ cột "fName"
                            fName = reader["fName"].ToString();

                            // Lấy giá từ cột "Price" và chuyển đổi sang kiểu decimal
                            Price = Convert.ToDecimal(reader["Price"]);

                            // Tạo một instance mới của UC_Item truyền tên món ăn và giá
                            UC_Item2 itemControl = new UC_Item2(fName, Price);

                            // Trả về thông tin của món
                            return itemControl;
                        }
                        else return null;
                    }
                }
            }
        }
    }
}
