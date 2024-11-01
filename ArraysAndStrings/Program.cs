using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Array Manipulations
            ////Assignment 1.Write C# programs on Matrix addition, Matrix Multiplication and Matrix Transpose. 

            Console.WriteLine("Enter 1 for addition, 2 for multiplication, 3 for transpose");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no. of rows of first matrix");
            int rows_firstMatrix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no. of columns of first matrix");
            int columns_firstMatrix = Convert.ToInt32(Console.ReadLine());
            int[,] firstMatrix = new int[rows_firstMatrix, columns_firstMatrix];
            int[,] secondMatrix = null;
            Console.WriteLine("Enter elements");
            for (int i = 0; i < rows_firstMatrix; i++)
            {
                for (int j = 0; j < columns_firstMatrix; j++)
                {
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (choice != 3)
            {
            Label1: Console.WriteLine("Enter no. of rows of second matrix");
                int rows_secondMatrix = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no. of columns of second matrix");
                int columns_secondMatrix = Convert.ToInt32(Console.ReadLine());

                if (choice == 1 && (rows_firstMatrix != rows_secondMatrix || columns_secondMatrix != columns_firstMatrix))
                {
                    Console.WriteLine("Invalid rows or columns\n");
                    goto Label1;
                }
                else if (choice == 2 && (columns_firstMatrix != rows_secondMatrix))
                {
                    Console.WriteLine("Invalid rows or columns\n");
                    goto Label1;
                }
                
                else
                {
                    secondMatrix = new int[rows_secondMatrix, columns_secondMatrix];
                    Console.WriteLine("Enter elements");
                    for (int i = 0; i < rows_secondMatrix; i++)
                    {
                        for (int j = 0; j < columns_secondMatrix; j++)
                        {
                            secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }

                if (choice == 1)
                {
                    Console.WriteLine("Sum:");
                    int[,] sum = new int[rows_firstMatrix, columns_firstMatrix];
                    for (int i = 0; i < rows_firstMatrix; i++)
                    {
                        for (int j = 0; j < columns_firstMatrix; j++)
                        {
                            sum[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                        }
                    }

                    for (int i = 0; i < rows_firstMatrix; i++)
                    {
                        for (int j = 0; j < columns_firstMatrix; j++)
                        {
                            Console.Write($"{sum[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }

                if (choice == 2)
                {
                    Console.WriteLine("Product:");
                    int[,] product = new int[rows_firstMatrix, columns_secondMatrix];
                    int temp = 0;
                    for (int i = 0; i < rows_firstMatrix; i++)
                    {
                        for (int j = 0; j < columns_secondMatrix; j++)
                        {
                            for (int k = 0; k < columns_firstMatrix; k++)
                            {
                                temp = temp + firstMatrix[i, k] * secondMatrix[k, j];
                            }
                            product[i, j] = temp;
                            temp = 0;
                        }
                    }
                    for (int i = 0; i < rows_firstMatrix; i++)
                    {
                        for (int j = 0; j < columns_secondMatrix; j++)
                        {
                            Console.Write($"{product[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                int[,] transpose = new int[columns_firstMatrix,rows_firstMatrix];
                Console.WriteLine("Transpose is: ");
                for (int i = 0; i < rows_firstMatrix; i++)
                {
                    for (int j = 0; j < columns_firstMatrix; j++)
                    {
                        transpose[j, i] = firstMatrix[i,j];
                    }
                }

                for (int i = 0; i < columns_firstMatrix; i++)
                {
                    for (int j = 0; j < rows_firstMatrix; j++)
                    {
                        Console.Write($"{transpose[i, j]} ");
                    }
                    Console.WriteLine();
                }

            }

            Console.ReadLine();
        }
    }
}
