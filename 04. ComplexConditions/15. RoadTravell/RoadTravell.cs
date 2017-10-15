using System;

namespace _15.RoadTravell
{
    public class RoadTravell
    {
        public static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if (money <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer") Console.WriteLine("Camp - {0:F2}", money * 0.30);
                if (season == "winter") Console.WriteLine("Hotel - {0:F2}", money * 0.70);
            }
            if (100 < money && money <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer") Console.WriteLine("Camp - {0:F2}", money * 0.40);
                if (season == "winter") Console.WriteLine("Hotel - {0:F2}", money * 0.80);
            }
            if (money > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", money * 0.90);
            }
        }
    }
}
