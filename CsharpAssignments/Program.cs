using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1: Circle Class
            //try
            //{
            //    Circle circle = new Circle();
            //    circle.Radius = 10;
            //    Console.WriteLine("Radius of the circle is: " + circle.Radius);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 2: Employee Class
            //try
            //{
            //    Employee employee = new Employee();
            //    employee.Name = "Aleesha";
            //    employee.Salary = 50000.0;
            //    Console.WriteLine($"Name of employee: {employee.Name}, salary: {employee.Salary}");
            //    Employee employee2 = new Employee();
            //    employee2.Name = "Aleesha";
            //    employee2.Salary = -50000.0;
            //    Console.WriteLine($"Name of employee: {employee2.Name}, salary: {employee2.Salary}");

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 3: Library Management System
            //Book book1 = new Book("The Da Vinci Code", "Dan Brown", "984-456-874");
            //Book book2 = new Book("Harry Potter", "J. K. Rowling", "875-545-634");
            //Book book3 = new Book("Alice in Wonderland", "Lewis Carroll", "584-412-965");
            //Library library = new Library();
            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);
            //Console.WriteLine("Books in library:");
            //library.DisplayBooks();
            //Console.WriteLine();
            //library.RemoveBook("984-456-874");
            //Console.WriteLine("Books in library after removing:");
            //library.DisplayBooks();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 4: Banking System
            //try
            //{
            //    BankAccount bankAccount = new BankAccount(5415485266542, "Aleesha Thomas");
            //    bankAccount.Deposit(50000);
            //    bankAccount.BalanceCheck();
            //    Console.WriteLine();
            //    bankAccount.Withdraw(35000);
            //    bankAccount.BalanceCheck();
            //    Console.WriteLine();
            //    bankAccount.Withdraw(40000);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 5: Student Management System
            //try
            //{
            //    StudentDetails student = new StudentDetails("Aleesha", "20EE");
            //    student.AddMarks(80);
            //    student.AddMarks(90);
            //    student.AddMarks(85);
            //    student.AddMarks(99);
            //    Console.WriteLine($"Name: {student.Name}, ID: {student.ID}");
            //    Console.WriteLine("Average marks is: "+student.Average());
            //    Console.WriteLine();
            //    StudentDetails student2 = new StudentDetails("Sreelakshmi", "21EE");
            //    student2.AddMarks(70);
            //    student2.AddMarks(80);
            //    student2.AddMarks(85);
            //    student2.AddMarks(95);
            //    Console.WriteLine($"Name: {student2.Name}, ID: {student2.ID}");
            //    Console.WriteLine("Average marks is: " + student2.Average());
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 6: Inventory System
            //try
            //{
            //    Item item1 = new Item("Laptop", 10, 50000);
            //    Item item2 = new Item("Mouse", 50, 500);
            //    Item item3 = new Item("Speaker", 20, 5000);

            //    Inventory inventory = new Inventory();
            //    inventory.AddItem(item1);
            //    inventory.AddItem(item2);
            //    inventory.AddItem(item3);
            //    inventory.ShowItems();
            //    Console.WriteLine();
            //    inventory.RemoveItem("Mouse");
            //    inventory.ShowItems();
            //    Console.WriteLine();
            //    inventory.UpdateItem("Speaker", 10, 6000);
            //    inventory.ShowItems();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            //Assignment 7: E-commerce System
            //try
            //{
            //    Product product1 = new Product("Bottle", 50, 80);
            //    Product product2 = new Product("Mug", 100, 50);
            //    Product product3 = new Product("Flower Vase", 500, 70);

            //    Order order = new Order();
            //    order.AddProduct(product1);
            //    order.AddProduct(product2);
            //    order.AddProduct(product3);
            //    Console.WriteLine("Before Ordering:");
            //    order.DisplayProductDetails("Mug");
            //    order.OrderProduct("Mug");
            //    Console.WriteLine("After Ordering:");
            //    order.DisplayProductDetails("Mug");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 8: Print Class
            //Print print = new Print();
            //Console.WriteLine($"Data as string: {print.PrintData("Aleesha")}");
            //Console.WriteLine($"Data as integer: {print.PrintData(2003)}");
            //int[] data = { 1, 2, 3, 4 };
            //Console.WriteLine("Data in array:");
            //print.PrintData(data);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 9: Rectangle Class 
            //Rectangle rectangle = new Rectangle();
            //rectangle.RectangleArea(4, 3);
            //rectangle.RectangleArea(5);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 10: Time Class
            //Time time = new Time();
            //time.SetTime(5, 62);
            //time.SetTime(4800);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            //Static and Instance Blocks

            ////Assignment 11: Initializing a Static Field
            //Bank bank = new Bank(500);
            //bank.DisplayAccountInfo();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 12: Counting Objects with Static and Instance Fields
            //Car car1 = new Car();
            //Car car2 = new Car();
            //car2.Count();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 13: Initializing Constants with Static Block
            //MathOperations mathOperations = new MathOperations();
            //mathOperations.Display();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 14: Initializing Configuration with Static Constructor
            //try
            //{
            //    Configuration configuration1 = new Configuration("ON", "Dark", "Times New Roman");
            //    Console.WriteLine("Settings of user 1");
            //    configuration1.Display_Settings();
            //    Console.WriteLine();
            //    Configuration configuration2 = new Configuration("OFF", "Light", "Calibri");
            //    Console.WriteLine("Settings of user 2");
            //    configuration2.Display_Settings();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment15: Implementing and Understanding Copy Constructor 
            //Details initial = new Details();
            //Console.WriteLine("Details during initialization");
            //initial.DisplayDetails();
            //Console.WriteLine();

            //Details input = new Details("Aleesha", 21, "Haripad");
            //Console.WriteLine("Details after inputting");
            //input.DisplayDetails();
            //Console.WriteLine();

            //Details copy = new Details(input);
            //Console.WriteLine("Details in Copy Constructor");
            //copy.DisplayDetails();
            //Console.WriteLine();

            //Details reference = input;
            //Console.WriteLine("Details in Reference");
            //reference.DisplayDetails();
            //Console.WriteLine();

            //reference.Name = "Riya";
            //reference.Age = 22;
            //reference.Place = "Nangiarkulangara";

            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("Details in original after changing in reference");
            //input.DisplayDetails();
            //Console.WriteLine();
            //Console.WriteLine("Details in copy after changing in reference");
            //copy.DisplayDetails();
            //Console.WriteLine();
            //Console.WriteLine("Details in reference after changing in reference");
            //reference.DisplayDetails();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 16: Identifying the Need for Chained Constructors
            //CarDetails car1 = new CarDetails("Ford");
            //car1.DisplayCarDetails();
            //Console.WriteLine();
            //CarDetails car2 = new CarDetails("Honda", "Pilot EX-L");
            //car2.DisplayCarDetails();
            //Console.WriteLine();
            //CarDetails car3 = new CarDetails("Chevrolet", "Equinox LS", 2024);
            //car3.DisplayCarDetails();
            //Console.WriteLine();
            //CarDetails car4 = new CarDetails("Mercedes-Benz", "GLA 250", 2024, 43000);
            //car4.DisplayCarDetails();
            //Console.WriteLine();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 17: Understanding the Need for Constructor Overloading 
            //ProductNew product1 = new ProductNew("Pencil");
            //product1.CalculateFinalPrice();
            //product1.Display();
            //Console.WriteLine();
            //ProductNew product2 = new ProductNew("Mouse", 3.5f);
            //product2.CalculateFinalPrice();
            //product2.Display();
            //Console.WriteLine();
            //ProductNew product3 = new ProductNew("Laptop", 737.18f, 40);
            //product3.CalculateFinalPrice();
            //product3.Display();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            ////Assignment 18: Exploring Different Ways to Initialize Objects 
            //NewProduct product1= new NewProduct();
            //Console.WriteLine("Initial values");
            //product1.Display();
            //Console.WriteLine();

            //NewProduct product2= new NewProduct("Pencil", 10, "Stationary");
            //Console.WriteLine("Values initialized");
            //product2.Display();
            //Console.WriteLine();

            //NewProduct product3 = NewProduct.CreateProduct("Pen", 5, "Stationary");
            //Console.WriteLine("Using static method");
            //product3.Display();
            //Console.WriteLine();

            //Type producttype = typeof(NewProduct);
            //NewProduct product4=(NewProduct)Activator.CreateInstance(producttype, new object[] {"Snacks", 80, "Eatables"});
            //Console.WriteLine("Reflection method");
            //product4.Display();
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------//

            //Assignment 19: Exploring Initialization Using Tuples and Records

            //Assignment 20: Shopping Cart
            ShoppingCart cart = new ShoppingCart();
            ShoppingCart.CartProduct product = new ShoppingCart.CartProduct("Laptop", 60000, 40);
            //cart.AddProduct(product);








        }
    }
    public class Circle
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }
                radius = value;
            }
        }
    }

    public class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }
    }

    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }
    }


}


