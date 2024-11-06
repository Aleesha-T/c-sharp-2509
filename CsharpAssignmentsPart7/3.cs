using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class Delegates
    {
        public delegate void OperationDelegate(double num1, double num2);
        //Delegate declaration.
        public static void Addition(double firstNumber,  double secondNumber)
        {
            Console.WriteLine("Sum is: " + (firstNumber + secondNumber));
        }
        //Addition method.
        public static void Subtraction(double firstNumber, double secondNumber)
        {
            Console.WriteLine("Difference is: " + (firstNumber - secondNumber));
        }
        //Subtraction method.
        public static void Multiplicaation(double firstNumber, double secondNumber)
        {
            Console.WriteLine("Product is: " + (firstNumber * secondNumber));
        }
        //Multiplication.
        public static void Division(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                Console.WriteLine("Quotient is: " + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("Division by zero is not defined.");
            }
        }
        //Division.
    }
}
