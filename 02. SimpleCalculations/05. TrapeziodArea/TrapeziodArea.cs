using System;

namespace _05.TrapeziodArea
{
    public class TrapeziodArea
    {
        public static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (b1 + b2) * h / 2;
            Console.WriteLine(area);
        }
    }
}
