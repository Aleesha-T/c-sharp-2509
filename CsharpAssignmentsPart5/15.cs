using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace CsharpAssignmentsPart5
{
    public class FileProcessor
    {
        public void ReadFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
                //Using using will close the file automatically
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found: "+filePath);
            }
            //Handles FileNotFoundException
        }
    }
    public class MathOperations
    {
        public int Divide(int a, int b)
        {
            int quotient = 0;
            try
            {
                quotient = a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            //Handling DivideByZeroException.
            return quotient;
        }
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Invalid age provided");
        }
    }
    //InvalidAgeException custom exception definition.
    public class Person
    {
        public int Age { get; set; }
        public void SetAge(int age)
        {   
            this.Age = age;
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException();
            }
            Console.WriteLine("Your age is " + Age);
        }
    }
}
