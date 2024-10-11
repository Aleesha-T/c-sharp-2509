using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Assignment
    {

        //Qn. 1 Multiplication table of a given number
        //Console.WriteLine("Enter a number"); //gets number
        //int number = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i <= 10; i++)
        //{
        //    int product = i * number; //finds product
        //    Console.WriteLine($"{i}*{number}={product}"); //outputs table
        //}
        //Console.ReadLine();

        //Qn. 2 Display a right-angled triangle
        //Console.WriteLine("Enter number of rows");
        //int rows = Convert.ToInt32(Console.ReadLine()); //gets no. of rows
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        //Qn. 3 Sum of all even numbers between 1 and 100 
        //int i = 0;
        //int sum = 0;
        //while (i <= 100)
        //{
        //checks if even
        //    if ((i % 2) == 0) 
        //    {
        //        sum = sum + i;
        //    }
        //    i++;
        //}
        //Console.WriteLine($"Sum of even nos. till 100 is: {sum}"); //outputs sum
        //Console.ReadLine();

        //Qn. 4 Multiplication table from 1 to 5
        //for (int j = 1; j <= 5; j++)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        int product = i * j;
        //        Console.WriteLine($"{i}*{j}={product}");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        //Qn. 5  Print Positive Number 
        //label:  Console.WriteLine("Enter a positive number");
        //int number = Convert.ToInt32(Console.ReadLine()); //reads number
        //if(number>0)
        //{
        //    Console.WriteLine("Entered number is: " + number); //outputs if positive
        //    goto label;
        //}
        //else if (number==0)
        //{
        //    Console.WriteLine("You entered zero"); //outputs if zero
        //    goto label;
        //}
        //else
        //{
        //    Console.WriteLine("You entered a negative number"); //outputs if negative
        //    return;
        //}

        //Qn. 6 Create Menu Driven Calculator
        /* Label: Console.WriteLine("Do you wish to use the calculator?");
             string userWish = Console.ReadLine();
             if (userWish.ToLower() == "yes")
             {

                 Console.WriteLine("Enter two numbers");
                 int number1 = Convert.ToInt32(Console.ReadLine()); //gets first number
                 int number2 = Convert.ToInt32(Console.ReadLine()); //gets second number
                 Console.WriteLine("Enter operator");
                 string myOperator = Console.ReadLine(); //gets operator
                 if (myOperator == "+")
                 {
                     int sum = number1 + number2;
                     Console.WriteLine("Sum is: " + sum); //prints sum
                     goto Label;
                 }
                 else if (myOperator == "-")
                 {
                     int difference = number1 - number2;
                     Console.WriteLine("Difference is: " + difference); //prints difference
                     goto Label;
                 }
                 else if (myOperator == "*")
                 {
                     int product = number1 * number2;
                     Console.WriteLine("Product is: " + product); //prints product
                     goto Label;
                 }
                 else if (myOperator=="/")
                 {
                     if (number2 == 0) //checks if denominator is zero
                     {
                         Console.Write("Division by zero is not possible");
                     }
                     else
                     {
                         int quotient = number1 / number2;
                         Console.WriteLine("Quotient is: " + quotient); //prints quotient
                         goto Label;
                     }
                 }
             } 
             else if (userWish.ToLower() == "no")
             {
                 return;
             } */

        //Qn. 7 Print All Numbers From 1 to 100
        //for (int i = 0; i <= 100; i++)
        //{
        //    if (i % 3 == 0) //checks if multiple of 3
        //    {
        //        continue;
        //    }
        //    if (i > 50)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        //Qn. 8 Sum of Odd Numbers 
        //int sum = 0;
        //for (int i = 1; i < 100; i += 2)
        //{
        //    sum = sum + i;
        //}
        //Console.WriteLine($"Sum of all odd numbers between 1 and 100 is {sum}.");
        //Console.ReadLine();

        //Qn. 9 Factorial Calculation 
        //Console.WriteLine("Enter a number:");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int i = 1;
        //int factorial = 1;
        //while(i<number+1)
        //{
        //   factorial = factorial * i;
        //    i++;
        //}
        //Console.WriteLine("Factorial is: "+factorial);
        //Console.ReadLine();

        //Qn. 10 Number Pyramid
        //Console.WriteLine("Enter no. of rows");
        //int rows = Convert.ToInt32(Console.ReadLine()); //gets no. of rows
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write(i + 1);
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        //Qn. 11 Guess the Number Game
        /* Label:  Console.WriteLine("Do you wanna play?");
         string userInput = Console.ReadLine();
         if (userInput.ToLower() == "yes")
         {
             int no_of_rounds = 4;
             do
             {
                 Console.WriteLine("Enter a number between 1 and 100");
                 int number = Convert.ToInt32(Console.ReadLine());
                 Random rnd = new Random();
                 int num = rnd.Next(1, 100);
                 if ((number - num) > 0)
                 {
                     Console.WriteLine("High"); //prints if value is greater
                     no_of_rounds--;
                 }
                 else if ((number - num) < 0)
                 {
                     Console.WriteLine("Low"); //prints if value is lesser
                     no_of_rounds--;
                 }
                 else if ((number - num) == 0)
                 {
                     Console.WriteLine("Hurray, you got it right"); //prints if value is equal
                     no_of_rounds--;
                 }

             }while (no_of_rounds > 0);
             goto Label;
         }
         else
         {
             return;
         }
         */
        //Qn. 12 Simple Calculator
        /*Label: Console.WriteLine("Do you wish to use the calculator?");
            string userWish = Console.ReadLine();
            if (userWish.ToLower() == "yes")
            {
                Console.WriteLine("Enter two numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication and 4 for division");
                int myOperator = Convert.ToInt32(Console.ReadLine());
                switch(myOperator)
                {
                    case 1: 
                    int sum = number1 + number2;
                    Console.WriteLine("Sum is: " + sum); //prints sum
                    goto Label;

                    case 2:
                    int difference = number1 - number2;
                    Console.WriteLine("Difference is: " + difference); //prints difference
                    goto Label;

                    case 3:
                    int product = number1 * number2;
                    Console.WriteLine("Product is: " + product); //prints product
                    goto Label;

                    case 4: 
                    if (number2 == 0) //checks if denominator is zero
                    { 
                        Console.Write("Division by zero is not possible");
                    }
                    else
                    {
                        int quotient = number1 / number2;
                        Console.WriteLine("Quotient is: " + quotient); //prints quotient
                        goto Label;
                    }
                    break;
                }
            }
            else if (userWish.ToLower() == "no")
            {
                return;
            } */

        //Qn. 13 Sum of Digits 
        //Console.WriteLine("Input a number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //do
        //{
        //    int remainder = number % 10;
        //    number = number / 10;
        //    sum += remainder;
        //} while (number > 0);
        //Console.WriteLine("Sum is: " + sum);
        //Console.ReadLine();

        //Qn. 14 Finding the Largest Number
        //int[] arr = new int [10];
        //Console.WriteLine("Enter 10 numbers: ");
        //for (int i = 0;i<10;i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int largest = 0;
        //for (int j = 0;j<10;j++)
        //{
        //    if (arr[j] > largest)
        //    {
        //        largest = arr[j];
        //    }
        //}
        //Console.WriteLine("Largest is: "+largest);
        //Console.ReadLine();

        //Qn. 15 Sum of Squares
        //Console.WriteLine("Enter a number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int i = 0;
        //int sum = 0;
        //while(i<number+1)
        //{
        //    sum = sum + i * i;
        //    i++;
        //}
        //Console.WriteLine("Sum is: " + sum);
        //Console.ReadLine();

        //Qn. 16 Countdown Timer

        //int count = 10;
        //do
        //{
        //    Console.WriteLine(count);
        //    count--;
        //    System.Threading.Thread.Sleep(1000);
        //}while (count > 0);
        //Console.WriteLine("Countdown complete!");
        //Console.ReadLine();


        // Qn. 17  Finding the First Multiple of 5 
        //int[] arr = new int[10];
        //Console.WriteLine("Enter total number");
        //int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter numbers");
        //for (int i=0;i<n;i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int j = 0; j < arr.Length; j++)
        //{
        //    if (arr[j] % 5 == 0) //checks if multiple of 5
        //    {
        //        Console.WriteLine("First multiple of 5 is " + arr[j]);
        //        break;
        //    }
        //}
        //Console.ReadLine();

        //Qn. 18 Print Non-Multiples of 3
        //for (int i = 0; i < 21; i++)
        //{
        //    if (i % 3 == 0) //checks if multiple of 3
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        //Qn. 19 Checking for Palindrome
        /*Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int n = num;
        int reverse = 0;
        while(n!=0)
        {
            reverse = (reverse*10)+(n%10);
            n = n / 10;
        }
        if ( num == reverse )
        {
            Console.WriteLine("It is a palindrome"); //prints if palindrome
        }
        else
        {
            Console.WriteLine("Not a palindrome"); //prints if not a palindrome
        } 
        Console.ReadLine(); */

        //Qn. 20 Average of Positive Numbers  
        /*Console.WriteLine("Enter number of nos. to find average");
        int totalNumber = Convert.ToInt32(Console.ReadLine());
        int n = totalNumber;
        Console.WriteLine("Enter positive numbers");
        int sum = 0;
        do
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(number<0)
            {
                return;
            }
            sum = sum + number;
            n--;
        } while (n > 0);
        int average = sum / totalNumber;
        Console.WriteLine("Average is: " + average); //prints average
        Console.ReadLine();*/

        //Qn. 21 Reverse a Number
        /*Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        int n = number;
        int reverse = 0;
        do
        {
            reverse = (reverse * 10) + (n % 10);
            n = n / 10;
        } while (n != 0);
        Console.WriteLine("Reverse is: " + reverse);
        Console.ReadLine();*/

        //Qn. 22 Menu-Driven String Operations 
        /* Console.WriteLine("Enter a string");
         string myString = Console.ReadLine();
         Console.WriteLine("Enter 1 for reversal \n2 for converting to upper case \n3 for converting to lower case \n4 for finding length of string");
         int option = Convert.ToInt32(Console.ReadLine());

         switch(option)
         {
             case 1:
                 string reverse = string.Empty;
                 for (int i = myString.Length - 1; i >= 0; i--)
                 {
                     reverse = reverse + myString[i];
                 }
                     Console.WriteLine("Reverse is: "+reverse); //prints reverse
                 break;
             case 2:
                 Console.WriteLine("String in uppercase is: "+myString.ToUpper()); //prints in uppercase
                 break;
             case 3:
                 Console.WriteLine("String in uppercase is: " + myString.ToLower()); //prints in lowercase
                 break;
             case 4:
                 Console.WriteLine("Length of string is: "+myString.Length); //prints length of string
                 break;
             default:
                 Console.WriteLine("Invalid option");
                 break;
         }
         Console.ReadLine(); */

        //Qn. 23 Skip Multiples of 4 
        //for (int i = 0; i <=50; i++)
        //{
        ////checks if multiple of 4
        //    if (i % 4 == 0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        //Qn. 24 Fibonacci Sequence
        //Console.WriteLine("Fibonacci Sequence is: ");
        //int[] arr = new int[10];
        //arr[0] = 0;
        //arr[1] = 1;
        //for (int i = 2; i < 10; i++)
        //{
        //    arr[i] = arr[i - 1] + arr[i - 2];
        //}
        //for (int j = 0; j < 10; j++)
        //{
        //    Console.WriteLine(arr[j]);
        //}
        //Console.ReadLine();

        //Qn. 25 Find All Armstrong Numbers  
        /* int num,a,b,c;
         Console.WriteLine("Armstrong numbers are");
         for(int i = 1;i<=500;i++)
         {
             num = i;
             a = num / 100;
             num = num % 100;
             b = num / 10;
             c = num % 10;

             if(i==a*a*a + b*b*b + c*c*c)
             {
                 Console.WriteLine(i);
             }
             else if(i==b*b + c*c)
             {
                 Console.WriteLine(i);
             }
             else if (i==c)
             {
                 Console.WriteLine(i);
             }
         }
         Console.ReadLine(); */

        //Qn. 26 Menu-Driven Number System Conversion
        /*Console.WriteLine("Enter 1 to convert binary to decimal \n2 to convert decimal to binary \n3 to convert decimal to hexadecimal");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Enter binary number");
                int binary = int.Parse(Console.ReadLine());
                int decimalNumber = 0;
                int base1 = 1;
                while (binary>0)
                {
                    int reminder = binary % 10;
                    binary = binary / 10;
                    decimalNumber += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.WriteLine("Decimal is: "+decimalNumber); //prints decimal
                break;

            case 2:
                Console.WriteLine("Enter decimal number");
                int decimalInput = Convert.ToInt32(Console.ReadLine());
                int[] binaryArray = new int[32];
                int i = 0;
                while (decimalInput > 0)
                {
                    binaryArray[i] = decimalInput % 2;
                    decimalInput = decimalInput / 2;
                    i++;
                }
                Console.Write("Binary number is: ");
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write(binaryArray[j]);
                }
                break;
            case 3:
                Console.WriteLine("Enter decimal number");
                int decimalValue = Convert.ToInt32(Console.ReadLine());
                int[] hexadecimalArray = new int[32];
                int l = 0;
                while (decimalValue > 0)
                {
                    hexadecimalArray[l] = decimalValue % 16;
                    decimalValue = decimalValue / 16;
                    l++;
                }
                Console.Write("Hexadecimal number is: ");
                for (int k = l - 1; k >= 0; k--)
                {
                    if (hexadecimalArray[k] < 10)
                        hexadecimalArray[k] = hexadecimalArray[k] + 48;  // For digits less than 10, adding ASCII value of '0'
                    else
                        hexadecimalArray[k] = hexadecimalArray[k] + 55;  // For digits greater than 9, adding ASCII value of 'A'
                    Console.Write("{0}", (char)hexadecimalArray[k]); //prints hexadecimal
                }
                break;
        }
        Console.ReadLine(); */

        //Qn. 27 Reverse a String
        //Console.WriteLine("Enter a string");
        //string myString = Console.ReadLine();
        //Console.WriteLine("Reversed string is:");
        //for (int i = myString.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(myString[i]);
        //}
        //Console.ReadLine();

        //Qn. 28 Count Vowels and Consonants in a String 
        /*Console.WriteLine("Enter a string");
        string myString = Console.ReadLine();
        int count = 0; int countConsonants = 0;
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'a' || myString[i] == 'A' || myString[i] == 'e' || myString[i] == 'E' || myString[i] == 'i' || myString[i] == 'I' || myString[i] == 'o' || myString[i] == 'O' || myString[i] == 'u' || myString[i] == 'U')
            {
                count++;
            }
            else if (myString[i] != ' ')
            {
                countConsonants++;
            }
        }
        Console.WriteLine($"No. of vowels is {count} and no. of consonants is {countConsonants}");
        Console.ReadLine(); */

        //Qn. 29 Find Maximum and Minimum  
        /*Console.WriteLine("Enter five numbers");
        int[] arr = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        int min = arr[0];
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] > max)
            {
                max = arr[j];
            }
            if (arr[j] < min)
            {
                min = arr[j];
            }
        }
        Console.WriteLine($"Maximum value is {max} and minimum value is {min}.");
        Console.ReadLine(); */

        //Qn. 30 Count Digits of a Number  
        Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
        int n = number; int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
        Console.WriteLine("No. of digits is: " + count); //prints no. of digits
            Console.ReadLine();

    }
}
