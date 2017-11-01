using System;

public class StartUp
{
    public static void Main()
    {
        var name = Console.ReadLine();

        switch (name)
        {
            case "dog": Console.WriteLine("mammal"); break;
            case "crocodile":
            case "tortoise":
            case "snake": Console.WriteLine("reptile"); break;
            default: Console.WriteLine("Unknown"); break;
        }
    }
}