using System;

public class StartUp
{
    public static void Main()
    {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        if (age < 16)
        {
            if (gender == "f") Console.WriteLine("Miss");
            else if (gender == "m") Console.WriteLine("Master");
        }
        else
        {
            if (gender == "f") Console.WriteLine("Ms.");
            else if (gender == "m") Console.WriteLine("Mr.");
        }
    }
}