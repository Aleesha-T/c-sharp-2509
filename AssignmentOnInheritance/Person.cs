using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    //Single Inheritance
    public class Person
    {
        public string Name{get;set;}
        public int Age { get; set; }
    }
    public class Student : Person
    {
        public char Grade { get; set; }
        public Student(string name, int age, char grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}
