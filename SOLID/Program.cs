using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StudentDetails student1 = new StudentDetails("Aleesha", "20EE");
            //StudentActivityPoints points = new StudentActivityPoints();
            //points.CalculateLeftPoints(40);

            //Open Closed Principle
            //----------------------------------------------------------------------------------//

            //Console.WriteLine("Enter a directory name");
            //string directoryName = Console.ReadLine();
            //if (directoryName != string.Empty)
            //{
            //    if (!Directory.Exists(directoryName))
            //    {
            //        Directory.CreateDirectory(directoryName);
            //        if (Directory.Exists(directoryName))
            //        {
            //            Console.WriteLine("Directory created");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Directory already exists.");
            //    }
            //}

            //Creating a directory if it doesn't exist.
            //----------------------------------------------------------------------------------------//

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee(1, "Aleesha", "IT");
            employees.Add(employee);
            Employee newEmployee = new Employee(2, "Liza", "HR");
            employees.Add(newEmployee);

            string result = JsonConvert.SerializeObject(employees);
            //Console.WriteLine(result);
            //Serializing object.
            //string result1 = JsonConvert.SerializeObject(employees);
            //Employee deserial = JsonConvert.DeserializeObject<Employee>(result1);

            List<Employee> deserialized = JsonConvert.DeserializeObject<List<Employee>>(result);
           
            Console.ReadLine();
        }
    }
}
