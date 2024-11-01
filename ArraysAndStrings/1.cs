using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Matrix
    {
        public static int[,] GetMatrix(int[,] matrix, int rows, int columns)
        {
            Console.WriteLine("Enter elements");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix; 
        }
        //Gets matrix from user.
        public static void DisplayMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //Displays matrix.
        public static int[,] FindSum(int[,] sumMatrix, int[,] firstMatrix, int[,] secondMatrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            return sumMatrix;
        }
        //Finds sum of matrices.
        public static int[,] FindProduct(int[,] productMatrix, int[,] firstMatrix, int[,] secondMatrix, 
                                          int rows, int columns_Second, int columns_First)
        {
            int temp = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns_Second; j++)
                {
                    for (int k = 0; k < columns_First; k++)
                    {
                        temp = temp + firstMatrix[i, k] * secondMatrix[k, j];
                    }
                    productMatrix[i, j] = temp;
                    temp = 0;
                }
            }
            return productMatrix;
        }
        //Finds product of matrices.
        public static int[,] FindTranspose(int[,] transposeMatrix, int[,] firstMatrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposeMatrix[j, i] = firstMatrix[i, j];
                }
            }
            return transposeMatrix;
        }
        //Finds transpose matrix.
    }
}
