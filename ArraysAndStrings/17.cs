using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Reverse
    {
        public static void ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            string reverse = "";
            for (int i = words.Length-1; i >= 0; i--)
            {
                reverse += words[i] + " ";
            }
            //Reverses words.
            Console.WriteLine(reverse);
        }
    }
}
