using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public partial class Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        //properties in first part of class
        public Person(string name, int age)
        {
            Name= name;
            Age= age;
        }
    }
}
