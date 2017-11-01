using System;

public class StartUp
{
    public static void Main()
    {
        var inchs = double.Parse(Console.ReadLine());
        var centimeters = inchs * 2.54;

        Console.WriteLine(centimeters);
    }
}