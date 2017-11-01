using System;

public class StartUp
{
    public static void Main()
    {
        var h = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var r1x1 = 0;
        var r1y1 = 0;
        var r1x2 = 3 * h;
        var r1y2 = h;

        var r2x1 = h;
        var r2y1 = h;
        var r2x2 = 2 * h;
        var r2y2 = 4 * h;

        if ((x > r1x1 && x < r1x2 && y > r1y1 && y < r1y2) || (x > r2x1 && x < r2x2 && y > r2y1 && y < r2y2) || (x > h && x < (2 * h) && y == h))
        {
            Console.WriteLine("inside");
        }
        else if ((x >= r1x1 && x <= r1x2 && y == 0) || (x >= r1x1 && x <= r1x2 - 2 * h && y == h) || (x >= r1x1 + 2 * h && x <= r1x2 && y == h) || (x == 0 && y >= r1y1 && y <= r1y2) || (x == (3 * h) && y >= r1y1 && y <= r1y2))
        {
            Console.WriteLine("border");
        }
        else if ((x >= r2x1 && x <= r2x2 && y == (4 * h)) || (x == h && y >= r2y1 && y <= r2y2) || (x == (2 * h) && y >= r2y1 && y <= r2y2))
        {
            Console.WriteLine("border");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}