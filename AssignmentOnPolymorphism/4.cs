using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public abstract class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Choose your payment method");
        }
    }
    public class CreditCardPayment:Payment
    {
        public override void ProcessPayment() //overriding method
        {
            Console.WriteLine("Credit card payment method");
        }
    }
    public class PayPalPayment:Payment
    {
        public override void ProcessPayment() //overriding method
        {
            Console.WriteLine("\nPay pal payment method");
        }
    }
}
