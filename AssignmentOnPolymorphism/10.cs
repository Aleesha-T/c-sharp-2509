using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class Laptop
    {
        public readonly int Count = 5; //value cannot be changed
        public virtual void LaptopCount()
        {
            Console.WriteLine("Count is: " + Count);
        }
    }
    public class Lenovo : Laptop
    {
        public override void LaptopCount()
        {
            base.LaptopCount();
        }
    }
}
