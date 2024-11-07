using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class Async
    {
        public async static void AsyncMethod()
        {
            Console.WriteLine("Async method start");
            await Task.Delay(3000);
            //Delay.
            Console.WriteLine("Async method end");
        }
        //Async method.
    }
}
