using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public class Throw
    {
        public static void ValidateAge(int age)
        {
            if(age<=18)
            {
                throw new Exception("Age should not be less than 18.");
                //Throwing new exception with custom message.
            }
            else
            {
                Console.WriteLine("Successfully validated your age.");
            }
        }
    }
}
