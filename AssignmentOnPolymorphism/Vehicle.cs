using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driven");
        }
    }
    public class  Car:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driven");
        }
    }
}
