using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation Of dictionary
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1998, "Atal Bihari Vajpayee");
            d.Add(2014, "Narendra Modi");
            d.Add(2004, "Manmohan Singh");
            Console.WriteLine("Prime minister of 2004 : "+d[2004]);
            // Add Current Prime Minister
            d.Add(2020, "Narendra Modi");
            Console.WriteLine("\nCurrent Prime Minister : " + d[2020]);
            //Sorting dictionary
            d.OrderBy(x => x.Value);
            Console.WriteLine("\nAfter Sorting list of Prime Ministers :");
            foreach( var dict in d)
            {
                Console.WriteLine(dict.Key+" : " +dict.Value);
            }

        }
    }
}
