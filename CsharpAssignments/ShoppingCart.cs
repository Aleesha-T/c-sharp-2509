using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class ShoppingCart
    {
        public float total_price;
        private List<CartProduct> products = new List<CartProduct>();

        public void AddProduct(ShoppingCart.CartProduct product)
        {
            products.Add(product);
        }

        public void TotalPrice()
        {
            foreach (var product in products)
            {
                total_price += product.Price;
            }
            Console.WriteLine($"Total Price: Rs.{total_price}");
        }

       public void Display()
       {
            foreach (var item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}, Price: Rs.{item.Price}, Quantity: {item.Quantity}");
            }
       }
        public class CartProduct
        {
            private string name;
            private float price;
            private int quantity;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public float Price
            {
                get { return price; }
                set { price = value; }
            }
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
            
            public CartProduct(string name, float price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
    }
}
