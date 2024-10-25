using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    public class VehicleNew
    {
        public string Brand {  get; set; }  
        public VehicleNew(string brand)
        {
            Brand = brand;
        }
    }
    public class NewCar : VehicleNew
    {
        public NewCar(string brand) : base(brand)
        {
            base.Brand = brand;
        }
        public void DisplayBrand()
        {
            Console.WriteLine("Name: " + base.Brand);
        }
    }
}
