using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public abstract class Bird
    {
        public abstract void Fly();
    }
    public interface ISwim
    {
        void Swim(); //inside interface, access modifiers cannot be given
    }
    public class Martin : Bird
    {
        public override void Fly() //abstract method in abstract class should be overridden
        {
            Console.WriteLine("The purple martin can fly");
        }
    }
    public class Dolphin : ISwim
    {
        public void Swim() //method in interface can be implemented without using override
        {
            Console.WriteLine("Dolphin can swim");
        }
    }
}
