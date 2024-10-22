using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Print
    {
        public string PrintData(string data)
        {
            return data;
        }
        public int PrintData(int data)
        {
            return data;
        }
        public void PrintData(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]+" ");
            }
        }
    }
}
