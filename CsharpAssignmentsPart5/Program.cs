using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpAssignmentsPart5
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1. Identify the need for single and multidimensional arrays as properties of a class
            ////Question : Create a Library class to store and manage books in a single-dimensional array where
            ////each element represents a book title.Also, use a two-dimensional array in a Classroom class
            ////where each element represents the seat of a student based on rows and columns.

            //Library library = new Library(new string[] { "Peter Pan", "Alice in Wonderland", "The Da Vinci Code", 
            //                                           "The Twilight Saga", "Harry Potter" });
            ////Single dimensional array initialized.
            //library.Display();
            //Classroom classroom = new Classroom(new string[,] { { "Seat 1", "Seat2" }, { "Seat 3", "Seat 4" } });
            ////Multi - dimensional array initialized.
            //classroom.Display();
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 2. Identify the need for an array of objects
            ////Question: Define a Movie class with properties like Title and Year. Create a MovieLibrary class
            //// that stores an array of Movie objects and displays each movie’s information.

            //Movie firstMovie = new Movie("RRR", 2022);
            //Movie secondMovie = new Movie("2018", 2023);
            //Movie thirdMovie = new Movie("Virus", 2019);
            //Movie fourthMovie = new Movie("Tangled", 2010);
            //Movie fifthMovie = new Movie("Exodus: Gods and Kings", 2014);

            //MovieLibrary library = new MovieLibrary();
            //library.AddMovie(firstMovie, 0);
            //library.AddMovie(secondMovie, 1);
            //library.AddMovie(thirdMovie, 2);
            //library.AddMovie(fourthMovie, 3);
            //library.AddMovie(fifthMovie, 4);
            //library.Display();
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 3. Identify the need for enumerations
            ////Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
            ////Define an Order class with an OrderStatus property to manage the status of each order.

            //Order firstOrder = new Order(1, OrderStatus.Pending);
            //Order secondOrder = new Order(2, OrderStatus.Delivered);
            //Order thirdOrder = new Order(3, OrderStatus.Shipped);

            //Order.DisplayStatus(firstOrder);
            //Order.DisplayStatus(secondOrder);
            //Order.DisplayStatus(thirdOrder);
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 4. Identify the need for value types and reference types
            ////Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
            ////represent a reference type.Show how changing values affects each.

            //Circle firstCircle = new Circle(5);
            //Circle secondCircle = firstCircle;
            ////Sending a copy of the value in first circle.
            //Console.WriteLine("Radius of circles before modifying:");
            //Console.WriteLine("Radius of first circle: "+firstCircle.Radius);
            //Console.WriteLine("Radius of second circle: "+secondCircle.Radius);
            //secondCircle.Radius = 10;
            ////Modifying the value in second circle.
            //Console.WriteLine("\nRadius of circles after modifying:");
            //Console.WriteLine("Radius of first circle: " + firstCircle.Radius);
            //Console.WriteLine("Radius of second circle: " + secondCircle.Radius);

            //Shape firstShape = new Shape(0);
            //Shape secondShape = firstShape;
            ////Referencing the object firstShape.
            //Console.WriteLine("\nNumber of sides before modifying:");
            //Console.WriteLine("Number of sides of first shape: " + firstShape.NoOfSides);
            //Console.WriteLine("Number of sides of second shape: " + secondShape.NoOfSides);
            //secondShape.NoOfSides = 5;
            ////Modifying the value in second shape.
            //Console.WriteLine("\nNumber of sides after modifying:");
            //Console.WriteLine("Number of sides of first shape: " + firstShape.NoOfSides);
            //Console.WriteLine("Number of sides of second shape: " + secondShape.NoOfSides);
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 5. Identify the need for pass by reference using ref keyword
            ////Question: Create a method IncreaseScore that takes a ref integer parameter representing a
            ////player’s score and increases it by 10.

            //int PlayerScore = 8;
            //Console.WriteLine("Score at the beginning: "+PlayerScore);
            //Score.IncreaseScore(ref PlayerScore);
            //Console.WriteLine("Current score: "+PlayerScore);
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 6. Identify the need for out parameters
            ////Question: Create a method Divide that takes two integers, calculates their quotient and
            ////remainder, and returns both values using the out keyword.

            //int firstNumber=10;
            //int secondNumber=5;
            //int quotient;
            //int remainder;
            //Calculation.Divide(firstNumber, secondNumber, out quotient, out remainder);
            ////Now variable quotient has quotient and variable remainder has remainder.
            //Console.WriteLine("Quotient: " + quotient + ", Remainder: " + remainder);
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 7. What is Exception and its Types
            ////Question: Write a C# program that demonstrates a FileNotFoundException and an IndexOutOfRangeException.
            ////Explain what causes these exceptions.

            //try
            //{
            //    StreamReader streamReader = new StreamReader("nonexistingfile.txt");
            //    Console.WriteLine(streamReader.ReadToEnd());
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("FileNotFoundException caught: "+ex.Message);
            //}
            //try
            //{
            //    int[] numbers = { 1, 2, 3, 6, 12 };
            //    Console.WriteLine(numbers[8]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
            //}
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            ////Assignment 8. How to Handle Exception
            ////Question: Create a method GetUserInput that prompts the user to enter an integer.
            ////If the input is invalid, catch the exception and prompt the user again until they enter a valid integer.

            //ExceptionClass exceptionClass = new ExceptionClass();
            //int validNumber = exceptionClass.GetUserInput();
            //Console.WriteLine("Valid number entered is: "+validNumber);
            //Console.ReadLine();
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//








        }
    }
}
