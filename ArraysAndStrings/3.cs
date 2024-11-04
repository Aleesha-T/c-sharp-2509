using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Search
    {
        public static void LinearSearch(string item, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item.ToLower())
                {
                    Console.WriteLine("Entered fruit, " + item + " found at index: " + i);
                }
            }
        }
        //Linear Search.

        public static int BinarySearch(int number, int[] array)
        {
            Array.Sort(array);
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == number)
                {
                    return mid;
                }
                if (array[mid] < number)
                {
                    low = mid + 1;
                }
                //Ignoring first half.
                else
                {
                    high = mid - 1;
                }
                //Ignoring second half.
            }
            return -1;
        }
        //Binary Search.
    }
}
