using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class Calculation
    {
        public delegate int CalculationDelegate(int x, int y);
        //Delegate declaration.
        public static int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Subtraction(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        //Methods for addition and subtraction.
        public static void Calculate(int firstNumber, int secondNumber, CalculationDelegate calculationDelegate)
        {
            calculationDelegate += Addition;
            int sum = calculationDelegate(firstNumber, secondNumber);
            Console.WriteLine("Sum is: "+sum);
            calculationDelegate += Subtraction;
            int difference = calculationDelegate(firstNumber, secondNumber);
            Console.WriteLine("Difference is: "+difference);
        }
        //Method with two integers and a delegate as a parameter.
    }
}
