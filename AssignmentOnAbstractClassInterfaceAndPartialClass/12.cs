using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class DeveloperAttribute : Attribute //inheriting from inbuilt class Attribute
    {
        public string Name { get;}
        public string LastModifiedDate { get;}
        public DeveloperAttribute(string name, string lastModifiedDate)
        {
            Name = name;
            LastModifiedDate = lastModifiedDate;
        }
    }
    [Developer("Aleesha", "2024-10-28")] //custom attribute for class
    class Calculator
    {
        [Developer("Jaya", "2024-10-26")] //custom attribute for method
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum is: " + (a + b));
        }
    }
   
}
