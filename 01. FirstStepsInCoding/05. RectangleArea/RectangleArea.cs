using System;

namespace _05.RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());

            var area = a * b;

            Console.WriteLine(area);
        }
    }
}
