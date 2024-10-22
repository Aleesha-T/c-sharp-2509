using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Rectangle
    {
        public void RectangleArea(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("Area of rectangle is: " + area);
        }
        public void RectangleArea(int length)
        {
            int area = length * length;
            Console.WriteLine("Area of square is: " + area);
        }
    }
}
