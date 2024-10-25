using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class Configuration
    {
        public static string Laptop_make;
        private string wifi;
        private string theme;
        private string font;

        static Configuration() //static constructor
        {
            Laptop_make = "Lenovo";
        }

        public string Wifi
        {
            get { return wifi; }
            set {
                wifi = value; 
            }
        }
        public string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
            }
        }
        public string Font
        {
            get { return font; }
            set
            {
               font = value;
            }
        }
        public Configuration(string wifi, string theme, string font)
        {
            Wifi = wifi;
            Theme = theme;
            Font = font;
        }
        public void Display_Settings()
        {
            Console.WriteLine($"Laptop Make: {Laptop_make}, Wifi: {Wifi}, Theme: {Theme}, Font: {Font}");
        }
    }
}
