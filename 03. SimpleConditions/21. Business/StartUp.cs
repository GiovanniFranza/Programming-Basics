using System;

public class StartUp
{
    public static void Main()
    {
        var needHours = int.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());

        var workHour = (days - (0.10 * days)) * 8;
        var extraWork = workers * (2 * days);
        var sum = workHour + extraWork;

        if (sum >= needHours)
        {
            Console.WriteLine("Yes!{0} hours left.", Math.Floor(sum - needHours));
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(needHours - sum));
        }
    }
}