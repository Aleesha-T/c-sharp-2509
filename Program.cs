using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter numbers:");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string c = Console.ReadLine();
            //    int num1=Convert.ToInt32(a);
            //    int num2 = Convert.ToInt32(b);
            //    int num3 = Convert.ToInt32(c);
            //    if (num1 >= num2)
            //    {
            //        if (num1 >= num3)
            //        {
            //            Console.WriteLine("greater is:"+num1);
            //        }
            //        else
            //        {
            //            Console.WriteLine("greater is:" +num3);
            //        }
            //    }
            //    else
            //    {
            //        if (num2 >= num3)
            //        {
            //            Console.WriteLine("greater is" +num2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("greater is"+num3);
            //        }
            //    }
            //Console.ReadLine();


            //int i=1;
            //for (int j = 0; j < 6; j++)
            //{
            //    Console.WriteLine(i);
            //    i = i + 2;
            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <=i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //int sum = 0;
            //for (int i = 1; i < 6; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("Sum of first five natural numbers is: " + sum);
            //Console.ReadLine();

            //for (int i = 10; i <= 1000; i+=20)
            //{
            //    if (i%20==0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    if (i == 190)
            //    {
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //Console.WriteLine("Input a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int flag = 0;
            //if (number % 2 == 0)
            //{
            //    flag = 1;
            //}

            //switch (flag)
            //{
            //    case 0:
            //        Console.WriteLine("Odd");
            //        break;
            //    case 1:
            //        Console.WriteLine("Even");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            //Console.ReadLine();

            //int[] number = { 1, 2, 3 };
            //for (int i = 0; i <number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //Console.ReadLine();

            Console.WriteLine("Enter rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            int totalSpace = rows + 5;
            int i = 0;
            for (int j = 0; j < rows; j++)
            {
                for (int l = totalSpace; l >= 1; l--)
                {
                    Console.Write(" ");
                }
                
                
                
                for (int k = 0; k <= j; k++)
                {
                     Console.Write($"{i + 1} ");
                     i++;
                }
                Console.WriteLine();
                totalSpace--;
            }
            Console.ReadLine();








        }
    }
}
