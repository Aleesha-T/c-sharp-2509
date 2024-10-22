using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Bank
    {
        public static float interestrate;
        public float balance;
        static Bank()
        {
            interestrate = 1.2f;
        }
        public Bank(float intitialbalance)
        {
            balance = intitialbalance;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Interest Rate: {interestrate}, Balance: {balance}");
        }
    }
}
