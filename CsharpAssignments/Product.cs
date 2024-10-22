using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Product
    {
        public string Name { get; set; }
        private float price;
        private int stock;

        public float Price 
        { 
            get { return price; } 
            set 
            { 
                if(value<0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }             
                price = value; 
            } 
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                stock = value;
            }
        }

        public Product(string name, float productprice, int productstock)
        {
            Name = name;
            Price = productprice;
            Stock = productstock;
        }
    }
    public class Order
    {
        private List<Product> products=new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void OrderProduct(string Name)
        {
            var product_ordered = products.Find(x => x.Name == Name);
            if (product_ordered != null)
            {
                product_ordered.Stock--;
            }
        }

        public void DisplayProductDetails(string Name)
        {
            var product_to_be_displayed = products.Find(x => x.Name == Name);
            Console.WriteLine($"Name: {product_to_be_displayed.Name}, Price: {product_to_be_displayed.Price}, Stock: {product_to_be_displayed.Stock}");
        }
    }
}
