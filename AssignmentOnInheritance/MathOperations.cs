using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    sealed public class MathOperations
    {
        public int Add(int a,  int b)
        {
            return a + b;
        }
    }
    //public class Inherit : MathOperations
    //{

    //}
    //Cannot inherit from sealed class
}
