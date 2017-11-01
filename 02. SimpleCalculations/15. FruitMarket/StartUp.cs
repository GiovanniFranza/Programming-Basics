using System;

public class StartUp
{
    public static void Main()
    {
        var costVegetable = double.Parse(Console.ReadLine());
        var costFruit = double.Parse(Console.ReadLine());
        var weightVegetable = int.Parse(Console.ReadLine());
        var weightFruit = int.Parse(Console.ReadLine());

        var priseVegetable = costVegetable * weightVegetable;
        var priseFruit = costFruit * weightFruit;

        var EUR = (priseVegetable + priseFruit) / 1.94;

        Console.WriteLine(EUR);
    }
}