using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    //Method Overriding - Dynamic Polymorphism
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape is drawn");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle is drawn");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }
    }
}
