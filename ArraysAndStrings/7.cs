using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class SubString
    {
        public static void FindSubString(string enteredString, string subString)
        {
            int count = 0;
            int index = 0;
            while ((index = enteredString.IndexOf(subString, index)) != -1)
            {
                count++;
                index += subString.Length;
            }
            Console.WriteLine($"Count is: {count}");
        }
        //Finds no. of occurences of a substring.
    }
}
