using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CsharpAssignmentsPart7.Delegates;
using static CsharpAssignmentsPart7.StringOperation;

namespace CsharpAssignmentsPart7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////Assignment 1. Anonymous Types
            ////Question: Create an anonymous type to represent a book with properties for Title, Author, and Price.
            ////Display the details of the book.

            //var book = new { Title = "The Da Vinci Code", Author = "Dan Brown", Price = 200 };
            //Console.WriteLine("Anonymous book details:");
            //Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price = Rs.{book.Price}");
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 2. Var and Dynamic
            ////Question:
            ////1.Declare a var variable to hold a list of integers, add some numbers to it, and print them.
            ////2.Declare a dynamic variable, assign different types of values to it, and observe the behavior.

            //var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            ////List with var keyword.
            //numbers.Add(6);
            ////Adding one more value to the list.
            //Console.WriteLine("Values in list with var keyword:");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            ////Printing values in list.
            //dynamic dynamicVariable = 5;
            ////Dynamic variable assigned to an integer.
            //Console.WriteLine("\nValue in dynamic variable: " + dynamicVariable);
            //dynamicVariable = "A string";
            ////Same dynamic variable assigned to a string.
            //Console.WriteLine("Value in dynamic variable: " + dynamicVariable);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 3. Delegates
            ////Question:
            ////Create a simple calculator using delegates.Define a delegate OperationDelegate that can
            ////represent different arithmetic operations(addition, subtraction, multiplication, division).
            ////Implement methods for each operation and allow the user to select an operation to perform on two input numbers.

            //Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division.");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter two numbers.");
            //int firstNumber= Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        OperationDelegate firstOperation = new OperationDelegate(Delegates.Addition);
            //        firstOperation(firstNumber, secondNumber);
            //        break;
            //    case 2:
            //        OperationDelegate secondOperation = new OperationDelegate(Delegates.Subtraction);
            //        secondOperation(firstNumber, secondNumber);
            //        break;
            //    case 3:
            //        OperationDelegate thirdOperation = new OperationDelegate(Delegates.Multiplicaation);
            //        thirdOperation(firstNumber, secondNumber);
            //        break;
            //    case 4:
            //        OperationDelegate fourthOperation = new OperationDelegate(Delegates.Division);
            //        fourthOperation(firstNumber, secondNumber);
            //        break;
            //}
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 4. Events
            ////Question:
            ////Create an event called OnCompleted in a class Process. Raise the event when a process is
            ////completed.Subscribe to the event from the main program to display a message.

            //Console.WriteLine("Enter a value for the counter.");
            //int counter = Convert.ToInt32(Console.ReadLine());
            //Process process = new Process();
            //process.OnCompleted += Process_OnCompleted;
            //process.DisplayCounter(counter);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 5. Anonymous Methods
            ////Question:
            ////Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to
            ////the delegate that prints a greeting message.

            //Greet greetClass = new Greet();
            ////Object of Greet class.
            //greetClass.greet("Hello, user");
            ////Calling anonymous method.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 6. Lambda Expressions
            ////Question:
            ////Write a lambda expression that takes two integers and returns their product. Use Func<int, int,
            ////int> for the delegate type.

            //Console.WriteLine("Enter two numbers.");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //Func<int,int,int> multiply = (x,y)=> x*y;
            //Console.WriteLine("Product is: "+multiply(firstNumber, secondNumber));
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 7. Expression Tree
            ////Question:
            ////Create an expression tree for a lambda expression that adds two integers.Compile and execute the expression.

            //Expression <Func<int,int,int>> expression=(a,b) => a + b;
            ////Expression tree.
            //Console.WriteLine(expression);
            ////Outputs the expression.

            //var compiledExpression = expression.Compile();
            ////Compiles the expression.
            //Console.WriteLine("Result: " +compiledExpression(2,4));
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 8. Using Delegates to Hold Methods with the Same Signature
            ////Question:
            ////Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
            ////string. Write three different methods that modify the string in different ways(e.g., convert to
            ////uppercase, reverse, add a prefix). Use the delegate to call each method.

            //StringOperationDelegate stringOperation = new StringOperationDelegate(Upper);
            //string result1 = stringOperation("Aleesha");
            //Console.WriteLine("In upper case: "+result1);
            //stringOperation += Reverse;
            //string result2 = stringOperation("Aleesha");
            //Console.WriteLine("Reversed string: "+result2); 
            //stringOperation += AddPrefix;
            //string result3 = stringOperation("Aleesha");
            //Console.WriteLine("String after prefixing: "+result3);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 9.Lambda Expressions to Filter and Process Lists
            ////Question:
            ////Given a list of products with properties Name and Price, use lambda expressions to:
            ////1.Filter the list to find products that cost more than $50.
            ////2.Sort the list by price in descending order.
            ////3.Select and display only the names of products from the filtered list.

            List<Products> products = new List<Products>();

            Products products1 = new Products() { Name = "Laptop", Price = 50000 };
            Products products2 = new Products() { Name = "Mouse", Price = 100 };
            Products products3 = new Products() { Name = "Pen", Price = 10 };
            products.Add(products1);
            products.Add(products2);
            products.Add(products3);

            var filtered = products.Where(x => x.Price > 50);
            var ordered = filtered.OrderByDescending(x => x.Price);






        }

        private static void Process_OnCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Counter complete");
        }
    }
}
