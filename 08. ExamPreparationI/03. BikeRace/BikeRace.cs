using System;

namespace _03.BikeRace
{
    public class BikeRace
    {
        public static void Main()
        {
            int young = int.Parse(Console.ReadLine());
            int old = int.Parse(Console.ReadLine());
            string road = Console.ReadLine();

            int people = young + old;

            if (road == "trail")
            {
                double taxeYoung = young * 5.50;
                double taxeOld = old * 7;
                double expenses = (taxeYoung + taxeOld) * 0.05;
                double total = taxeYoung + taxeOld - expenses;
                Console.WriteLine("{0:F2}", total);
            }
            else if (road == "cross-country")
            {
                if (people >= 50)
                {
                    double taxeYoung = young * (8 - (8 * 0.25));
                    double taxeOld = old * (9.50 - (9.50 * 0.25));
                    double expenses = (taxeYoung + taxeOld) * 0.05;
                    double total = taxeYoung + taxeOld - expenses;
                    Console.WriteLine("{0:F2}", total);
                }
                else
                {
                    double taxeYoung = young * 8;
                    double taxeOld = old * 9.50;
                    double expenses = (taxeYoung + taxeOld) * 0.05;
                    double total = taxeYoung + taxeOld - expenses;
                    Console.WriteLine("{0:F2}", total);
                }
            }
            else if (road == "downhill")
            {
                double taxeYoung = young * 12.25;
                double taxeOld = old * 13.75;
                double expenses = (taxeYoung + taxeOld) * 0.05;
                double total = taxeYoung + taxeOld - expenses;
                Console.WriteLine("{0:F2}", total);
            }
            else if (road == "road")
            {
                double taxeYoung = young * 20;
                double taxeOld = old * 21.50;
                double expenses = (taxeYoung + taxeOld) * 0.05;
                double total = taxeYoung + taxeOld - expenses;
                Console.WriteLine("{0:F2}", total);
            }
        }
    }
}
