using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class ProductNew
    {
        public string name { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public float finalprice;

        public ProductNew(string name)
        {
            this.name = name;
            this.price = 0;
            this.discount = 0;
        }
        public ProductNew(string name, float price)
        {
            this.name = name;
            this.price = price;
            this.discount = 0;
        }
        public ProductNew(string name, float price, int discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        public void CalculateFinalPrice()
        {
            if (discount != 0)
            {
                finalprice = price- (price * discount / 100);
            }
            else
            {
                finalprice = price;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Product Name: {name}, Price: {price:C}, Discount: {discount}, Final Price: {finalprice:C}");
        }
    }
}
