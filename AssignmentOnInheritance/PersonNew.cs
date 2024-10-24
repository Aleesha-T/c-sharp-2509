using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class PersonNew
    {
        public static string Name { get; set; }    
        public static int Age { get; set; }
        public PersonNew(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class EmployeeNew : PersonNew
    {
        public string Department;
        public EmployeeNew(string department):base(Name, Age)
        {
            Department = department;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
