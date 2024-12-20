﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Item1 : UserControl
    {
        string connectionString = "Data Source=DESKTOP-4S5L10L;Initial Catalog=KTPOS;" + "Integrated Security=true";
        string fName;
        decimal Price;
        int Amount = 0;
        
        public UC_Item1 ()
        {
            InitializeComponent();
        }


        public UC_Item1(string fName, decimal Price, int id)
        {
            InitializeComponent();
            txtName.Text = fName;
            txtCost.Text = $"${Price:0.00}";
            guna2CirclePictureBox1.Tag = id;
        }

        public UC_Item1 Item()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT fName, Price FROM ITEM WHERE ID = 1";

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
                            UC_Item1 itemControl = new UC_Item1(fName, Price,1);

                            // Trả về thông tin của món
                            return itemControl;
                        }
                        else return null;
                    }
                }
            }
        }

        public void get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT fName, Price FROM ITEM WHERE ID = 1";

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
                            //UC_Item1 itemControl = new UC_Item1(fName, Price);
                        }
                    }
                }
            }
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            UC_OrderFood a = new UC_OrderFood();
            
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }
        public UC_OrderFood UCAReference { get; set; }
       

        private void txtCost_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
