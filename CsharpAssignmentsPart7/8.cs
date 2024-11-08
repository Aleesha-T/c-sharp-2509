using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class StringOperation
    {
        public delegate string StringOperationDelegate(string value);

        public static string Upper(string value)
        {
            return value.ToUpper();
        }
        //Converts to upper case.
        public static string Reverse(string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        //Returns reverse of the string.
        public static string AddPrefix(string value)
        {
            return string.Concat("Miss. ",value);
        }
        //Adds a prefix to the string.
    }
}
