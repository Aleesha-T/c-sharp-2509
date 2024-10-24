using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class PersonalDetails
    {
        public string name { get; set; }
        public int age { get; set; }
        public PersonalDetails(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, age: {age}");
        }
    }
    static class Extension
    {
        public static string place = "Haripad";
        public static void DisplayAll(this PersonalDetails details)
        {
            Console.WriteLine($"Name: {details.name}, Age: {details.age}, Place: {place}");
        }
    }

}
