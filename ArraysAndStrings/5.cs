using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Count
    {
        public static void CountCharacters(string enteredValue)
        {
            int vowels = 0;
            int consonants = 0;
            int specialCharacters = 0;
            for(int i = 0; i < enteredValue.Length; i++)
            {
                if(enteredValue[i] == 'a'|| enteredValue[i] == 'e' || enteredValue[i] == 'i' || 
                    enteredValue[i] == 'o' || enteredValue[i] == 'u')
                {
                    vowels++;
                }
                else if (enteredValue[i] == '!' || enteredValue[i] == '@' || enteredValue[i] == '#' || enteredValue[i] == '$' 
                    || enteredValue[i] == '%' || enteredValue[i] == '^' || enteredValue[i] == '&' || enteredValue[i] == '*')
                {
                    specialCharacters++;
                }
                else
                {                    
                    consonants++;
                }
            }
            Console.WriteLine($"No. of vowels: {vowels}, no. of consonants: {consonants}, no. of special characters: {specialCharacters}");
        }
    }
}
