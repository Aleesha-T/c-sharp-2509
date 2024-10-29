using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Out
    {
        public static void Display(out string message)
        {
            message = "Aleesha ";
            message += "Thomas";
            Console.WriteLine($"Value inside function (with out): {message}");
        }
        public static void Display(string name)
        {
            name = "Alwin K ";
            name += "Thomas";
            Console.WriteLine($"Value inside function (without out): {name}");
        }
    }
}
