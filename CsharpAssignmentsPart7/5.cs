using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class Greet
    {
        public delegate void GreetDelegate(string message);
        //Delegate declaration.
        public GreetDelegate greet = delegate (string msg) { Console.WriteLine(msg); };
        //Anonymous method.
    }
}
