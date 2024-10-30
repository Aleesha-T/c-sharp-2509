using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class DivisionByZero : Exception
    {
        public DivisionByZero()
        {
            Console.WriteLine("Tried to divide by zero");
        }
    }
    public class ExceptionClass
    {
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Quotient is: "+(a/b));
            }
            else
            {
                throw new DivideByZeroException("Division by zero is not possible");
            }
        }

        public static int Division(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                result = numerator / denominator;
            }
            catch(Exception ex)
            {
                throw new DivisionByZero();
            }
            return result;
        }
    }
}
