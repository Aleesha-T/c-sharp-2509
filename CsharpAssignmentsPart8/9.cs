using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart8
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        //Method for addition.
        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        //Method for division.
    }
}
