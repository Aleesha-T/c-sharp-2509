using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class StudentDetails
    {
        public string Name;
        public string ID;       
        public List<int>marks = new List<int>();

        public StudentDetails(string name, string id)
        {
            Name = name;
            ID = id;
        }
        
        public void AddMarks(int a)
        {
            if (a > 0 && a <= 100)
            {
                marks.Add(a);
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
        }
       public int Average()
       {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            int average = sum / marks.Count;
            return average;
       }

    }
}
