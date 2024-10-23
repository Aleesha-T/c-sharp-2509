using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    //Copy Constructor
    public class Details
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Place { get; set; }

        public Details()
        {
            Name = "Unknown";
            Age = 0;
            Place = "Unknown";
        }

        public Details(string name, int age, string place)
        {
            Name = name;
            Age = age;
            Place = place;
        }

        public Details(Details details)
        {
            Name = details.Name;
            Age = details.Age;
            Place = details.Place;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Place: {Place}");
        }

    }
}
