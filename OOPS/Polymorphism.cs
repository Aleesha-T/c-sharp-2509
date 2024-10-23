using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Polymorphism
    {
        public string Display(string name)
        {
            return name;
        }
        public string Display(string firstname, string surname)
        {
            return firstname + " " + surname;
        }
        public string Display(string firstname, string middlename, string surname)
        {
            return firstname + " " + middlename + " " + surname;
        }
    }
}
