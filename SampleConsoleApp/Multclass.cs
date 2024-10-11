using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Multclass
    {
        
            //Qn. 1
            //Console.WriteLine("Your Name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName);
            //Console.ReadLine();

            //Qn. 2
            //Console.WriteLine("Your Full Name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your age?");
            //string age = Console.ReadLine();
            //Console.WriteLine("Favourite Colour");
            //string colour = Console.ReadLine();
            //Console.WriteLine("Hello " + name, "you are " + age, "years old");
            //Console.WriteLine("Your favourite colour is " + colour);
            //Console.ReadLine();

            //Qn. 3
            /*Console.WriteLine("Input numbers");
            string num1=Console.ReadLine();
            string num2=Console.ReadLine();
            double n1 = Convert.ToInt32(num1);
            double n2 = Convert.ToInt32(num2);
            double sum = n1 + n2;
            double diff = n1 - n2;
            double mult = n1 * n2;
            int flag = 0;
            double div = 0;
            if (n2==0)
            {
                flag = 1;
                Console.WriteLine("Not possible");
            }
            else
            {
                div = n1 / n2;
            }
            Console.WriteLine($"Sum is {sum},diff is {diff}, mult is {mult}");
            if (flag == 1)
            {
                Console.WriteLine("No answer");
            }
            else
            {
                Console.WriteLine($"Div is {div}");
            }
            Console.ReadLine(); */

            //Qn. 4
            //Console.WriteLine("Input temp in Celsius");
            //string cel = Console.ReadLine();
            //int Celsius = Convert.ToInt32(cel);
            //int Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine($"Temp in Fahrenheit is {Fahrenheit}");
            //Console.ReadLine();

            //Qn. 5
            /*Console.WriteLine("Input principal amount");
            string PA= Console.ReadLine();
            int P = Convert.ToInt32(PA);
            Console.WriteLine("Input Rate of Interest");
            string RI = Console.ReadLine();
            int R = Convert.ToInt32(RI);
            Console.WriteLine("Input time invested");
            string TI = Console.ReadLine();
            int T = Convert.ToInt32(TI);
            int SI = (P * R * T) / 100;
            Console.WriteLine($"Simple Interest is {SI}");
            Console.ReadLine();*/

            //Qn. 6
            //Console.WriteLine("Input the radius of the circle");
            //string r = Console.ReadLine();
            //int R = Convert.ToInt32(r);
            //double area = 3.14159 * R * R;
            //Console.WriteLine($"Area is {area}");
            //Console.ReadLine();

            //Qn. 7
            /*Console.WriteLine("Input no. of seconds");
            int sec = Convert.ToInt32(Console.ReadLine());
            int hrs = sec / 3600;
            sec = sec % 3600;
            int min = sec / 60;
            sec = sec % 60;
            Console.WriteLine($"Time in hrs, min and sec is {hrs} hrs, {min} mins and {sec} secs");
            Console.ReadLine();*/

            //Qn. 8
            //Console.WriteLine("Input String");
            //string input = Console.ReadLine();
            //string trimmedinput = input.Replace(" ", "");
            //int length = trimmedinput.Length;
            //Console.WriteLine("No. of characters is:");
            //Console.WriteLine(length);
            //Console.ReadLine();

            //Qn. 9
            /*Console.WriteLine("Input height in metres");
            double height = Double.Parse(Console.ReadLine()); //input height
            Console.WriteLine("Input weight");
            double weight = Double.Parse(Console.ReadLine()); //input weight
            double BMI = weight/(height*height); // finds BMI
            Console.WriteLine("Your BMI is: " + BMI);
            Console.ReadLine();*/

            //Qn. 10
            /*int num = 1;
            float floatingNum = 3.0f;
            double doubleNum = 4.55;
            char character = 'v';
            string myString = "Aleesha";
            bool myBool = false;
            Console.WriteLine($"{num} is an integer, {floatingNum} is a float,{doubleNum} is a double, {character} is a character, {myString} is a string and {myBool} is a boolean");
            //outputs with type
            Console.ReadLine();*/

            //Qn. 11
            /*const double PI = 3.14159;
            Console.WriteLine("Input radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input length and breadth");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            double areaCircle = PI * radius * radius; //finds area of circle
            int areaRectangle = length * breadth; // finds area of rectangle
            Console.WriteLine($"Area of circle is {areaCircle} and area of rectangle is {areaRectangle}");
            Console.ReadLine();*/

            //Qn. 12
            //const double PI = 3.14159; // initializes pi value
            //const int DAYS_IN_WEEK = 7; // initializes days in week
            //Console.WriteLine("Input radius");
            //int radius = Convert.ToInt32(Console.ReadLine()); //inputs radius
            //double circumference=2*PI*radius; //finds circumference
            //Console.WriteLine($"Circumference is {circumference} and days in a week is {DAYS_IN_WEEK}");
            //// outputs result and days in week
            //Console.ReadLine();

            //Qn. 13
            /*const double CONVERT_METRES_TO_INCHES = 39.3701; // initializes conversion factor to inch
            const double CONVERT_METRES_TO_CENTIMETRES = 100; // initializes conversion factor to centimetres
            Console.WriteLine("Input width and length in metres");
            int width = Convert.ToInt32(Console.ReadLine()); // inputs width
            int length = Convert.ToInt32(Console.ReadLine()); // inputs length
            int area = width * length; // finds area in square metres
            double areaInches = area*CONVERT_METRES_TO_INCHES*CONVERT_METRES_TO_INCHES; // area in square inches
            double areaCentimetres = area*CONVERT_METRES_TO_CENTIMETRES*CONVERT_METRES_TO_CENTIMETRES; // area in square centimetres
            Console.WriteLine($"Area of rectangle is {areaInches} in square inches and {areaCentimetres} in square centimetres"); // result
            Console.ReadLine();*/

            //Qn. 14
            /*Console.WriteLine("Enter your name");
            string employeeName = Console.ReadLine(); // gets employee's name
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine(); // gets age of the employee
            Console.WriteLine("Enter your salary");
            string salary = Console.ReadLine(); // gets monthly salary of the employee
            Console.WriteLine($"Employee Name: {employeeName}\nAge: {age}\nMonthly Salary: Rs.{salary}"); // outputs data
            Console.ReadLine();*/

            //Qn. 15
            //int firstNumber = 5; // initializes first number
            //int secondNumber = 3; // initializes second number
            //int sum = firstNumber + secondNumber;   //finds sum of the numbers
            //Console.WriteLine($"Sum of the two numbers is: {sum}"); //outputs the result
            //Console.ReadLine();

            //Qn. 16
            //int firstNumber = 1; //assigns first number
            //int secondNumber = 13; //assigns second number
            //int sum = firstNumber + secondNumber; // finds sum
            //Console.WriteLine($"Sum of the two numbers is: {sum}"); // outputs result
            //Console.ReadLine();

            //Qn. 17
            //Console.WriteLine("Input base value");
            //int baseValue = Convert.ToInt32(Console.ReadLine()); //inputs base value
            //Console.WriteLine("Input exponent value");
            //int exponentValue = Convert.ToInt32(Console.ReadLine()); // inputs exponent value
            //double power = Math.Pow(baseValue, exponentValue); // calculates power
            //Console.WriteLine("Power of the number is: " + power); // outputs results
            //Console.ReadLine();

            //Qn. 18
            /*Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine()); // gets age
            Console.WriteLine("Enter your citizenship");
            string citizenship = Console.ReadLine(); //gets citizenship
            // checks eligibility
            if ((age>18) && (citizenship.ToLower()== "indian") )
            {
                Console.WriteLine("You are eligible to vote."); // outputs if eligible
            }
            else
            {
                Console.WriteLine("You are not eligible to vote."); // outputs if not eligible
            }
            Console.ReadLine();*/

            //Qn. 19
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());//gets age
            //Console.WriteLine("Enter your annual salary in dollars");
            //int salary = Convert.ToInt32(Console.ReadLine()); //gets salary in dollars
            //Console.WriteLine("Do you have any outstanding loans?");
            //string loanStatus = Console.ReadLine(); //gets loan status
            ////checks for eligibilty
            //if ((age>=21)&&(salary>=30000)&&(loanStatus.ToLower() !="yes"))
            //{
            //    Console.WriteLine("You are eligible for a loan."); // outputs if eligible
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan."); //outputs if not eligible
            //}
            //Console.ReadLine();

            //Qn.2o
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine()); //gets age
            //Console.WriteLine("Enter your years of experience");
            //int experience = Convert.ToInt32(Console.ReadLine()); //gets years of experience
            //Console.WriteLine("Do you have a college degree");
            //string degree = Console.ReadLine(); //gets degree status
            ////checks eligibility
            //if (((age >= 18) && (age <= 35)) && (experience >= 2) && ((degree.ToLower() == "yes") || (experience >= 5)))
            //{
            //    Console.WriteLine("You are eligible to apply for this job"); //outputs if eligible
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to apply for this job"); //outputs if not eligible
            //}
            //Console.ReadLine();

            //Qn.21
            //Console.WriteLine("Enter a character");
            //string myCharacter = Console.ReadLine(); //gets character 
            //// checks if vowel or consonant
            //if (myCharacter.ToLower() == "a" || myCharacter.ToLower() == "e" || myCharacter.ToLower() == "i" || myCharacter.ToLower() == "o" || myCharacter.ToLower() == "u")
            //{
            //    Console.WriteLine("The character entered is a vowel"); //outputs if vowel
            //}
            //else
            //{
            //    Console.WriteLine("The character entered is a consonant"); //outputs if consonant
            //}
            //Console.ReadLine();

            //Qn.22
            //Console.WriteLine("Enter a number");
            //int myNumber = Convert.ToInt32(Console.ReadLine()); //gets number
            ////Checks if positive, negative or zero
            //if (myNumber < 0)
            //{
            //    Console.WriteLine("The number entered is negative"); //outputs if negative
            //}
            //else if (myNumber > 0)
            //{
            //    Console.WriteLine("The number entered is positive"); //outputs if positive
            //}
            //else
            //{
            //    Console.WriteLine("The number entered is zero"); //outputs if the number is zero
            //}
            //Console.ReadLine();

            //Qn. 23
            //Console.WriteLine("Enter a number");
            //int myNumber = Convert.ToInt32(Console.ReadLine()); //gets number
            ////checks divisibility by 5 and 11
            //if (myNumber % 5 == 0 && myNumber % 11 == 0)
            //{
            //    Console.WriteLine("The entered number is divisible by both 5 and 11.");
            //}
            //else
            //{
            //    Console.WriteLine("The entered number is not divisible by both 5 and 11.");
            //}
            //Console.ReadLine();

            //Qn. 24
            /*Console.WriteLine("Enter two numbers:");
            int firstNumber = Convert.ToInt32(Console.ReadLine()); //gets first number
            int secondNumber = Convert.ToInt32(Console.ReadLine()); //gets second number
            Console.WriteLine("Enter operator"); 
            string myOperator = Console.ReadLine(); //gets operator
            //checks and outputs result 
            if (myOperator == "+")
            {
                int sum = firstNumber + secondNumber;
                Console.WriteLine("Sum is: " + sum);
            }
            else if (myOperator == "-")
            {
                int difference = firstNumber - secondNumber;
                Console.WriteLine("Difference is: "+difference);
            }
            else if (myOperator == "*")
            {
                int product = firstNumber * secondNumber;
                Console.WriteLine("Product is: "+product);
            }
            else if (myOperator == "/")
            {
                int quotient = firstNumber / secondNumber;
                Console.WriteLine("Quotient is: "+quotient);
            }
            Console.ReadLine(); */

            //Qn. 25
            /*Console.WriteLine("Enter your marks out of 100");
            int marks = Convert.ToInt32(Console.ReadLine()); //gets marks
            //checks grade
            if (marks>=90)
            {
                Console.WriteLine("Congrats, you got an A grade"); //outputs if A grade
            }
            else if (marks>=80)
            {
                Console.WriteLine("Congrats, you got a B grade"); //outputs if B grade
            }
            else if (marks>=70)
            {
                Console.WriteLine("Good, you got a C grade"); //outputs if C grade
            }
            else if (marks>=60)
            {
                Console.WriteLine("You got a D grade"); //outputs if D grade
            }
            else
            {
                Console.WriteLine("Sorry, you got an F grade"); //outputs if F grade
            }
            Console.ReadLine();*/

            //Qn. 26
            /*Console.WriteLine("Enter value of A");
             int A = Convert.ToInt32(Console.ReadLine()); //gets A
             Console.WriteLine("Enter value of B");
             int B = Convert.ToInt32(Console.ReadLine()); // gets B
             int myVariable = A;
             A = B;
             B = myVariable;
             //swapping
             Console.WriteLine($"First swaped values are A = {A} and B = {B}"); //prints swapped values
             Console.WriteLine("Enter value of X");
             int X = Convert.ToInt32(Console.ReadLine()); //gets X
             Console.WriteLine("Enter value of Y");
             int Y = Convert.ToInt32(Console.ReadLine()); //gets Y
             int sum = X + Y;
             Y = sum - Y;
             X = sum - X;
             Console.WriteLine($"Second swaped values are X = {X} and Y = {Y}"); //prints swapped values
             Console.ReadLine(); */

            //Qn. 27
            /*Console.WriteLine("Enter two numbers");
            int firstNumber = Convert.ToInt32(Console.ReadLine()); //gets first number
            int secondNumber = Convert.ToInt32(Console.ReadLine()); //gets second number
            //checks if second number greater than zero and finds results
            if (secondNumber != 0)
            {
                int sum = firstNumber + secondNumber; //finds sum
                int difference = firstNumber - secondNumber; //finds difference
                int product = firstNumber * secondNumber; //finds product
                int quotient = firstNumber / secondNumber; //finds quotient
                int remainder = firstNumber % secondNumber; //finds remainder
                int increment_first_number = ++firstNumber; //finds increment value of first number
                int increment_second_number = ++secondNumber; //finds increment value of second number
                int decrement_first_number = firstNumber--; //finds decrement value of first number
                int decrement_second_number = secondNumber--; //finds decrement value of second number
                Console.WriteLine($"Sum is: {sum}, difference is: {difference}, product is: {product}, quotient is: {quotient}, remainder is: {remainder}, incremented values are: {increment_first_number} and {increment_second_number} and decremented values are {decrement_first_number} and {decrement_second_number}");
            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }
            Console.ReadLine();*/

            //Qn. 28
            //Console.WriteLine("Enter three numbers");
            //double firstNumber = Convert.ToInt32(Console.ReadLine());
            //double secondNumber = Convert.ToInt32(Console.ReadLine());
            //double thirdNumber = Convert.ToInt32(Console.ReadLine());
            ////gets three numbers
            //double average = Math.Round(((firstNumber + secondNumber + thirdNumber) / 3), 2); //finds average
            //Console.WriteLine("Average of the numbers with two decimal point is: " + average); //outputs result
            //Console.ReadLine();

            //Qn. 29
            //const double USD_TO_EUR = 0.85;
            //Console.WriteLine("Input amount in USD");
            //double currencyUSD = Convert.ToInt32(Console.ReadLine()); //gets amount in USD
            //double currencyEUR = currencyUSD * USD_TO_EUR; //convert to euros
            //Console.WriteLine("Amount in EUR is: " + currencyEUR); //outputs amount in euros
            //Console.ReadLine();

            //Qn. 30
            /*Console.WriteLine("Enter a number");
            int myNumber = Convert.ToInt32(Console.ReadLine()); //gets number
            // checks if within range
            if (myNumber > 1 && myNumber < 100)
            {
                Console.WriteLine("Entered number is between 1 and 100");
            }
            else
            {
                Console.WriteLine("Entered number is not between 1 and 100");
            }
            // checks if odd or even
            if (myNumber%2==0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
            }
            Console.ReadLine(); */

            //Qn. 31
            //Console.WriteLine("Enter a number");
            //int myNumber = Convert.ToInt32(Console.ReadLine()); //gets number
            ////checks divisibility by 3 and 5
            //if (myNumber % 3 == 0 && myNumber % 5 == 0)
            //{
            //    Console.WriteLine("The entered number is divisible by both 3 and 5.");
            //}
            //else
            //{
            //    Console.WriteLine("The entered number is not divisible by both 3 and 5.");
            //}
            //Console.ReadLine();

            //Qn. 32
            //Console.WriteLine("Enter an year");
            //int year = Convert.ToInt32(Console.ReadLine()); //gets year
            ////checks if leap year
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine("The entered year is a leap year."); //outputs if leap year
            //}
            //else
            //{
            //    Console.WriteLine("The entered year is not a leap year."); //outputs if not leap year
            //}
            //Console.ReadLine();

            //Qn. 33
            /*Console.WriteLine("Enter a number");
            int myNumber = Convert.ToInt32(Console.ReadLine()); //gets number
            //Checks if positive, negative or zero
            if (myNumber < 0)
            {
                Console.WriteLine("The number entered is negative"); //outputs if negative
            }
            else if (myNumber > 0)
            {
                Console.WriteLine("The number entered is positive"); //outputs if positive
            }
            else
            {
                Console.WriteLine("The number entered is zero"); //outputs if the number is zero
            }
            //checks if even or odd
            if (myNumber%2==0)
            {
                Console.WriteLine("The number entered is even"); //outputs if even
            }
            else
            {
                Console.WriteLine("The number entered is odd"); //outputs if odd
            }
            //checks if greater than 50
            if (myNumber > 50)
            {
                Console.WriteLine("The number entered is greater than 50"); //outputs if greater than 50
            }
            else
            {
                Console.WriteLine("The number entered is less than 50"); //outputs if the number is less than 50
            }
            Console.ReadLine(); */

            //Qn. 34
            //Console.WriteLine("Input marks of three subjects each out of 100");
            ////inputs marks
            //int firstMarks = Convert.ToInt32(Console.ReadLine());
            //int secondMarks = Convert.ToInt32(Console.ReadLine());
            //int thirdMarks = Convert.ToInt32(Console.ReadLine());
            //int[] marks = { firstMarks, secondMarks, thirdMarks };
            ////checks if passed in all subjects
            //if (marks[0] >= 40 && marks[1] >= 40 && marks[2] >= 40)
            //{
            //    Console.WriteLine("Congrats, you have passed in all subjects.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you haven't passed in all subjects.");
            //}
            ////checks if distinction
            //if ((marks[0] + marks[1] + marks[2]) / 3 >= 70)
            //{
            //    Console.WriteLine("Great, you have scored distinction");
            //}
            ////checks no. of failed subjects
            //int number_of_failed = 0;
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    if (marks[i] < 40)
            //    {
            //        number_of_failed++;
            //    }
            //}
            //Console.WriteLine("No. of failed subjects is: " + number_of_failed);
            //Console.ReadLine();

            //Qn. 35
            /*Console.WriteLine("Enter your annual salary");
            double salary = Convert.ToInt32(Console.ReadLine()); //gets salary
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine()); //gets age

            if (salary < 10000)
            {
                Console.WriteLine("No tax to be paid"); //outputs if salary less than 10000
            }
            else if (((salary >= 10000) && (salary <= 50000)) && (age < 60))
            {
                double tax1 = 0.1 * salary;
                Console.WriteLine("Tax to be paid is: " + tax1); //outputs if salary greater than 10000 and less than 50000
            }
            else if((salary > 50000) && (age < 60))
            {
                double tax2 = 0.2 * salary;
                Console.WriteLine("Tax to be paid is: " + tax2); //outputs if salary greater than 50000
            }
            else if (((salary >= 10000) && (salary <= 50000)) && (age >= 60))
            {
                double tax3 = (0.1 * salary) - 5000;
                Console.WriteLine("Tax to be paid is: " + tax3); //outputs if salary greater than 10000 and less than 50000 and age greater than or equal to 60
            }
            else if ((salary > 50000) && (age >= 60))
            {
                double tax4 = (0.2 * salary) - 5000;
                Console.WriteLine("Tax to be paid is: " + tax4); //outputs if salary greater than 50000 and age greater than or equal to 60
            }
            Console.ReadLine(); */
        
    }
}
