using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ObsoleteClass
    {
        [Obsolete("This is an obsolete method", false)]
        public static void Method()
        {
            Console.WriteLine("Obsolete method");
        }

        [Conditional ("DEBUG")]
        public static void NewMethod()
        {
            Console.WriteLine("Conditional method");
        }
    }
}
