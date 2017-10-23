using System;

namespace _01.HousePrice
{
    public class HousePrice
    {
        public static void Main()
        {
            double thirdRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double price1m3 = double.Parse(Console.ReadLine());

            double bathRoom = thirdRoom / 2;
            double secondRoom = thirdRoom + thirdRoom * 0.10;
            double firstRoom = secondRoom + secondRoom * 0.10;
            double corridor = (kitchen + bathRoom + firstRoom + secondRoom + thirdRoom) * 0.05;
            double total = kitchen + bathRoom + firstRoom + secondRoom + thirdRoom + corridor;
            double price = total * price1m3;

            Console.WriteLine("{0:F2}", price);
        }
    }
}
