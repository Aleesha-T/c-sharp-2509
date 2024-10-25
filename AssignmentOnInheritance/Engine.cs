using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public int NoOfCylinders { get; set; }
        public void Display()
        {
            Console.WriteLine($"Horse Power: {HorsePower} hp, Torque: {Torque} Nm, No. of Cylinders: {NoOfCylinders}");
        }
    }
    public class CarNew
    {
        private Engine engine;
        public string CarName {  get; set; }
        public CarNew(string carName, int horsePower, int torque, int noOfCylinders, Engine engine)
        {
            CarName = carName;
            engine.HorsePower=horsePower;
            engine.Torque=torque;
            engine.NoOfCylinders=noOfCylinders;
        }
        public void Display()
        {
            Console.WriteLine($"Car Name: {CarName}");
        }
    }
}
