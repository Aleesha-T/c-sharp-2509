using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class BankNew
    {
        List<Customer>customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        //add to customers list
        public void AddAccount(Customer customer, Customer.Account account)
        {
            customer.accounts.Add(account);
        }
        //add to accounts list
        public void DisplayCustomerDetails(Customer customer)
        {
            Console.WriteLine($"Customer Name: {customer.Name} ");
            foreach(var account in customer.accounts)
            {
                Console.Write($"Account Number: {account.AccountNumber}, ");
                Console.WriteLine($"Balance: Rs.{account.Balance}");
            }
        }
        //display customer details
        public class Customer
        {
            public string Name; 
            public Customer(string name)
            {
                this.Name = name;
            }
            public List <Account> accounts = new List<Account> ();
            public class Account
            {
                private long accountNumber;
                private double balance;
                public long AccountNumber
                {
                    get { return accountNumber; }
                    set { accountNumber = value; }
                }
                public double Balance
                {
                    get { return balance; }
                    set
                    {
                        if (value < 0)
                        {
                            throw new ArgumentException("Balance cannot be negative");
                        }
                        balance = value;
                    }
                }
                public Account(long accountnumber, double account_balance)
                {
                    AccountNumber = accountnumber;
                    Balance = account_balance;
                }
            }
        }

    }
}
