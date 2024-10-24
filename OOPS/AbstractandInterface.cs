using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class Abstract
    {
        public abstract string Name { get; }
        public static void Display(Class1 class1)
        {
            Console.WriteLine("Name: "+class1.Name);
        }
    }

    interface I
    {
        void DisplayDetails();
    }

    public class Class1 : Abstract
    {
        public override string Name => "Aleesha";
    }

    public class Class2 : I
    {
        public int Age { get; set; }
        public int Place { get; set; }
        public Class2(int age, int place)
        {
            Age = age;
            Place = place;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Age: {Age}, Place: {Place}");
        }
    }
}
