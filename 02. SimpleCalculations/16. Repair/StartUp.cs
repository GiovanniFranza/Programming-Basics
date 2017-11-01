using System;

public class StartUp
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var W = double.Parse(Console.ReadLine());
        var L = double.Parse(Console.ReadLine());
        var M = int.Parse(Console.ReadLine());
        var O = int.Parse(Console.ReadLine());

        var area = (((N * N) - (M * O)) / (W * L));
        var time = area * 0.2;

        Console.WriteLine(area);
        Console.WriteLine(time);
    }
}