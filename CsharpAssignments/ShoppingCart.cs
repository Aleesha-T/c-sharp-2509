using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class ShoppingCart
    {
       public static float total_price=0;
       private List<Product> products = new List<Product>();

       //public void AddProduct(ShoppingCart.CartProduct product)
       //{
       //     products.Add(product);
       //}
       public static void TotalPrice(CartProduct product)
       {
            total_price += product.Price;
            Console.WriteLine("Total Price: Rs."+total_price);
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
