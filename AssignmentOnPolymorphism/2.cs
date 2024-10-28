using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class MethodOverloading
    {
        public void Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            Console.WriteLine($"Product of two integers: {product}");
        }
        public void Multiply(int firstNumber, int secondNumber, int thirdNumber)
        {
            int product = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"Product of three integers: {product}");
        }
        //based on number of parameters
        public void Multiply(double firstNumber, double secondNumber)
        {
            double product = firstNumber * secondNumber;
            Console.WriteLine($"Product of two double numbers: {product}");
        }
        //based on datatype of parameters
        public void Multiply(int firstNumber, double secondNumber)
        {
            double product = firstNumber * secondNumber;
            Console.WriteLine($"Product of one double and one integer: {product}");
        }
        public void Multiply(double firstNumber, int secondNumber)
        {
            double product = firstNumber * secondNumber;
            Console.WriteLine($"Product of one double and one integer with order reversed: {product}");
        }
        //based on order of parameters
    }
}
