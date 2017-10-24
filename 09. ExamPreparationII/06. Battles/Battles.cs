using System;

namespace _06.Battles
{
    public class Battles
    {
        public static void Main()
        {
            int pokemon1 = int.Parse(Console.ReadLine());
            int pokemon2 = int.Parse(Console.ReadLine());
            int maxBattle = int.Parse(Console.ReadLine());
            int battle = 0;

            for (int i = 1; i <= pokemon1; i++)
            {
                for (int j = 1; j <= pokemon2; j++)
                {
                    if (battle >= maxBattle)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                    battle++;
                }
            }
            Console.WriteLine();
        }
    }
}
