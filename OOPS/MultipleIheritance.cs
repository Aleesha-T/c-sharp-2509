using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class MultipleIheritance
    {
        interface A
        {
            int add(int a, int b);
        }

        interface B
        {
            int sub(int a, int b);
        }

        class C : A, B
        {
            public int add(int a, int b) { return a + b; }
            public int sub(int a, int b) { return a - b; }
            public int mult(int a, int b) { return a * b; }
        }
    }
}
