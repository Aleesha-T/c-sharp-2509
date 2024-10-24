using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    interface IPrintable
    {
         void Print();
    }
    interface IScannable
    {
         void Scan();
    }
    public class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("This is from IPrintable interface");
        }

        public void Scan()
        {
            Console.WriteLine("This is from IScannable interface");
        }
    }
}
