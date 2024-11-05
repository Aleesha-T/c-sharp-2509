using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Sentence
    {
        public static void FindLongest(string input)
        {
            string[] words = input.Split(' ');
            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            Console.WriteLine("Longest word is: " + longest);
        }
        //Find longest word in a sentence.

        public static void CountWords(string input)
        {
            string[] words = input.Split(' ');
            int count = words.Length;
            Console.WriteLine("No. of words is: " + count);
        }
        //Count number of words.
    }
}
