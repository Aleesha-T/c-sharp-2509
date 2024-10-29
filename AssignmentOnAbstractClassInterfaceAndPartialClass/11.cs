using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public enum CarType
    {
        Sedan,
        SUV,
        Truck,
        Coupe
    }
    public class NewCar
    {
        public CarType CarType { get; set; }
        
        public void Display(CarType type)
        {
            int number = (int)type;
            switch(number) 
            {
                case (int)CarType.Sedan:
                    Console.WriteLine("This is Sedan");
                    break;
                case (int)CarType.SUV:
                    Console.WriteLine("This is SUV");
                    break;
                case (int)CarType.Truck:
                    Console.WriteLine("This is Truck");
                    break;
                case (int)CarType.Coupe:
                    Console.WriteLine("This is Coupe");
                    break;
            }
        }
    }
}
