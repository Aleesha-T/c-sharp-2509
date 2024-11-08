using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IActivityPoints
    {
        void CalculateLeftPoints(int pointsReceived);
    }
    internal class StudentActivityPoints:IActivityPoints
    {
        public void CalculateLeftPoints(int pointsReceived)
        {
            int leftPoints = 100 - pointsReceived;
            Console.WriteLine("Points to be achieved: " + leftPoints);
        }
    }
}
