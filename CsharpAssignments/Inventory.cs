using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Item
    {
        public string Name { get; set; }
        private int stock;
        private float price;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value");
                }
                stock = value;
            }
        }
        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                price= value;
            }
        }
        public Item(string name, int itemstock, float itemprice)
        {
            Name = name;
            Stock = itemstock;
            Price = itemprice;
        }
    }

    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(string Name)
        {
            items.RemoveAll(x => x.Name == Name);
        }

        public void UpdateItem(string Name, int stock, float price)
        {
            var item_to_be_updated = items.Find(x => x.Name == Name);
            item_to_be_updated.Stock = stock;
            item_to_be_updated.Price = price;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Stock: {item.Stock}, Price: {item.Price}");
            }
        }
    }
}
