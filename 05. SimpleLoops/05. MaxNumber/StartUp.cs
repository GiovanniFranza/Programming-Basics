using System;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var max = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine(max);
    }
}