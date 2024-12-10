using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace KTPOS_Order.Customer_Control
{
    public partial class UC_Payment : UserControl
    {
        public static List<ListViewItem> a = new List<ListViewItem>();
        decimal SubTotal = 0;
        decimal VAT = 1;
        decimal Total;
        public UC_Payment()
        {
            InitializeComponent();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            string filePath = "E:\\Project\\KTPOS-Restaurant-Order-App\\KTPOS Order\\Temp\\Bill.txt";
            listView.Items.Clear();

            // Đọc tất cả các dòng từ file
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // Các dòng tiếp theo: Dữ liệu
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] items = lines[i].Split('\t');
                    ListViewItem listViewItem = new ListViewItem(items);
                    listView.Items.Add(listViewItem);
                    SubTotal += decimal.Parse(listViewItem.SubItems[2].Text.ToString());
                }
            }
            txtSubTotal.Text = SubTotal.ToString();
            txtVAT.Text = "1";
            Total = SubTotal - VAT;
            txtTotal.Text = Total.ToString();
        }
    }
}
