using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Anagram
    {
        public static void CheckAnagram(string inputOne,  string inputTwo)
        {
            inputOne = inputOne.ToLower();
            inputTwo = inputTwo.ToLower();
            //Converting the entered strings to lower case.
            char[] firstInput = inputOne.ToCharArray();
            char[] secondInput = inputTwo.ToCharArray();
            //Converting strings to character arrays.
            Array.Sort(firstInput);
            Array.Sort(secondInput);
            //Sorting strings.
            if(new string (firstInput) == new string (secondInput))
            {
                Console.WriteLine("Entered strings are anagrams.");
            }
            //Checking if the strings are equal.
            else
            {
                Console.WriteLine("Entered strings are not anagrams.");
            }            
        }
    }
}
