using System;

namespace _10.RadiansToDegrees
{
    public class RadiansToDegrees
    {
        public static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = ((rad * 180) / Math.PI);

            Console.WriteLine(Math.Round(deg, 0));
        }
    }
}
