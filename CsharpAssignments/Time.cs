using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Time
    {
        public void SetTime(int hours, int minutes)
        {
            int Hours = hours;
            int Minutes = minutes%60;
            int rem_hours=minutes/60;
            Hours += rem_hours;
            int Seconds = 0;
            Console.WriteLine($"Time is: {Pad(Hours)}:{Pad(Minutes)}:{Pad(Seconds)}");
        }

        public void SetTime(int seconds)
        {
            int Hours = seconds / 3600;
            int minutes = seconds % 3600;
            int rem_minutes= minutes % 60;
            int Minutes = minutes / 60;
            int Seconds = 0;
            Seconds += rem_minutes;
            Console.WriteLine($"Time is: {Pad(Hours)}:{Pad(Minutes)}:{Pad(Seconds)}");
        }

        //method overloading
        string Pad(int a)
        {
            string b;
            if(a<10)
            {
                b = "0" + a;
            }
            else
            {
                b = ""+a;
            }
            return b;
        }
    }
}
