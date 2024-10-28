using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class EmployeeNew
    {
        public string[] Tasks { get; set; } //array as a property
        public EmployeeNew(string[] task) 
        {
            Tasks=task;
        }
        public virtual void Display() //virtual method
        {
            foreach(var t in Tasks)
            {
                Console.Write($" {t}");
            }
        }
    }
    public class ManagerNew:EmployeeNew
    {
        public ManagerNew(string[] task) : base(task)
        {
        }
        public override void Display() //override method
        {
            Console.WriteLine("Tasks of manager:");
            foreach (var t in Tasks)
            {
                Console.Write($" {t}");
            }
        }
    }
    public class DeveloperNew: EmployeeNew
    {
        public DeveloperNew(string[] task) : base(task)
        {
        }
        public override void Display() //override method
        {
            Console.WriteLine("Tasks of developer:");
            foreach (var t in Tasks)
            {
                Console.Write($" {t}");
            }
        }
    }
}
