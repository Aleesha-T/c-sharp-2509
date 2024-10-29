using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Details
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public void ChangeValue(Details detail)
        {
            detail = new Details();
            detail.Name = "Riya";
            detail.Age = 22;
            Console.WriteLine($"Name in function: {detail.Name}, Age: {detail.Age}");
        }
    }
}
