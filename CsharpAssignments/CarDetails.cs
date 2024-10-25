using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    //constructor chaining
    public class CarDetails
    {
        public string make;
        public string model;
        public int year;
        public float price;

        public CarDetails(string make) 
        { 
            this.make = make;
            this.model = "Unknown";
            this.year = 0;
            this.price = 0;
        }
        public CarDetails(string make, string model) : this(make)
        {
            this.model = model;
        }
        public CarDetails(string make, string model, int year):this(make,model)
        {
            this.year =year;
        }
        public CarDetails(string make, string model, int year, float price):this(make,model,year)
        {
           this.price=price;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}, Price:$ {price}");   
        }
    }
}
