using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public static class DelegateClass
    {
        public delegate void calculate(int r);
        //Delegate.
        public static void Area(int radius)
        {
            Console.WriteLine("Area is: "+3.14*radius*radius);  
        }
        public static void Perimeter(int radius)
        {
            Console.WriteLine("Perimeter is: " + 2*3.14 * radius);
        }
    }
}
