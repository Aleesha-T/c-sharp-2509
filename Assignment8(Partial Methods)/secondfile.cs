using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Partial_Methods_
{
    public partial class Employee
    {
        public partial void CalculateSalary(int baseSalary, int hra, int bonus) //method implementation in another part of partial class
        {
            int salary = baseSalary + hra + bonus;
            Console.WriteLine("Total salary is: " + salary);
        }
        //if not implemented, it will show error, and hence it is mandatory to implement
    }
}
