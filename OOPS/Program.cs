using System;
using System.Collections.Generic;
using System.Linq;
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

            //-----------------------------------------------------------------------------------------------//
            //int result;
            //Employee employee1 = new Employee();
            //result = employee1.Add();
            //Console.WriteLine(result);

            //Employee employee2 = new Employee();
            //result = employee2.Add();
            //Console.WriteLine(result);

            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------//

            //Tour tour = new Tour();
            //Console.WriteLine("Tour cost would be: Rs." + tour.TourCost());
            //TourPlace place = new TourPlace();
            //Console.WriteLine("Places in Mysore will be: " + place.Mysore());
            //Console.WriteLine("No. of days: " + place.TourDays());
            //Console.WriteLine("Bus will be: " + place.TourBus());
            //Console.WriteLine();
            //Console.ReadLine();

            //Single inheritance
            //-----------------------------------------------------------------------------------------------//

            //Stay stay = new Stay();
            //Console.WriteLine("Places in Banglore will be: " + stay.Bangalore());
            //Console.WriteLine("No. of days will be: " + stay.TourDays());
            //Console.WriteLine("Resort will be: " + stay.Resort());
            //Console.ReadLine();

            //Multi-level inheritance
            //-----------------------------------------------------------------------------------------------//

            //Polymorphism poly = new Polymorphism();
            //Console.WriteLine(poly.Display("Aleesha"));
            //Console.WriteLine(poly.Display("Aleesha", "Thomas"));
            //Console.WriteLine(poly.Display("Alwin", "K", "Thomas"));
            //Console.ReadLine();

            //Method overloading
            //-----------------------------------------------------------------------------------------------//

            //Reverse reverse1 = new Reverse(10, 20);
            //reverse1 = +reverse1;
            //reverse1.Display();
            //Console.ReadLine();

            //Operator overloading
            //-----------------------------------------------------------------------------------------------//

            //EmployeeNew employee1 = new EmployeeNew("Aleesha", "IT");
            //EmployeeNew employee2 = new EmployeeNew("Alwin", "IT");
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //employeeDetails.AddEmployee(employee1);
            //employeeDetails.AddEmployee(employee2);
            //employeeDetails.ShowDetails();
            //Console.ReadLine();

            //List
            //-----------------------------------------------------------------------------------------------//

            //Class1 class1 = new Class1();

            //-----------------------------------------------------------------------------------------------//

            PersonalDetails details = new PersonalDetails("Aleesha", 21);
            details.Display();
            details.DisplayAll();
            Console.ReadLine();




        }
    }
}
