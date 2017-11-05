using System;

public class StartUp
{
    public static void Main()
    {
        int hrizantemi = int.Parse(Console.ReadLine());
        int rozi = int.Parse(Console.ReadLine());
        int laleta = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string restDay = Console.ReadLine();

        double hrizantemiSS = 2.00;
        double roziSS = 4.10;
        double laletaSS = 2.50;
        double hrizantemiAW = 3.75;
        double roziAW = 4.50;
        double laletaAW = 4.15;
        double totalPrice = 0;
        int totalFlowers = hrizantemi + rozi + laleta;

        if (season == "Spring" || season == "Summer")
        {
            totalPrice = hrizantemi * hrizantemiSS + rozi * roziSS + laleta * laletaSS;
            if (restDay == "Y")
            {
                totalPrice += (totalPrice * 0.15);
            }
            if (laleta > 7 && season == "Spring")
            {
                totalPrice -= totalPrice * 0.05;
            }
            if (totalFlowers > 20)
            {
                totalPrice -= totalPrice * 0.20;
            }
            Console.WriteLine("{0:F2}", totalPrice + 2);
        }
        else if (season == "Autumn" || season == "Winter")
        {
            totalPrice = hrizantemi * hrizantemiAW + rozi * roziAW + laleta * laletaAW;
            if (restDay == "Y")
            {
                totalPrice += (totalPrice * 0.15);
            }
            if (rozi >= 10 && season == "Winter")
            {
                totalPrice -= totalPrice * 0.10;
            }
            if (totalFlowers > 20)
            {
                totalPrice -= totalPrice * 0.20;
            }
            Console.WriteLine("{0:F2}", totalPrice + 2);
        }
    }
}