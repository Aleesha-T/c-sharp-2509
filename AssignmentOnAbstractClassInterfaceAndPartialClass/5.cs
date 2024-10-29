using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public static class MathOperations
    {
        public static void Add(int a, int b) //static function
        {
            Console.WriteLine("Sum is: "+(a+b));
        }
        public static void Multiply(int a, int b) //static function
        {
            Console.WriteLine("Product is: "+(a*b));
        }
    }
}
