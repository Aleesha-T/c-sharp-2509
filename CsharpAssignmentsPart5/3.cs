using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    //Defined enum OrderStatus.
    public class Order
    {
        public OrderStatus Status;
        //Enum property.
        public int ProductID;

        public Order(int productID, OrderStatus orderStatus)
        {
            ProductID = productID;
            Status = orderStatus;
        }
        public static void DisplayStatus(Order order)
        {
            switch (order.Status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Status: Pending");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Status: Shipped");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Status: Delivered");
                    break;
                default:
                    Console.WriteLine("Invalid order");
                    break;
            }
        }
        //Displays order status by getting order object
    }
}
