using System;

public class StartUp
{
    public static void Main()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        char left = char.Parse(Console.ReadLine());

        int combination = 0;

        for (char i = start; i <= end; i++)
        {
            for (char j = start; j <= end; j++)
            {
                for (char k = start; k <= end; k++)
                {
                    if (i == left || j == left || k == left)
                    {
                        continue;
                    }
                    combination++;
                    Console.Write("{0}{1}{2} ", i, j, k);
                }
            }
        }
        Console.WriteLine(combination);
    }
}