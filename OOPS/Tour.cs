using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //A
    public class Tour
    {
        public int TourCost()
        {
            return 10000;
        }
        public int TourDays()
        {
            return 5;
        }
        public string TourBus()
        {
            return "Varieth";
        }
    }

    //B
    public class TourPlace : Tour
    {
        public string Mysore()
        {
            return "Mysore Palace";
        }

        public string Goa()
        {
            return "Anjuna Beach, Old Goa Church, Baga Beach";
        }
        public string Bangalore()
        {
            return "Lalbagh Botanical Garden";
        }
    }

    //C
    public class Stay : TourPlace
    {
        public string Resort()
        {
            return "Dine";
        }

        public string Hotel()
        {
            return "Royal Garden";
        }
    }

    //D
    public class Entertainment : TourPlace
    {
        public void Activities()
        {
            Console.WriteLine("Rafting, sky-diving");
        }
        public void PlacestoVisit()
        {
            Console.WriteLine("Parks, temples, gardens");
        }
    }

    //E
    public class Shopping : TourPlace
    {
        public void Clothes()
        {
            Console.WriteLine("Silks");
        }
    }










}

