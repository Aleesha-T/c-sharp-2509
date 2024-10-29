using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public abstract class Vehicle
    {
        public abstract void StartEngine(); //abstract method
        public void StopEngine() //concrete method
        {
            Console.WriteLine("Stop Vehicle");
        }
    }
    public class Car : Vehicle
    {
        public override void StartEngine() //overriding abstract method
        {
            Console.WriteLine("Start Car");
        }
    }
    public class MotorCycle : Vehicle
    {
        public override void StartEngine() //overriding abstract method
        {
            Console.WriteLine("Start MotorCycle");
        }
    }
}
