using System;

namespace _18.HotelRoom
{
    public class HotelRoom
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", nights * 65);
                    Console.WriteLine("Studio: {0:F2} lv.", nights * 50);
                }
                else if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", nights * 65);
                    Console.WriteLine("Studio: {0:F2} lv.", (nights * 50) - (nights * 50) * 0.05);
                }
                else if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", (nights * 65) - (nights * 65) * 0.10);
                    Console.WriteLine("Studio: {0:F2} lv.", (nights * 50) - (nights * 50) * 0.30);
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", nights * 68.70);
                    Console.WriteLine("Studio: {0:F2} lv.", nights * 75.20);
                }
                else if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", (nights * 68.70) - (nights * 68.70) * 0.10);
                    Console.WriteLine("Studio: {0:F2} lv.", (nights * 75.20) - (nights * 75.20) * 0.20);
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", nights * 77);
                    Console.WriteLine("Studio: {0:F2} lv.", nights * 76);
                }
                else if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", (nights * 77) - (nights * 77) * 0.10);
                    Console.WriteLine("Studio: {0:F2} lv.", nights * 76);
                }
            }
        }
    }
}
