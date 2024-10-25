using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Lab 1. Single Inheritance
            //Student student1 = new Student("Aleesha", 21, 'S');
            //student1.Display();
            //Console.WriteLine();
            //Student student2 = new Student("Arya", 22, 'S');
            //student2.Display();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 2. Multilevel Inheritance
            //Puppy puppy = new Puppy();
            //puppy.Weep();
            //puppy.Bark();
            //puppy.Eat();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 3. Multiple Inheritance (via Interfaces)
            //PrinterScanner printerscanner = new PrinterScanner();
            //printerscanner.Print();
            //printerscanner.Scan();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 4. Hierarchical Inheritance
            //Circle circle = new Circle();
            //circle.Draw();
            //Rectangle rectangle = new Rectangle();
            //rectangle.Draw();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 5. Hybrid Inheritance (Using Interfaces)
            //Vehicle vehicle = new Vehicle();
            //vehicle.Movable();
            //Console.WriteLine();
            //ElectricCar electricCar = new ElectricCar();
            //electricCar.Movable();
            //electricCar.Rechargeable();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 6. Overriding Methods in Inheritance
            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 7. Abstract Classes 
            //Car car = new Car();
            //car.Drive();
            //Bike bike = new Bike();
            //bike.Drive();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 8. Sealed Classes
            //MathOperations mathOperations = new MathOperations();            
            //Console.WriteLine($"Sum is: {mathOperations.Add(1, 2)}");
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 9. Constructor Chaining
            //PersonNew person = new PersonNew("Aleesha", 21);
            //EmployeeNew employee = new EmployeeNew("IT");
            //employee.ShowDetails();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 10. Interface Inheritance
            //InheritClass inheritClass = new InheritClass();
            //Console.WriteLine("This is from IDriveable");
            //inheritClass.Drive();
            //Console.WriteLine("\nThis is from IRaceable");
            //inheritClass.Race();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 11. IS-A Relationship (Inheritance)
            //DogNew dog = new DogNew();
            //Console.WriteLine("From DogNew class");
            //dog.Bark("Zoe");
            //Console.WriteLine("\nFrom AnimalNew class");
            //dog.Eat("Caesar");
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 12.HAS-A Relationship (Composition)
            //Engine engine = new Engine();
            //CarNew car = new CarNew("Honda", 24, 1600, 6, engine);
            //car.Display();
            //engine.Display();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 13. Calling Base Class Method Using base
            //NewEmployee employee = new NewEmployee("Riya", 22); //inside NewPerson
            //employee.DisplayInfo();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 14. Accessing Base Class Variable Using base 
            //StudentNew student = new StudentNew("Anakha"); //inside PersonClass
            //student.DisplayName();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//

            ////Lab 15. Calling Base Class Constructor Using base
            //NewCar car = new NewCar("Toyota");
            //car.DisplayBrand();
            //Console.ReadLine();

            //-----------------------------------------------------------------------//
        }
    }
}
