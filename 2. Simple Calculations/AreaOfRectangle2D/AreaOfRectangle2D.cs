using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle2D
{
    class AreaOfRectangle2D
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var sideA = Math.Max(x1, x2) - Math.Min(x1, x2);
            var sideB = Math.Max(y1, y2) - Math.Min(y1, y2);

            var area = sideA * sideB;
            var perimeter = (sideA + sideB) * 2;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
