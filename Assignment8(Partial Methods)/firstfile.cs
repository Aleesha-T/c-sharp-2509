using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Partial_Methods_
{
    public partial class Employee
    {
        public partial void CalculateSalary(int baseSalary, int hra, int bonus); //method declaration in one part of partial class
    }
    //using partial method will help in showing only the necessary info to certain accessors.
}
