using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    interface IMovable
    {
        void Movable();
    }
    interface IRechargeable
    {
        void Rechargeable();
    }
    public class Vehicle : IMovable
    {
        public virtual void Movable()
        {
            Console.WriteLine("This vehicle is movable");
        }
    }
    public class ElectricCar : Vehicle
    {
        public override void Movable()
        {
            Console.WriteLine("Electric car is movable");
        }

        public void Rechargeable()
        {
            Console.WriteLine("Electric car is rechargeable");
        }
    }
}
