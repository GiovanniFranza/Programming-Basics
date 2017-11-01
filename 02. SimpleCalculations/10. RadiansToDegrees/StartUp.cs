using System;

public class StartUp
{
    public static void Main()
    {
        var rad = double.Parse(Console.ReadLine());
        var deg = ((rad * 180) / Math.PI);

        Console.WriteLine(Math.Round(deg, 0));
    }
}