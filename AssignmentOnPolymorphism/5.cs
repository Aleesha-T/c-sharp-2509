using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class Employee
    {
        public static int NoOfEmployees; //static integer
        public int Number; //instance variable
        public string Name;
        public Employee()
        {
            NoOfEmployees++;
            Number++;
        }
        public static void DisplayNumber() //static method
        {
            Console.WriteLine("\nNo. of employees(using static field): " + NoOfEmployees);
        }
        public virtual void EmployeeDetail()
        {
            Console.WriteLine("Count with non-static field: "+Number);
            Console.WriteLine("Are you a manager or a developer?");
        }
    }
    public class Manager:Employee
    {
        public Manager(string name)
        {
            Name = name;
        }
        public override void EmployeeDetail()
        {
            Console.WriteLine("Count with non-static field: " + Number);
            Console.WriteLine("Manager name: "+Name);
        }
    }
    public class Developer:Employee
    {
        public Developer(string name)
        {
            Name = name;
        }
        public override void EmployeeDetail()
        {
            Console.WriteLine("\nCount with non-static field: " + Number);
            Console.WriteLine("Developer name: "+Name);
        }
    }
}
