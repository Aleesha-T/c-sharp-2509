--Create database CompanyDB
--created database

--use CompanyDB

/*Create table Employees (
EmployeeID int PRIMARY KEY identity (1,1),
FirstName varchar(50),
LastNme varchar(50),
Department varchar(50),
Salary decimal(10,2)
); */
--created table

--select * from Employees
/*insert into Employees (FirstName, LastNme, Department, Salary)
values
('John', 'Doe', 'HR', 50000),
('Jane', 'Smith', 'IT', 60000),
('David', 'Lee', 'Marketing', 55000);*/
--inserted values

--select FirstName, LastNme, Department from Employees

--select * from Employees where Salary > 5000

--select MAX(Salary) As MaxSalary from Employees

/*Update Employees
set Salary = 55000
where FirstName = 'John'*/
--updated salary of John

/*Update Employees
set Department = 'Marketing'
where FirstName = 'Jane'*/
--updated dept. of Jane

/*delete from Employees
where FirstName = 'David'*/
--deleted David's record

--delete from Employees where Department = 'Marketing'
--deleted records of marketing dept.

--Assignment 6
/*create table Products(
ProductID int PRIMARY KEY identity (1,1),
ProductName varchar(50),
Category varchar(50),
Price int,
Stock int );*/
--created table Products
--insert into Products(ProductName, Category, Price, Stock)
--values
--('Laptop', 'Electronics', 1000, 50),
--('Mouse', 'Electronics', 20, 200),
--('Keyboard', 'Electronics', 30, 150),
--('Printer', 'Electronics', 150, 75);
--inserted values

--select * from Products
--selected all columns

--select * from Products
--order by Price DESC
--shown in descending order

--Update Products
--set Price = 25
--where ProductName = 'Mouse'
--updated price of mouse

--delete from Products
--where ProductID = 2
--deleted mouse

--select * from Products
--order by ProductName ASC
--ordered in alphabetical order

--Assignment 7: Library Management

--create table Books(
--BookID int PRIMARY KEY identity(1,1),
--Title varchar(255),
--Author varchar(255),
--PublishedYear int,
--AvailableCopies int);
--created table Books

--insert into Books (Title, Author, PublishedYear, AvailableCopies)
--values
--('The Great Gatsby', 'F.Scott Fitzgerald', 1925, 3),
--('1984', 'George Orwell', 1949, 2),
--('To Kill a Mockingbird', 'Harper Lee', 1960, 5),
--('Brave New World', 'Aldous Huxley', 1932, 4);
--inserted values

--Update Books
--Set AvailableCopies = 5 where Title = '1984'
--updated available copies

--delete from Books
--where BookID = 1
--deleted first book

--select * from Books where PublishedYear >1950
-- select books published after 1950

--Assignment 8: Customer Management
--create table CustomersTable (
--CustomerID int Primary Key identity(201,1),
--CustomerName varchar(255),
--Email varchar(255),
--PhoneNumber varchar(255)
--);
--created table CustomersTable

--insert into CustomersTable (CustomerName, Email, PhoneNumber)
--values
--('Alice Johnson', 'alice@exampl.com', '555-1234'),
--('Bob Smith', 'bob@example.com', '555-8765'),
--('Charlie Brown', 'charlie@example.com', '555-8765');
--inserted values

--select * from CustomersTable

--insert into CustomersTable (CustomerName, Email, PhoneNumber)
--values
--('David Wilson', 'david@example.com', '555-4321');
--inserted value

--update CustomersTable
--set PhoneNumber = '555-9999'
--where CustomerName = 'Alice Johnson'
--updated phone number of Alice

--delete from CustomersTable
--where CustomerID = 202
--deleted Bob's data

--Assignment 9: Orders Management

--create table Orders(
--OrderID int PRIMARY KEY identity(301,1),
--CustomerID int,
--OrderDate date,
--TotalAmount int);
--created table

--insert into Orders (CustomerID, OrderDate, TotalAmount)
--values
--(201, '2024-09-01', 250),
--(202, '2024-09-02', 150),
--(203, '2024-09-03', 200);
--inserted values

--insert into Orders (CustomerID, OrderDate, TotalAmount)
--values
--(204, '2024-09-04', 300);
--inserted value 204

--update Orders
--set TotalAmount = 275
--where OrderID = 301
--updated amount of order id 301

--delete from Orders
--where OrderID = 302
--delete order 302

--select * from Orders where TotalAmount>200
--selected orders with amount greater than 200

--select OrderID, TotalAmount from Orders
--select only orderID and total amount

--Assignment 10: Primary Key
--create table Students(
--StudentID int PRIMARY KEY identity(1,1),
--FirstName varchar(255),
--LastName varchar(255),
--Email varchar(255)
--);
-- created students table

--insert into Students (FirstName, LastName, Email)
--values
--('John', 'Doe', 'john.doe@example.com'),
--('Jane', 'Smith', 'jane.smith@example.com'),
--('Mike', 'Johnson', 'mike.johnson@example.com');
--inserted value

--Assignment 11: Foreign Key
--create table Courses(
--CourseID int PRIMARY KEY identity(1,1),
--CourseName varchar(255)
--);
--created course table

--insert into Courses(CourseName)
--values
--('Python'),
--('SQLcode'),
--('C#');
--inserted values to courses

--create table StudentsTable(
--StudentID int PRIMARY KEY identity(1,1),
--StudentName varchar(255),
--);
--created students table

--insert into StudentsTable(StudentName)
--values
--('John'),
--('Peter'),
--('Thomas');
--inserted values to student table

--create table Enrollments(
--EnrollmentID int PRIMARY KEY identity(1,1),
--StudentID int,
--CourseID int,
--Foreign Key (StudentID) References StudentsTable(StudentID),
--Foreign Key (CourseID) References Courses (CourseID)
--);
--created entrollments table

--insert into Enrollments(StudentID, CourseID)
--values
--(1,1),
--(1,2),
--(2,2),
--(2,3)
-- inserted values

--select * from Enrollments

--Assignment 12: Composite Key
--Create table OrderDetails(
--OrderID int,
--ProductID int,
--Quantity int,
--Primary Key (OrderID, ProductID)
--);
--created table OrderDetails

--Assignment 13: Candidate Key and Alternate Key
--create table Users(
--UserID int primary key,
--Email varchar(100) unique,
--Username varchar(50)
--);
--created users table

--Assignment 14: Surrogate Key
--create table ProductsTable(
--AutoID int primary key identity(1,1),
--ProductName varchar(255),
--Price int
--);
--created products table

--Assignment 15: Natural Key
--create table EmployeesTable(
--SSN int primary key,
--FirstName varchar(50),
--LastName varchar(50),
--Position varchar(50)
--);
--created table employees

--insert into EmployeesTable(SSN, FirstName, LastName, Position)
--values
--(123456, 'John', 'Paul', 'HR'),
--(123453, 'Peter', 'Mathew', 'Manager');
--inserted values

--select * from EmployeesTable

--Assignment 16: Unique Key
--create table Customers (
--CustomerID int primary key,
--PhoneNumber int unique
--);
--created table




