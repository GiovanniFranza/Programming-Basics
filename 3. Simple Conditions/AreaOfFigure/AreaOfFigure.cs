using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    class AreaOfFigure
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                var area = side1 * side2;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var area = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = a * h / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
