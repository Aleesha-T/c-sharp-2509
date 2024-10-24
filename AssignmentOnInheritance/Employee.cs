using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee works in the office");
        }
    }
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is responsible for management");
        }
    }
}
