using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class NewPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public NewPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} in base class");
        }
        //method in base class
    }
    public class NewEmployee:NewPerson
    {
        public NewEmployee(string name, int age) : base(name, age)
        {
        }
        //constructor referenced from base class
        public override void DisplayInfo()
        {
            base.DisplayInfo(); //method taken from base class
            Console.WriteLine($"Name: {Name}, Age: {Age} in child class");
        }   
        //method in child class
    }
}
