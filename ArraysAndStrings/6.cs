using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class String
    {
        public static void Reverse(string myString)
        {
            string reverse=string.Empty;
            for (int i = myString.Length-1; i>=0; i--)
            {
                reverse += myString[i];
            }
            Console.WriteLine($"Reverse is: {reverse}");
        }
    }
}
