using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public interface IMovable
    {
        void Move();
    }
    public interface IDrawable
    {
        void Draw();
    }
    public class CarNew : IMovable, IDrawable //inheriting from multiple interfaces
    {
        public void Move()
        {
            Console.WriteLine("This is movable"); //implementaton of IMovable interface
        }
        public void Draw()
        {
            Console.WriteLine("This is drawable"); //implementaton of IDrawable interface
        }
    }
}
