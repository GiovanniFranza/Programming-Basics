using System;

public class StartUp
{
    public static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double priceLaundry = double.Parse(Console.ReadLine());
        int priceToy = int.Parse(Console.ReadLine());

        double money = 0;
        int toy = 0;
        int bonus = 10;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                money += bonus;
                money -= 1;
                bonus += 10;
            }
            else
            {
                toy++;
            }
        }

        int moneyToy = toy * priceToy;
        double allMoney = money + moneyToy;
        if (allMoney >= priceLaundry)
        {
            Console.WriteLine("Yes! {0:F2}", allMoney - priceLaundry);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", priceLaundry - allMoney);
        }
    }
}