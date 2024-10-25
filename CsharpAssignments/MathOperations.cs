using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class MathOperations
    {
        static double PI;
        static MathOperations() //static constructor
        {
            PI = 3.14;
        }

        public void Display()
        {
            Console.WriteLine("Value of PI is: "+PI);
        }
    }
}
