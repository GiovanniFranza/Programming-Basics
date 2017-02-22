using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (type == "Premiere")
            {
                var sum = r * c * 12.00;
                Console.WriteLine("{0:F2} leva", sum);
            }
            else if (type == "Normal")
            {
                var sum = r * c * 7.50;
                Console.WriteLine("{0:F2} leva", sum);
            }
            else if (type == "Discount")
            {
                var sum = r * c * 5.00;
                Console.WriteLine("{0:F2} leva", sum);
            }
        }
    }
}
