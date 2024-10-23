using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Reverse
    {
        public int firstnumber, secondnumber;

        public Reverse(int num1, int num2)
        {
            firstnumber = num1;
            secondnumber = num2;
        }
        public void Display()
        {
            Console.WriteLine("First number is: " + firstnumber);
            Console.WriteLine("Second number is: " + secondnumber);
        }

        public static Reverse operator +(Reverse reverse)
        {
            int temp = reverse.secondnumber;
            reverse.secondnumber = reverse.firstnumber;
            reverse.firstnumber = temp;
            return reverse;
        }
    }
}
