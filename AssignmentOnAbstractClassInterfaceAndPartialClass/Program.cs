using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnAbstractClassInterfaceAndPartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1. Abstract Class
            ////Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method StopEngine().
            ////Create derived classes Car and Motorcycle that implement the StartEngine() method and override it to show specific behavior for each type of vehicle.

            //Car car = new Car();
            //car.StartEngine(); //from car class
            //car.StopEngine(); //from abstract class Vehicle
            //Console.WriteLine();
            //MotorCycle motorCycle = new MotorCycle();
            //motorCycle.StartEngine(); //from motorcycle class
            //motorCycle.StopEngine(); //from abstract class Vehicle
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 2. Virtual Functions
            ////Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that override the MakeSound() method to provide their specific implementation.


            //Animal animal = new Animal();
            //animal.MakeSound(); //calling virtual method
            //Dog dog = new Dog();
            //dog.MakeSound(); //calling overridden method
            //Cat cat = new Cat();
            //cat.MakeSound(); //calling overridden method
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 3. Interface
            ////Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck class, with each class having its own implementation of Drive().


            //CarNew car = new CarNew();
            //car.Drive();
            //Truck truck = new Truck();
            //truck.Drive();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 4. Interface vs. Abstract Class
            ////Write a program that demonstrates the difference between an abstract class and an interface by creating an abstract class Bird with an abstract method Fly(), 
            ////and an interface ISwim with a method Swim(). 

            //Martin martin = new Martin();
            //martin.Fly(); //method from abstract class
            //Dolphin dolphin = new Dolphin();
            //dolphin.Swim(); //method from interface
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 5. Static Class
            ////Create a static class MathOperations with a static method Add() and Multiply().
            ////Demonstrate calling these methods without creating an instance of the class.

            //MathOperations.Add(5, 8);
            //MathOperations.Multiply(8, 40);
            ////Static methods are for the class itself.
            ////It is not related to an instance, and hence can be called directly (without an object).
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 6. Extension Methods
            ////Create an extension method IsEven() for the int type that returns true if the number is even and false if it is odd.

            //int number = 5;
            //bool myBool = number.IsEven();
            //Console.WriteLine(myBool);

            //int secondnumber = 8;
            //bool myNewBool = secondnumber.IsEven();
            //Console.WriteLine(myNewBool);
            //Console.ReadLine(); 

            //-------------------------------------------------------------------------------//

            ////Assignment 7. Partial Class
            ////Create a partial class Person that is defined in two files.
            ////One file should have the property Name, and the other file should have the method ShowDetails().

            //Person person = new Person("Aleesha", 21);
            //person.ShowDetails();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 9. Indexer
            ////Create a Library class that contains an array of Book objects.
            ////Implement an indexer that allows accessing the books by index.Write a method to display all the books in the library. 

            //Book firstbook = new Book("Harry Potter", "J K Rowling");
            //Book secondbook = new Book("Twilight", "Stephenie Meyer");
            //Book thirdbook = new Book("Alice in Wonderland", "Lewis Carroll");
            //Book fourthbook = new Book("Peter Pan", "J M Barrie");
            //Library library = new Library();
            //library[0]=firstbook; //assigning first book to index 0
            //library[1]=secondbook; //assigning second book to index 1
            //library[2] = thirdbook; //assigning third book to index 2
            //library[3] = fourthbook; //assigning fourth book to index 3
            //library.DisplayBooks(library); //display all the books
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 10. Exception Handling
            ////Write a method Divide that takes two integers as input and returns their division.
            ////If a division by zero occurs, catch the exception and display a custom error message.
            ////Demonstrate exception handling with a try-catch-finally block.

            //try
            //{
            //    Calculation calculation = new Calculation();
            //    int quotient = calculation.Divide(10, 10);
            //    Console.WriteLine("Quotient is: " + quotient);
            //    int newQuotient = calculation.Divide(4, 0);
            //    Console.WriteLine("Quotient is: " + newQuotient);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Code executed");
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 11. Enum
            ////Create an enum CarType with values Sedan, SUV, Truck, and Coupe.
            ////Write a Car class with a property Type of type CarType.
            ////Write a method that takes a CarType value and displays a message specific to that type of car. 

            //NewCar car = new NewCar();
            //car.Display(CarType.Truck); //calling function Display by giving an enum value
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//

            ////Assignment 12. Attributes
            ////Define a custom attribute DeveloperAttribute that takes the name of the developer and the date when the code was last modified.
            ////Apply this attribute to a class Calculator and its method Add. Retrieve and display the attribute information at runtime.

            ////Retrieving class attribute
            //Type type = typeof(Calculator);
            //object[] classAttributes= type.GetCustomAttributes(false);
            //foreach (DeveloperAttribute attribute in classAttributes)
            //{
            //    Console.WriteLine($"Class Developer Name: {attribute.Name}, Last Modified Date: {attribute.LastModifiedDate}");
            //}

            ////Retrieving method attribute
            //var methodDetail = type.GetMethod("Add");
            //object[] methodAttributes = methodDetail.GetCustomAttributes(false);
            //foreach(DeveloperAttribute attribute in methodAttributes)
            //{
            //    Console.WriteLine($"Method Developer Name: {attribute.Name}, Last Modified Date: {attribute.LastModifiedDate}");
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------//
        }
    }
}
