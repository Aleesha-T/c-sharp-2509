using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class NewProduct
    {
        public string Name { get; set; }
        public float Price;
        public string Category;

        public NewProduct() 
        {
            Name = "Unknown";
            Price = 0;
            Category = "Unknown";
        }
        //default values
        public NewProduct(string name, float price, string category) 
        {
            Name = name;
            Price = price;
            Category = category;
        }
        //initialize values
        public static NewProduct CreateProduct(string name, float price, string category)
        {
            return new NewProduct(name, price, category);
        }
        //static method to create product

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: Rs.{Price}, Category: {Category}");
        }
        //display values
    }
}
