using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public class ExceptionClass
    {
        public int GetUserInput()
        {
            int number;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You entered an integer");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry. Enter valid number.");
                }
            }
            return number;
        }
    }
}
