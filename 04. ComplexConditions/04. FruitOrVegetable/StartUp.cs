using System;

public class StartUp
{
    public static void Main()
    {
        var name = Console.ReadLine();

        if (name == "banana" || name == "apple" || name == "kiwi" || name == "cherry" || name == "lemon" || name == "grapes")
        {
            Console.WriteLine("Fruit");
        }
        else if (name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot")
        {
            Console.WriteLine("Vegetable");
        }
        else
        {
            Console.WriteLine("Unknown");
        }
    }
}