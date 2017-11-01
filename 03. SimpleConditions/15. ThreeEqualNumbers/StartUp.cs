using System;

public class StartUp
{
    public static void Main()
    {
        var num1 = double.Parse(Console.ReadLine());
        var num2 = double.Parse(Console.ReadLine());
        var num3 = double.Parse(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}