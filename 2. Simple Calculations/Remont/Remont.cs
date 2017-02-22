using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont
{
    class Remont
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());

            var area = (((N * N) - (M * O)) / (W * L));
            var time = area * 0.2;

            Console.WriteLine(area);
            Console.WriteLine(time);

        }
    }
}
