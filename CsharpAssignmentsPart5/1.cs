using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public class Library
    {
        public string Title { get; set; }
        public string[] Books = new string[5];
        //Single dimensional array.
        public Library(string[] books)
        {
            for(int i = 0; i < Books.Length; i++) 
            {
                Books[i] = books[i];
            }
        }
        public void Display()
        {
            Console.WriteLine("Books:");
            for (int i = 0; i < Books.Length; i++)
            {
                Console.Write($"{Books[i]}, ");
            }
            Console.WriteLine();
        }
    }
    public class Classroom
    {
        public string SeatName {  get; set; }
        public string[,] Seats = new string[2,2];
        //Multi-dimensional array.
        public Classroom(string[,] seats)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Seats[i, j] = seats[i,j];
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Seats:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{Seats[i, j]}, ");
                }
            }
        }
    }
}
