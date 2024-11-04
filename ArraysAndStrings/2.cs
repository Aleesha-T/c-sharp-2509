using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Sort
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        //Bubble sort.
        public static int[] InsertionSort(int[] arr)
        {
            for(int i =1;i<arr.Length;i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j]>key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
        //Insertion sort.
        public static int[] Display(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write($"{arr[k]} ");
            }
            return arr;
        }
        //Displays sorted array.
    }
}
