using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class LetStudentActivityPoints : IActivityPoints
    {
        public void CalculateLeftPoints(int pointsReceived)
        {
            int leftPoints = 80 - pointsReceived;
            Console.WriteLine("Points to be achieved: "+leftPoints);
        }
    }
}
