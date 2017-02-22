namespace _05.AreaOfRectangle
{
    using System;

    public class AreaOfRectangle
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
