using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Repeating
    {
        public static void FindFirstNonRepeating(string input)
        {
            List<char> seen = new List<char>();
            //List to store seen characters.
            List<char> repeating = new List<char>();
            //List to store repeating characters.
            foreach (char c in input)
            {
                if (seen.Contains(c))
                {
                    repeating.Add(c);
                }
                else
                {
                    seen.Add(c);
                }
            }
            //Finds repeating characters.
            char nonRepeating = '\0';
            foreach (char c in input)
            {
                if (!repeating.Contains(c))
                {
                    nonRepeating = c;
                }
                if (nonRepeating != '\0')
                {
                    break;
                }
            }
            //Gives first non-repeating character.
            Console.WriteLine(nonRepeating);
        }
    }
}
