using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class RefKeyword
    {
        public static void ChangeStringValue(ref string myString)
        {
            myString = "Alwin";
            Console.WriteLine("Value when function is called: "+myString);
        }
    }
}
