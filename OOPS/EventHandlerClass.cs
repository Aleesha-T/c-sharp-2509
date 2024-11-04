using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class EventHandlerClass
    {
        public event EventHandler DetectName;
        public void NameHandler(string Name)
        {
            if(Name=="Aleesha")
            {
                DetectName?.Invoke(this,EventArgs.Empty);                
            }
        }
        public static void EventHandlerClass_DetectName(object sender, EventArgs e)
        {
            Console.WriteLine("Detected 'Aleesha'");
        }
    }
}
