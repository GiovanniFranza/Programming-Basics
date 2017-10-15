using System;

namespace _17.TicketForGame
{
    public class TicketForGame
    {
        public static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var VIP = 499.99;
            var Normal = 249.99;
            var moneyLeft = budjet;

            if (1 <= people && people <= 4)
            {
                moneyLeft -= budjet * 0.75;
            }
            else if (5 <= people && people <= 9)
            {
                moneyLeft -= budjet * 0.60;
            }
            else if (10 <= people && people <= 24)
            {
                moneyLeft -= budjet * 0.50;
            }
            else if (25 <= people && people <= 49)
            {
                moneyLeft -= budjet * 0.40;
            }
            else if (50 <= people)
            {
                moneyLeft -= budjet * 0.25;
            }

            if (category == "VIP")
            {
                moneyLeft -= people * VIP;
            }
            else
            {
                moneyLeft -= people * Normal;
            }

            if (budjet + moneyLeft >= budjet)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(moneyLeft));
            }
        }
    }
}
