using System;

public class StartUp
{
    public static void Main()
    {
        var C = double.Parse(Console.ReadLine());
        var F = C * 1.8 + 32;

        Console.WriteLine(Math.Round(F, 2));
    }
}