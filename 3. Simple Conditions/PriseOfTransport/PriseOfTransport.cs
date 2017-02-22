using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriseOfTransport
{
    class PriseOfTransport
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var partOfDay = Console.ReadLine();

            if (km < 20 && partOfDay == "day")
            {
                Console.WriteLine(0.70 + 0.79 * km);
            }
            if (km < 20 && partOfDay == "night")
            {
                Console.WriteLine(0.70 + 0.90 * km);
            }
            else if (20 <= km && km < 100)
            {
                Console.WriteLine(0.09 * km);
            }
            else if (km >= 100)
            {
                Console.WriteLine(0.06 * km);
            }
        }
    }
}
