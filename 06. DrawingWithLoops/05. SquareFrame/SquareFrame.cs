﻿using System;

namespace _05.SquareFrame
{
    public class SquareFrame
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("| ");
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
