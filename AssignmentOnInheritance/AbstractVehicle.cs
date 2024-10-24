using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public abstract class AbstractVehicle
    {
        public abstract void Drive();        
    }
    public class Car : AbstractVehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driver drives a car.");
        }
    }
    public class Bike : AbstractVehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Rider rides a bike.");
        }
    }
}
