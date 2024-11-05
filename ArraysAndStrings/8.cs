using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Case
    {
        public static void Upper(string myString)
        {
            Console.WriteLine($"String in uppercase: {myString.ToUpper()}");
        }
        //Upper case.
        public static void Lower(string myString)
        {
            Console.WriteLine($"String in lowercase: {myString.ToLower()}");
        }
        //Lower case.
        public static void Title(string myString)
        {
            string[] words = myString.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            Console.WriteLine($"String in title case: {string.Join(" ", words)}");
        }
        //Title case.
    }
}
