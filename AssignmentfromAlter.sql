--use CompanyDB

--SQL Server assignments focused on using the ALTER TABLE command to perform various table modifications.

--Assignment 1: Add a New Column 

Alter table Employee
Add DateOfBirth date
--Added column DOB

--Assignment 2: Modify Column Data Type

Alter table CustomersTable
Alter Column PhoneNumber varchar(15)
--changed datatype

--Assignment 3: Add a Primary Key 

create table Departments(
DepartmentID int not null identity,
DepartmentName varchar(50) not null)

Alter table Departments
Add Constraint PK_DepartmentID Primary Key(DepartmentID)
--added primary key

--Assignment 4: Drop a Column

create table NewEmployeeTable(
ID int not null primary key identity,
FirstName varchar(50) not null,
MiddleName varchar(50) not null,
LastName varchar(50) not null)

Alter table NewEmployeeTable
Drop Column MiddleName
--dropped middle name column

select * from NewEmployeeTable

--Assignment 5: Add a Foreign Key 

create table Order1 (
EmploymentID int not null,
OrderDetail varchar(50) not null)

Alter table Order1
Add Constraint FK_EmploymentID 
Foreign Key (EmploymentID) references Employees(EmployeeID)
--added foreign key

--Assignment 6: Drop a Foreign Key 

Alter table Order1
Drop Constraint FK_EmploymentID 
--dropped foreign key

--Assignment 7: Rename a Column 

EXEC sp_rename 'Employee.EmployeeName', 'EmployeeFullName', 'COLUMN'; 
--renamed column

--Assignment 8: Add a Default Value 

Alter table NewEmployeeTable
Add Status1 varchar(50) 

Alter table NewEmployeeTable
Add constraint DF_Status
Default 'Active' for Status1
--added default constraint

--Assignment 9: Drop a Primary Key 

Alter table Departments
Drop constraint [PK_DepartmentID]
--dropped primary key constraint

--Assignment 10: Add a Unique Constraint 

Alter table NewEmployeeTable
Add email varchar(100) not null

Alter table NewEmployeeTable
Add constraint UQ_Email Unique(email)
--added unique key

--Assignment 11: Add a Check Constraint 

Alter table Employee
Add constraint CK_Salary Check(Salary > 1000)
--added check constraint

--Assignment 13: Drop a Check Constraint 

Alter table Employee
Drop constraint CK_Salary
--dropped check constraint

Alter table Employee
Add constraint CK_Salary Check(Salary > 1000)

--insert into Employee([EmployeeFullName], [Department], [Salary], [HireDate], [DateOfBirth])
--values
--('Ravi', 'Sales', 500, '09/02/2024', '09/02/1998') --checked if check constraint is wrking

--SQL Server assignments involving subqueries. 

--Assignment 1: Retrieve Employees Who Earn More Than the Average Salary 

select EmployeeFullName, Salary from Employee where Salary > (select AVG(Salary) from Employee)
--Retrieved the names and salaries of employees whose salary is greater than the average salary of all employees 

--Assignment 2: Find Departments with More Than 5 Employees 

create table Employee_New (
EmployeeID int not null primary key identity, 
EmployeeName varchar(50) not null, 
DepartmentID int not null) 

insert into Employee_New(EmployeeName, DepartmentID) 
values
('Ravi', 1),
('Sankar', 2),
('Akash', 1),
('Amal', 1),
('Raj', 1),
('Ram', 1),
('Anson', 1)

select * from Employee_New

insert into Departments(DepartmentName)
values 
('HR'),
('Marketing')

select * from Departments

select DepartmentName from Departments where DepartmentID in (select DepartmentID from Employee_New 
group by DepartmentID having count (EmployeeID)>5)
--Retrieved the department names that have more than 5 employees.

--Assignment 3: Retrieve Products with a Price Higher Than the Maximum Price of Category 'A' 

select * from Products

insert into products
values
('Pen', 'Stationary', 10, 4000),
('Pencil', 'Stationary', 10, 3000)

select ProductName, Price from Products where Price > (select max(Price) from Products where Category = 'Stationary')
-- Retrieved the product names and prices of products that have a price higher than the maximum price of products in category 'stationary'.

--Assignment 4: Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000

select * from Employee_New
truncate table Employee_New

Alter table Employee_New
Add Salary bigint not null

insert into Employee_New
values ('Ravi', 1, 30000),
('Raj', 2, 50000),
('Ram', 2, 80000),
('Riya', 2, 100000)

select * from Departments

select EmployeeName from Employee_New where DepartmentID = (select DepartmentID from Employee_New
group by DepartmentID having AVG(Salary) > 50000)
-- Retrieved the names of employees who work in departments where the average salary is higher than 50,000.

--Assignment 5:  Find Employees Who Earn More Than Their Department's Average Salary 

select EmployeeName from Employee_New E where Salary > (select AVG(Salary) from Employee_New where DepartmentID = E.DepartmentID)
--Retrieved the names of employees who earn more than the average salary of their department. 

--Assignment 6:  Find Customers Who Have Not Placed Any Orders 

select * from CustomersTable
select * from Orders

insert into CustomersTable
values('Leah', 'leah@example.com', '666-333')

select CustomerName from CustomersTable where CustomerID not in (select CustomerID from Orders)
--Retrieved the names of customers who have not placed any orders.

--Assignment 8:  Find Products That Have Never Been Ordered

select * from OrderDetails
select * from Products

insert into OrderDetails
values
(1,1, 2),
(2, 1, 5),
(3, 3, 3),
(4, 3, 5)

select ProductName from Products where ProductID not in (select ProductID from OrderDetails)
-- Retrieved the names of products that have never been ordered. 

--SQL Server assignments that focus on different types of joins (INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL OUTER JOIN, CROSS JOIN) 

--Assignment 1:  Retrieve Employees and Their Department Names (INNER JOIN)

select * from Departments
select * from Employee_New

select Employee_New.EmployeeName, Departments.DepartmentName from Employee_New
inner join Departments
on Employee_New.DepartmentID = Departments.DepartmentID
-- Retrieved the employee names and their corresponding department names. 

--Assignment 2: Retrieve All Employees and Their Department Names, Including Those Without Departments (LEFT JOIN)

Alter table Employee_New
Alter column DepartmentID int null

insert into Employee_New
values
('Amal', NULL, 8000)

select Employee_New.EmployeeName, Departments.DepartmentName from Employee_New
left join Departments
on Employee_New.DepartmentID = Departments.DepartmentID
-- Retrieved the employee names and their corresponding department names. 

--Assignment 3: Retrieve All Departments and the Employees Working in Them (RIGHT JOIN)

select * from Departments
select * from Employee_New

insert into Departments
values
('Finance'), ('Maintenance'), ('Operations')

select Employee_New.EmployeeName, Departments.DepartmentName from Employee_New
right join Departments
on Employee_New.DepartmentID = Departments.DepartmentID
--Retrieved all departments and their respective employees. 

--Assignment 4:  Retrieve All Employees and Departments, Including Those Without Matches (FULL OUTER JOIN)

select Employee_New.EmployeeName, Departments.DepartmentName from Employee_New
full outer join Departments
on Employee_New.DepartmentID = Departments.DepartmentID
--Retrieve all employees and all departments, including employees without a department and departments without employees.

--Assignment 5:  Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 

select * from Orders
select * from CustomersTable

select Orders.OrderID, CustomersTable.CustomerName from Orders
inner join CustomersTable
on Orders.CustomerID = CustomersTable.CustomerID
--Retrieve order IDs and customer names for all orders.

--Assignment 6:  Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN)

select Orders.OrderID, CustomersTable.CustomerName from CustomersTable
left join Orders
on Orders.CustomerID = CustomersTable.CustomerID
-- Retrieve all customers and their respective orders. Include customers even if they haven’t placed any orders.

--Assignment 7:  Retrieve Products and Their Categories (INNER JOIN)

create table Products_New (
ProductID int not null primary key identity,
ProductName varchar(50) not null,
CategoryID int not null)

insert into Products_New
values
('Laptop', 1),
('Keyboard', 1),
('Pen', 2),
('Pencil', 2)

create table Categories(
CategoryID int not null primary key identity,
CategoryName varchar(50))

insert into Categories
values
('Electronics'),
('Stationary'),
('FoodItems')

select * from Products_New
select * from Categories

select Products_New.ProductName, Categories.CategoryName from Products_New
inner join Categories
on Products_New.CategoryID = Categories.CategoryID
-- Retrieve product names and their respective category names.

--Assignment 8:  Retrieve All Categories and Products, Including Categories Without Products (RIGHT JOIN)

select Products_New.ProductName, Categories.CategoryName from Products_New
right join Categories
on Products_New.CategoryID = Categories.CategoryID
--Retrieve all categories and the products in each category. Include categories that don’t have any products. 

--Assignment 9:  Retrieve Employees and Their Managers (Self-Join) 

create table Employees1 (
EmployeeID int not null primary key identity,
EmployeeName varchar(50) not null,
ManagerID int null)

insert into Employees1
values
('Ravi', NULL),
('Sankar', 4),
('Sathyan', 2),
('Sheeba', 1)

select E1.EmployeeName, E2.EmployeeName as ManagerName from Employees1 E1
left join Employees1 E2
on E1.ManagerID = E2.EmployeeID
--Retrieve the employee names and the names of their managers.

--Assignment 10:  Get All Possible Combinations of Products and Orders (CROSS JOIN)

select * from OrderDetails
select * from Products

select P.ProductID, P.ProductName, O.OrderID from Products P
cross join OrderDetails O
--Retrieve all possible combinations of products and orders (cartesian product). 

--SQL Server assignments using the GROUP BY and HAVING clauses 

--Assignment 1: Find the Average Salary in Each Department 
--Retrieve the department name and the average salary of employees in each department. Only display departments where the average salary is greater than 50,000.

select D.DepartmentName,AVG(E.Salary) as AvgSalary from Employee_New E
Join Departments D on E.DepartmentID = D.DepartmentID
group by D.DepartmentName having AVG(E.Salary) > 50000

--Assignment 2:  Count the Number of Employees in Each Department 
--Retrieve the department name and the total number of employees in each department. Only display departments that have more than 5 employees.

insert into Employee_New
values
('Liam', 2, 50000),
('Peter', 2, 30000),
('John', 2, 40000)

select D.DepartmentName,count(E.EmployeeID) as EmployeeCount from Employee_New E
Join Departments D on E.DepartmentID = D.DepartmentID
group by D.DepartmentName having count(E.EmployeeID) > 5

--Assignment 3: Find the Maximum and Minimum Salary in Each Department 
--Retrieve the department name, maximum salary, and minimum salary for each department. Only include departments where the minimum salary is greater than 30,000.

insert into Employee_New
values
('Ram', 3, 80000)

select D.DepartmentName,max(E.Salary) as MaxSalary, min(E.Salary) as MinSalary from Employee_New E
Join Departments D on E.DepartmentID = D.DepartmentID
group by D.DepartmentName having min(E.Salary) > 30000

--Assignment 4:  Find the Total Sales by Each Salesperson 
--Retrieve the employee name and total sales made by each salesperson. Only display salespersons who have made total sales of more than 100,000.

create table Sales(
SalesID int not null primary key identity,
EmployeeID int not null, 
Amount bigint not null)

insert into Sales
values
(1, 50000),
(2, 5000),
(1, 52000),
(3, 20000)

select * from Sales
select * from Employees1

select E.EmployeeName, sum(S.Amount) as TotalSales from Sales S
Join Employees1 E on S.EmployeeID = E.EmployeeID
group by E.EmployeeName having sum(S.Amount) > 100000

--Assignment 5:  Find the Number of Orders by Each Customer 
--Retrieve the customer name and the total number of orders placed by each customer. Only display customers who have placed more than 3 orders. 

select * from CustomersTable
select * from Orders

insert into Orders
values
(201, '2024-08-16', 355),
(201, '2024-07-15', 400),
(201, '2024-03-16', 588)

select C.CustomerName, Count(O.OrderID) as OrderCount from Orders O
Join CustomersTable C on O.CustomerID = C.CustomerID
group by C.CustomerName having count(O.OrderID) > 3