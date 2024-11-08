using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CsharpAssignmentsPart7.Calculation;
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
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
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
            //Func<int, int, int> multiply = (x, y) => x * y;
            //Console.WriteLine("Product is: " + multiply(firstNumber, secondNumber));
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 7. Expression Tree
            ////Question:
            ////Create an expression tree for a lambda expression that adds two integers.Compile and execute the expression.

            //Expression<Func<int, int, int>> expression = (a, b) => a + b;
            ////Expression tree.
            //Console.WriteLine(expression);
            ////Outputs the expression.

            //var compiledExpression = expression.Compile();
            ////Compiles the expression.
            //Console.WriteLine("Result: " + compiledExpression(2, 4));
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 8. Using Delegates to Hold Methods with the Same Signature
            ////Question:
            ////Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
            ////string. Write three different methods that modify the string in different ways(e.g., convert to
            ////uppercase, reverse, add a prefix). Use the delegate to call each method.

            //StringOperationDelegate stringOperation = new StringOperationDelegate(Upper);
            //string result1 = stringOperation("Aleesha");
            //Console.WriteLine("In upper case: " + result1);
            //stringOperation += Reverse;
            //string result2 = stringOperation("Aleesha");
            //Console.WriteLine("Reversed string: " + result2);
            //stringOperation += AddPrefix;
            //string result3 = stringOperation("Aleesha");
            //Console.WriteLine("String after prefixing: " + result3);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 9.Lambda Expressions to Filter and Process Lists
            ////Question:
            ////Given a list of products with properties Name and Price, use lambda expressions to:
            ////1.Filter the list to find products that cost more than $50.
            ////2.Sort the list by price in descending order.
            ////3.Select and display only the names of products from the filtered list.

            //List<Products> products = new List<Products>();

            //Products products1 = new Products() { Name = "Laptop", Price = 50000 };
            //Products products2 = new Products() { Name = "Mouse", Price = 100 };
            //Products products3 = new Products() { Name = "Pen", Price = 10 };
            //Products products4 = new Products() { Name = "Speaker", Price = 5000 };
            //products.Add(products1);
            //products.Add(products2);
            //products.Add(products3);
            //products.Add(products4);

            //var filtered = products.Where(x => x.Price > 50);
            ////Filter according to price.
            //var ordered = filtered.OrderByDescending(x => x.Price);
            ////Order according to price.
            //foreach (var item in ordered)
            //{
            //    Console.WriteLine("Name: " + item.Name + ", Price: " + item.Price);
            //}
            ////Display the filtered and ordered.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 10.Delegate as a Callback Mechanism
            ////Question:
            ////Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
            ////Implement methods for addition and subtraction, and write a method Calculate that accepts two
            ////integers and a delegate as parameters.Use the delegate to perform addition and subtraction
            ////operations by passing different methods.

            //CalculationDelegate calculation = null;
            //Calculate(4, 2, calculation);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 11. Introduction to Asynchronous Programming 
            ////Question:
            ////Write a C# program that simulates a long-running operation using Task.Delay() and runs 
            ////asynchronously. Display a message before and after the operation completes.

            //Console.WriteLine("Main method start");
            //Async.AsyncMethod();
            ////Calling async method.
            //Console.WriteLine("Main method end");
            ////This will run even before the completion of async method.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 12. Async and Await Keywords 
            ////Question:
            ////Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
            ////fetch the data and print the length of the content.The method should use async and await keywords.

            //try
            //{
            //    string url = "https://www.w3schools.com/"; /*"www.example.com";*/
            //    Download.Call(url);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 13. Task and Task<T> 
            ////Question:
            ////Write a C# program that calculates the sum of an array of integers asynchronously using 
            ////Task<int>.Return the result from the asynchronous method and display it.

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //TaskClass.Call(numbers);
            //Console.WriteLine("Task running");
            ////Even if this is after calling the function, this gets executed first.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 14. Handling Exceptions in Asynchronous Methods 
            ////Question:
            ////Modify the previous example to handle exceptions that might occur during the sum calculation. 
            ////Catch the exception in the Main method and display an error message. 

            //try
            //{
            //    int[] numbers = { 1, 2, 3, 4, 5 };
            //    TaskClass.Call(numbers);
            //    Console.WriteLine("Task running");
            //    //Even if this is after calling the function, this gets executed first.
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An error has occured.");
            //}
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 15. Parallel Programming with Task Parallel Library (TPL) 
            ////Question:
            ////Create a program that runs multiple tasks in parallel to simulate multiple operations, such as
            ////calculating the factorial of different numbers.Print the result of each task when completed.

            //int[] numbers = { 5, 12, 3 };
            //Parallel.ForEach(numbers, number =>
            //{
            //    long result = ParallelClass.Factorial(number);
            //    Console.WriteLine("Factorial of " + number + " is " + result);
            //});
            //Console.WriteLine("Complete.");
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 16. LINQ Query Syntax and Method Syntax 
            ////Question: Write a LINQ query using both query syntax and method syntax to retrieve all
            ////numbers greater than 5 from a list of integers.

            //List<int> numbers = new List<int> { 3, 5, 1, 4, 6, 8, 10, 32, 41, 3, 6 };
            ////List of integers.
            //var results = from number in numbers where number > 5 select number;
            ////Query syntax.
            //Console.WriteLine("Numbers greater than 5 are:");
            //foreach (var result in results)
            //{
            //    Console.Write(result + " ");
            //}
            ////Displaying results.
            //var newResults = numbers.Where(x => x > 5);
            ////Method syntax.
            //Console.WriteLine("\nNumbers greater than 5 are:");
            //foreach (var result in newResults)
            //{
            //    Console.Write(result + " ");
            //}
            ////Displaying new results.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 17. LINQ Operators (Select, Where, GroupBy, Join, etc.) 
            ////Question 1: Given a list of strings representing student names, write a LINQ query that selects
            ////the names starting with the letter 'A' and orders them alphabetically.

            //List<string> studentNames = new List<string> { "Aleesha", "Ameya", "Riya", "Aisha", "Becca", "Julie" };
            ////List of names.
            //var names = studentNames.Where(x => x[0] == 'A').OrderBy(x => x);
            ////Selects names starting with A and orders them alphabetically.
            //Console.WriteLine("Filtered and ordered list:");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 18. LINQ to Objects 
            ////Question: Write a LINQ query to find the sum of all even numbers in an array of integers.

            //int[] numbers = { 1, 2, 4, 8, 3, 6 };
            //var sumOfEven = numbers.Where(num => num % 2 == 0).Sum(x => x);
            //Console.WriteLine("Sum of even numbers is: " + sumOfEven);
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 19. LINQ to XML 
            ////Question: Create an XML document representing a list of books, and use LINQ to XML to
            ////query the titles of books published after 2015.

            //XDocument xmlDocument = XDocument.Load("D:\\c-sharp-2509\\CsharpAssignmentsPart7\\Books.xml");
            //var books = xmlDocument.Descendants("Book")
            //                       .Where(book => (int)book.Element("Year") > 2015)
            //                       .Select(book => book.Element("Title").Value);
            //Console.WriteLine("Books published after 2015:");
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////

            ////Assignment 20. LINQ to SQL 
            ////Question: Given a database table Employees with columns ID, Name, and Department, write a
            ////LINQ to SQL query to select all employees from the "IT" department.

            //var itEmployees = from emp in db.Employees
            //                  where emp.Department == "IT"
            //                  select emp;
            ////Selecting employees in IT Department.
            //foreach (var emp in itEmployees)
            //{
            //    Console.WriteLine($"ID:{emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            //}
            ////Displaying details of IT Employees.
            //Console.ReadLine();

            ////-----------------------------------------------------------------------------------------------////






        }

        private static void Process_OnCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Counter complete");
        }
        //This will be run when the event is invoked.
    }
}
