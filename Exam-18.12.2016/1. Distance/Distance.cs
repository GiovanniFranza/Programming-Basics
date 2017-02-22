using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double kph = int.Parse(Console.ReadLine());
            double firstTime = int.Parse(Console.ReadLine());
            double secondTime = int.Parse(Console.ReadLine());
            double thirdTime = int.Parse(Console.ReadLine());

            double firstLenght = kph * (firstTime / 60);
            double secondSpeed = kph + (kph * 0.10);
            double secondLenght = secondSpeed * (secondTime / 60);
            double thirdSpeed = secondSpeed - (secondSpeed * 0.05);
            double thirdLenght = thirdSpeed * (thirdTime /60);
            double total = firstLenght + secondLenght + thirdLenght;

            Console.WriteLine("{0:F2}", total);

        }
    }
}
