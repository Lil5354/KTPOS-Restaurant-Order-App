using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

namespace KTPOS_Order.Classes
{
    public class Food
    {
        private string name;
        private int amount = 0;
        private float price;

        public string Name { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }

        public Food(string name, int amount, float price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        
    }
    public class FoodList
    {
        Dictionary<string, Food> menu;
        public FoodList()
        {
            menu = new Dictionary<string, Food>();
        }
        public void UpdateFoodItem(string key, string name, float price)
        {
            if (menu.ContainsKey(key))
            {
                // Nếu món ăn đã tồn tại, tăng số lượng lên 1
                var existingItem = menu[key];
                existingItem.Amount++;
                menu[key] = existingItem; // Cập nhật lại món ăn trong dictionary
            }
            else
            {
                // Nếu món ăn chưa tồn tại, thêm mới với số lượng là 1
                var newItem = new Food(name, 1, price);
                menu.Add(key, newItem);
            }
        }
    }
}
