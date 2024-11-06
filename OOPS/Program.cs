using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee("Aleesha ", 21, " IT");
            //Employee employee2 = new Employee("Alwin ", 30, " IT");

            //Console.Write(employee1.Name);
            //Console.Write(employee1.age);
            //Console.WriteLine(employee1.department);

            //Console.Write(employee2.Name);
            //Console.Write(employee2.age);
            //Console.WriteLine(employee2.department);

            //Console.ReadLine();

            //get and set properties.
            //-----------------------------------------------------------------------------------------------//
            //int result;
            //Employee employee1 = new Employee();
            //result = employee1.Add();
            //Console.WriteLine(result);

            //Employee employee2 = new Employee();
            //result = employee2.Add();
            //Console.WriteLine(result);

            //Console.ReadLine();

            //Static variable.
            //-----------------------------------------------------------------------------------------------//

            //Tour tour = new Tour();
            //Console.WriteLine("Tour cost would be: Rs." + tour.TourCost());
            //TourPlace place = new TourPlace();
            //Console.WriteLine("Places in Mysore will be: " + place.Mysore());
            //Console.WriteLine("No. of days: " + place.TourDays());
            //Console.WriteLine("Bus will be: " + place.TourBus());
            //Console.WriteLine();
            //Console.ReadLine();

            //Single inheritance.
            //-----------------------------------------------------------------------------------------------//

            //Stay stay = new Stay();
            //Console.WriteLine("Places in Banglore will be: " + stay.Bangalore());
            //Console.WriteLine("No. of days will be: " + stay.TourDays());
            //Console.WriteLine("Resort will be: " + stay.Resort());
            //Console.ReadLine();

            //Multi-level inheritance.
            //-----------------------------------------------------------------------------------------------//

            //Polymorphism poly = new Polymorphism();
            //Console.WriteLine(poly.Display("Aleesha"));
            //Console.WriteLine(poly.Display("Aleesha", "Thomas"));
            //Console.WriteLine(poly.Display("Alwin", "K", "Thomas"));
            //Console.ReadLine();

            //Method overloading.
            //-----------------------------------------------------------------------------------------------//

            //Reverse reverse1 = new Reverse(10, 20);
            //reverse1 = +reverse1;
            //reverse1.Display();
            //Console.ReadLine();

            //Operator overloading.
            //-----------------------------------------------------------------------------------------------//

            //EmployeeNew employee1 = new EmployeeNew("Aleesha", "IT");
            //EmployeeNew employee2 = new EmployeeNew("Alwin", "IT");
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //employeeDetails.AddEmployee(employee1);
            //employeeDetails.AddEmployee(employee2);
            //employeeDetails.ShowDetails();
            //Console.ReadLine();

            //List.
            //-----------------------------------------------------------------------------------------------//

            //PersonalDetails details = new PersonalDetails("Aleesha", 21);
            //details.Display();
            //details.DisplayAll();
            //Console.ReadLine();

            //Extension of a class.
            //-----------------------------------------------------------------------------------------------//

            //string myString = "Aleesha";
            //Console.WriteLine("Value before calling function: "+myString);
            //RefKeyword.ChangeStringValue(ref myString);
            //Console.WriteLine("Value after calling function: " + myString);
            //Console.ReadLine();

            //Use of ref keyword.
            //-----------------------------------------------------------------------------------------------//

            //Details details = new Details();
            //details.Name = "Aleesha";
            //details.Age = 21;
            //Console.WriteLine($"Before calling function, Name: {details.Name}, Age: {details.Age}");
            //details.ChangeValue(details);
            //Console.WriteLine($"After calling function, Name: {details.Name}, Age: {details.Age}");
            //Console.ReadLine();

            //When to use ref keyword.
            //-----------------------------------------------------------------------------------------------//

            //Indexer indexer = new Indexer();
            //indexer[0] = 2;
            //indexer[1] = 4;
            //indexer[2] = 6;
            //indexer[3] = 8;
            //indexer[4] = 10;

            //Console.WriteLine($"{indexer[0]}, {indexer[1]}");
            //Console.ReadLine();

            //Indexer.
            //-----------------------------------------------------------------------------------------------//

            //string detail=string.Empty;
            //Out.Display(out string info);
            //Out.Display(detail);
            //Console.WriteLine($"Value outside function (with out): {info}");
            //Console.WriteLine($"Value outside function (without out): {detail}");
            //Console.ReadLine();

            //Using of out keyword.
            //-----------------------------------------------------------------------------------------------//

            //ObsoleteClass.Method();
            //Console.ReadLine();

            //Obsolete. 
            //-----------------------------------------------------------------------------------------------//

            //try
            //{
            //    ExceptionClass exception = new ExceptionClass();
            //    exception.Divide(10, 2);
            //    exception.Divide(10, 0);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Parent exception block executed");
            //}
            ////Parent.
            //finally
            //{
            //    Console.WriteLine("Code executed");
            //}
            //Console.ReadLine();

            //Exception.
            //-----------------------------------------------------------------------------------------------//

            //try
            //{
            //    int firstResult = ExceptionClass.Division(40, 5);
            //    Console.WriteLine(firstResult);
            //    int secondResult = ExceptionClass.Division(40, 0);
            //    Console.WriteLine(secondResult);
            //}
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //    Console.WriteLine("Code executed");
            //}
            //Console.ReadLine();

            //User Defined Exception.
            //-----------------------------------------------------------------------------------------------//

            //int[,] TwoDimensionalArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
            //    {
            //        Console.Write($"{TwoDimensionalArray[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Two Dimensional Array.
            //-----------------------------------------------------------------------------------------------//

            //    int[] Array = { 13, 10, 11, 7, 8, 45, 59, 36, 29, 18, 15 };
            //Label: for (int i = 0; i < Array.Length - 1; i++)
            //    {
            //        if (Array[i] > Array[i + 1])
            //        {
            //            int temp = Array[i];
            //            Array[i] = Array[i + 1];
            //            Array[i + 1] = temp;
            //        }
            //    }
            //    for (int i = 0; i < Array.Length - 1; i++)
            //    {
            //        if (Array[i] > Array[i + 1])
            //        {
            //            goto Label;
            //        }
            //    }
            //    for (int j = 0; j < Array.Length; j++)
            //    {
            //        Console.Write($"{Array[j]} ");
            //    }
            //    Console.ReadLine();

            //Sorting Array without using in-built function.
            //-----------------------------------------------------------------------------------------------//

            //int[] myArray = { 1,45, 2,6, 4, 8,92};
            //int largest=myArray[0];
            //int secondLargest =myArray[1];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > largest)
            //    {
            //        int temp = largest;
            //        largest = myArray[i];
            //        secondLargest = temp;
            //    }
            //}
            //Console.WriteLine(largest);
            //Console.WriteLine(secondLargest);
            //Console.ReadLine();

            //To find second largest number.
            //-----------------------------------------------------------------------------------------------//

            //var anonymousItem = new { itemNo = 1, itemName = "Pen", itemPrice = 10.0f };
            //Console.WriteLine($"Sl. No.: {anonymousItem.itemNo}, Name: {anonymousItem.itemName}, Price: {anonymousItem.itemPrice}");
            //Anonymous.Display(anonymousItem);
            //Console.ReadLine();

            //Anonymous object, use of dynamic and var keywords.
            //-----------------------------------------------------------------------------------------------//

            //DelegateClass.calculate area = new DelegateClass.calculate(DelegateClass.Area);
            //area(5);
            //Console.ReadLine();

            //Delegate
            //-----------------------------------------------------------------------------------------------//

            //DelegateClass.calculate area1 = new DelegateClass.calculate(DelegateClass.Area);
            //area1 += DelegateClass.Perimeter;
            //area1(3);
            //Console.ReadLine();

            //Multicasting Delegate.
            //-----------------------------------------------------------------------------------------------//

            //EventHandlerClass eventHandlerClass = new EventHandlerClass();
            //eventHandlerClass.DetectName += EventHandlerClass.EventHandlerClass_DetectName;
            //Console.WriteLine("Enter a name");
            //int value = 0;
            //while (value < 5)
            //{
            //    var Name = Console.ReadLine();
            //    eventHandlerClass.NameHandler(Name);
            //    value++;
            //}
            //Console.ReadLine();

            //EventHandler.
            //-----------------------------------------------------------------------------------------------//   

            //Async.firstMethod();
            //Async.secondMethod();
            //Console.ReadLine();

            //Asynchronous method.
            //-----------------------------------------------------------------------------------------------//   

            //Async.Call();
            //Console.ReadLine();

            //Second method runs only after the completion of first method.
            //-----------------------------------------------------------------------------------------------//   

            //EmployeeClass[] employee =
            //{
            //    new EmployeeClass() {ID=1, Name = "Aleesha", Age=21 },
            //    new EmployeeClass() {ID=2,Name="Sreelakshmi", Age=22 },
            //    new EmployeeClass() {ID=3, Name = "Arya", Age=22 },
            //    new EmployeeClass() {ID=4,Name = "Ganesh", Age=26 },
            //    new EmployeeClass() {ID=5,Name="Rithin",Age=22 },
            //};
            //var employeeNew = employee.Where(x => x.ID == 4);

            //Console.ReadLine();

            //LINQ Query.
            //-----------------------------------------------------------------------------------------------//   
        }
    }
}
