using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class PersonClass
    {
        public string Name { get; set; }
        public PersonClass(string name)
        {
            Name = name;
        }
    }
    public class StudentNew : PersonClass
    {
        new public string Name { get; set; } //hiding name property
        public StudentNew(string name) : base(name) //using name from base class
        {
            base.Name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine("Name: " +base.Name);
        }
    }
}
