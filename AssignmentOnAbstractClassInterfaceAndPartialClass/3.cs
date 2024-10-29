using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public interface IDrive
    {
        void Drive();
    }
    public class CarNew : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car is driven by a driver");
        }
    }
    public class Truck : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Truck is driven by a trucker");
        }
    }
}
