using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public interface IDriveable
    {
         void Drive();        
    }
    public interface IRaceable:IDriveable
    {
        void Race();
    }
    public class InheritClass : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("People drive");
        }

        public void Race()
        {
            Console.WriteLine("Racers race");
        }
    }
}
