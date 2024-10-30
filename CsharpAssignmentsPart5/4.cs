using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public struct Circle
    {
        public int Radius {  get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
    //Struct is of value type.
    public class Shape
    {
        public int NoOfSides { get; set; }
        public Shape(int noOfSides)
        {
            NoOfSides = noOfSides;
        }
    }
    //Class is of reference type.
}
