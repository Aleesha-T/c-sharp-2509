using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Anonymous
    {
        public static void Display(dynamic value)
        {
            Console.WriteLine("Using function");
            Console.WriteLine($"Sl. No.: {value.itemNo}, Name: {value.itemName}, Price: {value.itemPrice}");
        }
    }
}
