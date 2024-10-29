using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnPolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1: To demonstrate Polymorphism and its Advantages
            ////Create a C# program demonstrating polymorphism by using a base class Shape and derived classes Circle and Rectangle. 
            ////Each derived class should implement a method Draw(). 
            ////Show how polymorphism helps in calling the correct method based on the object type.

            //Circle circle = new Circle();
            //circle.Draw(); //calling method Draw from Circle class
            //Console.WriteLine();
            //Rectangle rectangle = new Rectangle(); 
            //rectangle.Draw(); //calling method Draw from Rectangle class
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 2. Method Overloading and its uses
            ////Create a C# program to show method overloading by implementing a Multiply method with different parameter types, numbers and order.

            //MethodOverloading methodOverloading = new MethodOverloading();
            //methodOverloading.Multiply(1, 2); //two integers
            //methodOverloading.Multiply(1, 2, 3); //three integers
            //methodOverloading.Multiply(2.00, 4.00); //two double
            //methodOverloading.Multiply(1, 5.00); //one integer, one double
            //methodOverloading.Multiply(6.00, 2); //one double, one integer
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 3. Method Overriding  
            ////Write a program demonstrating method overriding by creating a base class Vehicle and a derived class Car that overrides the Drive() method.

            //Car car = new Car();
            //car.Drive();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 4. Scenario of Overriding 
            ////Consider a scenario of payment processing where different payment methods (e.g., CreditCardPayment, PayPalPayment) override the ProcessPayment() method of a base class Payment. 
            ////Write a C# program to demonstrate this scenario.

            //CreditCardPayment creditCardPayment = new CreditCardPayment();
            //creditCardPayment.ProcessPayment(); //calling overridden method
            //PayPalPayment payPalPayment = new PayPalPayment();
            //payPalPayment.ProcessPayment(); //calling overridden method
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 5.Polymorphism with Static Data and Methods.
            ////Create a C# program that demonstrates polymorphism using a base class Employee and derived classes Manager and Developer. 
            ////Include a static field to keep track of the total number of employees and a static method to display the total count.
            ////Use method overriding to demonstrate polymorphism, while also explaining the need for static members in this context.

            //Manager manager = new Manager("Deepa");
            //Developer developer = new Developer("Mekha");
            //manager.EmployeeDetail();
            //developer.EmployeeDetail();
            //Employee.DisplayNumber();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 6. Polymorphism with Arrays as Properties in a Class 
            ////Create a C# program demonstrating polymorphism using a base class Employee and derived classes Manager and Developer. 
            ////In this program, each employee should have a collection of tasks(stored in an array) assigned to them.
            ////Use arrays as properties in the class to handle this data, and demonstrate how polymorphism and arrays work together in the solution.

            //ManagerNew manager = new ManagerNew(new string[] {"Task1", "Task2"});
            //DeveloperNew developer = new DeveloperNew(new string[] {"DTask1", "DTask2"});
            //manager.Display();
            //Console.WriteLine();
            //developer.Display();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 7: Understanding Early Binding and Late Binding in C#
            ////Create a C# program that demonstrates early binding (compile-time polymorphism) using method overloading and late binding(runtime polymorphism) using method overriding. 
            ////This will help illustrate the differences between the two concepts in the context of polymorphism. 

            //Calculation calculation = new Calculation();
            //calculation.Add(1, 2);
            //calculation.Add(2, 3, 5);
            ////method overloading
            //Calculator calculator = new Calculator();
            //calculator.Subtract(1, 2);
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and Interfaces in C# 
            ////Create a C# program that demonstrates how runtime polymorphism is achieved using abstract classes and interfaces.
            ////Define an abstract class Shape and an interface IShape, implementing these in derived classes to showcase polymorphism.

            //Hexagon hexagon = new Hexagon();
            //hexagon.Draw();
            //Pentagon pentagon = new Pentagon();
            //pentagon.DrawShape();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces 
            ////Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
            ////The program will define two interfaces, IMovable and IDrawable, and implement them in a class Car that showcases how a class can inherit from multiple interfaces.

            //CarNew car = new CarNew();
            //car.Move();
            //car.Draw();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//

            ////Assignment 10. Polymorphism in C# with Readonly Property
            ////Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
            //// The program will define two interfaces, IMovable and IDrawable, and implement them in a class Car that showcases how a class can inherit from multiple interfaces.
        
            //Laptop laptop = new Laptop();
            //laptop.LaptopCount();
            //Lenovo lenovo = new Lenovo();
            //lenovo.LaptopCount();
            //Console.ReadLine();

            //-------------------------------------------------------------------------//






        }
    }
}
