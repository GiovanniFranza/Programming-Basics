using System;

public class StartUp
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double foodDogKg = double.Parse(Console.ReadLine());
        double foodCatKg = double.Parse(Console.ReadLine());
        double foodFishGr = double.Parse(Console.ReadLine());

        double needDogFood = days * foodDogKg;
        double needCatFood = days * foodCatKg;
        double needFishFood = (days * foodFishGr) / 1000;
        double total = needCatFood + needDogFood + needFishFood;

        if (food >= total)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(food - total));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(total - food));
        }
    }
}