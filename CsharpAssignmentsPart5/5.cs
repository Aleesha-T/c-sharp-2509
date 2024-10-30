using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public class Score
    {
        public static void IncreaseScore(ref int score)
        {
            score = score + 10;
            Console.WriteLine("Score increased by ten!");
        }
    }
}
