using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Indexer
    {
        int[] number = new int[5];
        public int this[int index]
        { 
            get { return number[index]; } 
            set { number[index] = value; }
        }
    }
}
