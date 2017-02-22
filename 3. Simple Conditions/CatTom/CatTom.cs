using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTom
{
    class CatTom
    {
        static void Main(string[] args)
        {
            var restDay = int.Parse(Console.ReadLine());

            var workDay = 365 - restDay;
            var playTime = workDay * 63 + restDay * 127;

            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                var outTime = playTime - 30000;
                var hours = outTime / 60;
                var minutes = outTime % 60;
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                var inTime = 30000 - playTime;
                var hours = inTime / 60;
                var minutes = inTime % 60;
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
