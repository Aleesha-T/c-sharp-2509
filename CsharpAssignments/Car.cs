using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Car
    {
        private static int counter;
        static Car()
        {
            counter = 0;
        }
        public Car() 
        {
            counter++;
        }
        public void Count()
        {
            Console.WriteLine("Count is: " + counter);
        }        
    }
}
