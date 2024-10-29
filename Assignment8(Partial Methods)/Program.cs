// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Partial_Methods_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Assignment 8. Partial Methods
            //Create a partial class Employee with a partial method CalculateSalary().
            //Implement the partial method in another part of the class and demonstrate its usage.

            Employee employee = new Employee();
            employee.CalculateSalary(50000, 4000, 8000);
            Console.ReadLine();
        }
    }
}
