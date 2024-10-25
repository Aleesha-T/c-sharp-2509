using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class AnimalNew
    {
        public string Name { get; set; }
        public void Eat(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} is eating");
        }
    }
    public class DogNew:AnimalNew 
        //DogNew IS-A AnimalNew
    {
        public void Bark(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} barks");
        }
    }
}
