using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Check
    {
        public static void CheckString(string input)
        {
            bool myBool = input.All(char.IsDigit);
            //Returns true if all characters are digits.
            if (myBool)
            {
                Console.WriteLine("All are numbers");
            }
            else
            {
                Console.WriteLine("All are not numbers");
            }
        }
    }
}
