using System;

namespace _11.USDToBGN
{
    public class USDToBGN
    {
        public static void Main()
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;

            Console.WriteLine(Math.Round(BGN, 2) + " BGN");
        }
    }
}
