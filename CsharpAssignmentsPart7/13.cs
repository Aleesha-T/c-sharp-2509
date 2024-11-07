using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart7
{
    public class TaskClass
    {
        public static async Task<int> CalculateSum(int[] array)
        {
            await Task.Delay(1000);
            //Awaits delay.
            return array.Sum();
        }
        public static async void Call(int[] numbers)
        {
            int sum = await CalculateSum(numbers);
            Console.WriteLine("Sum is: "+sum);
        }
        //Calls the CalculateSum method.
    }
}
