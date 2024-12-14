using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using KTPOS_Order.Proccess;
using static ZXing.QrCode.Internal.Mode;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Item : UserControl
    {
        string fName;
        decimal Price;
        private string connectionString;

        public UC_Item()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
         ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;

            // Thiết lập DoubleBuffered cho các control con bằng Reflection
            SetDoubleBuffered(txtName, true);
            SetDoubleBuffered(txtCost, true);
            SetDoubleBuffered(guna2CirclePictureBox1, true);
        }
        private void SetDoubleBuffered(Control control, bool value)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, value, null);
        }
        public UC_Item(string fName, decimal Price, int id)
        {
            InitializeComponent();
            txtName.Text = fName;
            txtCost.Text = $"${Price:0.00}";
            guna2CirclePictureBox1.Tag = id;
        }
        public void get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Câu lệnh SQL để lấy thông tin món ăn có ID = 1 từ bảng ITEM
                string sql = "SELECT fName, Price FROM ITEM";

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
        public string GetName()
        {
            return txtName.Text;
        }
    }
}
