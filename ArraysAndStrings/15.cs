using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Frequency
    {
        public static void FindFrequency(string input)
        {
            Dictionary<char, int> frequencies = new Dictionary<char, int>();
            //Dictionary with character as key and frequency of the character in string as value.
            foreach (char c in input)
            {
                if (frequencies.ContainsKey(c))
                {
                    frequencies[c]++;
                }
                else
                {
                    frequencies[c] = 1;
                }
            }
            //Finding frequency.
            foreach (var frequency in frequencies)
            {
                Console.WriteLine(frequency.Key + ": " + frequency.Value);
            }
            //Displaying frequency.
        }
    }
}
