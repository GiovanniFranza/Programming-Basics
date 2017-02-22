using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());
            var Z = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapes = X * Y;
            var wine = 0.40 * (grapes / 2.5);

            if (wine < Z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(Z - wine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - Z), Math.Ceiling((wine - Z) / workers));
            }
        }
    }
}
