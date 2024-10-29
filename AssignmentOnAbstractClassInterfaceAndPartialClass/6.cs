using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public static class Extension
    {
        public static bool IsEven(this int number)
        {
            if (number%2==0) //check if even
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
