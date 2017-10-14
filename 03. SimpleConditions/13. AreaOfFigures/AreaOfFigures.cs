using System;

namespace _13.AreaOfFigures
{
    public class AreaOfFigures
    {
        public static void Main()
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
