//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CsharpAssignments
//{
//    public class BankAccount
//    {
//        public long AccountNumber;
//        public string AccountHolderName;
//        private float balance;

//        public float Balance
//        {
//            get { return balance; }
//            set
//            {
//                if(value<0)
//                {
//                    throw new ArgumentException("Balance cannot be negative");
//                }
//                balance = value;
//            }
//        }

//        public BankAccount(long accountnumber, string accountholdername)
//        {
//            AccountNumber = accountnumber;
//            AccountHolderName = accountholdername;
//            Balance = 0;
//        }
//        public void Deposit(float amount)
//        {
//            if (amount > 0)
//            {
//                Balance = Balance + amount;
//                Console.WriteLine("Successfully deposited Rs. " + amount);
//            }
//            else
//            {
//                Console.WriteLine("Deposited amount must be positive");
//            }
//        }
//        public void Withdraw(float withdrawamount)
//        {
//            if(withdrawamount>0&&withdrawamount<=Balance)
//            {
//                Balance=Balance-withdrawamount;
//                Console.WriteLine("Withdrawed Rs. "+withdrawamount);
//            }
//            else
//            {
//                Console.WriteLine("Cannot be withdrawn");
//            }
//        }
//        public void BalanceCheck()
//        {
//            Console.WriteLine("New balance is: " + Balance);
//        }
//    }
//}
