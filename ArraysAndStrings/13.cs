using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class StringManipulation
    {
        public static void RemoveDuplicate(string input)
        {
            input=input.ToLower();
            List<char> seen = new List<char>();
            //List which contains checked characters.
            List<char> result = new List<char>();
            //List with output.
            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    result.Add(c);
                    seen.Add(c);
                }
            }
            string resultString = string.Empty;
            foreach (char c in result)
            {
                resultString += c;
            }
            //Converts result list to a string
            Console.WriteLine(resultString);
        }
    }
}
