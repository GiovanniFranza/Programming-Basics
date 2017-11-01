using System;

public class StartUp
{
    public static void Main()
    {
        var height = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());

        var placeHeight = (height - (height % 1.20)) / 1.20;
        var placeWidth = ((width - 1) - ((width - 1) % 0.70)) / 0.70;

        var place = (placeHeight * placeWidth) - 3;

        Console.WriteLine(place);
    }
}