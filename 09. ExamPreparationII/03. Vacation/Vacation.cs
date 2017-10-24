using System;

namespace _03.Vacation
{
    public class Vacation
    {
        public static void Main()
        {
            int old = int.Parse(Console.ReadLine());
            int young = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            int people = old + young;

            if (transport == "train")
            {
                if (people >= 50)
                {
                    double oldTrasport = 2 * old * (24.99 - 24.99 * 0.50);
                    double youngTransport = 2 * young * (14.99 - 14.99 * 0.50);
                    double priceNights = nights * 82.99;
                    double commision = (oldTrasport + youngTransport + priceNights) * 0.10;
                    double price = oldTrasport + youngTransport + priceNights + commision;
                    Console.WriteLine("{0:F2}", price);
                }
                else
                {
                    double oldTrasport = 2 * old * 24.99;
                    double youngTransport = 2 * young * 14.99;
                    double priceNights = nights * 82.99;
                    double commision = (oldTrasport + youngTransport + priceNights) * 0.10;
                    double price = oldTrasport + youngTransport + priceNights + commision;
                    Console.WriteLine("{0:F2}", price);
                }
            }
            else if (transport == "bus")
            {
                double oldTrasport = 2 * old * 32.50;
                double youngTransport = 2 * young * 28.50;
                double priceNights = nights * 82.99;
                double commision = (oldTrasport + youngTransport + priceNights) * 0.10;
                double price = oldTrasport + youngTransport + priceNights + commision;
                Console.WriteLine("{0:F2}", price);
            }
            else if (transport == "boat")
            {
                double oldTrasport = 2 * old * 42.99;
                double youngTransport = 2 * young * 39.99;
                double priceNights = nights * 82.99;
                double commision = (oldTrasport + youngTransport + priceNights) * 0.10;
                double price = oldTrasport + youngTransport + priceNights + commision;
                Console.WriteLine("{0:F2}", price);
            }
            else if (transport == "airplane")
            {
                double oldTrasport = 2 * old * 70.00;
                double youngTransport = 2 * young * 50.00;
                double priceNights = nights * 82.99;
                double commision = (oldTrasport + youngTransport + priceNights) * 0.10;
                double price = oldTrasport + youngTransport + priceNights + commision;
                Console.WriteLine("{0:F2}", price);
            }
        }
    }
}
