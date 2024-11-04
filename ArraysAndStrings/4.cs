using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Calculations
    {
        public static void DisplaySorted(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted array is: ");
            for(int i = 0;i<arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static double Median(int[] arr)
        {
            Array.Sort(arr);
            int mid = arr.Length / 2;
            return arr.Length % 2 != 0 ? arr[mid]:(arr[mid-1]+arr[mid])/2.0;
        }
        //Median.
        public static int Mode(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int mode = arr[0];
            int maxCount = 0;

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
                if (freq[num] > maxCount)
                {
                    maxCount = freq[num];
                    mode = num;
                }
            }
            return mode;
        }
        //Mode - Element with highest frequency
        public static void Largest(int[] arr)
        {
            int largest = arr[0];
            int secondLargest = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    int temp = largest;
                    largest = arr[i];
                    secondLargest = temp;
                }
            }
            Console.WriteLine($"Largest value is: {largest}, second largest value is: {secondLargest}");
        }
        //To find largest and second largest numbers.
        public static void Duplicates(int[] arr)
        {
            List<int> seen = new List<int>();
            List<int> duplicates = new List<int>();
            foreach (int num in arr)
            {
                if (seen.Contains(num) && !duplicates.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            Console.WriteLine("Duplicates are:");
            foreach (int num in duplicates)
            {
                Console.Write($"{num} ");
            }
        }
        //Gets duplicate values.   
    }
}
