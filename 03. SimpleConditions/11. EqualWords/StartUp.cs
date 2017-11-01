using System;

public class StartUp
{
    public static void Main()
    {
        var word1 = Console.ReadLine();
        var word2 = Console.ReadLine();

        word1 = word1.ToLower();
        word2 = word2.ToLower();

        if (word1 == word2)
        {
            Console.WriteLine("yes");
        }
        else if (word1 != word2)
        {
            Console.WriteLine("no");
        }
    }
}