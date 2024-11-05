using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            //firstMatrix = Matrix.GetMatrix(firstMatrix, rows_firstMatrix, columns_firstMatrix);
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
            //    int[,] transpose = new int[columns_firstMatrix, rows_firstMatrix];
            //    Matrix.FindTranspose(transpose, firstMatrix, rows_firstMatrix, columns_firstMatrix);
            //    //Finds transpose.
            //    Console.WriteLine("Transpose is: ");
            //    Matrix.DisplayMatrix(transpose, columns_firstMatrix, rows_firstMatrix);
            //    //Displays transpose.
            //}

            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 2. Write C# programs to sort an array using bubble sort and insertion sort. 

            //int[] myArray = { 5, 8, 3, 4, 9, 3, 7 };
            //int[] mySecondArray = { 7, 5, 6, 4, 9, 3, 2 };
            //Sort.BubbleSort(myArray);
            ////Bubble sort.
            //Console.WriteLine("Sorted array using bubble sort is:");
            //Sort.Display(myArray);
            ////Displays sorted array.
            //Sort.InsertionSort(mySecondArray);
            ////Insertion sort.
            //Console.WriteLine("\nSorted array using insertion sort is:");
            //Sort.Display(mySecondArray);
            ////Displays sorted array.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 3. Write C# programs to search an array using linear search and binary search.

            //string[] myString = { "apple", "orange", "grapes", "pomengranate", "avocado", "kiwi" };
            //int[] myArray = { 22, 8, 4, 11, 6, 9, 7, 6, 54, 35, 74, 36, 97, 84, 1 };
            //Console.WriteLine("Enter a fruit to search.");
            //var fruit = Console.ReadLine();
            //Search.LinearSearch(fruit, myString);
            ////Linear Search.
            //Console.WriteLine("Enter a number to search.");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int index = Search.BinarySearch(number, myArray);
            ////Binary Search.
            //if (index == -1)
            //{
            //    Console.WriteLine("Entered number not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered number, {number} found at index: {index}");
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 4. Array Calculations: write C# programs for finding median, mode value, 
            ////highest, second highest and duplicate elements in an array.

            //int[] myNumbers = { 89, 5, 47, 55, 32, 4, 6, 47, 5, 1, 3, 3, 5, 4, 9, 21 };
            //Calculations.DisplaySorted(myNumbers);
            //double median = Calculations.Median(myNumbers);
            ////Gets median.
            //Console.WriteLine($"\nMedian is: {median}");
            //int mode = Calculations.Mode(myNumbers);
            ////Gets mode.
            //Console.WriteLine($"Mode is: {mode}");
            //Calculations.Largest(myNumbers);
            ////Gets largest and second largest values.
            //Calculations.Duplicates(myNumbers);
            ////Gets duplicate values.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////String Manipulations 
            ////Assignment 5.Write a C# programs to count vowels, consonants and special characters.

            //Console.WriteLine("Enter something.");
            //string enteredString = Console.ReadLine();
            //enteredString = enteredString.ToLower();
            //Count.CountCharacters(enteredString);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 6. Write a C# program to reverse a string. 

            //Console.WriteLine("Enter a string.");
            //string enteredValue = Console.ReadLine();
            //String.Reverse(enteredValue);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 7. Write a C# program to find substring occurrence within a main string. 

            //Console.WriteLine("Enter a string.");
            //string enteredString = Console.ReadLine();
            //Console.WriteLine("Enter substring");
            //string subString = Console.ReadLine();
            //SubString.FindSubString(enteredString, subString);
            ////Finds no. of occurences of a substring.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 8. Write a C# program to convert string to uppercase, lowercase, and title case.

            //Console.WriteLine("Enter a string.");
            //var inputString = Console.ReadLine();
            //Case.Upper(inputString);
            ////Upper case.
            //Case.Lower(inputString);
            ////Lower case.
            //Case.Title(inputString);
            ////Title case.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 9. Write a C# program to remove whitespace from a string. 

            //Console.WriteLine("Enter a string.");
            //var inputString = Console.ReadLine();
            //inputString = inputString.Replace(" ", "");
            ////Replacing whitespace with null.
            //Console.WriteLine($"String after removing whitespace: {inputString}");
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 10. Write a C# program to replace all occurrences of a substring. 

            //Console.WriteLine("Enter a string.");
            //var inputString = Console.ReadLine();
            //Console.WriteLine("Enter a substring to replace");
            //var inputSubString = Console.ReadLine();
            //inputString = inputString.Replace(inputSubString, " ");
            ////Replacing substring with white space.
            //Console.WriteLine($"String after removing substring: {inputString}");
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 11. Write a C# program to find the longest word in a sentence. 

            //Console.WriteLine("Enter a sentence.");
            //var input = Console.ReadLine();
            //Sentence.FindLongest(input);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 12. Write a C# program to count words in a sentence.

            //Console.WriteLine("Enter a sentence.");
            //var input = Console.ReadLine();
            //Sentence.CountWords(input);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 13. Write a C# program to remove duplicate characters from a string.

            //Console.WriteLine("Enter a sentence.");
            //var input = Console.ReadLine();
            //StringManipulation.RemoveDuplicate(input);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 14. Write a C# program to check if two strings are anagrams. 

            //Console.WriteLine("Enter two strings.");
            //string firstString = Console.ReadLine();
            //string secondString = Console.ReadLine();
            //Anagram.CheckAnagram(firstString, secondString);
            ////Checking if the strings are anagrams.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 15. Write a C# program to find the frequency of each character in a string.

            //Console.WriteLine("Enter a string.");
            //string input = Console.ReadLine();
            //Frequency.FindFrequency(input);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 16. Write a C# program to find the first non-repeating character in a string.

            //Console.WriteLine("Enter a string.");
            //string input = Console.ReadLine();
            //Repeating.FindFirstNonRepeating(input);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 17. Write a C# program to reverse words in a sentence. 

            //Console.WriteLine("Enter a sentence.");
            //string inputSentence = Console.ReadLine();
            //Reverse.ReverseWords(inputSentence);
            ////Reverse words in a sentence.
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//

            ////Assignment 18. Write a C# program to check if a string contains only digits.

            //Console.WriteLine("Enter a string.");
            //string inputString = Console.ReadLine();
            //Check.CheckString(inputString);
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------//
        }
    }
}
