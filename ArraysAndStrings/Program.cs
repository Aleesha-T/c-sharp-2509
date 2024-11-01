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

            //Console.WriteLine("Enter 1 for addition, 2 for multiplication, 3 for transpose");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter no. of rows of first matrix");
            //int rows_firstMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter no. of columns of first matrix");
            //int columns_firstMatrix = Convert.ToInt32(Console.ReadLine());
            ////Gets rows and columns.
            //int[,] firstMatrix = new int[rows_firstMatrix, columns_firstMatrix];
            //int[,] secondMatrix = null;
           
            //firstMatrix=Matrix.GetMatrix(firstMatrix, rows_firstMatrix, columns_firstMatrix);
            ////Gets matrix.

            //Console.WriteLine("The entered matrix is: ");
            //Matrix.DisplayMatrix(firstMatrix, rows_firstMatrix, columns_firstMatrix);
            ////Displays entered matrix.

            //if (choice != 3)
            //{
            //Label1: Console.WriteLine("Enter no. of rows of second matrix");
            //    int rows_secondMatrix = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter no. of columns of second matrix");
            //    int columns_secondMatrix = Convert.ToInt32(Console.ReadLine());
            //    //Gets rows and columns.

            //    if (choice == 1 && (rows_firstMatrix != rows_secondMatrix || columns_secondMatrix != columns_firstMatrix))
            //    {
            //        Console.WriteLine("Invalid rows or columns\n");
            //        goto Label1;
            //    }
            //    //Validation for addition.
            //    else if (choice == 2 && (columns_firstMatrix != rows_secondMatrix))
            //    {
            //        Console.WriteLine("Invalid rows or columns\n");
            //        goto Label1;
            //    }   
            //    //Validation for multiplication
            //    else
            //    {
            //        secondMatrix = new int[rows_secondMatrix, columns_secondMatrix];                    
            //        secondMatrix = Matrix.GetMatrix(secondMatrix, rows_secondMatrix, columns_secondMatrix);
            //        //Gets matrix.
            //        Console.WriteLine("Entered matrix is: ");                    
            //        Matrix.DisplayMatrix(secondMatrix, rows_secondMatrix, columns_secondMatrix);
            //        //Displays entered matrix.
            //    }

            //    if (choice == 1)
            //    {
            //        int[,] sum = new int[rows_firstMatrix, columns_firstMatrix];
            //        sum = Matrix.FindSum(sum, firstMatrix, secondMatrix, rows_firstMatrix, columns_firstMatrix);
            //        //Performs addition.
            //        Console.WriteLine("Sum:");                    
            //        Matrix.DisplayMatrix(sum, rows_firstMatrix, columns_firstMatrix);
            //        //Displays sum.
            //    }

            //    if (choice == 2)
            //    {
            //        int[,] product = new int[rows_firstMatrix, columns_secondMatrix];
            //        product = Matrix.FindProduct(product, firstMatrix, secondMatrix, rows_firstMatrix,
            //                                     columns_secondMatrix, columns_firstMatrix);
            //        //Performs multiplication.
            //        Console.WriteLine("Product:");                    
            //        Matrix.DisplayMatrix(product, rows_firstMatrix, columns_secondMatrix);
            //        //Displays product.
            //    }
            //}
            //else
            //{
            //    int[,] transpose = new int[columns_firstMatrix,rows_firstMatrix];
            //    Matrix.FindTranspose(transpose, firstMatrix, rows_firstMatrix, columns_firstMatrix);
            //    //Finds transpose.
            //    Console.WriteLine("Transpose is: ");                
            //    Matrix.DisplayMatrix(transpose, columns_firstMatrix, rows_firstMatrix);
            //    //Displays transpose.
            //}

            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

        }
    }
}
