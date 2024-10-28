using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class Calculation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum is: "+(a+b));    
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum is: " + (a + b + c));
        }
        //Method overloading

        public virtual void Subtract(int a, int b)
        {
            Console.WriteLine("Difference is: "+(a-b));
        }
    }
    public class Calculator:Calculation
    {
        public override void Subtract(int a, int b)
        {
            Console.WriteLine("Difference is: " + (a - b));
        }
        //Method overriding
    }
}
