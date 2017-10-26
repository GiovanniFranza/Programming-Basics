using System;

namespace _01.Distance
{
    public class Distance
    {
        public static void Main()
        {
            double kph = int.Parse(Console.ReadLine());
            double firstTime = int.Parse(Console.ReadLine());
            double secondTime = int.Parse(Console.ReadLine());
            double thirdTime = int.Parse(Console.ReadLine());

            double firstLenght = kph * (firstTime / 60);
            double secondSpeed = kph + (kph * 0.10);
            double secondLenght = secondSpeed * (secondTime / 60);
            double thirdSpeed = secondSpeed - (secondSpeed * 0.05);
            double thirdLenght = thirdSpeed * (thirdTime / 60);
            double total = firstLenght + secondLenght + thirdLenght;

            Console.WriteLine("{0:F2}", total);
        }
    }
}
