using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var inSofia = (48 - h) * 3.0 / 4;
            var inTown = h;
            var restDay = p * (2.0 / 3);
            var sum = inSofia + inTown + restDay;

            if (year == "leap")
            {
                var playLeap = sum * 0.15;
                Console.WriteLine(Math.Truncate(sum + playLeap));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(sum));
            }
                        
        }
    }
}
