using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public abstract class ShapeNew
    {
        public virtual void Draw() //virtual method in abstract class
        {
            Console.WriteLine("Shape is drawn");
        }
    }
    public interface IShape
    {
        void DrawShape(); //declaring function in interface
    }
    public class Hexagon : ShapeNew
    {
        public override void Draw() //overriding a method in abstract class
        {
            Console.WriteLine("Hexagon is drawn");
        }
    }
    public class Pentagon : IShape
    {
        public void DrawShape() //implementing a method in an interface
        {
            Console.WriteLine("\nPentagon is drawn");
        }
    }
}
