using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class EmployeeNew
    {
        public string Name;
        public string Department;
        public EmployeeNew(string name, string department) 
        {
            Name = name;
            Department = department;
        }
    }
    public class EmployeeDetails
    {
        private List<EmployeeNew> employees = new List<EmployeeNew>();

        public void AddEmployee(EmployeeNew employee)
        {
            employees.Add(employee);
        }
        public void ShowDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Department: {employee.Department}");
            }
        }
    }
}
