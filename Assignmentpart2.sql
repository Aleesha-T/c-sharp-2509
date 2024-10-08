--use companyDB

--Assignment 17: Basic View Creation

--create view EmployeeView as 
--select FirstName,LastNme, Department from Employees;
--created Employee View

--select * from EmployeeView

--Assignment 18: Updating Data Through a View

--create view EditableEmployeeView as
--select EmployeeID, FirstName, LastNme, Salary from Employees
--created editable view

--select * from Employees

--update EditableEmployeeView
--set Salary = 60000
--where EmployeeID = 1
--updated salary

--select * from EditableEmployeeView
--verified update

--Assignment 19: View with Calculated Columns

--create view EmployeeSalaryBonusView as
--select FirstName, LastNme, Salary, Salary*0.10 as Bonus
--from Employees
--created bonus view

--select * from EmployeeSalaryBonusView

--Assignment 20: Altering a View 

--Alter view EmployeeView
--as
--select FirstName, LastNme, Department, Salary
--from Employees
--altered EmployeeView

--select * from EmployeeView

--Assignment 21: View with Parameters (Simulated via Filters) 

--create view FilteredEmployeeView as
--select EmployeeID,FirstName,LastNme,Department
--from Employees
--created filtered employee view

--select * from FilteredEmployeeView where Department = 'HR'

--Assignment 22: Dropping a View

--drop view EmployeeView
--deleted employee view

--select * from EmployeeView --tried calling again

--SQL Server Lab Assignments-Part 2
--Assignment 1: Sales Database

--create table SalesTable (
--SaleID int identity(1,1),
--ProductID int,
--ProductName varchar(50),
--QuantitySold int,
--SaleAmount int,
--SaleDate date
--)
--created sales table

--insert into SalesTable(ProductID, ProductName, QuantitySold, SaleAmount, SaleDate)
--values
--(101, 'Laptop', 5, 5000, '2024-09-01'),
--(102, 'Mouse', 10, 250, '2024-09-02'),
--(101, 'Laptop', 3, 3000, '2024-09-03'),
--(103, 'Keyboard', 8, 800, '2024-09-04'),
--(102, 'Mouse', 6, 150, '2024-09-05')
-- inseted values

--select sum(SaleAmount)  as sum_saleamount from SalesTable
--selected sum

--select max(QuantitySold) as max from SalesTable
--selected max value

--select AVG(SaleAmount) as avg from SalesTable
--selected average sale amount

--select min(SaleAmount)  as min from SalesTable
--selected min of sale amount

--select sum(QuantitySold) from SalesTable where ProductName = 'Laptop'
--seleccted sum of quantity sold of laptop

--Assignment 2: Employee Salaries

--create table Employee(
--EmployeeID int identity(1,1),
--EmployeeName varchar(50),
--Department varchar(50),
--Salary int,
--HireDate date
--)
--created table

--insert into Employee(EmployeeName, Department, Salary, HireDate)
--values
--('John Doe', 'IT', 5000, '2022-01-10'),
--('Jane Smith', 'HR', 6000, '2021-03-15'),
--('Bob Johnson', 'Finance', 5500, '2020-06-20'),
--('Alice Brown', 'IT', 6200, '2023-02-01'),
--('Charlie White', 'Marketing', 4800, '2023-03-10')
--inserted values

--select sum(Salary) as totalsalaryexpenditure from Employee
--selected total salary expenditure

--select max(Salary) as highestsalary from Employee
--selected highest salary

--select avg(Salary) as averagesalary from Employee
--selected average salary

--select min(Salary) as minsalary from Employee where Department = 'IT'
--selected minimum salary of IT

--select Department, count (*) as totalemployees from Employee
--group by Department
--selected and counted total number of employees in each department

--Assignment 3: Inventory Management

--create table Inventory (
--ProductID int not null primary key identity(201,1),
--ProductName varchar(50),
--QuantityInStock int,
--ReorderLevel int,
--LastRestockDate date)
--created inventory table

--insert into Inventory (ProductName, QuantityInStock, ReorderLevel, LastRestockDate)
--values
--('Monitor', 50, 10, '2024-08-25'),
--('Printer', 30, 5, '2024-09-01'),
--('Mouse', 100, 15, '2024-09-10'),
--('Keyboard', 80, 20, '2024-09-15'),
--('Laptop', 25, 5, '2024-09-20')
--inserted values

--select sum(QuantityInStock) as totalquantity from Inventory
--selected total qty.

--select ProductName, QuantityInStock as maxstock from Inventory where QuantityInStock = (select max(QuantityInStock) from Inventory)
--selected product with max. qty.

--select * from Inventory

--select AVG(ReorderLevel) as avgreorder from Inventory
--selected avg reorder level

--select ProductName, ReorderLevel as minreorder from Inventory where ReorderLevel = (select min(ReorderLevel) from Inventory)
--selected product with min reorder

--select sum(QuantityInStock) from Inventory where QuantityInStock<ReorderLevel 
--selected sum of qty. where qty. less than reorder

--Assignment 4: Customer Orders Database

--create table CustomerOrders(
--OrderID int not null primary key identity(501,1),
--CustomerID varchar(50),
--OrderDate date,
--OrderAmount int, 
--QuantityOrdered int)
--created table

--insert into CustomerOrders (CustomerID, OrderDate, OrderAmount, QuantityOrdered)
--values
--('C001', '2024-09-10', 1500, 3),
--('C002', '2024-09-11', 2000, 5),
--('C001', '2024-09-12', 1000, 2),
--('C003', '2024-09-13', 2500, 4),
--('C002', '2024-09-14', 3000, 6)
--inserted values

--select sum(OrderAmount) as sum from CustomerOrders
--selected total order amount

--select avg(OrderAmount) as avg from CustomerOrders
--selected average

--select max(OrderAmount) as max from CustomerOrders
--selected max value

--select sum(QuantityOrdered) as sum from CustomerOrders
--selected total orders

--select min(OrderAmount) as min from CustomerOrders
--selected min amount

--Assignment 6: Product Ratings Database
--create table ProductRatings (
--RatingID int not null primary key identity(1,1),
--ProductID varchar(50),
--CustomerID varchar(50),
--Rating int,
--ReviewDate date)
--created table

--insert into ProductRatings(ProductID, CustomerID, Rating, ReviewDate)
--values
--('P001', 'C001', 4, '2024-09-01'),
--('P002', 'C002', 5, '2024-09-02'),
--('P001', 'C003', 3, '2024-09-03'),
--('P003', 'C001', 2, '2024-09-04'),
--('P002', 'C004', 4, '2024-09-05')
--inserted values

--select ProductID, avg(Rating) as avg from ProductRatings
--group by ProductID
--selected average rating for each product

--select max(Rating) as maxrating from ProductRatings
--max rating

--select min(Rating) as minrating from ProductRatings
--min rating

--select ProductID, count(Rating) as totalcount from ProductRatings
--group by ProductID
--total no. of ratings for each pdt.

--select count(distinct ProductID) as TotalProductsRated from ProductRatings
--selected total no. of producs rated

--SQL Server assignments and solutions using various SQL operators such as IN, BETWEEN, LIKE, AND, OR, NOT, etc.

--Assignment 1: Retrieve Employees Who Work in Specific Departments Using IN Operator

--select EmployeeName from Employee where Department in ('HR', 'Finance', 'IT')
--selected employee names' working in HR, finance or IT

--Assignment 2: Retrieve Products Within a Specific Price Range Using BETWEEN Operator

--select ProductName, Price from Products where Price between 100 and 500
--retrieved the product names and prices of products that are priced between 100 and 500.

--Assignment 3: Find Customers Whose Name Starts With 'A' Using LIKE Operator

--select CustomerName from CustomersTable where CustomerName like 'A%'
--retrieved the customer names that start with the letter 'A'.

--Assignment 4: Retrieve Orders Placed on Specific Dates Using IN Operator

--select OrderID from Orders where OrderDate in ('2023-01-01', '2023-02-01', '2023-03-01')
--retrieved the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'

--Assignment 5: Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN Operator

--select ProductName, Price from Products where Price not between 100 and 500
--retrieved the product names and prices of products that are not priced between 100 and 500.

--Assignment 6: Find Orders Where the Total Amount is More Than 5000 or Less Than 1000 Using OR Operator

--select OrderID from Orders where TotalAmount>5000 or TotalAmount<1000
--retrieved the order IDs where the total amount is either greater than 5000 or less than 1000.

--Assignment 7: Retrieve Employees Who Do Not Work in the 'HR' or 'IT' Departments Using NOT IN Operator

--select EmployeeName from Employee where Department not in ('HR', 'IT')
--retrieved the names of employees who do not work in the 'HR' or 'IT' departments.

--Assignment 8: Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators

--select OrderID from Orders where OrderDate between '2023-01-01' and '2023-12-31'
--retrieved the order IDs of orders placed between '2023-01-01' and '2023-12-31'

--Assignment 9: Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator

--select CustomerName from CustomersTable where CustomerName not like '%John%'
--Retrieved the customer names that do not have 'John' in them.

--Assignment 10: Retrieve Products That Are Either in Category 'A' or Priced Below 100 Using IN and OR Operators

--create table Categories(
--CategoryID int not null primary key,
--CategoryName varchar(50)
--)
----created table

--insert into Categories(CategoryID, CategoryName)
--values
--(1, 'A'),
--(2, 'B'),
--(3, 'C')
----inserted values

--create table Product(
--ProductID int not null primary key identity(1,1),
--ProductName varchar(50),
--Price int,
--CategoryID int not null
--Foreign Key(CategoryID) References Categories(CategoryID)
--)
----created table

--insert into Product(ProductName, Price, CategoryID)
--values
--('Keyboard', 1000, 1),
--('Mouse', 100, 1),
--('Pen', 10, 2)
----inserted values

--select ProductName, Price from Product, Categories where CategoryName = 'A' or Price<100
--Retrieved the product names and prices of products that are either in category 'A' or have a price less than 100. 

