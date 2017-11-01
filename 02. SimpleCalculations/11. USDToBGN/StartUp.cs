using System;

public class StartUp
{
    public static void Main()
    {
        var USD = double.Parse(Console.ReadLine());
        var BGN = USD * 1.79549;

        Console.WriteLine(Math.Round(BGN, 2) + " BGN");
    }
}