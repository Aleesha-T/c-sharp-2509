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
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

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
            //}
            //Assignment 5: Student Management System
            try
            {
                StudentDetails student = new StudentDetails("Aleesha", "20EE");
                //student.BiologyMarks = 80;
                //student.EnglishMarks = 80;
                //student.ScienceMarks = 80;
                //student.AddBiologyMarks(12);
                //student.AddEnglishMarks(14);
                //student.AddScienceMarks(18);
                //student.Average();


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
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
}


